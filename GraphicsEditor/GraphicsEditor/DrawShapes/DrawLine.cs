using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.DrawShapes
{
    class DrawLine : IDrawShape
    {
        private Line line;
        
        public DrawLine(Line line)
        {
            this.line = line;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(this.line.Pen, this.line.Point1, this.line.Point2);
        }
    }
}
