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
        GebruikerRepository gar;     


        public FormInloggen()
        {
            InitializeComponent();

            gar = new GebruikerRepository(new MSSQL_Server());
        }       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EyeCT4Events_WF.Classes.Gebruiker gebruiker;
            
            if (gar.CheckLogIn(tbUser.Text, tbPass.Text))
            {
                gebruiker = gar.LogIn(tbUser.Text);

                if (gebruiker.GetType() == typeof(Bezoeker))
                {
                    this.Hide();
                    FormMediaOverzicht fmo = new FormMediaOverzicht(gebruiker);
                    fmo.Show();
                }

                else if(gebruiker.GetType() == typeof(Medewerker))
                {
                    this.Hide();
                    FormReserveerPlaats frp = new FormReserveerPlaats(gebruiker);
                    frp.Show();
                }

                else if(gebruiker.GetType() == typeof(Beheerder))
                {

                    this.Hide();
                }

                else
                    MessageBox.Show("Gebruikersnaam en/of wachtwoord incorrect, probeer het nogmaals");
            }

        }

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }
    }
}
