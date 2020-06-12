using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = CreateCollection(typeof(List<Employee>));
            Console.Write(employeeList.GetType().Name);
            var genericArguments = employeeList.GetType().GenericTypeArguments;
            foreach(var arg in genericArguments)
            {
                Console.Write($"[{arg.Name}]");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static object CreateCollection(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
