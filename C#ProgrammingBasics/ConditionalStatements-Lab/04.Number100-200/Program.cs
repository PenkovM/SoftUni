﻿using System;

namespace _04.Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            int number = int.Parse(Console.ReadLine());

            //Statements:
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
