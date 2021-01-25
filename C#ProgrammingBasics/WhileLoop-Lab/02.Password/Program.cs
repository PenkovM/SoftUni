using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string inputPass = Console.ReadLine();
                if (inputPass == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }

            }
        }
    }
}
