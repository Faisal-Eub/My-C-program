using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[6];
            int len1 = arr1.Length;
            Console.WriteLine($"Length of the 1D array: {len1}");

            int[,] arr2 = new int[5, 10];
            int len2 = arr2.Length;
            Console.WriteLine($"length of the 2D arry: {len2}");

        }
    }
}