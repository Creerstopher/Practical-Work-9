using System;

namespace _9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int P = 1;
            for (int i = 0; i < n; i += 2)
                P *= arr[i];
            Console.WriteLine("P = " +P);
            Console.ReadLine();
        }
    }
}
