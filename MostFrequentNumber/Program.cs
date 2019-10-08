using System;
using System.Linq;


namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            int[] count = new int[65536];

            for (int i = 0; i < numbers.Length; i++)
            {
                count[numbers[i]]++;
            }
            int max = count.Max();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (count[numbers[i]] == max)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }

            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int longestFrequency = 0;
            //int length = numbers.Length;
            //int mostFrequentNumber = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    int frequencyCounter = 0;
            //    for (int j = 0; j < length; j++)
            //    {
            //        if(numbers[i] == numbers[j])
            //        {
            //            frequencyCounter++;
            //        }
            //    }
            //    if(frequencyCounter > longestFrequency)
            //    {
            //        longestFrequency = frequencyCounter;
            //        mostFrequentNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(mostFrequentNumber);
        }
    }
}
