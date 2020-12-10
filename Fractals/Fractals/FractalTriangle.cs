using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Drawing fractal triangle class.
    /// </summary>
    class FractalTriangle : Fractal
    {
        /// <summary>
        /// Starting length of element.
        /// </summary>
        private static readonly int length = 1000;

        /// <summary>
        /// Maximum recursion depth.
        /// </summary>
        public static int maxDepth = 8;

        /// <summary>
        /// Creates fractal triangle instance.
        /// </summary>
        /// <param name="startColor">Starting gradient color.</param>
        /// <param name="endColor">Ending gradient color.</param>
        /// <param name="picture">Control where to draw.</param>
        public FractalTriangle(Color startColor, Color endColor, PictureBox picture)
            : base(startColor, endColor, picture) { }

        /// <summary>
        /// Recursive function drawing fractal.
        /// </summary>
        /// <param name="arr">Traignle coords.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        void Rec(Point[] arr, int depth, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (depth == 1)
            {
                Picture.Image = bmp;
                return;
            }
            Point[] a0 = new Point[3];
            Point[] a1 = new Point[3];
            Point[] a2 = new Point[3];
            a0[0] = arr[0];
            a0[1] = new Point((arr[0].X + arr[1].X) / 2, (arr[0].Y + arr[1].Y) / 2);
            a0[2] = new Point((arr[0].X + arr[2].X) / 2, (arr[0].Y + arr[2].Y) / 2);
            a1[2] = new Point((arr[1].X + arr[2].X) / 2, (arr[1].Y + arr[2].Y) / 2);
            a1[1] = arr[1];
            a2[2] = arr[2];
            a1[0] = a0[1];
            a2[0] = a0[2];
            a2[1] = a1[2];
            Rec(a0, depth - 1, bmp);
            Rec(a1, depth - 1, bmp);
            Rec(a2, depth - 1, bmp);
            g.DrawLine(new Pen(Gradient[depth - 1], 3), a0[1], a0[2]);
            g.DrawLine(new Pen(Gradient[depth - 1], 3), a1[2], a0[2]);
            g.DrawLine(new Pen(Gradient[depth - 1], 3), a1[2], a0[1]);
        }

        /// <summary>
        /// Drawing fractal triangle.
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
            Point[] arr = new Point[3];
            arr[0] = new Point(x, y);
            arr[1].X = x + length / 2;
            arr[1].Y = y - (int)(length * Math.Sqrt(3) / 2);
            arr[2].X = x + length;
            arr[2].Y = y;
            Rec(arr, depth, bmp);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Gradient[depth], 3), arr[0], arr[1]);
            g.DrawLine(new Pen(Gradient[depth], 3), arr[1], arr[2]);
            g.DrawLine(new Pen(Gradient[depth], 3), arr[0], arr[2]);
        }
    }
}
