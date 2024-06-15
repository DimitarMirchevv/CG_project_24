﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    internal class Line : Shape
    {
        public Line(RectangleF rect) : base(rect)
        {
        }

        public Line(RectangleShape rectangle) : base(rectangle)
        {
        }

        public override RectangleF Rectangle { get => base.Rectangle; set => base.Rectangle = value; }
        public override float Width { get => base.Width; set => base.Width = value; }
        public override PointF Location { get => base.Location; set => base.Location = value; }
        public override Color FillColor { get => base.FillColor; set => base.FillColor = value; }
        public Point Point1 { get; }
        public Point Point2 { get; }

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {


            PointF point1 = new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y);
            PointF point2 = new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height); 

            base.DrawSelf(grfx);
         

            grfx.DrawLine(new Pen(Color.Red), point1, point2);

           // base.DrawSelf(grfx);
            //grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
