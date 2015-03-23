using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.DrawShapes
{
    class DrawTriangle : IDrawShape
    {
        private Triangle triangle;

        public DrawTriangle(Triangle triangle)
        {
            this.triangle = triangle;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.FillPolygon(this.triangle.Brush, new Point[]{this.triangle.Point1, this.triangle.Point2,
                this.triangle.Point3});
        }
    }
}
