using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                numbers.AddRange(input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
