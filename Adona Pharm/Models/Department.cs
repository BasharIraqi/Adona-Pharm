using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? NumberOfEmployees { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
