/////////////////////////////////////////////////////////////////////////////
//  
// PressInterfaceFeatures.cs: Press nterface Features
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PressInterfaceFeatures.cs-arc   1.2   Nov 12 2008 23:13:20   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PressInterfaceFeatures.cs-arc  $
///  
///     Rev 1.2   Nov 12 2008 23:13:20   HNarala
///  to adjust different resolutions
///  
///     Rev 1.1   Oct 22 2008 03:36:56   HNarala
///  MT: 11396
///  
///     Rev 1.0   03 Oct 2008 14:42:12   knadler
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
    public partial class PressInterfaceFeatures : Form
    {
        MCPressInfo m_CurrentPress;
        public PressInterfaceFeatures()
        {
            InitializeComponent();
            m_CurrentPress = null;
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
            set{m_CurrentPress = value;}
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateDataFromUI();
            this.Close();
        }
        private void PressInterfaceFeatures_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 40);
            UpdateDataToUI();
        }

        //======================================================================================
        /// <Function>UpdateDataToUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data To UI
        /// </summary>
        /// 
        ///=====================================================================================
        void UpdateDataToUI()
        {
            MCClientInterfaceFeatures clientInterface = CurrentPress.ClientInterface;
            chkCIP3Presetting.Checked = (clientInterface.CIP3Presetting);
            chkSweep.Checked = (clientInterface.SweepControl);
            chkWater.Checked = (clientInterface.WaterControl);
        }

        //======================================================================================
        /// <Function>UpdateDataFromUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data From UI
        /// </summary>
        /// 
        ///=====================================================================================
        void UpdateDataFromUI()
        {
            MCClientInterfaceFeatures clientInterface = CurrentPress.ClientInterface;
            clientInterface.CIP3Presetting = chkCIP3Presetting.Checked;
            clientInterface.SweepControl = chkSweep.Checked;
            clientInterface.WaterControl = chkWater.Checked;        
        }

        private void txtBladeStiffness_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMaxNeighborKeyDelta_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDefaultOffset_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtServoPulsesAtZoneZero_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBackOffInPulses_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}