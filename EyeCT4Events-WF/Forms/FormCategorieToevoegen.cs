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
    public partial class FormCategorieToevoegen : Form
    {
        SocialMediaSharingRepository smsr;
        List<Categorie> catList;

        public Categorie cat { get; private set; }

        public FormCategorieToevoegen()
        {
            InitializeComponent();
            smsr = new SocialMediaSharingRepository(new MSSQL_Server());

            catList = smsr.GetAlleCategorien();
            
            foreach (Categorie cat in catList)
            {
                lbCategorien.Items.Add(cat.Naam);
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie();
            cat.Naam = tbNaam.Text;
            cat.Parent = smsr.GetCategorieMetNaam(lbCategorien.SelectedItem.ToString()).ID;
            smsr.CategorieToevoegen(cat);

            if (lbCategorien.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een hoofdcategorie.");
            }
            else
            {
                MessageBox.Show(cat.Naam + " Toegevoegd");

                Close();
            }
        }

        private void tbCategorieZoeken_TextChanged(object sender, EventArgs e)
        {
            lbCategorien.Items.Clear();
            catList = smsr.CategorieZoeken(tbCategorieZoeken.Text);

            foreach (Categorie cat in catList)
            {
                lbCategorien.Items.Add(cat.Naam);
            }
        }
    }
}
