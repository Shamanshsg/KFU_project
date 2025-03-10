namespace formsMubaNet1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridClear = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonChart = new System.Windows.Forms.Button();
            this.RemoveData1 = new System.Windows.Forms.Button();
            this.RemoveData2 = new System.Windows.Forms.Button();
            this.dataGridgl = new System.Windows.Forms.DataGridView();
            this.GenerateG = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridHeal = new System.Windows.Forms.DataGridView();
            this.HealButton = new System.Windows.Forms.Button();
            this.chart_button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridgl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(430, 386);
            this.dataGrid.TabIndex = 0;
            // 
            // dataGridClear
            // 
            this.dataGridClear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClear.Location = new System.Drawing.Point(448, 12);
            this.dataGridClear.Name = "dataGridClear";
            this.dataGridClear.RowHeadersWidth = 51;
            this.dataGridClear.RowTemplate.Height = 24;
            this.dataGridClear.Size = new System.Drawing.Size(430, 386);
            this.dataGridClear.TabIndex = 1;
            this.dataGridClear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Почистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ButtonChart
            // 
            this.ButtonChart.Location = new System.Drawing.Point(779, 411);
            this.ButtonChart.Name = "ButtonChart";
            this.ButtonChart.Size = new System.Drawing.Size(75, 35);
            this.ButtonChart.TabIndex = 4;
            this.ButtonChart.Text = "График";
            this.ButtonChart.UseVisualStyleBackColor = true;
            this.ButtonChart.Click += new System.EventHandler(this.ButtonChart_Click);
            // 
            // RemoveData1
            // 
            this.RemoveData1.Location = new System.Drawing.Point(12, 404);
            this.RemoveData1.Name = "RemoveData1";
            this.RemoveData1.Size = new System.Drawing.Size(89, 23);
            this.RemoveData1.TabIndex = 5;
            this.RemoveData1.Text = "Очистить";
            this.RemoveData1.UseVisualStyleBackColor = true;
            this.RemoveData1.Click += new System.EventHandler(this.RemoveData1_Click);
            // 
            // RemoveData2
            // 
            this.RemoveData2.Location = new System.Drawing.Point(448, 404);
            this.RemoveData2.Name = "RemoveData2";
            this.RemoveData2.Size = new System.Drawing.Size(90, 23);
            this.RemoveData2.TabIndex = 6;
            this.RemoveData2.Text = "Очистить";
            this.RemoveData2.UseVisualStyleBackColor = true;
            this.RemoveData2.Click += new System.EventHandler(this.RemoveData2_Click);
            // 
            // dataGridgl
            // 
            this.dataGridgl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridgl.Location = new System.Drawing.Point(884, 12);
            this.dataGridgl.Name = "dataGridgl";
            this.dataGridgl.RowHeadersWidth = 51;
            this.dataGridgl.RowTemplate.Height = 24;
            this.dataGridgl.Size = new System.Drawing.Size(430, 386);
            this.dataGridgl.TabIndex = 7;
            // 
            // GenerateG
            // 
            this.GenerateG.Location = new System.Drawing.Point(1037, 404);
            this.GenerateG.Name = "GenerateG";
            this.GenerateG.Size = new System.Drawing.Size(132, 48);
            this.GenerateG.TabIndex = 8;
            this.GenerateG.Text = "Сгенерировать глюкозу";
            this.GenerateG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GenerateG.UseVisualStyleBackColor = true;
            this.GenerateG.Click += new System.EventHandler(this.GenerateG_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(884, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridHeal
            // 
            this.dataGridHeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHeal.Location = new System.Drawing.Point(1320, 12);
            this.dataGridHeal.Name = "dataGridHeal";
            this.dataGridHeal.RowHeadersWidth = 51;
            this.dataGridHeal.RowTemplate.Height = 24;
            this.dataGridHeal.Size = new System.Drawing.Size(430, 386);
            this.dataGridHeal.TabIndex = 10;
            // 
            // HealButton
            // 
            this.HealButton.Location = new System.Drawing.Point(1467, 404);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(132, 48);
            this.HealButton.TabIndex = 11;
            this.HealButton.Text = "Сгенерировать болячку";
            this.HealButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.HealButton_Click);
            // 
            // chart_button2
            // 
            this.chart_button2.Location = new System.Drawing.Point(1675, 411);
            this.chart_button2.Name = "chart_button2";
            this.chart_button2.Size = new System.Drawing.Size(75, 35);
            this.chart_button2.TabIndex = 12;
            this.chart_button2.Text = "График";
            this.chart_button2.UseVisualStyleBackColor = true;
            this.chart_button2.Click += new System.EventHandler(this.chart_button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 514);
            this.Controls.Add(this.chart_button2);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.dataGridHeal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GenerateG);
            this.Controls.Add(this.dataGridgl);
            this.Controls.Add(this.RemoveData2);
            this.Controls.Add(this.RemoveData1);
            this.Controls.Add(this.ButtonChart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridClear);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridgl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridView dataGridClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonChart;
        private System.Windows.Forms.Button RemoveData1;
        private System.Windows.Forms.Button RemoveData2;
        private System.Windows.Forms.DataGridView dataGridgl;
        private System.Windows.Forms.Button GenerateG;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridHeal;
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button chart_button2;
    }
}

