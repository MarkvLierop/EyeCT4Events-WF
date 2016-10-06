using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Categorie
    {
        public int CategorieID { get; set; }
        public string CategorieNaam { get; set; }
        public int ParentCategorie { get; set; }
        public List<Categorie> SubCategorien { get; private set; }

        public Categorie()
        {

        }
    }
}
