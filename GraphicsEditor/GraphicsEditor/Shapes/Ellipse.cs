using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Ellipse : Shape
    {
        protected int length;
        protected int width;

        public Ellipse(int x, int y, int length, int width, Color brush) : base(x,y)
        {
            this.length = length;
            this.width = width;
            this.brush = new SolidBrush(brush);
        }

        /*public Ellipse(int x, int y, int length, Color brush) : base(x, y)
        {
            this.length = length;
            this.width = length;
            this.brush = new SolidBrush(brush);
        }*/

        /*private bool itIsCircle()
        {
            if (this.length == this.width)
                return true;
            else
                return false;
        }*/

        public override void Draw(Graphics graphObj)
        {
            graphObj.FillEllipse(brush, point.X, point.Y, this.length, this.width);
        }
    }
}
