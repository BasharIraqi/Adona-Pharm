using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string CategoryName { get; set; }
        public string SupplyCompany { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
