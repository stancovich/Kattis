using System;

namespace qaly
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal sumQaly = 0;
            string[] input = new string[N];
            for (int i = 0; i < N; i++)
            {
                input[i] = Console.ReadLine();
            }
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                string[]temp = input[i].Split(' ');
                decimal result = decimal.Parse(temp[0]) * decimal.Parse(temp[1]);
                sumQaly += result;
            }
            Console.WriteLine(sumQaly);
        }
    }
}
