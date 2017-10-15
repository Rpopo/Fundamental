using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            List<double> integers = number.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToList();
            int[] masterNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] == masterNumbers[0])
                {
    
                    int index = masterNumbers[1];
                    if (masterNumbers[1] + i > integers.Count - 1)
                    {
                        index = (masterNumbers[1] + i) - integers.Count;
                    }
                    int frontIndex = masterNumbers[1];
                    if (i - masterNumbers[1] < 0)
                    {
                        frontIndex = masterNumbers[1] - (i + 1);
                    }
                    integers.RemoveRange(i + 1, index);
                    integers.RemoveRange(i - frontIndex, frontIndex);
                    integers.Remove(masterNumbers[0]);
                    
                }
            }
            double sum = 0;
            for (int i = 0; i < integers.Count; i++)
            {
                sum += integers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
