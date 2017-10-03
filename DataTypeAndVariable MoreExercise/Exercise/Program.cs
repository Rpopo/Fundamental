using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableType = Console.ReadLine();
            switch (variableType)
            {
                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;
                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;
                case "short":
                    Console.WriteLine(short.MaxValue);
                    Console.WriteLine(short.MinValue);
                    break;
                case "ushort":
                    Console.WriteLine(ushort.MaxValue);
                    Console.WriteLine(ushort.MinValue);
                    break;
                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;
                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;
                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
                case "ulong":
                    Console.WriteLine(ulong.MaxValue);
                    Console.WriteLine(ulong.MinValue);
                    break;
                case "float":
                    Console.WriteLine(float.MaxValue);
                    Console.WriteLine(float.MinValue);
                    break;
                case "double":
                    Console.WriteLine(double.MaxValue);
                    Console.WriteLine(double.MinValue);
                    break;
                case "decimal":
                    Console.WriteLine(decimal.MaxValue);
                    Console.WriteLine(decimal.MinValue);
                    break;
                case "char":
                    Console.WriteLine(char.MaxValue);
                    Console.WriteLine(char.MinValue);
                    break;
            }
        }
    }
}
