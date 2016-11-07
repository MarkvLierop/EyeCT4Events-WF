using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    class Event
    {
        public string Beschrijving { get; set; }
        public DateTime DatumTot { get; set; }
        public DateTime DatumVan { get; set; }
        public int ID { get; set; }
        public string Locatie { get; set; }
        public string Naam { get; set; }

        public Event()
        {

        }
    }
}
