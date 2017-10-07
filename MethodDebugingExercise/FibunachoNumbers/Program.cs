using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibunachoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int integerA = 1;
            int integerB = 1;
            int rem = 1;
            for (int i = 0; i < number-1; i++)
            {
                rem = integerA + integerB;
                integerA = integerB;
                integerB = rem;
            }
                Console.WriteLine(rem);
        }
    }
}
