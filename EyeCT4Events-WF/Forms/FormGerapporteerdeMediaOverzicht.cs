using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events_WF.Persistencies;
using EyeCT4Events_WF.Classes.Persistencies;

namespace EyeCT4Events_WF.Forms
{
    public partial class FormGerapporteerdeMediaOverzicht : Form
    {
        private RepositorySocialMediaSharing rsms;
        private List<Media> gerapporteerdeMedia;
        private Gebruiker beheerder;
        private bool formLoad;
        private void VerbergThreshholdWegschrijven()
        {
            using (StreamWriter swVerbergThreshHold = new StreamWriter("Settings.txt", false))
            {
                swVerbergThreshHold.WriteLine("VerbergThreshhold:" + nudVerbergThreshhold.Value);
            }
        }
        private void MediaLijstVullen()
        {
            lsGerapporteerdeMediaOverzicht.Items.Clear();
            gerapporteerdeMedia = rsms.AlleGerapporteerdeMediaOpvragen();

            foreach (Media m in gerapporteerdeMedia)
            {
                lsGerapporteerdeMediaOverzicht.Items.Add(m.ToString());
            }
        }
        private void BekijkMedia()
        {
            if (lsGerapporteerdeMediaOverzicht.SelectedIndex != -1)
            {
                FormMediaBekijken fmb = new FormMediaBekijken(beheerder, gerapporteerdeMedia[lsGerapporteerdeMediaOverzicht.SelectedIndex]);
                fmb.ShowDialog();

                if (fmb.DialogResult == DialogResult.OK)
                {
                    MediaLijstVullen();
                }
            }
        }
        public FormGerapporteerdeMediaOverzicht(Gebruiker beheerder)
        {
            InitializeComponent();
            this.beheerder = beheerder;
            rsms = new RepositorySocialMediaSharing(new MSSQLSMS());
            #region Verbergthreshhold Ophalen of wegschrijven
            if (!File.Exists("Settings.txt"))
            {
                try
                {
                    VerbergThreshholdWegschrijven();
                }
                catch (IOException ioE)
                {
                    MessageBox.Show("Fout bij het wegschrijven van de Media Verberg Threshhold \n" + ioE.Message);
                }
            }
            else
            {
                formLoad = true;
                try
                {
                    using (StreamReader srVerbergThreshHold = new StreamReader("Settings.txt", false))
                    {
                        string line = srVerbergThreshHold.ReadLine();
                        string[] data = line.Split(':');
                        nudVerbergThreshhold.Value = Convert.ToDecimal(data[data.Count() - 1]);
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show("Fout bij het ophalen van de Media Verberg Threshhold \n" + e.Message);
                }
            }
            #endregion

            MediaLijstVullen();
        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            BekijkMedia();
        }

        private void nudVerbergThreshhold_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!formLoad)
                {
                    VerbergThreshholdWegschrijven();
                    MediaLijstVullen();
                }
                else
                {
                    formLoad = false;
                }
            }
            catch (IOException ioE)
            {
                MessageBox.Show("Fout bij het wegschrijven van gegevens \n"+ioE.Message);
            }
        }

        private void FormGerapporteerdeMediaOverzicht_DoubleClick(object sender, EventArgs e)
        {
            BekijkMedia();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
