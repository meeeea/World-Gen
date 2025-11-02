using System.Drawing;
using System.Drawing.Printing;

class Saver
{
    public static bool PointHashMapToImage<T>(HashMap<T> hashMap) where T : IConvertible, new()
    {
        try
        {
                                                                                #pragma warning disable CA1416 // Validate platform compatibility
            Bitmap output = new Bitmap(hashMap.Width, hashMap.Height);
                                                                                #pragma warning restore CA1416 // Validate platform compatibility

            for (int i = 0; i < 160; i++)
            {
                for (int k = 0; k < 90; k++)
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




}