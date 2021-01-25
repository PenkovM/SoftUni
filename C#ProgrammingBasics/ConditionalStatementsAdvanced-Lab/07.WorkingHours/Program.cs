using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int workinghours = int.Parse(Console.ReadLine());
            string dayOFWeek = Console.ReadLine();

            if (dayOFWeek == "Monday" || dayOFWeek == "Tuesday" || dayOFWeek == "Wednesday" || dayOFWeek == "Thursday" || dayOFWeek == "Friday" || dayOFWeek == "Saturday")
            {
                if (workinghours >= 10 && workinghours <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }




        }
    }
}
