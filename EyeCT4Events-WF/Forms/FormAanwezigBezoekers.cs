﻿using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
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
    public partial class AanwezigBezoekers : Form
    {
        private RepositoryGebruiker rg;
        private List<Gebruiker> bezoekerLijst;
        public AanwezigBezoekers()
        {
            InitializeComponent();
        }

        private void AanwezigBezoekers_Load(object sender, EventArgs e)
        {
            bezoekerLijst = rg.LijstAanwezigeBezoekers();
        }

        private void lbSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
