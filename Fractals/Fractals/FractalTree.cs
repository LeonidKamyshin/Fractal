using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Drawing fractal tree class.
    /// </summary>
    public class FractalTree : Fractal
    {
        /// <summary>
        /// Starting length of element.
        /// </summary>
        public static readonly int maxDepth = 15;


        /// <summary>
        /// Maximum recursion depth.
        /// </summary>
        private static readonly int length = 200;

        /// <summary>
        /// Angle between vertical line and left branch.
        /// </summary>
        int LeftDegree { get; set; }

        /// <summary>
        /// Angle between vertical line and rigth branch.
        /// </summary>
        int RightDegree { get; set; }

        /// <summary>
        /// Similarity coefficient.
        /// </summary>
        double Proportion { get; set; }

        /// <summary>
        /// Creates fractal tree instance.
        /// </summary>
        /// <param name="startColor">Starting gradient color.</param>
        /// <param name="endColor">Ending gradient color.</param>
        /// <param name="proportion">Similarity coefficient.</param>
        /// <param name="leftDegree"> Angle between vertical line and left branch.</param>
        /// <param name="rightDegree">Angle between vertical line and rigth branch.</param>
        /// <param name="picture">Control where to draw.</param>
        public FractalTree(Color startColor, Color endColor, double proportion,
            int leftDegree, int rightDegree, PictureBox picture)
            : base(startColor, endColor, picture)
        {
            LeftDegree = leftDegree;
            RightDegree = rightDegree;
            Proportion = proportion;
        }

        /// <summary>
        /// Recursive function drawing fractal.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="angle">Angle of current segment.</param>
        /// <param name="length">Length of current segment.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        void Rec(int x, int y, int depth, int angle, double length, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (depth == 0)
            {
                return;
            }
            int x1 = x + (int)(length * Math.Cos(angle * Math.PI * 2 / 360));
            int y1 = y + (int)(length * Math.Sin(angle * Math.PI * 2 / 360));
            Rec(x1, y1, depth - 1, angle - LeftDegree, length / Proportion, bmp);
            Rec(x1, y1, depth - 1, angle + RightDegree, length / Proportion, bmp);
            g.DrawLine(new Pen(Gradient[depth], (int)length / 10), x, y, x1, y1);
        }

        /// <summary>
        /// Drawing fractal tree.
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
            Rec(x, y, depth, -90, length, bmp);
            Picture.Image = bmp;
        }
    }
}
