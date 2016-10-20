using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EyeCT4Events_WF.Classes.Gebruikers;

namespace EyeCT4Events_WF.Persistencies
{
    class MSSQL_Server : IGebruikerAdministratie
    {
        string connString;
        SqlCommand command;
        SqlDataReader reader;

        private void Connect()
        {
            connString = "Data Source=192.168.10.11,20;Network Library = DBMSSOCN; Initial Catalog = EyeCT4Events; User ID = sa; Password = PTS16";
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
        public void AlleBezoekersOpvragen()
        {
            List<Bezoeker> bezoekerLijst = new List<Bezoeker>();

            Connect();
            using (SqlConnection SQLcon = new SqlConnection(connString))
            {
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
            }
        }
        public void RegistreerBezoeker()
        {
            Connect();
            using (SqlConnection SQLcon = new SqlConnection(connString))
            {
                //string query = "Insert into db (Gebruikersnaam,wachtwoord,voornaam,tussenvoegsel,achternaam,type)values('" +
                   
            }
        }
    }
}
