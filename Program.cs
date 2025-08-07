using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            Console.WriteLine("Enter 3 numbers to generate multiplication tables:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write($"Number {i + 1}: ");
                }
            }
            
            Console.WriteLine("\nMultiplication Tables:");
            
            foreach (int num in numbers)
            {
                Console.WriteLine($"\nTable for {num}:");
                for (int multiplier = 1; multiplier <= 10; multiplier++)
                {
                    Console.WriteLine($"{num} × {multiplier} = {num * multiplier}");
                }
            }

        }
    }
}
