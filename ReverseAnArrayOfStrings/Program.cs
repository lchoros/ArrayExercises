using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < words.Length / 2; i++)
            {
                words.Reverse(); 
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
