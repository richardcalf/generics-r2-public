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
            HashSet<Employee> set = new HashSet<Employee>();
            set.Add(new Employee { Name = "Scott" });
            set.Add(new Employee { Name = "Scott" });

            foreach (var item in set)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
