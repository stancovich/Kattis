using System;

namespace different
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] input = line.Split(' ');
                int.TryParse(input[0], out int num1);
                int.TryParse(input[1], out int num2);
                int output = Math.Abs(num1 - num2);
                Console.WriteLine(output);
            }
        }
    }
}
