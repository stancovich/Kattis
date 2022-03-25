using System;

namespace twostones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int input);
            Console.WriteLine(input % 2 != 0 ? "Alice" : "Bob");
        }
    }
}
