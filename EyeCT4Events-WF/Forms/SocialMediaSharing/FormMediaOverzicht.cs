using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Forms;
using EyeCT4Events_WF.Forms.SocialMediaSharing;
using EyeCT4Events_WF.Persistencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EyeCT4Events_WF
{
    public partial class FormMediaOverzicht : Form
    {
        // Fields
        RepositorySocialMediaSharing rsms;
        RepositoryGebruiker rg;
        private List<Categorie> categorieLijst;
        private List<Media> mediaLijst;
        private Gebruiker gebruiker;

        // Private Methods
        private void ContentCreeren(List<Media> mediaList)
        {
            // Ongewenste inhoud verwijderen
            rg = new RepositoryGebruiker(new MSSQLGebruiker());
            try
            {
                rsms.SchoolAbusievelijkTaalgebruikOp();
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }

            // Form layout creeren
            List<Control> pnlContentControlList = new List<Control>();
            for (int i = 0; i < mediaLijst.Count; i++)
            {
                Label Titel = new Label();
                Titel.Text = mediaLijst[i].GeplaatstDoorGebruiker() + " heeft een " + mediaLijst[i].Type + " Geplaatst";
                Titel.Font = new Font("Arial", 10, FontStyle.Bold);
                Titel.Width = pnlContent.Width;
                pnlContentControlList.Add(Titel);

                if (mediaLijst[i].Pad != "")
                {
                    Label lblDownloadFile = new Label();
                    lblDownloadFile.Text = "Bestand Downloaden: "+mediaLijst[i].GetBestandsNaam();
                    lblDownloadFile.Name = mediaLijst[i].ID.ToString();
                    lblCategorieZoeken.Font = new Font("Arial", 10, FontStyle.Underline);
                    lblDownloadFile.Width = pnlContent.Width;
                    lblDownloadFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDownloadFile_MouseUp);
                    pnlContentControlList.Add(lblDownloadFile);
                }

                Label Beschrijving = new Label();
                Beschrijving.Text = mediaLijst[i].Beschrijving;
                Beschrijving.Width = pnlContent.Width;
                pnlContentControlList.Add(Beschrijving);

                Button btnMediaLike = new Button();
                btnMediaLike.Text = "Likes " + mediaLijst[i].Likes;
                btnMediaLike.Tag = mediaLijst[i].Likes;
                btnMediaLike.Name = mediaLijst[i].ID.ToString();
                btnMediaLike.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMediaLike_MouseUp);
                pnlContentControlList.Add(btnMediaLike);

                Button btnMediaRapporteren = new Button();
                btnMediaRapporteren.Text = "Rapporteren";
                btnMediaRapporteren.Tag = mediaLijst[i].Flagged; // NOG AANPASSEN
                btnMediaRapporteren.Name = mediaLijst[i].ID.ToString();
                btnMediaRapporteren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMediaRapporteren_MouseUp);
                pnlContentControlList.Add(btnMediaRapporteren);

                Button btnReageren = new Button();
                btnReageren.Text = "Reageren";
                btnReageren.Name = mediaLijst[i].ID.ToString();
                btnReageren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReageren_MouseUp);
                pnlContentControlList.Add(btnReageren);

                List<Reactie> reactieLijst = rsms.AlleReactiesOpvragen();

                // Alle reacties weergeven onder elk media onderdeel
                foreach (Reactie r in reactieLijst)
                {
                    if (r.Media == mediaLijst[i].ID)
                    {
                        Label lblGebruiker = new Label();
                        try
                        {
                            lblGebruiker.Text = rg.GetGebruikerByID(r.GeplaatstDoor).ToString() + ": " + r.Inhoud;
                        }
                        catch (FoutBijUitvoerenQueryException e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        lblGebruiker.Width = pnlContent.Width;
                        pnlContentControlList.Add(lblGebruiker);
                    }
                }

                // Alle Custom controls positioneren  en toevoegen aan het Content panel.
                for (int c = 1; c < pnlContentControlList.Count; c++)
                {
                    pnlContentControlList[c].Location = new Point(0, (c * pnlContentControlList[c].Height) + pnlContent.Location.Y);
                    pnlContent.Controls.Add(pnlContentControlList[c]);
                }
            }
            pnlContent.Refresh();
        }

        // Constructor
        public FormMediaOverzicht(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            rsms = new RepositorySocialMediaSharing(new MSSQLSMS());
            try
            {
                categorieLijst = rsms.AlleCategorienOpvragen().ToList();
                mediaLijst = rsms.AlleMediaOpvragen();
            }
            catch (FoutBijUitvoerenQueryException e)
            {
                MessageBox.Show("Fout bij ophalen van categorien: " + e.Message);
            }

            ContentCreeren(mediaLijst);
        }
        // Events
        private void lblDownloadFile_MouseUp(object sender, MouseEventArgs e)
        {
            Media media = null;
            foreach (Media m in mediaLijst)
            {
                if (m.ID == Convert.ToInt32(((Label)sender).Name))
                {
                    media = m;
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Bestand Opslaan";
            sfd.Filter = media.FilterVastStellen();
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                File.Copy(media.Pad, sfd.FileName);
            }
        }

        private void btnReageren_MouseUp(object sender, MouseEventArgs e)
        {
            FormMediaReageren fmr = new FormMediaReageren(gebruiker, ((Button)sender).Name);
            fmr.ShowDialog();

            if (fmr.DialogResult == DialogResult.OK)
            {
                mediaLijst = rsms.AlleMediaOpvragen();
                ContentCreeren(mediaLijst);
            }
        }

        // Events
        private void btnMediaRapporteren_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                rsms.ToevoegenRapporterenMediaReactie(Convert.ToInt32(((Button)sender).Name), int.MinValue);
                ((Button)sender).Enabled = false;
                ((Button)sender).Text = "Gerapporteerd";
                MessageBox.Show("Gerapporteerd.");
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnMediaLike_MouseUp(object sender, MouseEventArgs e)
        {
            // Button sender.Name = ID van Media. 
            // sender.Tag = Aantal likes dat de media heeft.
            try
            {
                rsms.ToevoegenLikeInMediaOfReactie(gebruiker, Convert.ToInt32(((Button)sender).Name), int.MinValue);
                ((Button)sender).Text = "Likes " + (Convert.ToInt32(((Button)sender).Tag) + 1).ToString();
                ((Button)sender).Enabled = false;
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCategorieToevoegen_Click(object sender, EventArgs e)
        {
            FormCategorieToevoegen catToevoegen = new FormCategorieToevoegen();
            catToevoegen.ShowDialog();

            if (catToevoegen.DialogResult == DialogResult.OK)
            {
                categorieLijst = rsms.AlleCategorienOpvragen().ToList();
                pnlCategorieën.Refresh();
            }
        }

        private void pnlCategorieën_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < categorieLijst.Count; i++)
            {
                categorieLijst[i].DrawNaam(g, i);
            }
        }

        private void btnMediaUploaden_Click(object sender, EventArgs e)
        {
            using (FormMediaUploaden fmu = new FormMediaUploaden(gebruiker))
            {
                fmu.ShowDialog();

                if (fmu.DialogResult == DialogResult.OK)
                {
                    pnlContent.Controls.Clear();
                    mediaLijst = rsms.AlleMediaOpvragen();
                    ContentCreeren(mediaLijst);
                }
            }
        }

        private void tbZoeken_TextChanged(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            mediaLijst = rsms.ZoekenMedia(tbZoeken.Text, int.MinValue);
            ContentCreeren(mediaLijst);
        }

        private void pnlCategorieën_MouseDown(object sender, MouseEventArgs e)
        {
            // Checken welke categorie aangeklikt is. Op basis daarvan media filteren.
            foreach (Categorie c in categorieLijst)
            {
                if (c.Locatie.X < e.X && c.Locatie.Y < e.Y &&
                        c.Locatie.Right > e.X && c.Locatie.Bottom > e.Y)
                {
                    //MessageBox.Show(c.ID.ToString() + " "+ c.Naam +" Aangeklikt");
                    pnlContent.Controls.Clear();
                    mediaLijst = rsms.ZoekenMedia(" ", c.ID);
                    ContentCreeren(mediaLijst);
                }
            }
        }

        private void txtCategorieZoeken_TextChanged(object sender, EventArgs e)
        {
            RepositorySocialMediaSharing rsms = new RepositorySocialMediaSharing(new MSSQLSMS());
            try
            {
                categorieLijst = rsms.ZoekenCategorie(txtCategorieZoeken.Text);
                pnlCategorieën.Refresh();
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FormMediaOverzicht_Load(object sender, EventArgs e)
        {
            // Event scherm laten zien
            FormEventOverzicht feo = new FormEventOverzicht();
            feo.Show();
        }

        private void FormMediaOverzicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
