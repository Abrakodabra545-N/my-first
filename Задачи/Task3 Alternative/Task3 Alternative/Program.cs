using System;

namespace Task3_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine())/ 10;
            int b = Convert.ToInt32(a);
            if (b != 0)
            {
                Console.WriteLine($"{b * (b + 1)}25");
            }
            else
            {
                Console.WriteLine("25");
            }
        }
    }
}
