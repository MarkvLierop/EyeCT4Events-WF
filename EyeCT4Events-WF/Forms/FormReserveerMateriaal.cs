using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Forms;
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
    public partial class FormReserveerMateriaal : Form
    {
        Gebruiker medewerker;
        Gebruiker bezoeker;
        Reservering reservering;
        List<Materiaal> Materialen = new List<Materiaal>();
        List<Uitgeleend_materiaal> GewensteMaterialen = new List<Uitgeleend_materiaal>();
        

        public FormReserveerMateriaal(Gebruiker Bezoeker, Gebruiker Medewerker, Reservering reservering)
        {
            InitializeComponent();

            this.reservering = reservering;
            dateTimePicker1.MinDate = reservering.DatumVan;
            dateTimePicker1.MaxDate = reservering.DatumTot;
            // sdfsdf
            nudAantal.Enabled = false;

            medewerker = Medewerker;
            bezoeker = Bezoeker;

            labelHuurder.Text = bezoeker.ToString();
            lblMedewerker.Text = medewerker.ToString();

            RepositoryMateriaal rm = new RepositoryMateriaal(new MSSQLReserveren());

            try
            {
                Materialen = rm.HaalMaterialenOp();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Kan materiaal niet ophalen : \n" + exc.Message);
            }

            Ververs();
        }
        public FormReserveerMateriaal(Gebruiker Bezoeker, Gebruiker Medewerker)
        {
            InitializeComponent();
            
            // sdfsdf
            nudAantal.Enabled = false;

            medewerker = Medewerker;
            bezoeker = Bezoeker;

            labelHuurder.Text = bezoeker.ToString();
            labelHuurder.Width = bezoeker.ToString().Length;
            lblMedewerker.Text = medewerker.ToString();

            RepositoryMateriaal rm = new RepositoryMateriaal(new MSSQLReserveren());

            try
            {
                Materialen = rm.HaalMaterialenOp();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Kan materiaal niet ophalen : \n" + exc.Message);
            }

            Ververs();
        }
        public void Ververs()
        {
            lbBeschikbareMaterialen.Items.Clear();
            lbGekozenMaterialen.Items.Clear();

            foreach (Materiaal m in Materialen)
            {
                if(m.Voorraad > 0)
                {
                    lbBeschikbareMaterialen.Items.Add(m.ToString());
                }
                
            }

            foreach (Uitgeleend_materiaal u in GewensteMaterialen)
            {
                lbGekozenMaterialen.Items.Add(u);
            }
        }

        private void ReserveerMateriaal_Load(object sender, EventArgs e)
        {
          //Laad alle voorraat uit de database 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepositoryMateriaal rm = new RepositoryMateriaal(new MSSQLReserveren());

            try
            {
                foreach (Uitgeleend_materiaal u in GewensteMaterialen)
                {

                    rm.ReserveerMateriaal(u.Gebruiker, u.MateriaalID, u.Aantal, u.UitleenDatum);
                }

                foreach (Materiaal m in Materialen)
                {
                    rm.WerkVoorraadBij(m.Voorraad, m.MateriaalID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Materiaal gereserveerd.");
            FormMedewerkerMainMenu fmmm = new FormMedewerkerMainMenu(medewerker);
            fmmm.Show();
            this.Close();
            
        }

        private void lbBeschikbareMaterialen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbBeschikbareMaterialen.SelectedIndex >= 0)
            {
                nudAantal.Enabled = true;
                Materiaal gekozen = Materialen[lbBeschikbareMaterialen.SelectedIndex];
                nudAantal.Maximum = gekozen.Voorraad;
            }

            else
            {
                nudAantal.Enabled = false;
            }

        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            Materiaal material = new Materiaal(); 
            Uitgeleend_materiaal gewenstemateriaal = new Uitgeleend_materiaal();
            material = Materialen[lbBeschikbareMaterialen.SelectedIndex];
            material.Voorraad -= Convert.ToInt32(nudAantal.Value);

            gewenstemateriaal.Aantal = Convert.ToInt32(nudAantal.Value);
            gewenstemateriaal.Gebruiker = bezoeker.ID;
            gewenstemateriaal.MateriaalNaam = material.Naam;
            gewenstemateriaal.UitleenDatum = dateTimePicker1.Value;
            gewenstemateriaal.MateriaalID = material.MateriaalID;

            GewensteMaterialen.Add(gewenstemateriaal);

            Ververs();
        }

        private void btnGeenMateriaal_Click(object sender, EventArgs e)
        {
            FormMedewerkerMainMenu fmmm = new FormMedewerkerMainMenu(medewerker);
            fmmm.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }
    }
}
