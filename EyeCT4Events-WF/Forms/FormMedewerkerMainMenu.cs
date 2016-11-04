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
            lblMedewerkerNaam.Text = medewerker.ToString();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            FormMediaOverzicht fmo = new FormMediaOverzicht(medewerker);
            fmo.Show();
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            
            FormReserveerPlaats frp = new FormReserveerPlaats(medewerker);
            this.Hide();
            frp.Show();
        }

        private void btnEventAanmaken_Click(object sender, EventArgs e)
        {

        }

        private void btnBezoekers_Click(object sender, EventArgs e)
        {

        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            FormReserveerMateriaal frm = new FormReserveerMateriaal(medewerker);
            this.Hide();
            frm.Show();
        }
    }
}
