using System;

namespace jumbojavelin
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] NI = new int[N];
            for(int i = 0; i < N; i++)
            {
                NI[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(javelinSize(N, NI));
        }
        static int javelinSize(int N, int[] NI )
        {
            int lostCM = N - 1;
            int output = 0 - lostCM;
            for(int i = 0; i < N; i++)
            {
                output += NI[i];
            }
            return output;
        }
    }
}
