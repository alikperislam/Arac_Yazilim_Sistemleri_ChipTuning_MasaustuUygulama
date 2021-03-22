namespace aracYazilimApp
{
    partial class frmistatistik
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
            this.chartSatislar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMarka = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarka)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSatislar
            // 
            this.chartSatislar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.chartSatislar.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartSatislar.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            this.chartSatislar.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            chartArea1.Name = "ChartArea1";
            this.chartSatislar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSatislar.Legends.Add(legend1);
            this.chartSatislar.Location = new System.Drawing.Point(626, 68);
            this.chartSatislar.Name = "chartSatislar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Satışlar";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartSatislar.Series.Add(series1);
            this.chartSatislar.Size = new System.Drawing.Size(453, 335);
            this.chartSatislar.TabIndex = 0;
            this.chartSatislar.Text = "chart1";
            // 
            // chartMarka
            // 
            this.chartMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.chartMarka.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.Name = "ChartArea1";
            this.chartMarka.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMarka.Legends.Add(legend2);
            this.chartMarka.Location = new System.Drawing.Point(12, 61);
            this.chartMarka.Name = "chartMarka";
            this.chartMarka.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Fuchsia;
            series2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Marka";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ShadowColor = System.Drawing.Color.DarkViolet;
            series2.YValuesPerPoint = 2;
            this.chartMarka.Series.Add(series2);
            this.chartMarka.Size = new System.Drawing.Size(559, 353);
            this.chartMarka.TabIndex = 1;
            this.chartMarka.Text = "chart2";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(400, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartMarka);
            this.Controls.Add(this.chartSatislar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmistatistik";
            this.Text = "frmistatistik";
            ((System.ComponentModel.ISupportInitialize)(this.chartSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatislar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarka;
        private System.Windows.Forms.Button button1;
    }
}