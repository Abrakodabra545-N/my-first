using System;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"a = {a}");

            Increment(a);
            Console.WriteLine($"a передача по значению = {a}");
            IncrementRef(ref a);
            Console.WriteLine($"a передача по ссылке = {a}");
        }
        static void Increment(int b)
        {
            b++;  
        }
        static void IncrementRef(ref int b)
        {
            b++;
        }
    }
}
