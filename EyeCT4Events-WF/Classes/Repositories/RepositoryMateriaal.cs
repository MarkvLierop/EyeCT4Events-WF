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


        List<Materiaal> HaalMaterialenOp()
        {
            return  IM.HaalMaterialenOp();
        }
    }
}
