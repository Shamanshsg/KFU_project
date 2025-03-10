namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.color_picker = new System.Windows.Forms.Button();
            this.ColorPalate = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ThicknessBar = new System.Windows.Forms.TrackBar();
            this.Thickval = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elpseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // color_picker
            // 
            this.color_picker.Location = new System.Drawing.Point(655, 26);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(169, 55);
            this.color_picker.TabIndex = 0;
            this.color_picker.Text = "Pick Color";
            this.color_picker.UseVisualStyleBackColor = true;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(7, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 438);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ThicknessBar
            // 
            this.ThicknessBar.Location = new System.Drawing.Point(655, 87);
            this.ThicknessBar.Maximum = 20;
            this.ThicknessBar.Minimum = 1;
            this.ThicknessBar.Name = "ThicknessBar";
            this.ThicknessBar.Size = new System.Drawing.Size(169, 45);
            this.ThicknessBar.TabIndex = 2;
            this.ThicknessBar.Value = 5;
            this.ThicknessBar.Scroll += new System.EventHandler(this.Thickness_Scroll);
            // 
            // Thickval
            // 
            this.Thickval.AutoSize = true;
            this.Thickval.Location = new System.Drawing.Point(665, 135);
            this.Thickval.Name = "Thickval";
            this.Thickval.Size = new System.Drawing.Size(74, 14);
            this.Thickval.TabIndex = 3;
            this.Thickval.Text = "Thickness: 5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.figuresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eraseToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eraseToolStripMenuItem.Text = "Erase";
            this.eraseToolStripMenuItem.Click += new System.EventHandler(this.eraseToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Checked = true;
            this.brushToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // figuresToolStripMenuItem
            // 
            this.figuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.elpseToolStripMenuItem});
            this.figuresToolStripMenuItem.Name = "figuresToolStripMenuItem";
            this.figuresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.figuresToolStripMenuItem.Text = "Figures";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // elpseToolStripMenuItem
            // 
            this.elpseToolStripMenuItem.Name = "elpseToolStripMenuItem";
            this.elpseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elpseToolStripMenuItem.Text = "Elpse";
            this.elpseToolStripMenuItem.Click += new System.EventHandler(this.elpseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 478);
            this.Controls.Add(this.Thickval);
            this.Controls.Add(this.ThicknessBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.color_picker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button color_picker;
        private ColorDialog ColorPalate;
        private PictureBox pictureBox1;
        private TrackBar ThicknessBar;
        private Label Thickval;
        private CheckBox Erase;
        private CheckBox Brush;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem eraseToolStripMenuItem;
        private ToolStripMenuItem brushToolStripMenuItem;
        private ToolStripMenuItem figuresToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem elpseToolStripMenuItem;
    }
}