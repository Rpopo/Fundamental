using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] signs = Console.ReadLine().ToLower().Split(' ').ToArray();
            var countOfoccurses = new Dictionary<string,int>();
            foreach (var item in signs)
            {
                if (countOfoccurses.ContainsKey(item))
                {
                    countOfoccurses[item]++;
                }
                else
                {
                    countOfoccurses[item] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in countOfoccurses)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));

        }
    }
}
