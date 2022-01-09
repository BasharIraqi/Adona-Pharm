using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Amount { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RelationShip { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public int? JobId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Job Job { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
