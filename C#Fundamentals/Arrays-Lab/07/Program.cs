using System;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] arr2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {


                if (arr[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }

            int sum = arr.Sum();

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
