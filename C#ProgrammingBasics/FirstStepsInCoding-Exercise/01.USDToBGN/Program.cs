using System;

namespace _01.USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());

            decimal toBgn = usd * 1.79549m;

            Console.WriteLine(toBgn);
        }
    }
}
