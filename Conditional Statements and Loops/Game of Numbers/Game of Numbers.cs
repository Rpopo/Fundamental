using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int terminated = int.Parse(Console.ReadLine());
            int magicDigit = int.Parse(Console.ReadLine());
            int currentCombination = 0;
            int sum = 0;
            int curG = 0;
            int curI = 0;
            for (int g = start; g <= terminated; g++)
            {
                for (int i = start; i <= terminated; i++)
                {
                    currentCombination++;
                    sum = g + i;
                    if (sum == magicDigit)
                    {
                        curG = g;
                        curI = i;
                    }
                }
            }
            if (curG != 0)
            {
                Console.WriteLine($"Number found! {curG} + {curI} = {magicDigit}");
            }
            else
            {
                Console.WriteLine($"{currentCombination} combinations - neither equals {magicDigit}");
            }
        }
    }
}
