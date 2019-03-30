using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Fluent_API_Relationship.Entity
{
    public class DeptEmployee
    {
        public int DeptEmpID { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
