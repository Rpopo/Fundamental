using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 2; i <= end; i++)
            {
                bool prime = true;
                for (int g = 2; g <= Math.Sqrt(i); g++)
                {
                    if (i % g == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }       
    }
}

