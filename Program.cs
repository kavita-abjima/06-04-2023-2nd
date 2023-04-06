using System;
using System.Globalization;



namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello";
            int i, j;
            for (i = 0; i < test.Length; i++)
            {
                for (j = i; j < test.Length; j++)
                {
                    Console.Write(test.Substring(i, (j - i) + 1) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}

/*output
H, He, Hel, Hell, Hello 
e, el, ell, ello
l, ll, llo
l, lo
o */
