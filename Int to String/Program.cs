using System;

namespace Int_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n;

            try
            {
                n = Convert.ToSByte(Console.ReadLine());

                if (n >= -100 && n <= 100)
                {
                    Console.WriteLine("Good Job");
                }
                else
                {
                    Console.WriteLine("Wrong answer");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong answer");
            }
        }
    }
}
