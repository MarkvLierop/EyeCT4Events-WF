using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    public class RepositoryGebruiker
    {
        IGebruikerAdministratie context;

        public RepositoryGebruiker(IGebruikerAdministratie context)
        {
            this.context = context;
        }
        public List<Gebruiker> LijstBezoekers()
        {
            return context.LijstAanwezigePersonen();
        }
        public bool CheckLogIn(string gebruikersnaam, string wachtwoord)
        {
            bool logincorrect;

            logincorrect = context.Inloggen(gebruikersnaam, wachtwoord);

            return logincorrect;
        }
        public Gebruiker LogIn(string gebruikersnaam)
        {
            Gebruiker ingelogde;

            ingelogde = context.GetGebruikerByGebruikersnaam(gebruikersnaam);

            return ingelogde;
        }
        public Gebruiker GetGebruikerByGebruikersnaam (string gebruikersnaam)
        {
            return context.GetGebruikerByGebruikersnaam(gebruikersnaam);
        }
        public Gebruiker GetGebruikerByID (int ID)
        {
            return context.GetGebruikerByID(ID);
        }

        public List<Gebruiker> GezochteBezoekersOphalen(string zoekopdracht)
        {
            return context.GezochteBezoekersOphalen(zoekopdracht);
        }
    }
}
