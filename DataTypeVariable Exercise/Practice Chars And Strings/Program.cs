using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            char secChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            char fourthChar = char.Parse(Console.ReadLine());
            string lastLine = Console.ReadLine();
            Console.WriteLine(firstLine);
            Console.WriteLine(secChar);
            Console.WriteLine(thirdChar);
            Console.WriteLine(fourthChar);
            Console.WriteLine(lastLine);
        }
    }
}
