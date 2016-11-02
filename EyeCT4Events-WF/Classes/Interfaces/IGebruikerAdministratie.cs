using EyeCT4Events_WF.Classes;
using System.Collections.Generic;

namespace EyeCT4Events_WF.Interfaces
{
    public interface IGebruikerAdministratie
    {
        List<Gebruiker> LijstAanwezigePersonen();

        bool Inloggen(string gebruikersnaam, string wachtwoord);

        Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam);
    }
}
