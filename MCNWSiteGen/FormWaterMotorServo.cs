/////////////////////////////////////////////////////////////////////////////
//  
// FormWaterMotorServo.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen//////////////////////////////////////////////////////////////////////////////
//  
// FormSweepMotorOrServoCtrl.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterMotorServo.cs-arc   1.0   May 14 2009 03:36:08   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterMotorServo.cs-arc  $
///  
///     Rev 1.0   May 14 2009 03:36:08   HNarala
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
using System.Collections;
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{
    public partial class FormWaterMotorServo : Form
    {
        MCPressInfo mcPress;
        public bool bothMotorServoConfigured;
        ArrayList servoConfigured;
        int itemSelected;
        public FormWaterMotorServo()
        {
            InitializeComponent();
            bothMotorServoConfigured = false;
            servoConfigured = new ArrayList();
        }
        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }

        private void ListBoxServoControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                string s = ListBoxServoControl.Items[e.Index].ToString();
                if ((e.State & DrawItemState.Selected) == 0)
                {
                    e.Graphics.FillRectangle(
                        new SolidBrush(SystemColors.Window),
                        e.Bounds);
                    e.Graphics.DrawString(s, Font,
                        new SolidBrush(SystemColors.WindowText),
                        e.Bounds);
                    int iOffset = (int)(e.Graphics.DpiX * 0.1);
                    Point pt1 = new Point(e.Bounds.Location.X + (int)e.Bounds.Width / 2 - iOffset, e.Bounds.Top);
                    Point pt2 = new Point(e.Bounds.Location.X + (int)e.Bounds.Width / 2 - iOffset, e.Bounds.Bottom);


                    e.Graphics.DrawLine(
                        new Pen(Color.LightGray), pt1, pt2);
                }
                else //Selected item
                {
                    e.Graphics.FillRectangle(
                        new SolidBrush(SystemColors.Highlight),
                        e.Bounds);
                    e.Graphics.DrawString(s, Font,
                        new SolidBrush(SystemColors.HighlightText),
                        e.Bounds);
                }
                if (e.Index == ListBoxServoControl.Items.Count - 1) //last item
                {
                    Point pt1 = new Point(e.Bounds.Location.X, e.Bounds.Bottom);
                    Point pt2 = new Point(e.Bounds.Right, e.Bounds.Bottom);

                    e.Graphics.DrawLine(
                        new Pen(Color.LightGray), pt1, pt2);
                }
            }
        }

        private void ListBoxServoControl_MouseClick(object sender, MouseEventArgs e)
        {
            listCOMPorts.Visible = false;
        }

        private void ListBoxServoControl_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            butDropDown.Visible = false;
            this.listCOMPorts.Visible = false;
        }

        private void ListBoxServoControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCOMPorts.Visible = false;
            itemSelected = this.ListBoxServoControl.SelectedIndex;
            if (itemSelected >= 0)
            {
                Rectangle r = this.ListBoxServoControl.GetItemRectangle(itemSelected);
                this.butDropDown.Location = new System.Drawing.Point(ListBoxServoControl.Location.X + ListBoxServoControl.Width - butDropDown.Width - 20, r.Y + ListBoxServoControl.Top + 1);
                this.butDropDown.Height = r.Height + 1;
                this.butDropDown.Visible = true;
                this.butDropDown.Focus();
                this.butDropDown.BringToFront();
            }
        }

        private void listCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSel = this.ListBoxServoControl.SelectedIndex;
            if (iSel >= 0)
            {
                MCInker inker = (MCInker)CurrentPress.InkerList[iSel];
                string inkerName = inker.InkerName; ;
                string configured = servoConfigured[iSel].ToString();
                string selectedConfiguration = listCOMPorts.SelectedItem.ToString();
                configured = selectedConfiguration;
                servoConfigured.RemoveAt(iSel);
                servoConfigured.Insert(iSel, configured);
                string strSpuData = string.Concat(inkerName, "          " + configured);
                ListBoxServoControl.Items.RemoveAt(iSel);
                ListBoxServoControl.Items.Insert(iSel, strSpuData);
                listCOMPorts.Visible = false;
                ListBoxServoControl.SetSelected(iSel, true);
            }
        }

        private void butDropDown_Click(object sender, EventArgs e)
        {
            int iSel = this.ListBoxServoControl.SelectedIndex;
            if (iSel >= 0)
            {
                if (listCOMPorts.Visible)
                {
                    this.listCOMPorts.Visible = false;
                }
                else
                {
                    string itemText = this.ListBoxServoControl.Items[iSel].ToString();
                    Rectangle r = this.ListBoxServoControl.GetItemRectangle(itemSelected);
                    Point aPoint = butDropDown.Location;
                    aPoint.Offset(-(r.Width / 4 * 2), butDropDown.Height + 1);
                    this.listCOMPorts.Location = aPoint;
                    //select the current commport
                    this.listCOMPorts.Text = (string)servoConfigured[iSel];
                    this.listCOMPorts.Visible = true;
                    this.listCOMPorts.BringToFront();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bothMotorServoConfigured = true;
            UpdateDataFromGUI();
            this.Close();                      
        }

        private void UpdateDataFromGUI()
        {
            CurrentPress.WaterServo = servoConfigured;
            WaterMotorServoControlInterface waterMotorServoCtrl = CurrentPress.WaterMotorServoControl;
            waterMotorServoCtrl.InitialSurge = Convert.ToInt16(this.txtBoxInitialSurge.Text);
            waterMotorServoCtrl.ServoTurns = Convert.ToDouble(this.textBoxMotorTurns.Text);
            waterMotorServoCtrl.Turns2 = Convert.ToDouble(this.textTurns2.Text);
            waterMotorServoCtrl.IncrementalSurge = Convert.ToInt16(this.textBoxIncrementalSurge.Text);
            waterMotorServoCtrl.Reversed = Convert.ToBoolean(this.comboReversed.Text);
            waterMotorServoCtrl.SpecialMapping = Convert.ToBoolean(this.comboSpecialMapping.Text);
            waterMotorServoCtrl.UseBank1 = Convert.ToBoolean(this.comboUseBank1.Text); 
        }
        void FormWaterMotorServo_Load(object sender, System.EventArgs e)
        {
            itemSelected = -1;
            DisplayServoConfiguration();
            UpdateDataToGui();
        }

        private void UpdateDataToGui()
        {
            WaterMotorServoControlInterface waterMotorServoCtrl = CurrentPress.WaterMotorServoControl;
            this.txtBoxInitialSurge.Text = waterMotorServoCtrl.InitialSurge.ToString();
            this.textBoxMotorTurns.Text = waterMotorServoCtrl.ServoTurns.ToString();
            this.textTurns2.Text = waterMotorServoCtrl.Turns2.ToString();
            this.textBoxIncrementalSurge.Text = waterMotorServoCtrl.IncrementalSurge.ToString();
            this.comboReversed.Text = waterMotorServoCtrl.Reversed.ToString();
            this.comboSpecialMapping.Text = waterMotorServoCtrl.SpecialMapping.ToString();
            this.comboUseBank1.Text = waterMotorServoCtrl.UseBank1.ToString();
        }
        private void DisplayServoConfiguration()
        {
            string configuration = "";
            ListBoxServoControl.Items.Clear();
            servoConfigured.Clear();
            int totalInkers = CurrentPress.InkerList.Count;
            if (totalInkers <= 0)
                return;
            ArrayList configuredServo = new ArrayList();
            if (CurrentPress.WaterServo.Count > 0)
            {
                configuredServo = CurrentPress.WaterServo;
            }
            for (int inker = 0; inker < totalInkers; inker++)
            {
                MCInker mcInker = (MCInker)CurrentPress.InkerList[inker];
                string inkerName = mcInker.InkerName;

             //   if (CurrentPress.WaterServo.Count > 0)
                if((configuredServo.Count > inker) && (CurrentPress.WaterServo.Count > 0))
                {
                    //configuredServo = CurrentPress.WaterServo;
                    configuration = configuredServo[inker].ToString();
                }
                else
                    configuration = "FALSE";
                ListBoxServoControl.Items.Add(inkerName + "          " + configuration);
                servoConfigured.Add(configuration);
            }
            ListBoxServoControl.SetSelected(0, true);
        }

        private void textBoxMotorTurns_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMotorTurns.Text == "")
                return;
            double servoTurns = 0;
            if (CurrentPress != null)
            {
                servoTurns = CurrentPress.WaterMotorServoControl.ServoTurns;
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(textBoxMotorTurns.Text))
            {
                MessageBox.Show("The Range of Motor Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxMotorTurns.Text = servoTurns.ToString();
                return;
            }
            int turns = Convert.ToInt16(textBoxMotorTurns.Text);
            {
                if (turns < 0 || turns > DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS)
                {
                    MessageBox.Show("The Range of Motor Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                    textBoxMotorTurns.Text = servoTurns.ToString();
                }
            }
        }

        private void textBoxMotorTurns_Leave(object sender, EventArgs e)
        {
            if (textBoxMotorTurns.Text == "")
            {
                MessageBox.Show("The Range of Motor Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxMotorTurns.Text = CurrentPress.WaterMotorServoControl.ServoTurns.ToString();                    
            }            
        }

        private void textTurns2_TextChanged(object sender, EventArgs e)
        {
            if (this.textTurns2.Text == "")
                return;
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
            if (!regex.IsMatch(textTurns2.Text))
            {
                MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                textTurns2.Text = CurrentPress.WaterMotorServoControl.Turns2.ToString();
                return;
            }
        }

        private void textTurns2_Leave(object sender, EventArgs e)
        {
            if (this.textTurns2.Text == "")
            {
                MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                textTurns2.Text = CurrentPress.WaterMotorServoControl.Turns2.ToString();
                return;
            }
            double servoTurns = Convert.ToDouble(textTurns2.Text);
            if (this.textTurns2.Text != "0")
            {
                if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textTurns2.Text = CurrentPress.WaterMotorServoControl.Turns2.ToString();
                }
            }
            else
            {
                if (servoTurns < 0)
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textTurns2.Text = CurrentPress.WaterMotorServoControl.Turns2.ToString();
                }
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

        private void textBoxIncrementalSurge_Leave(object sender, EventArgs e)
        {
            if (textBoxIncrementalSurge.Text == "")
            {
                MessageBox.Show("The Range Of Incremental Surge is : 0 - " + DefineAndConst.SystemCapacities.MAX_WATER_MOTOR_TURNS);
                textBoxIncrementalSurge.Text = CurrentPress.WaterMotorServoControl.IncrementalSurge.ToString();
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
    }
}