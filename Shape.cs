namespace Liskov_Substitution_Principle
{
    public abstract class Shape
    {
        public abstract string Type { get; }
    }

    public abstract class TwoDimensionalShape : Shape
    {
        public abstract double GetArea();
    }

    public abstract class OneDimensionalShape : Shape
    {
        public abstract double GetLength();
    }


    public class CircleLiskov : TwoDimensionalShape
    {
        private readonly double _radius;

        public override string Type => "Circle";

        public CircleLiskov(double radius) => _radius = radius;

        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }

    public class SquareLiskov : TwoDimensionalShape
    {
        private readonly double _width;

        public override string Type => "Square";

        public SquareLiskov(double width) => _width = width;

        public override double GetArea() => Math.Pow(_width, 2);
    }

    // Class LineLiskov has been modified to adhere to the Liskov Substitution Principle.
    public class LineLiskov : OneDimensionalShape
    {
        public readonly double _length;
        public override string Type => "Line";

        public LineLiskov(double length) => _length = length;

        public override double GetLength() => _length;
    }
}