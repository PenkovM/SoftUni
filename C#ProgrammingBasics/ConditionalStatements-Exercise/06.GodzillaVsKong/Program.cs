using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());


            double decorSum = budget * 10 / 100;
            double clothingSum = extras * clothingPrice;


            if (extras > 150)
            {
                clothingSum = clothingSum * 0.9;
            }
            double budgetSum = decorSum + clothingSum;
            double moneyLeft = Math.Abs(budget - budgetSum);
            if (budgetSum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyLeft:F2} leva more.");

            }
        }
    }
}
