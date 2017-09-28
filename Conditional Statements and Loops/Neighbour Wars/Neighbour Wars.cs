using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealt = 100;
            int goshoHelt = 100;
            int turn = 0;
            while (true)
            {
                turn++;
                if (turn % 2 != 0)
                {
                    goshoHelt -= peshoDmg;
                    if (goshoHelt < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHelt} health.");
                }
                else
                {
                    peshoHealt -= goshoDmg;
                    if (peshoHealt < 1)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealt} health.");
                }
                if (turn % 3 == 0)
                {
                    peshoHealt += 10;
                    goshoHelt += 10;
                }
            }
        }
    }
}
