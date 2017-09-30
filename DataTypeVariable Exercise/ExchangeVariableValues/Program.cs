using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 5;
            sbyte b = 10;
             Console.WriteLine($"Before:\na = {a}\nb = {b}");
             sbyte reminder = a;
             a = b;
             b = reminder;
             Console.WriteLine($"After:\na = {a}\nb = {b}");
            
        }
    }
}
