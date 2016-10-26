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
        void ToevoegenCategorie(Categorie cat);
        void ToevoegenMedia(Media media);
        void ToevoegenLike(Gebruiker gebruiker, int mediaID, int reactieID, int aantalLikes);
        Categorie GetCategorieMetNaam(string naam);
        Media GetMediaByID(int ID);
        int AantalLikesOpvragen(int mediaID, int reactieID);
        List<Categorie> ZoekenCategorie(string naam);
    }
}
