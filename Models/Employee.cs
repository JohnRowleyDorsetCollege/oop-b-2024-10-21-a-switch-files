using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace oop_b_2024_10_21_a_switch.Models
{

    public class Employee
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        //public Address Address { get; set; }
        //public Job Job { get; set; }

        public override string ToString()
        {
            return $"{FirstName} | {LastName}";
        }
    }

    public class EmployeeFaker : Faker<Employee>
    {
        public EmployeeFaker()
        {
            RuleFor(x => x.FirstName, y => y.Name.FirstName());
            RuleFor(e => e.LastName, f => f.Name.LastName());

        }
    }

}
