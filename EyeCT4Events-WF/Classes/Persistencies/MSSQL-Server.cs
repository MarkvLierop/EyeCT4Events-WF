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

namespace EyeCT4Events_WF.Persistencies
{
    public class MSSQL_Server : IGebruikerAdministratie
    {
        string connString;
        SqlCommand command;
        SqlConnection SQLcon;
        SqlDataReader reader;

        private void Connect()
        {
            SQLcon = new SqlConnection();
            connString = "Server=192.168.10.12;Database=EyeCT4Events;User Id=sa;Password=PTS16;";
            SQLcon.Open();
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
        public List<Bezoeker> LijstBezoekers()
        {
            List<Bezoeker> bezoekerLijst = new List<Bezoeker>();

            Connect();
            string query = "SELECT * FROM Gebruiker";
            using (command = new SqlCommand(query, SQLcon))
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Bezoeker bezoeker = new Bezoeker();

                    bezoeker.Voornaam = reader["Voornaam"].ToString();
                    bezoeker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();

                    bezoekerLijst.Add(bezoeker);
                }
            }
            Close();
            return bezoekerLijst;
        }
        public Gebruiker Login(string wachtwoord, string gebruikersnaam)
        {
            Gebruiker gebruiker;

            Connect();
            string query = "SELECT Gebruikersnaam, Wachtwoord FROM Gebruiker Where Gebruikersnaam = @Gebruikersnaam AND Wachtwoord = @Wachtwoord";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@Gebruikersnaam", gebruikersnaam));
                command.Parameters.Add(new SqlParameter("@Wachtwoord", EncryptString(wachtwoord)));

                while (reader.Read())
                {
                    switch (reader["GebruikerType"].ToString().ToLower())
                    {
                        case "bezoeker":
                            gebruiker = new Bezoeker();
                            break;
                        case "medewerker":
                            gebruiker = new Medewerker();
                            break;
                        case "beheerder":
                            gebruiker = new Beheerder();
                            break;
                    }
                }
                return gebruiker = new Medewerker();  /// NOG AANPASSEN
            }
        }
        private Gebruiker GebruikerDataToewijzen(Gebruiker gebruiker)
        {
            gebruiker.Achternaam = reader["Achternaam"].ToString();
            gebruiker.GebruikersID = Convert.ToInt32(reader["ID"]);
            gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
            gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
            gebruiker.Voornaam = reader["Voornaam"].ToString();
            gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();

            Close();
            return gebruiker;
        }
    }
}
