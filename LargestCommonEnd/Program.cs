using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            int length = Math.Min(arr1.Length, arr2.Length);


            int seq1Length = 0;
            for (int i = 0; i < length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    break;
                }
                seq1Length++;
            }

            int seq2Length = 0;

            for (int i = length-1; i >= 0; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    break;
                }
                seq2Length++;
            }

            Console.WriteLine(Math.Max(seq1Length, seq2Length));
        }
    }
}
