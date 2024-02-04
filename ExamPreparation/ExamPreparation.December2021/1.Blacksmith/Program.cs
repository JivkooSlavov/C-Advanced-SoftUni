using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int totalSwords = 0;


            SortedDictionary<string, int> swords = new SortedDictionary<string, int>();
            swords.Add("Gladius", 0);
            swords.Add("Shamshir", 0);
            swords.Add("Katana", 0);
            swords.Add("Sabre", 0);
            swords.Add("Broadsword", 0);

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Peek();
                int sumOfSteelAndCarbon = currentCarbon + currentSteel;

                if (sumOfSteelAndCarbon == 70)
                {
                    swords["Gladius"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    totalSwords++;
                }
                else if (sumOfSteelAndCarbon == 80)
                {
                    swords["Shamshir"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    totalSwords++;
                }
                else if (sumOfSteelAndCarbon == 90)
                {
                    swords["Katana"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    totalSwords++;
                }
                else if (sumOfSteelAndCarbon == 110)
                {
                    swords["Sabre"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    totalSwords++;
                }
                else if (sumOfSteelAndCarbon == 150)
                {
                    swords["Broadsword"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    totalSwords++;
                }
                else
                {
                    steel.Dequeue();
                    currentCarbon += 5;
                    carbon.Pop();
                    carbon.Push(currentCarbon);
                }
            }
            if (totalSwords > 0)
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }
            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine("Steel left: " + string.Join(", ", steel));
            }
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine("Carbon left: " + string.Join(", ", carbon));
            }

            foreach (var sword in swords.OrderBy(sword => sword.Key))
            {
                if (sword.Value != 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }

            }
        }
    }
}