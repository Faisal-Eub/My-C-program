﻿using System;
namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter the level of Pyramid :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= i ; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

















        }
    }
}
