using System.Collections.ObjectModel;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICollection<Shape> shapes = new Collection<Shape>();

            shapes.Add(new CircleLiskov(10));
            shapes.Add(new SquareLiskov(4));
            // shapes.Add(new LineNotLiskov());
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Area: {0}", shape.GetArea());
            }
        }
    }
}