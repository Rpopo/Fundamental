using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var countResurses = new Dictionary<string, int>();
            while (command != "stop")
            {
                string quantity = Console.ReadLine();
                if (countResurses.ContainsKey(command))
                {
                    countResurses[command] += int.Parse(quantity);
                }
                else
                {
                    countResurses[command] = int.Parse(quantity);
                }
                command = Console.ReadLine();
            }
            foreach (var item in countResurses)
            {
                Console.WriteLine(string.Join(" -> ", item.Key, item.Value));
            }
        }
    }
}
