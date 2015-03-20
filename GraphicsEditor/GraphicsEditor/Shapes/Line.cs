using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Line : Shape
    {
        protected Point secondPoint;
        public Line(int x, int y, int x1, int y1, Color pen) : base(x,y)
        {
            point = new Point(x, y);
            secondPoint = new Point(x1, y1);
            this.pen = new Pen(pen);
        }

        public override void Draw(Graphics graphObj)
        {
            graphObj.DrawLine(pen, point, secondPoint);
        }
    }
}
