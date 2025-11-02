class Interpolator
{

    public static Point LinearPoint(HashMap<Point> hashMap, double x, double y)
    {
        int nx = (int)Math.Floor(x);
        int px = (int)Math.Ceiling(x);
        int ny = (int)Math.Floor(y);
        int py = (int)Math.Ceiling(y);

        float nxnyHeight = (float) hashMap.GetPoint(nx, ny);
        float nxpyHeight = (float) hashMap.GetPoint(nx, py);
        float pxnyHeight = (float) hashMap.GetPoint(px, ny);
        float pxpyHeight = (float)hashMap.GetPoint(px, py);

        double nxnytopxpyHeight = (nxnyHeight * Vec2.Magnitude(x % 1, y % 1) / 1.4142) + (pxpyHeight * Vec2.Magnitude(x % 1, y % 1) / 1.4142);
        


        return new(nxnytopxpyHeight);
    }



}