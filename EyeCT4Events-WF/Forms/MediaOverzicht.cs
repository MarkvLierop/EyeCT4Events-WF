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
    public partial class MediaOverzicht : Form
    {
        private List<Categorie> categorieLijst;
        public MediaOverzicht()
        {
            InitializeComponent();

            SocialMediaSharingRepository smsr = new SocialMediaSharingRepository(new MSSQL_Server());
            categorieLijst = smsr.GetAlleCategorien();
        }

        private void btnCategorieToevoegen_Click(object sender, EventArgs e)
        {
            CategorieToevoegen catToevoegen = new CategorieToevoegen();
            catToevoegen.Show();
        }

        private void pnlCategorieën_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < categorieLijst.Count; i++)
            {
                categorieLijst[i].DrawNaam(g, Location, i);
            }
        }

        private void btnMediaUploaden_Click(object sender, EventArgs e)
        {

        }
    }
}
