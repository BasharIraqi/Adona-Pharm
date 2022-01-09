using System;
using System.Collections.Generic;

#nullable disable

namespace Adona_Pharm.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
