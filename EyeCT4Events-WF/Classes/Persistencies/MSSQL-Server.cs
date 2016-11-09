using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Interfaces;
using System.IO;
using EyeCT4Events_WF.Exceptions;
using System.Windows.Forms;

namespace EyeCT4Events_WF.Persistencies
{
    public class MSSQL_Server : ISocialMediaSharing, IGebruikerAdministratie, IKampeerplaats, IMateriaal
    {
        string connString;
        SqlCommand command;
        SqlConnection SQLcon;
        SqlDataReader reader;

        Gebruiker gebruiker;
        Categorie[] categorieArray;

        /// <summary>
        ///  Private Methods
        /// </summary>
        private void Connect()
        {
            try
            {
                this.connString = "Data Source=192.168.10.11,20;Initial Catalog=EyeCT4Events;Persist Security Info=True;User ID=sa;Password=PTS16";
                SQLcon = new SqlConnection(connString);
                SQLcon.Open();
            }
            catch (SqlException e)
            {
                throw new NoDatabaseConnectionException(e.Message);
            }
        }
        private void Close()
        {
            try
            {
                SQLcon.Close();
                SQLcon.Dispose();
            }
            catch (SqlException e)
            {
                throw new DatabaseConnectionAlreadyCloseException(e.Message);
            }
        }
        private string EncryptString(string toEncrypt)
        {
            SHA256Managed crypt = new SHA256Managed();
            System.Text.StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt), 0, Encoding.UTF8.GetByteCount(toEncrypt));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        private string BestandsTypeDefinieren (string type)
        {
            switch (type.ToLower())
            {
                case ".png":
                    type = "Afbeelding";
                    break;
                case ".jpg":
                    type = "Afbeelding";
                    break;
                case ".tiff":
                    type = "Afbeelding";
                    break;
                case ".jpeg":
                    type = "Afbeelding";
                    break;
                case ".gif":
                    type = "Afbeelding";
                    break;
                case ".bmp":
                    type = "Afbeelding";
                    break;
                case ".mp4":
                    type = "Video";
                    break;
                case ".avi":
                    type = "Video";
                    break;
                case ".wmv":
                    type = "Video";
                    break;
                case ".flv":
                    type = "Video";
                    break;
                case ".vob":
                    type = "Video";
                    break;
                case ".mpeg":
                    type = "Video";
                    break;
                case ".mpg":
                    type = "Video";
                    break;
                case ".mp3":
                    type = "Audio";
                    break;
                case ".wav":
                    type = "Audio";
                    break;
                case ".m4a":
                    type = "Audio";
                    break;
                case ".wma":
                    type = "Audio";
                    break;
                default:
                    type = "Bericht";
                    break;
            }
            return type;
        }
        private void CheckVoorSubCategorien(List<Categorie> catLijst, Categorie[] catArray, Categorie cat)
        {
            foreach (Categorie c in catLijst)
            {
                if (c.Parent == cat.ID)
                {
                    int x = 0;
                    Start:
                    if (catArray[x] == null)
                    {
                        catArray[x] = c;
                        CheckVoorSubCategorien(catLijst, catArray, c);
                    }
                    else
                    {
                        x++;
                        goto Start;
                    }
                }
            }
        }
        private decimal GetMediaVerbergThreshhold()
        {
            using (StreamReader srVerbergThreshHold = new StreamReader("Settings.txt", false))
            {
                string line = srVerbergThreshHold.ReadLine();
                string[] data = line.Split(':');
                return Convert.ToDecimal(data[data.Count() - 1]);
            }
        }

        public List<Materiaal> HaalMaterialenOp()
        {
            List<Materiaal> materialen = new List<Materiaal>();

            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE LOWER(GebruikerType) = 'bezoeker' AND Aanwezig = 1";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Materiaal materiaal = new Materiaal();

                        materiaal.MateriaalID = Convert.ToInt32(reader["ID"]);
                        materiaal.Naam = reader["Naam"].ToString();
                        materiaal.Prijs = Convert.ToInt32(reader["Prijs"]);
                        materiaal.Voorraad = Convert.ToInt32(reader["HuidigeVoorraad"]);
                    

                        materialen.Add(materiaal);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            return materialen;
        }
        private List<string> GetNietGeaccepteerdeWoorden()
        {
            List<string> nietGeaccepteerdeWoorden = new List<string>();

            using (StreamReader srVerbergThreshHold = new StreamReader("NietGeaccepteerdeWoorden.txt", false))
            {
                while (srVerbergThreshHold.ReadLine() != null)
                {
                    nietGeaccepteerdeWoorden.Add(srVerbergThreshHold.ReadLine().ToLower());
                }
            }

            return nietGeaccepteerdeWoorden;
        }
        /// <summary>
        /// Public Methods.
        /// </summary>
        /// <returns></returns>
        /// 
        #region Gebruikers
        public void Betaal(int RFID)
        {
            Connect();
            try
            {
                string query = "UPDATE Reservering SET Betaald = 1 WHERE GebruikerID = (SELECT ReserveringVerantwoordelijke FROM ReserveringGroep WHERE Gebruiker = (SELECT ID FROM Gebruiker WHERE RFID = @RFID))";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@RFID", RFID));

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public List<string> GetBetalingsGegevens(Gebruiker gebruiker)
        {
            List<string> betalingsGegevens = new List<string>();
            Connect();
            try
            {
                string query = "SELECT rg.ReserveringVerantwoordelijke, r.Betaald FROM Reservering r, ReserveringGroep rg WHERE rg.Reservering = r.ID AND rg.Gebruiker = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@ID", gebruiker.ID));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        betalingsGegevens.Add(reader["ReserveringVerantwoordelijke"].ToString());
                        betalingsGegevens.Add(reader["Betaald"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return betalingsGegevens;
        }
        public Gebruiker GetGebruikerByID(int ID)
        {
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE ID = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@ID", ID));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["GebruikerType"].ToString().ToLower() == "bezoeker")
                        {
                            gebruiker = new Bezoeker();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "beheerder")
                        {
                            gebruiker = new Beheerder();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "medewerker")
                        {
                            gebruiker = new Medewerker();
                        }
                        gebruiker.ID = Convert.ToInt32(reader["ID"]);
                        gebruiker.RFID = Convert.ToInt32(reader["RFID"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();
                        gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        gebruiker.Achternaam = reader["Achternaam"].ToString();
                        if (Convert.ToInt32(reader["Aanwezig"]) == 1)
                        {
                            gebruiker.Aanwezig = true;
                        }
                        else
                        {
                            gebruiker.Aanwezig = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return gebruiker;
        }
        public Gebruiker GetGebruikerByRFID(int RFID)
        {
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE RFID = @RFID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@RFID", RFID));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        gebruiker = new Bezoeker();
                        gebruiker.ID = Convert.ToInt32(reader["ID"]);
                        gebruiker.RFID = Convert.ToInt32(reader["RFID"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();
                        gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        gebruiker.Achternaam = reader["Achternaam"].ToString();
                        if (Convert.ToInt32(reader["Aanwezig"]) == 1)
                        {
                            gebruiker.Aanwezig = true;
                        }
                        else
                        {
                            gebruiker.Aanwezig = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return gebruiker;
        }
        public Gebruiker Inloggen(string Gebruikersnaam, string wachtwoord)
        {
            Gebruiker gebruiker = null;
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE gebruikersnaam = @Gebruiker AND Wachtwoord = @Wachtwoord";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@Gebruiker", Gebruikersnaam));
                    command.Parameters.Add(new SqlParameter("@Wachtwoord", wachtwoord));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["GebruikerType"].ToString().ToLower() == "bezoeker")
                        {
                            gebruiker = new Bezoeker();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "beheerder")
                        {
                            gebruiker = new Beheerder();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "medewerker")
                        {
                            gebruiker = new Medewerker();
                        }
                        gebruiker.ID = Convert.ToInt32(reader["ID"]);
                        gebruiker.RFID = Convert.ToInt32(reader["RFID"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();
                        gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        gebruiker.Achternaam = reader["Achternaam"].ToString();
                        if (Convert.ToInt32(reader["Aanwezig"]) == 1)
                        {
                            gebruiker.Aanwezig = true;
                        }
                        else
                        {
                            gebruiker.Aanwezig = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return gebruiker;
        }
        public void GebruikerRegistreren(Gebruiker gebruiker)
        {
            string wachtwoord = EncryptString(gebruiker.Wachtwoord);
            Connect();
            string query = "INSERT INTO Gebruiker VALUES (@RFID, @Gebruikersnaam, @Wachtwoord, @Voornaam, @Tussenvoegsel, @Achternaam, @GebruikerType, @Aanwezig)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@RFID", gebruiker.RFID));
                command.Parameters.Add(new SqlParameter("@Gebruikersnaam", gebruiker.Gebruikersnaam));
                command.Parameters.Add(new SqlParameter("@Wachtwoord", wachtwoord));
                command.Parameters.Add(new SqlParameter("@Voornaam", gebruiker.Voornaam));
                command.Parameters.Add(new SqlParameter("@Tussenvoegsel", gebruiker.Tussenvoegsel));
                command.Parameters.Add(new SqlParameter("@Achternaam", gebruiker.Achternaam));
                command.Parameters.Add(new SqlParameter("@GebruikerType", "bezoeker"));
                command.Parameters.Add(new SqlParameter("@Aanwezig", gebruiker.Aanwezig ? 1 : 0));

                command.ExecuteNonQuery();
            }
            Close();
        }
        public Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam)
        {
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE Gebruikersnaam = @GEBRUIKERSNAAM";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@GEBRUIKERSNAAM", "lieropm")); // Lieropm later aanpassen
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["GebruikerType"].ToString().ToLower() == "bezoeker")
                        {
                            gebruiker = new Bezoeker();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "beheerder")
                        {
                            gebruiker = new Beheerder();
                        }
                        else if (reader["GebruikerType"].ToString().ToLower() == "medewerker")
                        {
                            gebruiker = new Medewerker();
                        }
                        gebruiker.ID = Convert.ToInt32(reader["ID"]);
                        gebruiker.RFID = Convert.ToInt32(reader["RFID"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();
                        gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        gebruiker.Achternaam = reader["Achternaam"].ToString();
                        if (Convert.ToInt32(reader["Aanwezig"]) == 1)
                        {
                            gebruiker.Aanwezig = true;
                        }
                        else
                        {
                            gebruiker.Aanwezig = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            
            Close();
            return gebruiker;
        }
        public List<Gebruiker> LijstAanwezigePersonen()
        {
            List<Gebruiker> bezoekerLijst = new List<Gebruiker>();

            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE LOWER(GebruikerType) = 'bezoeker' AND Aanwezig = 1";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        gebruiker = new Bezoeker();
                        gebruiker.ID = Convert.ToInt32(reader["ID"]);
                        gebruiker.RFID = Convert.ToInt32(reader["RFID"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();
                        gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        gebruiker.Achternaam = reader["Achternaam"].ToString();
                        if (Convert.ToInt32(reader["Aanwezig"]) == 1)
                        {
                            gebruiker.Aanwezig = true;
                        }
                        else
                        {
                            gebruiker.Aanwezig = false;
                        }

                        bezoekerLijst.Add(gebruiker);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return bezoekerLijst;
        }
        public List<Gebruiker> GezochteBezoekersOphalen(string zoekopdracht)
        {
            string gezochtebezoeker = zoekopdracht;
            List<Gebruiker> Bezoekers = new List<Gebruiker>();
            
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE GebruikerType = 'bezoeker' AND Gebruikersnaam LIKE @gezochtebezoeker";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@gezochtebezoeker", "%" + gezochtebezoeker + "%"));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Gebruiker bezoeker = new Bezoeker();
                        bezoeker.ID = Convert.ToInt32(reader["ID"]);
                        bezoeker.Voornaam = reader["Voornaam"].ToString();
                        bezoeker.Achternaam = reader["Achternaam"].ToString();
                        bezoeker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        bezoeker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                        bezoeker.RFID = Convert.ToInt32(reader["RFID"]);
                        if ((Convert.ToInt32(reader["Aanwezig"]) == 1))
                        {
                            bezoeker.Aanwezig = true;
                        }
                        bezoeker.Aanwezig = false;
                        Bezoekers.Add(bezoeker);

                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            
            Close();
            return Bezoekers;
        }
        #endregion
        #region Media
        public List<Media> AlleMediaOpvragen()
        {
            List<Media> mediaList = new List<Media>();

            Connect();
            try
            {
                string query = "SELECT * FROM Media WHERE Flagged < @VerbergThreshhold";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@VerbergThreshhold", GetMediaVerbergThreshhold()));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Media media = new Media();
                        media.ID = Convert.ToInt32(reader["ID"]);
                        media.Beschrijving = reader["Beschrijving"].ToString();
                        media.Pad = reader["BestandPad"].ToString();
                        media.Type = reader["MediaType"].ToString();
                        media.Categorie = Convert.ToInt32(reader["Categorie"]);
                        media.Flagged = Convert.ToInt32(reader["Flagged"]);
                        media.Likes = Convert.ToInt32(reader["Likes"]);
                        media.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]);
                        mediaList.Add(media);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return mediaList;
        }
        public void SchoolAbusievelijkTaalgebruikOp()
        {
            List<Reactie> reactielijst = AlleReactiesOpvragen();
            List<Media> mediaLijst = AlleMediaOpvragen();
            List<string> nietGeaccepteerdeWoorden = GetNietGeaccepteerdeWoorden();
            foreach (Reactie r in reactielijst)
            {
                //if (r.Media == media.ID)
                //{
                //    VerwijderReactie(r);
                //}
            }
            Connect();
            try
            {
                string query = "DELETE FROM Media WHERE ID = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    //command.Parameters.Add(new SqlParameter("@ID", media.ID));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public List<Media> AlleGerapporteerdeMediaOpvragen()
        {
            List<Media> mediaList = new List<Media>();

            Connect();
            try
            {
                string query = "SELECT * FROM Media WHERE Flagged > @VerbergThreshhold";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@VerbergThreshhold", GetMediaVerbergThreshhold()));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Media media = new Media();
                        media.ID = Convert.ToInt32(reader["ID"]);
                        media.Beschrijving = reader["Beschrijving"].ToString();
                        media.Pad = reader["BestandPad"].ToString();
                        media.Type = reader["MediaType"].ToString();
                        media.Categorie = Convert.ToInt32(reader["Categorie"]);
                        media.Flagged = Convert.ToInt32(reader["Flagged"]);
                        media.Likes = Convert.ToInt32(reader["Likes"]);
                        media.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]);
                        mediaList.Add(media);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return mediaList;
        }
        public Media GetMediaByID(int ID)
        {
            Media media = null;
            Connect();
            try
            {
                string query = "SELECT * FROM Media WHERE ID = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@ID", ID));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        media.ID = Convert.ToInt32(reader["ID"]);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            return media;
        }
        public void ToevoegenMedia(Media media)
        {
            Connect();
            try
            {
                string query = "INSERT INTO Media VALUES (@GeplaatstDoor, @Categorie, @Pad, @Type, 0, 0, @Beschrijving)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@GeplaatstDoor", media.GeplaatstDoor));
                    command.Parameters.Add(new SqlParameter("@Categorie", media.Categorie));
                    command.Parameters.Add(new SqlParameter("@Pad", media.Pad));
                    command.Parameters.Add(new SqlParameter("@Type", BestandsTypeDefinieren(media.Type)));
                    command.Parameters.Add(new SqlParameter("@Beschrijving", media.Beschrijving));

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }      
        public void ToevoegenLikeInMediaOfReactie(Gebruiker gebruiker, int mediaID, int reactieID)
        {
            // INSERT +1 Like INTO Media
            if (reactieID == int.MinValue)
            {
                Connect();
                try
                {
                    string query = "UPDATE Media SET Likes= (SELECT Likes FROM Media WHERE ID = @mediaID)+1 WHERE ID = @mediaID";
                    using (command = new SqlCommand(query, SQLcon))
                    {
                        command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                        command.ExecuteNonQuery();
                    }
                    //string insert = @"INSERT INTO [Like](GebruikerID,MediaID) VALUES(@gebruikerID, @mediaID)";
                    //using (command = new SqlCommand(insert, SQLcon))
                    //{
                    //    command.Parameters.Add(new SqlParameter("@gebruikerID", 1)); // AANPASSEN ALS LOGIN WERKT gebruiker.GebruikersID
                    //    command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                    //    command.ExecuteNonQuery();
                    //}
                }
                catch (SqlException e)
                {
                    throw new FoutBijUitvoerenQueryException(e.Message);
                }
                Close();
            }
            // INSERT +1 Like INTO Reactie
            else if (mediaID == int.MinValue)
            {
                Connect();
                try
                {
                    string query = "UPDATE Reactie SET Likes= (SELECT Likes FROM Reactie WHERE ID = @reactieID)+1 WHERE ID = @reactieID";
                    using (command = new SqlCommand(query, SQLcon))
                    {
                        command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                        command.ExecuteNonQuery();
                    }
                    //string insert = "INSERT INTO [Like](GebruikerID, ReactieID) VALUES(@gebruikerID, @reactieID)";
                    //using (command = new SqlCommand(insert, SQLcon))
                    //{
                    //    command.Parameters.Add(new SqlParameter("@gebruikerID", 1)); // AANPASSEN ALS LOGIN WERKT gebruiker.GebruikersID
                    //    command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                    //    command.ExecuteNonQuery();
                    //}
                }
                catch (SqlException e)
                {
                    throw new FoutBijUitvoerenQueryException(e.Message);
                }
                
                Close();
            }
        }
        public void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID)
        {
            if (reactieID == int.MinValue)
            {
                Connect();
                try
                {
                    string query = "UPDATE Media SET Flagged= (SELECT Flagged FROM Media WHERE ID = @mediaID)+1 WHERE ID = @mediaID";
                    using (command = new SqlCommand(query, SQLcon))
                    {
                        command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    throw new FoutBijUitvoerenQueryException(e.Message);
                }
                Close();
            }
            else if (mediaID == int.MinValue)
            {
                Connect();
                try
                {
                    string query = "UPDATE Reactie SET Flagged= (SELECT Flagged FROM Reactie WHERE ID = @reactieID)+1 WHERE ID = @reactieID";
                    using (command = new SqlCommand(query, SQLcon))
                    {
                        command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    throw new FoutBijUitvoerenQueryException(e.Message);
                }
                Close();
            }
        }
        // Zoeken op CategorieID & MediaType & bestandpad
        public List<Media> ZoekenMedia(string zoekterm, int ID)
        {
            List<Media> medialist = new List<Media>();
            Connect();
            try
            {
                string query = "SELECT * FROM Media WHERE Flagged < @Threshhold AND (Categorie = @ID OR MediaType LIKE @zoekterm OR BestandPad LIKE @zoekterm)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@zoekterm", "%" + zoekterm + "%"));
                    command.Parameters.Add(new SqlParameter("@ID", ID));
                    command.Parameters.Add(new SqlParameter("@Threshhold", GetMediaVerbergThreshhold()));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Media media = new Media();
                        media.ID = Convert.ToInt32(reader["ID"]);
                        media.Beschrijving = reader["Beschrijving"].ToString();
                        media.Pad = reader["BestandPad"].ToString();
                        media.Type = reader["MediaType"].ToString();
                        media.Categorie = Convert.ToInt32(reader["Categorie"]);
                        media.Flagged = Convert.ToInt32(reader["Flagged"]);
                        media.Likes = Convert.ToInt32(reader["Likes"]);
                        media.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]);
                        medialist.Add(media);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            
            return medialist;
        }
        public void ZetAantalKerenGerapporteerdOp0(Media media)
        {
            Connect();
            try
            {
                string query = "UPDATE Media SET Flagged = 0 WHERE ID = @mediaID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@mediaID", media.ID));

                    command.ExecuteNonQuery();
                }
                Close();
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
        }
        public void VerwijderMedia(Media media)
        {
            List<Reactie> reactielijst = AlleReactiesOpvragen();
            foreach (Reactie r in reactielijst)
            {
                if (r.Media == media.ID)
                {
                    VerwijderReactie(r);
                }
            }
            Connect();
            try
            {
                string query = "DELETE FROM Media WHERE ID = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@ID", media.ID));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public Media SelectLaatstIngevoerdeMedia()
        {
            Media media = null;
            Connect();
            try
            {
                string query = "SELECT MAX(ID) maxID FROM Media";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        media = new Media();

                        if (reader["maxID"].ToString() != "NULL")
                            media.ID = Convert.ToInt32(reader["maxID"]);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            return media;
        }
        #endregion
        #region Categorie
        public Categorie[] AlleCategorienOpvragen()
        {
            List<Categorie> categorieLijst = new List<Categorie>();
            string query;
            Connect();
            try
            {
                query = "SELECT COUNT(*) 'aantalCategorien' FROM Categorie";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        categorieArray = new Categorie[Convert.ToInt32(reader["aantalCategorien"])];
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            Connect();
            try
            {
                query = "SELECT * FROM Categorie";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Categorie cat = new Categorie();
                        cat.Naam = reader["Naam"].ToString();
                        cat.ID = Convert.ToInt32(reader["ID"]);
                        cat.Parent = Convert.ToInt32(reader["ParentCategorie"]);
                        categorieLijst.Add(cat);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            
            for (int i = 0; i< categorieLijst.Count;i++)
            {
                if (!categorieArray.Contains(categorieLijst[i]))
                {
                    int a = i;
                    Start:
                    if (categorieArray[a] == null)
                    {
                        categorieArray[a] = categorieLijst[i];
                        CheckVoorSubCategorien(categorieLijst, categorieArray, categorieArray[a]);
                    }
                    else
                    {
                        a++;
                        goto Start;
                    }
                }
            }
            return categorieArray;
        }
        public void ToevoegenCategorie(Categorie cat)
        {
            Connect();
            try
            {
                string query = "INSERT INTO Categorie VALUES (@Naam, @ParentCat)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@Naam", cat.Naam));
                    command.Parameters.Add(new SqlParameter("@ParentCat", cat.Parent));

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public Categorie GetCategorieMetNaam(string naam)
        {
            Categorie cat = null;
            Connect();
            try
            {
                string query = "SELECT * FROM Categorie WHERE Naam = @naam";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@naam", naam));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cat = new Categorie();
                        cat.ID = Convert.ToInt32(reader["ID"]);
                        cat.Naam = reader["Naam"].ToString();
                        cat.Parent = Convert.ToInt32(reader["ParentCategorie"]);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            return cat;
        }

        public List<Categorie> ZoekenCategorie(string naam)
        {
            List<Categorie> catlist = new List<Categorie>();
            Connect();
            try
            {
                string query = "SELECT * FROM Categorie WHERE Naam LIKE @naam";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@naam", "%" + naam + "%"));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Categorie cat = new Categorie();
                        cat.ID = Convert.ToInt32(reader["ID"]);
                        cat.Naam = reader["Naam"].ToString();
                        cat.Parent = Convert.ToInt32(reader["ParentCategorie"]);
                        catlist.Add(cat);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();

            return catlist;
        }
        #endregion
        #region Reactie        
        public void VerwijderReactie(Reactie reactie)
        {
            Connect();
            try
            {
                string query = "DELETE FROM Reactie WHERE ID = @ID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@ID", reactie.ReactieID));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public List<Reactie> AlleReactiesOpvragen()
        {
            List<Reactie> reactieLijst = new List<Reactie>();
            Connect();
            try
            {
                string query = "SELECT * FROM Reactie";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Reactie reactie = new Reactie();
                        reactie.DatumTijd = Convert.ToDateTime(reader["DatumTijd"]);
                        reactie.Flagged = Convert.ToInt32(reader["Flagged"]);
                        reactie.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]);
                        reactie.Inhoud = reader["Inhoud"].ToString();
                        reactie.Media = Convert.ToInt32(reader["MediaID"]);
                        reactie.ReactieID = Convert.ToInt32(reader["ID"]);
                        reactieLijst.Add(reactie);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return reactieLijst;
        }
        public void ToevoegenReactie(Reactie reactie)
        {
            Connect();
            try
            {
                string query = "INSERT INTO Reactie VALUES (@geplaatstDoor, @mediaID, 0, @inhoud, @datetime, 0)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@geplaatstDoor", 1)); // Later aanpassen
                    command.Parameters.Add(new SqlParameter("@mediaID", reactie.Media));
                    command.Parameters.Add(new SqlParameter("@inhoud", reactie.Inhoud));
                    command.Parameters.Add(new SqlParameter("@datetime", DateTime.Now.ToString()));
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        #endregion
        #region Kampeer queries
        public List<Kampeerplaats> AlleKampeerplaatsenOpvragen()
        {
            List<Kampeerplaats> KampeerList = new List<Kampeerplaats>();

            Connect();
            try
            {
                string query = "SELECT * FROM Kampeerplaats";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Kampeerplaats kampeerplaats = new Kampeerplaats();

                        kampeerplaats.Type = reader["KampeerPlaatsType"].ToString();
                        kampeerplaats.ID = Convert.ToInt32(reader["ID"]);
                        kampeerplaats.MaxPersonen = Convert.ToInt32(reader["MaxPersonen"]);
                        kampeerplaats.Lawaai = Convert.ToInt32(reader["Lawaai"]);
                        kampeerplaats.Invalide = Convert.ToInt32(reader["Invalide"]);
                        kampeerplaats.Comfort = Convert.ToInt32(reader["Comfort"]);
                        KampeerList.Add(kampeerplaats);

                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return KampeerList;
        }
        public List<Kampeerplaats> KampeerplaatsenOpvragen(bool comfort, bool invalide, bool lawaai, string eigentent,
                                     string bungalow, string bungalino, string blokhut, string stacaravan, string huurtent)
        {
            List<Kampeerplaats> KampeerList = new List<Kampeerplaats>();

            Connect();
            try
            {
                string query = "SELECT * FROM KampeerPlaats k WHERE (k.Comfort = @comfort AND k.Invalide = @invalide AND k.Lawaai = @lawaai) " +
                    "AND (k.KampeerPlaatsType = @blokhut OR k.KampeerPlaatsType = @bungalino OR k.KampeerPlaatsType = @eigentent OR k.KampeerPlaatsType = @huurtent OR k.KampeerPlaatsType = @stacaravan OR k.KampeerPlaatsType = @bungalow)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@comfort", comfort));
                    command.Parameters.Add(new SqlParameter("@invalide", invalide));
                    command.Parameters.Add(new SqlParameter("@lawaai", lawaai));
                    command.Parameters.Add(new SqlParameter("@eigentent", eigentent));
                    command.Parameters.Add(new SqlParameter("@bungalow", bungalow));
                    command.Parameters.Add(new SqlParameter("@bungalino", bungalino));
                    command.Parameters.Add(new SqlParameter("@blokhut", blokhut));
                    command.Parameters.Add(new SqlParameter("@stacaravan", stacaravan));
                    command.Parameters.Add(new SqlParameter("@huurtent", huurtent));
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Kampeerplaats kampeerplaats = new Kampeerplaats();

                        kampeerplaats.Type = reader["KampeerPlaatsType"].ToString();
                        kampeerplaats.ID = Convert.ToInt32(reader["ID"]);
                        kampeerplaats.MaxPersonen = Convert.ToInt32(reader["MaxPersonen"]);
                        kampeerplaats.Lawaai = Convert.ToInt32(reader["Lawaai"]);
                        kampeerplaats.Invalide = Convert.ToInt32(reader["Invalide"]);
                        kampeerplaats.Comfort = Convert.ToInt32(reader["Comfort"]);
                        KampeerList.Add(kampeerplaats);

                    }
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return KampeerList;
        }
        public void ZetBezoekerOpAfwezig(int RFID)
        {
            Connect();
            try
            {
                string query = "UPDATE Gebruiker SET Aanwezig = 0 WHERE RFID = @RFID ";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@RFID", RFID));

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        public void ZetBezoekerOpAanwezig(int RFID)
        {
            Connect();
            try
            {
                string query = "UPDATE Gebruiker SET Aanwezig = 1 WHERE RFID = @RFID ";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@RFID", RFID));

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }
        #endregion

        #region Reserveringen
        public void ReserveringPlaatsen(int gebruikerid, int plaatsid, DateTime datumVan, DateTime datumTot)
        {

            Connect();
            string query = "INSERT INTO Reservering VALUES (@KampeerPlaats, @GebruikrID, @DatumVan, @DatumTot, @Betaling)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@KampeerPlaats", plaatsid));
                command.Parameters.Add(new SqlParameter("@GebruikrID", gebruikerid));
                command.Parameters.Add(new SqlParameter("@DatumVan", datumVan));
                command.Parameters.Add(new SqlParameter("@DatumTot", datumTot));
                command.Parameters.Add(new SqlParameter("@Betaling", 0));


                command.ExecuteNonQuery();
            }

            Close();
        }

        public Reservering HaalReserveringOpNaAanmaken(int gebruikerid, int plaatsid, DateTime datumVan, DateTime datumTot)
        {
            Reservering reservering;

            int Gebruikerid = gebruikerid;
            int Plaatsid = plaatsid;
            DateTime DatumVan = datumVan;
            DateTime DatumTot = datumTot;
            bool betaald;

            Connect();
            string query = "SELECT * FROM Reservering WHERE GebruikerID = @Gebruikerid AND KampeerPlaats = @gezochtebezoeker AND DatumVan = @DatumVan AND DatumTot = DatumTot";
            using (command = new SqlCommand(query, SQLcon))
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    int GebruikerID = Convert.ToInt32(reader["GebruikerID"]);
                    int PlaatsID = Convert.ToInt32(reader["PlaatsID"]);
                    int ID = Convert.ToInt32(reader["ID"]);
                    DateTime DatumTOT= Convert.ToDateTime(reader["DatumTot"]);
                    DateTime DatumVAN = Convert.ToDateTime(reader["DatumVan"]);
                    if (Convert.ToInt32(reader["Betaald"]) == 0)
                    {
                        betaald = false;
                        reservering = new Reservering(ID, GebruikerID, PlaatsID, DatumVAN, DatumTOT, betaald);
                        return reservering;

                    }
                    
                    else
                    {
                        betaald = true;
                        reservering = new Reservering(ID, GebruikerID, PlaatsID, DatumVAN, DatumTOT, betaald);
                        return reservering;
                    }             

                   
                }
            }
            Close();
                        
        #endregion
        #region Events
        public void ToevoegenEvent(Event ev)
        {
            Connect();
            try
            {
                string query = "INSERT INTO Event VALUES (@locatie, @datumVan, @titel, @beschrijving, @datumTot)";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@locatie", ev.Locatie));
                    command.Parameters.Add(new SqlParameter("@datumVan", ev.DatumVan));
                    command.Parameters.Add(new SqlParameter("@titel", ev.Titel));
                    command.Parameters.Add(new SqlParameter("@beschrijving", ev.Beschrijving));
                    command.Parameters.Add(new SqlParameter("@datumTot", ev.DatumTot));
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
        }

        public List<Event> AlleEventsOpvragen()
        {
            List<Event> eventList = new List<Event>();
            Connect();
            try
            {
                string query = "SELECT * FROM Event";
                using (command = new SqlCommand(query, SQLcon))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Event e = new Event();
                        e.Beschrijving = reader["Beschrijving"].ToString();
                        e.Titel = reader["Titel"].ToString();
                        e.Locatie = reader["Locatie"].ToString();
                        e.ID = Convert.ToInt32(reader["ID"]);
                        e.DatumVan = Convert.ToDateTime(reader["DatumVan"]);
                        e.DatumTot = Convert.ToDateTime(reader["DatumTot"]);
                        eventList.Add(e);
                    }
                }
                }

        public void ReserveringgroepToevoegen(int verantwoordelijke, int gebruiker, int kampeerplaats, int reservering)
        {
            Connect();
            string query = "INSERT INTO ReserveringGroep VALUES (@ReserveringsVerantwoordelijke, @Gebruiker, @Kampeerplaats, @Reservering)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@ReserveringsVerantwoordelijke", verantwoordelijke));
                command.Parameters.Add(new SqlParameter("@Gebruiker", gebruiker));
                command.Parameters.Add(new SqlParameter("@Kampeerplaats", kampeerplaats));
                command.Parameters.Add(new SqlParameter("@Reservering", reservering));


                command.ExecuteNonQuery();
            }

            Close();
        }

            
            return eventList;
        }
        #endregion

    }
}
