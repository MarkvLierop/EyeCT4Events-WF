using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Events_WF.Classes.Interfaces;

namespace EyeCT4Events_WF.Classes.Repositories
{
    class RepositoryMateriaal
    {
        IMateriaal IM;

        public RepositoryMateriaal(IMateriaal im)
        {
            IM = im;
        }


        public List<Materiaal> HaalMaterialenOp()
        {
            return  IM.HaalMaterialenOp();
        }

        public void ReserveerMateriaal(int gebruikerid, int materiaalid, int aantal, DateTime datum)
        {
            IM.ReserveerMateriaal(gebruikerid, materiaalid, aantal, datum);
        }

        public void WerkVoorraadBij(int voorraad, int id)
        {
            IM.WerkVoorraadBij(voorraad, id);
        }
    }
}
