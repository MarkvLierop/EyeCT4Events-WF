using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    class DBcon
    {
        SqlConnection con;

        public DBcon()
        {
            Connect();
        }
        private void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=mssql.fhict.local;Database=dbi327544;User Id=dbi327544;Password=PTS16;";
            con.Open();
        }
    }
}
