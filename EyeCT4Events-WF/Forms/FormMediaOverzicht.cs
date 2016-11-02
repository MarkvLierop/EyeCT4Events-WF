using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Forms;
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
using WMPLib;

namespace EyeCT4Events_WF
{
    public partial class FormMediaOverzicht : Form
    {
        // Fields
        SocialMediaSharingRepository smsr;
        private List<Categorie> categorieLijst;
        private List<Media> mediaLijst;
        private Gebruiker gebruiker;
        private string[] directories;

        // Methods
        private void ContentCreeren(List<Media> mediaList)
        {
            //directories = Directory.GetDirectories(Directory.GetCurrentDirectory(), "*", SearchOption.AllDirectories);

            //for (int i = 0; i < directories.GetLength(0); i++)
            //{
            //    MessageBox.Show(Path.GetFileName(directories[i]));
            //}

            List<Control> pnlContentControlList = new List<Control>();
            for (int i = 0; i < mediaLijst.Count; i++)
            {
                Label Titel = new Label();
                Titel.Text = mediaLijst[i].GeplaatstDoor + " heeft een " + mediaLijst[i].Type + " Geplaatst";
                Titel.Width = pnlContent.Width;
                pnlContentControlList.Add(Titel);

                switch (mediaLijst[i].Type)
                {
                    case "Afbeelding":
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(mediaLijst[i].Pad);
                        pb.Width = Image.FromFile(mediaLijst[i].Pad).Width;
                        //pb.Height = Image.FromFile(mediaLijst[i].Pad).Height;
                        pnlContentControlList.Add(pb);
                        break;
                    case "Video":
                        WindowsMediaPlayer wmp1 = new WindowsMediaPlayer();
                        break;
                    case "Audio":
                        WindowsMediaPlayer wmp2 = new WindowsMediaPlayer();
                        break;
                }
                Label Beschrijving = new Label();
                Beschrijving.Text = mediaLijst[i].Beschrijving;
                pnlContentControlList.Add(Beschrijving);

                Button btnMediaLike = new Button();
                btnMediaLike.Text = "Likes " + mediaLijst[i].Likes;
                btnMediaLike.Tag = mediaLijst[i].Likes;
                btnMediaLike.Name = mediaLijst[i].ID.ToString();
                btnMediaLike.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMediaLike_MouseUp);
                pnlContentControlList.Add(btnMediaLike);

                Button btnMediaRapporteren = new Button();
                btnMediaRapporteren.Text = "Rapporteren";
                btnMediaRapporteren.Tag = mediaLijst[i].Likes; // NOG AANPASSEN
                btnMediaRapporteren.Name = mediaLijst[i].ID.ToString();
                btnMediaRapporteren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMediaRapporteren_MouseUp);
                pnlContentControlList.Add(btnMediaRapporteren);

                // Alle Custom controls positioneren op het Content panel.
                for (int c = 0; c < pnlContentControlList.Count; c++)
                {
                    pnlContentControlList[c].Location = new Point(0, c * pnlContentControlList[c].Height);
                    pnlContent.Controls.Add(pnlContentControlList[c]);
                }
            }
        }

        // Constructor
        public FormMediaOverzicht(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            smsr = new SocialMediaSharingRepository(new MSSQL_Server());
            categorieLijst = smsr.AlleCategorienOpvragen();

            mediaLijst = smsr.AlleMediaOpvragen();
            ContentCreeren(mediaLijst);
        }

        // Events
        private void btnMediaRapporteren_MouseUp(object sender, MouseEventArgs e)
        {
            smsr.ToevoegenRapporterenMediaReactie(Convert.ToInt32(((Button)sender).Name), int.MinValue);
            ((Button)sender).Enabled = false;
            ((Button)sender).Text = "Gerapporteerd";
            MessageBox.Show("Gerapporteerd.");
        }

        private void btnMediaLike_MouseUp(object sender, MouseEventArgs e)
        {
            // Button sender.Name = ID van Media. 
            // sender.Tag = Aantal likes dat de media heeft.
            smsr.ToevoegenLikeInMediaOfReactie(gebruiker, Convert.ToInt32(((Button)sender).Name), int.MinValue);
            ((Button)sender).Text = "Likes " + (Convert.ToInt32(((Button)sender).Tag) + 1).ToString();
            ((Button)sender).Enabled = false;
        }

        private void btnCategorieToevoegen_Click(object sender, EventArgs e)
        {
            FormCategorieToevoegen catToevoegen = new FormCategorieToevoegen();
            catToevoegen.Show();
        }

        private void pnlCategorieën_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < categorieLijst.Count; i++)
            {
                categorieLijst[i].DrawNaam(g, i);
            }
            //for (int i = 0; i< directories.GetLength(0); i++)
            //{
            //    MessageBox.Show(Path.GetFileName(Path.GetDirectoryName(directories[i]));
            //    g.DrawString(Path.GetFileName(Path.GetDirectoryName(directories[i])), new Font("Arial", 14), Brushes.Black, new Point(0, i * 15));
            //}
        }

        private void btnMediaUploaden_Click(object sender, EventArgs e)
        {
            using (FormMediaUploaden fmu = new FormMediaUploaden(gebruiker))
            {
                fmu.ShowDialog();

                if (fmu.DialogResult == DialogResult.OK)
                {
                    pnlCategorieën.Refresh();
                    pnlContent.Refresh();
                }
            }
        }

        private void tbZoeken_TextChanged(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            mediaLijst = smsr.ZoekenMedia(tbZoeken.Text);
            ContentCreeren(mediaLijst);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
