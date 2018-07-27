using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopfieldNetwork
{
    public partial class Form1 : Form
    {
        int k = 0;

        int netSize = 10;
        int cellSize = 30;

        HopfieldNet hNet;
        bool[] activeImage;
        bool[][] inputImages;

        bool isPressed;
        public Form1()
        {
            InitializeComponent();
            hNet = new HopfieldNet(netSize);
            activeImage = new bool[netSize * netSize];
            inputImages = hNet.Images;
        }

        private void ClearField_Click(object sender, EventArgs e)
        {
            activeImage = new bool[netSize * netSize];
            pictureBox1.Refresh();
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            if (activeImage.Any(x => x))
            {
                hNet.AddImage(activeImage);
                inputImages = hNet.Images;
            }
        }

        private void ShowImage_Click(object sender, EventArgs e)
        {
            if(inputImages.Length > 0)
            {
                if (k >= inputImages.Length-1)
                {
                    k=0;
                }
                else
                {
                    k++;
                }
                activeImage = inputImages[k];
                pictureBox1.Refresh();
            }
        }

        private void ClearImages_Click(object sender, EventArgs e)
        {
            hNet.ClearImages();
            inputImages = new bool[0][];
        }

        private void RecognizeImage_Click(object sender, EventArgs e)
        {
            if (activeImage.Any(x => x) && inputImages.Length>0)
            {
                bool[] image = hNet.RecognizeImage(activeImage);
                if (image != null)
                {
                    activeImage = image;
                    pictureBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Образ не распознан!");
                }
            }
        }

        private void CellSizeBox_ValueChanged(object sender, EventArgs e)
        {
            cellSize = (int)CellSizeBox.Value;
            pictureBox1.Refresh();
        }

        private void Recalculate_Click(object sender, EventArgs e)
        {
            netSize = (int)ImageSizeBox.Value;
            hNet = new HopfieldNet(netSize);
            activeImage = new bool[netSize * netSize];
            inputImages = hNet.Images;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawTable(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            int size = netSize * cellSize;
            if (e.X < size && e.Y < size && e.X > 0 && e.Y > 0)
            {
                int x = (int)Math.Floor((double)e.X / cellSize);
                int y = (int)Math.Floor((double)e.Y / cellSize);
                label2.Text = $"Ячейка ({x + 1},{y + 1})";
                activeImage[x + y * netSize] = true;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                int size = netSize * cellSize;
                if (e.X<size && e.Y<size && e.X>0 && e.Y>0)
                {
                    int x = (int)Math.Floor((double)e.X / cellSize);
                    int y = (int)Math.Floor((double)e.Y / cellSize);
                    label2.Text = $"Ячейка ({x+1},{y+1})";
                    activeImage[x + y * netSize] = true;
                    pictureBox1.Refresh();
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            label2.Text = $"Ячейка (-,-)";
        }


        private void DrawTable(Graphics gr)
        {
            int border = 1;

            int w = cellSize * netSize;
            int h = cellSize * netSize;

            int widthLines = cellSize;
            int heightLines = cellSize;


            gr.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, w, h));
            for (int i = 0; i < w; i += widthLines)
            {
                gr.DrawLine(new Pen(Color.Black), new Point(i + widthLines, 0), new Point(i + widthLines, h));
                gr.DrawLine(new Pen(Color.Black), new Point(0, i + heightLines), new Point(w, i + heightLines));
            }

            for (int x = 0; x < netSize; x++)
            {
                int line = netSize * x;
                for (int y = 0; y < netSize; y++)
                {
                    if (activeImage[line + y])
                    {
                        gr.FillRectangle(Brushes.LightGreen, new Rectangle(y * cellSize + border, x * cellSize + border, widthLines - border, heightLines - border));
                    }
                    else
                    {
                        gr.FillRectangle(Brushes.White, new Rectangle(y * cellSize + border, x * cellSize + border, widthLines - border, heightLines - border));
                    }
                }
            }


        }
    }
}
