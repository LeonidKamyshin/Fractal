using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Drawing Cantor set class.
    /// </summary>
    class CantorSet : Fractal
    {
        /// <summary>
        /// Starting length of element.
        /// </summary>
        private static readonly int length = 1000;

        /// <summary>
        /// Maximum recursion depth.
        /// </summary>
        public static int maxDepth = 7;

        /// <summary>
        /// Distance between recursion elements.
        /// </summary>
        int Distance { get; set; }

        /// <summary>
        /// Creates cantor set instance.
        /// </summary>
        /// <param name="startColor">Starting gradient color.</param>
        /// <param name="endColor">Ending gradient color.</param>
        /// <param name="distance">Disance between recursion elements.</param>
        /// <param name="picture">Control where to draw.</param>
        public CantorSet(Color startColor, Color endColor, int distance, PictureBox picture)
            : base(startColor, endColor, picture)
        {
            Distance = distance;
        }

        /// <summary>
        /// Recursive function drawing fractal.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="length">Starting length.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="width">Starting width.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        void Rec(int x, int y, int length, int depth, int width, Bitmap bmp)
        {
            if (depth == 0)
            {
                return;
            }
            Graphics g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Gradient[depth], width), x, y, x + length, y);
            Picture.Image = bmp;
            Rec(x, y + Distance, length / 3, depth - 1, width - 1, bmp);
            Rec(x + length * 2 / 3, y + Distance, length / 3, depth - 1, width - 1, bmp);
        }

        /// <summary>
        /// Drawing Cantor set fractal.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        public override void DrawFractal(int x, int y, int depth, Bitmap bmp)
        {
            base.DrawFractal(x, y, depth, bmp);
            depth = Math.Min(depth, maxDepth);
            SetGradient(depth);
            Rec(x, y, length, depth, 10, bmp);
        }
    }
}
