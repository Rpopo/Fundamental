using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCheckers
{
    class Program
    {
        static void Main(string[] args)
        {
            string integer = Console.ReadLine();
            long integers = 0;
            bool isInteger = long.TryParse(integer, out integers);
            if (isInteger)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
