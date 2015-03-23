using GraphicsEditor.Creators;
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
        Graphics g;
        Point[] arrayPoints = new Point[3];
        DrawCreator currentCreator;
        int clicksNumber, currentClicks = 0;
        List<IDrawShape> drawingClasses = new List<IDrawShape>();
        
        public FormGraphicsEditor()
        {
            InitializeComponent();
        }

        private void DrawOnPanel(List<IDrawShape> list)
        {
            g = panelDraw.CreateGraphics();
            foreach (IDrawShape dr in list)
                dr.Draw(g);
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
            if (currentClicks == clicksNumber)
            {
                drawingClasses.Add(currentCreator.FactoryMethod(arrayPoints));
                this.DrawOnPanel(drawingClasses);
                currentClicks = 0;
            }
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            currentCreator = new LineDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
        }


    }
}
