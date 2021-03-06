﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Events_WF.Persistencies;
using EyeCT4Events_WF.Exceptions;
using System.Data.SqlClient;
using EyeCT4Events_WF.Interfaces;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes.Interfaces;
using System.Security.Cryptography;
using System.IO;

namespace EyeCT4Events_WF.Classes.Persistencies
{
    class MSSQLGebruiker : MSSQL_Server, IGebruikerAdministratie
    {
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
        
        // Public Methods.
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
        public List<Gebruiker> GesorteerdeGeberuikers(string filter)
        {
            List<Gebruiker> gebruikersLijst = new List<Gebruiker>();
            string query = "";
            if (filter == "ID")
            {
                query = "SELECT * FROM Gebruiker";
            }
            else if (filter == "Naam")
            {
                query = "SELECT * FROM Gebruiker ORDER BY Voornaam";
            }
            else if (filter == "GebruikerType")
            {
                query = "SELECT * FROM Gebruiker ORDER BY GebruikerType, Voornaam ASC";
            }
            else if (filter == "Aanwezig")
            {
                query = "SELECT * FROM Gebruiker where Aanwezig = 1";
            }
            else if (filter == "Hoofd Reserveerder")
            {
                query = "SELECT * From Gebruiker Where ID IN (Select DISTINCT(ReserveringVerantwoordelijke) FROM ReserveringGroep)";
            }
            else
            {
                query = "SELECT * FROM Gebruiker";
            }
            Connect();
            using (command = new SqlCommand(query, SQLcon))
            {
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
                    gebruikersLijst.Add(gebruiker);

                }
            }
            return gebruikersLijst;
        }
        public List<Gebruiker> ZoekenGebruiker(string GezochtenNaam)
        {
            List<Gebruiker> gebruikersLijst = new List<Gebruiker>();
            Connect();
            string query = "Select * FROM Gebruiker WHERE Voornaam LIKE @txtZoeken";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@txtZoeken", "%" + GezochtenNaam + "%"));
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
                    gebruikersLijst.Add(gebruiker);

                }
            }
            return gebruikersLijst;
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
                    command.Parameters.Add(new SqlParameter("@Wachtwoord", EncryptString(wachtwoord)));
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

                        if (reader["RFID"].GetType() != typeof(DBNull))
                            gebruiker.RFID = Convert.ToInt32(reader["RFID"]);

                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();

                        if (reader["Tussenvoegsel"].GetType() != typeof(DBNull))
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
        public bool CheckOfGebruikerBestaat(string gebruikersnaam)
        {
            bool gebruikerBestaat = false;
            Connect();
            try
            {
                string query = "SELECT * FROM Gebruiker WHERE gebruikersnaam = @Gebruiker";
                using (command = new SqlCommand(query, SQLcon))
                {
                    command.Parameters.Add(new SqlParameter("@Gebruiker", gebruikersnaam));
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

                        if (reader["RFID"].GetType() != typeof(DBNull))
                            gebruiker.RFID = Convert.ToInt32(reader["RFID"]);

                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Voornaam = reader["Voornaam"].ToString();

                        if (reader["Tussenvoegsel"].GetType() != typeof(DBNull))
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
                        gebruikerBestaat = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new FoutBijUitvoerenQueryException(e.Message);
            }
            Close();
            return gebruikerBestaat;
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
                command.Parameters.Add(new SqlParameter("@GebruikerType", gebruiker.GetGebruikerType()));
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
            catch (Exception e)
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
    }

}
