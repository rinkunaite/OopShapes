namespace OopShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Squares square1 = new Squares(5);
            Shape square2 = new Squares(2);
            Circle circle1 = new Circle(15);
            triangle triangle1 = new triangle(3, 6);

            Console.WriteLine($"Area of the square: {square1.GetArea()}");
            Console.WriteLine($"Area of the square: {square2.GetArea()}");
            Console.WriteLine($"Area of the circle: {circle1.GetArea()}");
            Console.WriteLine($"Area of the triangle: {triangle1.GetArea()}");
        }
    }
}
