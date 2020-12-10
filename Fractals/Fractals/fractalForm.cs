using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Fractals
{
    /// <summary>
    /// Form with drawing fractals interface.
    /// </summary>
    partial class FractalsForm : Form
    {
        /// <summary>
        /// Current depth value.
        /// </summary>
        int depth = 1;

        /// <summary>
        /// Current fractal id.
        /// </summary>
        int selectedFractal;

        /// <summary>
        /// Current starting gradient color.
        /// </summary>
        Color startColor;

        /// <summary>
        /// Current ending gradient color.
        /// </summary>
        Color endColor;

        public FractalsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets startColor value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartColorButton_Click(object sender, EventArgs e)
        {
            if (startColorDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            startColorButton.BackColor = startColorDialog.Color;
            startColorButton.ForeColor = startColorDialog.Color;
        }

        /// <summary>
        /// Sets endColor value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndColorButton_Click(object sender, EventArgs e)
        {
            if (endColorDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            endColorButton.BackColor = endColorDialog.Color;
            endColorButton.ForeColor = endColorDialog.Color;
        }

        /// <summary>
        /// Sets all controls to default positions.
        /// </summary>
        private void SetDefault()
        {
            pictureFractal.Image = null;
            startColorDialog.Color = Color.White;
            endColorDialog.Color = Color.White;
            startColorButton.BackColor = Color.White;
            startColorButton.ForeColor = Color.White;
            endColorButton.BackColor = Color.White;
            endColorButton.ForeColor = Color.White;
            fractalDepthBar.Value = fractalDepthBar.Minimum;
            scaleTrackBar.Value = scaleTrackBar.Minimum;
            cantorSetDistanceBar.Value = cantorSetDistanceBar.Minimum;
            proportionsBar.Value = proportionsBar.Minimum;
            leftSegmentAngleBar.Value = 45;
            rightSegmentAngleBar.Value = 45;
            mainPanel.Visible = true;
            controlsPanel.Visible = true;
            saveButton.Visible = false;
            fractalTreePanel.Visible = false;
            cantorSetPanel.Visible = false;
        }

        /// <summary>
        /// Sets panels for current fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefault();
            switch (fractalsComboBox.SelectedIndex)
            {
                case 0:
                    fractalTreePanel.Visible = true;
                    fractalDepthBar.Maximum = 15;
                    return;
                case 1:
                    fractalDepthBar.Maximum = 8;
                    return;
                case 2:
                    fractalDepthBar.Maximum = 6;
                    return;
                case 3:
                    fractalDepthBar.Maximum = 8;
                    return;
                case 4:
                    fractalDepthBar.Maximum = 7;
                    cantorSetPanel.Visible = true;
                    return;
                default:
                    return;
            }
        }

        /// <summary>
        /// Draws selected fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            pictureFractal.Image = null;
            startColor = startColorDialog.Color;
            endColor = endColorDialog.Color;
            selectedFractal = fractalsComboBox.SelectedIndex;
            saveButton.Visible = true;
            PictureFractal(sender, e);
            if (pictureFractal.Image != null)
            {
                pictureFractal.Image = ZoomIn(pictureFractal.Image,
                    new Size(scaleTrackBar.Value, scaleTrackBar.Value));
            }
        }

        /// <summary>
        /// Maintain proper picture size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicturePanel_SizeChanged(object sender, EventArgs e)
        {
            pictureFractal.Width = Math.Max(pictureFractal.Width, picturePanel.Width);
            pictureFractal.Height = Math.Max(pictureFractal.Height, picturePanel.Height);
        }

        /// <summary>
        /// Returns zoomed image.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        Image ZoomIn(Image image, Size size)
        {
            Bitmap bmp = new Bitmap(image, image.Width * size.Width, image.Height * size.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        /// <summary>
        /// Sets pre-load settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalsForm_Load(object sender, EventArgs e)
        {
            startColor = Color.White;
            endColor = Color.White;
            DoubleBuffered = true;
        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalDepthBar_ValueChanged(object sender, EventArgs e)
        {
            depth = fractalDepthBar.Value;
            fractalDepthLabel.Text = $"Глубина рекурсии: {depth}";
        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            scaleLabel.Text = $"Увеличение: {scaleTrackBar.Value}";
        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CantorSetDistanceBar_ValueChanged(object sender, EventArgs e)
        {
            cantorSetDistanceLabel.Text = $"Расстояние между отрезками: {cantorSetDistanceBar.Value}";

        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProportionsBar_ValueChanged(object sender, EventArgs e)
        {
            proportionsLabel.Text = $"Отношение длин: 1:{(double)proportionsBar.Value / 100}";

        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftSegmentAngleBar_Scroll(object sender, EventArgs e)
        {
            leftSegmentAngleLabel.Text = $"Угол наклона левого отрезка: {leftSegmentAngleBar.Value}°";
        }

        /// <summary>
        /// Updates label and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightSegmentAngleBar_Scroll(object sender, EventArgs e)
        {
            rightSegmentAngleLabel.Text = $"Угол наклона правого отрезка: {rightSegmentAngleBar.Value}°";
        }

        /// <summary>
        /// Saves image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pictureFractal.Image != null)
            {
                saveFileDialog.Filter = "Image Files(*.JPG)|*JPG|Image Files(*.PNG)|*.PNG";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 0:
                                pictureFractal.Image.Save(saveFileDialog.FileName + ".jpeg",
                                    ImageFormat.Jpeg);
                                break;
                            case 1:
                                pictureFractal.Image.Save(saveFileDialog.FileName + ".png",
                                    ImageFormat.Png);
                                break;
                            default:
                                break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Call to draw current fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureFractal(object sender, EventArgs e)
        {
            int width = pictureFractal.Width;
            int height = pictureFractal.Height;
            Bitmap bmp = new Bitmap(width, height);
            switch (selectedFractal)
            {
                case 0:
                    FractalTree fractalTree = new FractalTree(startColor, endColor,
                        (double)proportionsBar.Value / 100,
                        leftSegmentAngleBar.Value,
                        rightSegmentAngleBar.Value,
                        pictureFractal);
                    fractalTree.DrawFractal(width / 2, (int)(height * 0.83), depth, bmp);
                    break;
                case 1:
                    KochCurve kochCurve = new KochCurve(startColor, endColor,
                        pictureFractal);
                    kochCurve.DrawFractal(width / 2, (int)(height * 0.7), depth, bmp);
                    break;
                case 2:
                    FractalCarpet fractalCarpet = new FractalCarpet(startColor, endColor,
                        pictureFractal);
                    fractalCarpet.DrawFractal(width / 2, height / 2, depth, bmp);
                    break;
                case 3:
                    FractalTriangle fractalTriangle = new FractalTriangle(startColor, endColor,
                        pictureFractal);
                    fractalTriangle.DrawFractal(width / 2 - 500, (int)(height * 0.9), depth, bmp);
                    break;
                case 4:
                    CantorSet cantorSet = new CantorSet(startColor, endColor,
                        cantorSetDistanceBar.Value, pictureFractal);
                    cantorSet.DrawFractal(width / 2 - 500, (int)(height * 0.2), depth, bmp);
                    break;
            }
        }
    }
}
