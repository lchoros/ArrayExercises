using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                bool isEqual = false;
                while(number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if(sum == 5 || sum == 7 || sum == 11)
                {
                    isEqual = true;
                }
                Console.WriteLine("{0} -> {1}", i, isEqual);
            }
        }
    }
}
