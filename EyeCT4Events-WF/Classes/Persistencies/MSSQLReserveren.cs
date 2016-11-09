using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Interfaces;
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Persistencies;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Persistencies
{
    class MSSQLReserveren : MSSQL_Server, IKampeerplaats , IMateriaal
    {
        string connString;
        SqlCommand command;
        SqlConnection SQLcon;
        SqlDataReader reader;

        Gebruiker gebruiker;
        Categorie[] categorieArray;

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
        public List<Kampeerplaats> KampeerplaatsenOpvragen(int comfort, int invalide, int lawaai, string eigentent,
                                     string bungalow, string bungalino, string blokhut, string stacaravan, string huurtent)
        {
            List<Kampeerplaats> KampeerList = new List<Kampeerplaats>();

            Connect();
            try
            {
                string query = "SELECT * FROM KampeerPlaats k WHERE k.Comfort = @comfort AND k.Invalide = @invalide AND k.Lawaai = @lawaai AND (k.KampeerPlaatsType = @eigentent OR k.KampeerPlaatsType = @bungalow OR k.KampeerPlaatsType = @bungalino OR k.KampeerPlaatsType = @blokhut OR k.KampeerPlaatsType = @stacaravan OR k.KampeerPlaatsType = @huurtent);";
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
                        kampeerplaats.Locatie = Convert.ToInt32(reader["Locatie"]);
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

        
        public void ReserveringPlaatsen(int gebruikerid, int plaatsid, DateTime datumVan, DateTime datumTot)
        {
            int userid = gebruikerid;
            int id = plaatsid;
            DateTime dvan = datumVan;
            DateTime dtot = datumTot;

            Connect();
            string query = "INSERT INTO Reservering VALUES (@KampeerPlaats, @GebruikrID, @DatumVan, @DatumTot, @Betaling)";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@KampeerPlaats", id));
                command.Parameters.Add(new SqlParameter("@GebruikrID", userid));
                command.Parameters.Add(new SqlParameter("@DatumVan", dvan));
                command.Parameters.Add(new SqlParameter("@DatumTot", dtot));
                command.Parameters.Add(new SqlParameter("@Betaling", false));


                command.ExecuteNonQuery();
            }

            Close();
        }

        public Reservering HaalReserveringOpNaAanmaken(int gebruikerid, int plaatsid, DateTime datumVan, DateTime datumTot)
        {
            Reservering reservering = new Reservering();

            int Gebruikerid = gebruikerid;
            int Plaatsid = plaatsid;
            DateTime DatumVan = datumVan;
            DateTime DatumTot = datumTot;
            bool betaald;

            Connect();
            string query = "SELECT * FROM Reservering WHERE GebruikerID = @Gebruikerid AND KampeerPlaats = @Plaatsid AND DatumVan = @DatumVan AND DatumTot = @DatumTot";
            using (command = new SqlCommand(query, SQLcon))
            {
                command.Parameters.Add(new SqlParameter("@Gebruikerid", Gebruikerid));
                command.Parameters.Add(new SqlParameter("@Plaatsid", Plaatsid));
                command.Parameters.Add(new SqlParameter("@DatumVan", DatumVan));
                command.Parameters.Add(new SqlParameter("@DatumTot", DatumTot));

                reader = command.ExecuteReader();


                while (reader.Read())
                {

                    int GebruikerID = Convert.ToInt32(reader["GebruikerID"]);
                    int PlaatsID = Convert.ToInt32(reader["KampeerPlaats"]);
                    int ID = Convert.ToInt32(reader["ID"]);
                    DateTime DatumTOT = Convert.ToDateTime(reader["DatumTot"]);
                    DateTime DatumVAN = Convert.ToDateTime(reader["DatumVan"]);
                    if ((bool)(reader["Betaald"]) == false)
                    {
                        betaald = false;


                        reservering.ReserveringID = ID;
                        reservering.BezoekerID = GebruikerID;
                        reservering.KampeerplaatsID = PlaatsID;
                        reservering.DatumVan = DatumVAN;
                        reservering.DatumTot = DatumTOT;
                        reservering.Betaald = betaald;

                    }

                    else
                    {

                        betaald = true;

                        reservering.ReserveringID = ID;
                        reservering.BezoekerID = GebruikerID;
                        reservering.KampeerplaatsID = PlaatsID;
                        reservering.DatumVan = DatumVAN;
                        reservering.DatumTot = DatumTOT;
                        reservering.Betaald = betaald;
                    }


                }


            }

            Close();
            return reservering;

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
    }
}
