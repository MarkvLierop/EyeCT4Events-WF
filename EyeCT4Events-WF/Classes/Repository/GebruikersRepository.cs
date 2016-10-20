using EyeCT4Events_WF.Classes.Gebruikers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class GebruikersRepository
    {
        private readonly Igebruiker gebruiker;
        

        public GebruikersRepository(Igebruiker _gebruiker)
        {
            gebruiker = _gebruiker;
        }
        public bool add(string name)
        {
            bool result;
            Bezoeker Bez = new Bezoeker();
            result = gebruiker.create(Bez);
            return result;
        }
    }
}
