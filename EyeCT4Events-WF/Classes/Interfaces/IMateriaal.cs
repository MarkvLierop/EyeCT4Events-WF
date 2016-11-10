using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Interfaces
{
    public interface IMateriaal
    {
        List<Materiaal> HaalMaterialenOp();

        void ReserveerMateriaal(int gebruikerid, int materiaalid, int aantal, DateTime datum);

        void WerkVoorraadBij(int voorraad, int id);

        void ToevoegenMateriaal(string naam, decimal prijs, decimal vooraad);
    }
}
