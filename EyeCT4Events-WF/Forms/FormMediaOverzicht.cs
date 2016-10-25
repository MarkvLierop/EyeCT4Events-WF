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

namespace EyeCT4Events_WF
{
    public partial class FormMediaOverzicht : Form
    {
        private List<Categorie> categorieLijst;
        private Gebruiker gebruiker;

        public FormMediaOverzicht(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            SocialMediaSharingRepository smsr = new SocialMediaSharingRepository(new MSSQL_Server());
            categorieLijst = smsr.GetAlleCategorien();
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
