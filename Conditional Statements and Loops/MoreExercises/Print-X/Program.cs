using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char x = 'x';
            char whiteSpace = ' ';
            string format = "{0}{1}{2}{1}{0}";
            for (int i = 0; i < n / 2; i++)
            {
                string top = string.Format(format,
                    new string(whiteSpace, i),
                        new string(x, 1),
                            new string(whiteSpace, (n - 2) - i * 2),
                                new string(x, 1),
                                    new string(whiteSpace, i));
                Console.WriteLine(top);
            }
            string midFormat = "{0}{1}{0}";
            Console.WriteLine(string.Format(midFormat,
                new string(whiteSpace, n / 2),
                    new string(x, 1)));
            for (int i = 1; i <=n/2; i++)
            {
                string mid = string.Format(format,
                     new string(whiteSpace, n / 2 - i),
                        new string(x, 1),
                            new string(whiteSpace, i*2-1));
                Console.WriteLine(mid);
            }
        }
    }
}
