using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv0104.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate() 
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        public Customer()
        {
            
        }
        public Customer Retrieve(int custumerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public void Save(Customer custumer)
        {
            
        }
    }
}