/////////////////////////////////////////////////////////////////////////////
//  
// frmPressSiteSettings.cs: Press Site Settings
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmPressSiteSettings.cs-arc   1.5   Mar 14 2012 09:49:14   SBabu  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmPressSiteSettings.cs-arc  $
///  
///     Rev 1.5   Mar 14 2012 09:49:14   SBabu
///  MT 17637 - Added support for configuring help path and show help options
///  
///     Rev 1.4   Feb 08 2012 11:06:50   SBabu
///  MT 17529 - Modified for Auto Zero Servo feature
///  
///     Rev 1.3   Feb 19 2009 01:25:58   HNarala
///  MC3 System Weird behavior.
///  
///  
///     Rev 1.0   03 Oct 2008 14:42:08   knadler
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
    public partial class frmPressSiteSettings : Form
    {
        MCPressInfo m_CurrentPress;
        MCClientInterfaceFeatures clientInterface;   
        private int m_iMaxKeyTurnsAtConsole99;
        public frmPressSiteSettings()
        {
            InitializeComponent();
            m_CurrentPress = null;
            clientInterface = new MCClientInterfaceFeatures();
        }

        //=============================================================================
        ///<Function Name>chkType1_CheckedChanged </Function>
        /// <Auther>              09/10/2008</Auther>
        /// <summary>
        /// chkType1 Checked Changed event
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        /// </History> 
        /// ======================================================================================
        private void chkType1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType1.Checked == true)
            {
                chkType2.Checked = false;
                chkNONFS.Checked = false;
                m_iMaxKeyTurnsAtConsole99 = DefineAndConst.SystemCapacities.NON_LINEARITY_TYPE1; ;
                CheckNullValues();
            }
            else
                checkNFSTypeSelection();
        }

        //=============================================================================
        ///<Function Name>chkType2_CheckedChanged </Function>
        /// <Auther>              09/10/2008</Auther>
        /// <summary>
        /// chkType2 Checked Changed event
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        /// </History> 
        /// ======================================================================================
        private void chkType2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType2.Checked == true)
            {
                chkType1.Checked = false;
                chkNONFS.Checked = false;
                m_iMaxKeyTurnsAtConsole99 = DefineAndConst.SystemCapacities.NON_LINEARITY_TYPE2; ;
                CheckNullValues();
            }
            else
                checkNFSTypeSelection();
        }

        //=============================================================================
        ///<Function Name>chkNONFS_CheckedChanged </Function>
        /// <Auther>              09/10/2008</Auther>
        /// <summary>
        /// chkNONFS Checked Changed event
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        /// </History> 
        /// ======================================================================================
        private void chkNONFS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNONFS.Checked == true)
            {
                chkType1.Checked = false;
                chkType2.Checked = false;
                m_iMaxKeyTurnsAtConsole99 = DefineAndConst.SystemCapacities.NON_LINEARITY_NO_NFS;
                CheckNullValues();
            }
            else
                checkNFSTypeSelection();
        }


        //=============================================================================
        ///<Function Name>checkNFSTypeSelection </Function>
        /// <Auther>              09/10/2008</Auther>
        /// <summary>
        ///check NFS Type Selection 
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        /// </History> 
        /// ======================================================================================
        private void checkNFSTypeSelection()
        {
            if ((chkNONFS.Checked == false) && (chkType1.Checked == false) && (chkType2.Checked == false))
            {
                MessageBox.Show("Select any NFS Type ");
                btnOK.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateDataFromUI();
            this.Close();
        }

        //======================================================================================
        /// <Function>frmPressSiteSettings_Load</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Loads the Press Site Settings Details
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 to support the 1440 X 900 resolution
        /// </History>
        ///=====================================================================================
        private void frmPressSiteSettings_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 60);
            clientInterface = CurrentPress.ClientInterface;
            MCPressNFSTable mcPressNFS = CurrentPress.NFSTable;
            m_iMaxKeyTurnsAtConsole99 = mcPressNFS.MaxKeyTurnsAtConsole99;
            UpdateDataToUI();
        }

        //======================================================================================
        /// <Function>UpdateDataToUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data To UI
        /// </summary>
        /// <history>
        ///     07-Feb-12, Mark C, MT17529: Update AutoZeroServos option
        ///     13-AUG-12, Mark C, WI28788: Rename AutoZero to AutoZeroServos
        /// </history>        
        ///=====================================================================================
        void UpdateDataToUI()
        {
            MCClientInterfaceFeatures clientInterface = CurrentPress.ClientInterface;
            txtBladeStiffness.Text = clientInterface.BladeStiffNess.ToString();
            txtMaxNeighborKeyDelta.Text = clientInterface.MaxKeyDelta.ToString();
            txtDefaultOffset.Text = clientInterface.DefaultOffset.ToString();
            txtServoPulsesAtZoneZero.Text = clientInterface.ServoPulsesZoneAtZero.ToString();          
            txtBackOffInPulses.Text = clientInterface.PressZeroBackoffInPulses.ToString();

            chkMeterRoller.Checked = (clientInterface.MeteringRoller);

            chkBladeComp.Checked = clientInterface.BladeCompensation;
            switch (clientInterface.NonLinear)
            {
                case 0:
                    chkNONFS.Checked = true;
                    break;

                case 1:
                    chkType1.Checked = true;
                    break;

                case 49:
                    chkType2.Checked = true;
                    break;
            }

            // update the AutoZeroServos option
            checkAutoZero.Checked = CurrentPress.AutoZeroServosEnabled;
        }

        //======================================================================================
        /// <Function>CurrentPress</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Current Press
        /// </summary>
        /// 
        ///=====================================================================================
        public MCPressInfo CurrentPress
        {
            get { return m_CurrentPress; }
            set { m_CurrentPress = value; }
        }


        public bool CheckNullValues()
        {
            if ((txtBladeStiffness.Text == "") || (txtMaxNeighborKeyDelta.Text == "") || (txtDefaultOffset.Text == "") || (txtServoPulsesAtZoneZero.Text == "") || (txtBackOffInPulses.Text == ""))
            {
                btnOK.Enabled = false;
                return true;
            }
            bool bStatus = true;
            if (CheckDataChanged())
            {
                btnOK.Enabled = true;
                bStatus = false;
            }
            else
                btnOK.Enabled = false;
            return bStatus;
        }
        //======================================================================================
        /// <Function>UpdateDataFromUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data From UI
        /// </summary>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        ///     07-Feb-12, Mark C, MT 17529: Update AutoZeroServos option from UI to data member
        ///     13-Aug-12, Mark C, WI28788: Renamed AutoZero to AutoZeroServos
        /// </History>  
        ///=====================================================================================
        void UpdateDataFromUI()
        {
            MCClientInterfaceFeatures clientInterface = CurrentPress.ClientInterface;
            clientInterface.BladeStiffNess = float.Parse(txtBladeStiffness.Text);
            clientInterface.MaxKeyDelta = int.Parse(txtMaxNeighborKeyDelta.Text);
            clientInterface.DefaultOffset = int.Parse(txtDefaultOffset.Text);
            clientInterface.ServoPulsesZoneAtZero = int.Parse(txtServoPulsesAtZoneZero.Text);
            clientInterface.PressZeroBackoffInPulses = int.Parse(txtBackOffInPulses.Text);
            clientInterface.MeteringRoller = chkMeterRoller.Checked;
            clientInterface.BladeCompensation = chkBladeComp.Checked;
            //int iLTSize = 0;

            MCPressNFSTable mcPressNFS = CurrentPress.NFSTable;
            mcPressNFS.BreakPoint = DefineAndConst.SystemCapacities.NFS_TABLE_BREAK_POINT;//50;          

            if (chkNONFS.Checked == true)
            {
                clientInterface.NonLinear = 0;
            }
            else if (chkType1.Checked == true)
            {
                clientInterface.NonLinear = 1;
            }
            else
            {
                clientInterface.NonLinear = 49;
            }
            mcPressNFS.MaxKeyTurnsAtConsole99 = m_iMaxKeyTurnsAtConsole99;    
            int iTotalUnits = CurrentPress.TotalUnits;
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit aUnit = CurrentPress.GetUnitAt(iUnit);
                if (aUnit == null)
                    continue;
                for (int iInker = 0; iInker < aUnit.TotalInkers; iInker++)
                {
                    MCInker aInker = ((MCInker)(aUnit.GetInkerAt(iInker)));
                    if (aInker == null)
                        continue;
                    aInker.LinTableSize = m_iMaxKeyTurnsAtConsole99.ToString();
                }
            }

            // Auto Zero for Servos
            CurrentPress.AutoZeroServosEnabled = checkAutoZero.Checked;
        }


        /// <![CDATA[
        /// 
        /// History: 
        ///         14-May-13, BEttinger, WI30716: Make sure integer in the range of 0 to 10 can be entered only
        /// 
        /// ]]>
        /// <summary>
        /// Event processor
        /// </summary>
        private void txtBladeStiffness_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^(([0-9])|([1][0]))$");//WI30716
            if (!regex.IsMatch(txtBladeStiffness.Text))
            {
                txtBladeStiffness.Text = "";
                MessageBox.Show("An integer in the range of 0 to 10 should be entered");//WI30716
            }

            CheckNullValues();
        }

        private void txtMaxNeighborKeyDelta_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtMaxNeighborKeyDelta.Text))
            {
                txtMaxNeighborKeyDelta.Text = "";
            }
            CheckNullValues();
        }

        private void txtDefaultOffset_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtDefaultOffset.Text))
            {
                txtDefaultOffset.Text = "";
            }
            CheckNullValues();
        }

        private void txtServoPulsesAtZoneZero_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtServoPulsesAtZoneZero.Text))
            {
                txtServoPulsesAtZoneZero.Text = "";
            }
            CheckNullValues();
        }

        private void txtBackOffInPulses_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtBackOffInPulses.Text))
            {
                txtBackOffInPulses.Text = "";
            }
            CheckNullValues();
        }


        //======================================================================================
        /// <Function>CheckDataChanged</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Feb-18-2009</Date>
        /// <summary>
        /// Check Data Changed
        /// </summary>
        /// <History>
        /// Hema Dt: 02-18-2009 MT: 12642 
        ///     07-Feb-12, Mark C, MT 17529: Added support for checking AutoZeroServos option
        ///     13-AUG-12, Mark C, WI28788: Renamed AutoZero to AutoZeroServos
        /// </History>  
        ///=====================================================================================
        private bool CheckDataChanged()
        {
            bool bChangeInData = false;
            MCClientInterfaceFeatures clientInterface = CurrentPress.ClientInterface;
            if (clientInterface.BladeStiffNess != float.Parse(txtBladeStiffness.Text))
            {
                bChangeInData = true;
            }
            else if(clientInterface.MaxKeyDelta != int.Parse(txtMaxNeighborKeyDelta.Text))
            {
                bChangeInData = true;
            }
            else if(clientInterface.DefaultOffset != int.Parse(txtDefaultOffset.Text))
            {
                bChangeInData = true;
            }
            else if(clientInterface.ServoPulsesZoneAtZero != int.Parse(txtServoPulsesAtZoneZero.Text))
            {
                bChangeInData = true;
            }
            else if(clientInterface.PressZeroBackoffInPulses != int.Parse(txtBackOffInPulses.Text))
            {
                bChangeInData = true;
            }
            else if(clientInterface.MeteringRoller != chkMeterRoller.Checked)
            {
                bChangeInData = true;
            }
            else if (clientInterface.BladeCompensation != chkBladeComp.Checked)
            {
                bChangeInData = true;
            }
            else
            {
                MCPressNFSTable mcPressNFS = CurrentPress.NFSTable;
                if (mcPressNFS.MaxKeyTurnsAtConsole99 != m_iMaxKeyTurnsAtConsole99)
                {
                    bChangeInData = true;
                }
            }
            // Is there a change in AutoZeroEnabled option? 
            if ( CurrentPress.AutoZeroServosEnabled != checkAutoZero.Checked )
            {
                bChangeInData = true;
            }

            return bChangeInData;
        }

        private void chkBladeComp_CheckedChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }

        private void chkMeterRoller_CheckedChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }

        /// <![CDATA[
        /// 
        /// < Function: checkAutoZero_CheckedChanged >
        /// 
        /// < Author: Mark C>
        /// 
        /// History: 07-Feb-12, Mark C, MT 17529: Created
        /// ]]>
        /// <summary>
        /// Handles the CheckedChanged event of the checkAutoZero control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void checkAutoZero_CheckedChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }
    }
}