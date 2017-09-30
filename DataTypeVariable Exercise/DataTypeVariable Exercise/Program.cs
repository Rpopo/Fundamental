using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeVariable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //-100
            //128
            //- 3540
            //64876
            //2 147 483 648
            //- 1 141 583 228
            //- 1 223 372 036 854 775 808
            sbyte number1 = sbyte.Parse(Console.ReadLine());
            byte number2 = byte.Parse(Console.ReadLine());
            short number3 = short.Parse(Console.ReadLine());
            ushort number4 = ushort.Parse(Console.ReadLine());
            long number5 = long.Parse(Console.ReadLine());
            int numbe6 = int.Parse(Console.ReadLine());
            long number7 = long.Parse(Console.ReadLine());
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(numbe6);
            Console.WriteLine(number7);

        }
    }
}
