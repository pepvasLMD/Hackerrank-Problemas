using System;

namespace Stdin_And_Stdout_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInt = Convert.ToInt32(Console.ReadLine());
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            string inputString = Console.ReadLine();

            Console.WriteLine("String: {0}", inputString);
            Console.WriteLine("Double: {0}", inputDouble);
            Console.WriteLine("Int: {0}", inputInt);

        }
    }
}
