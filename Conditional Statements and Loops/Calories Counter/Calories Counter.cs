using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreadiants = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;

            int calories = 0;
            for (int i = 0; i < ingreadiants; i++)
            {
                string ingreadiant = Console.ReadLine().ToLower();
                switch (ingreadiant)
                {
                    case "cheese":
                        calories += cheese;
                        break;
                    case "tomato sauce":
                        calories += tomatoSauce;
                        break;
                    case "salami":
                        calories += salami;
                        break;
                    case "pepper":
                        calories += pepper;
                        break;

                }

            }
            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
