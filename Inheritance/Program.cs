internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Length: ");
        double length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Enter Width: ");
        double width = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Enter Height: ");
        double height = int.Parse(Console.ReadLine());
        Console.WriteLine();

        var cube = new Cube(width, length, height); // using the constructor

        var triangle = new Triangle() { Height = height, Length = length, Hypotenuse = 10 }; // using default constructor, and assigning values
        var triangle2 = new Triangle(); // using default constructor without assigning values
        var triangle3 = new Triangle(10); // using constructor with only the hypotenuse parameter

        var rectangle = new Rectangle() { Width = width, Length = length, Height = height };



        Console.WriteLine($"Cube Area is: {cube.GetArea()}");
        Console.WriteLine($"Cube Volume is: {cube.GetVolume()}");

        Console.WriteLine($"Triangle Area is: {triangle.GetArea()}");

        Console.WriteLine($"Rectangle Area is: {rectangle.GetArea()}");
    }
}