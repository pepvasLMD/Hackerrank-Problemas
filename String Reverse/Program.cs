using System;

namespace String_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int half, i = 0;
            bool isPalindrome = true;
            String A = Console.ReadLine();

            half = A.Length / 2;

            if(A.Length == 0)
            {
                isPalindrome = false;
            }

            while(isPalindrome && i < half)
            {
                if(A[i].CompareTo(A[A.Length-1-i]) != 0)
                {
                    isPalindrome = false;
                }

                i++;
            }

            if (isPalindrome)
            {
                Console.WriteLine("Yes if it is a palindrome");
            }
            else
            {
                Console.WriteLine("No otherwise");
            }
        }
    }
}
