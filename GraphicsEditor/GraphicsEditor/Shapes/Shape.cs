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
    }
}
