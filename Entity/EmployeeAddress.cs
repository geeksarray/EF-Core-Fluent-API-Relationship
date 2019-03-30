using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Fluent_API_Relationship.Entity
{
    public class EmployeeAddress
    {
        public EmployeeAddress()
        {

        }

        public int EmployeeAddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<Employee> Employees { get; set; }

        
    }
}
