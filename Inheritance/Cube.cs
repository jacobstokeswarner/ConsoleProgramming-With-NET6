// See https://aka.ms/new-console-template for more information
class Cube : Shape, IShape
{
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }
    public Cube(double width, double length, double height)
    {
        Width = width;
        Length = length;
        Height = height;
    }
}
