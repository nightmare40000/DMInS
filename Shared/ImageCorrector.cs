using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shared
{
    public static class ImageCorrector
    {
        public static Bitmap CorrectBrightness(Bitmap image)
        {
            var newImage = new Bitmap(image);
            int offset = Configuration.FilterCoreSize/2;

            for (var i = offset; i < image.Width - offset; i++)
            {
                for (var j = offset; j < image.Height - offset; j++)
                {
                    IList<Color> pixelsColor = GetPixels(image, i, j);

                    int newR = FindMedian(pixelsColor, ColorType.Red);
                    int newG = FindMedian(pixelsColor, ColorType.Green);
                    int newB = FindMedian(pixelsColor, ColorType.Blue);

                    Color newColor = Color.FromArgb(
                        newR >= 255 ? 255 : newR,
                        newG >= 255 ? 255 : newG,
                        newB >= 255 ? 255 : newB
                        );

                    newImage.SetPixel(i, j, newColor);
                }
            }

            return newImage;
        }

        private static int FindMedian(IEnumerable<Color> pixelsColor, ColorType colorType)
        {
            int medianIndex = Configuration.FilterCoreSize*Configuration.FilterCoreSize/2;

            if (colorType == ColorType.Red)
            {
                var colors = pixelsColor.OrderBy(x => x.R).ToArray();
                return colors[medianIndex].R;
            }

            if (colorType == ColorType.Green)
            {
                var colors = pixelsColor.OrderBy(x => x.G).ToArray();
                return colors[medianIndex].G;
            }

            if (colorType == ColorType.Blue)
            {
                var colors = pixelsColor.OrderBy(x => x.B).ToArray();
                return colors[medianIndex].B;
            }

            return 0;
        }

        private static IList<Color> GetPixels(Bitmap image, int i, int j)
        {
            IList<Color> list = new List<Color>();
            var offset = Configuration.FilterCoreSize/2;

            for (var k = i - offset; k < i + 1 + offset; k++)
            {
                for (var l = j - offset; l < j + offset; l++)
                {
                    list.Add(image.GetPixel(k, l));
                }
            }

            return list;
        }

        public static Bitmap ConvertToBlackAndWhite(Bitmap image, int level)
        {
            var newImage = new Bitmap(image);
            for (var i = 0; i < image.Width; i++)
            {
                for (var j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    var brightness = pixel.R*0.3 + pixel.G*0.59 + pixel.B*0.11;
                    var newColor = brightness > level ? Color.FromArgb(255, 255, 255) : Color.FromArgb(0, 0, 0);
                    
                    newImage.SetPixel(i, j, newColor);
                }
            }

            return newImage;
        }

        public static void Labeling(Bitmap image, int[,] labels)
        {
            var l = 1;
            for (var i = 0; i < image.Width; i++)
            {
                for (var j = 0; j < image.Height; j++)
                {
                    try
                    {
                        Fill(image, labels, i, j, l++);
                    }
                    catch (System.StackOverflowException)
                    {
                        MessageBox.Show("adsgfsgsg");
                    }
                }
            }
        }

        private static void Fill(Bitmap image, int[,] labels, int x, int y, int l)
        {
                if (labels[x, y] != 0 || image.GetPixel(x, y).R != 255)
                {
                    return;
                }

                labels[x, y] = l;

                if (x > 0)
                {
                    Fill(image, labels, x - 1, y, l);
                }

                if (x < image.Width - 1)
                {
                    Fill(image, labels, x + 1, y, l);
                }

                if (y > 0)
                {
                    Fill(image, labels, x, y - 1, l);
                }

                if (y < image.Height - 1)
                {
                    Fill(image, labels, x, y + 1, l);
                }
            
        }

        public static Bitmap SetColorToClusters(Bitmap resultImage, Cluster cluster, Color color)
        {
            var result = new Bitmap(resultImage);
            foreach (var pixel in cluster.Objects.SelectMany(item => item.Pixels))
            {
                result.SetPixel(pixel.X, pixel.Y, color);
            }

            return result;
        }
    }

}

