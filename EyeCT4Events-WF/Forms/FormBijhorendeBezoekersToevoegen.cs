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

namespace EyeCT4Events_WF.Forms
{
    public partial class FormBijhorendeBezoekersToevoegen : Form
    {
        Gebruiker medewerker;
        Gebruiker bezoeker;
        Reservering reservering;

        public FormBijhorendeBezoekersToevoegen()
        {
            InitializeComponent();
        }

        private void btnNogEenToevoegen_Click(object sender, EventArgs e)
        {
            if (tbRegAchternaam.Text != "" && tbRegVoornaam.Text != "" && tbRegGebruiker.Text != "" && tbRegWachtwoord.Text != "")
            {
                bool aanwezig = false;
                if (tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    Gebruiker bezoeker = new Bezoeker(tbRegVoornaam.Text, tbRegAchternaam.Text, tbTussenvoegsel.Text, tbRegGebruiker.Text, tbRegWachtwoord.Text, Convert.ToInt32(tbRFID.Text), aanwezig);
                    RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQL_Server());
                    rg.GebruikerRegistreren(bezoeker);


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
            if (tbRegAchternaam.Text != "" && tbRegVoornaam.Text != "" && tbRegGebruiker.Text != "" && tbRegWachtwoord.Text != "")
            {
                bool aanwezig = false;
                if (tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    Gebruiker bezoeker = new Bezoeker(tbRegVoornaam.Text, tbRegAchternaam.Text, tbTussenvoegsel.Text, tbRegGebruiker.Text, tbRegWachtwoord.Text, Convert.ToInt32(tbRFID.Text), aanwezig);
                    RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQL_Server());
                    rg.GebruikerRegistreren(bezoeker);
                    //methode voor check 
                    //MessageBox.Show("Registratie succesvol");
                    //MessageBox.Show("Regestratie niet gelukt");
                    FormReserveerMateriaal frm = new FormReserveerMateriaal(bezoeker, medewerker, reservering);
                    this.Hide();
                    frm.Show();
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
    }
}
