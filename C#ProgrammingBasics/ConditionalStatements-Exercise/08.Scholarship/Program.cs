using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());





            if (success <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (income < minSalary && success < 5.5)
            {
                double socialScholarship = minSalary * 0.35;
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN ");
            }

            else if (income > minSalary && success < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (income > minSalary && success >= 5.5)
            {
                double successScholarship = success * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(successScholarship)} BGN");
            }

            else if (income < minSalary && success >= 5.5)

            {
                double socialScholarship = minSalary * 0.35;
                double successScholarship = success * 25;

                if (socialScholarship > successScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN ");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(successScholarship)} BGN");
                }

            }
            else if (success >= 5.50)
            {
                double socialScholarship = minSalary * 0.35;
                double successScholarship = success * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(successScholarship)} BGN");
            }
        }
    }
}
