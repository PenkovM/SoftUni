using System;

namespace _09.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSUm = 0;


            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSUm += numbers;
                }
                else if (i % 2 != 0)
                {
                    oddSum += numbers;
                }


            }

            int diff = Math.Abs(evenSUm - oddSum);

            if (evenSUm == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSUm}");
            }
            if (evenSUm != oddSum)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
