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

namespace EyeCT4Events_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GebruikerRepository gr = new GebruikerRepository(new MSSQL_Server());
            
        }
    }
}
