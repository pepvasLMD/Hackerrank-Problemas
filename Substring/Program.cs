using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = Console.ReadLine();
            String[] entrada = Console.ReadLine().Split(" ");
            byte start = Convert.ToByte(entrada[0]);
            byte end = Convert.ToByte(entrada[1]);

            byte diference = (byte)(end - start);

            if(cadena.Length >= 1 && cadena.Length <= 100)
            {
                if(start >= 0 && start <= (cadena.Length -1) && end > start && end <= (cadena.Length -1))
                {
                    Console.WriteLine(cadena.Substring(start, diference));
                }
            }
        }
    }
}
