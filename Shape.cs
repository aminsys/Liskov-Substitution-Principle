namespace Liskov_Substitution_Principle
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class CircleLiskov : Shape
    {
        private readonly double _radius;

        public CircleLiskov(double radius) => _radius = radius;
        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }

    public class SquareLiskov : Shape
    {
        private readonly double _width;

        public SquareLiskov(double width) => _width = width;

        public override double GetArea() => Math.Pow(_width, 2);
    }

    public class LineNotLiskov : Shape
    {
        // It is not possible to get the area of a line. This doesn't support the Liskov substitution principle.
        public override double GetArea() => throw new NotImplementedException();
    }
}