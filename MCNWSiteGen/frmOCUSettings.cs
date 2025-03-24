/////////////////////////////////////////////////////////////////////////////
//  
// frmOCUSettings.cs: OCU settings gerator
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmOCUSettings.cs-arc   1.6   Jan 17 2011 00:12:14   SRajarapu  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmOCUSettings.cs-arc  $
///  
///     Rev 1.6   Jan 17 2011 00:12:14   SRajarapu
///  13878: MC3SiteGen: Implement funny Fountains support
///  
///     Rev 1.5   Mar 12 2010 00:09:08   SRajarapu
///  15258: Client 1.19 crashes with the attached site file.
///  
///     Rev 1.4   Mar 04 2010 04:39:34   HNarala
///  To fix 15342, 45333
///  
///     Rev 1.3   Nov 13 2009 03:29:40   HNarala
///  MC3SiteGen: Changes to the total keys is not updating the OCU zones count
///  
///     Rev 1.2   Nov 12 2008 21:38:00   HNarala
///  for the screen resolution of 1440 X 900
///  
///     Rev 1.1   Oct 22 2008 03:36:26   HNarala
///  MT: 11396
///  
///     Rev 1.0   03 Oct 2008 14:42:02   knadler
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
    public partial class frmOCUSettings : Form
    {
        MCPressInfo mcPressInfo;
        public frmOCUSettings()
        {
            InitializeComponent();
        }
        public MCPressInfo CurrentPress
        {
            set { mcPressInfo = value; }
            get { return mcPressInfo; }
        }

        //======================================================================================
        /// <Function>frmOCUSettings_Load</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Loads the OCU Details
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 to support the 1440 X 900 resolution
        /// </History>
        ///=====================================================================================
        private void frmOCUSettings_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 35);
            GenerateOCUDetails();
        }

        //======================================================================================
        /// <Function>GenerateOCUDetails</Function>
        /// <Author>Chetan</Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Generates the OCU Details
        /// </summary>
        /// 
        ///=====================================================================================
        void GenerateOCUDetails()
        {
            MCPressConsoleZones mcConsoleZones = mcPressInfo.OCUInterface;
            txtNumOfZones.Text = mcConsoleZones.NumberOfZones.ToString(); ;
            txtZoneWidth.Text = mcConsoleZones.ZoneWidth.ToString();
            txtMinVal.Text = mcConsoleZones.MinValue.ToString(); ;
            txtMaxValue.Text = mcConsoleZones.MaxValue.ToString ();
        }

        /// <![CDATA[
        /// 
        /// Function: StoreOCUDetails
        ///
        /// Author: Chetan
        /// 
        /// History: Hema Dt: 11/13/2009 MT: 14770
        ///         Hema Kumar Dt: 03/04/2010 MT: 15342
        ///         Suresh, Oct-06-2010, MT 13878 (removed zone number, zone width storage)
        ///         11-Jan-17, Mark C, WI97682: Update the number of servos of each Inker when the #of zones on OCU changes
        ///         07-July-20, Mark C, 200927: Update Display Zones when #of console zones changes
        ///         21-July-20, Mark C, 200927: Update the WidePress option status when the total key count is > 44
        /// 
        /// ]]>
        /// <summary>
        /// Stores the OCU Details
        /// </summary>
        void StoreOCUDetails()
        {
            try
            {
                MCPressConsoleZones mcConsoleZones = mcPressInfo.OCUInterface;

                int iZones = Convert.ToInt32(this.txtNumOfZones.Text);
                mcConsoleZones.NumberOfZones = iZones;
                // Update Display Zones when #of console zones changes
                mcPressInfo.DisplayKeys = iZones;

                // Select Wide Press option if total keys > 44
                mcPressInfo.MCClientInterface.WidePress = ( iZones > DefineAndConst.SystemCapacities.MAX_SERVOS_PER_SPU_PORT );

                float fZoneWidth = float.Parse(txtZoneWidth.Text);
                mcConsoleZones.ZoneWidth = fZoneWidth;

                mcConsoleZones.MinValue = int.Parse(txtMinVal.Text);
                mcConsoleZones.MaxValue = int.Parse(txtMaxValue.Text);

                int iTotalUnits = CurrentPress.TotalUnits;
                for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
                {
                    MCPressUnit aUnit = CurrentPress.GetUnitAt(iUnit);
                    if (aUnit == null)
                        continue;
                    for (int iInker = 0; iInker < aUnit.TotalInkers; iInker++)
                    {
                        MCInker inker = aUnit.GetInkerAt( iInker ) as MCInker;
                        if ( null != inker )
                        {
                            inker.MaxConsole = mcConsoleZones.MaxValue.ToString( );
                            inker.MinConsole = mcConsoleZones.MinValue.ToString( );
                            // update the #of servos of each Inker as per the #of zones on OCU, only when the Funny Fountain setting is NOT selected
                            if ( !mcPressInfo.MCClientInterface.FunnyFountains )
                            {
                                inker.TotalKeys = iZones;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StoreOCUDetails();
            this.Close();
        }

        private void txtMaxValue_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtMaxValue.Text))
            {
                txtMaxValue.Text = "";
            }
            CheckNullEntries();
            if (txtMaxValue.Text == "")
                return;

            int iMaxVal = int.Parse (txtMaxValue.Text);
            //if (iMaxVal < 0 || iMaxVal > 99)
            if (iMaxVal < 0 || iMaxVal > DefineAndConst.SystemCapacities.MAX_SERVOCONSOLE_VALUE)
            {
                MessageBox.Show("Invalid Range");
                txtMaxValue.Text = "";
                return;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: txtNumOfZones_TextChanged
        ///
        /// Author: Someone
        /// 
        /// History: Hema Dt: 11/13/2009 MT: 14770
        ///         Suresh, Mar-12-2010, MT 15258
        ///         Suresh, Oct-06-2010, MT 13878 (Changed show message information)
        /// 
        /// ]]>
        /// <summary>
        /// txtNumOfZones TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumOfZones_TextChanged(object sender, EventArgs e)
        {
            if ("" == txtNumOfZones.Text)
            {
                CheckNullEntries();
                return;
            }
            Regex regex = new Regex("^[0-9]*$");
            byte iMaxZoneCount = DefineAndConst.SystemCapacities.CQ_MAX_FOUNTAIN_KEYS;
            if (!regex.IsMatch(txtNumOfZones.Text))
            {
                MessageBox.Show("Please enter a number between 1 - " + iMaxZoneCount.ToString());
                txtNumOfZones.Text = mcPressInfo.GetMostCommonKeysPerFountain().ToString();
                return;
            }
            CheckNullEntries();
            int iNumOfZones = Convert.ToInt32(txtNumOfZones.Text);
            if (iNumOfZones <= 0 || iNumOfZones > iMaxZoneCount)
            {
                MessageBox.Show("The total zones range is: 1 - " + iMaxZoneCount.ToString());
                txtNumOfZones.Text = mcPressInfo.GetMostCommonKeysPerFountain().ToString();
            }
        }

        private bool CheckNullEntries()
        {
            if ((txtNumOfZones.Text == "") || (txtZoneWidth.Text == "") || (txtMinVal.Text == "") || (txtMaxValue.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            else
            {
                btnOK.Enabled = true;
                return false;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: txtZoneWidth_TextChanged
        ///
        /// Author: Someone
        /// 
        /// History: Hema Kumar Dt: 03/04/2010 MT: 15342
        ///         Suresh, Oct-06-2010, MT 13878 (to validate mcPressInfo)
        /// 
        /// ]]>
        /// <summary>
        /// txt ZoneWidth TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtZoneWidth_TextChanged(object sender, EventArgs e)
        {
            if (null == mcPressInfo)
                return;

            MCPressConsoleZones mcConsoleZones = mcPressInfo.OCUInterface;
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
            if (!regex.IsMatch(txtZoneWidth.Text))
            {
                txtZoneWidth.Text = mcConsoleZones.ZoneWidth.ToString();
            }
            frmMain mainForm = new frmMain();
            string strZoneWidth = txtZoneWidth.Text;
            bool bValidateDigts = mainForm.IsValidRangeNumber(strZoneWidth);
            if (!bValidateDigts)
            {
                txtZoneWidth.Text = strZoneWidth.Remove(strZoneWidth.Length - 1); ;
            }
            CheckNullEntries();
        }

        /// <![CDATA[
        /// 
        /// Function: SetZoneWidth
        ///
        /// Author: Suresh
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// to SetZoneWidth when user changes from the fountains configuration view
        /// </summary>
        /// <param name="strZoneWidth"></param>
        public void SetZoneWidth(string strZoneWidth)
        {
            this.txtZoneWidth.Text = strZoneWidth;

            MCPressConsoleZones mcConsoleZones = CurrentPress.OCUInterface;
            mcConsoleZones.ZoneWidth = float.Parse(strZoneWidth);
        }

        /// <![CDATA[
        /// 
        /// Function: SetNumberOfZones
        ///
        /// Author: Suresh
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// to SetNumberOfZones after user enters the all fountains keys for funny fountains
        /// </summary>
        /// <param name="strZones"></param>
        public void SetNumberOfZones(string strZones)
        {
            this.txtNumOfZones.Text = strZones;

            MCPressConsoleZones mcConsoleZones = CurrentPress.OCUInterface;
            mcConsoleZones.NumberOfZones = int.Parse(strZones);
        }

        private void txtMinVal_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtMinVal.Text))
            {
                txtMinVal.Text = "";
            }
            CheckNullEntries();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}