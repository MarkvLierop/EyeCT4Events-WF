using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    class Gebruiker
    {
        public string Achternaam { get; set; }
        public int GebruikersID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string GebruikerType { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Voornaam { get; set; }
        public string Wachtwoord { get; set; }
        public bool Aanwezig { get; set; }

        private List<Media> MediaList;
        private List<Reactie> ReactieList;
        private List<Uitgeleend_materiaal> UitgeleendMateriaal;
    }
}
