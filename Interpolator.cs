using System.Security.Cryptography.X509Certificates;

class Interpolator
{

    public static Point LinearPoint(HashMap<Point> hashMap, double x, double y)
    {
        int nx = Math.Max((int)Math.Floor(x), 0);
        int px = Math.Min((int)Math.Ceiling(x), hashMap.Width - 1);
        int ny = Math.Max((int)Math.Floor(y), 0);
        int py = Math.Min((int)Math.Ceiling(y), hashMap.Height - 1);

        double nxd = x % 1;
        double pxd = 1- x % 1;
        double nyd = x % 1;
        double pyd = 1- x % 1;


        double nxnyH = (double) hashMap.GetPoint(nx, ny);
        double nxpyH = (double) hashMap.GetPoint(nx, py);
        double pxnyH = (double) hashMap.GetPoint(px, ny);
        double pxpyH = (double) hashMap.GetPoint(px, py);

        double nxH = nxnyH * nyd + nxpyH * pyd;
        double pxH = pxnyH * nyd + pxpyH * pyd;

        double pointValue = nxH * nxd + pxH * pxd;

        Console.WriteLine($"start point {x}, {y}");
        Console.WriteLine($"{nx}, {ny}, {nxnyH}, {nxd}, {nyd}");
        Console.WriteLine($"{px}, {ny}, {pxnyH}, {pxd}, {nyd}");
        Console.WriteLine($"{nx}, {py}, {nxpyH}, {nxd}, {pyd}");
        Console.WriteLine($"{px}, {py}, {pxpyH}, {pxd}, {pyd}\n");

        return new(Math.Max(Math.Min(pointValue, 1), 0));
    }

    public static Point BicubicPoint(HashMap<Point> hashMap, double x, double y)
    {
        double getValue1d(List<Point> p, double x)
        {
            return p[1] + 0.5 * x * (p[2] - p[0] + x * (2.0 * p[0] - 5 * p[1] + 4 * p[2] - p[3] + x * (3 * p[1] - p[2] - p[0])));
        }
        double getValue2d(List<List<Point>>? p, double x, double y)
        {
            if (p is null)
            {
                return 0;
            }

            List<Point> points =
            [
                new(getValue1d(p[0], y)),
                new(getValue1d(p[1], y)),
                new(getValue1d(p[2], y)),
                new(getValue1d(p[3], y)),
            ];
            return getValue1d(points, x);
        }


        List<List<Point>>? values = hashMap.GetBufferArea(x, y, 2);

        return new(getValue2d(values, x, y));
    }

}