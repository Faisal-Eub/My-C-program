using System;
namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original Array: ");
            foreach (int i in arr)
                Console.WriteLine(i);

            Array.Reverse(arr);

            Console.WriteLine("\nReverse Array: ");
            foreach (int i in arr)
                Console.WriteLine(i);





        }



    }
}