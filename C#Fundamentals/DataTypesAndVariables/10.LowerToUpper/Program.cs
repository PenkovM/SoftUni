﻿using System;

namespace _10.LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
