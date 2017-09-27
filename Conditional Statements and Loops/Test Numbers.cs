using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int master = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int g = start; g >= 1; g--)
            {
                for (int i = 1; i <= end; i++)
                {
                    counter++;
                    sum = sum + 3 * (g * i);
                    if (sum >= master)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {master}");
                        return;
                    }

                }
            }

            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum} ");
        }
    }
}
