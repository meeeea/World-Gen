using System.Drawing;
using System.Drawing.Printing;

class Saver
{
    public static bool DrawHashmap<T>(HashMap<T> hashMap) where T : IConvertible, new()
    {
        try
        {
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            Bitmap output = new Bitmap(hashMap.Width, hashMap.Height);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility

            for (int i = 0; i < hashMap.Width; i++)
            {
                for (int k = 0; k < hashMap.Height; k++)
                {
                    Color hue = (Color) Convert.ChangeType(hashMap.GetPoint(i, k), typeof(Color));
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
                    output.SetPixel(i, k, hue);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
                }
            }

                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            output.Save("./Outputs/ouput.png", System.Drawing.Imaging.ImageFormat.Png);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
        }
        catch (Exception E)
        {
            Console.WriteLine(E.Source);
            Console.WriteLine(E.Message);
            Console.WriteLine("failed");
            return false;
        }

        Console.WriteLine("Passed");
        return true;
    }

    public static bool LinearInterpolationHashMap(HashMap<Point> hashMap, int scaleX, int scaleY)
    {
        try
        {
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            Bitmap output = new Bitmap(scaleX, scaleY);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility

            for (int i = 0; i < scaleX; i++)
            {
                for (int k = 0; k < scaleY; k++)
                {
                    Color hue = (Color)Interpolator.LinearPoint(hashMap, i * hashMap.Width / scaleX, k * hashMap.Height / scaleY);
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
                    output.SetPixel(i, k, hue);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
                }
            }

                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            output.Save("./Outputs/ouput.png", System.Drawing.Imaging.ImageFormat.Png);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
        }
        catch (Exception E)
        {
            Console.WriteLine(E.Source);
            Console.WriteLine(E.Message);
            Console.WriteLine("failed");
            return false;
        }

        Console.WriteLine("passed");
        return true;
    }


}