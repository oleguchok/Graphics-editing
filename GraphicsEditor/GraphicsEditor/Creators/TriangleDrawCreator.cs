using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class TriangleDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(System.Drawing.Point[] arrayPoint)
        {
            Triangle triangle = new Triangle(arrayPoint[0], arrayPoint[1], arrayPoint[2], Color.Black, Color.Black);
            return new DrawTriangle(triangle);
        }
    }
}
