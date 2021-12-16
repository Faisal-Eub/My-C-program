using System;
namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int[] arr = { 16, 5, 4, 1, 10 };

            Console.WriteLine("Original Array: ");
            foreach (int i in arr)
                Console.WriteLine(i);

            Array.Sort(arr);

            Console.WriteLine("\nSorting Array: ");
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
}
