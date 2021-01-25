using System;

namespace _11.RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, heigth = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            double volume = (length * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
