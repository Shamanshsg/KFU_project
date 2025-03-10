namespace TextProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextInput = new System.Windows.Forms.RichTextBox();
            this.TextOutput = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.Button();
            this.Letters = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Setntence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.wordsSent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lng = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextInput.Location = new System.Drawing.Point(16, 162);
            this.TextInput.Margin = new System.Windows.Forms.Padding(4);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(497, 406);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "";
            this.TextInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TextOutput
            // 
            this.TextOutput.FormattingEnabled = true;
            this.TextOutput.ItemHeight = 16;
            this.TextOutput.Location = new System.Drawing.Point(527, 167);
            this.TextOutput.Margin = new System.Windows.Forms.Padding(4);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(496, 404);
            this.TextOutput.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(16, 33);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(109, 121);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Words
            // 
            this.Words.Location = new System.Drawing.Point(307, 36);
            this.Words.Margin = new System.Windows.Forms.Padding(4);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(113, 58);
            this.Words.TabIndex = 6;
            this.Words.Text = "Подсчет слов";
            this.Words.UseVisualStyleBackColor = true;
            this.Words.Click += new System.EventHandler(this.Words_Click);
            // 
            // Letters
            // 
            this.Letters.Location = new System.Drawing.Point(428, 36);
            this.Letters.Margin = new System.Windows.Forms.Padding(4);
            this.Letters.Name = "Letters";
            this.Letters.Size = new System.Drawing.Size(113, 60);
            this.Letters.TabIndex = 7;
            this.Letters.Text = "Считать буквы";
            this.Letters.UseVisualStyleBackColor = true;
            this.Letters.Click += new System.EventHandler(this.Letters_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 38);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "Средняя длина слова";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Setntence
            // 
            this.Setntence.Location = new System.Drawing.Point(660, 36);
            this.Setntence.Margin = new System.Windows.Forms.Padding(4);
            this.Setntence.Name = "Setntence";
            this.Setntence.Size = new System.Drawing.Size(115, 60);
            this.Setntence.TabIndex = 9;
            this.Setntence.Text = "Считать предложения";
            this.Setntence.UseVisualStyleBackColor = true;
            this.Setntence.Click += new System.EventHandler(this.Setntence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(448, 119);
            this.Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(204, 16);
            this.Count.TabIndex = 11;
            this.Count.Text = "В ожидании какой-то команды";
            // 
            // wordsSent
            // 
            this.wordsSent.Location = new System.Drawing.Point(549, 36);
            this.wordsSent.Margin = new System.Windows.Forms.Padding(4);
            this.wordsSent.Name = "wordsSent";
            this.wordsSent.Size = new System.Drawing.Size(103, 60);
            this.wordsSent.TabIndex = 12;
            this.wordsSent.Text = "Среднее количество слов в предложении";
            this.wordsSent.UseVisualStyleBackColor = true;
            this.wordsSent.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 121);
            this.button1.TabIndex = 14;
            this.button1.Text = "Графики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lng
            // 
            this.lng.Location = new System.Drawing.Point(894, 38);
            this.lng.Margin = new System.Windows.Forms.Padding(4);
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(115, 60);
            this.lng.TabIndex = 15;
            this.lng.Text = "Самое длинное слово";
            this.lng.UseVisualStyleBackColor = true;
            this.lng.Click += new System.EventHandler(this.lng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 585);
            this.Controls.Add(this.lng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordsSent);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Setntence);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Letters);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextInput;
        private System.Windows.Forms.ListBox TextOutput;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Words;
        private System.Windows.Forms.Button Letters;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Setntence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button wordsSent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lng;
    }
}

