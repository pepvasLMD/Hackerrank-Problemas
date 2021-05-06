using System;

namespace Date_And_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] entrada = Console.ReadLine().Split(" ");
            byte month = Convert.ToByte(entrada[0]);
            byte day = Convert.ToByte(entrada[1]);
            short year = Convert.ToInt16(entrada[2]);

            Console.WriteLine(getDay(month, day, year));
        }

        static string getDay(int month, int day, int year)
        {
            DateTime dt = new DateTime(year, month, day);

            return dt.DayOfWeek.ToString().ToUpper();
        }
    }
}
