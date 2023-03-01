using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyToCustomer
{
  public  class Order
    {
        public int OrderID { get; set; }

       
        private List<OrderItems> orderItems = new List<OrderItems>();

        public void setorderitem(OrderItems orderitem)
        {
            orderItems.Add(orderitem);
        }

        public List<OrderItems> GetOrderItems()
        {
            return orderItems;
        }

       }
}
