using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            int counter = 1;
            double currentSum = 0;

            while (counter <= entries)
            {
                double income = double.Parse(Console.ReadLine());
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    currentSum += income;
                    Console.WriteLine($"Your account balance was increased by: {income:f2}");
                }
                counter++;
            }
            Console.WriteLine($"Total balance: {currentSum}");
        }
    }
}