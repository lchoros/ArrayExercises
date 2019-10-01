using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;
            if (length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else if (length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", input[length / 2 - 1], input[length / 2]);
            }
            else if (length % 2 != 0)
            {
                Console.WriteLine("{0}, {1}, {2}", input[length / 2 - 1], input[length / 2], input[length / 2 + 1]);
            }
        }
    }
}
