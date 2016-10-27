using EyeCT4Events_WF.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    public class SocialMediaSharingRepository
    {
        ISocialMediaSharing ISM;

        public SocialMediaSharingRepository(ISocialMediaSharing ISM)
        {
            this.ISM = ISM;
        }
        public List<Categorie> AlleCategorienOpvragen()
        {
            return ISM.AlleCategorienOpvragen();
        }
        public void ToevoegenCategorie(Categorie cat)
        {
            ISM.ToevoegenCategorie(cat);
        }
        public void ToevoegenMedia(Media media)
        {
            ISM.ToevoegenMedia(media);
        }
        public void ToevoegenLikeMediaReactie(Gebruiker gebruiker, int mediaID, int reactieID)
        {
            ISM.ToevoegenLikeInMediaOfReactie(gebruiker, mediaID, reactieID);
        }
        public void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID)
        {
            ISM.ToevoegenRapporterenMediaReactie(mediaID, reactieID);
        }
        public Media GetMediaByID(int id)
        {
            return ISM.GetMediaByID(id);
        }
        public Categorie GetCategorieMetNaam(string naam)
        {
            return ISM.GetCategorieMetNaam(naam);
        }

        public List<Categorie> ZoekenCategorie(string naam)
        {
            return ISM.ZoekenCategorie(naam);
        }
        public List<Media> ZoekenMedia (string zoekterm)
        {
            return ISM.ZoekenMedia(zoekterm);
        }
        public List<Media> AlleMediaOpvragen()
        {
            return ISM.AlleMediaOpvragen();
        }
    }
}
