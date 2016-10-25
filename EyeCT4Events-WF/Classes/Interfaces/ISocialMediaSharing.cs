using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Interfaces
{
    public interface ISocialMediaSharing
    {
        List<Categorie> GetAlleCategorien();
        void CategorieToevoegen(Categorie cat);
        Categorie GetCategorieMetNaam(string naam);
        List<Media> GetAlleMedia();
        List<Categorie> CategorieZoeken(string naam);
    }
}
