using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[4] { 1, 3, 6, 10 };
            arr[1] = new int[7] { 34, 45, 4, 54, 8, 7, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Elements of row no {i+1} of jagged arry: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}