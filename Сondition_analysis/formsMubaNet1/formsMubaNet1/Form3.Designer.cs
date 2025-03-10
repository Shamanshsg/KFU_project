namespace formsMubaNet1
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartfinal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.up_buttonom = new System.Windows.Forms.Button();
            this.down_buttonom = new System.Windows.Forms.Button();
            this.textBoxom = new System.Windows.Forms.TextBox();
            this.textBoxt = new System.Windows.Forms.TextBox();
            this.down_buttont = new System.Windows.Forms.Button();
            this.up_buttont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartfinal)).BeginInit();
            this.SuspendLayout();
            // 
            // chartfinal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartfinal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartfinal.Legends.Add(legend1);
            this.chartfinal.Location = new System.Drawing.Point(27, 12);
            this.chartfinal.Name = "chartfinal";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Шум";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "τ";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Вес/рост";
            this.chartfinal.Series.Add(series1);
            this.chartfinal.Series.Add(series2);
            this.chartfinal.Series.Add(series3);
            this.chartfinal.Size = new System.Drawing.Size(917, 521);
            this.chartfinal.TabIndex = 0;
            this.chartfinal.Text = "chartfinal";
            // 
            // up_buttonom
            // 
            this.up_buttonom.Location = new System.Drawing.Point(1021, 42);
            this.up_buttonom.Name = "up_buttonom";
            this.up_buttonom.Size = new System.Drawing.Size(30, 29);
            this.up_buttonom.TabIndex = 1;
            this.up_buttonom.Text = "↑";
            this.up_buttonom.UseVisualStyleBackColor = true;
            this.up_buttonom.Click += new System.EventHandler(this.up_buttonom_Click);
            // 
            // down_buttonom
            // 
            this.down_buttonom.Location = new System.Drawing.Point(1021, 112);
            this.down_buttonom.Name = "down_buttonom";
            this.down_buttonom.Size = new System.Drawing.Size(30, 29);
            this.down_buttonom.TabIndex = 2;
            this.down_buttonom.Text = "↓";
            this.down_buttonom.UseVisualStyleBackColor = true;
            this.down_buttonom.Click += new System.EventHandler(this.down_buttonom_Click);
            // 
            // textBoxom
            // 
            this.textBoxom.Location = new System.Drawing.Point(1012, 77);
            this.textBoxom.Multiline = true;
            this.textBoxom.Name = "textBoxom";
            this.textBoxom.Size = new System.Drawing.Size(54, 29);
            this.textBoxom.TabIndex = 3;
            this.textBoxom.Text = "0.5";
            this.textBoxom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxt
            // 
            this.textBoxt.Location = new System.Drawing.Point(1128, 77);
            this.textBoxt.Multiline = true;
            this.textBoxt.Name = "textBoxt";
            this.textBoxt.Size = new System.Drawing.Size(43, 29);
            this.textBoxt.TabIndex = 6;
            this.textBoxt.Text = "0.5";
            this.textBoxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_buttont
            // 
            this.down_buttont.Location = new System.Drawing.Point(1128, 112);
            this.down_buttont.Name = "down_buttont";
            this.down_buttont.Size = new System.Drawing.Size(43, 29);
            this.down_buttont.TabIndex = 5;
            this.down_buttont.Text = "↓";
            this.down_buttont.UseVisualStyleBackColor = true;
            this.down_buttont.Click += new System.EventHandler(this.down_buttont_Click);
            // 
            // up_buttont
            // 
            this.up_buttont.Location = new System.Drawing.Point(1128, 42);
            this.up_buttont.Name = "up_buttont";
            this.up_buttont.Size = new System.Drawing.Size(43, 29);
            this.up_buttont.TabIndex = 4;
            this.up_buttont.Text = "↑";
            this.up_buttont.UseVisualStyleBackColor = true;
            this.up_buttont.Click += new System.EventHandler(this.up_buttont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(983, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "σ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1092, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "τ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxt);
            this.Controls.Add(this.down_buttont);
            this.Controls.Add(this.up_buttont);
            this.Controls.Add(this.textBoxom);
            this.Controls.Add(this.down_buttonom);
            this.Controls.Add(this.up_buttonom);
            this.Controls.Add(this.chartfinal);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.chartfinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartfinal;
        private System.Windows.Forms.Button up_buttonom;
        private System.Windows.Forms.Button down_buttonom;
        private System.Windows.Forms.TextBox textBoxom;
        private System.Windows.Forms.TextBox textBoxt;
        private System.Windows.Forms.Button down_buttont;
        private System.Windows.Forms.Button up_buttont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}