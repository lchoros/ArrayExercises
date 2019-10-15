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
            int length = numbers.Length;

            string command = Console.ReadLine();

            while(command != "done")
            {
                string[] commands = command.Split(' ');
                string com = string.Empty;
                string recipient = string.Empty;
                string result = string.Empty;
                for (int i = 0; i < length; i++)
                {

                }
                if (commands[0] == "message")
                {
                    com = "sending sms to ";
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
                else
                {
                    com = "calling";
                }

                for (int i = 0; i < length; i++)
                {
                    if (commands[1] == numbers[i])
                    {
                        recipient = names[i];
                    }
                    else if (commands[1] == names[i])
                    {
                        recipient = $"{ numbers[i] }...";
                    }
                    break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
