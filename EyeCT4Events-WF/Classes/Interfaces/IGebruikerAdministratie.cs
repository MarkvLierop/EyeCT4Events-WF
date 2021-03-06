﻿using EyeCT4Events_WF.Classes;
using System.Collections.Generic;

namespace EyeCT4Events_WF.Interfaces
{
    public interface IGebruikerAdministratie
    {
        List<Gebruiker> LijstAanwezigePersonen();
        void ZetBezoekerOpAfwezig(int gebruikerID);
        void ZetBezoekerOpAanwezig(int gebruikerID);
        List<Gebruiker> ZoekenGebruiker(string GezochtenNaam);
        bool CheckOfGebruikerBestaat(string gebruikersnaam);
        List<Gebruiker> GesorteerdeGeberuikers(string filter);
        List<Gebruiker> GezochteBezoekersOphalen(string zoekopdracht);
        Gebruiker Inloggen(string gebruikersnaam, string wachtwoord);
        Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam);
        Gebruiker GetGebruikerByID(int ID);
        Gebruiker GetGebruikerByRFID(int RFID);
        void GebruikerRegistreren(Gebruiker gebruiker);
        List<string> GetBetalingsGegevens(Gebruiker gebruiker);
        void Betaal(int RFID);
    }
}
