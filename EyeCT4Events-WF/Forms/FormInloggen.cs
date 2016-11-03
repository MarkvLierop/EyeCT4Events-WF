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
using EyeCT4Events_WF.Forms;

namespace EyeCT4Events_WF
{
    public partial class FormInloggen : Form
    {
        RepositoryGebruiker gar;    

        public FormInloggen()
        {
            InitializeComponent();

            gar = new RepositoryGebruiker(new MSSQL_Server());
        }       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EyeCT4Events_WF.Classes.Gebruiker gebruiker = gar.GebruikerInloggen(tbUser.Text, tbPass.Text);

            if (gebruiker != null)
            {

                if (gebruiker.GetType() == typeof(Bezoeker))
                {
                    this.Hide();
                    FormMediaOverzicht fmo = new FormMediaOverzicht(gebruiker);
                    fmo.Show();
                }

                else if(gebruiker.GetType() == typeof(Medewerker))
                {
                    this.Hide();
                    FormMedewerkerHub fmh = new FormMedewerkerHub(gebruiker);
                    fmh.Show();
                }

                else if(gebruiker.GetType() == typeof(Beheerder))
                {

                    this.Hide();
                }
            }
            else
                MessageBox.Show("Gebruikersnaam of wachtwoord incorrect, probeer het nogmaals");
        }
        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
