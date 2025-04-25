using System;

namespace OOPPortfolioWeb.Models
{

    public class ShapeInputModel
    {
        public string ShapeType { get; set; }
        public string Color { get; set; }
        public double? Radius { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? BaseLength { get; set; }
    }

    // Abstract base class
    public abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        // Abstract method to calculate area
        public abstract double CalculateArea();
    }

    // Circle subclass
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle subclass
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Triangle subclass
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(string color, double baseLength, double height) : base(color)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }
}
