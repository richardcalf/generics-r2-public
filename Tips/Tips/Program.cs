using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Item();
            var b = new Item();
            var c = new Item();

            Console.WriteLine(Item.InstanceCount);

            Console.ReadLine();
        }
    }
    
    public class Item
    {
        public Item()
        {
            InstanceCount++;
        }

        public static int InstanceCount;
    }
}
