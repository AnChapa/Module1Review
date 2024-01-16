namespace Module1Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What shape do you want?\nChoose either a Circle, Triangle, Rectangle, or Square:");
            var shape = Console.ReadLine().ToLower();
            switch (shape)
            {
                case "circle":
                    Console.WriteLine("\nWhat is the radius:");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nThe area of a circle with {radius} radius is: {CircleArea(radius)}");
                    break;
                case "triangle":
                    Console.WriteLine("\nWhat is the length of the base for the triangle:");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n What is the height of the triangle:");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nThe area of a triangle with a {baseLength} base and {height} height is: {TriangleArea(baseLength, height)}");
                    break;
                case "rectangle":
                    Console.WriteLine("\nWhat is the length of the rectangle:");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nWhat is the width of the rectangle:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nThe area of a rectangle with a length of {length} and width {width} is: {RectangleArea(length, width)}");
                    break;
                case "square":
                    Console.WriteLine("\nWhat is the length of the sides for the square:");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nThe area of a square with sides of lenght {side} is: {SquareArea(side)}");
                    break;
                default:
                    Console.WriteLine($"\n{shape} is not a valid shape.");
                    break;
            }

        }

        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double TriangleArea(double baseLength, double height)
        {
            return (baseLength * height)/2;
        }
        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
    }
}
