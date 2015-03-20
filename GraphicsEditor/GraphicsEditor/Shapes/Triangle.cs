using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Triangle : Shape
    {
        protected Point secondPoint;
        protected Point thirdPoint;

        public Triangle(int x, int y, int x1, int y1, int x2, int y2, Color brush) : base(x,y)
        {
            secondPoint = new Point(x1, y1);
            thirdPoint = new Point(x2, y2);
            this.brush = new SolidBrush(brush);
        }

        public override void Draw(Graphics graphObj)
        {
            graphObj.FillPolygon(brush, new Point[] { point, secondPoint, thirdPoint });
        }
    }
}
