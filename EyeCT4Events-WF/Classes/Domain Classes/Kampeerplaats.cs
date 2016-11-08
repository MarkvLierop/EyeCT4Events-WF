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
        public int MaxPersonen { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public int Comfort { get; set; }
        public int Invalide { get; set; }
        public int Lawaai { get; set; }

        public Kampeerplaats()
        {
            gebruikersOpLocatie = new List<Gebruiker>();
        }

        public bool CheckOfBezoekerOpKampeerplaatsIs(Gebruiker g)
        {
            if (gebruikersOpLocatie.Contains(g))
            {
                return true;
            }
            return false;
        }
    }
}
