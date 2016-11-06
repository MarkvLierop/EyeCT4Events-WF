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
        public List<Gebruiker> LijstAanwezigeBezoekers()
        {
            return context.LijstAanwezigePersonen();
        }
        public void ZetGebruikerOpAanwezig(int gebruikerID)
        {
            context.ZetBezoekerOpAanwezig(gebruikerID);
        }
        public void ZetGebruikerOpAfwezig(int gebruikerID)
        {
            context.ZetBezoekerOpAfwezig(gebruikerID);
        }
        public Gebruiker GebruikerInloggen(string gebruikersnaam, string wachtwoord)
        {
            return context.Inloggen(gebruikersnaam, wachtwoord);
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
