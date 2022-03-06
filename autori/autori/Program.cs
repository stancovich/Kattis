using System;

namespace autori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] slicedInput = Slice(input);
            string FirstLetterOfAllNames = AddFirstLetterOfName(slicedInput);

            Console.WriteLine(FirstLetterOfAllNames);

        }
        static string[] Slice (string input)
        {
            string[] stringArray = input.Split('-');

            return stringArray;
        }
        static string AddFirstLetterOfName(string[] input)
        {
            string output = "";
            foreach (string name in input)
            {
                output += name[0];
            }
            return output;
        }
    }
}
