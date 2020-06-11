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
            var departments = new SortedDictionary<string, List<Employee>>();

            departments.Add("Sales", new List<Employee> {
                new Employee { Name = "Joy" },
                new Employee { Name = "Dani" },
                new Employee { Name = "Dani" }});

            departments.Add("Engineering", new List<Employee> {
                new Employee { Name = "Scott" },
                new Employee { Name = "Alex" },
                new Employee { Name = "Dani" }});
            
            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");
                }
            }

            Console.ReadLine();
        }
    }
}
