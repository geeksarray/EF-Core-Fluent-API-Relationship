using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Fluent_API_Relationship.Entity
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<DeptEmployee> DeptEmployee { get; set; }
    }
}
