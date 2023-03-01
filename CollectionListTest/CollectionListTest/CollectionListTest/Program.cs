using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Friends = new List<string>();
            List<string> SchoolFriends = new List<string>();
            List<string> OfficeFriends = new List<string>();
            List<string> BestFriends = new List<string>();

            // Friends list
            Friends.Add("Anju");
            Friends.Add("Hari");
            Friends.Add("Shiva");
            Friends.Add("Shanker");
            Friends.Add("Ravi");
            Friends.Add("Suman");
            Friends.Add("Roopa");

            // School Friends list

            SchoolFriends.Add("Anju");
            SchoolFriends.Add("Hari");
            SchoolFriends.Add("Shiva");
            SchoolFriends.Add("Roopa");
            SchoolFriends.Add("Suman");
            SchoolFriends.Add("Manju");
            SchoolFriends.Add("Avvi");
            SchoolFriends.Add("Sripad");

            // Office friends
            OfficeFriends.Add("Ravi");
            OfficeFriends.Add("Hari");
            OfficeFriends.Add("Anju");
            OfficeFriends.Add("Shhanker");
            OfficeFriends.Add("Shashi");
            OfficeFriends.Add("Naga");
            OfficeFriends.Add("Ganesha");
            OfficeFriends.Add("Prakash");

            foreach(string temp1 in SchoolFriends)
            {
           
                foreach (string temp2 in Friends)
                {
                    if (temp1 == temp2)
                    {
                        BestFriends.Add(temp2);
                        
                        break;
                    }
                }
            }
            Console.WriteLine("==================BestFriends=========");
            foreach (string temp in BestFriends)
            {
                Console.WriteLine(temp);
                SchoolFriends.Remove(temp);
                Friends.Remove(temp);
                OfficeFriends.Remove(temp);
            }

            Console.WriteLine("==================friends=========");
            foreach (string temp in Friends)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("==================SchoolFriends=========");
            foreach (string temp in SchoolFriends)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("==================OfficeFriends=========");
            foreach (string temp in OfficeFriends)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
