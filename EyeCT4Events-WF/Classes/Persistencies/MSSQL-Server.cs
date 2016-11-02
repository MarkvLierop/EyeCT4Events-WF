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

namespace EyeCT4Events_WF.Persistencies
{
    public class MSSQL_Server : ISocialMediaSharing, IGebruikerAdministratie, IKampeerplaats
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
            SQLcon.Close();
            SQLcon.Dispose();
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
        private Gebruiker GetGebruikerByID(int ID)
        {
            Connect();
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
                    gebruiker.GebruikersID = Convert.ToInt32(reader["ID"]);
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
            Close();
            return gebruiker;
        }

        /// <summary>
        /// Public Methods.
        /// </summary>
        /// <returns></returns>
        /// 
        #region Gebruikers
        public Gebruiker GebruikerLogin(string wachtwoord, string gebruikersnaam)
        {
            Connect();
            string query = "SELECT Gebruikersnaam, Wachtwoord FROM Gebruiker WHERE Gebruikersnaam = @Gebruikersnaam AND Wachtwoord = @Wachtwoord";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@Gebruikersnaam", gebruikersnaam));
                command.Parameters.Add(new SqlParameter("@Wachtwoord", wachtwoord));

                while (reader.Read())
                {
                    //GebruikerDataToewijzen(gebruiker);
                }

                Close();
                return gebruiker;
            }
        }
        public bool Inloggen(string Gebruikersnaam, string wachtwoord)
        {
            Connect();
            string query = "SELECT * FROM Gebruiker WHERE gebruikersnaam = @GEBRUIKERSNAAM";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@GEBRUIKERSNAAM", Gebruikersnaam));
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.HasRows)
                    {
                        Close();
                        return false;
                    }

                    else if (!wachtwoord.Equals(reader["Wachtwoord"].ToString()))
                    {
                        Close();
                        return false;
                    }


                }
            }
            Close();
            return true;
        }
        public void GebruikerRegistreren(Gebruiker gebruiker)
        {
            Connect();
            string query = "INSERT INTO Gebruiker VALUES (@RFID, @Gebruikersnaam, @Wachtwoord, @Voornaam, @Tussenvoegsel, @Achternaam, @GebruikerType, @Aanwezig)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@RFID", gebruiker.RFID));
                command.Parameters.Add(new SqlParameter("@Gebruikersnaam", gebruiker.Gebruikersnaam));
                command.Parameters.Add(new SqlParameter("@Wachtwoord", EncryptString(gebruiker.Wachtwoord)));
                command.Parameters.Add(new SqlParameter("@Voornaam", gebruiker.Voornaam));
                command.Parameters.Add(new SqlParameter("@Tussenvoegsel", gebruiker.Tussenvoegsel));
                command.Parameters.Add(new SqlParameter("@Achternaam", gebruiker.Achternaam));
                command.Parameters.Add(new SqlParameter("@GebruikerType", gebruiker.GetType().ToString()));
                command.Parameters.Add(new SqlParameter("@Aanwezig", gebruiker.Aanwezig ? 1 : 0));

                command.ExecuteNonQuery();
            }
            Close();
        }
        public Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam)
        {
            Connect();
            string query = "SELECT * FROM Gebruiker WHERE Gebruikersnaam = @GEBRUIKERSNAAM";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@GEBRUIKERSNAAM", gebruikersnaam));
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
                    gebruiker.GebruikersID = Convert.ToInt32(reader["ID"]);
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
            Close();
            return gebruiker;
        }
        public List<Gebruiker> LijstAanwezigePersonen()
        {
            List<Gebruiker> bezoekerLijst = new List<Gebruiker>();

            Connect();
            string query = "SELECT * FROM Gebruiker WHERE GebruikerType = 'bezoeker'";
            using (command = new SqlCommand(query, SQLcon))
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gebruiker = new Bezoeker();
                    //GebruikerDataToewijzen(gebruiker);

                    bezoekerLijst.Add(gebruiker);
                }
            }
            Close();
            return bezoekerLijst;
        }
        #endregion
        #region Media
        public List<Media> AlleMediaOpvragen()
        {
            List<Media> mediaList = new List<Media>();

            Connect();
            string query = "SELECT * FROM Media";
            using (command = new SqlCommand(query, SQLcon))
            {
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
                    media.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]).ToString();
                    mediaList.Add(media);
                }
            }
            Close();

            foreach (Media m in mediaList)
            {
                m.GeplaatstDoor = GetGebruikerByID(Convert.ToInt32(m.GeplaatstDoor)).ToString();
            }

            return mediaList;
        }
        public Media GetMediaByID(int ID)
        {
            Media media = null;
            Connect();
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
            Close();

            return media;
        }
        public void ToevoegenMedia(Media media)
        {
            Connect();
            string query = "INSERT INTO Media VALUES (@GeplaatstDoor, @Categorie, @Pad, @Type, 0, 0, @Beschrijving)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@GeplaatstDoor", 1)); // media.GeplaatstDoor   AAANPASSEN ALS INLOGGEN WERKT.
                command.Parameters.Add(new SqlParameter("@Categorie", media.Categorie));
                command.Parameters.Add(new SqlParameter("@Pad", media.Pad));
                command.Parameters.Add(new SqlParameter("@Type", BestandsTypeDefinieren(media.Type)));
                command.Parameters.Add(new SqlParameter("@Beschrijving", media.Beschrijving));

                command.ExecuteNonQuery();
            }
            Close();
        }      
        public void ToevoegenLikeInMediaOfReactie(Gebruiker gebruiker, int mediaID, int reactieID)
        {
            // INSERT +1 Like INTO Media
            if (reactieID == int.MinValue)
            {
                Connect();
                string query = "UPDATE Media SET Likes= (SELECT Likes FROM Media WHERE ID = @mediaID)+1 WHERE ID = @mediaID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                    command.ExecuteNonQuery();
                }
                string insert = @"INSERT INTO [Like](GebruikerID,MediaID) VALUES(@gebruikerID, @mediaID)";
                using (command = new SqlCommand(insert, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@gebruikerID", 1)); // AANPASSEN ALS LOGIN WERKT gebruiker.GebruikersID
                    command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                    command.ExecuteNonQuery();
                }
                Close();
            }
            // INSERT +1 Like INTO Reactie
            else if (mediaID == int.MinValue)
            {
                Connect();
                string query = "UPDATE Reactie SET Likes= (SELECT Likes FROM Reactie WHERE ID = @reactieID)+1 WHERE ID = @reactieID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                    command.ExecuteNonQuery();
                }
                string insert = "INSERT INTO [Like](GebruikerID, ReactieID) VALUES(@gebruikerID, @reactieID)";
                using (command = new SqlCommand(insert, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@gebruikerID", 1)); // AANPASSEN ALS LOGIN WERKT gebruiker.GebruikersID
                    command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                    command.ExecuteNonQuery();
                }
                Close();
            }
        }
        public void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID)
        {
            if (reactieID == int.MinValue)
            {
                Connect();
                string query = "UPDATE Media SET Flagged= (SELECT Flagged FROM Media WHERE ID = @mediaID)+1 WHERE ID = @mediaID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@mediaID", mediaID));

                    command.ExecuteNonQuery();
                }
                Close();
            }
            else if (mediaID == int.MinValue)
            {
                Connect();
                string query = "UPDATE Reactie SET Flagged= (SELECT Flagged FROM Reactie WHERE ID = @reactieID)+1 WHERE ID = @reactieID";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@reactieID", reactieID));

                    command.ExecuteNonQuery();
                }
                Close();
            }
        }
        public List<Media> ZoekenMedia(string zoekterm)
        {
            List<Media> medialist = new List<Media>();
            Connect();
            string query = "SELECT * FROM Media WHERE GeplaatstDoor LIKE(SELECT ID FROM Gebruiker WHERE Voornaam Like @zoekterm OR Tussenvoegsel Like @zoekterm OR Achternaam LIKE @zoekterm) OR MediaType LIKE @zoekterm";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@zoekterm", "%" + zoekterm + "%"));
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
                    media.GeplaatstDoor = Convert.ToInt32(reader["GeplaatstDoor"]).ToString();
                    medialist.Add(media);
                }
            }
            Close();

            foreach (Media m in medialist)
            {
                m.GeplaatstDoor = GetGebruikerByID(Convert.ToInt32(m.GeplaatstDoor)).ToString();
            }
            return medialist;
        }
        #endregion
        #region Categorie
        public List<Categorie> AlleCategorienOpvragen()
        {
            List<Categorie> categorieLijst = new List<Categorie>();

            Connect();
            string query = "SELECT COUNT(*) 'aantalCategorien' FROM Categorie";
            using (command = new SqlCommand(query, SQLcon))
            {
                reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    categorieArray = new Categorie[Convert.ToInt32(reader["aantalCategorien"])];
                }
            }
            Close();

            Connect();
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
            Close();

            for (int i = 0; i < categorieLijst.Count; i++)
            {
                if (!categorieArray.Contains(categorieLijst[i]))
                {
                    int w = i;
                    Start3:
                    if (categorieArray[w] == null)
                    {
                        categorieArray[w] = categorieLijst[i];
                    }
                    else
                    {
                        w++;
                        goto Start3;
                    }
                }
                foreach (Categorie c in categorieLijst)
                {
                    if (categorieLijst[i].ID == c.Parent)
                    {
                        int b = i;
                        Start:
                        if (categorieArray[b] == null)
                        {
                            if (!categorieArray.Contains(c))
                            {
                                int a = b;
                                Start2:
                                if (categorieArray[a] == null)
                                {
                                    categorieArray[a] = c;
                                }
                                else
                                {
                                    a++;
                                    goto Start2;
                                }
                            }
                        }
                        else 
                        {
                            b++;
                            goto Start;                            
                        }
                    }
                }
            }
            Categorie[] ar = categorieArray;
            return categorieLijst;
        }
        public void ToevoegenCategorie(Categorie cat)
        {
            Connect();
            string query = "INSERT INTO Categorie VALUES (@Naam, @ParentCat)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@Naam", cat.Naam));
                command.Parameters.Add(new SqlParameter("@ParentCat", cat.Parent));

                command.ExecuteNonQuery();
            }
            Close();
        }

        public Categorie GetCategorieMetNaam(string naam)
        {
            Categorie cat = null;
            Connect();
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
            Close();

            return cat;
        }

        public List<Categorie> ZoekenCategorie(string naam)
        {
            List<Categorie> catlist = new List<Categorie>();
            Connect();
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
            Close();

            return catlist;
        }
        #endregion

        #region Kampeer queries

        public List<Kampeerplaats> AlleKampeerplaatsenOpvragen()
        {
            List<Kampeerplaats> KampeerList = new List<Kampeerplaats>();

            Connect();
            string query = "SELECT * FROM Kampeerplaats";
            using (command = new SqlCommand(query, SQLcon))
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Kampeerplaats kampeerplaats = new Kampeerplaats();

                    kampeerplaats.Type = reader["KampeerPlaatsType"].ToString();
                    kampeerplaats.PlaatsID = Convert.ToInt32(reader["ID"]);
                    kampeerplaats.MaxPersonen = Convert.ToInt32(reader["MaxPersonen"]);
                    kampeerplaats.Lawaai = Convert.ToInt32(reader["Lawaai"]);
                    kampeerplaats.Invalide = Convert.ToInt32(reader["Invalide"]);
                    kampeerplaats.Comfort = Convert.ToInt32(reader["Comfort"]);
                    KampeerList.Add(kampeerplaats);

                }
            }
            Close();
            return KampeerList;
        }
        #endregion

    }
}
