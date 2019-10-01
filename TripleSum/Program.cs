using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isContain = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if(numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        isContain = true;
                    }
                }
            }

            if(!isContain)
            {
                Console.WriteLine("No");
            }
        }
    }
}
