using System;

namespace _08.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double price = meters * 7.61;
            double discount = 0.18 * price;
            double total = price - discount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The Discount is: {discount} lv.");
        }
    }
}
