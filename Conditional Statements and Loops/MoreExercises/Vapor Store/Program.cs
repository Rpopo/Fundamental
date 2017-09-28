using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            Console.WriteLine(
            PrintAmountMoney(order));
            
            

        double PrintAmountMoney(string Ordered)
        {
                double OutFall4 = 39.99;
                double CSOG = 15.99;
                double Zplinter = 19.99;
                double Honored2 = 59.99;
                double RoverWatch = 29.99;
                double RoverWatchORG = 39.99;
                double amount = 0;
                while (order != "Game Time")
                {

                    if (order == "OutFall 4")
                    {
                        amount += balance - OutFall4;
                    }
                    else if (order == "CS: OG")
                    {
                        amount += balance - CSOG;
                    }
                    else if (order == "Zplinter Zell")
                    {
                        amount += balance - Zplinter;
                    }
                    else if (order == "Honored 2")
                    {
                        amount += balance - Honored2;
                    }
                    else if (order == "RoverWatch")
                    {
                        amount += balance - RoverWatch;
                    }
                    else if (order == "RoverWatch Origins Edition")
                    {
                        amount += balance - RoverWatchORG;
                    }
                    order = Console.ReadLine();
                }
                return amount;
            }

        }
    }
}
