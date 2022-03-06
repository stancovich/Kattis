using System;

namespace oddecho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for(int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
