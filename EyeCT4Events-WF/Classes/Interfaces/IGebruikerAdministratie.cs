using EyeCT4Events_WF.Classes;
using System.Collections.Generic;

namespace EyeCT4Events_WF.Interfaces
{
    public interface IGebruikerAdministratie
    {
        List<Gebruiker> LijstAanwezigePersonen();

        List<Gebruiker> GezochteBezoekersOphalen(string zoekopdracht);
        bool Inloggen(string gebruikersnaam, string wachtwoord);

        Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam);
        Gebruiker GetGebruikerByID(int ID);

        void GebruikerRegistreren(Gebruiker gebruiker);


    }
}
