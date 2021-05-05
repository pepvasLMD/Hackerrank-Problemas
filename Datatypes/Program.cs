using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            long n;
            string entrada = "";

            T = Convert.ToInt32(Console.ReadLine());

            

            while ( T > 0)
            {
                try {
                    entrada = Console.ReadLine();
                    n = Convert.ToInt64(entrada);

                    Console.WriteLine("{0} can be fitted in:", n);

                    if (n >= 0 && n <= 255)
                    {
                        Console.WriteLine("* byte");
                    }

                    if (n >= -32768 && n <= 32767)
                    {
                        Console.WriteLine("* short");
                    }

                    if (n >= -2147483648 && n <= 2147483647)
                    {
                        Console.WriteLine("* int");
                    }

                    if (n >= -9223372036854775808 && n <= 9223372036854775807)
                    {
                        Console.WriteLine("* long");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(entrada + " can't be fitted anywhere.");
                }
            }
        }
    }
}
