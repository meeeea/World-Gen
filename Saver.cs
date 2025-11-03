using System.Drawing;
using System.Drawing.Printing;

class Saver
{
    public static bool DrawHashmap<T>(HashMap<T> hashMap, string fileName = "output") where T : IConvertible, new()
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
            output.Save($"./Outputs/{fileName}.png", System.Drawing.Imaging.ImageFormat.Png);
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

    public static bool LinearInterpolationHashMap(HashMap<Point> hashMap, int scaleX, int scaleY, string fileName = "output")
    {
        //try
        //{
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            Bitmap output = new Bitmap(scaleX, scaleY);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
            int width = hashMap.Width - 1;
            int heigth = hashMap.Height - 1;

            for (int i = 0; i < scaleX; i++)
            {
                for (int k = 0; k < scaleY; k++)
                {
                    Color hue = (Color)Interpolator.LinearPoint(hashMap, i * (double)width / (double)scaleX,
                                                                         k * (double)heigth / (double)scaleY);
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
                    output.SetPixel(i, k, hue);
                                                                                #pragma warning restore CA1416 // Validate platform compatibilit
                }
            }

                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            output.Save($"./Outputs/{fileName}.png", System.Drawing.Imaging.ImageFormat.Png);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility
        //}
        //catch (Exception E)
        //{
        //    Console.WriteLine(E.Source);
        //    Console.WriteLine(E.Message);
        //    Console.WriteLine("failed");
        //    return false;
        //}

        Console.WriteLine("passed");
        return true;
    }


}