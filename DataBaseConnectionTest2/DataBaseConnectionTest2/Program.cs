using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseConnectionTest2
{
    class Program
    {
        static void Main(string[] args)
        {

            ConnectionTosql obj = new ConnectionTosql();
            obj.openConnection();
            obj.closeConnection();
            Console.ReadLine();

        }
    }
}
