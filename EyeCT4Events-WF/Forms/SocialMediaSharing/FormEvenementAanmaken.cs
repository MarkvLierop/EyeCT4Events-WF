using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Persistencies;
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
    public partial class FormEvenementAanmaken : Form
    {
        private RepositorySocialMediaSharing rsms;
        private Gebruiker beheerder;
        public FormEvenementAanmaken(Gebruiker beheerder)
        {
            InitializeComponent();
            this.beheerder = beheerder;
            rsms = new RepositorySocialMediaSharing(new MSSQL_Server());

            dtpDatumVan.Format = DateTimePickerFormat.Custom;
            dtpDatumVan.CustomFormat = "dd-MM-yyyy    HH:mm";
            dtpDatumTot.Format = DateTimePickerFormat.Custom;
            dtpDatumTot.CustomFormat = "dd-MM-yyyy    HH:mm";
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            ev.Beschrijving = txtBeschrijving.Text;
            ev.DatumTot = dtpDatumTot.Value;
            ev.DatumVan = dtpDatumVan.Value;
            ev.Locatie = txtLocatie.Text;
            ev.Naam = txtEventNaam.Text;

            try
            {
                rsms.ToevoegenEvent(ev);
                MessageBox.Show("Event is aangemaakt");
                this.Close();
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
