/////////////////////////////////////////////////////////////////////////////
//  
// PLCSweep.cs: PLC Sweep
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PLCSweep.cs-arc   1.5   Jul 21 2011 14:47:12   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PLCSweep.cs-arc  $
///  
///     Rev 1.5   Jul 21 2011 14:47:12   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.4   Mar 26 2010 00:06:18   SSomashekaran
///  MC3 - MC3SiteGen - Add Crabtree ducting support via serial Mits PLC
///  
///     Rev 1.3   May 14 2009 03:51:34   HNarala
///  for mt 13162
///  
///     Rev 1.2   Nov 12 2008 23:13:16   HNarala
///  to adjust different resolutions
///  
///     Rev 1.1   Oct 22 2008 03:36:50   HNarala
///  MT: 11396
///  
///     Rev 1.0   03 Oct 2008 14:42:10   knadler
///  Initial revision.
///  Resolution for 11396: Create MC3 Siteset application
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
    public partial class PLCSweep : Form
    {
        public bool plcConfigured;
        MCPressInfo mcPress;
        string m_plcTypeSelected = string.Empty;

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC 
		///			7/28/18	MarkC remove the enables on unused fields for selected sweep types
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="PLCSweep"/> class.
        /// </summary>
        /// <param name="plcTypeSelected">The PLC type selected.</param>
        public PLCSweep(string plcTypeSelected)
        {
            InitializeComponent();
            plcConfigured = false;
            m_plcTypeSelected = plcTypeSelected;
			DisableUnUsedControls();
        }

        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }
        private void checkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            gpPLCSettings.Enabled = !gpPLCSettings.Enabled;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StoreData();
            plcConfigured = true;
            this.Close();
        }

        //======================================================================================
        /// <Function>StoreData</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Store Data
        /// </summary>
        /// <History>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 2/8/13 MT18035  add AB poll type and rate
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// 03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// </History>
        /// 
        ///=====================================================================================
        void StoreData()
        {
            SweepControlInterface sweepInterface = mcPress.SweepInterface;
            sweepInterface.PLCType = PLCNameAndType.GetPLCType(cboPLCList.SelectedItem.ToString());
            sweepInterface.PLCCOMMPort = cboCommPorts.Text;
            sweepInterface.PLCMechDelayInMS = int.Parse(txtMechDelay.Text);
            sweepInterface.PLCTachPulsePerExec = int.Parse(txtTachPulses.Text);
            sweepInterface.PLCWashCycle = int.Parse(txtWashCycle.Text);
            sweepInterface.IsPLCUsed = checkEnabled.Checked;
            sweepInterface.PLCSampleTime = int.Parse(txtSampleTime.Text);
            sweepInterface.PLCSweepDivisor = int.Parse(txtSweepDivisor.Text);
            sweepInterface.PLCWaterDivisor = int.Parse(txtWaterDivisor.Text);
            sweepInterface.PLCWaterOutputMin = int.Parse(txtWaterOutputMin.Text);
            sweepInterface.PLCWaterStartSpeedMin = int.Parse(txtWaterStartSpeedMin.Text);
            sweepInterface.PLCWaterStartSpeedMax = int.Parse(txtWaterStartSpeedMax.Text);
            sweepInterface.PLCWaterStartupVolt = int.Parse(txtWaterStartupVolt.Text);
            sweepInterface.PLCABType = (cboABType.SelectedIndex);
            sweepInterface.PLCABDHBaud = cboDH_Baud.Text;
            sweepInterface.PLCABPLCNode = int.Parse(txtABPLCNode.Text);
            sweepInterface.PLCABASNode = int.Parse(txtABPLCASNode.Text);
            sweepInterface.PLCABFilename = txtABPLCFilename.Text;
            sweepInterface.PLCABModType =  cboABPLCMod.SelectedIndex;
            sweepInterface.PLCABPLCMap = maplabel_ABPLC(cboABPLCMapType.SelectedIndex);
            sweepInterface.PLCABPOLLTYPE = (cboABPOLLType.SelectedIndex);
            sweepInterface.PLCABPOLLRATE = int.Parse(txtABPOLLRATE.Text);
            sweepInterface.PLCNLCurve = int.Parse(txtNLCurve.Text);
            sweepInterface.PLCMotorSpeed = int.Parse(txtMotorSpeed.Text);
            sweepInterface.PLCMotorTurns = int.Parse(txtPLCmotorTurns.Text);
        }

        //======================================================================================
        /// <Function>CheckNullEntries</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Oct-03-2008</Date>
        /// <summary>
        /// to check the null entries
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// </summary>
        /// 
        ///=====================================================================================
        private bool CheckNullEntries()
        {
            if ((txtWashCycle.Text == "") || (txtMechDelay.Text == "") || (txtTachPulses.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            if ((txtSampleTime.Text == "") || (txtSweepDivisor.Text == "") || (txtWaterDivisor.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            if ((txtWaterOutputMin.Text == "") || (txtWaterStartSpeedMin.Text == "") || (txtWaterStartSpeedMax.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            if ((txtWaterStartupVolt.Text == "") || (txtNLCurve.Text == "") || (txtMotorSpeed.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            if ( (txtPLCmotorTurns.Text == "") )
            {
                btnOK.Enabled = false;
                return true;
            }
            btnOK.Enabled = true;
            return false;
        }

        private void PLCSweep_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 50);
            GenerateData();
        }

        //======================================================================================
        /// <Function>GenerateData</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Generate Data
        /// </summary>
        /// <History>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 2/8/13 MT18035  add AB poll type and rate
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// 03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// </History>
        ///  		Modified as part of WI#35675
        ///=====================================================================================
        void GenerateData()
        {
            // we need to start over from COM1 for supporting TI PLC.
            // COM1 to COM4 are normally RS232 PORTs.
            for (int i = 1; i < 25; i++)
            {
                string strCOMMPort = "COM" + i.ToString();
                cboCommPorts.Items.Add(strCOMMPort);
            }
            cboCommPorts.Items.Add("AB DH 1784-PKTX");
            SweepControlInterface sweepInterface = mcPress.SweepInterface;
            checkEnabled.Checked = sweepInterface.IsPLCUsed;
            cboPLCList.Text = m_plcTypeSelected;
            cboPLCList.Enabled = false;
            cboCommPorts.Text = sweepInterface.PLCCOMMPort;
            txtMechDelay.Text = sweepInterface.PLCMechDelayInMS.ToString();
            txtTachPulses.Text = sweepInterface.PLCTachPulsePerExec.ToString();
            txtWashCycle.Text = sweepInterface.PLCWashCycle.ToString();
            txtSampleTime.Text = sweepInterface.PLCSampleTime.ToString();
            txtSweepDivisor.Text = sweepInterface.PLCSweepDivisor.ToString();
            txtWaterDivisor.Text = sweepInterface.PLCWaterDivisor.ToString();
            txtWaterOutputMin.Text = sweepInterface.PLCWaterOutputMin.ToString();
            txtWaterStartSpeedMin.Text = sweepInterface.PLCWaterStartSpeedMin.ToString();
            txtWaterStartSpeedMax.Text = sweepInterface.PLCWaterStartSpeedMax.ToString();
            txtWaterStartupVolt.Text = sweepInterface.PLCWaterStartupVolt.ToString();
            cboABType.SelectedIndex = (sweepInterface.PLCABType);   				//AB PLC type: 1=PLC3, 2=PLC5, 3=SLC504, 4=ControlLogix
            cboDH_Baud.Text = sweepInterface.PLCABDHBaud;		                    //DH+: "57600","115200", "230400"	Baud rates
            txtABPLCNode.Text = sweepInterface.PLCABPLCNode.ToString();            //AB PLC controller node address
            txtABPLCASNode.Text = sweepInterface.PLCABASNode.ToString();		    //AB PLC App Server node address
            txtABPLCFilename.Text = sweepInterface.PLCABFilename;                  //AB PLC filename (i.e. $N18)
            cboABPLCMod.SelectedIndex = (sweepInterface.PLCABModType);  			//AB PLC modification type: 0=direct, 1=nudge through ladder logic
            cboABPLCMapType.SelectedIndex = mapABPLC_label(sweepInterface.PLCABPLCMap);		    //AB PLC address mapping scheme for PLC controller
            cboABPOLLType.SelectedIndex = (sweepInterface.PLCABPOLLTYPE);
            txtABPOLLRATE.Text = sweepInterface.PLCABPOLLRATE.ToString();
            txtNLCurve.Text = sweepInterface.PLCNLCurve.ToString();
            txtMotorSpeed.Text = sweepInterface.PLCMotorSpeed.ToString();
            txtPLCmotorTurns.Text = sweepInterface.PLCMotorTurns.ToString();
        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWashCycle_Validating(object sender, EventArgs e)
        {

            TextBox WashCycle = sender as TextBox;
            if ( null == WashCycle )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WashCycle.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Wash Cycle time. Please input valid data." );
                WashCycle.SelectAll();
                WashCycle.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WashCycle.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_WASH_CYCLE ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_WASH_CYCLE ) )
            {
                MessageBox.Show( "Invalid Wash Cycle time (0.1 sec). Valid Range is 1 to 100." );
                WashCycle.SelectAll();
                WashCycle.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtMechDelay_Validating(object sender, EventArgs e)
        {

            TextBox PLCMechDelayInMS = sender as TextBox;
            if ( null == PLCMechDelayInMS )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( PLCMechDelayInMS.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Mechanical Delay time. Please input valid data." );
                PLCMechDelayInMS.SelectAll();
                PLCMechDelayInMS.Focus();
                return;
            }

            // validate range            
            int tmpPLCMechDelayInMS = Convert.ToInt32( PLCMechDelayInMS.Text.Trim() );
            if ( ( tmpPLCMechDelayInMS < DefineAndConst.SystemCapacities.MIN_PLC_MECH_DELAY ) ||
                ( tmpPLCMechDelayInMS > DefineAndConst.SystemCapacities.MAX_PLC_MECH_DELAY ) )
            {
                MessageBox.Show( "Invalid Mechanical Delay time (ms). Valid Range is 0 to 300." );
                PLCMechDelayInMS.SelectAll();
                PLCMechDelayInMS.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtTachPulses_Validating(object sender, EventArgs e)
        {

            TextBox TachPulses = sender as TextBox;
            if ( null == TachPulses )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( TachPulses.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Tach Pulses count. Please input valid data." );
                TachPulses.SelectAll();
                TachPulses.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( TachPulses.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_TACH_PULSE ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_TACH_PULSE ) )
            {
                MessageBox.Show( "Invalid Tach Pulses count. Valid Range is 1 to 127." );
                TachPulses.SelectAll();
                TachPulses.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtSampleTime_Validating(object sender, EventArgs e)
        {

            TextBox SampleTime = sender as TextBox;
            if ( null == SampleTime )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( SampleTime.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Sample Time. Please input valid data." );
                SampleTime.SelectAll();
                SampleTime.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( SampleTime.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_SAMPLE_TIME ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_SAMPLE_TIME ) )
            {
                MessageBox.Show( "Invalid Sample Time(ms). Valid Range is 100 to 1000." );
                SampleTime.SelectAll();
                SampleTime.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtSweepDivisor_Validating(object sender, EventArgs e)
        {

            TextBox SweepDivisor = sender as TextBox;
            if ( null == SweepDivisor )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( SweepDivisor.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Sweep Divisor. Please input valid data." );
                SweepDivisor.SelectAll();
                SweepDivisor.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( SweepDivisor.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_SWP_DIVISOR ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_SWP_DIVISOR ) )
            {
                MessageBox.Show( "Invalid Sweep Divisor. Valid Range is 10 to 1000." );
                SweepDivisor.SelectAll();
                SweepDivisor.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWaterDivisor_Validating(object sender, EventArgs e)
        {

            TextBox WaterDivisor = sender as TextBox;
            if ( null == WaterDivisor )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WaterDivisor.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Water Divisor. Please input valid data." );
                WaterDivisor.SelectAll();
                WaterDivisor.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WaterDivisor.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_WTR_DIVISOR ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_WTR_DIVISOR ) )
            {
                MessageBox.Show( "Invalid Water Divisor. Valid Range is 10 to 1000." );
                WaterDivisor.SelectAll();
                WaterDivisor.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWaterOutputMin_Validating(object sender, EventArgs e)
        {

            TextBox WaterOutputMin = sender as TextBox;
            if ( null == WaterOutputMin )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WaterOutputMin.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Water Output Min. Please input valid data." );
                WaterOutputMin.SelectAll();
                WaterOutputMin.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WaterOutputMin.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_MIN_OUTPUT ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_MIN_OUTPUT ) )
            {
                MessageBox.Show( "Invalid Water Output Min. Valid Range is 0 to 1000." );
                WaterOutputMin.SelectAll();
                WaterOutputMin.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWaterStartSpeedMin_Validating(object sender, EventArgs e)
        {

            TextBox WaterStartSpeedMin = sender as TextBox;
            if ( null == WaterStartSpeedMin )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WaterStartSpeedMin.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Water Start Speed Min. Please input valid data." );
                WaterStartSpeedMin.SelectAll();
                WaterStartSpeedMin.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WaterStartSpeedMin.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_START_SPEED_MIN ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_START_SPEED_MIN ) )
            {
                MessageBox.Show( "Invalid Water Start Speed Min. Valid Range is 0 to 1000." );
                WaterStartSpeedMin.SelectAll();
                WaterStartSpeedMin.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWaterStartSpeedMax_Validating(object sender, EventArgs e)
        {

            TextBox WaterStartSpeedMax = sender as TextBox;
            if ( null == WaterStartSpeedMax )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WaterStartSpeedMax.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Water Start Speed Max. Please input valid data." );
                WaterStartSpeedMax.SelectAll();
                WaterStartSpeedMax.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WaterStartSpeedMax.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_START_SPEED_MAX ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_START_SPEED_MAX ) )
            {
                MessageBox.Show( "Invalid Water Start Speed Max. Valid Range is 0 to 1000." );
                WaterStartSpeedMax.SelectAll();
                WaterStartSpeedMax.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtWaterStartupVolt_Validating(object sender, EventArgs e)
        {

            TextBox WaterStartupVolt = sender as TextBox;
            if ( null == WaterStartupVolt )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( WaterStartupVolt.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid WaterStartupVolt. Please input valid data." );
                WaterStartupVolt.SelectAll();
                WaterStartupVolt.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( WaterStartupVolt.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_START_SPEED_VOLT ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_START_SPEED_VOLT ) )
            {
                MessageBox.Show( "Invalid WaterStartupVolt. Valid Range is 0 to 2000." );
                WaterStartupVolt.SelectAll();
                WaterStartupVolt.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Apr 14 2013</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtNLCurve_Validating(object sender, EventArgs e)
        {

            TextBox NLCurve = sender as TextBox;
            if ( null == NLCurve )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( NLCurve.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Non Linear Curve. Please input valid data." );
                NLCurve.SelectAll();
                NLCurve.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( NLCurve.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_NL_CURVE ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_NL_CURVE ) )
            {
                MessageBox.Show( "Invalid Non Linear Curve factor. Valid Range is 0 to 4." );
                NLCurve.SelectAll();
                NLCurve.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Apr 14 2013</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtMotorSpeed_Validating(object sender, EventArgs e)
        {

            TextBox MotorSpeed = sender as TextBox;
            if ( null == MotorSpeed )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( MotorSpeed.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid MotorSpeed. Please input valid data." );
                MotorSpeed.SelectAll();
                MotorSpeed.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( MotorSpeed.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_PLC_MOTOR_SPEED ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_PLC_MOTOR_SPEED ) )
            {
                MessageBox.Show( "Invalid Motor Speed. Valid Range is 0 to 30." );
                MotorSpeed.SelectAll();
                MotorSpeed.Focus();
            }

        }

        //======================================================================================
        /// <Function> _Validate control</Function>
        /// <Author>Mark C</Author>
        /// <Date>Apr 14 2013</Date>
        /// <summary>
        /// method for validation of input control: check for valid chars, checks for NULL value, validates range.
        /// Resets back to original value if fail. Range error shows message with valid range.
        /// </summary>
        /// <History>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </History>
        /// 
        ///=====================================================================================
        private void txtPLCmotorTurns_Validating(object sender, EventArgs e)
        {

            TextBox PLCmotorTurns = sender as TextBox;
            if ( null == PLCmotorTurns )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( PLCmotorTurns.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid PLC motor Turns. Please input valid data." );
                PLCmotorTurns.SelectAll();
                PLCmotorTurns.Focus();
                return;
            }

            // validate range            
            int tmpWashCycle = Convert.ToInt32( PLCmotorTurns.Text.Trim() );
            if ( ( tmpWashCycle < DefineAndConst.SystemCapacities.MIN_SWEEP_MOTOR_TURNS ) ||
                ( tmpWashCycle > DefineAndConst.SystemCapacities.MAX_SWEEP_MOTOR_TURNS ) )
            {
                MessageBox.Show( "Invalid PLC motor Turns. Valid Range is 0 to 60." );
                PLCmotorTurns.SelectAll();
                PLCmotorTurns.Focus();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //AB mapping scheme labels:
        //  BakerPerkinsPLC3
        //  BakerPerkinsPLC5
        //  GMI_STD_SLC5
        //  GMI_STD_PLC5
        //  Goss_PLC5
        //  Goss_SLC504
        //  Goss_Cxxx_PLC5
        //  HANTSCHO_MARKx
        // alignments (label to enum of AB_PLC)
        //  0 - 60
        //  1 - 61
        //  2 - 59  (also 63)
        //  3 - 62  
        //  4 - 56
        //  5 - 57  (also 58)
        //  6 - 65 
        //  7 - 50 (also 51,52)
        // unknown label - 54, 55
        private int mapABPLC_label( int iPLC )
        {
            int[] imap=new int[8]{60,61,59,62,56,57,65,50};
            int i;
            for(i=0; i<8; i++)
            {
                if( imap[i] == iPLC)
                    return i;
            }
            return -1;  //bad PLC map value
        }

        private int maplabel_ABPLC(int ilabel)
        {
            int[] imap = new int[8]{ 60, 61, 59, 62, 56, 57, 65, 50 };
            return imap[ilabel];
        }
        /// <![CDATA[              
        /// 
        /// Author: Mark Colvin
        /// History: create 7/27/18 mac WI 113814
        /// ]]>
        /// <summary>
        /// Disables the unused controls for PLC sweep/water text field dialog
        /// </summary>
        private void DisableUnUsedControls()
        {
            label25.Enabled = false;
            txtPLCmotorTurns.Enabled = false;
            label24.Enabled = false;
            label23.Enabled = false;
            txtMotorSpeed.Enabled = false;
            txtNLCurve.Enabled = false;
            txtWaterStartupVolt.Enabled = false;
            label13.Enabled = false;
            txtWaterStartSpeedMax.Enabled = false;
            label11.Enabled = false;
            txtWaterStartSpeedMin.Enabled = false;
            label12.Enabled = false;
            txtWaterOutputMin.Enabled = false;
            label10.Enabled = false;
            txtWaterDivisor.Enabled = false;
            label9.Enabled = false;
            txtSweepDivisor.Enabled = false;
            label8.Enabled = false;
            txtSampleTime.Enabled = false;
            label7.Enabled = false;
            label6.Enabled = false;
            cboPLCList.Enabled = false;
            cboCommPorts.Enabled = false;
            txtTachPulses.Enabled = false;
            txtMechDelay.Enabled = false;
            txtWashCycle.Enabled = false;
            label4.Enabled = false;
            label3.Enabled = false;
            label2.Enabled = false;
            label1.Enabled = false;
            pnlWizardTitle.Enabled = false;
            label5.Enabled = false;
			gpABPLCSettings.Enabled = false;
            txtABPOLLRATE.Enabled = false;
            label22.Enabled = false;
            cboABPOLLType.Enabled = false;
            label21.Enabled = false;
            cboABPLCMapType.Enabled = false;
            label20.Enabled = false;
            label19.Enabled = false;
            cboABPLCMod.Enabled = false;
            label18.Enabled = false;
            txtABPLCFilename.Enabled = false;
            label17.Enabled = false;
            txtABPLCASNode.Enabled = false;
            label16.Enabled = false;
            label15.Enabled = false;
            cboDH_Baud.Enabled = false;
            cboABType.Enabled = false;
            txtABPLCNode.Enabled = false;
            label14.Enabled = false;
			switch (m_plcTypeSelected)
			{
				case"Nilpeter" :
				// Wash Cycle time is 10th of 1 second
					cboCommPorts.Enabled = true;
					txtTachPulses.Enabled = true;
					txtMechDelay.Enabled = true;
					txtWashCycle.Enabled = true;
					label4.Enabled = true;
					label3.Enabled = true;
					label2.Enabled = true;
					label1.Enabled = true;
					break;
				
				case"Crabtree" :
				// Pneumatic relays control output air flow and pressure in response to a pneumatic input signal. The pneumatic delay must be determined on-site based on measurements of actual performance.
				// In general, the higher the value of the mechanical delay (in milli-seconds), the wider is the ink-stripe generated. The recommended value for Mechanical delay is 30 (Hz).
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					txtMechDelay.Enabled = true;
					label3.Enabled = true;
					break;
				
				case"Digital to Analog" :
				// The analog output PLC can control sweeps, waters, or both sweeps and waters. This PLC provides 0 to 10 volts output to control a maximum of eight units. The outputs are proportional to the press speed.
				// Sample time is A/D circuit sampling rate. Divisor set to hold output volts to 10volts.
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					txtWaterStartupVolt.Enabled = true;
					label13.Enabled = true;
					txtWaterStartSpeedMax.Enabled = true;
					label11.Enabled = true;
					txtWaterStartSpeedMin.Enabled = true;
					label12.Enabled = true;
					txtWaterOutputMin.Enabled = true;
					label10.Enabled = true;
					txtWaterDivisor.Enabled = true;
					label9.Enabled = true;
					txtSweepDivisor.Enabled = true;
					label8.Enabled = true;
					txtSampleTime.Enabled = true;
					label7.Enabled = true;
					break;
				
				case"Ragsdale" :
				// Tach Pulse is a signal generated by the tachometer roller of the PLC, one or more times per rotation. Use this option when a tachometer or sensor sends information about the entire
				// press. The larger the number, the slower the input will be. Some metal decorating presses use this configuration. Presses with ratchets on the units should NOT use this option.
				// In general, the higher the value of the tach pulses, the slower the Ductor Roller moves. The recommended value for Tach pulse is 6.
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					label4.Enabled = true;
					label3.Enabled = true;
					txtTachPulses.Enabled = true;
					txtMechDelay.Enabled = true;
					break;
				
				case"Allen Bradley" :
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					gpABPLCSettings.Enabled = true;
					pnlWizardTitle.Enabled = true;
					label5.Enabled = true;
					txtABPOLLRATE.Enabled = true;
					label22.Enabled = true;
					cboABPOLLType.Enabled = true;
					label21.Enabled = true;
					cboABPLCMapType.Enabled = true;
					label20.Enabled = true;
					label19.Enabled = true;
					cboABPLCMod.Enabled = true;
					label18.Enabled = true;
					txtABPLCFilename.Enabled = true;
					label17.Enabled = true;
					txtABPLCASNode.Enabled = true;
					label16.Enabled = true;
					label15.Enabled = true;
					cboDH_Baud.Enabled = true;
					cboABType.Enabled = true;
					txtABPLCNode.Enabled = true;
					label14.Enabled = true;
					break;
				
				case"HO + Motor" :
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					label25.Enabled = true;
					txtPLCmotorTurns.Enabled = true;
					label24.Enabled = true;
					label23.Enabled = true;
					txtMotorSpeed.Enabled = true;
					txtNLCurve.Enabled = true;
					break;
				
				case"HO + D to A" :
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					txtWaterOutputMin.Enabled = true;
					label10.Enabled = true;
					txtWaterDivisor.Enabled = true;
					label9.Enabled = true;
					txtSweepDivisor.Enabled = true;
					label8.Enabled = true;
					txtSampleTime.Enabled = true;
					label7.Enabled = true;
					label24.Enabled = true;
					label23.Enabled = true;
					txtMotorSpeed.Enabled = true;
					txtNLCurve.Enabled = true;
					break;
				
				case"Texas Instruments" :
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					break;
				
			}
        }

    }
}