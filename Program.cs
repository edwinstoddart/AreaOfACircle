using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double circum;
            double diameter;

            Console.WriteLine("Enter the radius of a circle: ");
            string userInput = Console.ReadLine();
            radius = double.Parse(userInput);

            area = Math.PI * Math.Pow(radius, 2);
            circum = 2 * Math.PI * radius;
            diameter = 2 * radius;

            Console.WriteLine($"The area of a circle of radius {radius} is: {area} \n" +
                $"The circumference of a circle of radius {radius} is: {circum} \n" +
                $"The diameter of a circle of radius {radius} is: {diameter}");

            Console.WriteLine("What is the MPG of your car: ");
            userInput = Console.ReadLine();


        }
    }
}
