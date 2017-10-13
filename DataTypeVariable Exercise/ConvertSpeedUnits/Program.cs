using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort distance = ushort.Parse(Console.ReadLine());
            ushort distanceInMiles = (ushort)(distance * 1609);
            byte hours = byte.Parse(Console.ReadLine());
            byte minut = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            float speedInMetersPerSec = distance / seconds;
            Console.WriteLine(distanceInMiles);
        }
    }
}
