using System.Drawing;
using System.Drawing.Imaging;

namespace Paint
{
    public partial class Form1 : Form
    {

        // cursor coordinates
        private int x, y;
        
        // standart params
        Color PenCol = Color.Black;
        Pen pen;
        private int thickness = 5;

        // brushes
        // 0 - elyps
        // 1 - rect
        // 2 - default brush
        private bool isPainting, isErase;
        private int mode = 2;
        Color bgColor;

        // graphics
        Bitmap bmp;
        Graphics g;
        



        public Form1()
        {
            InitializeComponent();

            // bg for picturebox
            bmp = new Bitmap(Convert.ToInt32(pictureBox1.Width), Convert.ToInt32(pictureBox1.Height));
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
            }
            pictureBox1.Image = bmp;
            bgColor = pictureBox1.BackColor;
        }

        private void Thickness_Scroll(object sender, EventArgs e)
        {
            thickness = ThicknessBar.Value;
            Thickval.Text = String.Format("Thickness:" + thickness);

        }
        private void color_picker_Click(object sender, EventArgs e)
        {
            ColorPalate.ShowDialog();
            PenCol = ColorPalate.Color;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            x = e.X;
            y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x1 = e.X;
            int y1 = e.Y;
            pen = new Pen(PenCol, thickness);
            if (isErase)
            {
                pen = new Pen(bgColor, thickness);
                mode = 2;
            }
            if (mode != 2) // если необычная кисть
            {
                // по сути просто копирует фон пикчер бокса (код спиздил у Шаймуха) 
                Rectangle cloneRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                PixelFormat format = bmp.PixelFormat;
                Bitmap local = bmp.Clone(cloneRect, format);
                pictureBox1.Image = local;
                g = Graphics.FromImage(local); 
            }
            if (isPainting)
            {
                
                switch (mode)
                {
                    case 0:   // элипс     
                        g.DrawEllipse(pen, x, y, (x1 - x), (y1 - y));
                        break;

                    case 1: // прямоугольник
                        g.DrawRectangle(pen, x, y, x1 - x, y1 - y);
                        break;

                    case 2: // обычная кисть
                        var t = pictureBox1.Image;
                        g = Graphics.FromImage(t);
                        g.DrawLine(pen, new Point(x, y), new Point(x1, y1));
                        x = x1;
                        y = y1;
                        pictureBox1.Image = t;
                        g.Dispose();
                        break;     
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);

            // когда отпускаем мышу закрепляем нарисованную фигуру
            switch (mode) {
                case 0:
                    g.DrawEllipse(pen, x, y, (e.X - x), (e.Y - y));
                    break;
                case 1:
                    g.DrawRectangle(pen, x, y, (e.X - x), (e.Y - y));
                    break;
            }
            g.Dispose();
            isPainting = false;
        }

        
        // Figures
        private void elpseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eraseToolStripMenuItem.Checked = false;
            brushToolStripMenuItem.Checked = false;

            rectangleToolStripMenuItem.Checked = false;
            elpseToolStripMenuItem.Checked = true;

            mode = 0;
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eraseToolStripMenuItem.Checked = false;
            brushToolStripMenuItem.Checked = false;

            rectangleToolStripMenuItem.Checked = true;
            elpseToolStripMenuItem.Checked = false;
            
            mode = 1;
        }

        
        // Edit
        private void eraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eraseToolStripMenuItem.Checked = true;
            brushToolStripMenuItem.Checked = false;

            rectangleToolStripMenuItem.Checked = false;
            elpseToolStripMenuItem.Checked = false;

            isErase = true;
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eraseToolStripMenuItem.Checked = false;
            brushToolStripMenuItem.Checked = true;

            mode = 2;
            isErase = false;
        }

        // File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bmp = new Bitmap(dlg.FileName);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(dlg.FileName, ImageFormat.Png);
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}