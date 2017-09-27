using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int grpupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            if (PrintGrupPrizeByHall(grpupSize) == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            double GrupPrizeByHall = PrintGrupPrizeByHall(grpupSize);
            double totalPrizeOfPacet = PrintTotalPrize(GrupPrizeByHall, package, grpupSize);
            if (grpupSize <= 50)
            {
                Console.WriteLine($"We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {totalPrizeOfPacet.ToString("0.00")}$");
            }
            else if (grpupSize > 50 && grpupSize <= 100)
            {
                Console.WriteLine($"We can offer you the Terrace");
                Console.WriteLine($"The price per person is {totalPrizeOfPacet.ToString("0.00")}$");
            }
            else if (grpupSize > 100 && grpupSize < 120)
            {
                Console.WriteLine($"We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {totalPrizeOfPacet.ToString("0.00")}$");
            }
        }

        static double PrintGrupPrizeByHall(double grpupSize)
        {
            double prizeByHall = 0.0;
            if (grpupSize <= 50)
            {
                prizeByHall = 2500;
            }
            else if (grpupSize > 50 && grpupSize <= 100)
            {
                prizeByHall = 5000;
            }
            else if (grpupSize > 100 && grpupSize <= 120)
            {
                prizeByHall = 7500;
            }
            return prizeByHall;
        }

        static double PrintTotalPrize(double grupPize, string TypeOfPacet, int grupSize)
        {
            double entirePrize = 0.0;
            double discount = 0.0;
            if (TypeOfPacet == "Normal")
            {
                entirePrize = grupPize + 500;
                discount = entirePrize * 0.05;
                entirePrize = entirePrize - discount;
            }
            else if (TypeOfPacet == "Gold")
            {
                entirePrize = grupPize + 750;
                discount = entirePrize * 0.10;
                entirePrize = entirePrize - discount;
            }
            else if (TypeOfPacet == "Platinum")
            {
                entirePrize = grupPize + 1000;
                discount = entirePrize * 0.15;
                entirePrize = entirePrize - discount;
            }
            double prizePerPerson = entirePrize / grupSize;

            return prizePerPerson;
        }
    }
}
