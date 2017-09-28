using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int n = 1;
            for (int g = 1; g <= start; g++)
            {
                for (int i = 1; i <= g; i++)
                {
                    Console.Write($"{n} ");
                }
                n++;
                Console.WriteLine();
            }
        }
    }
}
