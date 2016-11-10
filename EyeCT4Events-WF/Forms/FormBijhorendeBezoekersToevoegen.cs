using EyeCT4Events_WF.Classes;
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
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;
using EyeCT4Events_WF.Classes.Persistencies;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormBijhorendeBezoekersToevoegen : Form
    {
        Gebruiker medewerker;
        Gebruiker verantwoordelijke;
        Reservering reservering;
        Kampeerplaats kampeerplaats;

        public FormBijhorendeBezoekersToevoegen()
        {
            InitializeComponent();
        }

        public FormBijhorendeBezoekersToevoegen(Gebruiker Medewerker, Gebruiker Bezoeker, Reservering Reservering, Kampeerplaats Kampeerplaats)
        {
            InitializeComponent();

            medewerker = Medewerker;
            verantwoordelijke = Bezoeker;
            reservering = Reservering;
            kampeerplaats = Kampeerplaats;
        }

        private void btnNogEenToevoegen_Click(object sender, EventArgs e)
        {
            if (tbRegAchternaam.Text != "" && tbRegVoornaam.Text != "" && tbRegGebruiker.Text != "" && tbRegWachtwoord.Text != "")
            {
                bool aanwezig = false;
                if (tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    Gebruiker bijhorendebezoeker = new Bezoeker();
                   
                    bijhorendebezoeker.Voornaam = tbRegVoornaam.Text;
                    bijhorendebezoeker.Achternaam = tbRegAchternaam.Text;
                    bijhorendebezoeker.Tussenvoegsel = tbTussenvoegsel.Text;
                    bijhorendebezoeker.Gebruikersnaam = tbRegGebruiker.Text;
                    bijhorendebezoeker.Wachtwoord = tbRegWachtwoord.Text;
                    bijhorendebezoeker.RFID = Convert.ToInt32(tbRFID.Text);
                    bijhorendebezoeker.Aanwezig = aanwezig;

                    RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQLGebruiker());
                    rg.GebruikerRegistreren(bijhorendebezoeker);

                    MessageBox.Show("Gebruiker Toegevoegd");
                    tbRegAchternaam.Clear();
                    tbRegBevestigWachtwoord.Clear();
                    tbRegGebruiker.Clear();
                    tbRegVoornaam.Clear();
                    tbRegWachtwoord.Clear();
                    tbRFID.Clear();
                    tbTussenvoegsel.Clear();
                    //methode voor check 
                    //MessageBox.Show("Registratie succesvol");
                    //MessageBox.Show("Regestratie niet gelukt");

                    bijhorendebezoeker = rg.GetGebruikerByGebruikersnaam(bijhorendebezoeker.Gebruikersnaam);

                    int verantwoordelijkeid = verantwoordelijke.ID;
                    int reserveringid = reservering.ReserveringID;
                    int plaatsid = kampeerplaats.ID;
                    int bijhorendebezoekerid = bijhorendebezoeker.ID;

                    RepositoryKampeerPlaatsen rkp = new RepositoryKampeerPlaatsen(new MSSQLReserveren());
                    rkp.ReserveringgroepToevoegen(verantwoordelijkeid, bijhorendebezoekerid, plaatsid, reserveringid);
                    MessageBox.Show("Gebruiker toegevoegd aan reservering");
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
         
        

        private void btnNaarMateriaal_Click(object sender, EventArgs e)
        {
           
            FormReserveerMateriaal frm = new FormReserveerMateriaal(verantwoordelijke, medewerker, reservering);
            this.Hide();
            frm.Show();
        }
    }
}
