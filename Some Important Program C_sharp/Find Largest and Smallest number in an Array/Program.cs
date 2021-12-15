using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float large, small;
            int[] arr;
            Console.WriteLine("Enter the size of the array: ");
            string s = Console.ReadLine();
            n = int.Parse(s);
            arr = new int[n];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);

            }
            Console.WriteLine("");
            large = arr[0];
            small = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }
                else if (arr[i] < small)
                {
                    small = arr[i];
                }
            }

            Console.WriteLine($"largest number :{large}");
            Console.WriteLine($"smallest number :{small}");

        }
    }
}

/*
5
45
47
675
4
45

*/