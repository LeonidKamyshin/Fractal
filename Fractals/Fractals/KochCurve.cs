using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Drawing Koch curve class.
    /// </summary>
    public class KochCurve : Fractal
    {
        /// <summary>
        /// Starting length of element.
        /// </summary>
        private static readonly int length = 1500;

        /// <summary>
        /// Maximum recursion depth.
        /// </summary>
        public static readonly int maxDepth = 8;

        /// <summary>
        /// Creates Koch curve instance.
        /// </summary>
        /// <param name="startColor">Starting gradient color.</param>
        /// <param name="endColor">Ending gradient color.</param>
        /// <param name="picture">Control where to draw.</param>
        public KochCurve(Color startColor, Color endColor, PictureBox picture)
            : base(startColor, endColor, picture) { }

        /// <summary>
        /// Recursive function drawing fractal.
        /// </summary>
        /// <param name="x1">Segment left X-coord.</param>
        /// <param name="y1">Segment left Y-coord.</param>
        /// <param name="x2">Segment right X-coord.</param>
        /// <param name="y2">Segment right Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="length">Segment length.</param>
        /// <param name="angle">Segment angle.</param>
        /// <param name="colorStage">Gradient color id.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        void Rec(int x1, int y1, int x2, int y2, int depth,
            int length, int angle, int colorStage, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (depth == 1)
            {
                g.DrawLine(new Pen(Gradient[colorStage]), x1, y1, x2, y2);
                Picture.Image = bmp;
                return;
            }
            length /= 3;
            // Order clockwise: x1,x3,x4,x5,x2
            int x3 = x1 + (x2 - x1) / 3;
            int y3 = y1 + (y2 - y1) / 3;
            int x4 = x3 + (int)(length * Math.Cos(angle * Math.PI * 2 / 360));
            int y4 = y3 + (int)(length * Math.Sin(angle * Math.PI * 2 / 360));
            int x5 = x1 + (x2 - x1) * 2 / 3;
            int y5 = y1 + (y2 - y1) * 2 / 3;
            Rec(x1, y1, x3, y3, depth - 1, length, angle, colorStage, bmp);
            Rec(x3, y3, x4, y4, depth - 1, length, angle - 60, colorStage - 1, bmp);
            Rec(x4, y4, x5, y5, depth - 1, length, angle + 60, colorStage - 1, bmp);
            Rec(x5, y5, x2, y2, depth - 1, length, angle, colorStage, bmp);
        }

        /// <summary>
        /// Drawing Koch curve fractal.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        public override void DrawFractal(int x, int y, int depth, Bitmap bmp)
        {
            base.DrawFractal(x, y, depth, bmp);
            depth = Math.Min(maxDepth, depth);
            SetGradient(depth);
            int x1 = x - length / 2;
            int y1 = y;
            int x2 = x + length / 2;
            int y2 = y;
            Rec(x1, y1, x2, y2, depth, length, -60, depth, bmp);
        }
    }
}
