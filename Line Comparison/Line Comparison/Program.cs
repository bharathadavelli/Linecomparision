﻿namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");

            double x1, x2, y1, y2, length;
            Console.WriteLine("Enter Coordinate of first Point x1 & y1 in cm :");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Coordinate of second Point x2 & y2 in cm :");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Lenght of a Line is : " + length + " cm");
        }
    }
}