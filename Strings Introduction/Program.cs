using System;

namespace Strings_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            String A = Console.ReadLine();
            String B = Console.ReadLine();

            Console.WriteLine((A.Length + B.Length));

            if (A.CompareTo(B) > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            
            Console.WriteLine(char.ToUpper(A[0]) + A.Substring(1) + " " + char.ToUpper(B[0]) + B.Substring(1));
        }
    }
}
