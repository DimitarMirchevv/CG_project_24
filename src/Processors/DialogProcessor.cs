using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>

        
        private Shape selection;
       public Shape Selection
       {
           get { return selection; }
           set { selection = value; }
       }
        
        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		

		//Rectange
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}

		//Ellipse 
        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

		//Square
        public void AddRandomSquare()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            Square sq = new Square(new Rectangle(x, y, 100, 100));
            sq.FillColor = Color.White;

            ShapeList.Add(sq);
        }

        //Line
        public void AddRandomLine()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 500);

            Line ln = new Line(new Rectangle(x, y, 100, 250));

            ShapeList.Add(ln);
        }

        //Circle
        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            CircleShape circlee = new CircleShape(new Rectangle(x, y, 100, 100));
            circlee.FillColor = Color.White;

            ShapeList.Add(circlee);
        }

        //Point
        public void AddRandomPoint()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            PointShape point = new PointShape(new Rectangle(x, y, 9, 9));
            point.FillColor = Color.Black;
            //point.BorderWidth = currentWidth;
            ShapeList.Add(point);
        }

        //         --------------------------------
        public void AddRandomRectangleX()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectX rectX = new RectX(new Rectangle(x, y, 200, 100));
            rectX.FillColor = Color.White;
            rectX.BorderColor = Color.Black;
            rectX.Opacity = 255;

            ShapeList.Add(rectX);
        }



        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					ShapeList[i].FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			if (selection != null) {
				selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, 
                    selection.Location.Y + p.Y - lastLocation.Y);
				lastLocation = p;
			}
		}

 

        public void DeleteSelectedShape()
        {
            if (selection != null)
            {
                ShapeList.Remove(selection);
                selection = null; // Нулиране на selection след изтриване
            }
        }





    }
}
