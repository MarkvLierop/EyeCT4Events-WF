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
                if(tbRegBevestigWachtwoord.Text == tbRegWachtwoord.Text)
                {
                    //Administration admin = new Administration();
                    //bool gelukt = admin.MaakBezoeker(tbRegAchternaam.Text, tbRegVoornaam.Text, tbRegGebruiker.Text, tbRegWachtwoord.Text);

                    //if (gelukt)
                    //{
                    //    MessageBox.Show("Registratie succesvol");
                    //}
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
