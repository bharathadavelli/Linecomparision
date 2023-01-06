namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            double x1, x2, x3, x4, y1, y2, y3, y4, length1, length2;
            Console.WriteLine("Enter Coordinate of first Point of first line x1 & y1 in cm :");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinate of second Point of first line x2 & y2 in cm :");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinate of first Point of second line x3 & y3 in cm :");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinate of second Point of second line x4 & y4 in cm :");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of first Line is : " + length1 + " cm");
            Console.WriteLine("Length of second Line is : " + length2 + " cm");
                int status = length1.CompareTo(length2);
            if (status > 0)
            {
                Console.WriteLine("Length of both the lines are equal ");
                Console.WriteLine("First Length is Greater than Second ");
            }
            else if (status < 0)
            {
                Console.WriteLine("Second Length is Greater than First");
            }
            else
            {
                Console.WriteLine("Length of both the lines are not equals");
                Console.WriteLine("Both Lines Length is Equal");
            }
        }
    }
}