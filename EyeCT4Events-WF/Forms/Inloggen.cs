using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Classes.Gebruikers;

namespace EyeCT4Events_WF
{
    public partial class Inloggen : Form
    {

        string inlog;


        public Inloggen()
        {
             

            InitializeComponent();

           
            RegistreerNieuweGebruiker RG = new RegistreerNieuweGebruiker();
            RG.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inlog = tbUser.Text;
            //string SoortAccount = DatabaseClass.LogIn(tbUser.Text, tbPass.Text);

            //if (Gebruikertype == "Beheerder")
            //{
            //    //BeheerderForm beheerder = new BeheerderForm ();
            //    //beheerder.Show(); naar het beheerdersform
            //}
            //else if (Gebruikertype == "Medewerker")
            //{
                
            //    MedewerkerForm medewerker = new MedewerkerForm();
            //    medewerker.Show();
            //}
            //else if (Gebruikertype == "Bezoeker")
            //{
            //    BezoekerForm bezoeker = new BezoekerForm();
            //    bezoeker.Show();
            //}
        }

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }

        //In de database class zit dan een read method die de gegevens ophaalt voor de login

        //public static string LogIn(string user, string wachtwoord)
        //{
        //    string oradb = @"Server = mssql.fhict.local; Database = dbi327544; User Id = dbi327544; Password = PTS16;" ; //Database connection string

        //    OracleConnection conn = new OracleConnection(oradb);

        //    try // kijk of het lukt
        //    {
        //        conn.Open(); // open de connectie
        //        OracleCommand cmd = new OracleCommand(); // nieuwe command om queries uit te voeren 
        //        cmd.Connection = conn; //zorg dat de queries naar de juiste connectie gaan
        //        cmd.CommandText = "SELECT * FROM GEBRUIER WHERE USER= :User"; // Selecteer DATA

        //        cmd.Parameters.Add(new OracleParameter("User",
        //                               OracleDbType.Varchar2,
        //                               user,
        //                               ParameterDirection.Input)); //maak de "1" referentie en zorg dat hij verwijst naar de meegegeven string Inlognaam, deze parameters meegeven werkt SQL injection tegen
        //        cmd.CommandType = CommandType.Text; // het is een SQL text command 
        //        OracleDataReader reader = cmd.ExecuteReader(); // maak een reader 
        //        if (!reader.HasRows) //zijn er rows met de query die we opgaven
        //        {
        //            MessageBox.Show("Er zijn geen gebruikers met die naam"); //nee die zijn er niet
        //            return "";
        //        }
        //        if (!wachtwoord.Equals(reader["WACHTWOORD"].ToString()))//is het wachtwoord dat we mee hebben gegeven gelijk aan de wWACHTWOORD rij in de tabel
        //        {
        //            MessageBox.Show("Verkeerd wachtwoord");  // nee dat is hij niet
        //            return "";
        //        }
        //        return reader["GEBRUIKERTYPE"].ToString(); //Ja dat is hij wel return gebruikertype
        //    }
        //    catch (OracleException oe) // mocht er iets fout gaan
        //    {
        //        MessageBox.Show(oe.Message); // wat ging er fout
        //        return ""; // het is fout gegaan return false
        //    }
        //    finally
        //    {
        //        conn.Close(); // sluit de connectie zodat hij niet voor eeuwig open blijft
        //    }
        //}
    }
}
