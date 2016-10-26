using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Forms;
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
using WMPLib;

namespace EyeCT4Events_WF
{
    public partial class FormMediaOverzicht : Form
    {
        SocialMediaSharingRepository smsr;
        private List<Categorie> categorieLijst;
        private List<Media> mediaLijst;
        private Gebruiker gebruiker;


        public FormMediaOverzicht(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            smsr = new SocialMediaSharingRepository(new MSSQL_Server());
            categorieLijst = smsr.AlleCategorienOpvragen();

            mediaLijst = smsr.AlleMediaOpvragen();
            List<Control> pnlContentControlList = new List<Control>();
            for(int i = 0; i< mediaLijst.Count;i++)
            {
                Label Titel = new Label();
                Titel.Text = mediaLijst[i].GeplaatstDoor + " heeft een " + mediaLijst[i].Type + " Geplaatst";
                Titel.Width = pnlContent.Width;
                pnlContentControlList.Add(Titel);
                
                switch (mediaLijst[i].Type)
                {
                    case "Afbeelding":
                        PictureBox pb = new PictureBox();
                        pb.ImageLocation = mediaLijst[i].Pad;
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

                Button btnLikes = new Button();
                btnLikes.Text = "Likes "+ mediaLijst[i].Likes;
                btnLikes.Tag = mediaLijst[i].ID;
                btnLikes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLikes_MouseUp);
                pnlContentControlList.Add(btnLikes);

                Button Rapporteren = new Button();
                Rapporteren.Text = "Rapporteren";
                pnlContentControlList.Add(Rapporteren);

                for (int c = 0; c < pnlContentControlList.Count;c++)
                {
                    pnlContentControlList[c].Location = new Point(0, c * pnlContentControlList[c].Height);
                    pnlContent.Controls.Add(pnlContentControlList[c]);
                }
            }
        }

        private void btnLikes_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Media m in mediaLijst)
            {
                if (Convert.ToInt32(Tag) == m.ID)
                {
                    smsr.ToevoegenLike(gebruiker, m.ID, int.MinValue, smsr.AantalLikesOpvragen(m.ID, int.MinValue));
                }
            }
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
    }
}
