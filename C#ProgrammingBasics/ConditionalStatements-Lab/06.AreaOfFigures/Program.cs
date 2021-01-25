using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "square")
            {
                double number = double.Parse(Console.ReadLine());

                area = number * number;
            }
            else if (figure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                area = side * side2;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                area = (side * h) / 2;
            }
            Console.WriteLine($"{area:
        }
    }
}
