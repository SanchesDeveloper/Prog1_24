using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv0104.Models
{
    public class OrderItem
    {
        public string Product { get; set; }

        public double Quantity { get; set; }

        public double PurchasePrice { get; set; }


        public bool Validate() 
        {
            return true;
        }

        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public void Save(OrderItem orderItem)
        {
            
        }
    }
}