using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= specialNum; i++)
            {
                for (int g = 1; g <= 1; g++)
                {
                    int firstDigit = i % 10;
                    int secondDigit = i / 10;
                    if (firstDigit + secondDigit == 5 || firstDigit + secondDigit == 7 || firstDigit + secondDigit == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }

            }
        }
    }
}
