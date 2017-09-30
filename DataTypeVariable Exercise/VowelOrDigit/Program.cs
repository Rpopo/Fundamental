using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int digit;
            bool vowel = int.TryParse(symbol, out digit);
            if (vowel)
            {
                Console.WriteLine("digit");
            }
            else
            {
                if (symbol == "a" || symbol == "y" || symbol == "o" ||
                    symbol == "e" || symbol == "i" || symbol == "u")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }

        }
    }
}
