using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int lowestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < lowestNumber)
                {
                    lowestNumber = numbers[i];
                }
            }
            Console.WriteLine(lowestNumber);
        }
    }
}
