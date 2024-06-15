using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class Square : Shape
    {
        public Square(RectangleF rect) : base(rect)
        {
        }

        public Square(RectangleShape rectangle) : base(rectangle)
        {
        }

        public override RectangleF Rectangle { get => base.Rectangle; set => base.Rectangle = value; }
        public override float Width { get => base.Width; set => base.Width = value; }
        public override float Height { get => base.Height; set => base.Height = value; }
        public override PointF Location { get => base.Location; set => base.Location = value; }
        public override Color FillColor { get => base.FillColor; set => base.FillColor = value; }

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(Pens.Purple, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

        }
    }
}
