using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    class Kampeerplaats
    {
        public List<Gebruiker> gebruikersOpLocatie { get; private set; }
        public List<string> Eigenschappen { get; set; }
        public int MaxPersonen { get; set; }
        public int PlaatsID { get; set; }
        public string Type { get; set; }

        public Kampeerplaats()
        {

        }
    }
}
