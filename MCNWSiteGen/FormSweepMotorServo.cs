/////////////////////////////////////////////////////////////////////////////
//  
// FormSweepMotorServo.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen////////////////////////////////////////////////////////////////////////////////  // FormSweepMotorOrServoCtrl.cs: Sweep Motor Or Servo Contorls////  Author:	Hema Kumar           May-14-2009 ////	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormSweepMotorServo.cs-arc   1.3   Jun 16 2009 05:36:10   HNarala  $////	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormSweepMotorServo.cs-arc  $///  
///     Rev 1.3   Jun 16 2009 05:36:10   HNarala
///  site file generator defect fixes
///  
///     Rev 1.2   Jun 04 2009 04:57:00   HNarala
///  MT: 13469
///  
///     Rev 1.1   May 14 2009 08:04:58   HNarala
///  13162
///  
///     Rev 1.0   May 14 2009 03:36:04   HNarala
///  Initial revision.
///  // ///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{    
    public partial class FormSweepMotorServo : Form
    {
        public bool bothMotorServoConfigured;
        MCPressInfo mcPress;
        ArrayList servoConfigured;
        int itemSelected;
        public FormSweepMotorServo()
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            bothMotorServoConfigured = true;
            UpdateDataFromGUI();
            this.Close();
        }

        private void UpdateDataFromGUI()
        {
            CurrentPress.SweepServo = servoConfigured;
            SweepMotorServoControlInterface sweepMotorServoCtrl = CurrentPress.SweepMotorServoControl;
            sweepMotorServoCtrl.StepEnabled = Convert.ToBoolean(this.cboStepEnabled.Text);
            sweepMotorServoCtrl.ServoTurns = Convert.ToDouble(this.txtServoTurns.Text);
            sweepMotorServoCtrl.Turns2 = Convert.ToDouble(this.textServoTurns2.Text);
            sweepMotorServoCtrl.Reversed = Convert.ToBoolean(this.cboReversed.Text);
            sweepMotorServoCtrl.LowBacklashUsed = Convert.ToBoolean(this.cboLowBackLashUsed.Text);
            sweepMotorServoCtrl.OffsetEnabled = Convert.ToBoolean(this.cboOffsetEnabled.Text);
            sweepMotorServoCtrl.UseBank1 = Convert.ToBoolean(this.cboUseBank1.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (CurrentPress.SweepServo.Count > 0)
            {
                configuredServo = CurrentPress.SweepServo;
            }
            for (int inker = 0; inker < totalInkers; inker++)
            {
                MCInker mcInker = (MCInker)CurrentPress.InkerList[inker];
                string inkerName = mcInker.InkerName;

                //if (CurrentPress.SweepServo.Count > 0)
                if ((configuredServo.Count > inker) && (configuredServo.Count > 0))
                {
                    //configuredServo = CurrentPress.SweepServo;
                    configuration = configuredServo[inker].ToString();
                }
                else
                    configuration = "FALSE";
                ListBoxServoControl.Items.Add(inkerName + "          " + configuration);
                servoConfigured.Add(configuration);
            }
            ListBoxServoControl.SetSelected(0, true);
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
        private void formSweepMotorServo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 12 , Location.Y + 13);
            itemSelected = -1;
            DisplayServoConfiguration();
            UpdateDataToGui();
        }

        private void UpdateDataToGui()
        {
            SweepMotorServoControlInterface sweepMotorServoCtrl = CurrentPress.SweepMotorServoControl;
            this.cboStepEnabled.Text = sweepMotorServoCtrl.StepEnabled.ToString();
            int servoTurns = Convert.ToInt16(sweepMotorServoCtrl.ServoTurns);
            this.txtServoTurns.Text = servoTurns.ToString();
            this.textServoTurns2.Text = sweepMotorServoCtrl.Turns2.ToString();
            this.cboReversed.Text = sweepMotorServoCtrl.Reversed.ToString();
            this.cboLowBackLashUsed.Text = sweepMotorServoCtrl.LowBacklashUsed.ToString();
            this.cboOffsetEnabled.Text = sweepMotorServoCtrl.OffsetEnabled.ToString();
            if (sweepMotorServoCtrl.ReadFromFile)
                this.cboUseBank1.Text = sweepMotorServoCtrl.UseBank1.ToString();
            else
                this.cboUseBank1.Text = "False";
        }
        private void listBoxSPU_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                string s = listBoxSPU.Items[e.Index].ToString();
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
                if (e.Index == listBoxSPU.Items.Count - 1) //last item
                {
                    Point pt1 = new Point(e.Bounds.Location.X, e.Bounds.Bottom);
                    Point pt2 = new Point(e.Bounds.Right, e.Bounds.Bottom);

                    e.Graphics.DrawLine(
                        new Pen(Color.LightGray), pt1, pt2);
                }
            }            
        }

        private void listBoxSPU_MouseClick(object sender, MouseEventArgs e)
        {
            listCOMPorts.Visible = false;
        }

        private void listBoxSPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCOMPorts.Visible = false;
            itemSelected = this.listBoxSPU.SelectedIndex;
            if (itemSelected >= 0)
            {
                Rectangle r = this.listBoxSPU.GetItemRectangle(itemSelected);
                this.butDropDown.Location = new System.Drawing.Point(listBoxSPU.Location.X + listBoxSPU.Width - butDropDown.Width - 20, r.Y + listBoxSPU.Top + 1);
                this.butDropDown.Height = r.Height + 1;
                this.butDropDown.Visible = true;
                this.butDropDown.Focus();
                this.butDropDown.BringToFront();
            }
        }
        private void listBoxSPU_scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {

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
                    aPoint.Offset(-(r.Width / 4 * 2) , butDropDown.Height + 1);
                    this.listCOMPorts.Location = aPoint;
                    //select the current commport
                    this.listCOMPorts.Text = (string)servoConfigured[iSel];
                    this.listCOMPorts.Visible = true;
                    this.listCOMPorts.BringToFront();
                }
            }
        }

        private void betterListBox1_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            butDropDown.Visible = false;
            this.listCOMPorts.Visible = false;
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

        private void txtServoTurns_TextChanged(object sender, EventArgs e)
        {
            if (txtServoTurns.Text == "")
                return;
            double actualServoTurns = 0;
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtServoTurns.Text))
            {
                MessageBox.Show("The Range of Servo Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS);
                txtServoTurns.Text = actualServoTurns.ToString();
                return;
            }
            int servoTurns = Convert.ToInt16(txtServoTurns.Text);
            {
                if (servoTurns < 0 ||  servoTurns > DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS)
                {
                    MessageBox.Show("The Range of Servo Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS);
                }
            }
        }

        private void txtServoTurns_Leave(object sender, EventArgs e)
        {
            if (this.txtServoTurns.Text == "")
            {
                MessageBox.Show("The Range Of Servo Turns is : 0 - " + DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS);
                txtServoTurns.Text = CurrentPress.SweepMotorServoControl.ServoTurns.ToString();
            }           
        }


        //======================================================================================
        /// <Function>textServoTurns2_Leave</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textServo Turns2 Leave event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textServoTurns2_Leave(object sender, EventArgs e)
        {
            if (this.textServoTurns2.Text == "")
            {
                MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                textServoTurns2.Text = CurrentPress.SweepMotorServoControl.Turns2.ToString();
                return;
            }
            if (textServoTurns2.Text == ".")
                textServoTurns2.Text = "0";
            double servoTurns = Convert.ToDouble(textServoTurns2.Text);
            if (this.textServoTurns2.Text != "0")
            {
                if (servoTurns < DefineAndConst.SystemCapacities.MIN_SERVO_TURNS || servoTurns > DefineAndConst.SystemCapacities.MAX_SERVO_TURNS)
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textServoTurns2.Text = DefineAndConst.SystemCapacities.MIN_SERVO_TURNS.ToString();
                }
            }
            else
            {
                if (servoTurns < 0)
                {
                    MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                    textServoTurns2.Text = servoTurns.ToString();//CurrentPress.SweepMotorServoControl.Turns2.ToString();
                }
            }
        }

        private void textServoTurns2_TextChanged(object sender, EventArgs e)
        {
            if (this.textServoTurns2.Text == "")
                return;
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
            if (!regex.IsMatch(textServoTurns2.Text))
            {
                MessageBox.Show("The Range Of Servo Turns is 0 or between : " + DefineAndConst.SystemCapacities.MIN_SERVO_TURNS + " - " + DefineAndConst.SystemCapacities.MAX_SERVO_TURNS);
                textServoTurns2.Text = CurrentPress.SweepMotorServoControl.Turns2.ToString();
                return;
            }
        }        
    }
   //public class Win32 
   // { 
   //       [DllImport("User32.Dll")] 
   //       public static extern bool SendMessage(IntPtr hWnd,int Msg,int wParam,int  lParam);       
   //       public const int WM_VSCROLL = 0x0115; 
   //       public const int SB_LINEDOWN = 1; 
   // } 
    public class BetterListBox : ListBox
    {
        public delegate void BetterListBoxScrollDelegate(object Sender, BetterListBoxScrollArgs e);
        public event BetterListBoxScrollDelegate Scroll;
        // WM_VSCROLL message constants
        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBTRACK = 5;
        private const int SB_ENDSCROLL = 8;

        protected override void WndProc(ref Message m)
        {
            // Trap the WM_VSCROLL message to generate the Scroll event
            base.WndProc(ref m);
            if (m.Msg == WM_VSCROLL)
            {
                int nfy = m.WParam.ToInt32() & 0xFFFF;
                if (Scroll != null && (nfy == SB_THUMBTRACK || nfy == SB_ENDSCROLL))
                    Scroll(this, new BetterListBoxScrollArgs(this.TopIndex, nfy == SB_THUMBTRACK));
            }
        }
        public class BetterListBoxScrollArgs
        {
            // Scroll event argument
            private int mTop;
            private bool mTracking;
            public BetterListBoxScrollArgs(int top, bool tracking)
            {
                mTop = top;
                mTracking = tracking;
            }
            public int Top
            {
                get { return mTop; }
            }
            public bool Tracking
            {
                get { return mTracking; }
            }
        }
    }

}