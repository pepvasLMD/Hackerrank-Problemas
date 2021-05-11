using System;
using System.Numerics;

namespace Primality_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            bool esPrimo = true;

            if(a == 1)
            {
                esPrimo = false;
            }
            else
            {
                for (BigInteger b = 2; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }


            if (esPrimo)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
