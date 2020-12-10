using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Drawing fractal carpet class.
    /// </summary>
    public class FractalCarpet : Fractal
    {
        /// <summary>
        /// Starting length of element.
        /// </summary>
        private static readonly int length = 900;

        /// <summary>
        /// Maximum recursion depth.
        /// </summary>
        public static int maxDepth = 6;

        /// <summary>
        /// Creates fractal carpet instance.
        /// </summary>
        /// <param name="startColor">Starting gradient color.</param>
        /// <param name="endColor">Ending gradient color.</param>
        /// <param name="picture">Control where to draw.</param>
        public FractalCarpet(Color startColor, Color endColor, PictureBox picture)
            : base(startColor, endColor, picture) { }

        /// <summary>
        /// Splits a square into a 9 equal squares.
        /// </summary>
        /// <param name="x1">Square left lower point X-coord.</param>
        /// <param name="y1">Square left lower point Y-coord.</param>
        /// <param name="x2">Square right upper point X-coord.</param>
        /// <param name="y2">Square right upper point Y-coord.</param>
        /// <returns>An array with points of splitted squares.</returns>
        Point[,] SplitSquare(int x1, int y1, int x2, int y2)
        {
            int length = (x2 - x1) / 3;
            // arr[i,j] means coords of point if we choose 
            //   0         1         2         3   -> i
            // 0 | ‾ ‾ ‾ ‾ | ‾ ‾ ‾ ‾ | ‾ ‾ ‾ ‾ |
            //   |         |         |         |
            //   |         |         |         |
            // 1 | _ _ _ _ | _ _ _ _ | _ _ _ _ |
            //   |         |         |         |
            //   |         |         |         |
            //   |         |         |         |
            // 2 | _ _ _ _ | _ _ _ _ | _ _ _ _ |
            //   |         |         |         |
            //   |         |         |         |
            //   |         |         |         |
            // 3 | _ _ _ _ | _ _ _ _ | _ _ _ _ |
            //
            // ↓
            // j

            Point[,] arr = new Point[4, 4];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        arr[i, j].X = x1;
                    }
                    else
                    {
                        arr[i, j].X = arr[i - 1, j].X + length;
                    }
                    if (j == 0)
                    {
                        arr[i, j].Y = y2;
                    }
                    else
                    {
                        arr[i, j].Y = arr[i, j - 1].Y + length;
                    }
                    if (i + 1 == arr.GetLength(0))
                    {
                        arr[i, j].X = x2;
                    }
                    if (j + 1 == arr.GetLength(1))
                    {
                        arr[i, j].Y = y1;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Recursive function drawing fractal.
        /// </summary>
        /// <param name="x1">Square left lower point X-coord.</param>
        /// <param name="y1">Square left lower point Y-coord.</param>
        /// <param name="x2">Square right upper point X-coord.</param>
        /// <param name="y2">Square right upper point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="colorStage">Gradient color id.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        void Rec(int x1, int y1, int x2, int y2, int depth, int colorStage, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (depth == 1)
            {
                g.FillRectangle(new SolidBrush(Gradient[colorStage]), x1, y2, x2 - x1, y1 - y2);
                Picture.Image = bmp;
                return;
            }
            Point[,] arr = SplitSquare(x1, y1, x2, y2);
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (i == 2 && j == 1)
                    {
                        continue;
                    }
                    Rec(arr[i - 1, j + 1].X, arr[i - 1, j + 1].Y, arr[i, j].X, arr[i, j].Y, depth - 1, i + j, bmp);
                }
            }

        }

        /// <summary>
        /// Drawing fractal carpet.
        /// </summary>
        /// <param name="x">Starting point X-coord.</param>
        /// <param name="y">Starting point Y-coord.</param>
        /// <param name="depth">Recursion depth.</param>
        /// <param name="bmp">Bitmap where to draw.</param>
        public override void DrawFractal(int x, int y, int depth, Bitmap bmp)
        {
            base.DrawFractal(x, y, depth, bmp);
            depth = Math.Min(maxDepth, depth);
            SetGradient(5);
            int x1 = x - length / 2;
            int y1 = y + length / 2;
            int x2 = x + length / 2;
            int y2 = y - length / 2;
            Rec(x1, y1, x2, y2, depth, 5, bmp);
        }
    }
}
