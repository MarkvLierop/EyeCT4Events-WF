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

namespace EyeCT4Events_WF.Forms
{
    public partial class FormMediaUploaden : Form
    {
        SocialMediaSharingRepository smsr;
        Gebruiker gebruiker;
        OpenFileDialog ofd;
        public FormMediaUploaden(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            smsr = new SocialMediaSharingRepository(new MSSQL_Server());
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            media.Beschrijving = tbBeschrijving.Text;
            media.Categorie = smsr.GetCategorieMetNaam(tbCategorie.Text).ID;
            media.GeplaatstDoor = gebruiker.ToString();
            media.Pad = ofd.InitialDirectory;
        }

        private void tbBestandZoeken_Click(object sender, EventArgs e)
        {
            using (ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();

                lblBestandsNaam.Text = ofd.FileName;
            }
        }

        private void btnCategorieToevoegen_Click(object sender, EventArgs e)
        {
            using (FormCategorieToevoegen fct = new FormCategorieToevoegen())
            {
                fct.ShowDialog();

                if (fct.DialogResult == DialogResult.OK)
                {
                    tbCategorie.Text = fct.cat.Naam;
                }
            }
        }
    }
}
