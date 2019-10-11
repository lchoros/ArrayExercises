using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double multiplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i] * multiplier);
            }
        }
    }
}
