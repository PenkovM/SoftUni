using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceForApp = 0;
            double priceForStudio = 0;

            if (month == "May" || month == "October")
            {
                priceForStudio = nights * 50;
                priceForApp = nights * 65;

                if (nights > 7 && nights <= 14)
                {
                    priceForStudio *= 0.95;
                }
                else if (nights > 14)
                {
                    priceForStudio *= 0.70;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = nights * 75.20;
                priceForApp = nights * 68.70;

                if (nights > 14)
                {
                    priceForStudio *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = nights * 76;
                priceForApp = nights * 77;
            }
            if (nights > 14)
            {
                priceForApp *= 0.9;
            }
            Console.WriteLine($"Apartment: {priceForApp:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:F2} lv.");
        }
    }
}
