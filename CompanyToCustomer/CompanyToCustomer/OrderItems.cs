using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyToCustomer
{
   public class OrderItems
    {
        public int orderId { get; set; }
      
        private List<Item> Itemslist = new List<Item>();

        public void setItemlist(Item Items)
        {
            Itemslist.Add(Items);
        }
        public List<Item> GetItemslist()
        {
            return Itemslist;
        }


    }
}
