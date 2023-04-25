// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public double Hypotenuse { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }

    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
        Hypotenuse = hyp;
    }

    public Triangle(int length, int height, int hyp)
    {
        Length = length;
        Height = height;
        Hypotenuse = hyp;
    }


}