using System;

namespace _12.RefactorSpecailNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isValid = true;
            for (int ch = 1; ch <= n; ch++)
            {
                int sumOfDigits = 0;
                int digits = 0;
                digits = ch;
                while (ch > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                isValid = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", ch, isValid);
            }
    }
}
