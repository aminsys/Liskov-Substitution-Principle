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
            shapes.Add(new LineLiskov(103));
            foreach (TwoDimensionalShape shape in shapes.Where(x => x is TwoDimensionalShape))
            {
                Console.WriteLine("Area of {0}: {1}", shape.Type, shape.GetArea());
            }
            
            foreach (OneDimensionalShape shape in shapes.Where(x => x is OneDimensionalShape))
            {
                Console.WriteLine("Length of {0}: {1}", shape.Type, shape.GetLength());
            }
        }
    }
}