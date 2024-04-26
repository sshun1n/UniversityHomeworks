using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.core
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int Salary { get; set; }
        public int HoursWorked { get; set; }
        public int ToPay { get; set; }
    }
}
