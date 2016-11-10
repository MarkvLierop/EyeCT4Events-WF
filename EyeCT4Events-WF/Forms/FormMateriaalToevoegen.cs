using EyeCT4Events_WF.Classes.Persistencies;
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

namespace EyeCT4Events_WF.Forms
{
    public partial class FormMateriaalToevoegen : Form
    {
        public FormMateriaalToevoegen()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            RepositoryMateriaal rm = new RepositoryMateriaal(new MSSQLReserveren());
            try
            {
                rm.ToevoegenMateriaal(txtNaam.Text, nudPrijs.Value, nudVoorraad.Value);
                MessageBox.Show("Materiaal Toevoegd");

                txtNaam.Text = "";
                nudVoorraad.Value = 0;
                nudPrijs.Value = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
