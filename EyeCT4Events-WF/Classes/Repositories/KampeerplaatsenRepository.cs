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

        public List<Kampeerplaats> LijstKampeerplaatsen()
        {
            return context.AlleKampeerplaatsenOpvragen();
        }
    }
}
