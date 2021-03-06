﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Interfaces
{
    public interface ISocialMediaSharing
    {
        Categorie[] AlleCategorienOpvragen();
        List<Media> AlleMediaOpvragen();
        List<Media> AlleGerapporteerdeMediaOpvragen();
        List<Reactie> AlleReactiesOpvragen();
        List<Event> AlleEventsOpvragen();
        void ToevoegenCategorie(Categorie cat);
        void ToevoegenEvent(Event ev);
        void SchoolAbusievelijkTaalgebruikOp();
        void ToevoegenMedia(Media media);
        void ToevoegenLikeInMediaOfReactie(Gebruiker gebruiker, int mediaID, int reactieID);
        void ToevoegenReactie(Reactie reactie);
        void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID);
        Categorie GetCategorieMetNaam(string naam);
        Media GetMediaByID(int ID);
        List<Categorie> ZoekenCategorie(string naam);
        List<Media> ZoekenMedia(string zoekterm, int ID);
        Media SelectLaatstIngevoerdeMedia();
        void ZetAantalKerenGerapporteerdOp0(Media media);
        void VerwijderReactie(Reactie reactie);
        void VerwijderMedia(Media media);
    }
}
