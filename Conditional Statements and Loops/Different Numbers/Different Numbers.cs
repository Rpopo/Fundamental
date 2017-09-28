using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool no = true;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        for (int d = start; d <= end; d++)
                        {
                            for (int i = start; i <= end; i++)
                            {
                                if (a < b && b < c && c < d & d < i)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {i}");
                                    no = false;
                                }
                            }
                        }
                    }
                }
            }
            if (no)
            {
                Console.WriteLine("No");
            }
        }
    }
}
