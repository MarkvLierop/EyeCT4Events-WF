using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Materiaal
    {
        public int MateriaalID { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public int Voorraad { get; set; }

        public Materiaal()
        {

        }

        public override string ToString()
        {
            return "Item: " + Naam + " Prijs: " + Prijs + " Aantal beschikbaar: " + Voorraad;
        }
    }
}
