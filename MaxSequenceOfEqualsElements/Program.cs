using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sequenceCounter = 1;
            int start = 0;
            int longestSequenceCounter = 1;
            int bestStart = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 1;
                }
                if(sequenceCounter > longestSequenceCounter)
                {
                    bestStart = i;
                    longestSequenceCounter = sequenceCounter;
                }
            }
            Console.WriteLine(string.Join(" ", numbers.Skip(bestStart).Take(longestSequenceCounter)));
        }
    }
}
