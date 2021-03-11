using System;

namespace Task68
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == "School" & b % 2 == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
