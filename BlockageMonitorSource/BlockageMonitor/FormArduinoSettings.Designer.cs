namespace BlockageMonitor
{
	partial class FormArduinoSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTargetPopulation = new System.Windows.Forms.Label();
            this.lblRowSpacing = new System.Windows.Forms.Label();
            this.lblPlantingSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSavePlanterSettings = new System.Windows.Forms.Button();
            this.nUDPopulation = new System.Windows.Forms.NumericUpDown();
            this.nudRowSpacing = new System.Windows.Forms.NumericUpDown();
            this.nudPlantingSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblNumRows = new System.Windows.Forms.Label();
            this.btnPlanterMonitorActive = new System.Windows.Forms.Button();
            this.btnSeedAlarm = new System.Windows.Forms.Button();
            this.btnSendPlanterConfigPGN = new System.Windows.Forms.Button();
            this.lblPMSS = new System.Windows.Forms.Label();
            this.lblCurPopulation = new System.Windows.Forms.Label();
            this.lblCurRowWidth = new System.Windows.Forms.Label();
            this.lblCurTargetSpeed = new System.Windows.Forms.Label();
            this.lblCurNumSections = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPlanterDoublesFactor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurDoubleFactor = new System.Windows.Forms.Label();
            this.btnPlanterSimulator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlantingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanterDoublesFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planter Monitor Settings";
            // 
            // lblTargetPopulation
            // 
            this.lblTargetPopulation.AutoSize = true;
            this.lblTargetPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetPopulation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTargetPopulation.Location = new System.Drawing.Point(67, 199);
            this.lblTargetPopulation.Name = "lblTargetPopulation";
            this.lblTargetPopulation.Size = new System.Drawing.Size(234, 20);
            this.lblTargetPopulation.TabIndex = 3;
            this.lblTargetPopulation.Text = "Target Population (per acre)";
            // 
            // lblRowSpacing
            // 
            this.lblRowSpacing.AutoSize = true;
            this.lblRowSpacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowSpacing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRowSpacing.Location = new System.Drawing.Point(67, 263);
            this.lblRowSpacing.Name = "lblRowSpacing";
            this.lblRowSpacing.Size = new System.Drawing.Size(183, 20);
            this.lblRowSpacing.TabIndex = 4;
            this.lblRowSpacing.Text = "Row Spacing (inches)";
            // 
            // lblPlantingSpeed
            // 
            this.lblPlantingSpeed.AutoSize = true;
            this.lblPlantingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantingSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlantingSpeed.Location = new System.Drawing.Point(67, 323);
            this.lblPlantingSpeed.Name = "lblPlantingSpeed";
            this.lblPlantingSpeed.Size = new System.Drawing.Size(182, 20);
            this.lblPlantingSpeed.TabIndex = 6;
            this.lblPlantingSpeed.Text = "Planting Speed (mph)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(67, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Rows (sections)";
            // 
            // btnSavePlanterSettings
            // 
            this.btnSavePlanterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePlanterSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSavePlanterSettings.BackgroundImage = global::BlockageMonitor.Properties.Resources.Cancel64;
            this.btnSavePlanterSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSavePlanterSettings.FlatAppearance.BorderSize = 0;
            this.btnSavePlanterSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlanterSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePlanterSettings.Location = new System.Drawing.Point(520, 467);
            this.btnSavePlanterSettings.Name = "btnSavePlanterSettings";
            this.btnSavePlanterSettings.Size = new System.Drawing.Size(83, 79);
            this.btnSavePlanterSettings.TabIndex = 213;
            this.btnSavePlanterSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSavePlanterSettings.UseVisualStyleBackColor = false;
            this.btnSavePlanterSettings.Click += new System.EventHandler(this.PMS_Exit);
            // 
            // nUDPopulation
            // 
            this.nUDPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDPopulation.Location = new System.Drawing.Point(330, 181);
            this.nUDPopulation.Maximum = new decimal(new int[] {
            210000,
            0,
            0,
            0});
            this.nUDPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPopulation.Name = "nUDPopulation";
            this.nUDPopulation.Size = new System.Drawing.Size(117, 38);
            this.nUDPopulation.TabIndex = 214;
            this.nUDPopulation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPopulation.ValueChanged += new System.EventHandler(this.nudPopulation_ValueChanged);
            this.nUDPopulation.Click += new System.EventHandler(this.nudPopulation);
            // 
            // nudRowSpacing
            // 
            this.nudRowSpacing.DecimalPlaces = 1;
            this.nudRowSpacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRowSpacing.Location = new System.Drawing.Point(330, 245);
            this.nudRowSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowSpacing.Name = "nudRowSpacing";
            this.nudRowSpacing.Size = new System.Drawing.Size(117, 38);
            this.nudRowSpacing.TabIndex = 215;
            this.nudRowSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowSpacing.ValueChanged += new System.EventHandler(this.nudRowSpacing_valueChanged);
            this.nudRowSpacing.Click += new System.EventHandler(this.nudRowSpacing_Clicked);
            // 
            // nudPlantingSpeed
            // 
            this.nudPlantingSpeed.DecimalPlaces = 1;
            this.nudPlantingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlantingSpeed.Location = new System.Drawing.Point(330, 305);
            this.nudPlantingSpeed.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudPlantingSpeed.Name = "nudPlantingSpeed";
            this.nudPlantingSpeed.Size = new System.Drawing.Size(117, 38);
            this.nudPlantingSpeed.TabIndex = 216;
            this.nudPlantingSpeed.ValueChanged += new System.EventHandler(this.nudPlantingSpeed_ValueChanged);
            this.nudPlantingSpeed.Click += new System.EventHandler(this.nudPlantingSpeed_Clicked);
            // 
            // lblNumRows
            // 
            this.lblNumRows.AutoSize = true;
            this.lblNumRows.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumRows.Location = new System.Drawing.Point(324, 460);
            this.lblNumRows.Name = "lblNumRows";
            this.lblNumRows.Size = new System.Drawing.Size(46, 31);
            this.lblNumRows.TabIndex = 218;
            this.lblNumRows.Text = "15";
            // 
            // btnPlanterMonitorActive
            // 
            this.btnPlanterMonitorActive.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlanterMonitorActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanterMonitorActive.Location = new System.Drawing.Point(39, 73);
            this.btnPlanterMonitorActive.Name = "btnPlanterMonitorActive";
            this.btnPlanterMonitorActive.Size = new System.Drawing.Size(300, 70);
            this.btnPlanterMonitorActive.TabIndex = 220;
            this.btnPlanterMonitorActive.Text = "Planter Monitor is Active";
            this.btnPlanterMonitorActive.UseVisualStyleBackColor = false;
            this.btnPlanterMonitorActive.Click += new System.EventHandler(this.pmonitorActive_Clicked);
            // 
            // btnSeedAlarm
            // 
            this.btnSeedAlarm.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSeedAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeedAlarm.Location = new System.Drawing.Point(473, 73);
            this.btnSeedAlarm.Name = "btnSeedAlarm";
            this.btnSeedAlarm.Size = new System.Drawing.Size(300, 70);
            this.btnSeedAlarm.TabIndex = 221;
            this.btnSeedAlarm.Text = "Seed Alarm is Active";
            this.btnSeedAlarm.UseVisualStyleBackColor = false;
            this.btnSeedAlarm.Click += new System.EventHandler(this.seedAlarm_Clicked);
            // 
            // btnSendPlanterConfigPGN
            // 
            this.btnSendPlanterConfigPGN.BackColor = System.Drawing.Color.Transparent;
            this.btnSendPlanterConfigPGN.FlatAppearance.BorderSize = 0;
            this.btnSendPlanterConfigPGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPlanterConfigPGN.Image = global::BlockageMonitor.Properties.Resources.Save;
            this.btnSendPlanterConfigPGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendPlanterConfigPGN.Location = new System.Drawing.Point(640, 414);
            this.btnSendPlanterConfigPGN.Name = "btnSendPlanterConfigPGN";
            this.btnSendPlanterConfigPGN.Size = new System.Drawing.Size(133, 62);
            this.btnSendPlanterConfigPGN.TabIndex = 502;
            this.btnSendPlanterConfigPGN.UseVisualStyleBackColor = false;
            this.btnSendPlanterConfigPGN.Click += new System.EventHandler(this.btnSendPlanterConfigPGN_Click);
            // 
            // lblPMSS
            // 
            this.lblPMSS.BackColor = System.Drawing.Color.Transparent;
            this.lblPMSS.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblPMSS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPMSS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPMSS.Location = new System.Drawing.Point(609, 486);
            this.lblPMSS.Name = "lblPMSS";
            this.lblPMSS.Size = new System.Drawing.Size(150, 30);
            this.lblPMSS.TabIndex = 503;
            this.lblPMSS.Text = "Send +  Save";
            this.lblPMSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurPopulation
            // 
            this.lblCurPopulation.AutoSize = true;
            this.lblCurPopulation.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCurPopulation.Location = new System.Drawing.Point(126, 223);
            this.lblCurPopulation.Name = "lblCurPopulation";
            this.lblCurPopulation.Size = new System.Drawing.Size(13, 13);
            this.lblCurPopulation.TabIndex = 504;
            this.lblCurPopulation.Text = "0";
            // 
            // lblCurRowWidth
            // 
            this.lblCurRowWidth.AutoSize = true;
            this.lblCurRowWidth.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCurRowWidth.Location = new System.Drawing.Point(126, 294);
            this.lblCurRowWidth.Name = "lblCurRowWidth";
            this.lblCurRowWidth.Size = new System.Drawing.Size(13, 13);
            this.lblCurRowWidth.TabIndex = 505;
            this.lblCurRowWidth.Text = "0";
            // 
            // lblCurTargetSpeed
            // 
            this.lblCurTargetSpeed.AutoSize = true;
            this.lblCurTargetSpeed.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCurTargetSpeed.Location = new System.Drawing.Point(126, 353);
            this.lblCurTargetSpeed.Name = "lblCurTargetSpeed";
            this.lblCurTargetSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblCurTargetSpeed.TabIndex = 506;
            this.lblCurTargetSpeed.Text = "0";
            // 
            // lblCurNumSections
            // 
            this.lblCurNumSections.AutoSize = true;
            this.lblCurNumSections.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCurNumSections.Location = new System.Drawing.Point(126, 499);
            this.lblCurNumSections.Name = "lblCurNumSections";
            this.lblCurNumSections.Size = new System.Drawing.Size(13, 13);
            this.lblCurNumSections.TabIndex = 507;
            this.lblCurNumSections.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(68, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 508;
            this.label2.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(67, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 509;
            this.label3.Text = "A Double =";
            // 
            // nudPlanterDoublesFactor
            // 
            this.nudPlanterDoublesFactor.DecimalPlaces = 2;
            this.nudPlanterDoublesFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlanterDoublesFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPlanterDoublesFactor.Location = new System.Drawing.Point(172, 381);
            this.nudPlanterDoublesFactor.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            131072});
            this.nudPlanterDoublesFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPlanterDoublesFactor.Name = "nudPlanterDoublesFactor";
            this.nudPlanterDoublesFactor.Size = new System.Drawing.Size(120, 38);
            this.nudPlanterDoublesFactor.TabIndex = 510;
            this.nudPlanterDoublesFactor.Value = new decimal(new int[] {
            55,
            0,
            0,
            131072});
            this.nudPlanterDoublesFactor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudPlanterDoublesFactor.Click += new System.EventHandler(this.nudPlanterDoublesFactor_clicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(313, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 511;
            this.label4.Text = "X Normal Spacing";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCurDoubleFactor
            // 
            this.lblCurDoubleFactor.AutoSize = true;
            this.lblCurDoubleFactor.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCurDoubleFactor.Location = new System.Drawing.Point(129, 434);
            this.lblCurDoubleFactor.Name = "lblCurDoubleFactor";
            this.lblCurDoubleFactor.Size = new System.Drawing.Size(13, 13);
            this.lblCurDoubleFactor.TabIndex = 512;
            this.lblCurDoubleFactor.Text = "0";
            // 
            // btnPlanterSimulator
            // 
            this.btnPlanterSimulator.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlanterSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanterSimulator.Location = new System.Drawing.Point(71, 530);
            this.btnPlanterSimulator.Name = "btnPlanterSimulator";
            this.btnPlanterSimulator.Size = new System.Drawing.Size(216, 41);
            this.btnPlanterSimulator.TabIndex = 513;
            this.btnPlanterSimulator.Text = "Simulator on";
            this.btnPlanterSimulator.UseVisualStyleBackColor = false;
            this.btnPlanterSimulator.Click += new System.EventHandler(this.SimulatorClicked);
            // 
            // FormArduinoSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.btnPlanterSimulator);
            this.Controls.Add(this.lblCurDoubleFactor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPlanterDoublesFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurNumSections);
            this.Controls.Add(this.lblCurTargetSpeed);
            this.Controls.Add(this.lblCurRowWidth);
            this.Controls.Add(this.lblCurPopulation);
            this.Controls.Add(this.lblPMSS);
            this.Controls.Add(this.btnSendPlanterConfigPGN);
            this.Controls.Add(this.btnSeedAlarm);
            this.Controls.Add(this.btnPlanterMonitorActive);
            this.Controls.Add(this.lblNumRows);
            this.Controls.Add(this.nudPlantingSpeed);
            this.Controls.Add(this.nudRowSpacing);
            this.Controls.Add(this.nUDPopulation);
            this.Controls.Add(this.btnSavePlanterSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlantingSpeed);
            this.Controls.Add(this.lblRowSpacing);
            this.Controls.Add(this.lblTargetPopulation);
            this.Controls.Add(this.label1);
            this.Name = "FormArduinoSettings";
            this.Text = "Arduino Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlantingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanterDoublesFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTargetPopulation;
		private System.Windows.Forms.Label lblRowSpacing;
		private System.Windows.Forms.Label lblPlantingSpeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSavePlanterSettings;
		private System.Windows.Forms.NumericUpDown nUDPopulation;
		private System.Windows.Forms.NumericUpDown nudRowSpacing;
		private System.Windows.Forms.NumericUpDown nudPlantingSpeed;
		private System.Windows.Forms.Label lblNumRows;
		private System.Windows.Forms.Button btnPlanterMonitorActive;
		private System.Windows.Forms.Button btnSeedAlarm;
		private System.Windows.Forms.Button btnSendPlanterConfigPGN;
		private System.Windows.Forms.Label lblPMSS;
		private System.Windows.Forms.Label lblCurPopulation;
		private System.Windows.Forms.Label lblCurRowWidth;
		private System.Windows.Forms.Label lblCurTargetSpeed;
		private System.Windows.Forms.Label lblCurNumSections;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudPlanterDoublesFactor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCurDoubleFactor;
		private System.Windows.Forms.Button btnPlanterSimulator;
	}
}
