using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double widt = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintPerimeter(widt, height));
            Console.WriteLine(PrintArea(widt, height));
            Console.WriteLine(PrintDiagonal(widt, height));


        }

         static decimal PrintDiagonal(double widt, double height)
        {
            decimal diagonal = (decimal)Math.Sqrt(widt* widt + height * height);
            return diagonal;
        }

        static double PrintArea(double widt, double height)
        {
            double area = widt * height;
            return area;
        }

        static double PrintPerimeter(double widt , double height)
        {
            double perimeter = 2 * (widt + height);
            return perimeter;
        }
    }
}
