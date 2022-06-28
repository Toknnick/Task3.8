using System;

namespace Task3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Массив:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }

            Console.WriteLine("\nВведите на сколько позиций передвинуть массив:");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (position > 0)
            {
                int[] temp = new int[position];
                Array.Copy(arrayOfNumbers, temp, position);
                Array.Copy(arrayOfNumbers, position, arrayOfNumbers, 0, arrayOfNumbers.Length - position);
                Array.Copy(temp, 0, arrayOfNumbers, arrayOfNumbers.Length - position, temp.Length);

                foreach (var number in arrayOfNumbers)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
