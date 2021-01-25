using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            //Aquarium Capacity:
            double aquaCapacity = lenght * width * height;

            //Liters:
            double capacityInLiters = aquaCapacity * 0.001;

            //Percent Calculations:
            double exactPercent = percent * 0.01;
            double neededLiters = capacityInLiters * (1 - exactPercent);

            //Output:
            Console.WriteLine(neededLiters);

        }
    }
}
