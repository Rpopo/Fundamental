using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            if (firstNum <1)
            {
                firstNum = firstNum * 0.1m;
            }
            decimal firstNumEps = Math.Round(firstNum, 6);
            firstNumEps = Math.Abs(firstNumEps);
            decimal secondNum = decimal.Parse(Console.ReadLine());
            if (secondNum < 1)
            {
                secondNum = secondNum * 0.1m;
            }
            decimal secondNumEps = Math.Round(secondNum, 6);
            secondNumEps = Math.Abs(secondNumEps);
            bool compared = firstNumEps == secondNumEps;
            if (compared)
            {
                Console.WriteLine(compared);
            }
            else
            {
                Console.WriteLine(compared);
            }
            
        }
    }
}
