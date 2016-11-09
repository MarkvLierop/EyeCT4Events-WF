using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
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
    public partial class FormGebruikernieuw : Form
    {
        public FormGebruikernieuw()
        {
            InitializeComponent();
        }

        private void FormGebruikernieuw_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistreer_Click(object sender, EventArgs e)
        {
            //Controleer of ieder veld ingevuld is,
            //Controleer of wachtwoord overeenkomt met bevestiging,
            //Voer alle informatie in de database in.
            //Let op, ID word automatisch ingevoerd.

            if (TbAchternaam.Text != null & TbVoornaam.Text != null & TbGebruikersnaam.Text != null & TbWachtwoord.Text != null & TbBevestig.Text != null) {
                if (TbWachtwoord.Text == TbBevestig.Text) {
                    RepositoryGebruiker RG = new RepositoryGebruiker(new MSSQL_Server());
                    

                    }
                }
            else {
                MessageBox.Show("Niet alle gegevens zijn ingevuld.");}


        }

        private void BtnBack_Click(object sender, EventArgs e){
            Gebruikersbeheer G = new Gebruikersbeheer();
            G.Show();
            this.Hide();
        }





    }
}
