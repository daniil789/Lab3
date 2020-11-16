using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 0.0001;
            int k = 10;
            int n = 10;
            double a = 0.1;
            double b = 1;
            double Se, Sn, An, x = a;
            double step = (b - a) / k;
            int i;

            do
            {
                Sn = 1;
                Se = 1;

                for (i = 1; i < n; i++)
                {
                    Sn += (Math.Pow(Math.Log10(3), i)*Math.Pow(x,i))/Factorial(i);
                }

                for (i = 1, An = 1; An >= e; i++)
                {
                    An *= (Math.Pow(Math.Log10(3), i) * Math.Pow(x, i)) / Factorial(i);
                    Se += An;
                }

                double exp = Math.Pow(3, x);
                Console.WriteLine($"X = {(float)x} Sn = {(float)Sn} Se = {(float)Se} Y = {(float)exp}");
                x += step;
            }
            while (x <= b);
        }

        private static int Factorial(int val)
        {
            int factorial = 1;

            for (int i = 2; i <= val; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}