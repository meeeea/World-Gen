using System.Drawing;
using System.Drawing.Printing;

class Saver
{
    public static bool PointHashMapToImage(HashMap hashMap)
    {
//        try
//        {
            Bitmap output = new Bitmap(5, 5);

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    int hue = hashMap.GetPoint(i, k).value;
                    output.SetPixel(i, k, Color.FromArgb(hue, hue, hue));
                }
            }

            output.Save("./Outputs/", System.Drawing.Imaging.ImageFormat.Png);
//        }
//        catch (Exception E)
//        {
//            Console.WriteLine(E.Source);
//            Console.WriteLine(E.Message);
//            Console.WriteLine("failed");
//            return false;
//        }

        Console.WriteLine("Passed");
        return true;
    }




}