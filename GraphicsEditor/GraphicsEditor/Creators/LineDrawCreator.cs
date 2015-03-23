using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class LineDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(Point[] arrayPoint)
        {
            Line line = new Line(arrayPoint[0], arrayPoint[1], Color.Black);
            return new DrawLine(line);
        }
    }
}
