namespace BlockageMonitor
{
	partial class PopulationChart2
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.popChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTargetPop = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExitPop = new System.Windows.Forms.Button();
            this.btnPopChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // popChart2
            // 
            this.popChart2.BackColor = System.Drawing.Color.LightGray;
            this.popChart2.BackSecondaryColor = System.Drawing.Color.Red;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.popChart2.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.popChart2.Legends.Add(legend1);
            this.popChart2.Location = new System.Drawing.Point(37, 0);
            this.popChart2.Name = "popChart2";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Row";
            series1.Name = "SeriesPop";
            series1.Points.Add(dataPoint1);
            this.popChart2.Series.Add(series1);
            this.popChart2.Size = new System.Drawing.Size(363, 159);
            this.popChart2.TabIndex = 0;
            this.popChart2.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Population Target";
            this.popChart2.Titles.Add(title1);
            // 
            // lblTargetPop
            // 
            this.lblTargetPop.AutoSize = true;
            this.lblTargetPop.BackColor = System.Drawing.Color.LightGray;
            this.lblTargetPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetPop.Location = new System.Drawing.Point(247, 6);
            this.lblTargetPop.Name = "lblTargetPop";
            this.lblTargetPop.Size = new System.Drawing.Size(97, 25);
            this.lblTargetPop.TabIndex = 1;
            this.lblTargetPop.Text = "999,999";
            this.lblTargetPop.Click += new System.EventHandler(this.lblTargetPop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExitPop
            // 
            this.btnExitPop.BackColor = System.Drawing.Color.Maroon;
            this.btnExitPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPop.ForeColor = System.Drawing.Color.White;
            this.btnExitPop.Location = new System.Drawing.Point(1, 0);
            this.btnExitPop.Name = "btnExitPop";
            this.btnExitPop.Size = new System.Drawing.Size(31, 159);
            this.btnExitPop.TabIndex = 2;
            this.btnExitPop.Text = "EXIT";
            this.btnExitPop.UseVisualStyleBackColor = false;
            this.btnExitPop.Click += new System.EventHandler(this.btnExitPop_Click);
            // 
            // btnPopChart
            // 
            this.btnPopChart.BackColor = System.Drawing.Color.Maroon;
            this.btnPopChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopChart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopChart.Location = new System.Drawing.Point(270, 127);
            this.btnPopChart.Name = "btnPopChart";
            this.btnPopChart.Size = new System.Drawing.Size(130, 32);
            this.btnPopChart.TabIndex = 4;
            this.btnPopChart.Text = "Pop Graph 1";
            this.btnPopChart.UseVisualStyleBackColor = false;
            this.btnPopChart.Click += new System.EventHandler(this.btnPopChart_Click);
            // 
            // PopulationChart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 160);
            this.Controls.Add(this.btnPopChart);
            this.Controls.Add(this.btnExitPop);
            this.Controls.Add(this.lblTargetPop);
            this.Controls.Add(this.popChart2);
            this.Location = new System.Drawing.Point(80, 60);
            this.Name = "PopulationChart2";
            this.Text = "Population";
            this.Load += new System.EventHandler(this.PopulationChart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popChart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart popChart2;
		private System.Windows.Forms.Label lblTargetPop;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnExitPop;
		private System.Windows.Forms.Button btnPopChart;
	}
}
