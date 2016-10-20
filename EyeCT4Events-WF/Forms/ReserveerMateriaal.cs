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
    public partial class ReserveerMateriaal : Form
    {
        public ReserveerMateriaal(){
            InitializeComponent();
        }

        private void ReserveerMateriaal_Load(object sender, EventArgs e){
            VoorraadLijst.Items.Add("Usb stick");
            VoorraadLijst.Items.Add("Beeldscherm");
            VoorraadLijst.Items.Add("Muis");
            VoorraadLijst.Items.Add("Camera");
        }
    }
}
