/////////////////////////////////////////////////////////////////////////////
//  
// FormWaterMotorOrServo.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen//////////////////////////////////////////////////////////////////////////////
//  
// FormSweepMotorOrServoCtrl.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterMotorOrServo.cs-arc   1.2   Jun 16 2009 05:36:12   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterMotorOrServo.cs-arc  $
///  
///     Rev 1.2   Jun 16 2009 05:36:12   HNarala
///  site file generator defect fixes
///  
///     Rev 1.1   Jun 04 2009 04:59:24   HNarala
///  For MT: 13469
///  
///     Rev 1.0   May 14 2009 03:36:06   HNarala
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
    public partial class FormWaterMotorOrServo : Form
    {
        MCPressInfo mcPress;
        public bool motorOrServoConfigured;
        public FormWaterMotorOrServo()
        {
            InitializeComponent();
            motorOrServoConfigured = false;
        }
        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }
        void FormWaterMotorOrServo_Load(object sender, System.EventArgs e)
        {
            this.Location = new Point(Location.X + 10, Location.Y + 10);
            if (this.Tag != null)
            {
                string title = this.Tag.ToString();
                if (title == "Servo Water")
                {
                    this.labelWaterMotorOrServo.Text = title;
                    this.gpMotorServoSettings.Text = "Servo control";
                }
                UpdateWaterMotorServoDataToGui();
            }
        }

        private void UpdateWaterMotorServoDataToGui()
        {
            WaterMotorServoControlInterface waterMotorServoInterface = CurrentPress.WaterMotorServoControl;
            double servoTurns = waterMotorServoInterface.ServoTurns;
            if (this.Tag.ToString() == "Servo Water")
            {
                if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                {
                    servoTurns = DefineAndConst.SystemCapacities.MIN_SERVO_TURNS;
                }
            }
            else
            {
                int tempServoTurns = (int)servoTurns;
                servoTurns = (double)tempServoTurns;
            }
            textBoxServoTurns.Text = servoTurns.ToString();
            txtBoxInitialSurge.Text = waterMotorServoInterface.InitialSurge.ToString();
            textBoxIncrementalSurge.Text = waterMotorServoInterface.IncrementalSurge.ToString();
            comboReversed.Text = waterMotorServoInterface.Reversed.ToString();
            comboSpecialMapping.Text = waterMotorServoInterface.SpecialMapping.ToString();
            comboUseBank1.Text = waterMotorServoInterface.UseBank1.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WaterMotorServoControlInterface waterMotorServoInterface = CurrentPress.WaterMotorServoControl;
            waterMotorServoInterface.ServoTurns = Convert.ToDouble(textBoxServoTurns.Text);
            waterMotorServoInterface.InitialSurge =Convert.ToInt16(txtBoxInitialSurge.Text);
            waterMotorServoInterface.IncrementalSurge = Convert.ToInt16(textBoxIncrementalSurge.Text);
            waterMotorServoInterface.Reversed = Convert.ToBoolean(comboReversed.Text);
            waterMotorServoInterface.SpecialMapping = Convert.ToBoolean(comboSpecialMapping.Text);
            waterMotorServoInterface.UseBank1 = Convert.ToBoolean(comboUseBank1.Text);
            motorOrServoConfigured = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIncrementalSurge_Leave(object sender, EventArgs e)
        {
            if (textBoxIncrementalSurge.Text == "")
            {
                MessageBox.Show("The Range Of Incremental Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxIncrementalSurge.Text = CurrentPress.WaterMotorServoControl.IncrementalSurge.ToString();
            }
        }

        private void textBoxServoTurns_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServoTurns.Text == "")
                    return; 
            double turns = 0;
            if (this.Tag.ToString() == "Servo Water")
            {
                Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                if (!regex.IsMatch(textBoxServoTurns.Text))
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textBoxServoTurns.Text = turns.ToString();
                    return;
                }
            }
            else
            {
                int maxWaterMotorTurns = DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS;
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textBoxServoTurns.Text))
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + maxWaterMotorTurns);
                    textBoxServoTurns.Text = turns.ToString();
                    return;
                }
                double servoTurns = Convert.ToDouble(textBoxServoTurns.Text);
                if (servoTurns < 0 || servoTurns > maxWaterMotorTurns)
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + maxWaterMotorTurns);
                    textBoxServoTurns.Text = turns.ToString();
                }
            }
        }

        //======================================================================================
        /// <Function>textBoxServoTurns_Leave</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textBoxServo Turns2 Leave event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textBoxServoTurns_Leave(object sender, EventArgs e)
        {
            if (textBoxServoTurns.Text == "")
            {
                if (this.Tag.ToString() == "Servo Water")
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                }
                else
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                }
                textBoxServoTurns.Text = "0";
                return;
            }
            if (this.Tag.ToString() == "Servo Water")
            {
                double servoTurns = 0; 
                double turns = 0;
                Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                if (!regex.IsMatch(textBoxServoTurns.Text))
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textBoxServoTurns.Text = turns.ToString();
                    return;
                }
                if (textBoxServoTurns.Text == ".")
                    textBoxServoTurns.Text = "0";
                servoTurns = Convert.ToDouble(textBoxServoTurns.Text);
                if (this.textBoxServoTurns.Text != "0")
                {
                    if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                    {
                        MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                        textBoxServoTurns.Text = turns.ToString();
                    }
                }
                else
                {
                    if (servoTurns < 0)
                    {
                        MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                        textBoxServoTurns.Text = turns.ToString();
                    }
                }
            }
        }

        private void txtBoxInitialSurge_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxInitialSurge.Text == "")
                return;
            int initialSurge = 0;
            if (CurrentPress != null)
            {
                initialSurge = CurrentPress.WaterMotorServoControl.InitialSurge;
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtBoxInitialSurge.Text))
            {
                MessageBox.Show("The Range Of Initial Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                txtBoxInitialSurge.Text = initialSurge.ToString();
                return;
            }
            int iSurge = Convert.ToInt16(txtBoxInitialSurge.Text);
            if (iSurge < 0 || iSurge > DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS)
            {
                MessageBox.Show("The Range Of Initial Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                txtBoxInitialSurge.Text = initialSurge.ToString();
            }                
        }

        private void txtBoxInitialSurge_Leave(object sender, EventArgs e)
        {
            if (this.txtBoxInitialSurge.Text == "")
            {
                MessageBox.Show("The Range Of Initial Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                txtBoxInitialSurge.Text = CurrentPress.WaterMotorServoControl.InitialSurge.ToString();
            }
        }

        private void textBoxIncrementalSurge_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIncrementalSurge.Text == "")
                return;
            int incrementalSurge = 0;
            if (CurrentPress != null)
            {
                incrementalSurge = CurrentPress.WaterMotorServoControl.IncrementalSurge;
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(textBoxIncrementalSurge.Text))
            {
                MessageBox.Show("The Range Of Initial Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxIncrementalSurge.Text = incrementalSurge.ToString();
                return;
            }
            int iSurge = Convert.ToInt16(textBoxIncrementalSurge.Text);
            if (iSurge < 0 || iSurge > DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS)
            {
                MessageBox.Show("The Range Of Incremental Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxIncrementalSurge.Text = incrementalSurge.ToString();
            }             
        }
    }
}