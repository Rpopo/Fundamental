using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long lastDigit = Math.Abs(long.Parse(Console.ReadLine()));

            
            Console.WriteLine(PrintNameOfDigit(lastDigit));
        }

         static string PrintNameOfDigit(long lastDigit)
        {
            string name = "";
            switch (lastDigit % 10)
            {
                case 1: name += "one";
                    break;
                case 2: name += "two";
                    break;
                case 3: name += "three";
                    break;
                case 4: name += "four";
                    break;
                case 5: name += "five";
                    break;
                case 6: name += "six";
                    break;
                case 7: name += "seven";
                    break;
                case 8: name += "eight";
                    break;
                case 9: name += "nine";
                    break;
                case 0: name += "zero";
                    break;
            }
            return name;
        }
    }
}
