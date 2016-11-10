using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Uitgeleend_materiaal
    {
        public int Gebruiker { get; set; }
        public int MateriaalID { get; set; }
        public string MateriaalNaam { get; set; }
        public DateTime UitleenDatum { get; set; }
        public int Aantal { get; set; }
        public int UitleenID { get; set; }

        public Uitgeleend_materiaal()
        {

        }

        public override string ToString()
        {
            return "Item: " + MateriaalNaam + "Aantal: " + Aantal;
        }
    }
}
