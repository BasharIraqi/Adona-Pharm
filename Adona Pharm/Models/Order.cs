using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Order
    {
        public Order()
        {
            Customers = new HashSet<Customer>();
            Products = new HashSet<Product>();
        }

        public int OrderId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public decimal? Price { get; set; }
        public int? NumberOfProducts { get; set; }
        public int? NumberOfOrders { get; set; }
        public DateTime? ReperationDate { get; set; }
        public DateTime? ResieveDate { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
