using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Exceptions
{
    class FoutBijOpslaanBestandException : Exception
    {
        public FoutBijOpslaanBestandException(string message) 
            : base("Bestand kan niet opgeslagen worden. \n"+ message)
        {
        }
    }
}
