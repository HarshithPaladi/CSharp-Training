using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFile
{
    internal class firstlastreversal
    {
        // Q1
        // Write a C# Sharp program to exchange the first and last characters
        // in a given string and return the new string
        public void FirstLast_Reversal()
        {
            Console.Write("Enter String: ");
            string a = Convert.ToString(Console.ReadLine());
            var first = a[0];
            var last = a[a.Length - 1];
            Console.WriteLine(last + a.Substring(1, a.Length - 2) + first);
        }

        // Q2
        // Write a C# Sharp program to create a new string with the last char
        // added at the front and back of a given string of length 1 or more.

        public void FrontBackAdd()
        {
            Console.Write("Enter String: ");
            string a = Convert.ToString(Console.ReadLine());
            char symbol = a[a.Length-1];
            Console.WriteLine(symbol + a + symbol);
        }

        // Q3
        // Write a C# Sharp program to check if a string 'ok' appears in a given string.
        // If it appears return a string without 'ok' otherwise return the original string.

        public void CheckOk()
        {
            Console.Write("Enter String: ");
            string a = Convert.ToString(Console.ReadLine()).ToLower();
            string b = "ok";

            while (a.Contains(b))
            {
                a = a.Remove(a.IndexOf(b),b.Length);
            }
            Console.WriteLine(a);
            


        }


    }
}
