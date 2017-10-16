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
            var phoneBook = new Dictionary<string, string>();
            phoneBook["Rado"] = "0883355509";
            phoneBook["Elena"] = "0883123421";
            phoneBook["Gergana"] = "+359-122-123-12";
            phoneBook["Home"] = "0-55-9-2-45-81";
            string velu;
            if (phoneBook.TryGetValue("Rado", out velu))
            {
               // Console.WriteLine(velu);
            }
        }
    }
}
