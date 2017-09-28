using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            int output;
            int counter = 0;

            bool isInt;
            do
            {
                input = Console.ReadLine();
                isInt = Int32.TryParse(input, out output);
                counter++;
            } while (isInt);
            Console.WriteLine(counter - 1);
        }
    }
}
