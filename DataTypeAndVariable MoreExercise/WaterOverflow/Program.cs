using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte lines = sbyte.Parse(Console.ReadLine());
            byte waterTankCapacity = 255;
            byte pouredWater = 0;
            string overLoadedTank = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                if (liters + pouredWater < waterTankCapacity)
                {
                    pouredWater += (byte)liters;
                }
                else
                {
                    overLoadedTank += "Insufficient capacity!\n";
                }
            }
            if (overLoadedTank != null)
            {
                Console.Write(overLoadedTank);
            }
            Console.WriteLine(pouredWater);
        }
    }
}
