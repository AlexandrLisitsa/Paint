using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class PaintField:Panel
    {
        private int x = 0;
        private int y = 0;
        private Graphics G { get; set; }
        public Pen Pen { get; set; }
        private Point selectorsSize = new Point(5, 5);
        public Panel rightSizeSelector = new Panel();
        public Panel verticalSizeSelector = new Panel();
        public Panel diagonalSizeSelector = new Panel();

        public PaintField()
        {
            initPaintField();
            initRightSizeSelector();
            initVerticalSizeSelector();
            initDiagonalSizeSelector();
            initGraphics();
            initDrowEngine();
        }

        private void initDrowEngine()
        {
            this.MouseDown += mouseDown;
            this.MouseMove += mouseMove;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                G.DrawLine(Pen, x, y, e.X, e.Y);
            }
             x = e.X;
             y = e.Y;
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void initGraphics()
        {
            G = this.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen = new Pen(Brushes.Black, 5);
            Pen.StartCap = Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }


        private void initDiagonalSizeSelector()
        {
            diagonalSizeSelector.Size = new Size(selectorsSize);
            diagonalSizeSelector.Location = new Point(this.Size.Width+this.Location.X, this.Size.Height+this.Location.Y);
            diagonalSizeSelector.BackColor = Color.White;
            diagonalSizeSelector.BorderStyle = BorderStyle.FixedSingle;
            diagonalSizeSelector.MouseMove += diagonalResize;
        }


        private void initVerticalSizeSelector()
        {
            verticalSizeSelector.Size = new Size(selectorsSize);
            verticalSizeSelector.Location = new Point((this.Size.Width/2)+this.Location.X, this.Size.Height+this.Location.Y);
            verticalSizeSelector.BackColor = Color.White;
            verticalSizeSelector.BorderStyle = BorderStyle.FixedSingle;
            verticalSizeSelector.MouseMove += verticalResize;
        }


        private void initRightSizeSelector()
        {
            rightSizeSelector.Size = new Size(selectorsSize);
            rightSizeSelector.Location = new Point(this.Size.Width+this.Location.X, (this.Size.Height/2)+this.Location.Y);
            rightSizeSelector.BackColor = Color.White;
            rightSizeSelector.BorderStyle = BorderStyle.FixedSingle;
            rightSizeSelector.MouseMove += horisontalResize;
        }

        private void diagonalResize(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point(diagonalSizeSelector.Location.X + e.X, diagonalSizeSelector.Location.Y + e.Y);
                diagonalSizeSelector.Location = pos;
                resizePaintPanel(pos, "diagonal");
            }
        }

        private void verticalResize(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point(this.Size.Width/2+this.Location.X, verticalSizeSelector.Location.Y+e.Y);
                verticalSizeSelector.Location = pos;
                resizePaintPanel(pos,"vertical");
            }
        }

        private void horisontalResize(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point(rightSizeSelector.Location.X+e.X, this.Size.Height/2+this.Location.Y);
                rightSizeSelector.Location = pos;
                resizePaintPanel(pos,"horisontal");
            }
        }

        private void resizePaintPanel(Point point, string vector)
        {
            if (vector.Equals("horisontal"))
            {
                Size tmp = new Size(point.X+this.Location.X-10, this.Size.Height);
                this.Size = tmp;
            } else if (vector.Equals("vertical"))
            {
                Size tmp = new Size(this.Size.Width, point.Y-this.Location.Y);
                this.Size = tmp;
            }else if (vector.Equals("diagonal"))
            {
                Size tmp = new Size(point.X-this.Location.X, point.Y -this.Location.Y);
                this.Size = tmp;
            }
            optimizeSelectorsLocation();
        }

        private void optimizeSelectorsLocation()
        {
            rightSizeSelector.Location = new Point(this.Width+this.Location.X,this.Height/2+this.Location.Y);
            verticalSizeSelector.Location = new Point(this.Width/2+this.Location.X, this.Height+this.Location.Y);
            diagonalSizeSelector.Location = new Point(this.Width + this.Location.X, this.Height + this.Location.Y);
            G = this.CreateGraphics();
        }

        private void initPaintField()
        {
            this.SetBounds(5, 40, 10, 10);
            Size tmp = new Size();
            tmp.Height = 500;
            tmp.Width = 900;
            this.BackColor = Color.White;
            this.Size = tmp;
        }
    }
}
