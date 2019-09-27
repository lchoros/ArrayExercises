using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcatSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
