using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowerType == "Roses")
            {
                totalPrice = numberOfFlowers * 5;
                if (numberOfFlowers > 80)
                {
                    totalPrice *= 0.90;
                }
            }
            else if (flowerType == "Dahlias")
            {
                totalPrice = numberOfFlowers * 3.8;
                if (numberOfFlowers > 90)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                totalPrice = numberOfFlowers * 2.8;
                if (numberOfFlowers > 80)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                totalPrice = numberOfFlowers * 3;
                if (numberOfFlowers < 120)
                {
                    totalPrice *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                totalPrice = numberOfFlowers * 2.5;
                if (numberOfFlowers < 80)
                {
                    totalPrice *= 1.20;
                }
            }

            double moneyLeft = budget - totalPrice;
            string output = string.Empty;

            if (budget >= totalPrice)
            {
                output = $"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {moneyLeft:f2} leva left.";


            }
            else
            {
                output = $"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.";
            }
            Console.WriteLine(output);
        }
    }
}
