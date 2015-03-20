using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Circle : Ellipse
    {
        public Circle(int x, int y, int length, Color brush) : base (x, y, length, length, brush)
        {
            point = new Point(x, y);
            this.brush = new SolidBrush(brush);
        }
    }
}
