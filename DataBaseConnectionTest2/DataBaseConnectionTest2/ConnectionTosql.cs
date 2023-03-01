using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBaseConnectionTest2
{
    class ConnectionTosql
    {
        public static string str = ConfigurationManager.ConnectionStrings["Manisha"].ConnectionString;
        public static SqlConnection conection = new SqlConnection(str); 

        public SqlConnection GetConnection()
        {
            return conection;
        }
        public void openConnection()
        {
            conection.Open();
            Console.WriteLine("connection opend");
        }
        public void closeConnection()
        {
            conection.Close();
            Console.WriteLine("connection closed");
        }

    }
}
