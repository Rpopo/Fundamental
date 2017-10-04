using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double areaOfTheTriangle = PrintTriangleArea(widght, height);
            Console.WriteLine(areaOfTheTriangle);

        }

         static double PrintTriangleArea(double widght, double height)
        {
            double areaOfTheTriangle = (widght * height) / 2;
            return areaOfTheTriangle;
        }
    }
}
