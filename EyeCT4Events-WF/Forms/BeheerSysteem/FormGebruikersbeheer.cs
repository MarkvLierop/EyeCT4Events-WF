using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes.Persistencies;
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
    public partial class Gebruikersbeheer : Form
    {
        RepositoryGebruiker rg;
        List<Gebruiker> gebruikerlijst;
        public Gebruikersbeheer()
        {
            InitializeComponent();
            // Combobox vullen
            cbSorteer.Items.Add("ID");
            cbSorteer.Items.Add("Naam");
            cbSorteer.Items.Add("GebruikerType");
            cbSorteer.Items.Add("Aanwezig");
            cbSorteer.Items.Add("Hoofd Reserveerder");
            //wat aangepast

            // listview vullen
            lvGebruikerOverzicht.View = View.Details;
            lvGebruikerOverzicht.FullRowSelect = true;
            lvGebruikerOverzicht.Columns.Add("ID");
            lvGebruikerOverzicht.Columns.Add("Naam");
            lvGebruikerOverzicht.Columns.Add("GebruikerType");
            lvGebruikerOverzicht.Columns.Add("Aanwezig");


            rg = new RepositoryGebruiker(new MSSQLGebruiker());
            gebruikerlijst = rg.GesorteerdeGeberuikers(cbSorteer.SelectedText);
            FillListView();
        }
        private void FillListView()
        {
            lvGebruikerOverzicht.Items.Clear();
            foreach (Gebruiker g in gebruikerlijst)
            {
                ListViewItem lvi = new ListViewItem(g.ID.ToString());
                //lvi.SubItems.Add(g.Gebruikersnaam);
                lvi.SubItems.Add(g.ToString());
                lvi.SubItems.Add(g.GetGebruikerType());
                lvi.SubItems.Add(g.Aanwezig.ToString());
                lvi.UseItemStyleForSubItems = false;
                lvGebruikerOverzicht.Items.Add(lvi);

            }
        }


        private void cbSorteer_SelectedIndexChanged(object sender, EventArgs e){
            gebruikerlijst = rg.GesorteerdeGeberuikers(cbSorteer.SelectedItem.ToString());
            FillListView();
        }

        private void Gebruikersbeheer_Load(object sender, EventArgs e) {

        }
        private void BtnZoeken_Click(object sender, EventArgs e){
            gebruikerlijst = rg.ZoekenGebruiker(txtZoeken.Text);
            FillListView();
        }


        private void btSluiten_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e){
            Gebruikergegevens G = new Gebruikergegevens();
            G.Show();
            this.Hide();
        }

        private void BtAddNew_Click(object sender, EventArgs e)
        {
            // Laat FormGebruiker nieuw herkennen door de vorm.
            FormGebruikernieuw G = new FormGebruikernieuw();
            G.Show();
            this.Hide();
        }



        private void textBox1_TextChanged(object sender, EventArgs e){
            }
    }
}
