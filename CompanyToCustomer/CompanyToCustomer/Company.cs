using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyToCustomer
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        public List<Customers> Customers = new List<Customers>();

        private List<Item> ItemList = new List<Item>();

        public void SetItem(Item Items)
        {
            ItemList.Add(Items);
        }
        public List<Item> getItems()
        {
            return ItemList;
        }
  
        public void SetCustomers(Customers Customerdata)
        {
            Customers.Add(Customerdata);
        }
        public List<Customers> getCustomer()
        {
            return Customers;
        }
    }

   
}
