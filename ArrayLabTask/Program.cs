using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
            
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ');
            int n = int.Parse(Console.ReadLine());

            ReversTheDigits(text,n);
            
        }

         static void ReversTheDigits(string[] text, int n)
        {
            int[] numbers = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = int.Parse(text[i]);
            }
            int[] sumArrays = new int[numbers.Length];
            for (int g = 0; g < n; g++)
            {
                int lastDigit = numbers[numbers.Length - 1];
                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                    sumArrays[i] += numbers[i];
                }
                numbers[0] = lastDigit;
                sumArrays[0] += lastDigit;
            }
            Console.WriteLine(string.Join(" ",sumArrays));
        }
    }
}
