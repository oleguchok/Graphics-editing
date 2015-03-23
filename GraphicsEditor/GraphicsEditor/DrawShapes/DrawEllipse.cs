using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.DrawShapes
{
    class DrawEllipse : IDrawShape
    {
        private Ellipse ellipse;

        public DrawEllipse(Ellipse ellipse)
        {
            this.ellipse = ellipse;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.FillEllipse(this.ellipse.Brush, this.ellipse.Point1.X, this.ellipse.Point1.Y,
                this.ellipse.Length, this.ellipse.Width);
        }
    }
}
