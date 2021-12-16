using System;
namespace Alphabetic_order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            
            names.Add("Shuvo");
            names.Add("Shakib");
            names.Add("Muhammad");

            Console.WriteLine("Array without sorting: ");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            names.Sort();

            Console.WriteLine("\nArray after sorting: ");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

        }
    }
}