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
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Forms;

namespace EyeCT4Events_WF
{
    public partial class FormReserveerPlaats : Form
    {
        RepositoryKampeerPlaatsen kpr = new RepositoryKampeerPlaatsen(new MSSQL_Server());
        List<Kampeerplaats> kampeerplaatsen = new List<Kampeerplaats>();
        Gebruiker bezoeker;
        Gebruiker medewerker;
        Kampeerplaats kampeerplaats;
        Reservering reservering;
        DateTime datumVan;
        DateTime datumTot;
        int plaatsid;
        int bezoekerid;

        int comfort;
        int lawaai;
        int invalide;
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

        public FormReserveerPlaats(Gebruiker Medewerker, Gebruiker Bezoeker)
        {
            InitializeComponent();

            medewerker = Medewerker;
            bezoeker = Bezoeker;
            lblMedewerker.Text = medewerker.Voornaam + " " + medewerker.Achternaam;

            groupBox2.Enabled = false;

        }

        public void HaalKampeerplaatsenOp()
        {
            ResetGegevens();

            if (cbBlokhut.Checked) { blokhut = "blokhut"; }
            if (cbBungalino.Checked) { bungalino = "bungalino"; }
            if (cbBungalow.Checked) { bungalow = "bungalow"; }
            if (cbEigenTent.Checked) { eigentent = "eigentent"; }
            if (cbHuurTent.Checked) { huurtent = "huurtent"; }
            if (cbStaCaravan.Checked) { stacaravan = "stacaravan"; }
            if (rbComfort.Checked) { comfort = 1; }
            if (rbInvalide.Checked) { invalide = 1; }
            if (rbLawaai.Checked) { lawaai = 1; }

            try
            {
                kampeerplaatsen = kpr.KampeerplaatsenOpvragen(comfort, invalide, lawaai, eigentent, bungalow, bungalino, blokhut, stacaravan, huurtent);
                Ververs();
            }
            catch (FoutBijUitvoerenQueryException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public void ResetGegevens()
        {
            kampeerplaatsen.Clear();
            comfort = 0;
            lawaai = 0;
            invalide = 0;
            bungalow = "''";
            bungalino = "''";
            blokhut = "''";
            stacaravan = "''";
            huurtent = "''";
            eigentent = "''";
        }

        public void Ververs()
        {
            lbKampeerplaatsen.Items.Clear();

            foreach (Kampeerplaats k in kampeerplaatsen)
            {
                lbKampeerplaatsen.Items.Add(k.ToString()) ;
            }
                        
        }


        private void ReserveerPlaats_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            kampeerplaats = kampeerplaatsen[lbKampeerplaatsen.SelectedIndex];
            datumVan = dtVan.Value;
            datumTot = dtTot.Value;
            plaatsid = kampeerplaats.ID;
            bezoekerid = bezoeker.ID;

            RepositoryKampeerPlaatsen rkp = new RepositoryKampeerPlaatsen(new MSSQL_Server());
            rkp.ReserveringPlaatsen(bezoekerid, plaatsid, datumVan, datumTot);

            reservering = rkp.HaalReserveringOpNaAanmaken(bezoekerid, plaatsid, datumVan, datumTot);

            FormBijhorendeBezoekersToevoegen fbbt = new FormBijhorendeBezoekersToevoegen(medewerker, bezoeker, reservering, kampeerplaats);


        }
    }
}
