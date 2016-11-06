using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
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

        }

        private void AanwezigBezoekers_Load(object sender, EventArgs e)
        {
            bezoekerLijst = rg.LijstAanwezigeBezoekers();
            kampeerplaatsLijst = rkp.AlleKampeerplaatsenOpvragen();

            foreach (Gebruiker g in bezoekerLijst)
            {
                ListViewItem lvi = new ListViewItem("Kampeerplaats");
                foreach (Kampeerplaats k in kampeerplaatsLijst)
                {
                    if (k.CheckOfBezoekerOpKampeerplaatsIs(g))
                    {
                        lstAanwezigeBezoekers.Items.Add(k.ID.ToString());
                    }
                }
                lvi.SubItems.Add(g.Aanwezig.ToString());
                lvi.SubItems.Add(g.ToString());
                lstAanwezigeBezoekers.Items.Add(lvi);
            }
        }

        private void lbSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBezoekerAanmelden_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBezoekerAfmelden_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
