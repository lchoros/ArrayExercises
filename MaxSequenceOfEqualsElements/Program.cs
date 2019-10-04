using System;
using System.Linq;

namespace MaxSequenceOfEqualsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int seqLen = 1;
            int longestSequenceCounter = 1;
            int bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    seqLen++;
                }
                else
                {
                    seqLen = 1;
                    start = i;
                }
            }
            //Console.WriteLine(string.Join(" ", numbers.Skip(bestStart).Take(longestSequenceCounter)));
        }
    }
}
