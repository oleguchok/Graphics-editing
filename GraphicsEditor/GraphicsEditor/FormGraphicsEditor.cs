using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class FormGraphicsEditor : Form
    {
        public FormGraphicsEditor()
        {
            InitializeComponent();
        }

        private void FormGraphicsEditor_Paint(object sender, PaintEventArgs e)
        {
            ListOfShapes figures = new ListOfShapes();
            figures.list.Add(new Ellipse(10, 10, 50, 70, Color.Chocolate));
            figures.list.Add(new Circle(70, 10, 50, Color.Yellow));
            figures.list.Add(new Rectangle(140, 10, 60, 80, Color.Red));
            figures.list.Add(new Square(210, 10, 60, Color.Black));
            figures.list.Add(new Line(290, 10, 420, 60, Color.Violet));
            figures.list.Add(new Triangle(430, 40, 470, 10, 520, 50, Color.Green));

            Graphics graphObj = this.CreateGraphics();

            foreach (Shape shape in figures.list)
            {
                shape.Draw(graphObj);
            }
        }
    }
}
