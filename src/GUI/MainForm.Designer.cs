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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.SquareShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircleDraw = new System.Windows.Forms.ToolStripButton();
            this.colorPickerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPoint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawLine = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleX = new System.Windows.Forms.ToolStripButton();
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
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(924, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
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
            this.pickUpSpeedButton,
            this.toolStripButtonEllipse,
            this.SquareShape,
            this.toolStripButtonCircle,
            this.toolStripButtonCircleDraw,
            this.colorPickerBtn,
            this.toolStripButtonPoint,
            this.toolStripButtonDrawLine,
            this.DeleteButton,
            this.RectangleX});
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
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEllipse.Text = "toolStripButton1";
            this.toolStripButtonEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SquareShape
            // 
            this.SquareShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SquareShape.Image = ((System.Drawing.Image)(resources.GetObject("SquareShape.Image")));
            this.SquareShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SquareShape.Name = "SquareShape";
            this.SquareShape.Size = new System.Drawing.Size(29, 24);
            this.SquareShape.Text = "toolStripButton1";
            this.SquareShape.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCircle.Text = "toolStripButton2";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButtonCircleDraw
            // 
            this.toolStripButtonCircleDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCircleDraw.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircleDraw.Image")));
            this.toolStripButtonCircleDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircleDraw.Name = "toolStripButtonCircleDraw";
            this.toolStripButtonCircleDraw.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCircleDraw.Text = "toolStripButton2";
            this.toolStripButtonCircleDraw.Click += new System.EventHandler(this.toolStripButtonCircleDraw_Click);
            // 
            // colorPickerBtn
            // 
            this.colorPickerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPickerBtn.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerBtn.Image")));
            this.colorPickerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPickerBtn.Name = "colorPickerBtn";
            this.colorPickerBtn.Size = new System.Drawing.Size(29, 24);
            this.colorPickerBtn.Text = "toolStripButton2";
            this.colorPickerBtn.ToolTipText = "colorPicker";
            this.colorPickerBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonPoint
            // 
            this.toolStripButtonPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPoint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPoint.Image")));
            this.toolStripButtonPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPoint.Name = "toolStripButtonPoint";
            this.toolStripButtonPoint.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPoint.Text = "toolStripButtonPoint";
            this.toolStripButtonPoint.Click += new System.EventHandler(this.toolStripButtonPoint_Click);
            // 
            // toolStripButtonDrawLine
            // 
            this.toolStripButtonDrawLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawLine.Image")));
            this.toolStripButtonDrawLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawLine.Name = "toolStripButtonDrawLine";
            this.toolStripButtonDrawLine.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDrawLine.Text = "toolStripButton2";
            this.toolStripButtonDrawLine.Click += new System.EventHandler(this.toolStripButtonDrawLine_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(29, 24);
            this.DeleteButton.Text = "DeleteButton";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RectangleX
            // 
            this.RectangleX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleX.Image = ((System.Drawing.Image)(resources.GetObject("RectangleX.Image")));
            this.RectangleX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleX.Name = "RectangleX";
            this.RectangleX.Size = new System.Drawing.Size(29, 24);
            this.RectangleX.Text = "RectangleX";
            this.RectangleX.Click += new System.EventHandler(this.RectangleX_Click_2);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 444);
            this.viewPort.TabIndex = 4;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton SquareShape;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircleDraw;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawLine;
        private System.Windows.Forms.ToolStripButton colorPickerBtn;
        private System.Windows.Forms.ToolStripButton toolStripButtonPoint;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RectangleX;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
