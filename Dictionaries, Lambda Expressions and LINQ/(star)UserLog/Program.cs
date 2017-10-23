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
            string[] inputToken = Console.ReadLine().Split(' ', '=')
                .ToArray();
            var ipData = new SortedDictionary<string, Dictionary<string, int>>();
            while (inputToken[0] != "end")
            {
                string ip = inputToken[1];
                string massage = inputToken[3];
                string username = inputToken[5];

                if (!ipData.ContainsKey(username))
                {
                    ipData[username] = new Dictionary<string, int>();
                    if (!ipData[username].ContainsKey(ip))
                    {
                        ipData[username][ip] = 1;
                    }
                }
                else if (ipData.ContainsKey(username))
                {
                    if (!ipData[username].ContainsKey(ip))
                    {
                        ipData[username][ip] = 1;
                    }
                    else
                    {
                        ipData[username][ip]++;
                    }
                }

                inputToken = Console.ReadLine().Split(' ', '=')
                .ToArray();
            }

            foreach (var keys in ipData)
            {
                var ip = keys.Value;
                int tempcount = keys.Value.Count();
                int nestedCount = 1;
                Console.WriteLine($"{keys.Key}:");
                foreach (var host in ip)
                {
                    char simbul = ',';
                    if (nestedCount == tempcount)
                    {
                        simbul = '.';
                    }
                    int count = host.Value;
                    Console.Write(string.Join(" => ", host.Key, count));
                    Console.WriteLine(simbul);
                    nestedCount++;
                }
            }
        }
    }
}
