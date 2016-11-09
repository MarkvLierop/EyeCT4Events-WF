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
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Classes.Persistencies;

namespace EyeCT4Events_WF
{
    public partial class FormInloggen : Form
    {
        RepositoryGebruiker gar;    

        public FormInloggen()
        {
            InitializeComponent();

            gar = new RepositoryGebruiker(new MSSQLGebruiker());
        }       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                EyeCT4Events_WF.Classes.Gebruiker gebruiker = gar.GebruikerInloggen(tbUser.Text, tbPass.Text);

                if (gebruiker != null)
                {

                    if (gebruiker.GetType() == typeof(Bezoeker))
                    {
                        this.Hide();
                        FormMediaOverzicht fmo = new FormMediaOverzicht(gebruiker);
                        fmo.ShowDialog();

                        if (fmo.DialogResult == DialogResult.OK)
                            this.Show();
                    }

                    else if (gebruiker.GetType() == typeof(Medewerker))
                    {
                        this.Hide();
                        FormMedewerkerMainMenu fmh = new FormMedewerkerMainMenu(gebruiker);
                        fmh.ShowDialog();
                        if (fmh.DialogResult == DialogResult.OK)
                            this.Show();

                    }

                    else if (gebruiker.GetType() == typeof(Beheerder))
                    {
                        this.Hide();
                        FormBeheerderMainMenu fbmm = new FormBeheerderMainMenu(gebruiker);
                        fbmm.ShowDialog();
                        if (fbmm.DialogResult == DialogResult.OK)
                            this.Show();
                    }
                }
                else
                    MessageBox.Show("Gebruikersnaam of wachtwoord incorrect, probeer het nogmaals");
            }
            catch (NoDatabaseConnectionException exc)
            {
                MessageBox.Show(exc.Message);
            }            
        }
        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnAanwezigeBezoekers_Click(object sender, EventArgs e)
        {
            FormAanwezigeBezoekers fab = new FormAanwezigeBezoekers();
            fab.ShowDialog();
            this.Hide();
            
            if (fab.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
