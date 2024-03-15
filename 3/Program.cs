using System;

namespace _3
{
    class Program
    {
        delegate double SeriesTerm(int n);
        static void Main(string[] args)
        {

            // Обчислення суми ряду 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...
            double sum1 = CalculateSeries(Term1);
            Console.WriteLine("Sum of series 1 + 1/2 + 1/4 + 1/8 + 1/16 + ... : " + sum1);

            // Обчислення суми ряду 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...
            double sum2 = CalculateSeries(Term2);
            Console.WriteLine("Sum of series 1 + 1/2! + 1/3! + 1/4! + 1/5! + ... : " + sum2);

            // Обчислення суми ряду –1 + 1/2 – 1/4 + 1/8 – 1/16 + ...
            double sum3 = CalculateSeries(Term3);
            Console.WriteLine("Sum of series –1 + 1/2 – 1/4 + 1/8 – 1/16 + ... : " + sum3);
        }
        public static double Term1(int n)
        {
            return 1.0 / Math.Pow(2, n);
        }

        public static double Term2(int n)
        {
            return 1.0 / Factorial(n + 1);
        }

        public static double Term3(int n)
        {
            return Math.Pow(-1, n + 1) / Math.Pow(2, n);
        }

        static double CalculateSeries(SeriesTerm term)
        {
            const double tolerance = 1e-10;
            double sum = 0.0;
            int n = 0;

            while (Math.Abs(term(n)) >= tolerance)
            {
                sum += term(n);
                n++;
            }

            return sum;
        }

        public static double Factorial(int number)
        {
            long factorial = 1;
            while (number != 1)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }
}
