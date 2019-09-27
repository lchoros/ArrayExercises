using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)('a' + n);
            for (char l1 = 'a'; l1 < letter; l1++)
            {
                for (char l2 = 'a'; l2 < letter; l2++)
                {
                    for (char l3 = 'a'; l3 < letter; l3++)
                    {
                        Console.WriteLine("{0}{1}{2}", l1, l2, l3);
                    }
                }
            }
        }
    }
}
