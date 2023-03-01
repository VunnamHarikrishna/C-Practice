using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CsharptoSqlConnection
{
    class Program
    {
  
        static void Main(string[] args)
        {
            CreateTable();
            //ReadData();
            UpdateData();
            ReadData();
            DeleteTable();
      
            Console.ReadLine();
        }
        static ConnectionToDataBase obj = new ConnectionToDataBase();
        static SqlCommand cm;
        // create a table for demo database 
        public static void CreateTable()
        {
            try
            {


                 cm = new SqlCommand("DemoProcedure", obj.getConnection());
               
                obj.OpenConnection();
                cm.CommandType = CommandType.StoredProcedure;
                cm.ExecuteNonQuery();
                Console.WriteLine("table created");
                //}
                
                bool check = true;
                do
                {
                    Console.WriteLine("enter Id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Id");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter Id");
                    int age = int.Parse(Console.ReadLine());

                    cm = new SqlCommand($"insert into Student values({id},'{name}',{age}) ", obj.getConnection());
                    cm.ExecuteNonQuery();
                    
                    Console.WriteLine("enter 1 if you want enter anothor student : "  );
                    int t= int.Parse(Console.ReadLine());
                    if (t!=1) { check = false; }

                } while (check);
               
               
                Console.WriteLine("qureey's excuted sucessfully");
            }
            catch
            {
                Console.WriteLine("sonting wrong");
            }
            finally
            {
                obj.CloseConnection();
            }

        }

        //read operation
        public static void ReadData()
        {
            //try
            //{


            string str = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;

            using (SqlConnection con = new SqlConnection(str))
                {
                con.Close();
                con.Open();
                    cm = new SqlCommand("select * from Persons ", obj.getConnection());
                    SqlDataReader datas = cm.ExecuteReader();//1
                    Console.WriteLine("querry excuted succesfuly2");
                    Console.WriteLine("--------------------------------------------------------");

                    while (datas.Read())//2
                    {
                        Console.WriteLine(datas["Id"] + " " + datas["name"]);//3
                    }

                }
                //    cm = new SqlCommand("select * from Persons ", obj.getConnection());
                //    obj.OpenConnection();

                //    SqlDataReader data = cm.ExecuteReader();//1

                //    Console.WriteLine("querry excuted succesfuly2");
                //    Console.WriteLine("--------------------------------------------------------");

                //    while (data.Read())//2
                //    {
                //        Console.WriteLine(data["Id"] + " " + data["name"]);//3
                //    }

                //}
                //catch
                //{
                //    Console.WriteLine("error occured");
                //}
                //finally
                //{

                //    obj.CloseConnection();
            //}


        }

        //update
        public static void UpdateData()
        {
            try
            {
                obj.OpenConnection();
                Console.WriteLine("enter id to to update that row  ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enrer name value to update");
                string str = Console.ReadLine();

                cm = new SqlCommand($"update Persons set name='{str}' where Id={id} ", obj.getConnection());
                cm.ExecuteNonQuery();
                Console.WriteLine("querry excuted sucessfully");
            }
            catch
            {
                Console.WriteLine("something wrong. ");
            }
            finally
            {
                obj.CloseConnection();
            }

        }

        //delete table
        public static void DeleteTable()
        {
            try
            {
                cm = new SqlCommand("drop table Persons;", obj.getConnection());
                obj.OpenConnection();
                cm.ExecuteNonQuery();
                Console.WriteLine("table deleted");
            }
            catch
            {
                Console.WriteLine("somthhing went wrong");
            }
            finally
            {
                obj.CloseConnection();
            }

        }
    }
}
/*
 
            //c - create r-read u-update d-delete

//            SqlConnection con = null;
//            SqlDataReader data=null;
//            try
//            {
//                con = new SqlConnection("data source=DESKTOP-9UJ8CBG; database=Demo; integrated security=true");

//                con.Open();
////----------------------------------------------------------------------------------------------

//                SqlCommand cm = new SqlCommand("select * from Sample ",con);
//                data = cm.ExecuteReader();
//                while (data.Read())
//                {
//                    Console.WriteLine(data["id"] + " " + data["name"]);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("somting not good");
//            }
//            finally
//            {
//                con.Close();
//                Console.WriteLine("con closed");
//            }
           
 
  //using (SqlCommand command = new SqlCommand("CREATE TABLE Customer(First_Name char(50),Last_Name char(50),City char(50));", obj.getConnection()))
                // {
                //     obj.OpenConnection();
                //     command.ExecuteNonQuery();
                // }
 
 
 */