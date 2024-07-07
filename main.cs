using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the wind speed (in miles per hour):");

        if (!double.TryParse(Console.ReadLine(), out double windSpeed))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        if (windSpeed >= 157)
        {
            Console.WriteLine("Hurricane Category: 5");
        }
        else if (windSpeed >= 130)
        {
            Console.WriteLine("Hurricane Category: 4");
        }
        else if (windSpeed >= 111)
        {
            Console.WriteLine("Hurricane Category: 3");
        }
        else if (windSpeed >= 96)
        {
            Console.WriteLine("Hurricane Category: 2");
        }
        else if (windSpeed >= 74)
        {
            Console.WriteLine("Hurricane Category: 1");
        }
        else
        {
            Console.WriteLine("This is not a hurricane.");
        }
    }
}