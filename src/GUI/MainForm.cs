using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked /*|| SelectAllButton.Checked*/) {
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null)
				{
					if (dialogProcessor.Selection.Contains(sel))
					{
						dialogProcessor.Selection.Remove(sel);
						sel.ChangeFillColor(Color.White);
					}
					else
					{
						dialogProcessor.Selection.Add(sel);
						sel.ChangeFillColor(Color.Red);
					}
				}

				statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
				dialogProcessor.IsDragging = true;
				dialogProcessor.LastLocation = e.Location;
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		private void DrawEllipseSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}

		private void DrawLineSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на линия";

			viewPort.Invalidate();

		}

		private void DrawPointSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomPoint();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}

		private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void ChangeColorButtonCLick(object sender, EventArgs e)
		{
			foreach (Shape shape in dialogProcessor.Selection)
			{
				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					shape.ChangeFillColor(colorDialog1.Color);
					viewPort.Invalidate();
				}
			}
		}

		//private void SelectAllButtonClick(object sender, EventArgs e)
		//{
		//    dialogProcessor.SelectAll();

		//    statusBar.Items[0].Text = "Последно действие: селектиране на всички";

		//    viewPort.Invalidate();
		//}

		private void DrawSquareSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();

		}

		private void pickUpSpeedButton_Click(object sender, EventArgs e)
		{

		}

		private void viewPort_Load(object sender, EventArgs e)
		{

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void RotateShapeSpeedButtonCLick(object sender, EventArgs e)
		{
			//dialogProcessor.Rotate();

			statusBar.Items[0].Text = "Последно действие: Ротация на фигурата";

			viewPort.Invalidate();
		}

		private void ChangeBorderColorButtonCLick(object sender, EventArgs e)
		{
			foreach (Shape shape in dialogProcessor.Selection)
			{
				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					shape.ChangeBorderColor(colorDialog1.Color);
					viewPort.Invalidate();
				}
			}
		}

		private void ChangeBorderWidthCLick(object sender, EventArgs e)
		{
			foreach (Shape shape in dialogProcessor.Selection)
			{
				string numberDialog = Interaction.InputBox("Enter integer number", "Input Number for Border Width Box", "", 500, 300);
				if (int.TryParse(numberDialog, out int n))
				{
					shape.ChangeBorderWidth(n);
				}
				else
				{
					Interaction.MsgBox("Enter INTEGER number, please!", new MsgBoxStyle(), "Incorect input number message box");

				}
			}

			statusBar.Items[0].Text = "Последно действие: Промяна дебелината на рамката";
			viewPort.Invalidate();
		}

		private void CreateGroupButtonCLick(object sender, EventArgs e)
		{
			dialogProcessor.CreateGroupShapeFromSelection();

			statusBar.Items[0].Text = "Последно действие: Създаване на група";

			viewPort.Invalidate();
		}

		private void ResizeShapeButtonClick(object sender, EventArgs e)
		{
			string numberDialogWidth = Interaction.InputBox("Enter integer number", "Input Number for Shape Width Box", "", 500, 300);
			string numberDialogHeight = Interaction.InputBox("Enter integer number", "Input Number for Shape Height Box", "", 500, 300);
			foreach (Shape shape in dialogProcessor.Selection)
			{
				if (int.TryParse(numberDialogWidth, out int shapeWidth) && int.TryParse(numberDialogHeight, out int shapeHeight))
				{
					dialogProcessor.ResizeShape(shapeWidth, shapeHeight);
				}
				else
				{
					Interaction.MsgBox("Enter INTEGER number, please!", new MsgBoxStyle(), "Incorect input number message box");

				}
			}

			statusBar.Items[0].Text = "Последно действие: Промяна размера на фигура";

			viewPort.Invalidate();

		}

		private void resizeShapeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ResizeShapeButtonClick(sender, e);
		}

		private void changeFillColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeColorButtonCLick(sender, e);
		}

		private void changeBorderColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeBorderColorButtonCLick(sender, e);
		}

		private void changeBorderWidthToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeBorderWidthCLick(sender, e);
		}

		private void DeleteShapeButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.DeleteShapesFromSelection();

			statusBar.Items[0].Text = "Последно действие: Триене на обект";

			viewPort.Invalidate();
		}

		private void UpGroupSelectedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.UnGroupSelected();

            statusBar.Items[0].Text = "Последно действие: Разгрупиране на обекти";

            viewPort.Invalidate();

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawRectangleSpeedButtonClick(sender, e);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawEllipseSpeedButtonClick(sender, e);
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawLineSpeedButtonClick(sender, e);
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawPointSpeedButtonClick(sender, e);
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawSquareSpeedButtonClick(sender, e);
        }

        private void DrawCircleSpeedButtonClick(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Добавяне на кръг";

            viewPort.Invalidate();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.DrawCircleSpeedButtonClick(sender, e);
        }

        private void shapeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Shape shape in dialogProcessor.Selection)
			{
				string nameBox = Interaction.InputBox("Enter name for your shape", "Name Box", "", 500, 300);
				shape.Name = nameBox;

                statusBar.Items[0].Text = "Последно действие: Добавяне на име на фигурата";

                viewPort.Invalidate();
            }
        }

        private void selectAllRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.SelectAllRectangles();

            statusBar.Items[0].Text = "Последно действие: Селектиране на всички правоъгълници";

            viewPort.Invalidate();
        }

        private void selectAllEllipsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAllEllipses();

            statusBar.Items[0].Text = "Последно действие: Селектиране на всички правоъгълници";

            viewPort.Invalidate();
        }

        private void selectAllSquaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAllSquares();

            statusBar.Items[0].Text = "Последно действие: Селектиране на всички правоъгълници";

            viewPort.Invalidate();
        }

        private void selectAllPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAllPoints();

            statusBar.Items[0].Text = "Последно действие: Селектиране на всички правоъгълници";

            viewPort.Invalidate();
        }

        private void selectAllCirclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAllCircles();

            statusBar.Items[0].Text = "Последно действие: Селектиране на всички правоъгълници";

            viewPort.Invalidate();
        }

        private void selectByShapeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string nameBox = Interaction.InputBox("Enter shape name you want to select", "Name Box", "", 500, 300);
            
			dialogProcessor.SelectByShapeName(nameBox);

            statusBar.Items[0].Text = "Последно действие: Селектиране по име";

            viewPort.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string fileName = Interaction.InputBox("Enter name for the file", "File Name Box", "", 500, 300);


            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dialogProcessor.SaveFile((List<Shape>)dialogProcessor.ShapeList, sfd.FileName);
            }

            statusBar.Items[0].Text = "Последно действие: Записване на файл.";
        }

        private void changeFillColorByShapeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string shapeName = Interaction.InputBox("Enter shape name whose color we will change", "Change FillColor by Name Box", "", 500, 300);

			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach (Shape shape in dialogProcessor.ShapeList)
				{
					if (shape.Name == shapeName)
					{
						shape.ChangeFillColor(colorDialog1.Color);
						viewPort.Invalidate();

					}
				}
			}

            statusBar.Items[0].Text = "Последно действие: Промяна на цвета по име на фигура";

            viewPort.Invalidate();
        }

        private void chaneBorderWidthByShapeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string shapeName = Interaction.InputBox("Enter shape name whose borde width we will change", "Change BorderWidth by Name Box", "", 500, 300);

			string bordeWidth = Interaction.InputBox("Enter width with integer", "Change BorderWidth Box", "", 500, 300);

            foreach (Shape shape in dialogProcessor.ShapeList)
            {
                if (shape.Name == shapeName)
                {
					if (int.TryParse(bordeWidth, out int n))
					{
						shape.ChangeBorderWidth(n);
						viewPort.Invalidate();
                    }
                    else
                    {
                        Interaction.MsgBox("Enter INTEGER number, please!", new MsgBoxStyle(), "Incorect input number message box");
                    }

                }
            }

            statusBar.Items[0].Text = "Последно действие: Промяна на дебелината на рамката по име на фигура";

            viewPort.Invalidate();
        }

        private void changeBorderColorByShapeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string shapeName = Interaction.InputBox("Enter shape name whose border color we will change", "Change BorderColor by Name Box", "", 500, 300);

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Shape shape in dialogProcessor.ShapeList)
                {
                    if (shape.Name == shapeName)
                    {
                        shape.ChangeBorderColor(colorDialog1.Color);
                        viewPort.Invalidate();

                    }
                }
            }

            statusBar.Items[0].Text = "Последно действие: Промяна на цвета на рамката по име на фигура";

            viewPort.Invalidate();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dialogProcessor.ShapeList = (List<Shape>)dialogProcessor.LoadFile(ofd.FileName);
                viewPort.Invalidate();
            }

            statusBar.Items[0].Text = "Последно действие: Отваряне на файл.";
        }
    }
}
