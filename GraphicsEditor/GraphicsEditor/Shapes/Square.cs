using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Square : Rectangle
    {
        public Square(Point point1, Point point2, Color brushColor, Color penColor) : base(point1,point2,brushColor,penColor)
        {
            this.width = Math.Abs(point1.X - point2.X);
        }
    }
}
