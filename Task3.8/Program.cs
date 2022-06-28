using System;

namespace Task3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Массив:");
            int firstNumber = arrayOfNumbers[0];

            foreach (var number in arrayOfNumbers)
                Console.WriteLine(number);

            Console.WriteLine("\nВведите на сколько позиций передвинуть массив:");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < arrayOfNumbers.Length - position; i++)
            {
                arrayOfNumbers[i] = arrayOfNumbers[i + position];
            }

            arrayOfNumbers[arrayOfNumbers.Length - position] = firstNumber;

            foreach (var number in arrayOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
