/////////////////////////////////////////////////////////////////////////////
//  
// frmUtilityTestSettings.cs: Utility Test Settings
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmUtilityTestSettings.cs-arc   1.6   Feb 03 2011 00:56:34   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmUtilityTestSettings.cs-arc  $
///  
///     Rev 1.6   Feb 03 2011 00:56:34   HNarala
///  Mercury Client: Operator configuration of  'Sweep Test' under diagnostics
///  
///     Rev 1.5   Jul 08 2010 05:20:04   HNarala
///  MC3SiteGen: With version 1.17, from 'Auto Test Settings' view "Total Servos Per Unit" can not be configured more than 16.
///  
///     Rev 1.4   Apr 20 2010 00:49:56   SSomashekaran
///  MC3SiteGen: Modify the NoOfTestCycles parameter from drop down list to editable field
///  
///     Rev 1.3   Mar 04 2010 04:39:42   HNarala
///  To fix 15342, 45333
///  
///     Rev 1.2   Mar 03 2010 04:16:12   SRajarapu
///  some issues
///  
///     Rev 1.1   Oct 15 2009 01:57:18   HNarala
///  to fix MC3SiteGen: Spell 'Settings' not correct from view titles 'Auto Test Settings' and 'Sweep Test Settings'.
///  
///     Rev 1.0   May 14 2009 03:37:18   HNarala
///  Initial revision.
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
    public partial class frmUtilityTestSettings : Form
    {
        MCPressInfo m_CurrentPress;
        MCClientInterfaceFeatures clientInterface; 
        public frmUtilityTestSettings()
        {
            InitializeComponent();
            m_CurrentPress = null;
            clientInterface = new MCClientInterfaceFeatures();
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
        /// Hem Dt: 10-12-2009 MT: 14451
        /// Hema Dt: 04-03-2010 MT: 15333
        /// Hema Dt: 01-Jan-2011 MT: 16253
        /// </History>
        ///=====================================================================================
        private void frmUtilityTestSettings_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 60);
            if (this.Tag != null)
            {
                if (this.Tag.ToString() == "Sweep Test")
                {
                    this.comboCloseKeysUpTo.Enabled = false;
                    comboCloseKeysUpTo.Text = "0";
                    this.comboLooptype.Enabled = false;
                    this.comboLooptype.Text = "Sequential";
                    this.labelOpenKeysSweep.Text = "Open Sweeps Up To";
                    this.labelServoPorts.Text = "Which Port To Test";
                    textTotalServostoTest.Text = MCNWSiteGen.DefineAndConst.SystemCapacities.SWEEP_PORT.ToString();
                    textTotalServostoTest.Enabled = false;
                    this.labelUnitsSweeps.Text = "Total Sweeps To Test";
                    this.labeltitle.Text = "Sweep Test Settings";
                    tbOpenUpTo.Visible = true;
                    lbPercentag.Visible = true;
                    comboOpenKeysUpTo.Visible = false;
                }
            }
            UpdateDataToUI();
        }

        //======================================================================================
        /// <Function>UpdateDataToUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <History>
        /// Suresh, Mar-02-2010, MT#15362
        /// Hema Dt: 04-03-2010 MT: 15333
        /// Sreejit, 20-Apr-2010 MT: 15567
        /// Hema Dt: 01-Jan-2011 MT: 16253
        /// </History>
        /// <summary>
        /// Update Data To UI
        /// </summary>
        /// 
        ///=====================================================================================
        void UpdateDataToUI()
        {
            if (this.Tag.ToString() == "Auto Test")
            {
                MCAutoTest mcAutoTest = CurrentPress.AutoTest;
                textBoxTotalSPUsToTest.Text = mcAutoTest.TotalSpusToTest.ToString();
                textTotalUnitstoTest.Text = mcAutoTest.TotalUnitsToTest.ToString();
                textTotalServostoTest.Text = mcAutoTest.TotalServosToTest.ToString();
                double closeKey = findCloseKey(mcAutoTest.CloseKeysUpTo);
                comboCloseKeysUpTo.Text = closeKey.ToString();
                int timeDelay = findTimeDelay(mcAutoTest.TimeDelay);
                comboTimeDelay.Text = timeDelay.ToString();
                textNumberOfCycles.Text = mcAutoTest.NumberOfCycles.ToString();
                string loopTpe = findLoopType(mcAutoTest.LoopType);
                comboLooptype.Text = loopTpe;
                int openKeysUpTo = findOpenKeysUpTo(mcAutoTest.OpenKeysUpTo);
                comboOpenKeysUpTo.Text = openKeysUpTo.ToString();
                textTotalServostoTest.Text = m_CurrentPress.GetMostCommonKeysPerFountain().ToString();
            }
            else
            {
                MCSweepTest mcSweepTest = CurrentPress.SweepTest;
                textBoxTotalSPUsToTest.Text = mcSweepTest.TotalSpusToTest.ToString();
                textTotalUnitstoTest.Text = mcSweepTest.TotalSweepsToTest.ToString();
                int timeDelay = findTimeDelay(mcSweepTest.TimeDelay);
                comboTimeDelay.Text = timeDelay.ToString();
                textNumberOfCycles.Text = mcSweepTest.NumberOfCycles.ToString();
                comboOpenKeysUpTo.Text = "630";
                tbOpenUpTo.Text = mcSweepTest.OpenSweepUpTo.ToString();
            }
        
        }


        private int findOpenKeysUpTo(int openKeysUpTo)
        {
            int open = 630;
            if (openKeysUpTo == 2)
                open = 2982;
            else if (openKeysUpTo == 3)
                open = 1000;
            return open;
        }

        private string findLoopType(int loopType)
        {
            string loop = "Sequential";
            if (loopType == 2)
                loop = "Simultaneous";
            return loop;
        }

        private double findCloseKey(int closeKey)
        {
            double close = 0;
            if (closeKey == 2)
                close = 0.1;
            else if (closeKey == 3)
                close = 0.3;
            return close;
        }

        private int findTimeDelay(int timeDelay)
        {
            int time = 1;
            if (timeDelay == 2)
                time = 30;
            else if (timeDelay == 3)
                time = 60;
            return time;
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

        /// <![CDATA[
        /// 
        /// Function: CheckNullValues
        ///
        /// Author: Someone
        /// 
        /// History: Modified by Sreejit on 20-Apr-2010 fot MT# 15567
        ///          - Modify the NoOfTestCycles parameter from drop down
        ///            list to editable field
        /// 		  Hema Dt: 01-Jan-2011 MT: 16253
        /// 
        /// ]]>
        /// <summary>
        /// Check for Null Values
        /// </summary>
        /// <param name=></param>
        /// <param name=></param>
        public bool CheckNullValues()
        {
            if ((textBoxTotalSPUsToTest.Text == "") || (textTotalServostoTest.Text == "") || (textTotalUnitstoTest.Text == "")
                                    || (textNumberOfCycles.Text == "") || (tbOpenUpTo.Text.Equals(string.Empty)))
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
        /// Hema Dt: 04-03-2010 MT: 15333
        /// Sreejit Dt:20-Apr-2010 MT: 15567
        /// Hema Dt: 01-Jan-2011 MT: 16253
        /// </History>  
        ///=====================================================================================
        void UpdateDataFromUI()
        {
            string strTotalCycles = textNumberOfCycles.Text;
            int numberOfCycles = 1;
            int iValue;
            bool bIsValidNumber = int.TryParse(strTotalCycles, out iValue);
            if (bIsValidNumber)
            {
                numberOfCycles = iValue;
            }
            if (this.Tag.ToString() == "Auto Test")
            {
                MCAutoTest mcAutoTest = CurrentPress.AutoTest;
                mcAutoTest.TotalSpusToTest = Convert.ToInt16(textBoxTotalSPUsToTest.Text);
                mcAutoTest.TotalUnitsToTest = Convert.ToInt16(textTotalUnitstoTest.Text);
                mcAutoTest.TotalServosToTest = Convert.ToInt16(textTotalServostoTest.Text);
                int closeKey = GetCloseKeyPostion(comboCloseKeysUpTo.Text);
                mcAutoTest.CloseKeysUpTo = closeKey;
                int timeDelay = GetTimeDelay(comboTimeDelay.Text);
                mcAutoTest.TimeDelay = timeDelay;
                mcAutoTest.NumberOfCycles = numberOfCycles;
                int LoopType = GetLoopType(comboLooptype.Text);
                mcAutoTest.LoopType = LoopType;
                int openKeys = GetOpenKeyPosition(comboOpenKeysUpTo.Text);
                mcAutoTest.OpenKeysUpTo = openKeys;
            }
            else
            {
                MCSweepTest mcSweepTest = CurrentPress.SweepTest;
                mcSweepTest.TotalSpusToTest = Convert.ToInt16(textBoxTotalSPUsToTest.Text);
                mcSweepTest.WhichPortToTest = Convert.ToInt16(textTotalServostoTest.Text);  
                mcSweepTest.TotalSweepsToTest = Convert.ToInt16(textTotalUnitstoTest.Text); 
                int timeDelay = GetTimeDelay(comboTimeDelay.Text);
                mcSweepTest.TimeDelay = timeDelay;
                
                mcSweepTest.NumberOfCycles = numberOfCycles;
                mcSweepTest.OpenSweepUpTo = Convert.ToInt16(tbOpenUpTo.Text);
            }
        }

        private int GetOpenKeyPosition(string openKeys)
        {
            int openPosition = 1;
            if (openKeys == "2982")
                openPosition = 2;
            else if (openKeys == "1000")
                openPosition = 3;
            return openPosition;
        }

        private int GetLoopType(string loopType)
        {
            int loop = 1;
            if (loopType == "Simultaneous")
                loop = 2;
            return loop;
        }

        private int GetTimeDelay(string timeDelay)
        {
            int delay = 1;
            if (timeDelay == "30")
                delay = 2;
            else if (timeDelay == "60")
                delay = 3;
            return delay;
        }

        private int GetCloseKeyPostion(string closeKey)
        {
            int closePosition = 1;
            if (closeKey == "0.1")
                closePosition = 2;
            else if (closeKey == "0.3")
                closePosition = 3;
            return closePosition;
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
        /// Sreejit Dt: 20-Apr-2010 MT: 15567
        /// Hema Dt: 01-Jan-2011 MT: 16253
        /// </History>  
        ///=====================================================================================
        private bool CheckDataChanged()
        {
            bool bChangeInData = false;
           
            if (comboCloseKeysUpTo.Text == "" || comboTimeDelay.Text == "" || textNumberOfCycles.Text == "" ||
                    comboLooptype.Text == "" || comboOpenKeysUpTo.Text == "")
                return bChangeInData;
            if (this.Tag.ToString() == "Auto Test")
            {                
                MCAutoTest mcAutoTest = CurrentPress.AutoTest;
                if (mcAutoTest.TotalSpusToTest != Convert.ToInt16(textBoxTotalSPUsToTest.Text))
                    bChangeInData = true;

                else if (mcAutoTest.TotalUnitsToTest != Convert.ToInt16(textTotalUnitstoTest.Text))
                {
                    bChangeInData = true;
                }
                else if (mcAutoTest.TotalServosToTest != Convert.ToInt16(textTotalServostoTest.Text))
                {
                    bChangeInData = true;
                }
                //else if (mcAutoTest.CloseKeysUpTo != Convert.ToInt16(comboCloseKeysUpTo.Text))
                else if (mcAutoTest.CloseKeysUpTo != GetCloseKeyPostion(comboCloseKeysUpTo.SelectedItem.ToString()))
                {
                    bChangeInData = true;
                }
                //else if (mcAutoTest.TimeDelay != Convert.ToInt16(comboTimeDelay.SelectedItem))
                else if (mcAutoTest.TimeDelay != GetTimeDelay(comboTimeDelay.SelectedItem.ToString()))
                {
                    bChangeInData = true;
                }
                else if (mcAutoTest.NumberOfCycles != Convert.ToInt16(textNumberOfCycles.Text))
                {
                    bChangeInData = true;
                }
                else if (mcAutoTest.LoopType != GetLoopType(comboLooptype.SelectedItem.ToString())) //Convert.ToInt16(comboLooptype.SelectedItem))
                {
                    bChangeInData = true;
                }
                else if (mcAutoTest.OpenKeysUpTo != GetOpenKeyPosition(comboOpenKeysUpTo.SelectedItem.ToString()))//Convert.ToInt16(comboOpenKeysUpTo.SelectedItem))
                {
                    bChangeInData = true;
                }
            }
            else
            {
                MCSweepTest mcSweepTest = CurrentPress.SweepTest;
                if (mcSweepTest.TotalSpusToTest != Convert.ToInt16(textBoxTotalSPUsToTest.Text))
                    bChangeInData = true;

                else if (mcSweepTest.TotalSweepsToTest != Convert.ToInt16(textTotalUnitstoTest.Text))
                {
                    bChangeInData = true;
                }
                else if (mcSweepTest.TimeDelay != GetTimeDelay(comboTimeDelay.SelectedItem.ToString()))//Convert.ToInt16(comboTimeDelay.SelectedItem))
                {
                    bChangeInData = true;
                }
                else if (mcSweepTest.NumberOfCycles != Convert.ToInt16(textNumberOfCycles.Text))
                {
                    bChangeInData = true;
                }
                else if(mcSweepTest.OpenSweepUpTo != Convert.ToInt16(tbOpenUpTo.Text))
                {
                    bChangeInData = true;
                }
            }
            return bChangeInData;
        }
        
        private void textBoxTotalSPUsToTest_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTotalSPUsToTest.Text == "")
                return;
            int availableSPU = 1;
            if (m_CurrentPress != null)
            {
                availableSPU = m_CurrentPress.GetNumOfSPUs();
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(textBoxTotalSPUsToTest.Text))
            {
                MessageBox.Show("The range of SPUs to test is : " + 1 + " - " + availableSPU);
                textBoxTotalSPUsToTest.Text = availableSPU.ToString();                
            }
            CheckNullValues();
            int totalSpusToTest = Convert.ToInt16(textBoxTotalSPUsToTest.Text);
            if (totalSpusToTest < 1 || totalSpusToTest > availableSPU)
            {
                MessageBox.Show("The range of SPUs to test is : " + 1 + " - " + availableSPU);
                textBoxTotalSPUsToTest.Text = availableSPU.ToString();
            }
        }

        /// <![CDATA[
        /// 
        /// Function: textTotalUnitstoTest_TextChanged
        ///
        /// Author: Unknown
        /// 
        /// History: Hema Kumar MT: 14448, July-07-2010
        /// 
        /// ]]>
        /// <summary>
        /// tbKeysPerFrame textNumberOfCycles_Leave event
        /// </summary>
        private void textTotalUnitstoTest_TextChanged(object sender, EventArgs e)
        {
            string totalUnitsOrSweepToTest = textTotalUnitstoTest.Text;
            if (string.IsNullOrEmpty( totalUnitsOrSweepToTest ))
            {
                return;
            }
            if (null == m_CurrentPress)
            {
                return;
            }
            int availableUnits = m_CurrentPress.TotalUnits;
            if (this.Tag.ToString().Equals("Auto Test", StringComparison.InvariantCultureIgnoreCase))
            {
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(totalUnitsOrSweepToTest))
                {
                    MessageBox.Show("The range of Units to test is : " + 1 + " - " + availableUnits);
                    textTotalUnitstoTest.Text = availableUnits.ToString();
                }
                CheckNullValues();
                int totalUnitstoTest = Convert.ToInt16(textTotalUnitstoTest.Text);
                if (totalUnitstoTest < 1 || totalUnitstoTest > availableUnits)
                {
                    MessageBox.Show("The range of Units to test is : " + 1 + " - " + availableUnits);
                    textTotalUnitstoTest.Text = availableUnits.ToString();
                }
            }
            else
            {
                int SweepToTest = m_CurrentPress.SweepTest.TotalSweepsToTest;
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(totalUnitsOrSweepToTest))
                {
                    MessageBox.Show("The range of sweeps to test is : " + 1 + " - " + availableUnits);
                    textTotalUnitstoTest.Text = SweepToTest.ToString();
                }
                CheckNullValues();
                int totalSweepToTest = Convert.ToInt16(textTotalUnitstoTest.Text);
                if (totalSweepToTest < 1 || totalSweepToTest > availableUnits)
                {
                    MessageBox.Show("The range of sweeps to test is : " + 1 + " - " + availableUnits);
                    textTotalUnitstoTest.Text = SweepToTest.ToString();
                }
            }
        }

        //======================================================================================
        /// <Function>textTotalServostoTest_TextChanged</Function>
        /// <Date>Sep-21-2008</Date>
        /// <History>
        /// Suresh, Mar-02-2010, MT#15362
        /// </History>
        /// <summary>
        /// to update the TotalServosToTest text box
        /// </summary>
        /// 
        ///=====================================================================================
        private void textTotalServostoTest_TextChanged(object sender, EventArgs e)
        {
            if (textTotalServostoTest.Text == "")
                return;
            if (this.Tag.ToString() == "Auto Test")
            {
                int availableServos = 0;
                if (m_CurrentPress != null)
                {
                    availableServos = m_CurrentPress.GetMostCommonKeysPerFountain();
                }
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textTotalServostoTest.Text))
                {
                    MessageBox.Show("The range of Servos to test is : " + 1 + " - " + availableServos);
                    textTotalServostoTest.Text = availableServos.ToString();
                }
                CheckNullValues();
                int totalServosToTest = Convert.ToInt16(textTotalServostoTest.Text);
                if (totalServosToTest < 1 || totalServosToTest > availableServos)
                {
                    MessageBox.Show("The range of Servos to test is : " + 1 + " - " + availableServos);
                    textTotalServostoTest.Text = availableServos.ToString();
                }
            }
            else
            {
                int portToTest = 1;
                if (m_CurrentPress != null)
                {
                    portToTest = m_CurrentPress.SweepTest.WhichPortToTest;
                }
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textTotalServostoTest.Text))
                {
                    MessageBox.Show("The range port to test is : " + 1 + " - " + 8);
                    textTotalServostoTest.Text = portToTest.ToString();
                }
                CheckNullValues();
                int totalSweepToTest = Convert.ToInt16(textTotalServostoTest.Text);
                if (totalSweepToTest < 1 || totalSweepToTest > 8)
                {
                    MessageBox.Show("The range port to test is : " + 1 + " - " + 8);
                    textTotalServostoTest.Text = portToTest.ToString();
                }
            }
        }

        private void comboTimeDelay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int timeDelay = 1;
            //if (this.Tag.ToString() == "Auto Test")
            //{
            //    if (m_CurrentPress != null)
            //    {
            //        timeDelay = m_CurrentPress.AutoTest.TimeDelay;
            //    }
            //    CheckNullValues();
            //}
            //else
            //{                
            //    if (m_CurrentPress != null)
            //    {
            //        timeDelay = m_CurrentPress.SweepTest.TimeDelay;
            //    }
            //    CheckNullValues();
            //}
            CheckNullValues();
        }

        private void comboNumberOfCycles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }

        private void comboLooptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNullValues();            
        }

        private void comboCloseKeysUpTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }

        private void comboOpenKeysUpTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckNullValues();
        }

        private void textBoxTotalSPUsToTest_Leave(object sender, EventArgs e)
        {
            if (textBoxTotalSPUsToTest.Text == "")
            {
                int availableSPU = CurrentPress.GetNumOfSPUs();
                if (this.Tag.ToString() == "Auto Test")
                {
                    MessageBox.Show("The range of SPUs to test is : " + 1 + " - " + availableSPU);
                    textBoxTotalSPUsToTest.Text = CurrentPress.AutoTest.TotalSpusToTest.ToString();
                }
                else
                {
                    MessageBox.Show("The range of SPUs to test is : " + 1 + " - " + availableSPU);
                    textBoxTotalSPUsToTest.Text = CurrentPress.SweepTest.TotalSpusToTest.ToString();
                }
            }
        }
        /// <![CDATA[
        /// 
        /// Function: textNumberOfCycles_Leave
        ///
        /// Author: Sreejit
        /// 
        /// History: Created for DEF 15567, Apr-20-2010
        /// 
        /// ]]>
        /// <summary>
        /// tbKeysPerFrame textNumberOfCycles_Leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textNumberOfCycles_Leave(object sender, EventArgs e)
        {
            string strMessage = "The range of Number Of Cycles is 1 - 200";

            if (textNumberOfCycles.Text == "")
            {
                if (this.Tag.ToString() == "Auto Test")
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.AutoTest.NumberOfCycles.ToString();
                }
                else
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.SweepTest.NumberOfCycles.ToString();
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: textTotalUnitstoTest_Leave
        ///
        /// Author: Unknown
        /// 
        /// History: Hema Kumar MT: 14448, July-07-2010
        /// 
        /// ]]>
        /// <summary>
        /// tbKeysPerFrame textNumberOfCycles_TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textTotalUnitstoTest_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( textTotalUnitstoTest.Text )) 
            {
                int totalUnitsOrSweepToTest = CurrentPress.TotalUnits;
                if (this.Tag.ToString().Equals("Auto Test", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("The range of Units to test is : " + 1 + " - " + totalUnitsOrSweepToTest);
                    textTotalUnitstoTest.Text = CurrentPress.TotalUnits.ToString();
                }
                else
                {
                    MessageBox.Show("The range of sweeps to test is : " + 1 + " - " + totalUnitsOrSweepToTest);
                    textTotalUnitstoTest.Text = CurrentPress.SweepTest.TotalSweepsToTest.ToString();
                }
            }
        }

        //======================================================================================
        /// <Function>textTotalServostoTest_Leave</Function>
        /// <Date>Sep-21-2008</Date>
        /// <History>
        /// Suresh, Mar-02-2010, MT#15362
        /// </History>
        /// <summary>
        /// to validate the TotalServosToTest text box
        /// </summary>
        /// 
        ///=====================================================================================
        private void textTotalServostoTest_Leave(object sender, EventArgs e)
        {
            int availableServos = 0;
            if (m_CurrentPress != null)
            {
                availableServos = m_CurrentPress.GetMostCommonKeysPerFountain();
            }

            if (textTotalServostoTest.Text == "")
            {
                if (this.Tag.ToString() == "Auto Test")
                {
                    MessageBox.Show("The range of Units to test is : " + 1 + " - " + "16");
                    textTotalServostoTest.Text = availableServos.ToString();
                }
                else
                {
                    MessageBox.Show("The range of sweeps to test is : " + 1 + " - " + 8);
                    textTotalServostoTest.Text = CurrentPress.SweepTest.WhichPortToTest.ToString();
                }
            }
        }        

        /// <![CDATA[
        /// 
        /// Function: textNumberOfCycles_TextChanged
        ///
        /// Author: Sreejit
        /// 
        /// History: Created for DEF 15567, Apr-20-2010
        /// 
        /// ]]>
        /// <summary>
        /// tbKeysPerFrame textNumberOfCycles_TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textNumberOfCycles_TextChanged(object sender, EventArgs e)
        {
            string strMessage = "The range of Number Of Cycles is 1 - 200";

            if (textNumberOfCycles.Text == "")
                return;
            
            if (m_CurrentPress == null)
                return;
            
            Regex regex = new Regex("^[0-9]*$");
            if (this.Tag.ToString() == "Auto Test")
            {
                if (!regex.IsMatch(textNumberOfCycles.Text))
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.AutoTest.NumberOfCycles.ToString();
                }
                CheckNullValues();
                int NoOfCyclesforAutoTest = Convert.ToInt16(textNumberOfCycles.Text);
                if ((NoOfCyclesforAutoTest < 1) || (NoOfCyclesforAutoTest > 200))
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.AutoTest.NumberOfCycles.ToString();
                }
            }
            else
            {
                if (!regex.IsMatch(textNumberOfCycles.Text))
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.SweepTest.NumberOfCycles.ToString();
                }
                CheckNullValues();
                int NoOfCyclesforSweepTest = Convert.ToInt16(textNumberOfCycles.Text);
                if ((NoOfCyclesforSweepTest < 1) || (NoOfCyclesforSweepTest > 200))
                {
                    MessageBox.Show( strMessage );
                    textNumberOfCycles.Text = m_CurrentPress.SweepTest.NumberOfCycles.ToString();
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: tbOpenUpTo_TextChanged
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Created for ENH: 16253, to set the Sweep open to be text entry
        /// 
        /// ]]>
        /// <summary>
        /// text box bOpenUpTo Text Changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbOpenUpTo_TextChanged(object sender, EventArgs e)
        {
            if (tbOpenUpTo.Text.Equals(string.Empty))
                return;
            int openSweepUpTo = 0;
            if (m_CurrentPress != null)
            {
                openSweepUpTo = m_CurrentPress.SweepTest.OpenSweepUpTo;
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(tbOpenUpTo.Text))
            {
                MessageBox.Show("The range of Open Sweep up to is : " + "0" + " - " + "99");
                tbOpenUpTo.Text = openSweepUpTo.ToString();
            }
            CheckNullValues();
        }

        /// <![CDATA[
        /// 
        /// Function: tbOpenUpTo_Leave
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Created for Created for ENH: 16253, to set the Sweep open to be text entry
        /// 
        /// ]]>
        /// <summary>
        /// text box OpenUpTo Leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbOpenUpTo_Leave(object sender, EventArgs e)
        {
            if (tbOpenUpTo.Text.Equals(string.Empty))
            {
                int openSweepUpTo = CurrentPress.SweepTest.OpenSweepUpTo;
                if (this.Tag.ToString() == "Sweep Test")
                {
                    MessageBox.Show("The range of Open Sweep up to is : " + "0" + " - " + "99");
                    tbOpenUpTo.Text = openSweepUpTo.ToString();
                }
            }
        }
    }
}