using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class CircleDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(System.Drawing.Point[] arrayPoint)
        {
            Circle circle = new Circle(arrayPoint[0], arrayPoint[1], Color.Black, Color.Black);
            return new DrawEllipse(circle);
        }
    }
}
