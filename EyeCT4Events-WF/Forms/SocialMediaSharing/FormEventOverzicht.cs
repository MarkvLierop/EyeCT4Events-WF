using EyeCT4Events_WF.Classes;
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

namespace EyeCT4Events_WF.Forms.SocialMediaSharing
{
    public partial class FormEventOverzicht : Form
    {
        private List<Event> eventlist;
        private RepositorySocialMediaSharing rsms;
        public FormEventOverzicht()
        {
            InitializeComponent();
            rsms = new RepositorySocialMediaSharing(new MSSQL_Server());

            eventlist = rsms.AlleEventsOpvragen();
            foreach (Event e in eventlist)
            {
                lsEvents.Items.Add(e.ToString());
            }
            lsEvents.SelectedIndex = 0;
            lblBeschrijving.Width = this.Width;
            lblBeschrijving.Height = 80;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void lsEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitel.Text = eventlist[lsEvents.SelectedIndex].Titel;
            lblBeschrijving.Text = "Beschrijving: \n ---------- \n"+eventlist[lsEvents.SelectedIndex].BeschrijvingInsertEnters();
            lblDatumTot.Text = "Tot: "+eventlist[lsEvents.SelectedIndex].DatumTot.ToString();
            lblDatumVan.Text = "Van: "+eventlist[lsEvents.SelectedIndex].DatumVan.ToString();
            lblLocatie.Text = "Locatie: "+eventlist[lsEvents.SelectedIndex].Locatie;
        }
    }
}
