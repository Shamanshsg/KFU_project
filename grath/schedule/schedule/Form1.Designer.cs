namespace schedule
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Button();
            this.textMin = new System.Windows.Forms.TextBox();
            this.MinMax = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.SpeedDown = new System.Windows.Forms.Button();
            this.SpeedUp = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(667, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(694, 403);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(685, 21);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(94, 23);
            this.type.TabIndex = 2;
            this.type.Text = "закрасить";
            this.type.UseVisualStyleBackColor = true;
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(685, 88);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(80, 22);
            this.textMin.TabIndex = 4;
            // 
            // MinMax
            // 
            this.MinMax.Location = new System.Drawing.Point(685, 116);
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(75, 23);
            this.MinMax.TabIndex = 5;
            this.MinMax.Text = "Задать";
            this.MinMax.UseVisualStyleBackColor = true;
            this.MinMax.Click += new System.EventHandler(this.MinMax_Click);
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(896, 60);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(80, 22);
            this.textValue.TabIndex = 6;
            this.textValue.TextChanged += new System.EventHandler(this.textValue_TextChanged);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(905, 31);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(61, 23);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(905, 87);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(61, 23);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // SpeedDown
            // 
            this.SpeedDown.Location = new System.Drawing.Point(694, 229);
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.Size = new System.Drawing.Size(61, 23);
            this.SpeedDown.TabIndex = 11;
            this.SpeedDown.Text = "Down";
            this.SpeedDown.UseVisualStyleBackColor = true;
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // SpeedUp
            // 
            this.SpeedUp.Location = new System.Drawing.Point(694, 173);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(61, 23);
            this.SpeedUp.TabIndex = 10;
            this.SpeedUp.Text = "Up";
            this.SpeedUp.UseVisualStyleBackColor = true;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(685, 202);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(80, 22);
            this.Speed.TabIndex = 9;
            this.Speed.TextChanged += new System.EventHandler(this.Speed_TextChanged);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(775, 403);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 12;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Скорость(Время задержки в мс)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Минимум";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Параметр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.SpeedDown);
            this.Controls.Add(this.SpeedUp);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.MinMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.type);
            this.Controls.Add(this.start);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button type;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Button MinMax;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button SpeedDown;
        private System.Windows.Forms.Button SpeedUp;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

