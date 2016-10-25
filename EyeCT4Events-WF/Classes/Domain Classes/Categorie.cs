using EyeCT4Events_WF.Classes.Interfaces;
using EyeCT4Events_WF.Classes.Repositories;
using EyeCT4Events_WF.Persistencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int Parent { get; set; }

        public Categorie()
        {

        }

        public void DrawNaam(Graphics g, int count)
        {
            int fontSize = 14;
            g.DrawString(Naam, new Font("Arial", fontSize), Brushes.Black, new Point(0, 0 + (count * fontSize)));
        }
    }
}
