using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsHome = double.Parse(Console.ReadLine());

            double sofiaWeekends = (48.0 - weekendsHome) * (3.0 / 4.0);
            double playSofia = holidays * (2.0 / 3.0);
            double playTotal = sofiaWeekends + playSofia + weekendsHome;

            if (year.Equals("leap"))
            {
                playTotal = Math.Floor(playTotal * 15 / 100 + playTotal);
            }
            else if (year.Equals("normal"))
            {
                playTotal = Math.Floor(playTotal);
            }
            Console.WriteLine(playTotal);
        }
    }
}
