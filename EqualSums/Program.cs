using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = numbers.Length;
            bool canFind = false;
            for (int i = 0; i < length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }


                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(leftSum);
                    canFind = true;
                }
            }
            if(!canFind)
            {
                Console.WriteLine("no");
            }

        }
    }
}
