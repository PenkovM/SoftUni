using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0.0;

            if (city == "Sofia" || city == "Plovdiv" || city == "Varna")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    if (city == "Sofia")
                    {
                        commission = sales * 0.05;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales * 0.055;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales * 0.045;
                        Console.WriteLine($"{commission:f2}");
                    }
                }
                else if (sales > 500 && sales <= 1000)
                {
                    if (city == "Sofia")
                    {
                        commission = sales * 0.07;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales * 0.075;
                        Console.WriteLine($"{commission:f2}");
                    }
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    if (city == "Sofia")
                    {
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales * 0.10;
                        Console.WriteLine($"{commission:f2}");
                    }
                }
                else if (sales > 10000)
                {
                    if (city == "Sofia")
                    {
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Plovdiv")
                    {
                        commission = sales * 0.145;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (city == "Varna")
                    {
                        commission = sales * 0.13;
                        Console.WriteLine($"{commission:f2}");
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
