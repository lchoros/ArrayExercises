using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            int counter = 0;
            for (char i = 'a'; i <= 'z'; i++, counter++)
            {
                alphabet[counter] = i;
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(word[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", word[i], j);
                        break;
                    }
                }
            }
        }
    }
}
