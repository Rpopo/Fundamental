using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuging_and_TroubleshootingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("-----------------\n\u00A9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Change to________");
            Console.WriteLine("Received by______");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIP");
            Console.WriteLine("-----------------");
        }
    }
}
