﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndREverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result =  new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            if(result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
