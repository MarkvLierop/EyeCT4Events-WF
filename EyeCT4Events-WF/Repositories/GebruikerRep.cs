using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Events_WF.Classes.Gebruikers;

namespace EyeCT4Events_WF.Repositories
{
    class GebruikerRep : IGebruikerAdministratie
    {
        public int ID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public string type { get; set; }

        public GebruikerRep()
        {

        }

        public void AlleBezoekersOpvragen()
        {
            throw new NotImplementedException();
        }

        public int create(Medewerker medewerker)
        {
            throw new NotImplementedException();
        }
    }
}
