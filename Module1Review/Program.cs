namespace Module1Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Hello, World!");
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
