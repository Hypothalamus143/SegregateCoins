using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegregateCoins
{
    public partial class Form1 : Form
    {
        List<Tuple<int, int, int, int>> coins = new List<Tuple<int, int, int, int>>();
        public Form1()
        {
            InitializeComponent();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(exeDirectory, @"..\..\coins.jpeg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            int bWidth = bitmap.Width;
            int bHeight = bitmap.Height;
            int pWidth = pictureBox1.Width;
            int pHeight = pictureBox1.Height;
            double widthRatio = (double)pWidth / bWidth;
            double heightRatio = (double)pHeight / bHeight;
            //Console.WriteLine($"{widthRatio}, {heightRatio}, {bWidth}, {bHeight}, {pWidth}, {pHeight}");
            Graphics g = e.Graphics;
            int fivePesoThreshold = (int)fivePesoThresholdNumericUpDown.Value;
            int onePesoThreshold = (int)onePesoNumericUpDown.Value;
            int twentyFiveCentThreshold = (int)twentyFiveCentNumericUpDown.Value;
            int tenCentThreshold = (int)tenCentNumericUpDown.Value;
            Pen p;
            foreach (Tuple<int, int, int, int> coin in coins)
            {

                int centerX = coin.Item1;
                int centerY = coin.Item2;
                int radius = coin.Item3;
                int scaledX = (int)(centerX * widthRatio);
                int scaledY = (int)(centerY * heightRatio);
                int scaledRadius = (int)(radius * widthRatio);
                if(radius >= fivePesoThreshold)
                {
                    p = Pens.Blue;
                }
                else if(radius >= onePesoThreshold)
                {
                    p = Pens.Green;
                }
                else if (radius >= twentyFiveCentThreshold)
                {
                    p = Pens.Cyan;
                }
                else if (radius >= tenCentThreshold)
                {
                    p = Pens.Magenta;
                }
                else
                {
                    p = Pens.Red;
                }
                //Console.WriteLine($"{scaledX}, {scaledY}, {scaledRadius}, {centerX}, {centerY}, {radius}");
                g.DrawArc(p, scaledX - scaledRadius, scaledY - scaledRadius, 2 * scaledRadius, 2 * scaledRadius, 0, 360);
            }
        }
        private void getCoins()
        {
            coins = new List<Tuple<int, int, int, int>>();
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            int width = bitmap.Width;
            int height = bitmap.Height;
            int colorThreshold = colorThresholdTrackBar.Value;
            int rangeThreshold = (int)rangeThresholdNumericUpDown.Value;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if (validCoin(rangeThreshold, colorThreshold, ref bitmap, x, y, coins))
                    {
                        Tuple<int, int> result = getDiameter(colorThreshold, ref bitmap, x, y);
                        int diameter = result.Item1;
                        int maxMistake = result.Item2;
                        if (diameter < rangeThreshold) break; //brute-forced solution
                        int radius = (int)(diameter / 2.0);
                        int centerX = x;
                        int centerY = y + radius;
                        Tuple<int, int, int, int> coin = new Tuple<int, int, int, int>(centerX, centerY, radius, maxMistake);
                        coins.Add(coin);

                    }
                }
            }
        }
        private bool validCoin(int rangeThreshold, int colorThreshold, ref Bitmap bitmap, int x, int y, List<Tuple<int, int, int, int>> coins)
        {
            Color pixel;
            int chance = (int)chanceNumericUpDown.Value;
            int mistake = 0;
            for (int i = 0; i < rangeThreshold && y + i < bitmap.Height; i++)
            {
                if (!newCoin(x, y + i, coins)) return false;
                pixel = bitmap.GetPixel(x, y + i);
                if (pixel.R > colorThreshold) mistake++;
                else mistake = 0;
                if(mistake > chance) return false;
            }
            return true;
        }
        private Tuple<int, int> getDiameter(int colorThreshold, ref Bitmap bitmap, int x, int y)
        {
            int chance = (int)chanceNumericUpDown.Value;
            int diameter = 0;
            int mistake = 0;
            int maxMistake = 0;
            Color pixel;
            while (y + diameter < bitmap.Height)
            {
                pixel = bitmap.GetPixel(x, y+diameter);
                if (pixel.R > colorThreshold) mistake++;
                else
                {
                    if(mistake > maxMistake) maxMistake = mistake;
                    mistake = 0;
                }
                if (mistake > chance) break;
                diameter++;
            }
            Tuple<int, int> result = new Tuple<int, int>(diameter, maxMistake);
            return result;
        }
        private bool newCoin(int x, int y, List<Tuple<int, int, int, int>> coins)
        {
            foreach (Tuple<int, int, int, int> coin in coins)
            {
                int centerX = coin.Item1;
                int centerY = coin.Item2;
                int radius = coin.Item3;
                if (centerX - radius <= x && x <= centerX + radius && centerY - radius <= y && y <= centerY + radius)
                //if (centerX - radius <= x && x <= centerX + radius && centerY - radius <= y && y <= centerY + radius)
                    return false;

            }
            return true;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            getCoins();
            int fivePesoThreshold = (int)fivePesoThresholdNumericUpDown.Value;
            int onePesoThreshold = (int)onePesoNumericUpDown.Value;
            int twentyFiveCentThreshold = (int)twentyFiveCentNumericUpDown.Value;
            int tenCentThreshold = (int)tenCentNumericUpDown.Value;
            int fivePesoCount = 0;
            int onePesoCount = 0;
            int twentyFiveCentCount = 0;
            int tenCentCount = 0;
            int fiveCentCount = 0;
            foreach(Tuple<int, int, int, int> coin in coins)
            {
                int radius = coin.Item3;
                if (radius >= fivePesoThreshold) fivePesoCount++;
                else if (radius >= onePesoThreshold) onePesoCount++;
                else if(radius >= twentyFiveCentThreshold) twentyFiveCentCount++;
                else if(radius>= tenCentThreshold) tenCentCount++;
                else fiveCentCount++;
            }
            CoinsDetected.Text = $"Five Peso Count: {fivePesoCount}\n";
            CoinsDetected.Text += $"One Peso Count: {onePesoCount}\n";
            CoinsDetected.Text += $"Twenty Five Cent Count: {twentyFiveCentCount}\n";
            CoinsDetected.Text += $"Ten Cent Count: {tenCentCount}\n";
            CoinsDetected.Text += $"Five Cent Count: {fiveCentCount}";
            pictureBox1.Refresh();
        }

        private void fivePesoThresholdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void onePesoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void twentyFiveCentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void tenCentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
