using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes =
            //3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
            //microseconds = 3155673600000000000 nanoseconds
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minute = hours * 60;
            long sec = minute * 60;
            long milesec = sec * 100;
            long microsec = milesec * 1000;
            long nanosec = microsec * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minute} minutes =" +
                $" {sec} seconds = {milesec}0 milliseconds = {microsec}0 microseconds = {nanosec}0 nanoseconds");
            //With some cheat!
        }
    }
}
