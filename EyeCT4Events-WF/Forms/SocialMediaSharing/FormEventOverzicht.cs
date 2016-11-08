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
        private RepositorySocialMediaSharing rsms;
        public FormEventOverzicht()
        {
            InitializeComponent();
            rsms = new RepositorySocialMediaSharing(new MSSQL_Server());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rsms.all
        }
    }
}
