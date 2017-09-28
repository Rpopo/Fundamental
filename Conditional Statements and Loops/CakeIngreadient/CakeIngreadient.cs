using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngreadient
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentIngrediant = string.Empty;
            int count = 0;
            string master = Console.ReadLine();
            while (!(master == "Bake!"))
            {
                count++;
                currentIngrediant += "Adding ingredient ";
                currentIngrediant += master;
                currentIngrediant += ".\n";
                master = Console.ReadLine();
            }
            Console.Write(currentIngrediant);
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
