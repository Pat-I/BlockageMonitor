using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockageMonitor
{ 

    public partial class FormArduinoSettings : Form
	{
		/// <summary>
		/// ///
		 
		private frmStart mf;
		public FormArduinoSettings(Form callingForm)
		{
			mf = callingForm as frmStart;
			InitializeComponent();
		}/// 
		 /// </summary>
		public FormArduinoSettings()
		{
			InitializeComponent();
		}
	

    

		private void Form1_Load(object sender, EventArgs e)
		{
			//			nUDPopulation.Value = (decimal)mf.rc.rcTargetPopulation;
			nUDPopulation.Value = (decimal)Properties.Settings.Default.setPlanterTargetPopulation;
			nudRowSpacing.Value = (decimal)Properties.Settings.Default.setPlanterRowWidth;
			nudPlantingSpeed.Value = (decimal)Properties.Settings.Default.setPlanterSpeed;
			nudPlanterDoublesFactor.Value  = (decimal)Properties.Settings.Default.setPlanterDoublesFactor;
			int	numberOfSections = Properties.Settings.Default.setVehicle_numSections;
			lblNumRows.Text = numberOfSections.ToString();
			lblCurNumSections.Text = mf.rc.fbNumSections.ToString();
			lblCurPopulation.Text = mf.rc.fbTargetPopulation.ToString();
			lblCurRowWidth.Text = mf.rc.fbRowWidth.ToString("N1");
			lblCurTargetSpeed.Text = mf.rc.fbTargetSpeed.ToString();
			lblCurDoubleFactor.Text = mf.rc.fbDoublesFactor.ToString("N2");

			if (Properties.Settings.Default.setPlanterAlarm_Active == true)
			{
				btnSeedAlarm.BackColor = System.Drawing.Color.Green;
				btnSeedAlarm.ForeColor = SystemColors.ButtonFace;
				btnSeedAlarm.Text = "Seed Alarm is Active";
			}
			else
			{
				btnSeedAlarm.BackColor = System.Drawing.Color.Red;
				btnSeedAlarm.ForeColor = SystemColors.ControlText;
				btnSeedAlarm.Text = "Seed Alarm is Off";
			}

			if (Properties.Settings.Default.setPlanter_Active == true)
			{
				btnPlanterMonitorActive.Text = "Planter Monitor is Active";
				btnPlanterMonitorActive.BackColor = System.Drawing.Color.Green;
				btnPlanterMonitorActive.ForeColor = SystemColors.ButtonFace;
			}
			else
			{
				btnPlanterMonitorActive.Text = "Planter Monitor is Off";
				btnPlanterMonitorActive.BackColor = System.Drawing.Color.Red;
				btnPlanterMonitorActive.ForeColor = SystemColors.ControlText;
			}

			if (Properties.Settings.Default.setMenu_isMetric)
			{
				lblTargetPopulation.Text = "Target Population (per ha)";
				lblPlantingSpeed.Text = "Planter Speed (kph)";
				lblRowSpacing.Text = "Row Spacing (cm)";
				//				nUDPopulation.Value = (decimal)(mf.rc.rcTargetPopulation * 2.471052f);
				//				nudPlantingSpeed.Value = (decimal)(mf.rc.rcTargetSpeed * 1.609344f);
				//				nudRowSpacing.Value = (decimal)(mf.rc.rcRowSpacing * 2.54f);
			}

			if (Properties.Settings.Default.setPlanterSimulator_Active == false)
			{
				btnPlanterSimulator.Text = "Simulator is Off";
				btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
				btnPlanterSimulator.ForeColor = SystemColors.ControlText;
			}
			else
			{
				btnPlanterSimulator.Text = "Simulator is On";
				btnPlanterSimulator.BackColor = System.Drawing.Color.Red;
				btnPlanterSimulator.ForeColor = SystemColors.ButtonFace;
			}


		}



		private void PMS_Exit(object sender, EventArgs e)
		{
			Close();
		}

		private void nudPopulation(object sender, EventArgs e)
		{
			mf.KeypadToNUD((NumericUpDown)sender, this);
			btnSavePlanterSettings.Focus();
		}

		private void nudPopulation_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.setPlanterTargetPopulation = (float)nUDPopulation.Value;
			btnSavePlanterSettings.Focus();
		}

		private void nudRowSpacing_Clicked(object sender, EventArgs e)
		{
			mf.KeypadToNUD((NumericUpDown)sender, this);
			btnSavePlanterSettings.Focus();
		}

		private void nudRowSpacing_valueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.setPlanterRowWidth = (float)nudRowSpacing.Value;
			btnSavePlanterSettings.Focus();
		}

		private void nudPlantingSpeed_Clicked(object sender, EventArgs e)
		{
			mf.KeypadToNUD((NumericUpDown)sender, this);
			btnSavePlanterSettings.Focus();
		}

		private void nudPlantingSpeed_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.setPlanterSpeed = (float)nudPlantingSpeed.Value;
			btnSavePlanterSettings.Focus();

		}

		private void pmonitorActive_Clicked(object sender, EventArgs e)
		{
				if (Properties.Settings.Default.setPlanter_Active == true)
				{
				Properties.Settings.Default.setPlanter_Active = false;
				btnPlanterMonitorActive.Text = "Planter Monitor is Off";
				btnPlanterMonitorActive.BackColor = System.Drawing.Color.Red;
				btnPlanterMonitorActive.ForeColor = SystemColors.ControlText;

				Properties.Settings.Default.setPlanterSimulator_Active = false;
				btnPlanterSimulator.Text = "Simulator is Off";
				btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
				btnPlanterSimulator.ForeColor = SystemColors.ControlText;

				for (int i = 0; i <= mf.rc.fbNumSections; i++)
				{
					String curstate = mf.rc.GetCurrentState(i);
					if (!(curstate == "Normal"))
					{
						mf.rc.SetStateNormal(i);
					}
				}
			}
			else
			{
				Properties.Settings.Default.setPlanter_Active = true;
				btnPlanterMonitorActive.Text = "Planter Monitor is Active";
				btnPlanterMonitorActive.BackColor = System.Drawing.Color.Green;
				btnPlanterMonitorActive.ForeColor = SystemColors.ButtonFace;
			}

		}

		private void seedAlarm_Clicked(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.setPlanterAlarm_Active == true)
			{
				Properties.Settings.Default.setPlanterAlarm_Active = false;
				btnSeedAlarm.BackColor = System.Drawing.Color.Red;
				btnSeedAlarm.ForeColor = SystemColors.ButtonFace;
				btnSeedAlarm.Text = "Seed Alarm is Off";
			}
			else
			{
				Properties.Settings.Default.setPlanterAlarm_Active = true;
				btnSeedAlarm.BackColor = System.Drawing.Color.Green;
				btnSeedAlarm.ForeColor = SystemColors.ControlText;
				btnSeedAlarm.Text = "Seed Alarm is Active";
			}
		}


		private void btnSendPlanterConfigPGN_Click(object sender, EventArgs e)
		{
			SavePMSettings();
//			SendMachineModulePort(mf.p_224.pgn, mf.p_224.pgn.Length);
			//mf.SendUDPMessage(mf.p_224.pgn);

			//mf.TimedMessageBox(1000, gStr.gsAutoSteerPort, "Settings Sent To Planter Monitor Module");

		}
		private void SavePMSettings()
		{
				mf.p_224.pgn[mf.p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
				mf.p_224.pgn[mf.p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
				mf.p_224.pgn[mf.p_224.numSections] = (byte)Properties.Settings.Default.setVehicle_numSections;
				mf.p_224.pgn[mf.p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
				mf.p_224.pgn[mf.p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
				mf.p_224.pgn[mf.p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
				mf.p_224.pgn[mf.p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
			if (Properties.Settings.Default.setMenu_isMetric)
			{
				mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)1);
			}
			else
			{
				mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)0);
			}

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.setPlanterDoublesFactor = (float)nudPlanterDoublesFactor.Value;
			btnSavePlanterSettings.Focus();
		}

		private void nudPlanterDoublesFactor_clicked(object sender, EventArgs e)
		{
			mf.KeypadToNUD((NumericUpDown)sender, this);
			btnSavePlanterSettings.Focus();
		}

		private void SimulatorClicked(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.setPlanterSimulator_Active  == true)
			{
				Properties.Settings.Default.setPlanterSimulator_Active = false;
				btnPlanterSimulator.Text = "Simulator is Off";
				btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
				btnPlanterSimulator.ForeColor = SystemColors.ControlText;
			}
			else
			{
				Properties.Settings.Default.setPlanterSimulator_Active = true;
				btnPlanterSimulator.Text = "Simulator is On";
				btnPlanterSimulator.BackColor = System.Drawing.Color.Red;
				btnPlanterSimulator.ForeColor = SystemColors.ButtonFace;
			}

		}
	}
}
