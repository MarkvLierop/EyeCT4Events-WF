using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;

namespace EyeCT4Events_WF
{
    public partial class FormReserveerPlaats : Form
    {
        KampeerplaatsenRepository kpr = new KampeerplaatsenRepository(new MSSQL_Server());
             
        public FormReserveerPlaats()
        {
            InitializeComponent();
            
        }

        public FormReserveerPlaats(Gebruiker gebruiker)
        {
            lblMedewerker.Text = gebruiker.Voornaam + " " + gebruiker.Achternaam;
            groupBox2.Enabled = false;

        }

        public void HaalLijstOp()
        {

        }


        private void ReserveerPlaats_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbInvalide_CheckedChanged(object sender, EventArgs e)
        {
            HaalLijstOp();
        }

        private void rbComfort_CheckedChanged(object sender, EventArgs e)
        {
            HaalLijstOp();
        }

        private void rbLawaai_CheckedChanged(object sender, EventArgs e)
        {
            HaalLijstOp();
        }
    }
}
