﻿using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = group * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = group * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = group * 10.46;
                }

                if (group >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (group >= 100)
                {
                    group -= 10;
                }

                if (day == "Friday")
                {
                    price = group * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = group * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = group * 16;
                }


            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = group * 15;
                }
                else if (day == "Saturday")
                {
                    price = group * 20;
                }
                else if (day == "Sunday")
                {
                    price = group * 22.50;
                }

                if (group >= 10 && group <= 20)
                {
                    price *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
