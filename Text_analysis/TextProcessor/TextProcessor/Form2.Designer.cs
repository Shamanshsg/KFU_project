namespace TextProcessor
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartWord_letter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bar_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSentence_letter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartWord_letter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSentence_letter)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWord_letter
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWord_letter.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWord_letter.Legends.Add(legend1);
            this.chartWord_letter.Location = new System.Drawing.Point(13, 283);
            this.chartWord_letter.Margin = new System.Windows.Forms.Padding(4);
            this.chartWord_letter.Name = "chartWord_letter";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWord_letter.Series.Add(series1);
            this.chartWord_letter.Size = new System.Drawing.Size(563, 364);
            this.chartWord_letter.TabIndex = 0;
            this.chartWord_letter.Text = "chartWord_letter";
            // 
            // bar_graph
            // 
            chartArea2.Name = "ChartArea1";
            this.bar_graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.bar_graph.Legends.Add(legend2);
            this.bar_graph.Location = new System.Drawing.Point(13, 19);
            this.bar_graph.Margin = new System.Windows.Forms.Padding(4);
            this.bar_graph.Name = "bar_graph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.bar_graph.Series.Add(series2);
            this.bar_graph.Size = new System.Drawing.Size(1142, 256);
            this.bar_graph.TabIndex = 1;
            this.bar_graph.Text = "bar_graph";
            this.bar_graph.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chartSentence_letter
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSentence_letter.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSentence_letter.Legends.Add(legend3);
            this.chartSentence_letter.Location = new System.Drawing.Point(584, 283);
            this.chartSentence_letter.Margin = new System.Windows.Forms.Padding(4);
            this.chartSentence_letter.Name = "chartSentence_letter";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSentence_letter.Series.Add(series3);
            this.chartSentence_letter.Size = new System.Drawing.Size(571, 364);
            this.chartSentence_letter.TabIndex = 8;
            this.chartSentence_letter.Text = "chartSentence_letter";
            this.chartSentence_letter.Click += new System.EventHandler(this.chartSentence_letter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 860);
            this.Controls.Add(this.chartSentence_letter);
            this.Controls.Add(this.bar_graph);
            this.Controls.Add(this.chartWord_letter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWord_letter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSentence_letter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWord_letter;
        private System.Windows.Forms.DataVisualization.Charting.Chart bar_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSentence_letter;
    }
}