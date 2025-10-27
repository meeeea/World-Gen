using System.Security.Cryptography.X509Certificates;

class Vec2
{
    private double X;
    private double Y;
    public double x => X;
    public double y => Y;


    public Vec2 ()
    {
        X = Rand.Random();
        Y = Rand.Random();
    }

    public Vec2(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({Math.Round(x, 5)}, {Math.Round(y, 5)})";
    }   
}