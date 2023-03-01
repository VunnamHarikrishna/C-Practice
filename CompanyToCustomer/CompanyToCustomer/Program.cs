using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyToCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            //items data
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();

            item1.ItemId = 1;
            item1.ItemName="ball";

            item2.ItemId = 2;
            item2.ItemName = "dall";

            item3.ItemId = 3;
            item3.ItemName = "pen";           
            
            OrderItems orderItems1 = new OrderItems();
            OrderItems orderItems2 = new OrderItems();
            OrderItems orderItems3 = new OrderItems();

            orderItems1.orderId = 1;
            orderItems1.setItemlist(item1);

            orderItems2.orderId = 1;
            orderItems2.setItemlist(item2);

            orderItems3.orderId = 3;
            orderItems3.setItemlist(item3);



        }
    }
}
