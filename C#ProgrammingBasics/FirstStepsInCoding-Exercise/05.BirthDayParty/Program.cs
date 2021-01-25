using System;

namespace _05.BirthDayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;
            double drinks = cake - (cake * 45) / 100;
            double animator = 1 / 3.0;
            double animatorPrice = rent * animator;
            double sum = rent + cake + drinks + animatorPrice;

            Console.WriteLine(sum);
        }
    }
}
