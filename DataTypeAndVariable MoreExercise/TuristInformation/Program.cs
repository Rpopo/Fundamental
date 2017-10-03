using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialValue = Console.ReadLine();
            float imperialUnit = float.Parse(Console.ReadLine());
            float metricUnit = 0.0f;
            if (initialValue == "miles")
            {
                metricUnit = imperialUnit * 1.6f;
                Console.WriteLine($"{imperialUnit} {initialValue} = {metricUnit.ToString("0.00")} kilometers");

            }
            else if (initialValue == "inches")
            {
                metricUnit = imperialUnit * 2.54f;
                Console.WriteLine($"{imperialUnit} {initialValue} = {metricUnit.ToString("0.00")} centimeters");

            }
            else if (initialValue == "feet")
            {
                metricUnit = imperialUnit * 30f;
                Console.WriteLine($"{imperialUnit} {initialValue} = {metricUnit.ToString("0.00")} centimeters");

            }
            else if (initialValue == "yards")
            {
                metricUnit = imperialUnit * 0.31f;
                Console.WriteLine($"{imperialUnit} {initialValue} = {metricUnit.ToString("0.00")} meters");


            }
            else if (initialValue == "gallons")
            {
                metricUnit = imperialUnit * 3.8f;
                Console.WriteLine($"{imperialUnit} {initialValue} = {metricUnit.ToString("0.00")} liters");
            }
            
        }
    }
}
