using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Console.Write("{0} ",words[words.Length - 1]);
            for (int i = 1; i < words.Length; i++)
            {
                Console.Write("{0} ", words[i-1]);
            }
        }
    }
}
