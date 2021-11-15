using System;

namespace _9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-30, 30);
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
        }
    }
}
