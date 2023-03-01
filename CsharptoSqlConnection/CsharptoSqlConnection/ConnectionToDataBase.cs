using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CsharptoSqlConnection
{
   public class ConnectionToDataBase
    {
        private static string str = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;

        private static SqlConnection cons =new  SqlConnection(str);
       
        public SqlConnection getConnection()
        {
            return cons;
        }
       public void OpenConnection()
        {

            cons.Open();
           // Console.WriteLine("connection established");
        }
        public void CloseConnection()
        {
            cons.Close();
           // Console.WriteLine("connection closed");
        }
    
    }
}
//public void Connecting()
//{
//    using (
//             // Creating Connection  
//             SqlConnection con = new SqlConnection("data source=DESKTOP-9UJ8CBG; database=Demo; integrated security=true")
//         )
//    {
//        con.Open();
//        Console.Write Line("Connection Established Successfully");
//    }
//}