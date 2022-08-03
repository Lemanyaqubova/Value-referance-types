using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 9, 12 };
            int min = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
         
        }
    }
}
