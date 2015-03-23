using GraphicsEditor.DrawShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    class SquareDrawCreator : DrawCreator
    {
        public override IDrawShape FactoryMethod(System.Drawing.Point[] arrayPoint)
        {
            Square square = new Square(arrayPoint[0], arrayPoint[1], Color.Black, Color.Black);
            return new DrawRectangle(square);
        }
    }
}
