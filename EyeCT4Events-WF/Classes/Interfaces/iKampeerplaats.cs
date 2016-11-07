using EyeCT4Events_WF.Classes;
using System.Collections.Generic;

namespace EyeCT4Events_WF.Classes.Interfaces
{
    public interface IKampeerplaats
    {
        List<Kampeerplaats> KampeerplaatsenOpvragen(bool comfort, bool invalide, bool lawaai, string eigentent,
                                      string bungalow, string bungalino, string blokhut, string stacaravan, string huurtent);

        List<Kampeerplaats> AlleKampeerplaatsenOpvragen();

        void ReserveringPlaatsen();
    }
}
