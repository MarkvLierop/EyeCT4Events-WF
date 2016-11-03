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
    public partial class FormCategorieZoeken : Form
    {
        RepositorySocialMediaSharing smsr;
        List<Categorie> catlist;

        // ----- 
        public string Categorie { get; private set; }

        public FormCategorieZoeken()
        {
            InitializeComponent();

            smsr = new RepositorySocialMediaSharing(new MSSQL_Server());

            catlist = smsr.AlleCategorienOpvragen().ToList();

            foreach (Categorie cat in catlist)
            {
                lbCategorien.Items.Add(cat.Naam);
            };
        }

        private void btnSelecteren_Click(object sender, EventArgs e)
        {
            Categorie = lbCategorien.SelectedItem.ToString();
            Close();
        }
    }
}
