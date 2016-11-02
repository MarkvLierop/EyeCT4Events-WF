using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Reservering
    {
        public List<Gebruiker> GebruikerList { get; private set; }
        public DateTime DatumTot { get; set; }
        public DateTime DatumVan { get; set; }
        public int ReserveringID { get; set; }

        public Reservering()
        {

        }
    }
}
