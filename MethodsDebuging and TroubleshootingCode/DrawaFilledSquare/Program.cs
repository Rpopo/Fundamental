using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawaFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintHeader(N);
            PrintBody(N);
            PrintBody(N);
            PrintHeader(N);
        }

         static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

         static void PrintHeader(int N)
        {
            Console.WriteLine(new string('-',N*2));
        }
    }
}
