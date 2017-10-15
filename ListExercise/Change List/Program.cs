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
                if (comands == "Delete")
                {
                    int element = int.Parse(Console.ReadLine());
                    integers.RemoveAll(c => c == element);
                    
                }
                if (comands == "Insert")
                {
                    int element = int.Parse(Console.ReadLine());
                    int position = int.Parse(Console.ReadLine());
                    integers.Insert(position,element);
                }
                //Console.WriteLine(string.Join(" ", integers));
                if (comands == "Odd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] % 2 == 0)
                        {
                            odd[i] = integers[i];
                        }
                    }
                 Console.WriteLine(string.Join(" ",odd));

                }
                continue;
            }
        }
    }
}
