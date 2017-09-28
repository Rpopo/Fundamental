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
            double balance = double.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            double OutFall4 = 39.99;
            double CSOG = 15.99;
            double Zplinter = 19.99;
            double Honored2 = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchORG = 39.99;
            double purshedPrice = 0;
            string boutghtGames = string.Empty;
            while (order != "Game Time")
            {

                if (order == "OutFall 4")
                {
                    if (balance < OutFall4)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += OutFall4;
                        boutghtGames += "Bought OutFall 4\n";
                    }
                }
                else if (order == "CS: OG")
                {
                    if (balance < CSOG)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += CSOG;
                        boutghtGames += "Bought CS: OG \n";
                    }
                }
                else if (order == "Zplinter Zell")
                {
                    if (balance < Zplinter)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += Zplinter;
                        boutghtGames += "Bought Zplinter Zell \n";
                    }
                }
                else if (order == "Honored 2")
                {
                    if (balance < Honored2)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += Honored2;
                        boutghtGames += "Bought Honored 2\n";
                    }
                }
                else if (order == "RoverWatch")
                {
                    if (balance < RoverWatch)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += RoverWatch;
                        boutghtGames += "Bought RoverWatch\n";
                    }
                }
                else if (order == "RoverWatch Origins Edition")
                {
                    if (balance < RoverWatchORG)
                    {
                        boutghtGames += "Too Expensive\n";
                    }
                    else
                    {
                        purshedPrice += RoverWatchORG;
                        boutghtGames += "Bought RoverWatch Origins Edition\n";
                    }
                }
                else
                {
                    boutghtGames += "Not Found\n";
                }

                order = Console.ReadLine();
            }

            double amount = balance - purshedPrice;
            Console.Write(boutghtGames);
            if (purshedPrice >= balance)
            {
                Console.Write("Out of money!");
            }
            else
            {
                Console.Write($"Total spent: ${purshedPrice.ToString("0.00")}. Remaining: ${amount.ToString("0.00")}\n");
            }
            


        }
    }
}
