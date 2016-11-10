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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormCategorieToevoegen : Form
    {
        RepositorySocialMediaSharing smsr;
        List<Categorie> catList;

        public Categorie cat { get; private set; }

        public FormCategorieToevoegen()
        {
            InitializeComponent();
            smsr = new RepositorySocialMediaSharing(new MSSQLSMS());

            try
            {
                catList = smsr.AlleCategorienOpvragen().ToList();
            }
            catch (FoutBijUitvoerenQueryException e)
            {
                MessageBox.Show("Fout bij categorie toevoegen: " + e.Message);
            }
            
            foreach (Categorie cat in catList)
            {
                lbCategorien.Items.Add(cat.Naam);
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie();
            cat.Naam = tbNaam.Text;
            try
            {
                if (lbCategorien.SelectedItem != null)
                {
                    cat.Parent = smsr.GetCategorieMetNaam(lbCategorien.SelectedItem.ToString()).ID;
                    smsr.ToevoegenCategorie(cat);
                }
                else
                {
                    MessageBox.Show("Selecteer een hoofdcategorie");
                }
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (lbCategorien.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecteer een hoofdcategorie.");
            }
            else
            {
                MessageBox.Show(cat.Naam + " Toegevoegd");

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void tbCategorieZoeken_TextChanged(object sender, EventArgs e)
        {
            lbCategorien.Items.Clear();
            try
            {
                catList = smsr.ZoekenCategorie(tbCategorieZoeken.Text);
            }
            catch (FoutBijUitvoerenQueryException exc)
            {
                MessageBox.Show(exc.Message);
            }

            foreach (Categorie cat in catList)
            {
                lbCategorien.Items.Add(cat.Naam);
            }
        }
    }
}
