using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesForOneDay = cakes * 45;
            double wafflesForOneDay = waffles * 5.80;
            double pancakesForOneDay = pancakes * 3.20;
            double sumForOneDay = (cakesForOneDay + wafflesForOneDay + pancakesForOneDay) * bakers;

            double wholeCampaign = sumForOneDay * days;

            double expences = 1 / 8.0;
            double sumAfterExpences = wholeCampaign - (wholeCampaign * expences);

            Console.WriteLine(sumAfterExpences);

        }
    }
}
