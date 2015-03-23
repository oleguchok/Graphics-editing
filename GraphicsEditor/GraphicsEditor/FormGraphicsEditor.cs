﻿using GraphicsEditor.Creators;
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
        DrawCreator currentCreator;
        int clicksNumber, currentClicks = 0;
        Stack<IDrawShape> drawingClasses = new Stack<IDrawShape>();
        
        public FormGraphicsEditor()
        {
            InitializeComponent();
        }

        private void DrawOnPanel(Stack<IDrawShape> stack)
        {
            g = panelDraw.CreateGraphics();
            foreach (IDrawShape dr in stack)
                dr.Draw(g);
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
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
                    drawingClasses.Push(currentCreator.FactoryMethod(arrayPoints));
                    this.DrawOnPanel(drawingClasses);
                    currentClicks = 0;
                }
            }
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            currentCreator = new LineDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            drawingClasses.Pop();
            this.DrawOnPanel(drawingClasses);
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            drawingClasses.Clear();
            g.Dispose();
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            currentCreator = new RectangleDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButtonSquare_Click(object sender, EventArgs e)
        {
            currentCreator = new SquareDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            currentCreator = new EllipseDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButtonCircle_Click(object sender, EventArgs e)
        {
            currentCreator = new CircleDrawCreator();
            clicksNumber = 2;
            currentClicks = 0;
            isDrawing = true;
        }

        private void toolStripButtonTriangle_Click(object sender, EventArgs e)
        {
            currentCreator = new TriangleDrawCreator();
            clicksNumber = 3;
            currentClicks = 0;
            isDrawing = true;
        }


    }
}
