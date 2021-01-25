using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzelsMoney = puzzels * 2.60;
            double dollsMoney = dolls * 3;
            double teddybearsMoney = teddybears * 4.10;
            double minionsMoney = minions * 8.20;
            double trucksMoney = trucks * 2;

            double sum = puzzelsMoney + dollsMoney + teddybearsMoney + minionsMoney + trucksMoney;
            double toys = puzzels + dolls + teddybears + minions + trucks;

            if (toys >= 50)
            {
                sum = sum * 0.75;
            }
            sum = sum * 0.9;
            if (sum >= vacation)
            {
                double remainingMoney = sum - vacation;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            else if (sum <= vacation)
            {
                double remainingMoney = vacation - sum;
                Console.WriteLine($"Not enough money! {remainingMoney:F2} lv needed.");
            }
        }
    }
}
