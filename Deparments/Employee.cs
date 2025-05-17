using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparments
{
    public class Employee:IPerson
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public double Salary { get; }

        public Employee(string name, int age, double salary)
        {
            if (string.IsNullOrWhiteSpace(name) || age <= 0 || salary <= 0)
                throw new ArgumentException("Name, age və salary düzgün daxil edilməlidir.");

            Id = ++_idCounter;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
