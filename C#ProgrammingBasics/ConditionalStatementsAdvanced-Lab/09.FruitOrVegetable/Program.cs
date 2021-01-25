using System;

namespace _09.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string productType = string.Empty;

            switch (product)
            {
                case "banana":
                case "kiwi":
                case "apple":
                case "cherry":
                case "lemon":
                case "grapes":
                    productType = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    productType = "vegetable";
                    break;
                default:
                    productType = "unknown";
                    break;
            }
            Console.WriteLine(productType);
        }
    }
}
