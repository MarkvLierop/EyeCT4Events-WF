﻿using System;
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
        public Gebruikersbeheer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gebruikersbeheer_Load(object sender, EventArgs e)
        {
            cbSorteer.Items.Add("Gebruikersnaam");
            cbSorteer.Items.Add("Naam");
        }

        private void btSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbGebruikersnaam_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbGebruikersnaam.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(Convert.ToString(index));
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
           // Gebruikergegevens g = new Gebruikergegevens();
            //g.Show();
        }
    }
}
