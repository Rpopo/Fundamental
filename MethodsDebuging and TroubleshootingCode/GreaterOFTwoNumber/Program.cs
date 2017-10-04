using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOFTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int  firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            double greaterOfTwo = PrintGreate(firstInteger,secondInteger);
            Console.WriteLine(greaterOfTwo);
        }

         static double PrintGreate(int firstInteger, int secondInteger)
        {
            return Math.Max(firstInteger, secondInteger);
        }
    }
}
