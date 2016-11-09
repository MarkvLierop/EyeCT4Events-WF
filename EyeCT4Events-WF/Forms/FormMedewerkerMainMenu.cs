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
    public partial class FormMedewerkerMainMenu : Form
    {
        Gebruiker medewerker;

        public FormMedewerkerMainMenu(Gebruiker gebruiker)
        {
            InitializeComponent();
            medewerker = gebruiker;

            lblMedewerker.Text = medewerker.ToString();
        }

        private void btnMaakEventAan_Click(object sender, EventArgs e)
        {

        }

        private void btnMateriaalReserveren_Click(object sender, EventArgs e)
        {
            FormReserveerMateriaal frm = new FormReserveerMateriaal();
            this.Hide();
            frm.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {

        }

        private void btnAanwezigeBezoekers_Click(object sender, EventArgs e)
        {
            FormAanwezigeBezoekers fab = new FormAanwezigeBezoekers();
            this.Hide();
            fab.Show();
        }

        private void btnPlaatsReserveren_Click(object sender, EventArgs e)
        {
            FormBestaandeAccount fba = new FormBestaandeAccount(medewerker);
            this.Hide();
            fba.Show();
        }
    }
    }

