using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    class PenSizeSelector:ComboBox
    {
        public PenSizeSelector()
        {
            initVisual();       
        }

        private void initVisual()
        {
            Size tmp = new Size();
            tmp.Height = 27;
            tmp.Width = 75;
        }
    }
}
