using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosDrinkTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            double quantite = int.Parse(Console.ReadLine());
            if (profession == "Athlete")
            {
                double prize = quantite * 0.70;
                Console.WriteLine($"The {profession} has to pay {prize.ToString("0.00")}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                double prize = quantite * 1.00;
                Console.WriteLine($"The {profession} has to pay {prize.ToString("0.00")}.");
            }
            else if (profession == "SoftUni Student")
            {
                double prize = quantite * 1.70;
                Console.WriteLine($"The {profession} has to pay {prize.ToString("0.00")}.");
            }
            else
            {
                double prize = quantite * 1.20;
                Console.WriteLine($"The {profession} has to pay {prize.ToString("0.00")}.");
            }
        }
    }
}
