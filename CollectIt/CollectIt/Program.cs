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
            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee { Name = "Alex" });
            line.Enqueue(new Employee { Name = "Dani" });
            line.Enqueue(new Employee { Name = "Chris" });

            while(line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee.Name);
            }
            Console.ReadLine();
        }
    }
}
