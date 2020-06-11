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
            var employeesByDepartment = new Dictionary<string, List<Employee>>();

            employeesByDepartment.Add("Engineering",
                new List<Employee>() { new Employee { Name = "Scott" } });

            // ..

            employeesByDepartment["Engineering"].Add(new Employee { Name = "Alex" });

            foreach(var item in employeesByDepartment)
            {
                foreach(var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
