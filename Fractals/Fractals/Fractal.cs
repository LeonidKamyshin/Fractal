using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Basic class to draw fractals.
    /// </summary>
    public class Fractal
    {
        // Fractals colored with linear gradient.

        /// <summary>
        /// Start gradient color.
        /// </summary>
        protected Color StartColor { get; set; }

        /// <summary>
        /// End gradient color.
        /// </summary>
        protected Color EndColor { get; set; }

        /// <summary>
        /// Control where to draw.
        /// </summary>
        protected PictureBox Picture { get; set; }

        /// <summary>
        /// An arrray with all gradient colors.
        /// </summary>
        protected Color[] Gradient { get; set; }


        public Fractal(Color startColor, Color endColor, PictureBox picture)
        {
            StartColor = startColor;
            EndColor = endColor;
            Picture = picture;
        }

        /// <summary>
        /// Creating gradient certain length.
        /// </summary>
        /// <param name="length">Gradient length.</param>
        protected void SetGradient(int length)
        {
            Gradient = new Color[length + 1];
            Gradient[1] = EndColor;
            Gradient[length] = StartColor;
            int dr = (StartColor.R - EndColor.R) / length;
            int dg = (StartColor.G - EndColor.G) / length;
            int db = (StartColor.B - EndColor.B) / length;
            for (int i = 2; i < length; i++)
            {
                Gradient[i] = Gradient[i - 1];
                int r = Gradient[i - 1].R + dr;
                int g = Gradient[i - 1].G + dg;
                int b = Gradient[i - 1].B + db;
                Gradient[i] = Color.FromArgb(255, r, g, b);
            }
        }

        /// <summary>
        /// Drawing fractal function.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        public virtual void DrawFractal(int x, int y, int depth, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 45, 45, 45)), 0, 0, bmp.Width, bmp.Height);
        }
    }
}
