using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Interfaces
{
    public interface ISocialMediaSharing
    {
        List<Categorie> AlleCategorienOpvragen();
        List<Media> AlleMediaOpvragen();
        List<Reactie> AlleReactiesOpvragen();
        void ToevoegenCategorie(Categorie cat);
        void ToevoegenMedia(Media media);
        void ToevoegenLikeInMediaOfReactie(Gebruiker gebruiker, int mediaID, int reactieID);
        void ToevoegenReactie(Reactie reactie);
        void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID);
        Categorie GetCategorieMetNaam(string naam);
        Media GetMediaByID(int ID);
        List<Categorie> ZoekenCategorie(string naam);
        List<Media> ZoekenMedia(string zoekterm);
    }
}
