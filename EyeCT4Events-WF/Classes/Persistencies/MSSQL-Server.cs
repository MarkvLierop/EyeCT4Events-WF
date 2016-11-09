using EyeCT4Events_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EyeCT4Events_WF.Classes.Gebruikers;
using EyeCT4Events_WF.Classes;
using EyeCT4Events_WF.Classes.Interfaces;
using System.IO;
using EyeCT4Events_WF.Exceptions;
using System.Windows.Forms;

namespace EyeCT4Events_WF.Persistencies
{
    public class MSSQL_Server  
    {
        string connString;
        SqlCommand command;
        SqlConnection SQLcon;
        SqlDataReader reader;

        Gebruiker gebruiker;
        Categorie[] categorieArray;

        /// <summary>
        ///  Private Methods
        /// </summary>
        public void Connect()
        {
            try
            {
                this.connString = "Data Source=192.168.10.11,20;Initial Catalog=EyeCT4Events;Persist Security Info=True;User ID=sa;Password=PTS16";
                SQLcon = new SqlConnection(connString);
                SQLcon.Open();
            }
            catch (SqlException e)
            {
                throw new NoDatabaseConnectionException(e.Message);
            }
        }
        public void Close()
        {
            try
            {
                SQLcon.Close();
                SQLcon.Dispose();
            }
            catch (SqlException e)
            {
                throw new DatabaseConnectionAlreadyCloseException(e.Message);
            }
        }
       
       
       
    

        
    
        /// <summary>
        /// Public Methods.
        /// </summary>
        /// <returns></returns>
        /// 
        #region Gebruikers
       

        #endregion
        #region Media
       
        #endregion
        #region Kampeer queries
        

        #endregion
        #region Events
      
        #endregion
    }
}

