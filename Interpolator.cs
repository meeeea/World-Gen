using System.Security.Cryptography.X509Certificates;

class Interpolator
{

    public static Point LinearPoint(HashMap<Point> hashMap, double x, double y)
    //this function is done and does not need any further editing. if you want to change something look at something else.
    {
        int nx = Math.Max((int)Math.Floor(x), 0);
        int px = Math.Min((int)Math.Ceiling(x), hashMap.Width - 1);
        int ny = Math.Max((int)Math.Floor(y), 0);
        int py = Math.Min((int)Math.Ceiling(y), hashMap.Height - 1);

        double nxd = x % 1;
        double pxd = 1 - x % 1;
        double nyd = y % 1;
        double pyd = 1 - y % 1;


        double nxnyH = (double)hashMap.GetPoint(nx, ny);
        double nxpyH = (double)hashMap.GetPoint(nx, py);
        double pxnyH = (double)hashMap.GetPoint(px, ny);
        double pxpyH = (double)hashMap.GetPoint(px, py);

        double nxH = nxnyH * pyd + nxpyH * nyd;
        double pxH = pxnyH * pyd + pxpyH * nyd;

        double pointValue = nxH * pxd + pxH * nxd;

        return new(Math.Max(Math.Min(pointValue, 1), 0));
    }

    public static Point SmootherStep(HashMap<Point> hashMap, double x, double y, bool printColory = false)
    {
        double calculate(double nxd, double LH, double RH) => (6 * Math.Pow(nxd, 5) - 15 * Math.Pow(nxd, 4) + 10 * Math.Pow(nxd, 3)) * (RH - LH) + LH;

        int nx = Math.Max((int)Math.Floor(x), 0);
        int px = Math.Min((int)Math.Ceiling(x), hashMap.Width - 1);
        int ny = Math.Max((int)Math.Floor(y), 0);
        int py = Math.Min((int)Math.Ceiling(y), hashMap.Height - 1);

        double nxd = x % 1;
        double nyd = y % 1;

        double nxnyH = (double)hashMap.GetPoint(nx, ny);
        double nxpyH = (double)hashMap.GetPoint(nx, py);
        double pxnyH = (double)hashMap.GetPoint(px, ny);
        double pxpyH = (double)hashMap.GetPoint(px, py);


        if (nxd < 0 || nxd > 1) { Console.WriteLine(nxd); }
        if (nyd < 0 || nyd > 1) { Console.WriteLine(nyd); }

        if (nxnyH < 0 || nxnyH > 1) { Console.WriteLine(nxnyH); }
        if (nxpyH < 0 || nxpyH > 1) { Console.WriteLine(nxpyH); }
        if (pxnyH < 0 || pxnyH > 1) { Console.WriteLine(pxnyH); }
        if (pxpyH < 0 || pxpyH > 1) { Console.WriteLine(pxpyH); }



        double newNY = calculate(nxd, nxnyH, pxnyH);

        double newPY = calculate(nxd, nxpyH, pxpyH);
        if (newPY < 0 || newPY > 1) { Console.WriteLine($"b: {newPY}"); }
        if (newNY < 0 || newNY > 1) { Console.WriteLine($"c: {newNY}"); }


        double smoothPoint = calculate(nyd, newNY, newPY);

        if (smoothPoint < 0 || smoothPoint > 1) { Console.WriteLine($"s: {smoothPoint}"); }

        if (printColory)
        {
            return new(smoothPoint, nxd, nyd);

        }
        return new(smoothPoint);
    }
    
    public static Point BicubicPoint(HashMap<Point> hashMap, double x, double y)
    {
        


        return new();
    }

    class BadInput : Exception
    {
        public BadInput(string Message) : base(Message) { }
    }
}

