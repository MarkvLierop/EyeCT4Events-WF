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

namespace EyeCT4Events_WF
{
    partial class Gebruikergegevens : Form
    {
        Gebruiker g;   
        public Gebruikergegevens(Gebruiker g) 
        {
            InitializeComponent();
            this.g = g;
        }

        private void Gebruikergegevens_Load(object sender, EventArgs e)
        {
            tbnaam.Text = g.Voornaam;
            tbTussenvoegsel.Text = g.Tussenvoegsel;
            tbAchternaam.Text = g.Achternaam;
            tbWachtwoord.Text = g.Wachtwoord;
            
            
        }

        private void tbGebruikersnaam_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void tbnaam_TextChanged(object sender, EventArgs e)
        {// Changes the textboxs length accordingly
            if (tbnaam.Text.Length > tbnaam.Width)
            {
                tbnaam.Width += 5;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {// Changes the textboxs length accordingly
            if (tbEmail.Text.Length > tbEmail.Width)
            {
                tbEmail.Width += 5;
            }
        }

        private void tbWachtwoord_TextChanged(object sender, EventArgs e)
        {// Changes the textboxs length accordingly
            if (tbWachtwoord.Text.Length > tbWachtwoord.Width)
            {
                tbWachtwoord.Width += 5;
            }

        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            g.Voornaam = tbnaam.Text;
            g.Tussenvoegsel = tbTussenvoegsel.Text;
            g.Achternaam = tbAchternaam.Text;
            g.Wachtwoord = tbWachtwoord.Text;
            // Voeg veranderingen toe in de database
         
            
        }

        private void tbTussenvoegsel_TextChanged(object sender, EventArgs e)
        {
            if (tbTussenvoegsel.Text.Length > tbTussenvoegsel.Width)
            {
                tbnaam.Width += 5;
            }
        }

        private void tbAchternaam_TextChanged(object sender, EventArgs e)
        {
            if (tbAchternaam.Text.Length > tbAchternaam.Width)
            {
                tbnaam.Width += 5;
            }
        }

        private void btDeleteAccount_Click(object sender, EventArgs e)
        {
            //Verwijder account uit de database
           // g = null;
        }
    }
}
