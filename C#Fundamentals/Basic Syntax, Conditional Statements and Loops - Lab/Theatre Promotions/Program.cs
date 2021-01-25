﻿using System;
using System.Runtime.InteropServices.ComTypes;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    ticketPrice += 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice += 18;
                }

            }
            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    ticketPrice += 15;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice += 20;
                }

            }
            else if (typeOfDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice += 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice += 12;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice += 10;
                }
              
            }
            if(ticketPrice > 0)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }





        }
    }
}

