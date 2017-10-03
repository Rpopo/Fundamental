using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long integerNumber = 0;
            bool integers = long.TryParse(number, out integerNumber);
            if (integers)
            {
                if (integerNumber > -128 && integerNumber < 127)
                {
                    Console.WriteLine("Sunny");
                }
                else if (integerNumber > -2147483648 && integerNumber < 2147483647)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (integerNumber > -9223372036854775808 && integerNumber < 9223372036854775807)
                {
                    Console.WriteLine("Windy");
                }

            }
            else
            {
                Console.WriteLine("Rainy");
            }
            //float floatNumber = 0.0f;
            //bool floating = float.TryParse(number, out floatNumber);
            //else if (floating)
            //{
            //    Console.WriteLine("Rainy");
            //}

            
            
        }
    }
}
