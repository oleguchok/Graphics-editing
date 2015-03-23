using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class EllipseDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(System.Drawing.Point[] arrayPoint)
        {
            Ellipse ellipse = new Ellipse(arrayPoint[0], arrayPoint[1], Color.Green, Color.Green);
            return new DrawEllipse(ellipse);
        }
    }
}
