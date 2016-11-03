using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Exceptions
{
    class FoutBijUitvoerenQueryException : Exception
    {
        public FoutBijUitvoerenQueryException(string message) 
            : base("De database query kan niet uitgevoerd worden. \n De volgende fout wordt meegegeven: "+message)
        {

        }
    }
}
