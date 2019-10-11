using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(i == numbers[i])
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}
