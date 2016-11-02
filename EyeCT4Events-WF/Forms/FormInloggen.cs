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
    public partial class Inloggen : Form
    {

        string inlog;
        GebruikerRepository gar;
        


        public Inloggen()
        {
            InitializeComponent();

            gar = new GebruikerRepository(new MSSQL_Server());

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EyeCT4Events_WF.Classes.Gebruiker ingelogde;

            bool check;

            check = gar.CheckLogIn(tbUser.Text, tbPass.Text);

            if (check)
            {
                ingelogde = gar.LogIn(tbUser.Text);

                if(ingelogde.GebruikerType == "Bezoeker")
                {
                    this.Close();
                    FormMediaOverzicht fmo = new FormMediaOverzicht(ingelogde);
                    fmo.Show();
                }

                else if(ingelogde.GebruikerType == "Medewerker")
                {
                    this.Close();
                }

                else if(ingelogde.GebruikerType == "Beheerder")
                {
                    this.Close();
                }
            }

        }

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }
    }
}
