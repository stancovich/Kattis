using System;

namespace aaah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string doctorInput = Console.ReadLine();
            Console.WriteLine(NoOrGo(input, doctorInput));
        }
        static string NoOrGo(string input, string doctorInput)
        {
            return input.Length >= doctorInput.Length ? "go" : "no";
        }
    }
}
