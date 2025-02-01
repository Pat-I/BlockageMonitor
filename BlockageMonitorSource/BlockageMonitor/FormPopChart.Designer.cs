namespace BlockageMonitor
{
	partial class FormPopChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.popchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExitPop = new System.Windows.Forms.Button();
            this.lblGraphPop = new System.Windows.Forms.Label();
            this.btnPopChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popchart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // popchart
            // 
            this.popchart.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.Interval = 5D;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.popchart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.popchart.Legends.Add(legend1);
            this.popchart.Location = new System.Drawing.Point(40, 0);
            this.popchart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.popchart.Name = "popchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Row        ";
            series1.Name = "Population";
            series1.Points.Add(dataPoint1);
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.popchart.Series.Add(series1);
            this.popchart.Series.Add(series2);
            this.popchart.Size = new System.Drawing.Size(527, 229);
            this.popchart.TabIndex = 0;
            this.popchart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Population % from Target ->";
            this.popchart.Titles.Add(title1);
            this.popchart.Click += new System.EventHandler(this.popchart_Click);
            // 
            // btnExitPop
            // 
            this.btnExitPop.BackColor = System.Drawing.Color.Maroon;
            this.btnExitPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPop.ForeColor = System.Drawing.Color.White;
            this.btnExitPop.Location = new System.Drawing.Point(0, 0);
            this.btnExitPop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitPop.Name = "btnExitPop";
            this.btnExitPop.Size = new System.Drawing.Size(46, 229);
            this.btnExitPop.TabIndex = 1;
            this.btnExitPop.Text = "EXIT";
            this.btnExitPop.UseVisualStyleBackColor = false;
            this.btnExitPop.Click += new System.EventHandler(this.btnExitPop_Click);
            // 
            // lblGraphPop
            // 
            this.lblGraphPop.AutoSize = true;
            this.lblGraphPop.BackColor = System.Drawing.Color.LightGray;
            this.lblGraphPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphPop.Location = new System.Drawing.Point(400, 0);
            this.lblGraphPop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGraphPop.Name = "lblGraphPop";
            this.lblGraphPop.Size = new System.Drawing.Size(139, 37);
            this.lblGraphPop.TabIndex = 2;
            this.lblGraphPop.Text = "199,000";
            this.lblGraphPop.Click += new System.EventHandler(this.lblGraphPop_Click);
            // 
            // btnPopChart
            // 
            this.btnPopChart.BackColor = System.Drawing.Color.Maroon;
            this.btnPopChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopChart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopChart.Location = new System.Drawing.Point(364, 180);
            this.btnPopChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPopChart.Name = "btnPopChart";
            this.btnPopChart.Size = new System.Drawing.Size(203, 49);
            this.btnPopChart.TabIndex = 3;
            this.btnPopChart.Text = "Pop Graph 2";
            this.btnPopChart.UseVisualStyleBackColor = false;
            this.btnPopChart.Click += new System.EventHandler(this.btnPopChart_Click);
            // 
            // FormPopChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 235);
            this.Controls.Add(this.btnPopChart);
            this.Controls.Add(this.lblGraphPop);
            this.Controls.Add(this.btnExitPop);
            this.Controls.Add(this.popchart);
            this.Location = new System.Drawing.Point(80, 60);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPopChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form Pop Chart";
            this.Load += new System.EventHandler(this.FormPopChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart popchart;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button btnExitPop;
		private System.Windows.Forms.Label lblGraphPop;
		private System.Windows.Forms.Button btnPopChart;
	}
}
