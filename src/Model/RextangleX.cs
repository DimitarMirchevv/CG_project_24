using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;

namespace Draw.src.Model
{
    class RectX : Shape
    {
        #region Constructor

        public RectX(RectangleF rect) : base(rect)
        {
        }

        public RectX(RectangleShape rectangle) : base(rectangle)
        {
        }

        public Color BorderColor { get;  set; }
        public int Opacity { get;  set; }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
      
            public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            
            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

           //RecBorder
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            //center of the rectangle
            Point center = new Point((int)(Rectangle.X + Rectangle.Width / 2), (int)(Rectangle.Y + Rectangle.Height / 2));

            Point p1 = new Point((int)(Rectangle.X + Rectangle.Width), (int)Rectangle.Y); 
            Point p2 = new Point((int)(Rectangle.X + Rectangle.Width), (int)(Rectangle.Y + Rectangle.Height)); 
            Point p3 = new Point((int)Rectangle.X, (int)(Rectangle.Y + Rectangle.Height / 2)); 

            grfx.DrawLine(new Pen(BorderColor, BorderWidth), p1, center);
            grfx.DrawLine(new Pen(BorderColor, BorderWidth), p2, center);
            grfx.DrawLine(new Pen(BorderColor, BorderWidth), p3, center);
   
            grfx.ResetTransform();


        }
    }
}

