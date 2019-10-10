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
            int bestSequence = 1;
            int bestStart = 0;
            int length = numbers.Length - 1;


            for (int i = 1; i < length+1; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    seqLen++;
                    if(seqLen > bestSequence)
                    {
                        bestSequence = seqLen;
                        bestStart = start;
                    }
                }
                else
                {
                    seqLen = 1;
                    start = i;
                }
            }

            for (int i = bestStart; i < bestSequence; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

        }
    }
}
