using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public int? PhoneNumber { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
