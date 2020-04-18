using System;
namespace Program1
{
    class Program
    {
        class Converter
        {
            public static double usd { get; set; }
            public static double eur { get; set; }
            public static double rub { get; set; }
            public Converter(double us, double eu, double rb)
            {
                usd = us;
                eur = eu;
                rub = rb;
            }
            public static double SmnToUsd(double som)
            {
                double us = Math.Round(som * usd, 4);
                return us;
            }
            public static double SmnToEur(double som)
            {
                double eu = Math.Round(som * eur, 4);
                return eu;
            }
            public static double SmnToRub(double som)
            {
                double rb = Math.Round(som * rub, 4);
                return rb;
            }
            public static double UsdToSmn(double us)
            {
                if (usd != 0)
                {
                    double som = Math.Round(us / usd, 4);
                    return som;
                }
                else
                {
                    Console.WriteLine("Error1");
                    return 0;
                }
            }
            public static double EurToSmn(double eu)
            {
                if (eur != 0)
                {
                    double som = Math.Round(eu / eur, 4);
                    return som;
                }
                else
                {
                    Console.WriteLine("Error2");
                    return 0;
                }
            }
            public static double RubToSmn(double rb)
            {
                if (rub != 0)
                {
                    double som = Math.Round(rb / rub, 4);
                    return som;
                }
                else
                {
                    Console.WriteLine("Error3");
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Converter n = new Converter(0.099, 0.089, 7.22);
            int choice;
        j8:
            Console.WriteLine("Converter command:");
            Console.WriteLine("From smn to $ - 1");
            Console.WriteLine("From smn to £ - 2");
            Console.WriteLine("From smn to R - 3");
            Console.WriteLine("From $ to smn - 4");
            Console.WriteLine("From £ to smn - 5");
            Console.WriteLine("From R to smn - 6");
            while (true)
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 6)
                    Console.WriteLine("ERROR! You choice out of range!");
                else
                    break;
            }
            Console.WriteLine("You sum: ");
            double sum = double.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{sum} somon == {Converter.SmnToUsd(sum)} dollar");
                    break;
                case 2:
                    Console.WriteLine($"{sum} somon == {Converter.SmnToEur(sum)} euro");
                    break;
                case 3:
                    Console.WriteLine($"{sum} somon== {Converter.SmnToRub(sum)} ruble");
                    break;
                case 4:
                    Console.WriteLine($"{sum} dollar == {Converter.UsdToSmn(sum)} somon");
                    break;
                case 5:
                    Console.WriteLine($"{sum} euro == {Converter.EurToSmn(sum)} somon");
                    break;
                case 6:
                    Console.WriteLine($"{sum} ruble == {Converter.RubToSmn(sum)} somon");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            Console.WriteLine();
            goto j8;
        }

    }
}