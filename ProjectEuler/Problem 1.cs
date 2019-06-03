using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(numbers.Sum());
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
