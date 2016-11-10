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
using EyeCT4Events_WF.Classes.Persistencies;

namespace EyeCT4Events_WF
{
    public partial class FormRegistreerNieuweGebruiker : Form
    {
        Gebruiker medewerker;


        RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQLGebruiker());
        public FormRegistreerNieuweGebruiker()
        {
            InitializeComponent();
        }

        public FormRegistreerNieuweGebruiker(Gebruiker gebruiker)
        {
            InitializeComponent();
            medewerker = gebruiker;
        }

        private void btnBevestigRegistratie_Click(object sender, EventArgs e)
        {

            if (tbRegAchternaam.Text != "" && tbRegVoornaam.Text != "" && tbRegGebruiker.Text != "" && tbRegWachtwoord.Text != "")
            {
                bool aanwezig = false;
                if(tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    Gebruiker bezoeker = new Bezoeker();
                    bezoeker.Voornaam = tbRegVoornaam.Text;
                    bezoeker.Achternaam = tbRegAchternaam.Text;
                    bezoeker.Tussenvoegsel = tbTussenvoegsel.Text;
                    bezoeker.Gebruikersnaam = tbRegGebruiker.Text;
                    bezoeker.Wachtwoord = tbRegWachtwoord.Text;
                    bezoeker.RFID = Convert.ToInt32(tbRFID.Text);
                    bezoeker.Aanwezig = aanwezig;

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

        private void tbRegGebruiker_TextChanged(object sender, EventArgs e)
        {
            if (rg.CheckOfGebruikerBestaat(tbRegGebruiker.Text))
            {
                btnBevestigRegistratie.Enabled = false;
                lblGebruikerBestaat.Visible = true;
            }
            else
            {
                btnBevestigRegistratie.Enabled = true;
                lblGebruikerBestaat.Visible = false;
            }
        }
    }
}
