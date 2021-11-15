using System;

namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = Math.Pow(arr[i], 2);
                }
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
        }
    }
}
