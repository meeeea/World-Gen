using System.Drawing;
using System.Drawing.Printing;

class Saver
{
    public static bool PointHashMapToImage<T>(HashMap<T> hashMap) where T : IConvertible, new()
    {
        try
        {
            Bitmap output = new Bitmap(hashMap.Width, hashMap.Height);

            for (int i = 0; i < 160; i++)
            {
                for (int k = 0; k < 90; k++)
                {
                    Color hue = (Color) Convert.ChangeType(hashMap.GetPoint(i, k), typeof(Color));
                    output.SetPixel(i, k, hue);
                }
            }

            output.Save("./Outputs/ouput.png", System.Drawing.Imaging.ImageFormat.Png);
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