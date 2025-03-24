/////////////////////////////////////////////////////////////////////////////
//  
// FormSweepMotorOrServoCtrl.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormSweepMotorOrServoCtrl.cs-arc   1.2   Jun 16 2009 05:36:08   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormSweepMotorOrServoCtrl.cs-arc  $
///  
///     Rev 1.2   Jun 16 2009 05:36:08   HNarala
///  site file generator defect fixes
///  
///     Rev 1.1   Jun 04 2009 04:56:56   HNarala
///  MT: 13469
///  
///     Rev 1.0   May 14 2009 03:36:02   HNarala
///  Initial revision.
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
    public partial class FormSweepMotorOrServoCtrl : Form
    {
        MCPressInfo mcPress;
        public bool motorOrServoConfigured;
        public FormSweepMotorOrServoCtrl()
        {
            InitializeComponent();
            motorOrServoConfigured = false;
        }

        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }
        private void FormSweepMotorOrServoCtrl_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 10, Location.Y + 10);
            if (this.Tag != null)
            {
                string title = this.Tag.ToString();
                if (title == "Servo Sweep")
                {
                    this.labelTitle.Text = title;
                    this.gpMotorOrServoSettings.Text = "Servo control";
                }
                UpdateSweepMotorServoDataToGui();
            }
        }

        private void UpdateSweepMotorServoDataToGui()
        {
            SweepMotorServoControlInterface sweepMotorServoCtrl = CurrentPress.SweepMotorServoControl;
            this.cboStepEnabled.Text = sweepMotorServoCtrl.StepEnabled.ToString();
            double servoTurns = sweepMotorServoCtrl.ServoTurns;
            if (this.Tag.ToString() == "Servo Sweep")
            {
                if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                    servoTurns = DefineAndConst.SystemCapacities.MIN_SERVO_TURNS;
            }
            else
            {
                int tempServoTurns = (int)servoTurns;
                servoTurns = (double)tempServoTurns;
            }
            this.txtServoTurns.Text = servoTurns.ToString();
            this.comboReversed.Text = sweepMotorServoCtrl.Reversed.ToString();
            this.comboLowBacklashUsed.Text = sweepMotorServoCtrl.LowBacklashUsed.ToString();
            this.comboOffsetEnabled.Text = sweepMotorServoCtrl.OffsetEnabled.ToString();
            this.comboUserBank1.Text = sweepMotorServoCtrl.UseBank1.ToString();
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SweepMotorServoControlInterface sweepMotorServoCtrl = CurrentPress.SweepMotorServoControl;
            sweepMotorServoCtrl.StepEnabled = Convert.ToBoolean(cboStepEnabled.Text);            
            sweepMotorServoCtrl.ServoTurns = Convert.ToDouble(txtServoTurns.Text);
            sweepMotorServoCtrl.Reversed = Convert.ToBoolean(comboReversed.Text);
            sweepMotorServoCtrl.LowBacklashUsed = Convert.ToBoolean(comboLowBacklashUsed.Text);
            sweepMotorServoCtrl.OffsetEnabled = Convert.ToBoolean(this.comboOffsetEnabled.Text);
            sweepMotorServoCtrl.UseBank1 = Convert.ToBoolean(this.comboUserBank1.Text);

            motorOrServoConfigured = true;
            this.Close();
        }

        private void txtServoTurns_TextChanged(object sender, EventArgs e)
        {
            if (txtServoTurns.Text == "")
                return;
            double turns = 0;
            if (CurrentPress != null)
            {
                turns = CurrentPress.SweepMotorServoControl.ServoTurns;
            }
            if (this.Tag.ToString() == "Servo Sweep")
            {
                Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                if (!regex.IsMatch(txtServoTurns.Text))
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    txtServoTurns.Text = turns.ToString();
                    return;
                }
            }
            if (this.Tag.ToString() == "Motor Sweep")
            {
                int maxServoTurn = DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS;
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(txtServoTurns.Text))
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + maxServoTurn);
                    txtServoTurns.Text = turns.ToString();
                    return;
                }
                double servoTurns = Convert.ToDouble(txtServoTurns.Text);
                if (servoTurns < 0 || servoTurns > maxServoTurn)
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + maxServoTurn);
                    txtServoTurns.Text = "0";
                }                
            }            
        }

        //======================================================================================
        /// <Function>txtServoTurns_Leave</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// txtServo Turns Leave event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void txtServoTurns_Leave(object sender, EventArgs e)
        {
            double turns = 0;
            if (txtServoTurns.Text == "")
            {
                if (this.Tag.ToString() == "Servo Sweep")
                {                    
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    txtServoTurns.Text = "0";
                    return;
                }
                else
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS);
                }
                txtServoTurns.Text = turns.ToString();
                return;
            }
            if (txtServoTurns.Text == ".")
                txtServoTurns.Text = "0";
            double servoTurns = Convert.ToDouble(txtServoTurns.Text);
            if (this.Tag.ToString() == "Servo Sweep")
            {
                if (this.txtServoTurns.Text != "0")
                {
                    if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                    {
                        MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                        txtServoTurns.Text = turns.ToString();
                    }
                }
                else
                {
                    if (servoTurns < 0)
                    {
                        MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                        txtServoTurns.Text = turns.ToString();
                    }
                }
            }
        }
    }
}