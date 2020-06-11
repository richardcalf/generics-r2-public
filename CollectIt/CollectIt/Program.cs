using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new SortedList<string, List<Employee>>();
            employeesByDepartment.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            employeesByDepartment.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            foreach(var item in employeesByDepartment)
            {
                Console.WriteLine($"The count of employees for {item.Key} is {item.Value.Count}");
            }

            Console.ReadLine();
        }
    }
}
