using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainFrame : Form
    {

        private PaintField paintField;

        public MainFrame()
        {
            InitializeComponent();
            initMainPaintField();
        }

        private void initMainPaintField()
        {
            paintField = new PaintField();
            this.Controls.Add(paintField);
            this.Controls.Add(paintField.rightSizeSelector);
            this.Controls.Add(paintField.verticalSizeSelector);
            this.Controls.Add(paintField.diagonalSizeSelector);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            var choie=cd.ShowDialog();
            var color = cd.Color;
            if (choie == DialogResult.OK)
            {
                paintField.Pen.Color = color;
            }
        }
    }
}
