using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;

namespace EyeCT4Events_WF
{
    public partial class FormReserveerPlaats : Form
    {
        RepositoryKampeerPlaatsen kpr = new RepositoryKampeerPlaatsen(new MSSQL_Server());
        List<Kampeerplaats> kampeerplaatsen = new List<Kampeerplaats>();
        Gebruiker bezoeker;
        Gebruiker medewerker;

        bool comfort;
        bool lawaai;
        bool invalide;
        string bungalow ;
        string bungalino ;
        string blokhut ;
        string stacaravan ;
        string huurtent ;
        string eigentent ;



        public FormReserveerPlaats()
        {
            InitializeComponent();
            //HaalKampeerplaatsenOp();
        }

        public FormReserveerPlaats(Gebruiker medewerker, Gebruiker Bezoeker)
        {
           
            lblMedewerker.Text = medewerker.Voornaam + " " + medewerker.Achternaam;
            bezoeker = Bezoeker;

            groupBox2.Enabled = false;

        }

        public void HaalKampeerplaatsenOp()
        {
            ResetGegevens();

            if (cbBlokhut.Checked) { blokhut = "blokhut"; }
            if (cbBungalino.Checked) { blokhut = "bungalino"; }
            if (cbBungalow.Checked) { blokhut = "bungalow"; }
            if (cbEigenTent.Checked) { blokhut = "eigentent"; }
            if (cbHuurTent.Checked) { blokhut = "huurtent"; }
            if (cbStaCaravan.Checked) { blokhut = "stacaravan"; }
            if (rbComfort.Checked) { comfort = true; }
            if (rbInvalide.Checked) { invalide = true; }
            if (rbLawaai.Checked) { lawaai = true; }
            kampeerplaatsen = kpr.KampeerplaatsenOpvragen(comfort, invalide, lawaai, eigentent, bungalow, bungalino, blokhut, stacaravan, huurtent);

            Ververs();
        }

        public void ResetGegevens()
        {
            kampeerplaatsen.Clear();
            comfort = false;
            lawaai = false;
            invalide = false;
            bungalow = "";
            bungalino = "";
            blokhut = "";
            stacaravan = "";
            huurtent = "";
            eigentent = "";
        }

        public void Ververs()
        {
            lbKampeerplaatsen.Items.Clear();

            foreach (Kampeerplaats k in kampeerplaatsen)
            {
                lbKampeerplaatsen.Items.Add(k);
            }
                        
        }


        private void ReserveerPlaats_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservering reservering = new Reservering(medewerker.GebruikersID, kampeerplaatsen.Contains.)

            Kampeerplaats plaats;
            
        }

        private void rbInvalide_CheckedChanged(object sender, EventArgs e)
        {

            
            if (rbInvalide.Checked)
            {
                cbBungalow.Checked = true;
                groupBox2.Enabled = false;
                cbBlokhut.Checked = false;
                cbBungalino.Checked = false;
                cbEigenTent.Checked = false;
                cbHuurTent.Checked = false;
                cbStaCaravan.Checked = false;
                HaalKampeerplaatsenOp();
            }

            else

                groupBox2.Enabled = true;
            HaalKampeerplaatsenOp();


        }

        private void rbComfort_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            HaalKampeerplaatsenOp();
        }

        private void rbLawaai_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            HaalKampeerplaatsenOp();
        }

        private void cbBungalow_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }

        private void cbStaCaravan_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }

        private void cbBlokhut_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }

        private void cbHuurTent_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }

        private void cbBungalino_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }

        private void cbEigenTent_CheckedChanged(object sender, EventArgs e)
        {
            HaalKampeerplaatsenOp();
        }
    }
}
