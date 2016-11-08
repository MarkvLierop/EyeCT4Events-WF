using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;
using EyeCT4Events_WF.Classes.Gebruikers;

namespace EyeCT4Events_WF
{
    public partial class FormRegistreerNieuweGebruiker : Form
    {
        Gebruiker medewerker;


        public FormRegistreerNieuweGebruiker()
        {
            InitializeComponent();
        }

        public FormRegistreerNieuweGebruiker(Gebruiker gebruiker)
        {
            medewerker = gebruiker;
        }

        private void btnBevestigRegistratie_Click(object sender, EventArgs e)
        {

            if (tbRegAchternaam.Text != "" && tbRegVoornaam.Text != "" && tbRegGebruiker.Text != "" && tbRegWachtwoord.Text != "")
            {
                bool aanwezig = false;
                if(tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    Gebruiker bezoeker = new Bezoeker(tbRegVoornaam.Text, tbRegAchternaam.Text, tbTussenvoegsel.Text, tbRegGebruiker.Text, tbRegWachtwoord.Text, Convert.ToInt32(tbRFID.Text), aanwezig);
                    RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQL_Server());
                    rg.GebruikerRegistreren(bezoeker);
                    bezoeker = rg.GetGebruikerByGebruikersnaam(tbRegGebruiker.Text);
                    //methode voor check 
                    //MessageBox.Show("Registratie succesvol");
                    //MessageBox.Show("Regestratie niet gelukt");
                    FormReserveerPlaats frp = new FormReserveerPlaats(medewerker, bezoeker);
                    this.Hide();
                    frp.Show();
                }

                
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }
               
            }

            else
            {
                MessageBox.Show("Vul alle velden in");

              
            }    
        }

        private void RegistreerNieuweGebruiker_Load(object sender, EventArgs e)
        {

        }
    }
}
