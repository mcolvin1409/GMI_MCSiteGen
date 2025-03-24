/////////////////////////////////////////////////////////////////////////////
//  
// PLCwater.cs: PLC Water
//
//  Author:	Mark Colvin         June 20, 2011
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PLCwater.cs-arc   1.0   Jul 21 2011 14:51:28   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PLCwater.cs-arc  $
///  
///     Rev 1.0   Jul 21 2011 14:51:28   MColvin
///  Initial revision.
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
    public partial class PLCwater : Form
    {

        public bool plcCongigured;
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
        /// Initializes a new instance of the <see cref="PLCwater"/> class.
        /// </summary>
        /// <param name="plcTypeSelected">The PLC type selected.</param>
        public PLCwater(string plcTypeSelected)
        {
            InitializeComponent();
            plcCongigured = false;
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
            StoreWaterData();
            plcCongigured = true;
            this.Close();
        }

        //======================================================================================
        /// <Function>StoreWaterData</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// Store Data
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 2/8/13 MT18035  add AB poll type and rate
        /// 03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// </History>
        /// 
        ///=====================================================================================
        void StoreWaterData()
        {
            WaterControlInterface waterInterface = mcPress.WaterInterface;
            waterInterface.PLCType = PLCNameAndType.GetPLCType( cboPLCList.SelectedItem.ToString() );
            waterInterface.PLCCOMMPort = cboCommPorts.Text;
            waterInterface.PLCMechDelayInMS = int.Parse(txtMechDelay.Text);
            waterInterface.PLCTachPulsePerExec = int.Parse(txtTachPulses.Text);
            waterInterface.PLCWashCycle = int.Parse(txtWashCycle.Text);
            waterInterface.IsPLCUsed = checkEnabled.Checked;
            waterInterface.PLCSampleTime = int.Parse(txtSampleTime.Text);
            waterInterface.PLCSweepDivisor = int.Parse(txtSweepDivisor.Text);
            waterInterface.PLCWaterDivisor = int.Parse(txtWaterDivisor.Text);
            waterInterface.PLCWaterOutputMin = int.Parse(txtWaterOutputMin.Text);
            waterInterface.PLCWaterStartSpeedMin = int.Parse(txtWaterStartSpeedMin.Text);
            waterInterface.PLCWaterStartSpeedMax = int.Parse(txtWaterStartSpeedMax.Text);
            waterInterface.PLCWaterStartupVolt = int.Parse(txtWaterStartupVolt.Text);
            waterInterface.PLCABType = (cboABType.SelectedIndex);
            waterInterface.PLCABDHBaud = (cboDH_Baud.Text);
            waterInterface.PLCABPLCNode = int.Parse(txtABPLCNode.Text);
            waterInterface.PLCABASNode = int.Parse(txtABPLCASNode.Text);
            waterInterface.PLCABFilename = txtABPLCFilename.Text;
            waterInterface.PLCABModType = cboABPLCMod.SelectedIndex;
            waterInterface.PLCABPLCMap = maplabel_ABPLC(cboABPLCMapType.SelectedIndex);
            waterInterface.PLCABPOLLTYPE = (cboABPOLLType.SelectedIndex);
            waterInterface.PLCABPOLLRATE = int.Parse(txtABPOLLRATE.Text);
        }

        //======================================================================================
        /// <Function>CheckNullEntries</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// to check the null entries
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
            if ((txtWaterStartupVolt.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            btnOK.Enabled = true;
            return false;
        }

        private void PLCwater_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 50);
            GenerateWaterData();
        }

        //======================================================================================
        /// <Function>GenerateWaterData</Function>
        /// <Author>Mark C</Author>
        /// <Date>Jun 20 2011</Date>
        /// <summary>
        /// Generate water Data
        /// </summary>
        /// <History>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// MarkC WI29958 add AB PLC5 type 
        /// MarkC 2/8/13 MT18035  add AB poll type and rate
        /// 03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// </History>
        /// 
        ///=====================================================================================
        void GenerateWaterData()
        {
            for (int i = 1; i < 25; i++)
            {
                string strCOMMPort = "COM" + i.ToString();
                cboCommPorts.Items.Add(strCOMMPort);
            }
            string strCOMMPort1 = "AB DH 1784-PKTX";
            cboCommPorts.Items.Add(strCOMMPort1);
            WaterControlInterface waterInterface = mcPress.WaterInterface;
            checkEnabled.Checked = waterInterface.IsPLCUsed;
            cboPLCList.Text = m_plcTypeSelected;
            cboPLCList.Enabled = false;
            cboCommPorts.Text = waterInterface.PLCCOMMPort;
            txtMechDelay.Text = waterInterface.PLCMechDelayInMS.ToString();
            txtTachPulses.Text = waterInterface.PLCTachPulsePerExec.ToString();
            txtWashCycle.Text = waterInterface.PLCWashCycle.ToString();
            txtSampleTime.Text = waterInterface.PLCSampleTime.ToString();
            txtSweepDivisor.Text = waterInterface.PLCSweepDivisor.ToString();
            txtWaterDivisor.Text = waterInterface.PLCWaterDivisor.ToString();
            txtWaterOutputMin.Text = waterInterface.PLCWaterOutputMin.ToString();
            txtWaterStartSpeedMin.Text = waterInterface.PLCWaterStartSpeedMin.ToString();
            txtWaterStartSpeedMax.Text = waterInterface.PLCWaterStartSpeedMax.ToString();
            txtWaterStartupVolt.Text = waterInterface.PLCWaterStartupVolt.ToString();
            cboABType.SelectedIndex = (waterInterface.PLCABType);   //AB PLC type: 1=PLC3, 2=PLC5, 3=SLC504, 4=ControlLogix
            cboDH_Baud.Text = waterInterface.PLCABDHBaud;		                    //DH+: "57600","115200", "230400"	Baud rates
            txtABPLCNode.Text = waterInterface.PLCABPLCNode.ToString();             //AB plc controller node address
            txtABPLCASNode.Text = waterInterface.PLCABASNode.ToString();		    //AB plc app server node address
            txtABPLCFilename.Text = waterInterface.PLCABFilename;                   //AB plc filename (i.e. $N18)
            cboABPLCMod.SelectedIndex = (waterInterface.PLCABModType);  //AB plc modification type: 0=direct, 1=nudge through ladder logic
            cboABPLCMapType.SelectedIndex = mapABPLC_label(waterInterface.PLCABPLCMap);	    //AB plc address mapping scheme for plc controller
            cboABPOLLType.SelectedIndex = (waterInterface.PLCABPOLLTYPE);
            txtABPOLLRATE.Text = waterInterface.PLCABPOLLRATE.ToString();
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
        //  3 - 56
        //  4 - 57  (also 58)
        //  5 - 65 
        //  6 - 50 (also 51,52)
        // unknown label - 54, 55
        private int mapABPLC_label(int iPLC)
        {
            int[] imap = new int[8] { 60, 61, 59, 62, 56, 57, 65, 50 };
            int i;
            for (i = 0; i < 8; i++)
            {
                if (imap[i] == iPLC)
                    return i;
            }
            return -1;  //bad PLC map value
        }

        private int maplabel_ABPLC(int ilabel)
        {
            int[] imap = new int[8] { 60, 61, 59, 62, 56, 57, 65, 50 };
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
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					txtMechDelay.Enabled = true;
					label3.Enabled = true;
					break;
				
				case"Digital to Analog" :
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
				
				case"Texas Instruments" :
					cboCommPorts.Enabled = true;
					label1.Enabled = true;
					break;
				
			}
        }

    }
}