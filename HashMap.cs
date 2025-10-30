using System.Reflection.Metadata.Ecma335;

class HashMap
{
    private List<List<Point>> hashmap = new();

    private int scaleX;
    public int Width => scaleX;
    private int scaleY;
    public int Height => scaleY;
    public HashMap(int width = 160, int height = 90)
    {
        scaleX = Width;
        scaleY = Height;
        for (int i = 0; i < width; i++)
        {
            hashmap.Add(new List<Point>());
            for (int k = 0; k < height; k++)
            {
                hashmap[i].Add(new Point());
            }
        }
    }

    public Point GetPoint(int x, int y)
    {
        return hashmap[x][y];
    }
}