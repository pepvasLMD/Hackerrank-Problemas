using System;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            short q;
            sbyte a, b, n, i;
            ushort aux;

            q = Convert.ToInt16(Console.ReadLine());

            if (q >= 0 && q <= 500)
            {

                while (q > 0)
                {
                    string[] argumentos = Console.ReadLine().Split(" ");
                    a = Convert.ToSByte(argumentos[0]);
                    b = Convert.ToSByte(argumentos[1]);
                    n = Convert.ToSByte(argumentos[2]);

                    if ((a >= 0 && a <= 50) && (b >= 0 && b <= 50) && (n >= 0 && n <= 15))
                    {
                        aux = (ushort)a;

                        for (i = 0; i < n; i++)
                        {
                            aux += (ushort)(Math.Pow(2, i) * b);
                            Console.Write(aux + " ");
                        }
                    }

                    Console.WriteLine();

                    q--;
                }
            }

        }
    }
}
