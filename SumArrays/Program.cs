using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int firstLength = arr1.Length;
            int secondLength = arr2.Length;

            int maxLength = Math.Max(firstLength, secondLength);
            int[] sumOfNums = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                sumOfNums[i] = arr1[i % firstLength] + arr2[i % secondLength];
            }
            Console.WriteLine(string.Join("", sumOfNums));
        }
    }
}
