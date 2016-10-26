using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        FormCategorieToevoegen fct;
        FormCategorieZoeken fcz;

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
            if(fct != null)
            {
                media.Categorie = smsr.GetCategorieMetNaam(fct.cat.Naam).ID;
            }
            else if (fcz != null)
            {
                media.Categorie = smsr.GetCategorieMetNaam(fcz.Categorie).ID;
            }
            media.GeplaatstDoor = gebruiker.ToString();
            media.Pad = ofd.FileName;
            media.Type = Path.GetExtension(ofd.FileName);
            smsr.ToevoegenMedia(media);
            MessageBox.Show("Media geplaatst.");
            Close();
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
            fct = new FormCategorieToevoegen();            
            fct.ShowDialog();

            if (fct.DialogResult == DialogResult.OK)
            {
                lblCategorie.Text = fct.cat.Naam;
            }
            
        }

        private void btnCategorieZoeken_Click(object sender, EventArgs e)
        {
            fcz = new FormCategorieZoeken();
            fcz.ShowDialog();

            if (fcz.DialogResult == DialogResult.OK)
            {
                lblCategorie.Text = fcz.Categorie;
            }
        }
    }
}
