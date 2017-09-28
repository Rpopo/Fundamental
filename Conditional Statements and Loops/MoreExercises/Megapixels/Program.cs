using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double counting = width * height;
            double megapix = counting / 1000000;
            megapix = double.Parse(megapix.ToString("0.0"));
            Console.WriteLine(megapix);
        }
    }
}
