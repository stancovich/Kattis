using System;

namespace everywhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTrips = stringToInt();
            for(int i = 0; i < numberOfTrips; i++)
            {
                int numberOfCities = 0;
                string[] cities = new string [stringToInt()];
                for(int j = 0; j < cities.Length; j++)
                {
                    cities[j] = Console.ReadLine();
                    numberOfCities++;
                }

                for(int j = 0; j < cities.Length-1; j++)
                {
                    bool foundSame = false;
                    for(int k = cities.Length - 1; k > j; k--)
                    {
                        if(cities[j] == cities[k])
                        {
                                foundSame = true;
                        }
                    }
                    if (foundSame)
                    {
                        numberOfCities--;
                    }
                }
                Console.WriteLine(numberOfCities);
            }

            //Console.WriteLine(cities.Length);
        }
        static int stringToInt()
        {
            int.TryParse(Console.ReadLine(), out int output);
            return output;
        }
    }
}
