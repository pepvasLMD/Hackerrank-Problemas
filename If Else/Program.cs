using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (numero > 1 && numero < 6)
                {
                    Console.WriteLine("Not weird");
                }

                if (numero > 5 && numero < 21)
                {
                    Console.WriteLine("Weird");
                }

                if (numero > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
