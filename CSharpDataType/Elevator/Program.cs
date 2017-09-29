using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persone = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int curses = (int)Math.Ceiling((double)persone / capacity);
            Console.WriteLine(curses);
        }
    }
}
