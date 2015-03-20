using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Rectangle : Shape
    {
        protected int length;
        protected int width;

        public Rectangle(int x, int y, int length, int width, Color brush) : base(x,y)
        {
            this.length = length;
            this.width = width;
            this.brush = new SolidBrush(brush);
        }

        public override void Draw(Graphics graphObj)
        {
            graphObj.FillRectangle(brush, point.X, point.Y, this.length, this.width);
        }
    }
}
