using System;

namespace _04.VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesForOneHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double wholeTime = pages / pagesForOneHour;
            double neededHours = wholeTime / days;

            Console.WriteLine(neededHours);
        }
    }
}
