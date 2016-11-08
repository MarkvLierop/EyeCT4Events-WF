using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Exceptions
{
    class DatabaseConnectionAlreadyCloseException : Exception
    {
        public DatabaseConnectionAlreadyCloseException(string message) 
            : base("De database connectie is al gesloten: "+ message)
        {
        }
    }
}
