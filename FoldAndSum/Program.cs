using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numbersLength = numbers.Length;

            int upperRowLength = numbersLength / 2;
            int lowerRowLength = numbersLength / 4;

            int[] upperRow = new int[upperRowLength];
            int[] lowerRow = new int[upperRowLength];
            int[] result = new int[upperRowLength];
            int counter = 0;
            for (int i = lowerRowLength; i <= upperRowLength; i++)
            {
                upperRow[counter] = numbers[i];
                counter++;
            }

            counter = 0;
            for (int i = lowerRowLength-1; i >= 0; i--)
            {
                lowerRow[counter] = numbers[i];
                counter++;
            }

            for (int i = numbersLength - 1; i >= numbersLength - lowerRowLength; i--)
            {
                lowerRow[counter] = numbers[i];
                counter++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
