using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace BitCronch
{
    public class Cruncher
    {
        public static Bitmap Crunch(string Filename)
        {
            BitArray bits = new BitArray(File.ReadAllBytes(Filename));
            int imgWidthHeight = (int) Math.Ceiling(Math.Sqrt(bits.Count));
            Bitmap img = new Bitmap(imgWidthHeight, imgWidthHeight);
            int i = 0;
            for (int y = 0; y < imgWidthHeight; y++)
            {
                for (int x = 0; x < imgWidthHeight; x++)
                {
                    if (!(i >= bits.Count))
                    {
                        if (bits[i])
                        {
                            img.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            img.SetPixel(x, y, Color.Black);
                        }
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                    i++;
                }
            }
            return img;
        }
    }
}