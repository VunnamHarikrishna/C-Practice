using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyToCustomer
{
    public class Customers
    {
        public RegisterCustomerstatus Customer { get; set; }

        private List<Order> Orders = new List<Order>();

        public void setOrders(Order Orderdata)
        {
            Orders.Add(Orderdata);
        }
        public List<Order> GetOrders()
        {
            return Orders;
        }
    }
}