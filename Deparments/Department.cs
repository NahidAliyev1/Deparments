using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deparments.Exceptions;

namespace Deparments
{
    public class Department
    {
        public string Name { get; }
        public int EmployeeLimit { get; }
        private Employee[] Employees;
        private int currentCount = 0;

        public Department(string name, int employeeLimit)
        {
            if (string.IsNullOrWhiteSpace(name) || employeeLimit <= 0)
                throw new ArgumentException("Name və employee limit düzgün daxil edilməlidir.");

            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[employeeLimit];
        }

        public void AddEmployee(Employee employee)
        {
            if (currentCount >= EmployeeLimit)
                throw new CapacityLimitException("Employee limiti aşılıb!");

            Employees[currentCount++] = employee;
        }

        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index >= currentCount)
                    throw new IndexOutOfRangeException("Index mövcud deyil.");
                return Employees[index];
            }
            set
            {
                if (index < 0 || index >= currentCount)
                    throw new IndexOutOfRangeException("Index mövcud deyil.");
                Employees[index] = value;
            }
        }
    }
}
