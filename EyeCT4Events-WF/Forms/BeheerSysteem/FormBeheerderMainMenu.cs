using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormBeheerderMainMenu : Form
    {
        private Gebruiker beheerder;
        public FormBeheerderMainMenu(Gebruiker beheerder)
        {
            InitializeComponent();
            this.beheerder = beheerder;
        }

        private void btnGerapporteerdeMedia_Click(object sender, EventArgs e)
        {
            //FormGerapporteerdeMediaOverzicht fgmo = new FormGerapporteerdeMediaOverzicht(beheerder);
            //fgmo.Show();
        }

        private void btnAanwezigeBezoekers_Click(object sender, EventArgs e)
        {

        }

        private void btnGebruikersBeheren_Click(object sender, EventArgs e)
        {
            Gebruikersbeheer gebruikerbeheer = new Gebruikersbeheer();
            gebruikerbeheer.Show();
        }

        private void btnEvenementAanmaken_Click(object sender, EventArgs e)
        {
            FormEvenementAanmaken fea = new FormEvenementAanmaken(beheerder);
            fea.Show();
        }
    }
}
