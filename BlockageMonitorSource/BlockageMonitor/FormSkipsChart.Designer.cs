namespace BlockageMonitor
{
	partial class FormSkipsChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skipChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExitSC = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skipChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skipChart
            // 
            this.skipChart.BackColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.Maximum = 17D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "Row";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX2.Maximum = 17D;
            chartArea4.AxisX2.Minimum = 0D;
            chartArea4.AxisY.Maximum = 7D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY2.Maximum = 7D;
            chartArea4.AxisY2.Minimum = 0D;
            chartArea4.BackColor = System.Drawing.Color.LightGray;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea4.Name = "ChartArea1";
            this.skipChart.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.LightGray;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.skipChart.Legends.Add(legend4);
            this.skipChart.Location = new System.Drawing.Point(54, -9);
            this.skipChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skipChart.Name = "skipChart";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Yellow;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Skips";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Violet;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Doubles";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.skipChart.Series.Add(series7);
            this.skipChart.Series.Add(series8);
            this.skipChart.Size = new System.Drawing.Size(534, 267);
            this.skipChart.TabIndex = 0;
            this.skipChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Skips & Doubles - 3 second look";
            this.skipChart.Titles.Add(title4);
            this.skipChart.Click += new System.EventHandler(this.skipChart_Click);
            // 
            // btnExitSC
            // 
            this.btnExitSC.BackColor = System.Drawing.Color.Maroon;
            this.btnExitSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSC.ForeColor = System.Drawing.Color.White;
            this.btnExitSC.Location = new System.Drawing.Point(18, 18);
            this.btnExitSC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitSC.Name = "btnExitSC";
            this.btnExitSC.Size = new System.Drawing.Size(51, 231);
            this.btnExitSC.TabIndex = 1;
            this.btnExitSC.Text = "EXIT";
            this.btnExitSC.UseVisualStyleBackColor = false;
            this.btnExitSC.Click += new System.EventHandler(this.btnSkipExit);
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.Maroon;
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAlarm.Location = new System.Drawing.Point(368, 213);
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(220, 45);
            this.btnAlarm.TabIndex = 2;
            this.btnAlarm.Text = "ALARM";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.AlarmClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(88, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Skips";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Violet;
            this.textBox2.Location = new System.Drawing.Point(172, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Doubles";
            // 
            // FormSkipsChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 257);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnExitSC);
            this.Controls.Add(this.skipChart);
            this.Location = new System.Drawing.Point(800, 60);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSkipsChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form Skip Chart";
            this.Load += new System.EventHandler(this.FormSkipChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skipChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart skipChart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnExitSC;
		private System.Windows.Forms.Button btnAlarm;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}
