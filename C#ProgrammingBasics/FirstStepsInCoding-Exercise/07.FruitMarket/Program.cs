using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input :   
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberryes = double.Parse(Console.ReadLine());
            double strawberryes = double.Parse(Console.ReadLine());

            // PriceCalculations:
            double raspberryesPrice = strawberryPrice / 2;
            double orangesPrice = raspberryesPrice - (0.4 * raspberryesPrice);
            double bananasPrice = raspberryesPrice - (0.8 * raspberryesPrice);

            //Sum:
            double raspberryesSum = raspberryes * raspberryesPrice;
            double orangesSum = oranges * orangesPrice;
            double bananasSum = bananas * bananasPrice;
            double strawberryesSum = strawberryes * strawberryPrice;

            //WholeSum:
            double wholeSum = raspberryesSum + orangesSum + bananasSum + strawberryesSum;

            //Output:
            Console.WriteLine($"{wholeSum:f2}");
        }
    }
}
