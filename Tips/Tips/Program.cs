using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    public enum Steps
    {
        Step1,
        Step2,
        Step3        
    }

    public static class StringExtensions
    {
        public static Steps ParseEnum(this string str)
        {
            return (Steps)Enum.Parse(typeof(Steps), str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = "Step1";
            var value = (Steps)Enum.Parse(typeof(Steps), input);
            var value2 = input.ParseEnum();

            List<string> coll = new List<string>();
            coll.Add(value.ToString());
            coll.Add(value2.ToString());

            foreach(var item in coll)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
