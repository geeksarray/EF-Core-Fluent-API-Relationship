using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Fluent_API_Relationship.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DeptEmployee> DeptEmployee { get; set; }
    }
}
