/////////////////////////////////////////////////////////////////////////////
//  
// PressInformation.cs: Press Information
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PressInformation.cs-arc   1.1   Oct 22 2008 03:36:54   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/PressInformation.cs-arc  $
///  
///     Rev 1.1   Oct 22 2008 03:36:54   HNarala
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
    public partial class PressInformation : Form
    {
        MCPressInfo mcPressInfo;
        frmMain frmMain = new frmMain();
        UnitTypes m_CurrentUnit;
        float m_PressWidthInCM;
        public int iPressType = 0;
        public PressInformation()
        {
            InitializeComponent();
            mcPressInfo = null;
            m_CurrentUnit = new UnitTypes();
            m_CurrentUnit = UnitTypes.UNIT_TYPE_CMS;
        }
        public MCPressInfo PressInfo
        {
            set { mcPressInfo = value; }
            get { return mcPressInfo; }            
        }
        private void PressInformation_Load(object sender, EventArgs e)
        {
            int iPressType = 0;
            if (mcPressInfo != null)
            {
                txtPressName.Text = mcPressInfo.PressName;
                iPressType = mcPressInfo.PressType;
                txtPressType.Text = mcPressInfo.PressType.ToString ();
                txtPressWidth.Text = mcPressInfo.PressWidth.ToString ();
                DisplayPressType(iPressType);
            }
        }

        #region Events
        public static event PressTypeChanged pressTypeChanged;
        #endregion

        //======================================================================================
        /// <Function>DisplayPressType</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Display Press Type
        /// </summary>
        /// <histroty>
        ///     23-Apr-13, Mark C, WI30347: Changed press type from DUAL_WEB_PRESS to MULTI_WEB_PRESS
        ///     15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// </histroty>
        ///=====================================================================================
        private void DisplayPressType(int iPressType)
        {
            switch (iPressType)
            {
                case (int)enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;

                case (int)enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_WITH_TURNBAR;
                    break;

                case (int)enPressTypes.SHEET_FED_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SHEET_FED_PRESS;
                    break;

                case (int)enPressTypes.SINGLE_WEB_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_WEB_PRESS;
                    break;

                case (int)enPressTypes.MULTI_WEB_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.MULTI_WEB_PRESS;
                    break;

                case (int)enPressTypes.NEWSPAPER_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.NEWSPAPER_PRESS;
                    break;

                case (int)enPressTypes.SINGLE_SIDED_CIC_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_SIDED_CIC_PRESS;
                    break;

                case (int)enPressTypes.UNKNOWN_PRESS_TYPE:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNKNOWN_PRESS_TYPE;
                    break;

                default:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mcPressInfo.PressName = txtPressName.Text;
            mcPressInfo.PressType = iPressType;
            if (m_CurrentUnit != UnitTypes.UNIT_TYPE_CMS)
            {
                mcPressInfo.PressWidth = m_PressWidthInCM;
            }
            else
                mcPressInfo.PressWidth = float.Parse(txtPressWidth.Text);            
            pressTypeChanged();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBoxPressType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Changed press type from DUAL_WEB_PRESS to MULTI_WEB_PRESS
        ///     15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///     
        /// </history>
        private void comboBoxPressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strComboBoxEntry = comboBoxPressType.SelectedItem.ToString();
            switch (strComboBoxEntry)
            {
                case MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR:
                    iPressType = (int) enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_WITH_TURNBAR:
                    iPressType = (int) enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SHEET_FED_PRESS:
                    iPressType = (int)enPressTypes.SHEET_FED_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_WEB_PRESS:
                    iPressType = (int)enPressTypes.SINGLE_WEB_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.MULTI_WEB_PRESS:
                    iPressType = (int)enPressTypes.MULTI_WEB_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.NEWSPAPER_PRESS:
                    iPressType = (int)enPressTypes.NEWSPAPER_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_SIDED_CIC_PRESS:
                    iPressType = (int)enPressTypes.SINGLE_SIDED_CIC_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.UNKNOWN_PRESS_TYPE:
                    iPressType = (int)enPressTypes.UNKNOWN_PRESS_TYPE;
                    break;

            }
        }
        private void chkMeasurementCheckedChanged(string strUnit)
        {
            if (txtPressWidth.Text != "")
            {
                if (chkMM.Checked == true)
                {
                    chkCms.Checked = false;
                    chkInches.Checked = false;
                    lblUnits.Text = strUnit;
                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;
                    UnitTypes unitType = new UnitTypes();
                    if (strUnit == MCNWSiteGen.DefineAndConst.StringConstant.MM)
                        unitType = UnitTypes.UNIT_TYPE_MM;
                    else if (strUnit == MCNWSiteGen.DefineAndConst.StringConstant.CMS)
                        unitType = UnitTypes.UNIT_TYPE_CMS;
                    else
                        unitType = UnitTypes.UNIT_TYPE_INCHS;

                    fNewVal = frmMain.UnitConversions(fVal, m_CurrentUnit, unitType);
                    m_CurrentUnit = unitType;
                    txtPressWidth.Text = fNewVal.ToString();
                }
            }
        }

        private void chkMM_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPressWidth.Text != "")
            {
                if (chkMM.Checked == true)
                {
                    chkCms.Checked = false;
                    chkInches.Checked = false;
                    lblUnits.Text = MCNWSiteGen.DefineAndConst.StringConstant.MM;
                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;

                    fNewVal = frmMain.UnitConversions(fVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_MM);
                    m_CurrentUnit = UnitTypes.UNIT_TYPE_MM;
                    txtPressWidth.Text = fNewVal.ToString();
                    m_PressWidthInCM = frmMain.UnitConversions(fNewVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                }
            }
        }

        private void chkInches_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPressWidth.Text != "")
            {
                if (chkInches.Checked == true)
                {
                    chkCms.Checked = false;
                    chkMM.Checked = false;
                    lblUnits.Text = MCNWSiteGen.DefineAndConst.StringConstant.INCHE;
                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;

                    fNewVal = frmMain.UnitConversions(fVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_INCHS);
                    m_CurrentUnit = UnitTypes.UNIT_TYPE_INCHS;
                    txtPressWidth.Text = fNewVal.ToString();
                    m_PressWidthInCM = frmMain.UnitConversions(fNewVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                }
            }
        }

        private void chkCms_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPressWidth.Text != "")
            {
                if (chkCms.Checked == true)
                {
                    chkInches.Checked = false;
                    chkMM.Checked = false;
                    lblUnits.Text = MCNWSiteGen.DefineAndConst.StringConstant.CMS;
                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;

                    fNewVal = frmMain.UnitConversions(fVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                    m_CurrentUnit = UnitTypes.UNIT_TYPE_CMS;
                    txtPressWidth.Text = fNewVal.ToString();
                 //   m_PressWidthInCM = fNewVal;
                }
            }
        }

        private void txtPressWidth_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$"); 
            if (!regex.IsMatch(txtPressWidth.Text))
            {
                txtPressWidth.Text = "";
            }
            if ((txtPressName.Text != "") && (txtPressWidth.Text != ""))
            {
                btnOK.Enabled = true;
            }
            else
                btnOK.Enabled = false;

        }

        private void txtPressName_TextChanged(object sender, EventArgs e)
        {
            if ((txtPressName.Text != "") && (txtPressWidth.Text != ""))
            {
                btnOK.Enabled = true;
            }
            else
                btnOK.Enabled = false;

        }
    }
}