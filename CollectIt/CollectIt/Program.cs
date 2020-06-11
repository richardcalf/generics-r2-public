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
            var employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add("Scott", new Employee { Name = "Scott" });
            employeesByName.Add("Alex", new Employee { Name = "Alex" });
            employeesByName.Add("Joy", new Employee { Name = "Joy" });

            var scott = employeesByName["Scott"];

            foreach(var item in employeesByName)
            {
                Console.WriteLine($"{item.Key}:{item.Value.Name}");
            }

            Console.ReadLine();
        }
    }
}
