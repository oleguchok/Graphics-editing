using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class RectangleDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(System.Drawing.Point[] arrayPoint)
        {
            Rectangle rectangle = new Rectangle(arrayPoint[0], arrayPoint[1], Color.Red, Color.Red);
            return new DrawRectangle(rectangle);
        }
    }
}
