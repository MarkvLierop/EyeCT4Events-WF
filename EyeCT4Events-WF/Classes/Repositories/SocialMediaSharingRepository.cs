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

        public List<Categorie> GetAlleCategorien()
        {
            return ISM.GetAlleCategorien();
        }
        public void CategorieToevoegen(Categorie cat)
        {
            ISM.CategorieToevoegen(cat);
        }
        public Categorie GetCategorieMetNaam(string naam)
        {
            return ISM.GetCategorieMetNaam(naam);
        }

        public List<Categorie> CategorieZoeken(string naam)
        {
            return ISM.CategorieZoeken(naam);
        }

        public void MediaToevoegen(Media media)
        {
            ISM.MediaToevoegen(media);
        }
    }
}
