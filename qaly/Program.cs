using System;

namespace qaly
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal sumQaly = 0;
            string[] Ni = new string[N];
            for (int i = 0; i < N; i++)
            {
                Ni[i] = Console.ReadLine();
            }
            for (int i = 0; i < N; i++)
            {
                string[]temp = Ni[i].Split(' ');
                decimal result = decimal.Parse(temp[0]) * decimal.Parse(temp[1]);
                sumQaly += result;
            }
            Console.WriteLine(sumQaly);
        }
    }
}
