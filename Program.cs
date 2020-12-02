using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String a = "Joseph Staline";
            char[] x = a.ToCharArray(0, a.Length);
            foreach (var sub in x)
            {
                Console.WriteLine($"Substring: {sub}");
            }

        }
    }
}
