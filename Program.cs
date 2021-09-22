using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            double Radius;
            double Area;
            double Circum;
            double Diameter;

            do
            {
                Console.WriteLine("Enter the radius of a circle: ");
                UserInput = Console.ReadLine();
                if (!Double.TryParse(UserInput, out Radius))
                {
                    Console.WriteLine("Error: Entered a Non-numerical string!!");
                    Environment.Exit(0);
                }
            } while (Double.Parse(UserInput) < 0 || UserInput.Equals(""));

                Radius = Double.Parse(UserInput);
            Area = Circle.Area(Radius);
            Circum = Circle.Circumference(Radius);
            Diameter = Circle.Diameter(Radius);

            Console.WriteLine($"The area of a circle of radius {Radius} is: {Area} \n" +
                $"The circumference of a circle of radius {Radius} is: {Circum} \n" +
                $"The diameter of a circle of radius {Radius} is: {Diameter}");

            Console.WriteLine("What is the MPG of your car: ");
            UserInput = Console.ReadLine();
            double MPG = Double.Parse(UserInput);

            double GallonsUsed = Circle.GallonsUsed(Circum, MPG);
            Console.WriteLine($"It would take you {GallonsUsed} gallons of gas to drive around this circle.");
        }
    }
}
