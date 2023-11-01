using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Helper
{
    internal class ImageProcessing
    {
        public static Bitmap RotateImage(Image img, float rotationAngle)
        {
            try
            {
                //create an empty Bitmap image
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                //turn the Bitmap into a Graphics object
                Graphics gfx = Graphics.FromImage(bmp);

                //now we set the rotation point to the center of our image
                gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

                //now rotate the image
                gfx.RotateTransform(rotationAngle);

                gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

                //set the InterpolationMode to HighQualityBicubic so to ensure a high
                //quality image once it is transformed to the specified size
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gfx.Clear(Color.White);
                //now draw our new image onto the graphics object
                gfx.DrawImage(img, new Point(0, 0));

                //bmp.Save("result.jpg", ImageFormat.Jpeg);

                //dispose of our Graphics object
                gfx.Dispose();

                //return the image
                return bmp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static Image putOverLayerOnImage(Bitmap img)
        {
            try
            {
                using (Graphics g = Graphics.FromImage(img))
                {
                    //g.DrawImage(originalBmp, 0, 0);
                    Color customColor = Color.FromArgb(100, Color.SkyBlue);
                    SolidBrush shadowBrush = new SolidBrush(customColor);
                    g.FillRectangles(shadowBrush, new RectangleF[] { new RectangleF(0, img.Height - 120, img.Width, img.Height - 120) });
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, new Point(0, 0));
                }

                return img;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
