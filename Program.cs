using System.Xml.Serialization;

namespace Assignment_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 2.2.1
             * 
             * Write a base class: "shape" and add properties like id, name and color, 
             * and methos like "calculate area".
             * 
             * Create a class called "circle", inherit the base class and add properties like radius.
             * Add an override to calculate area for circle.
             * 
             * Create a class called "square", inherit base class from shape and add change 
             * the calculate area logic. Add property like side of square.
             * 
             * Take the input from user to select circle or square and display the calculated area.
             * No hard coded values!
             */

            string? choice = "default";
            do
            {
                Console.Clear();
                Console.WriteLine("Select circle or square (type your choice):");
                choice = Console.ReadLine().ToLower();

                if (choice == "circle")
                {
                    Circle circle = new Circle(1, "circle", "red");
                    Console.WriteLine($"\nYou have selected a circle.\nThe circle is {circle.Color} and has an ID: {circle.Id}\nWhat is the radius of this circle?");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"\nThis circle has a radius of {circle.Radius} and an area of {circle.CalculateArea(circle.Radius)}");
                    Console.Read();
                }
                else if (choice == "square")
                {
                    Square square = new Square(2, "square", "blue");
                    Console.WriteLine($"\nYou have selected a square.\nThe square is {square.Color} and has an ID: {square.Id}\nWhat is the width of this square?");
                    square.Width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"\nThis square has a width of {square.Width} and an area of {square.CalculateArea(square.Width)}");
                    Console.Read();
                }
            }
            while (choice != "circle" || choice != "square");
        }
    }

    public class Shape
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        public Shape(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public virtual double CalculateArea(double input)
        {
            return 0.0;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int id, string name, string color)
            : base(id, name, color) { }

        // Area = π × r^2
        public override double CalculateArea(double input)
        {
            return Math.PI * Math.Pow(input, 2);
        }
    }

    public class Square : Shape
    {
        public double Width { get; set; }

        public Square(int id, string name, string color)
            : base(id, name, color) { }

        // Area = L x W
        public override double CalculateArea(double input)
        {
            return Math.Pow(input, 2);
        }
    }
}
