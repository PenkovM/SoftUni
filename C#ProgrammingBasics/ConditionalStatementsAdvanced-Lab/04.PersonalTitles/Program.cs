using System;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string output = string.Empty;

            if (gender == "m" && age >= 16)
            {
                output = "Mr.";
            }
            else if (gender == "m" && age < 16)
            {
                output = "Master";
            }
            else if (gender == "f" && age >= 16)
            {
                output = "Ms.";
            }
            else if (gender == "f" && age < 16)
            {
                output = "Miss";
            }

            Console.WriteLine(output);
        }
    }
}
