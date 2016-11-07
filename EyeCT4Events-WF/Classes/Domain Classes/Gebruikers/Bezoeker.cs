using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Gebruikers
{
    public class Bezoeker : Gebruiker
    {
        public Bezoeker()
        {
        }

        public Bezoeker(string voornaam, string achternaam, string tussenvoegsel, string gebruikersnaam, string wachtwoord, int rfid, bool aanwezig) : base(voornaam, achternaam, tussenvoegsel, gebruikersnaam, wachtwoord, rfid, aanwezig)
        {
        }
    }


}
