namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBorderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBorderWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFillColorByShapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBorderColorByShapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaneBorderWidthByShapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllRectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllEllipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllSquaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectByShapeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawPointSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawSquareSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.ChangeColorButton = new System.Windows.Forms.ToolStripButton();
            this.RotateShapeButton = new System.Windows.Forms.ToolStripButton();
            this.ChangeBorderColorButton = new System.Windows.Forms.ToolStripButton();
            this.ResizeShapeButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteShapeButton = new System.Windows.Forms.ToolStripButton();
            this.CreateGroupButton = new System.Windows.Forms.ToolStripButton();
            this.UpGroupSelectedButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.selectOptionsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(924, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeShapeToolStripMenuItem,
            this.changeFillColorToolStripMenuItem,
            this.changeBorderColorToolStripMenuItem,
            this.changeBorderWidthToolStripMenuItem,
            this.shapeNameToolStripMenuItem,
            this.changeFillColorByShapeNameToolStripMenuItem,
            this.changeBorderColorByShapeNameToolStripMenuItem,
            this.chaneBorderWidthByShapeNameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resizeShapeToolStripMenuItem
            // 
            this.resizeShapeToolStripMenuItem.Name = "resizeShapeToolStripMenuItem";
            this.resizeShapeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.resizeShapeToolStripMenuItem.Text = "Resize Shape";
            this.resizeShapeToolStripMenuItem.Click += new System.EventHandler(this.resizeShapeToolStripMenuItem_Click);
            // 
            // changeFillColorToolStripMenuItem
            // 
            this.changeFillColorToolStripMenuItem.Name = "changeFillColorToolStripMenuItem";
            this.changeFillColorToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.changeFillColorToolStripMenuItem.Text = "Change Fill Color";
            this.changeFillColorToolStripMenuItem.Click += new System.EventHandler(this.changeFillColorToolStripMenuItem_Click);
            // 
            // changeBorderColorToolStripMenuItem
            // 
            this.changeBorderColorToolStripMenuItem.Name = "changeBorderColorToolStripMenuItem";
            this.changeBorderColorToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.changeBorderColorToolStripMenuItem.Text = "Change Border Color";
            this.changeBorderColorToolStripMenuItem.Click += new System.EventHandler(this.changeBorderColorToolStripMenuItem_Click);
            // 
            // changeBorderWidthToolStripMenuItem
            // 
            this.changeBorderWidthToolStripMenuItem.Name = "changeBorderWidthToolStripMenuItem";
            this.changeBorderWidthToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.changeBorderWidthToolStripMenuItem.Text = "Change Border Width";
            this.changeBorderWidthToolStripMenuItem.Click += new System.EventHandler(this.changeBorderWidthToolStripMenuItem_Click);
            // 
            // shapeNameToolStripMenuItem
            // 
            this.shapeNameToolStripMenuItem.Name = "shapeNameToolStripMenuItem";
            this.shapeNameToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.shapeNameToolStripMenuItem.Text = "Shape Name";
            this.shapeNameToolStripMenuItem.Click += new System.EventHandler(this.shapeNameToolStripMenuItem_Click);
            // 
            // changeFillColorByShapeNameToolStripMenuItem
            // 
            this.changeFillColorByShapeNameToolStripMenuItem.Name = "changeFillColorByShapeNameToolStripMenuItem";
            this.changeFillColorByShapeNameToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.changeFillColorByShapeNameToolStripMenuItem.Text = "Change FillColor by Shape Name";
            this.changeFillColorByShapeNameToolStripMenuItem.Click += new System.EventHandler(this.changeFillColorByShapeNameToolStripMenuItem_Click);
            // 
            // changeBorderColorByShapeNameToolStripMenuItem
            // 
            this.changeBorderColorByShapeNameToolStripMenuItem.Name = "changeBorderColorByShapeNameToolStripMenuItem";
            this.changeBorderColorByShapeNameToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.changeBorderColorByShapeNameToolStripMenuItem.Text = "Change BorderColor by Shape Name";
            this.changeBorderColorByShapeNameToolStripMenuItem.Click += new System.EventHandler(this.changeBorderColorByShapeNameToolStripMenuItem_Click);
            // 
            // chaneBorderWidthByShapeNameToolStripMenuItem
            // 
            this.chaneBorderWidthByShapeNameToolStripMenuItem.Name = "chaneBorderWidthByShapeNameToolStripMenuItem";
            this.chaneBorderWidthByShapeNameToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.chaneBorderWidthByShapeNameToolStripMenuItem.Text = "Change BorderWidth by Shape Name";
            this.chaneBorderWidthByShapeNameToolStripMenuItem.Click += new System.EventHandler(this.chaneBorderWidthByShapeNameToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.pointToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.shapesToolStripMenuItem.Text = "Insert Shapes";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // selectOptionsToolStripMenuItem
            // 
            this.selectOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllRectanglesToolStripMenuItem,
            this.selectAllEllipsesToolStripMenuItem,
            this.selectAllSquaresToolStripMenuItem,
            this.selectAllPointsToolStripMenuItem,
            this.selectAllCirclesToolStripMenuItem,
            this.selectByShapeNameToolStripMenuItem});
            this.selectOptionsToolStripMenuItem.Name = "selectOptionsToolStripMenuItem";
            this.selectOptionsToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.selectOptionsToolStripMenuItem.Text = "Select Options";
            // 
            // selectAllRectanglesToolStripMenuItem
            // 
            this.selectAllRectanglesToolStripMenuItem.Name = "selectAllRectanglesToolStripMenuItem";
            this.selectAllRectanglesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectAllRectanglesToolStripMenuItem.Text = "Select All Rectangles";
            this.selectAllRectanglesToolStripMenuItem.Click += new System.EventHandler(this.selectAllRectanglesToolStripMenuItem_Click);
            // 
            // selectAllEllipsesToolStripMenuItem
            // 
            this.selectAllEllipsesToolStripMenuItem.Name = "selectAllEllipsesToolStripMenuItem";
            this.selectAllEllipsesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectAllEllipsesToolStripMenuItem.Text = "Select All Ellipses";
            this.selectAllEllipsesToolStripMenuItem.Click += new System.EventHandler(this.selectAllEllipsesToolStripMenuItem_Click);
            // 
            // selectAllSquaresToolStripMenuItem
            // 
            this.selectAllSquaresToolStripMenuItem.Name = "selectAllSquaresToolStripMenuItem";
            this.selectAllSquaresToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectAllSquaresToolStripMenuItem.Text = "Select All Squares";
            this.selectAllSquaresToolStripMenuItem.Click += new System.EventHandler(this.selectAllSquaresToolStripMenuItem_Click);
            // 
            // selectAllPointsToolStripMenuItem
            // 
            this.selectAllPointsToolStripMenuItem.Name = "selectAllPointsToolStripMenuItem";
            this.selectAllPointsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectAllPointsToolStripMenuItem.Text = "Select All Points";
            this.selectAllPointsToolStripMenuItem.Click += new System.EventHandler(this.selectAllPointsToolStripMenuItem_Click);
            // 
            // selectAllCirclesToolStripMenuItem
            // 
            this.selectAllCirclesToolStripMenuItem.Name = "selectAllCirclesToolStripMenuItem";
            this.selectAllCirclesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectAllCirclesToolStripMenuItem.Text = "Select All Circles";
            this.selectAllCirclesToolStripMenuItem.Click += new System.EventHandler(this.selectAllCirclesToolStripMenuItem_Click);
            // 
            // selectByShapeNameToolStripMenuItem
            // 
            this.selectByShapeNameToolStripMenuItem.Name = "selectByShapeNameToolStripMenuItem";
            this.selectByShapeNameToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.selectByShapeNameToolStripMenuItem.Text = "Select by Shape Name";
            this.selectByShapeNameToolStripMenuItem.Click += new System.EventHandler(this.selectByShapeNameToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            this.statusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusBar_ItemClicked);
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.DrawLineSpeedButton,
            this.DrawEllipseSpeedButton,
            this.DrawCircleSpeedButton,
            this.DrawPointSpeedButton,
            this.DrawSquareSpeedButton,
            this.ChangeColorButton,
            this.RotateShapeButton,
            this.ChangeBorderColorButton,
            this.ResizeShapeButton,
            this.pickUpSpeedButton,
            this.DeleteShapeButton,
            this.CreateGroupButton,
            this.UpGroupSelectedButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.drawRectangleSpeedButton.Text = "Draw Random Rectangle Button";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // DrawLineSpeedButton
            // 
            this.DrawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineSpeedButton.Image = global::Draw.Properties.Resources.line_simple;
            this.DrawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawLineSpeedButton.Name = "DrawLineSpeedButton";
            this.DrawLineSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.DrawLineSpeedButton.Text = "Draw Random Line Button";
            this.DrawLineSpeedButton.Click += new System.EventHandler(this.DrawLineSpeedButtonClick);
            // 
            // DrawEllipseSpeedButton
            // 
            this.DrawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawEllipseSpeedButton.Image = global::Draw.Properties.Resources.ellipse_shape1;
            this.DrawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawEllipseSpeedButton.Name = "DrawEllipseSpeedButton";
            this.DrawEllipseSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.DrawEllipseSpeedButton.Text = "Draw Random Ellipse Button";
            this.DrawEllipseSpeedButton.Click += new System.EventHandler(this.DrawEllipseSpeedButtonClick);
            // 
            // DrawCircleSpeedButton
            // 
            this.DrawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawCircleSpeedButton.Image = global::Draw.Properties.Resources.circle;
            this.DrawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawCircleSpeedButton.Name = "DrawCircleSpeedButton";
            this.DrawCircleSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.DrawCircleSpeedButton.Text = "Draw Circle Button";
            this.DrawCircleSpeedButton.Click += new System.EventHandler(this.DrawCircleSpeedButtonClick);
            // 
            // DrawPointSpeedButton
            // 
            this.DrawPointSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawPointSpeedButton.Image = global::Draw.Properties.Resources.point;
            this.DrawPointSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawPointSpeedButton.Name = "DrawPointSpeedButton";
            this.DrawPointSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.DrawPointSpeedButton.Text = "Draw Random Point Button";
            this.DrawPointSpeedButton.Click += new System.EventHandler(this.DrawPointSpeedButtonClick);
            // 
            // DrawSquareSpeedButton
            // 
            this.DrawSquareSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawSquareSpeedButton.Image = global::Draw.Properties.Resources.square;
            this.DrawSquareSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawSquareSpeedButton.Name = "DrawSquareSpeedButton";
            this.DrawSquareSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.DrawSquareSpeedButton.Text = "Draw Random Square Button";
            this.DrawSquareSpeedButton.Click += new System.EventHandler(this.DrawSquareSpeedButtonClick);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeColorButton.Image = global::Draw.Properties.Resources.paint;
            this.ChangeColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(29, 24);
            this.ChangeColorButton.Text = "Change Color Button";
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButtonCLick);
            // 
            // RotateShapeButton
            // 
            this.RotateShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateShapeButton.Image = global::Draw.Properties.Resources.rotate;
            this.RotateShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateShapeButton.Name = "RotateShapeButton";
            this.RotateShapeButton.Size = new System.Drawing.Size(29, 24);
            this.RotateShapeButton.Text = "RotateShapeButton";
            this.RotateShapeButton.Click += new System.EventHandler(this.RotateShapeSpeedButtonCLick);
            // 
            // ChangeBorderColorButton
            // 
            this.ChangeBorderColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeBorderColorButton.Image = global::Draw.Properties.Resources.change_border_color;
            this.ChangeBorderColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeBorderColorButton.Name = "ChangeBorderColorButton";
            this.ChangeBorderColorButton.Size = new System.Drawing.Size(29, 24);
            this.ChangeBorderColorButton.Text = "Change Border Color Button";
            this.ChangeBorderColorButton.Click += new System.EventHandler(this.ChangeBorderColorButtonCLick);
            // 
            // ResizeShapeButton
            // 
            this.ResizeShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResizeShapeButton.Image = global::Draw.Properties.Resources.resize;
            this.ResizeShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResizeShapeButton.Name = "ResizeShapeButton";
            this.ResizeShapeButton.Size = new System.Drawing.Size(29, 24);
            this.ResizeShapeButton.Text = "Resize Shape Button";
            this.ResizeShapeButton.Click += new System.EventHandler(this.ResizeShapeButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "pick Up Button";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // DeleteShapeButton
            // 
            this.DeleteShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteShapeButton.Image = global::Draw.Properties.Resources.bin11;
            this.DeleteShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteShapeButton.Name = "DeleteShapeButton";
            this.DeleteShapeButton.Size = new System.Drawing.Size(29, 24);
            this.DeleteShapeButton.Text = "Delete Shape Button";
            this.DeleteShapeButton.Click += new System.EventHandler(this.DeleteShapeButtonClick);
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateGroupButton.Image = global::Draw.Properties.Resources.group;
            this.CreateGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(29, 24);
            this.CreateGroupButton.Text = "Create Group Button";
            this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButtonCLick);
            // 
            // UpGroupSelectedButton
            // 
            this.UpGroupSelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpGroupSelectedButton.Image = global::Draw.Properties.Resources.ungroup;
            this.UpGroupSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpGroupSelectedButton.Name = "UpGroupSelectedButton";
            this.UpGroupSelectedButton.Size = new System.Drawing.Size(29, 24);
            this.UpGroupSelectedButton.Text = "UpGroup Selected Butтon";
            this.UpGroupSelectedButton.Click += new System.EventHandler(this.UpGroupSelectedButtonClick);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 444);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton DrawEllipseSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawLineSpeedButton;
        //private System.Windows.Forms.ToolStripButton DrawPolygonSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawPointSpeedButton;
        private System.Windows.Forms.ToolStripButton ChangeColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        //private System.Windows.Forms.ToolStripButton SelectAllButton;
        private System.Windows.Forms.ToolStripButton DrawSquareSpeedButton;
        private System.Windows.Forms.ToolStripButton RotateShapeButton;
        private System.Windows.Forms.ToolStripButton ChangeBorderColorButton;
        private System.Windows.Forms.ToolStripButton CreateGroupButton;
        private System.Windows.Forms.ToolStripButton ResizeShapeButton;
        private System.Windows.Forms.ToolStripMenuItem resizeShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBorderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBorderWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton DeleteShapeButton;
        private System.Windows.Forms.ToolStripButton UpGroupSelectedButton;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton DrawCircleSpeedButton;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllRectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllEllipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllSquaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllCirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectByShapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFillColorByShapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBorderColorByShapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaneBorderWidthByShapeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    }
}
