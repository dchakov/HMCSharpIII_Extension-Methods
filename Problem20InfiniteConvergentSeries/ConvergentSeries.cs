using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20InfiniteConvergentSeries
{
    public static class ConvergentSeries
    {
        public delegate double ConvergentDelegate(double precision);

        public static double Calculation(double precision)
        {
            double sum = 0;
            double element = 1;
            while (element > precision)
            {
                sum += element;
                element /= 2;
            }
            return sum;
        }
        public static double CalculationFact(double precision)
        {
            double sum = 0;
            double element = 1;
            ulong counter = 1;
            while (element > precision)
            {
                sum += element;
                counter++;
                ulong product = 1;
                for (ulong i = 1; i <= counter; i++)
                {
                    product *= i;
                }
                element = ((double)1) / product;
            }
            return sum;
        }
        public static double CalculationMinus(double precision)
        {
            double sum = 0;
            double element = 1;
            ulong counter = 1;
            while (Math.Abs(element) > precision)
            {
                sum += element;
                counter++;
                if (counter % 2 == 0)
                {
                    element /= 2;
                }
                else
                {
                    element /= -2;
                }
            }
            return sum;
        }

        public static double ProductSeries(Func<int, double> function, double precision)
        {
            double sum = 0;
            double element = 1;
            int counter = 2;
            while (Math.Abs(element) > precision)
            {
                sum += element;
                element = function(counter);
                counter++;
            }
            return sum;
        }

        public static void Main()
        {
            ConvergentDelegate cal1 = new ConvergentDelegate(Calculation);
            ConvergentDelegate cal2 = new ConvergentDelegate(CalculationFact);
            ConvergentDelegate cal3 = new ConvergentDelegate(CalculationMinus);
            Console.WriteLine(cal1(0.001));
            Console.WriteLine(cal2(0.001));
            Console.WriteLine(cal3(0.001));
            Console.WriteLine("Math E");
            Console.WriteLine(Math.E);

            // Baretata
            Console.WriteLine();
            Console.WriteLine(ProductSeries(index => 1 / Math.Pow(2, index - 1), 0.001));
            Console.WriteLine(ProductSeries(index => 1d / Enumerable.Range(1, index).Aggregate((a, b) => a * b), 0.001));
            Console.WriteLine(ProductSeries(index => -1 / Math.Pow(-2, index - 1), 0.001));

        }
    }
}