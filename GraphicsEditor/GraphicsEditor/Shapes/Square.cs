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
        public Square(int x, int y, int length, Color myBrush) : base(x,y,length,length,myBrush)
        {
            point = new Point(x, y);
            brush = new SolidBrush(myBrush);
        }
    }
}
