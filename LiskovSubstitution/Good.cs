using System;

namespace LiskovSubstitution
{
    // The LSP states that the design must provide the ability to replace any instance of a parent class with an instance of one of its child classes.
    // If a parent class can do something, a child class must also be able to do it.
    // A square is not a rectangle, it is a shape. This is a better design in which the square can use the same functionality as it's parent, the shape class.
    public abstract class Shape
    {
        protected double area;
        public abstract double getArea();
    }

    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        public Rectangle(double l, double w)
        {
            _length = l;
            _width = w;
        }

        public override double getArea()
        {
            var area = _length * _width;

            return area;
        }
    }

    public class Square : Shape
    {
        private double _side;
        public Square(double s)
        {
            _side = s;
        }

        public override double getArea()
        {
            var area = _side * _side;

            return area;
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
