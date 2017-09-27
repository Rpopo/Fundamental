using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            if (mount == "May" || mount == "October")
            {
                PrintRoomMayOctober(nightCount, mount);
            }
            else if (mount == "June" || mount == "September")
            {
                PrintRoomJuneSeptemer(nightCount, mount);
            }
            else if (mount == "July" || mount == "August" || mount == "December")
            {
                PrintRoomJulyAugustDecember(nightCount);
            }
        }
        static void PrintRoomMayOctober(int nightCount, string mount)
        {
            int freeSleep = nightCount;
            if (mount == "October" && nightCount > 7)
            {
                freeSleep--;
            }
            double studioPrice = freeSleep * 50;
            double doublePrice = nightCount * 65;
            double suitePrice = nightCount * 75;
            if (nightCount > 7)
            {
                double discount = studioPrice * 0.05;
                studioPrice = studioPrice - discount;
            }
            Console.WriteLine($"Studio: {studioPrice.ToString("0.00")} lv.");
            Console.WriteLine($"Double: {doublePrice.ToString("0.00")} lv.");
            Console.WriteLine($"Suite: {suitePrice.ToString("0.00")} lv.");

        }
        static void PrintRoomJuneSeptemer(int nightCount, string mount)
        {
            int freeSleep = nightCount;
            if (mount == "September" && nightCount > 7)
            {
                freeSleep--;
            }
            double studioPrice = freeSleep * 60;
            double doublePrice = nightCount * 72;
            double suitePrice = nightCount * 82;
            if (nightCount > 14)
            {
                double discount = doublePrice * 0.10;
                doublePrice = doublePrice - discount;
            }
            Console.WriteLine($"Studio: {studioPrice.ToString("0.00")} lv.");
            Console.WriteLine($"Double: {doublePrice.ToString("0.00")} lv.");
            Console.WriteLine($"Suite: {suitePrice.ToString("0.00")} lv.");
        }
        static void PrintRoomJulyAugustDecember(int nightCount)
        {
            double studioPrice = nightCount * 68;
            double doublePrice = nightCount * 77;
            double suitePrice = nightCount * 89;
            if (nightCount > 14)
            {
                double discount = suitePrice * 0.15;
                suitePrice = suitePrice - discount;
            }
            Console.WriteLine($"Studio: {studioPrice.ToString("0.00")} lv.");
            Console.WriteLine($"Double: {doublePrice.ToString("0.00")} lv.");
            Console.WriteLine($"Suite: {suitePrice.ToString("0.00")} lv.");
        }
    }
}
