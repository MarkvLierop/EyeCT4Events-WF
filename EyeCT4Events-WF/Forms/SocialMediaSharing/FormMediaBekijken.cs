using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Exceptions;
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
    public partial class FormMediaBekijken : Form
    {
        private Gebruiker beheerder;
        private Media media;
        private RepositorySocialMediaSharing rsms;
        private RepositoryGebruiker rg;
        private List<Reactie> reactieLijst;
        private void ReactieLijstLaden()
        {
            lsReacties.Items.Clear();
            foreach (Reactie r in reactieLijst)
            {
                if (r.Media == media.ID)
                {
                    lsReacties.Items.Add(r.ToString());
                }
            }
        }
        public FormMediaBekijken(Gebruiker beheerder, Media media)
        {
            InitializeComponent();
            this.beheerder = beheerder;
            this.media = media;

            rsms = new RepositorySocialMediaSharing(new MSSQLSMS());
            rg = new RepositoryGebruiker(new MSSQLGebruiker());

            try
            {
                lblGebruiker.Text = rg.GetGebruikerByID(media.GeplaatstDoor).ToString();
                btnAantalKerenGerapporteerd.Text = media.Flagged.ToString();
                lblBestand.Text = "Bestand: " + media.GetBestandsNaam();
                lblBeschrijving.Text = media.Beschrijving;

                reactieLijst = rsms.AlleReactiesOpvragen();
                ReactieLijstLaden();
            }
            catch (FoutBijUitvoerenQueryException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAantalKerenGerapporteerd_Click(object sender, EventArgs e)
        {
            try
            {
                rsms.ZetAantalKerenGerapporteerdOp0(media);
                btnAantalKerenGerapporteerd.Text = "0";
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show("Kan aantal keren gerapporteerd niet aanpassen: \n" + exc.Message);
            }
        }

        private void btnVerwijderReactie_Click(object sender, EventArgs e)
        {
            try
            {
                rsms.VerwijderReactie(reactieLijst[lsReacties.SelectedIndex + 1]);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Kan reactie niet verwijderen \n \n" + exc.Message);
            }

            reactieLijst = rsms.AlleReactiesOpvragen();
            ReactieLijstLaden();
        }

        private void lblBestand_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Bestand Opslaan";
            sfd.Filter = media.FilterVastStellen();
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                File.Copy(media.Pad, sfd.FileName);
            }
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerwijderMedia_Click(object sender, EventArgs e)
        {
            try
            {
                rsms.VerwijderMedia(media);
                MessageBox.Show("Media Verwijderd");
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Kan media niet verwijderen \n" + exc.Message);
            }
        }
    }
}
