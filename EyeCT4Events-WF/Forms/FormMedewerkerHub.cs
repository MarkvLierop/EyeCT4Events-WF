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

namespace EyeCT4Events_WF.Forms
{
    public partial class FormMedewerkerHub : Form
    {
        Gebruiker medewerker;

        public FormMedewerkerHub()
        {
            InitializeComponent();
        }

        public FormMedewerkerHub(Gebruiker gebruiker)
        {
            InitializeComponent();
            medewerker = gebruiker;
            lblMedewerker.Text = medewerker.Voornaam + " " + medewerker.Achternaam;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {

        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            
            FormBestaandeAccount fba = new FormBestaandeAccount(medewerker);
            this.Hide();
            fba.Show();
        }

        private void btnEventAanmaken_Click(object sender, EventArgs e)
        {

        }

        private void btnBezoekers_Click(object sender, EventArgs e)
        {
            AanwezigBezoekers fab = new AanwezigBezoekers();
            this.Hide();
            fab.Show();
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            FormReserveerMateriaal frm = new FormReserveerMateriaal();
            this.Hide();
            frm.Show();
        }
    }
}
