using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();


            string command = Console.ReadLine();

            while(command != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if(command == names[i])
                    {
                        Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
                        break;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
