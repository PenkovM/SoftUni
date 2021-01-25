using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string country = string.Empty;
            string vacationType = string.Empty;
            double moneyspent = 0.0;

            if (budget <= 100)
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    moneyspent = budget * 0.30;
                }
                else
                {
                    vacationType = "Hotel";
                    moneyspent = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    moneyspent = budget * 0.40;
                }
                else
                {
                    vacationType = "Hotel";
                    moneyspent = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                country = "Europe";
                if (season == "summer")
                {
                    vacationType = "Hotel";
                    moneyspent = budget * 0.90;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    moneyspent = budget * 0.90;
                }




            }
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{vacationType} - {moneyspent:f2}");

        }
    }
}
