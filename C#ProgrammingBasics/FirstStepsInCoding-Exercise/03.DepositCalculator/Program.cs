using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double insert = double.Parse(Console.ReadLine());

            double insertIncrease = depositSum * insert / 100;
            double insertForOneMonth = insertIncrease / 12;
            double sum = depositSum + (insertForOneMonth * time);

            Console.WriteLine(sum);
        }
    }
}
