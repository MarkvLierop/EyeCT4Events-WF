﻿using EyeCT4Events_WF.Interfaces;
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
        //public List<Gebruiker> AanwezigeGebruikers()
        //{
        //    List<Gebruiker> aanwezigeGebruikers = new List<Gebruiker>();

        //    return aanwezigeGebruikers;
        //}
        public Gebruiker Login(string wachtwoord, string gebruikersnaam)
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
                    gebruiker.Achternaam = reader["Achternaam"].ToString();
                    gebruiker.GebruikersID = Convert.ToInt32(reader["ID"]);
                    gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                    gebruiker.Tussenvoegsel = reader["Tussenvoegsel"].ToString();
                    gebruiker.Voornaam = reader["Voornaam"].ToString();
                    gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                }

                Close();
                return gebruiker;
            }
        }
    }
}
