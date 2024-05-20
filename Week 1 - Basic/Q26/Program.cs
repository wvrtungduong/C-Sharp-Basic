using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2, sum = 0, count = 0;
            while (count < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    count++;
                }
                n++;
            }
            Console.WriteLine(sum);
        }

        static bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}