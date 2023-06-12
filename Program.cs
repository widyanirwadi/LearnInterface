namespace LearnInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle (4, 6);

            // Menggunakan polimorfisme untuk memanggil metode CalculateArea() dan Display()
            double circleArea = circle.CalculateArea();
            double rectangleArea = rectangle.CalculateArea();

            circle.Display();
            rectangle.Display();

            Console.WriteLine("Circle Area: " + circleArea);
            Console.WriteLine("Rectangle Area: " + rectangleArea);
        }
    }
}