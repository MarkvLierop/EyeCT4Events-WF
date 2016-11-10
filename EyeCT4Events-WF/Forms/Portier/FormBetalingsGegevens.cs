using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Persistencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events_WF.Forms.BeheerSysteem
{
    public partial class FormBetalingsGegevens : Form
    {
        private RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQLGebruiker());
        public FormBetalingsGegevens()
        {
            InitializeComponent();
        }

        private void txtAanmelden_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rg.ZetGebruikerOpAanwezig(Convert.ToInt32(txtAanmelden.Text));
                MessageBox.Show("Bezoeker aangemeld.");
                this.Close();
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtAfmelden_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            try
            {
                Gebruiker gebruiker = rg.GetGebruikerByRFID(Convert.ToInt32(txtScannen.Text));
                rg.Betaal(Convert.ToInt32(txtScannen.Text));
                btnBetaald.Text = rg.GetBetalingsGegevens(gebruiker)[1]; 
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtScannen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Gebruiker gebruiker = rg.GetGebruikerByRFID(Convert.ToInt32(txtScannen.Text));

                lblAchternaam.Text = gebruiker.Achternaam;
                lblTussenvoegsel.Text = gebruiker.Tussenvoegsel;
                lblVoornaam.Text = gebruiker.Voornaam;
                btnBetaald.Text = rg.GetBetalingsGegevens(gebruiker)[1];
                lblVerantwoordelijke.Text = rg.GetBetalingsGegevens(gebruiker)[0];

                txtScannen.Text = "";
            }
            catch
            {
                //MessageBox.Show("De gebruiker heeft geen reservering");
            }
        }
    }
}
