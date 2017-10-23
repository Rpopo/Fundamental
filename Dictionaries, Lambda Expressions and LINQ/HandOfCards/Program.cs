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
            string[] nameCards = Console.ReadLine()
                .Split(':')
                .ToArray();
            var personCount = new Dictionary<string, List<int>>();

            while (nameCards[0] != "JOKER")
            {
                string name = nameCards[0];


                var cards = nameCards[1]
                    .Split(new char[] { ' ', ',' }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(CardsValue)
                    .ToArray();

                if (!personCount.ContainsKey(nameCards[0]))
                {
                    personCount[nameCards[0]] = new List<int>();
                }
                personCount[nameCards[0]].AddRange(cards);

                nameCards = Console.ReadLine()
                .Split(':')
                .ToArray();

            }

            foreach (var item in personCount)
            {
                string name = item.Key;
                var card = item.Value;

                var totalCard = card.Distinct().Sum();
                Console.WriteLine($"{name}: {totalCard}");

            }
        }


        static int CardsValue(string cards)
        {
            string cardTypes = cards;
            var dicOfPowers = new Dictionary<string, int>();
            dicOfPowers["J"] = 11;
            dicOfPowers["Q"] = 12;
            dicOfPowers["K"] = 13;
            dicOfPowers["A"] = 14;
            for (int i = 2; i <= 10; i++)
            {
                dicOfPowers[i.ToString()] = i;
            }
            var dicOfValues = new Dictionary<string, int>();
            dicOfValues["S"] = 4;
            dicOfValues["H"] = 3;
            dicOfValues["D"] = 2;

            dicOfValues["C"] = 1;

            var power = cardTypes.Substring(0, cardTypes.Length - 1);
            var value = cardTypes.Substring(cardTypes.Length - 1);
            int resultOfMultiplay = dicOfPowers[power] * dicOfValues[value];

            return resultOfMultiplay;


        }
    }
}
