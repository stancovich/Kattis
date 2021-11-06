using System;

namespace tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] P = new int[N];
            for (int i = 0; i < N; i++)
            { 
                P[i] = int.Parse(Console.ReadLine());
            }
            calculation(X, N, P);
            
        }
        static void calculation(int X, int N, int[]P)
        {
            int totalData = X * (N + 1);
            foreach(int month in P)
            {
                totalData -= month;
            }
            Console.WriteLine(totalData);
        }
    }
}
