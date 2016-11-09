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
    public partial class FormReserveerMateriaal : Form
    {
        Gebruiker medewerker;
        Gebruiker bezoeker;
        

        public FormReserveerMateriaal()
        {
            InitializeComponent();
        }

        public FormReserveerMateriaal(Gebruiker Bezoeker, Gebruiker Medewerker)
        {
            InitializeComponent();

            medewerker = Medewerker;
            bezoeker = Bezoeker;

            lblHuurder.Text = "Huurder:" + bezoeker.ToString();
            lblMedewerker.Text = medewerker.ToString();
        }

        private void ReserveerMateriaal_Load(object sender, EventArgs e)
        {
          //Laad alle voorraat uit de database 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zet de geselecteerde items in de database als verhuurd
        }
    }
}
