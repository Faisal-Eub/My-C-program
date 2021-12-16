using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palindrome
{
    static void Main(string[] args)
    {

        string text, reverse = "";
        Console.WriteLine("Enter a string: ");
        text = Console.ReadLine();

        int len = text.Length;

        for (int i = len - 1; i >= 0; i--)
        {
            reverse = reverse + text.ElementAt(i);
            //reverse = reverse + text[i];
        }

        if (text == reverse)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FASLE");



        /*  Another code ---
            string text;
            text = Console.ReadLine();
        
            char x;

            string str = string.Empty;
            int len = text.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                x = text[i];
                str = str + x;
            }
            str = str.ToLower();
            text = text.ToLower();
            if (text == str)
            {
            Console.WriteLine("true");
            }
            else
            {
            Console.WriteLine("false");
            }

        */


    }

}
