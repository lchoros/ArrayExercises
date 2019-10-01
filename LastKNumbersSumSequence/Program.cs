using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                for (int j = i-k; j <= i-1; j++)
                {
                    if (j >= 0)
                    {
                        sum += sequence[j];
                    }
                }
                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
