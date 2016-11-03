using System;
using EyeCT4Events_WF.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    class RepositoryKampeerPlaatsen
    {

        Interfaces.IKampeerplaats context;

        public RepositoryKampeerPlaatsen(Interfaces.IKampeerplaats context)
        {
            this.context = context;
        }

        public List<Kampeerplaats> KampeerplaatsenOpvragen(bool comfort, bool invalide, bool lawaai, string eigentent,
                                     string bungalow, string bungalino, string blokhut, string stacaravan, string huurtent)
        {
            return context.KampeerplaatsenOpvragen(comfort, invalide, lawaai, eigentent, bungalow, bungalino, blokhut,
                                            stacaravan, huurtent);
        }

        public List<Kampeerplaats> AlleKampeerplaatsenOpvragen()
        {
            return context.AlleKampeerplaatsenOpvragen();
        }
    }
}
