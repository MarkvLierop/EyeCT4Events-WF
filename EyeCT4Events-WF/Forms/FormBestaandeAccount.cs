using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Persistencies;
using EyeCT4Events_WF.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Exceptions;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormBestaandeAccount : Form
    {
        List<Gebruiker> bestaandegebruikers;
        Gebruiker medewerker;

        public int MSSQL { get; private set; }

        public FormBestaandeAccount()
        {
            InitializeComponent();
        }

        public FormBestaandeAccount(Gebruiker gebruiker)
        {
            medewerker = gebruiker;
        }

        private void tbZoekGebruikers_TextChanged(object sender, EventArgs e)
        {
            string zoekopdracht = tbZoekGebruikers.Text;
            RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQL_Server());
            try
            {
                bestaandegebruikers = rg.GezochteBezoekersOphalen(zoekopdracht);
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnKampeerplaatsReserveren_Click(object sender, EventArgs e)
        {
            FormReserveerPlaats frp = new FormReserveerPlaats(medewerker);
            this.Hide();
            frp.Show();
        }

        private void btnNieuweAccAanmaken_Click(object sender, EventArgs e)
        {
            FormRegistreerNieuweGebruiker frng = new FormRegistreerNieuweGebruiker(medewerker);
            this.Hide();
            frng.Show();
        }
    }
}
