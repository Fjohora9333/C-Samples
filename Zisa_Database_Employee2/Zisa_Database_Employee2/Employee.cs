using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zisa_Database_Employee2
{
    public class EmployeeSortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            var res = x.Name.CompareTo(y.Name);

            return res;
        }
    }
    public class EmployeeSortByPay : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            var res = x.HourlyPayRate.CompareTo(y.HourlyPayRate);

            return res;
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double HourlyPayRate { get; set; }
        public bool IsChanged { get; set; }
        public bool IsDeleted { get; set; }

        public Employee Clone()
        {
            var e = new Employee
            {
                EmployeeId = EmployeeId,
                Name = Name,
                Position = Position,
                HourlyPayRate = HourlyPayRate,
                IsChanged = true,
                IsDeleted = false
            };

            return e;
        }
    }
}
