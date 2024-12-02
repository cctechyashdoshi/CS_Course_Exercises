using System;

namespace Using_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
