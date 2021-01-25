using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            string result = char1.ToString() + char2.ToString() + char3.ToString();

            Console.WriteLine(result);
        }
    }
}
