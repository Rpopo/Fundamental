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
            string command = Console.ReadLine();
            var phoneNumbers = new SortedDictionary<string, string>();

            while (command != "END")
            {
                List<string> commandArg = command.Split(' ').ToList();
                if (commandArg[0] == "A")
                {
                    if (phoneNumbers.ContainsKey(commandArg[1]))
                    {
                        phoneNumbers[commandArg[1]] = commandArg[2];
                    }
                    else
                    {
                        phoneNumbers.Add(commandArg[1], commandArg[2]);

                    }
                }
                else if (commandArg[0] == "S")
                {
                    if (phoneNumbers.ContainsKey(commandArg[1]))
                    {
                        Console.WriteLine("{0} -> {1}", commandArg[1], phoneNumbers[commandArg[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commandArg[1]} does not exist.");
                    }
                }

                if (command == "ListAll")
                {

                    foreach (var numbers in phoneNumbers)
                    {
                        Console.WriteLine($"{numbers.Key} -> {numbers.Value}");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
