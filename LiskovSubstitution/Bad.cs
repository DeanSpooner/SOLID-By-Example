namespace LiskovSubstitution.Bad
{
    // The LSP states that the design must provide the ability to replace any instance of a parent class with an instance of one of its child classes.
    // If a parent class can do something, a child class must also be able to do it.
    // In the example below a rectangle cannot calculate the area correctly as it inherits from a square, a rectangle is not a square.
    // A rectangle requires two parameters to calculate the area whereas a square requires only one.
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

    public class Square : Rectangle
    {
        public Square(double s) : base(s, s)
        {
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
