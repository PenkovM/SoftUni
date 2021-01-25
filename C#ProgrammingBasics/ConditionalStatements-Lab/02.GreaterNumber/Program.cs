using System;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //Statements:
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
