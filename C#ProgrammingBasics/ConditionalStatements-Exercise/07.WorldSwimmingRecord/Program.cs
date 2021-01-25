using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeInSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double metersToSwim = meters * secondsForOneMeter;
            double penaltyTime = Math.Floor(meters / 15) * 12.5;
            double time = metersToSwim + penaltyTime;

            if (timeInSeconds <= time)
            {
                double timeDiff = time - timeInSeconds;
                Console.WriteLine($"No, he failed! He was {timeDiff:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
        }
    }
}
