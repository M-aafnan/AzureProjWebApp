using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PracADOWeb.Models
{
    public class DBConnection
    {
        private static SqlConnection connection;
        private DBConnection()
        {
            
        }
        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                string constr = ConfigurationManager.ConnectionStrings["SchoolManagement"].ToString();
                connection = new SqlConnection(constr);
                connection.Open();

            }
            return connection; 
        }
    }
}