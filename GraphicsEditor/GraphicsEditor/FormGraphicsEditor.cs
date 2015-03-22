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
        bool isDrawing = false;
        Graphics g;
        Point[] arrayPoints = new Point[3];
        Shape currentShape;
        int clicksNumber, currentClicks = 0;

        public FormGraphicsEditor()
        {
            InitializeComponent();
        }

        private void FormGraphicsEditor_Paint(object sender, PaintEventArgs e)
        {
            /*ListOfShapes figures = new ListOfShapes();
            figures.list.Add(new Ellipse(10, 10, 50, 70, Color.Chocolate));
            figures.list.Add(new Circle(70, 10, 50, Color.Yellow));
            figures.list.Add(new Rectangle(140, 10, 60, 80, Color.Red));
            figures.list.Add(new Square(210, 20, 60, Color.Black));
            figures.list.Add(new Line(290, 10, 420, 60, Color.Violet));
            figures.list.Add(new Triangle(430, 40, 470, 10, 520, 50, Color.Green));

            Graphics graphObj = this.CreateGraphics();

            foreach (Shape shape in figures.list)
            {
                shape.Draw(graphObj);
            }*/
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentClicks < clicksNumber)
            {
                if (currentClicks == 0)
                    arrayPoints[0] = new Point(e.X, e.Y);
                if (currentClicks == 1)
                    arrayPoints[1] = new Point(e.X, e.Y);
                if (currentClicks == 2)
                    arrayPoints[2] = new Point(e.X, e.Y);
                currentClicks++;
            }
            else
            {
                //DrawShape(Shape, Point[])
                currentClicks++;
            }
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            currentShape = new Line();
            clicksNumber = 2;
            currentClicks = 0;
        }


    }
}
