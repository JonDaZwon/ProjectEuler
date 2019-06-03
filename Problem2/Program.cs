using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            while (numbers.Last() <= 4000000)
            {
                int number = Fibbo(numbers[numbers.Count - 1], numbers[numbers.Count - 2]);
                if (number < 4000000)
                    numbers.Add(number);
                else break;
            }

            foreach(int i in numbers.ToList())
            {
                if (i % 2 == 1)
                {
                    numbers.Remove(i);
                }
            }

            Console.WriteLine(numbers.Sum());

            while (true)
            {
                Console.ReadLine();
            }
        }

        static int Fibbo(int n1, int n2)
        {
            int n3;
            n3 = n1 + n2;
            return n3;
        }
    }
}
