using System;

namespace _04.MetricCovnerter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metricKind = Console.ReadLine();
            string exitMetricKind = Console.ReadLine();

            double result = 0;

            if (metricKind == "mm" && exitMetricKind == "m")
            {
                result = number / 1000.0;
            }
            else if (metricKind == "m" && exitMetricKind == "cm")
            {
                result = number * 100.0;
            }
            else if (metricKind == "cm" && exitMetricKind == "mm")
            {
                result = number * 10;
            }
            else if (metricKind == "mm" && exitMetricKind == "cm")
            {
                result = number / 10.0;
            }
            else if (metricKind == "m" && exitMetricKind == "mm")
            {
                result = number * 1000;
            }
            else if (metricKind == "cm" && exitMetricKind == "m")
            {
                result = number / 100;
            }

            Console.WriteLine($"{result:F3}");
        }
    }
}
