using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Uitgeleend_materiaal
    {
        public string Gebruiker { get; set; }
        public string MateriaalNaam { get; set; }
        public DateTime UitleenDatum { get; set; }
        public int UitleenID { get; set; }

        public Uitgeleend_materiaal()
        {

        }
    }
}
