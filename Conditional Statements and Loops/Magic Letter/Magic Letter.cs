using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char next = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            for (char first = start; first <= next; first++)
            {
                for (char second = start; second <= next; second++)
                {
                    for (char third = start; third <= next; third++)
                    {
                        string letter = $"{first}{second}{third} ";
                        if (!letter.Contains(last))
                        {
                            Console.Write(letter);
                        }

                    }
                }
            }
        }
    }
}
