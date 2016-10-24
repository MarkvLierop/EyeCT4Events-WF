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
    public partial class CategorieToevoegen : Form
    {
        public CategorieToevoegen()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            SocialMediaSharingRepository smsr = new SocialMediaSharingRepository(new MSSQL_Server());

            Categorie cat = new Categorie();
            cat.Naam = tbNaam.Text;
            cat.Parent = smsr.GetCategorieMetNaam(tbHoofdCategorie.Text).ID;
        }
    }
}
