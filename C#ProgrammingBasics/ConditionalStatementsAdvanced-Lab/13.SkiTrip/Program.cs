using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int nights = days - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double pricePerNight = 0;

            if (roomType == "room for one person")
            {
                pricePerNight = 18;
            }
            else if (roomType == "apartment")
            {
                pricePerNight = 25;
            }
            else
            { // president apartment
                pricePerNight = 35;
            }
            int discount = 0;

            if (roomType == "apartment")
            {
                if (days < 10)
                {
                    discount = 30;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 35;
                }
                else if (days > 15)
                {
                    discount = 50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    discount = 10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 15;
                }
                else if (days > 15)
                {
                    discount = 20;
                }

            }
            double totalPrice = nights * pricePerNight;

            if (discount != 0)
            {
                //double discountMoney = totalPrice * discount / 100.0;
                //totalPrice = totalPrice - discount;
                totalPrice = totalPrice * (100 - discount) / 100.0;
            }

            if (rating == "positive")
            {
                totalPrice = totalPrice * 1.25;
            }
            else
            {
                totalPrice = totalPrice * 0.9;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
