using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Exceptions
{
    class NoDatabaseConnectionException : Exception
    {
        public NoDatabaseConnectionException(string message) 
            : base("No database connection exists.")
        {
        }
    }
}
