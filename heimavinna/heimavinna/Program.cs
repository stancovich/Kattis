using System;

namespace heimavinna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = SplitInput(input);
            int problems = CountSpots(splitInput);
            Console.WriteLine(problems);
        }
        static string[] SplitInput(string input)
        {
            return input.Split(';');
        }
        static int CountSpots(string[] input)
        {
            int count = 0;
            foreach(string s in input)
            {
                if (s.Contains("-"))
                {
                    string[] holder = s.Split('-');
                    int a = int.Parse(holder[0]);
                    int b = int.Parse(holder[1]);
                    for(int i = a; i <= b; i++)
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
