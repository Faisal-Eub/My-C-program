using System;

namespace Matrix_Additon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row and column of the matrix");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            //int row = Convert.ToInt32((Console.Readline));
            //int col = Convert.ToInt32((Console.Readline));
            int[,] arr1 = new int[row, col];


            Console.WriteLine("Enter 1st matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                    //arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("First matrix: ");
             for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr1[i, j] + "  ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Enter 2nd Matrix: ");
            int[,] arr2 = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    //arr2[i,j] = int.Parse(Console.ReadLine()); 
                }
            }

            Console.WriteLine("Second matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr2[i, j] + "  ");
                }
                Console.WriteLine();
            }


            int[,] arr3 = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            Console.WriteLine("\nMatrix Additon: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr3[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}