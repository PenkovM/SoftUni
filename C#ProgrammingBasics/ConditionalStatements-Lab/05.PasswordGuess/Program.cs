using System;

namespace _05.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            string password = Console.ReadLine();

            //Loop:
            while (password != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
                break;
            }
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }


        }
    }
}
