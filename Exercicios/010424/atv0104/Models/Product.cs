using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv0104.Models
{
    public class Product
    {
        public string ProductName{ get; set;}

        public string Description{ get; set;}

        public string CurrentValue{ get; set;}

        public bool Validate() 
        {
            return true;
        }

        public Product Retrieve()
        {
            return new Product();
        }

        public void Save(Product product)
        {
            
        }

    }
}