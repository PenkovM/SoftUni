using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            string evenOrOdd = string.Empty;
            string output = string.Empty;

            if (N2 == 0)
            {
                output = $"Cannot divide {N1} by zero";
            }
            else if (operation == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }

                output = $"{N1} {operation} {N2} = {result} - {evenOrOdd}";
            }
            else if (operation == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                output = $"{N1} {operation} {N2} = {result} - {evenOrOdd}";

            }
            else if (operation == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                output = $"{N1} {operation} {N2} = {result} - {evenOrOdd}";
            }
            else if (operation == "/")
            {
                result = (N1 * 1.0) / N2;
                output = $"{N1} {operation} {N2} = {result:f2}";
            }
            else if (operation == "%")
            {
                result = N1 % N2;
                output = $"{N1} {operation} {N2} = {result}";
            }
            Console.WriteLine(output);
        }
    }
}
