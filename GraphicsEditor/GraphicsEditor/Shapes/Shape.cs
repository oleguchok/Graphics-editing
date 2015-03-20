using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    abstract class Shape
    {
        public abstract Point Point1 { get; set; }
        public abstract Point Point2 { get; set; }
        public virtual Brush Brush { get; set; }
        public abstract Pen Pen { get; set; }

        /*public Shape(Point point1, Point point2, Color brushColor, Color penColor)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            Brush = new SolidBrush(brushColor);
            Pen = new Pen(penColor);
        }

        public Shape(Point point1, Point point2, Color penColor)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Pen = new Pen(penColor);
        }
        */
       // public abstract void Draw(Graphics graphObj);

    }
}
