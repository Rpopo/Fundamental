﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiant = double.Parse(Console.ReadLine());
            double area = radiant * radiant * Math.PI;
            Console.WriteLine(Math.Round(area,12));
        }
    }
}
