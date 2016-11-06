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

namespace EyeCT4Events_WF
{
    public partial class FormAanwezigeBezoekers : Form
    {
        private RepositoryGebruiker rg;
        private RepositoryKampeerPlaatsen rkp;
        private List<Gebruiker> bezoekerLijst;
        private List<Kampeerplaats> kampeerplaatsLijst;

        public FormAanwezigeBezoekers()
        {
            InitializeComponent();
            rg = new RepositoryGebruiker(new MSSQL_Server());
            rkp = new RepositoryKampeerPlaatsen(new MSSQL_Server());
            bezoekerLijst = new List<Gebruiker>();

            lvAanwezigeBezoekers.View = View.Details;
            lvAanwezigeBezoekers.FullRowSelect = true;
            lvAanwezigeBezoekers.Columns.Add("Bezoeker");
            lvAanwezigeBezoekers.Columns.Add("Aanwezig");
            lvAanwezigeBezoekers.Columns.Add("Kampeerplaats");
        }
        private void AanwezigeBezoekerslijstVullen()
        {
            lvAanwezigeBezoekers.Items.Clear();
            bezoekerLijst = rg.LijstAanwezigeBezoekers();
            kampeerplaatsLijst = rkp.AlleKampeerplaatsenOpvragen();

            foreach (Gebruiker g in bezoekerLijst)
            {
                ListViewItem lvi = new ListViewItem(g.ToString());
                lvi.SubItems.Add(g.Aanwezig ? "Ja" : "Nee");
                foreach (Kampeerplaats k in kampeerplaatsLijst)
                {
                    if (k.CheckOfBezoekerOpKampeerplaatsIs(g))
                    {
                        lvi.SubItems.Add(k.ID.ToString());
                    }
                }
                lvAanwezigeBezoekers.Items.Add(lvi);
            }
            lvAanwezigeBezoekers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lvAanwezigeBezoekers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void AanwezigBezoekers_Load(object sender, EventArgs e)
        {
            AanwezigeBezoekerslijstVullen();
        }

        private void lbSluiten_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtBezoekerAanmelden_TextChanged(object sender, EventArgs e)
        {
            if (txtBezoekerAanmelden.Text != "")
            {
                try
                {
                    rg.ZetGebruikerOpAanwezig(Convert.ToInt32(txtBezoekerAanmelden.Text));
                    txtBezoekerAanmelden.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AanwezigeBezoekerslijstVullen();
            }
        }

        private void txtBezoekerAfmelden_TextChanged(object sender, EventArgs e)
        {
            if (txtBezoekerAfmelden.Text != "")
            {
                try
                {
                    rg.ZetGebruikerOpAfwezig(Convert.ToInt32(txtBezoekerAfmelden.Text));
                    txtBezoekerAfmelden.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AanwezigeBezoekerslijstVullen();
            }
        }
    }
}
