﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < number; i1++)
            {
                for (int i2 = 0; i2 < number; i2++)
                {
                    for (int i3 = 0; i3 < number; i3++)
                    {

                        char letter1 = (char)('a' + i1);
                        char letter2 = (char)('a' + i2);
                        char letter3 = (char)('a' + i3);
                        Console.WriteLine("{0}{1}{2}",letter1,letter2,letter3);
                    }
                }
            }
        }
    }
}
