using System;

namespace _07.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherPets = int.Parse(Console.ReadLine());

            double dogFood = 2.5;
            int otherFood = 4;

            double totalDogFood = dogs * dogFood;
            int totalOtherFood = otherPets * otherFood;

            Console.WriteLine($" {totalOtherFood + totalDogFood} lv.");
        }
    }
}
