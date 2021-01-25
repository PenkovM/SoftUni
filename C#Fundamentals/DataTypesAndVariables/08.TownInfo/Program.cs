using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {cityName} has population of {population} and area {area} square km.");
        }
    }
}
