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

namespace EyeCT4Events_WF.Persistencies
{
    public class MSSQL_Server : ISocialMediaSharing, IGebruikerAdministratie 
    {
        string connString;
        SqlCommand command;
        SqlConnection SQLcon;
        SqlDataReader reader;

        Gebruiker gebruiker;

        private void Connect()
        {
            this.connString = "Data Source=192.168.10.12,20;Initial Catalog=EyeCT4Events;Persist Security Info=True;User ID=sa;Password=PTS16";
            SQLcon = new SqlConnection(connString);
            SQLcon.Open();
        }
        private void Close()
        {
            SQLcon.Close();
            SQLcon.Dispose();
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
                    GebruikerDataToewijzen(gebruiker);

                    bezoekerLijst.Add(gebruiker);
                }
            }
            Close();
            return bezoekerLijst;
        }
        public Gebruiker GebruikerLogin(string wachtwoord, string gebruikersnaam)
        {
            Connect();
            string query = "SELECT Gebruikersnaam, Wachtwoord FROM Gebruiker Where Gebruikersnaam = @Gebruikersnaam AND Wachtwoord = @Wachtwoord";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@Gebruikersnaam", gebruikersnaam));
                command.Parameters.Add(new SqlParameter("@Wachtwoord", wachtwoord));

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
                    GebruikerDataToewijzen(gebruiker);
                }

                Close();
                return gebruiker;
            }
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
                command.Parameters.Add(new SqlParameter("@GebruikerType", gebruiker.GebruikerType));
                command.Parameters.Add(new SqlParameter("@Aanwezig", gebruiker.Aanwezig ? 1 : 0));

                command.ExecuteNonQuery();
            }
            Close();
        }
        private void GebruikerDataToewijzen(Gebruiker gebruiker)
        {
            gebruiker.Achternaam = reader["Achternaam"].ToString();
            gebruiker.GebruikersID = Convert.ToInt32(reader["ID"]);
            gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
            gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
            gebruiker.Voornaam = reader["Voornaam"].ToString();
            gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
            if (Convert.ToInt32(reader["Aanwezig"]) == 1)
            {
                gebruiker.Aanwezig = true;
            }
            else
            {
                gebruiker.Aanwezig = false;
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

        public List<Categorie> GetAlleCategorien()
        {
            List<Categorie> categorieLijst = new List<Categorie>();

            Connect();
            string query = "SELECT DISTINCT(c.Naam), c.ID, c.ParentCategorie, Categorie.ID 'ID2', Categorie.Naam 'N2', Categorie.ParentCategorie 'P2' FROM Categorie c LEFT JOIN Categorie ON c.ID = Categorie.ParentCategorie WHERE c.ParentCategorie = 0";
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

                    if (!string.IsNullOrEmpty(reader["ID2"].ToString()))
                    {
                        cat = new Categorie();
                        cat.ID = Convert.ToInt32(reader["ID2"]);
                        cat.Naam = reader["N2"].ToString();
                        cat.Parent = Convert.ToInt32(reader["P2"]);
                        categorieLijst.Add(cat);
                    }
                }
            }
            Close();

            // Dubbele verwijderen
            //List<Categorie> tempList = new List<Categorie>();
            //foreach (Categorie c in categorieLijst)
            //{
            //    if (!tempList.Contains(c).)
            //    {
            //        tempList.Add(c);
            //    }
            //}
            return categorieLijst;
        }
        public void CategorieToevoegen(Categorie cat)
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
    }
}
