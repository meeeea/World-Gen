class Point
{
    public int value;

    public Point()
    {
        value = Rand.Random(0, 255);
    }

    public override string ToString()
    {
        return $"{value}";
    }
}