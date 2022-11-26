using System;

namespace HigherAndLowerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double higher = 0, lower = 0, number;

            Console.WriteLine("Enter 15 numbers:");

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{i + 1}º: ");
                number = double.Parse(Console.ReadLine());

                if (i == 0)
                    lower = higher = number;
                
                else if (number > higher)
                    higher = number;

                else if (number < lower)
                    lower = number;
            }

            Console.WriteLine("{0} has the higher value, while {1} has the lower", higher, lower);

            Console.ReadKey();
        }
    }
}
