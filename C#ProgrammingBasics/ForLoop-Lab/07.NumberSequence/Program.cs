using System;

namespace _07.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxnumber)
                {
                    maxnumber = currentNumber;
                }
                if (currentNumber < minnumber)
                {
                    minnumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxnumber}");
            Console.WriteLine($"Min number: {minnumber}");
        }
    }
}
