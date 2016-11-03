using System;
using EyeCT4Events_WF.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    class KampeerplaatsenRepository
    {

        Interfaces.IKampeerplaats context;

        public KampeerplaatsenRepository(Interfaces.IKampeerplaats context)
        {
            this.context = context;
        }

        public List<Kampeerplaats> AlleKampeerplaatsenOpvragen(bool comfort, bool invalide, bool lawaai, string eigentent,
                                     string bungalow, string bungalino, string blokhut, string stacaravan, string huurtent)
        {
            return context.AlleKampeerplaatsenOpvragen(comfort, invalide, lawaai, eigentent, bungalow, bungalino, blokhut,
                                            stacaravan, huurtent);
        }
    }
}
