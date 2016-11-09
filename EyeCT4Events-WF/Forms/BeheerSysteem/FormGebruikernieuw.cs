using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
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
    public partial class FormGebruikernieuw : Form
    {
        Gebruiker gebruiker;
        public FormGebruikernieuw()
        {
            InitializeComponent();

            cbType.Items.Add("Medewerker");
            cbType.Items.Add("Beheerder");
        }

        private void FormGebruikernieuw_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistreer_Click(object sender, EventArgs e)
        {
            if (TbAchternaam.Text != null & TbVoornaam.Text != null & TbGebruikersnaam.Text != null & TbWachtwoord.Text != null & TbBevestig.Text != null)
            {
                if (TbWachtwoord.Text == TbBevestig.Text)
                {
                    RepositoryGebruiker RG = new RepositoryGebruiker(new MSSQLGebruiker());
                    if (cbType.SelectedText == "Medewerker")
                    {
                        gebruiker = new Medewerker();
                    }
                    else if (cbType.SelectedText == "Beheerder")
                    {
                        gebruiker = new Beheerder();
                    }
                    gebruiker.Achternaam = TbAchternaam.Text;
                    gebruiker.Voornaam = TbVoornaam.Text;
                    gebruiker.Tussenvoegsel = TbTussenvoegsel.Text;
                    gebruiker.Wachtwoord = TbWachtwoord.Text;
                    try
                    {
                        RG.GebruikerRegistreren(gebruiker);
                        MessageBox.Show("Nieuw account geregistreerd.");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (FoutBijUitvoerenQueryException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn ingevuld.");
            }

        }

        private void BtnBack_Click(object sender, EventArgs e){
            Gebruikersbeheer G = new Gebruikersbeheer();
            G.Show();
            this.Close();
        }
    }
}
