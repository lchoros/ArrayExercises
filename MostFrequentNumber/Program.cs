using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestFrequency = 0;
            int mostFrequent = numbers[0];

            int length = numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumberFrequency = 0;
                for (int j = 0; j < numbers.Length; j++)
                {

                }
            }
        }
    }
}
