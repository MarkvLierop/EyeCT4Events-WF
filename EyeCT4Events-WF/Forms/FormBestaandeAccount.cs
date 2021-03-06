﻿using EyeCT4Events_WF.Classes;
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
using EyeCT4Events_WF.Classes.Persistencies;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormBestaandeAccount : Form
    {
        List<Gebruiker> bestaandegebruikers = new List<Gebruiker>();
        Gebruiker medewerker;

        public int MSSQL { get; private set; }

        public FormBestaandeAccount(Gebruiker gebruiker, string tekst)
        {
            InitializeComponent();
            medewerker = gebruiker;

            btnNieuweAccAanmaken.Visible = false;
            btnKampeerplaatsReserveren.Visible = false;
        }

        public FormBestaandeAccount(Gebruiker gebruiker)
        {
            InitializeComponent();
            medewerker = gebruiker;

            btnMateriaalReserveren.Visible = false;
            btnKampeerplaatsReserveren.Enabled = false;
        }

        private void tbZoekGebruikers_TextChanged(object sender, EventArgs e)
        {
            string zoekopdracht = tbZoekGebruikers.Text;
            if (bestaandegebruikers.Capacity > 0)
            {
                bestaandegebruikers.Clear();
            }

            RepositoryGebruiker rg = new RepositoryGebruiker(new MSSQLGebruiker());
            try
            {
                bestaandegebruikers = rg.GezochteBezoekersOphalen(zoekopdracht);

                Ververs();
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnKampeerplaatsReserveren_Click(object sender, EventArgs e)
        {
            Gebruiker gekozengebruiker;
            gekozengebruiker = bestaandegebruikers[lbBestaandeGebruikers.SelectedIndex];
            FormReserveerPlaats frp = new FormReserveerPlaats(medewerker, gekozengebruiker);
            this.Close();
            frp.Show();
        }

        private void btnNieuweAccAanmaken_Click(object sender, EventArgs e)
        {
            FormRegistreerNieuweGebruiker frng = new FormRegistreerNieuweGebruiker(medewerker);
            this.Close();
            frng.Show();
        }

        void Ververs()
        {
            lbBestaandeGebruikers.Items.Clear();

            foreach (Gebruiker g in bestaandegebruikers)
            {
                lbBestaandeGebruikers.Items.Add(g);
            }
        }

        private void btnMateriaalReserveren_Click(object sender, EventArgs e)
        {
            Gebruiker gekozengebruiker;
            gekozengebruiker = bestaandegebruikers[lbBestaandeGebruikers.SelectedIndex];
            FormReserveerMateriaal frm = new FormReserveerMateriaal(gekozengebruiker, medewerker);
            this.Close();
            frm.Show();
        }

        private void lbBestaandeGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBestaandeGebruikers.SelectedIndex >= 0)
            {
                btnKampeerplaatsReserveren.Enabled = true;
            }
        }
    }
}
