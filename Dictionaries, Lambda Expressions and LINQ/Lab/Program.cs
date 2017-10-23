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
            int n = int.Parse(Console.ReadLine());
            var aggregateData = new Dictionary<string,Dictionary<int,List<int>>>();
            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[1];
                int durutarion = int.Parse(input[2]);
                var ip = input[0].Split('.').Select(k => int.Parse(k)).ToArray();
                if (!aggregateData.ContainsKey(name))
                {
                    aggregateData[name] = new Dictionary<int, List<int>>();
                }
                aggregateData[name][durutarion] = new List<int>();
                aggregateData[name][durutarion].AddRange(ip);

            }

            foreach (var data in aggregateData)
            {
                var name = data.Value;
                foreach (var item in name)
                {


                }
            }
        }
    }
}
