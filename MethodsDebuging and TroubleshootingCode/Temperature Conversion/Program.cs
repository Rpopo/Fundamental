using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit = double.Parse(Console.ReadLine());
            double celsiumConvert =  PrintFromFahrenHeitToCelsius(Fahrenheit);
            Console.WriteLine(celsiumConvert.ToString("0.00"));
        }

         static double PrintFromFahrenHeitToCelsius(double F)
        {
            double celsius = (F - 32) * 5 /9;
            return celsius;
        }
    }
}
