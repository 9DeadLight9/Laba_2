namespace Task_1;

class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
internal class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter first side -");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second side -");
        double side2 = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(side1, side2);
        double Area = rectangle.Area;
        double Perimeter = rectangle.Perimeter;
        Console.WriteLine($"Area of your rectangle is {Area}");
        Console.WriteLine($"Perimeter of your rectangle is {Perimeter}");
    }
}
