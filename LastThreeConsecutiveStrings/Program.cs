using System;
using System.Linq;

namespace LastThreeConsecutiveStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int counter = 1;

            int start = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if(words[i] == words[i-1])
                {
                    counter++;
                    if(counter > 2)
                    {
                        start = i - 2;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ", words.Skip(start).Take(3)));
        }
    }
}
