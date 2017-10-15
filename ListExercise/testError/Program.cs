using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<int> integers = numbers.Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string comands = Console.ReadLine();
                List<string> comandArgs = comands.Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (comandArgs[0] == "Delete")
                {
                    integers.RemoveAll(c => c == int.Parse(comandArgs[1]));

                }
                if (comandArgs[0] == "Insert")
                {
                    integers.Insert(int.Parse(comandArgs[2]), int.Parse(comandArgs[1]));
                }
                //Console.WriteLine(string.Join(" ", integers));
                if (comands == "Even")
                {
                    List<int> even = new List<int>();
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] % 2 == 0)
                        {
                            even.Add(integers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", even));
                    return;
                }
                if (comands == "Odd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] % 2 != 0)
                        {
                            odd.Add(integers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",odd));
                    return;
                }
                continue;
            }
        }
    }
}
