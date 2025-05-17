using Deparments.Exceptions;

namespace Deparments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Department dep = new Department("IT", 2);
                Employee emp1 = new Employee("Ali", 30, 1500);
                Employee emp2 = new Employee("Veli", 25, 1800);
                Employee emp3 = new Employee("Sara", 28, 2000);

                dep.AddEmployee(emp1);
                dep.AddEmployee(emp2);

                // Bu hissə exception atacaq
                dep.AddEmployee(emp3);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
    }
}
