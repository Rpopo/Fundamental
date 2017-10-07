using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            long integer = long.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(integer);
            sqrt = Math.Round(sqrt);
            bool isPrime = true;
            if (integer == 1 || integer == 0)
            {
                isPrime = false;
                Console.WriteLine(isPrime);
                return;
            }
            for (int i = 2; i <=sqrt; i++)
            {
                if (integer % i == 0 )
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);

        }
    }
}
