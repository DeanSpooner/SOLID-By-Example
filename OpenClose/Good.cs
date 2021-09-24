using System;

namespace OpenClose
{
    // The OCP states that you should be able to extend a class's behaviour, without modifying it.
    public abstract class Shape
    {
        public abstract double getArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public override double getArea()
        {
            return Length * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double getArea()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class Area
    {
        private double _area;

        public double calcArea(Shape s)
        {
            _area = s.getArea();
            return _area;
        }
    }
}
