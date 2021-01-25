using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int sum = 0;
            while (true)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (sum >= n)
                {
                    Console.WriteLine(sum);
                    break;

                }

            }
        }
    }
}
