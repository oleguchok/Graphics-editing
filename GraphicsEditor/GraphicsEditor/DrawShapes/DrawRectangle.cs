using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.DrawShapes
{
    class DrawRectangle : IDrawShape
    {
        private Rectangle rectangle;

        public DrawRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(this.rectangle.Brush, this.rectangle.Point1.X, this.rectangle.Point1.Y,
                this.rectangle.Length, this.rectangle.Width);
        }
    }
}
