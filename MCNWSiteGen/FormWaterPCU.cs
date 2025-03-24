/////////////////////////////////////////////////////////////////////////////
//  
// FormWaterPCU.cs: Water PCU Contorls
//
//  Author:	Mark Colvin         Aug 21, 2013
//
//	$Header:    $
//
//	$Log:    $
///  
///  
// 
//
/////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{
    public partial class FormWaterPCU : Form
    {
        MCPressInfo mcPress;
        public bool PCUConfigured;
        public FormWaterPCU()
        {
            InitializeComponent();
            PCUConfigured = false;
        }

        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }
        private void FormWaterPCU_Load(object sender, EventArgs e)
        {
                UpdateWaterPCUDataToGui();
        }

        private void UpdateWaterPCUDataToGui()
        {
            WaterMotorServoControlInterface WaterPCUCtrl = CurrentPress.WaterMotorServoControl;
            int pulseWidth = WaterPCUCtrl.PCU_pulseWidth;
            int distNudge = WaterPCUCtrl.PCU_distNudge;
            int maxStalls = WaterPCUCtrl.PCU_maxStalls;
            int tolerance = WaterPCUCtrl.PCU_tolerance;
            this.txtPulseWidth.Text = pulseWidth.ToString();
            this.txtDistNudge.Text = distNudge.ToString();
            this.txtMaxStalls.Text = maxStalls.ToString();
            this.txtTolerance.Text = tolerance.ToString();
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WaterMotorServoControlInterface WaterPCUCtrl = CurrentPress.WaterMotorServoControl;
            WaterPCUCtrl.PCU_pulseWidth = Convert.ToInt16(txtPulseWidth.Text);
            WaterPCUCtrl.PCU_distNudge = Convert.ToInt16(txtDistNudge.Text);
            WaterPCUCtrl.PCU_maxStalls = Convert.ToInt16(txtMaxStalls.Text);
            WaterPCUCtrl.PCU_tolerance = Convert.ToInt16(txtTolerance.Text);

            PCUConfigured = true;
            this.Close();
        }

        private void txtDistNudge_TextChanged(object sender, EventArgs e)
        {
            if (txtDistNudge.Text == "")
                return;
            int distNudge = 0;
            int maxdistNudge = 10000;
            if (CurrentPress != null)
            {
                distNudge = CurrentPress.WaterMotorServoControl.PCU_distNudge;
            }
            {
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(txtDistNudge.Text))
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxdistNudge);
                    txtDistNudge.Text = distNudge.ToString();
                    return;
                }
                int distNudge1 = Convert.ToInt16(txtDistNudge.Text);
                if (distNudge1 < 0 || distNudge1 > maxdistNudge)
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxdistNudge);
                    txtDistNudge.Text = "0";
                }
            }
        }

        private void txtDistNudge_Leave(object sender, EventArgs e)
        {
            int distNudge = 0;
            int maxdistNudge = 10000;
            if (txtDistNudge.Text == "")
            {
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxdistNudge);
                }
                txtDistNudge.Text = distNudge.ToString();
                return;
            }
            if (txtDistNudge.Text == ".")
                txtDistNudge.Text = "0";
        }

        private void txtPulseWidth_TextChanged(object sender, EventArgs e)
        {
            if (txtPulseWidth.Text == "")
                return;
            int pulseWidth = 0;
            int maxpulseWidth = 10000;
            if (CurrentPress != null)
            {
                pulseWidth = CurrentPress.WaterMotorServoControl.PCU_pulseWidth;
            }
            {
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(txtPulseWidth.Text))
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxpulseWidth);
                    txtPulseWidth.Text = pulseWidth.ToString();
                    return;
                }
                int pulseWidth1 = Convert.ToInt16(txtPulseWidth.Text);
                if (pulseWidth1 < 0 || pulseWidth1 > maxpulseWidth)
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxpulseWidth);
                    txtPulseWidth.Text = "0";
                }
            }
        }

        private void txtPulseWidth_Leave(object sender, EventArgs e)
        {
            int pulseWidth = 0;
            int maxpulseWidth = 10000;
            if (txtPulseWidth.Text == "")
            {
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxpulseWidth);
                }
                txtPulseWidth.Text = pulseWidth.ToString();
                return;
            }
            if (txtPulseWidth.Text == ".")
                txtPulseWidth.Text = "0";
        }

        private void txtMaxStalls_TextChanged(object sender, EventArgs e)
        {
            if (txtMaxStalls.Text == "")
                return;
            int maxStalls = 0;
            int maxmaxStalls = 10000;
            if (CurrentPress != null)
            {
                maxStalls = CurrentPress.WaterMotorServoControl.PCU_maxStalls;
            }
            {
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(txtMaxStalls.Text))
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxmaxStalls);
                    txtMaxStalls.Text = maxStalls.ToString();
                    return;
                }
                int maxStalls1 = Convert.ToInt16(txtMaxStalls.Text);
                if (maxStalls1 < 0 || maxStalls1 > maxmaxStalls)
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxmaxStalls);
                    txtMaxStalls.Text = "0";
                }
            }
        }

        private void txtMaxStalls_Leave(object sender, EventArgs e)
        {
            int maxStalls = 0;
            int maxmaxStalls = 10000;
            if (txtMaxStalls.Text == "")
            {
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxmaxStalls);
                }
                txtMaxStalls.Text = maxStalls.ToString();
                return;
            }
            if (txtMaxStalls.Text == ".")
                txtMaxStalls.Text = "0";
        }

        private void txtTolerance_TextChanged(object sender, EventArgs e)
        {
            if (txtTolerance.Text == "")
                return;
            int tolerance = 0;
            int maxtolerance = 10000;
            if (CurrentPress != null)
            {
                tolerance = CurrentPress.WaterMotorServoControl.PCU_tolerance;
            }
            {
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(txtPulseWidth.Text))
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxtolerance);
                    txtTolerance.Text = tolerance.ToString();
                    return;
                }
                int tolerance1 = Convert.ToInt16(txtTolerance.Text);
                if (tolerance1 < 0 || tolerance1 > maxtolerance)
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxtolerance);
                    txtTolerance.Text = "0";
                }
            }
        }

        private void txtTolerance_Leave(object sender, EventArgs e)
        {
            int tolerance = 0;
            int maxtolerance = 10000;
            if (txtTolerance.Text == "")
            {
                {
                    MessageBox.Show("The Range of value is : 0 - " + maxtolerance);
                }
                txtTolerance.Text = tolerance.ToString();
                return;
            }
            if (txtTolerance.Text == ".")
                txtTolerance.Text = "0";
        }
    }
}