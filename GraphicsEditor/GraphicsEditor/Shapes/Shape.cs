using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    abstract class Shape
    {
        protected Point point;
        protected Brush brush;
        protected Pen pen;

        public Shape(int x, int y)
        {
            this.point = new Point(x, y);
        }

        public abstract void Draw(Graphics graphObj);

        /*private virtual bool CorrectInput()
        {
            if (point.X < 0 || point.Y < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/
    }
}
