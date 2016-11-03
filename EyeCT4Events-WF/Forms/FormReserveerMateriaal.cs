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
        public FormReserveerMateriaal()
        {
            InitializeComponent();
        }

        public FormReserveerMateriaal(Gebruiker gebruiker)
        {

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
