using System;

namespace Loops_I
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, N;

            N = Convert.ToByte(Console.ReadLine());

            if(N > 1 && N <= 20)
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x  {1} = {2}", N, i, (N * i));
                }
            }
            
        }
    }
}
