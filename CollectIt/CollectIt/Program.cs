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
            var departments = new DepartmentCollection();

            departments.Add("Sales", new Employee { Name = "Joy" })
                       .Add("Sales", new Employee { Name = "Dani" })
                       .Add("Sales", new Employee { Name = "Dani" });

            departments.Add("Engineering", new Employee { Name = "Scott" })
                       .Add("Engineering", new Employee { Name = "Alex" })
                       .Add("Engineering", new Employee { Name = "Dani" });

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
