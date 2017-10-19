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
            string names = Console.ReadLine();
            var colectOfMeils = new Dictionary<string, string>();
            while (names != "stop")
            {
                string meil = Console.ReadLine();
                if (meil.EndsWith("us"))
                {
                    names = Console.ReadLine();
                    continue;
                }
                else
                {
                    colectOfMeils.Add(names, meil);
                }
                names = Console.ReadLine();
            }
            foreach (var item in colectOfMeils)
            {
                Console.WriteLine(string.Join(" -> ", item.Key, item.Value));
            }

        }
    }
}
