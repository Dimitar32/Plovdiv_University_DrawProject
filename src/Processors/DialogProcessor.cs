using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

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
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
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

		private Color blackColor = Color.Black;
		private Color whiteColor = Color.White;
		private float defaultWidth = 3;
		#endregion

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
			rect.FillColor = whiteColor;
			rect.BorderColor = blackColor;
			rect.BorderWidth = defaultWidth;

			ShapeList.Add(rect);
		}

		public void AddRandomSquare()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			SquareShape square = new SquareShape(new Rectangle(x, y, 100, 100));
			square.FillColor = whiteColor;
			square.BorderColor = blackColor;
			square.BorderWidth = defaultWidth;

			ShapeList.Add(square);
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
			for (int i = ShapeList.Count - 1; i >= 0; i--) {
				if (ShapeList[i].Contains(point)) {
					ShapeList[i].ChangeFillColor(Color.Red);

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
			foreach (Shape shape in Selection)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("GroupShape"))
                {
                    shape.MoveGroupedShape(p.X - lastLocation.X, p.Y - lastLocation.Y);
                }
                else
				{
                    shape.Location = new PointF(shape.Location.X + p.X - lastLocation.X, shape.Location.Y + p.Y - lastLocation.Y);
				}

			}

			lastLocation = p;
		}

		//public void SelectAll()
		//{
		//	if (SelectAllButton.Checked)
		//	foreach (Shape shape in ShapeList)
		//	{
		//		Selection.Add(shape);
		//		shape.FillColor = Color.Red;
		//	}
		//}

		public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
			ellipse.FillColor = whiteColor;
			ellipse.BorderColor = blackColor;
			ellipse.BorderWidth = defaultWidth;

			ShapeList.Add(ellipse);
		}

		public void AddRandomLine()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			LineShape line = new LineShape(new Rectangle(x, y, 100, 200));
			line.FillColor = blackColor;
			line.BorderColor = blackColor;
			line.BorderWidth = defaultWidth;

			ShapeList.Add(line);
		}

		public void AddRandomPoint()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			PointShape point = new PointShape(new Rectangle(x, y, 100, 200));
			point.FillColor = whiteColor;
			point.BorderColor = blackColor;
			point.BorderWidth = defaultWidth;

			ShapeList.Add(point);
		}

		public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            CircleShape circle = new CircleShape(new EllipseShape(new Rectangle(x, y, 100, 200)));
            circle.FillColor = whiteColor;
            circle.BorderColor = blackColor;
            circle.BorderWidth = defaultWidth;

            ShapeList.Add(circle);
        }


        public void Rotate()
		{
			if (selection.Count != 0)
			{
				foreach (Shape shape in selection)
				{
					shape.Matrix.Rotate(3);
				}
			}
		}

		public void CreateGroupShapeFromSelection()
		{
			if (selection.Count <= 1)
				return;

			GroupShape groupShape = new GroupShape(selection);

			foreach (Shape shape in selection)
			{
				ShapeList.Remove(shape);
			}

			groupShape.ChangeFillColor(Color.Pink);

			selection = new List<Shape>();
			ShapeList.Add(groupShape);
			selection.Add(groupShape);
		}

		public void UnGroupSelected()
		{
			List<Shape> shapesFromGroup = new List<Shape>();
			foreach (Shape shape in selection)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("GroupShape"))
				{
					GroupShape gs = (GroupShape)shape;
					foreach (Shape shape2 in gs.GroupShapes)
					{
						shapesFromGroup.Add(shape2);
						ShapeList.Add(shape2);
					}

					gs.GroupShapes.Clear();
					ShapeList.Remove(shape);
				}
			}
			selection.Clear();
		}

		public void ResizeShape(int width, int height)
		{
			foreach (Shape shape in selection)
			{
				shape.Resize(width, height);
			}
		}

		public void DeleteShapesFromSelection()
		{
			foreach (Shape shape in selection)
			{
				ShapeList.Remove(shape);
			}

			Selection.Clear();
		}

		public void AddNameToObjectsFromSelection(string name)
		{
			foreach (Shape shape in selection)
			{
				shape.Name = name;
			}
		}

		public void SelectAllRectangles()
		{
			foreach (Shape shape in Selection)
			{
				shape.ChangeFillColor(Color.White);
			}

			Selection.Clear();

			foreach (Shape shape in ShapeList)
			{
				string shapeType = shape.GetType().Name.ToString();
				if (shapeType.Equals("RectangleShape"))
				{
					Selection.Add(shape);
                    shape.ChangeFillColor(Color.Red);
                }
			}
		}

        public void SelectAllEllipses()
        {
            foreach (Shape shape in Selection)
            {
                shape.ChangeFillColor(Color.White);
            }

            Selection.Clear();

            foreach (Shape shape in ShapeList)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("EllipseShape"))
                {
                    Selection.Add(shape);
                    shape.ChangeFillColor(Color.Red);
                }
            }
        }

		public void SelectAllCircles()
        {
            foreach (Shape shape in Selection)
            {
                shape.ChangeFillColor(Color.White);
            }

            Selection.Clear();

            foreach (Shape shape in ShapeList)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("CircleShape"))
                {
                    Selection.Add(shape);
                    shape.ChangeFillColor(Color.Red);
                }
            }
        }

        public void SelectAllPoints()
        {
            foreach (Shape shape in Selection)
            {
                shape.ChangeFillColor(Color.White);
            }

            Selection.Clear();

            foreach (Shape shape in ShapeList)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("PointShape"))
                {
                    Selection.Add(shape);
					shape.ChangeFillColor(Color.Red);
                }
            }
        }

        public void SelectAllSquares()
        {
            foreach (Shape shape in Selection)
            {
                shape.ChangeFillColor(Color.White);
            }

            Selection.Clear();

            foreach (Shape shape in ShapeList)
            {
                string shapeType = shape.GetType().Name.ToString();
                if (shapeType.Equals("SquareShape"))
                {
                    Selection.Add(shape);
                    shape.ChangeFillColor(Color.Red);
                }
            }
        }

		public void SelectByShapeName(string name)
        {
            foreach (Shape shape in Selection)
            {
                shape.ChangeFillColor(Color.White);
            }

            Selection.Clear();

            foreach (Shape shape in ShapeList)
            {
                if (shape.Name.Equals(name))
                {
                    Selection.Add(shape);
                    shape.ChangeFillColor(Color.Red);
                }
            }
        }

        public void SaveFile(object obj, string path = null)
        {
            Stream stream;
            IFormatter formatter = new BinaryFormatter();

            if (path == null)
            {
                stream = new FileStream("DrawFile.asd", FileMode.Create, FileAccess.Write, FileShare.None);
            }
            else
            {
                string preparePath = path + ".asd";
                stream = new FileStream(preparePath, FileMode.Create);
            }

            formatter.Serialize(stream, obj);
            stream.Close();
        }
    }
}
