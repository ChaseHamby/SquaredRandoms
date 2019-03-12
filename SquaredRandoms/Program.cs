using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var randomList = new List<int>();
            var squaredList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                randomList.Add(rnd.Next(50));
            }

            foreach (var number in randomList)
            {
                var squared = number * number;
                if (squared % 2 != 1)
                {
                    squaredList.Add(squared);
                }
                Console.WriteLine(number);
            }

            Console.WriteLine($"Odd numbers removed - here is the final list: ");

            foreach (var result in squaredList)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
