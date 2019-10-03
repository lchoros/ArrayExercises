using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int length = Math.Min(arr1.Length, arr2.Length);
            bool allLettersEqual = true;
            bool isFirstBigger = true;
            for (int i = 0; i < length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    allLettersEqual = false;
                    if (arr1[i] < arr1[2])
                    {
                        isFirstBigger = false;
                    }
                    break;
                }
            }

            if(allLettersEqual)
            {
                if(arr1.Length <= arr2.Length)
                {
                    Console.WriteLine(new string(arr1));
                    Console.WriteLine(string.Join("", arr2));
                } 
                else
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
            else
            {
                if(isFirstBigger)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
                else
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
        }
    }
}
