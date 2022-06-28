using System;

namespace Task3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int[] arrayOfNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Массив:");

            foreach (var number in arrayOfNumbers)
                Console.Write(number + " ");

            Console.WriteLine("\nЧтобы сдвинуть массив введите число 1:");
            int number1 = 0;
            Console.WriteLine();

            while (isWork)
            {
                int position = int.Parse(Console.ReadLine());
                int firstNumber = arrayOfNumbers[number1];

                for (int i = 0; i < arrayOfNumbers.Length - position; i++)
                {
                    arrayOfNumbers[i] = arrayOfNumbers[i + position];
                }

                arrayOfNumbers[arrayOfNumbers.Length - position] = firstNumber;

                foreach (var number in arrayOfNumbers)
                {
                    Console.Write(number + " ");
                }

                if (position != 1)
                {
                    Console.WriteLine("Error\n");
                    isWork = false;
                }

                Console.WriteLine();
            }
        }
    }
}
