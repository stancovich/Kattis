using System;

namespace triarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal triangleArea = CalculateTriangleArea(input);
            Console.WriteLine(triangleArea);

        }
        static decimal CalculateTriangleArea(string input)
        {
            string[] inputArray = input.Split(" ");
            decimal.TryParse(inputArray[0], out decimal h);
            decimal.TryParse(inputArray[1], out decimal b);
            decimal triangleArea = (h * b) / 2;
            return triangleArea;
        }
    }
}
