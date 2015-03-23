using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Creators
{
    abstract class DrawCreator
    {
        public abstract IDrawShape FactoryMethod(Point[] arrayPoint);
    }

}
