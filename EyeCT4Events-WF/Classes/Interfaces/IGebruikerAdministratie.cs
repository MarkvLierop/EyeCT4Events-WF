﻿using EyeCT4Events_WF.Classes;
using System.Collections.Generic;

namespace EyeCT4Events_WF.Interfaces
{
    public interface IGebruikerAdministratie
    {
        List<Gebruiker> LijstAanwezigePersonen();
        void ZetBezoekerOpAfwezig(int gebruikerID);
        void ZetBezoekerOpAanwezig(int gebruikerID);
        List<Gebruiker> GezochteBezoekersOphalen(string zoekopdracht);
        Gebruiker Inloggen(string gebruikersnaam, string wachtwoord);
        Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam);
        Gebruiker GetGebruikerByID(int ID);

    }
}
