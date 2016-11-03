﻿using EyeCT4Events_WF.Classes;
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
    public partial class FormMediaReageren : Form
    {
        RepositorySocialMediaSharing rsms;

        Gebruiker gebruiker;
        string mediaID;
        public FormMediaReageren(Gebruiker gebruiker, string mediaID)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.mediaID = mediaID;
        }

        private void btnReactiePlaatsen_Click(object sender, EventArgs e)
        {
            rsms = new RepositorySocialMediaSharing(new MSSQL_Server());

            Reactie reactie = new Reactie();
            reactie.DatumTijd = DateTime.Now;
            reactie.GeplaatstDoor = gebruiker.GebruikersID;
            reactie.Inhoud = txtReactieInhoud.Text;
            reactie.Media = Convert.ToInt32(mediaID);

            rsms.ToevoegenReactie(reactie);

            MessageBox.Show("Reactie Toegevoegd");
            Close();
        }
    }
}
