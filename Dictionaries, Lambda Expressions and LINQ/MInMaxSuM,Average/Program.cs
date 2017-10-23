using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInMaxSuM_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] integers = new int[n];
            for (int i = 0; i < n; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            var dicOfOperations = new Dictionary<string, double>();
            dicOfOperations["Sum"] = integers.Sum();
            dicOfOperations["Min"] = integers.Min();
            dicOfOperations["Max"] = integers.Max();
            dicOfOperations["Average"] = integers.Average();
            foreach (var item in dicOfOperations)
            {
                Console.WriteLine(string.Join(" = ",item.Key,item.Value));
            }
        }
    }
}
