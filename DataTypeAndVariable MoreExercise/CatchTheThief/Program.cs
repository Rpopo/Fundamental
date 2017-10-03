using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableType = Console.ReadLine();
            byte currentRollOfNumbers = byte.Parse(Console.ReadLine());
            if (variableType == "sbyte")
            {
                sbyte maxValue = sbyte.MaxValue;
                sbyte prisonerId = 0;
                sbyte previousId = 0;
                for (int i = 0; i < currentRollOfNumbers; i++)
                {
                    long id = long.Parse(Console.ReadLine());
                    if (id <= maxValue)
                    {
                        previousId = Math.Max(previousId, (sbyte)id);
                        prisonerId = previousId;
                    }
                }
                Console.WriteLine(prisonerId);
            }
            if (variableType == "int")
            {
                int maxValue = int.MaxValue;
                int prisonerId = 0;
                int previousId = 0;
                for (int i = 0; i < currentRollOfNumbers; i++)
                {
                    long id = long.Parse(Console.ReadLine());
                    if (id <= maxValue)
                    {
                        previousId = Math.Max(previousId,(int)id);
                        prisonerId = previousId;
                    }
                }
                Console.WriteLine(prisonerId);
            }
            if (variableType == "long")
            {
                long maxValue = long.MaxValue;
                long prisonerId = 0;
                long previousId = 0;
                for (int i = 0; i < currentRollOfNumbers; i++)
                {
                    long id = long.Parse(Console.ReadLine());
                    if (id <= maxValue)
                    {
                        previousId = Math.Max(previousId, id);
                        prisonerId = previousId;
                    }
                }
                Console.WriteLine(prisonerId);
            }
        }
    }
}
