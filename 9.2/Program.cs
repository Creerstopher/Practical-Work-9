using System;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();
            int n1 = 0;
            int n2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    n1 = i;
                    break;
                }
            }
            for (int i = n1 + 1; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    n2 = i;
                    break;
                }
            }
            int sum = 0;
            for (int i = n1 + 1; i < n2; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
