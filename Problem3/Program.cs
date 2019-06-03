using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 600851475143;
            primeFactors(number);

            while (true)
            {
                Console.ReadLine();
            }
        }

        public static void primeFactors(long n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i+= 2)
            {
                while(n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                    break;
                }
            }

            if (n > 2)
            {
                Console.Write(n);
            }
        }

    }
}
