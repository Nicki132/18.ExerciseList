using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    // The guest is going.
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    // if the guest is not present in the guest list.
                    guestList.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    // The guest is not going.
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    // If the guest is present in the guestlist the we 
                    guestList.Remove(name);
                }
            }
            PrintItemsOnNewLine(guestList);
        }
        static void PrintItemsOnNewLine(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
