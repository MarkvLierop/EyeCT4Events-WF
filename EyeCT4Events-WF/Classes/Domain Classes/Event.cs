using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Event
    {
        public string Beschrijving { get; set; }
        public DateTime DatumTot { get; set; }
        public DateTime DatumVan { get; set; }
        public int ID { get; set; }
        public string Locatie { get; set; }
        public string Naam { get; set; }
        
        private Font font;
        public Event()
        {
            font = new Font("Arial", 13);
        }
        public void DrawEventData(Graphics g, int y)
        {
            // Event Naam
            g.DrawString(Naam, font, Brushes.Black, new Point(0, y));
            // Event datum van / tot
            g.DrawString(DatumVan + " " + DatumTot, font, Brushes.Black, new Point(0, y));
            // Locatie
            g.DrawString("Locatie: " + Locatie, font, Brushes.Black, new Point(0, y));
            // Beschrijving
            g.DrawString("Beschrijving: \n" + Beschrijving, font, Brushes.Black, new Point(0, y));
        }
    }
}
