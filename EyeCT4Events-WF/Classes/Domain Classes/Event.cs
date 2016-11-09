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
        public string Titel { get; set; }
        
        private Font font;
        private Font fontTitel;
        public Event()
        {
            font = new Font("Arial", 12);
            fontTitel = new Font("Arial", 16);
        }
        public void DrawEventData(Graphics g, int formWidth)
        {
            int hoogte = 18;

            // Event Naam
            g.DrawString(Titel, fontTitel, Brushes.Black, new Point(0, hoogte * 1));
            // Event datum van / tot
            g.DrawString("Van: "+ DatumVan, font, Brushes.Black, new Point(0, hoogte * 2));
            g.DrawString("Tot: " + DatumTot, font, Brushes.Black, new Point(0, hoogte * 3));
            // Locatie
            g.DrawString("Locatie: " + Locatie, font, Brushes.Black, new Point(0, hoogte * 4));
            // Beschrijving
            if (g.MeasureString("Beschrijving: \n" + Beschrijving,font).Width > formWidth)
            {
                float aantalEnters = (g.MeasureString(Beschrijving, font).Width / formWidth);
                for (int i = 0; i < Math.Floor(aantalEnters); i++)
                {
                    Beschrijving = Beschrijving.Insert(Beschrijving.Length / (int)Math.Floor((decimal)aantalEnters), "\n");
                }
            }
            g.DrawString("Beschrijving: \n" + Beschrijving, font, Brushes.Black, new Point(0, hoogte * 5));
        }
        public string GetEventData()
        {
            return Titel + "\n Van: " + DatumVan + "\n Locatie: " + Locatie + "\n";
        }
        public string BeschrijvingInsertEnters()
        {
            string beschrijving = Beschrijving;

            if (beschrijving.Length > 35)
                beschrijving = beschrijving.Insert(35, "\n");
            if (beschrijving.Length > 70)
                beschrijving = beschrijving.Insert(70, "\n");
            if (beschrijving.Length > 105)
                beschrijving = beschrijving.Insert(105, "\n");
            if (beschrijving.Length > 140)
                beschrijving = beschrijving.Insert(140, "\n");

            return beschrijving;
        }
        public override string ToString()
        {
            return Titel + " " + DatumVan.Date + "  "+ DatumVan.Hour +":"+ DatumVan.Minute;
        }
    }
}
