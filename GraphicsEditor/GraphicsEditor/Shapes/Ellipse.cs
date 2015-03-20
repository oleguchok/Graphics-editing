﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Ellipse : Shape
    {
        protected Point point1;
        protected Point point2;
        protected Brush brush;
        protected Pen pen;
        protected int length;
        protected int width;

        public Ellipse(Point point1, Point point2, Color brushColor, Color penColor)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.brush = new SolidBrush(brushColor);
            this.pen = new Pen(penColor);
            this.length = Math.Abs(point1.X - point2.X);
            this.width = Math.Abs(point1.Y - point2.Y);
        }

/*        public override void Draw(Graphics graphObj)
        {
            graphObj.FillEllipse(brush, point.X, point.Y, this.length, this.width);
        }*/

        public override Point Point1
        {
            get
            {
                return point1;
            }
            set
            {
                point1 = value;
            }
        }

        public override Point Point2
        {
            get
            {
                return point2;
            }
            set
            {
                point2 = value;
            }
        }

        public override Brush Brush
        {
            get
            {
                return brush;
            }
            set
            {
                brush = value;
            }
        }

        public override Pen Pen
        {
            get
            {
                return pen;
            }
            set
            {
                pen = value;
            }
        }
    }
}
