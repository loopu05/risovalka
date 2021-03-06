﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka.FormFigure;

namespace risovalka.APainter
{
    public class LinePainter : AbstractPainter
    {
        public LinePainter(Brush brush, IFormFigure formFigure, Point startPoint)
        {
            this.brush = brush;
            this.formFigure = formFigure;
            this.startPoint = startPoint;
        }
        public override void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift)
        {
            brush.DrawLine(startPoint, p1, pictureBox, brush.currentColor);
            startPoint = p1;
        }

        public override void MoveFigure(int dX, int dY)
        {
            
        }
    }
}
