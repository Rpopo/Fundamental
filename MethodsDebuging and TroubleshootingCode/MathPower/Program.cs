using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double intiger = double.Parse(Console.ReadLine());
            double powerOfDigit = double.Parse(Console.ReadLine());
            double intigerPower = PrintPowerOfTwoDigit(intiger,powerOfDigit);
            Console.WriteLine(intigerPower);
        }

         static double PrintPowerOfTwoDigit(double firstDigit, double secondDigit)
        {
            return Math.Pow(firstDigit, secondDigit);
        }
    }
}
