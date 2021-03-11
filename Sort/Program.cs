using System;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int a;

            Console.WriteLine("Введите 5 чисел");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        a = nums[i];
                        nums[i] = nums[j];
                        nums[j] = a;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
