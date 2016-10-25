using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    public class GebruikerRepository
    {
        IGebruikerAdministratie context;

        public GebruikerRepository(IGebruikerAdministratie context)
        {
            this.context = context;
        }

        public List<Gebruiker> LijstBezoekers()
        {
            return context.LijstAanwezigePersonen();
        }
       
        public Gebruiker GetGebruikerByID(int id)
        {
            return context.GetGebruikerByID(id);
        }
    }
}
