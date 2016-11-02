using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Kampeerplaats
    {
        public List<Gebruiker> gebruikersOpLocatie { get; private set; }
        public List<string> Eigenschappen { get; set; }
        public int MaxPersonen { get; set; }
        public int PlaatsID { get; set; }
        public string Type { get; set; }
        public int Comfort { get; set; }
        public int Invalide { get; set; }
        public int Lawaai { get; set; }

        public Kampeerplaats()
        {

        }

        public bool CheckOfBezoekersAanwezigZijn()
        {
            if (gebruikersOpLocatie.Count < 1)
            {
                return false;
            }
            return true;
        }
    }
}
