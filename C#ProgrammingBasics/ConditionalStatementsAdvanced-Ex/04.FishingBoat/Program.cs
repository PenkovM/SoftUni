using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (season == "Spring")
            {
                totalPrice = 3000;

            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
            }
            if (fishermanCount <= 6)
            {
                totalPrice *= 0.9;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                totalPrice *= 0.85;
            }
            else
            {
                totalPrice *= 0.75;
            }
            if (season == "Winter" || season == "Summer" || season == "Spring")
            {
                if (fishermanCount % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }
            double moneyLeft = groupBudget - totalPrice;
            string output = string.Empty;

            if (groupBudget >= totalPrice)
            {
                output = $"Yes! You have {moneyLeft:f2} leva left.";
            }
            else
            {
                output = $"Not enough money! You need {Math.Abs(moneyLeft):f2} leva. ";






            }
            Console.WriteLine(output);
        }
    }
}
