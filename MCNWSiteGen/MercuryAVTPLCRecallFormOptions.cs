// ***********************************************************************
// Author           : Mark C
// Created          : 21-Dec-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCRecallFormOptions.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCNWSiteGen
{
    public partial class MercuryAVTPLCRecallFormOptions : Form
    {
        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCRecallFormOptions"/> class.
        /// </summary>
        /// <param name="sweepEnabled">if set to <c>true</c> [sweep enabled].</param>
        /// <param name="sweepFunctionEnabled">if set to <c>true</c> [sweep function enabled].</param>
        /// <param name="ductorHoldOffEnabled">if set to <c>true</c> [ductor hold off enabled].</param>
        /// <param name="waterEnabled">if set to <c>true</c> [water enabled].</param>
        /// <param name="waterFunctionEnabled">if set to <c>true</c> [water function enabled].</param>
        /// <param name="press">The press.</param>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        public MercuryAVTPLCRecallFormOptions( bool sweepEnabled, bool sweepFunctionEnabled, bool ductorHoldOffEnabled,
            bool waterEnabled, bool waterFunctionEnabled, MCPressInfo press, MercuryAVTPLCConfig avtPLCConfig, AVTPLCType plcType )
        {
            m_sweepEnabled = sweepEnabled;
            m_sweepFunctionEnabled = sweepFunctionEnabled;
            m_ductorHoldOffEnabled = ductorHoldOffEnabled;

            m_waterEnabled = waterEnabled;
            m_waterFunctionEnabled = waterFunctionEnabled;

            m_press = press;
            m_avtPLCConfig = avtPLCConfig;
            m_plcType = plcType;

            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MercuryAVTPLCRecallFormOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryAVTPLCRecallFormOptions_Load( object sender, EventArgs e )
        {
            ApplyDataToGUI();
        }

        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            LoadSweepParameters();
            LoadWaterParameters();
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Loads the sweep parameters.
        /// </summary>
        private void LoadSweepParameters()
        {
            // Change the "Trim Value" text to "Console Value" for the CX8190 PLC Model
            string sweepTrimParamText = ( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_plcType ) ? "Trim Value" : "Console Value";
            m_sweepTrimParamCheckBox.Text = sweepTrimParamText;

            m_sweepParametersGroupBox.Enabled = m_sweepEnabled;
            m_sweepTrimParamCheckBox.Enabled = m_sweepEnabled;
            m_sweepFunctionSettingParamCheckBox.Enabled = m_sweepEnabled && m_sweepFunctionEnabled;
            m_sweepDuctorSettingParamCheckBox.Enabled = m_sweepEnabled && m_ductorHoldOffEnabled;

            m_sweepTrimParamCheckBox.Checked = m_sweepEnabled && m_avtPLCConfig.SweepConfig.RecallFormOptions.TrimParamSelected;
            m_sweepFunctionSettingParamCheckBox.Checked = m_sweepFunctionEnabled && m_avtPLCConfig.SweepConfig.RecallFormOptions.FunctionParamSelected;
            m_sweepDuctorSettingParamCheckBox.Checked = m_ductorHoldOffEnabled && m_avtPLCConfig.SweepConfig.RecallFormOptions.DuctorHoldoffParamSelected;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Loads the water parameters.
        /// </summary>
        private void LoadWaterParameters()
        {
            // Change the "Trim Value" text to "Console Value" for the CX8190 PLC Model
            string waterTrimParamText = ( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_plcType ) ? "Trim Value" : "Console Value";
            m_waterTrimParamCheckBox.Text = waterTrimParamText;

            m_waterParametersGroupBox.Enabled = m_waterEnabled;
            m_waterTrimParamCheckBox.Enabled = m_waterEnabled;
            m_waterFunctionSettingParamCheckBox.Enabled = m_waterEnabled && m_waterFunctionEnabled;

            m_waterTrimParamCheckBox.Checked = m_waterEnabled && m_avtPLCConfig.WaterConfig.RecallFormOptions.TrimParamSelected;
            m_waterFunctionSettingParamCheckBox.Checked = m_waterFunctionEnabled && m_avtPLCConfig.WaterConfig.RecallFormOptions.FunctionParamSelected;
        }

        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            m_avtPLCConfig.SweepConfig.RecallFormOptions.TrimParamSelected = m_sweepTrimParamSelected;
            m_avtPLCConfig.SweepConfig.RecallFormOptions.FunctionParamSelected = m_sweepFunctionParamSelected;
            m_avtPLCConfig.SweepConfig.RecallFormOptions.DuctorHoldoffParamSelected = m_sweepDuctHoldOffParamSelected;

            m_avtPLCConfig.WaterConfig.RecallFormOptions.TrimParamSelected = m_waterTrimParamSelected;
            m_avtPLCConfig.WaterConfig.RecallFormOptions.FunctionParamSelected = m_waterFunctionParamSelected;
        }

        /// <summary>
        /// Called when [ok click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnOK_Click( object sender, EventArgs e )
        {
            UpdateDataFromGUI();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Called when [cancel click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCancel_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// Called when [sweep trim parameter CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepTrimParamCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            m_sweepTrimParamSelected = m_sweepTrimParamCheckBox.Checked;
        }

        /// <summary>
        /// Called when [sweep function setting parameter CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepFunctionSettingParamCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            m_sweepFunctionParamSelected = m_sweepFunctionSettingParamCheckBox.Checked;
        }

        /// <summary>
        /// Called when [sweep ductor setting parameter CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepDuctorSettingParamCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            m_sweepDuctHoldOffParamSelected = m_sweepDuctorSettingParamCheckBox.Checked;
        }

        /// <summary>
        /// Called when [water trim parameter CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterTrimParamCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            m_waterTrimParamSelected = m_waterTrimParamCheckBox.Checked;
        }

        /// <summary>
        /// Called when [water function setting parameter CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterFunctionSettingParamCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            m_waterFunctionParamSelected = m_waterFunctionSettingParamCheckBox.Checked;
        }

        #region Members

        private bool m_sweepTrimParamSelected = false;
        private bool m_sweepFunctionParamSelected = false;
        private bool m_sweepDuctHoldOffParamSelected = false;
        private bool m_waterTrimParamSelected = false;
        private bool m_waterFunctionParamSelected = false;

        private bool m_sweepEnabled = false;
        private bool m_sweepFunctionEnabled = false;
        private bool m_ductorHoldOffEnabled = false;
        private bool m_waterEnabled = false;
        private bool m_waterFunctionEnabled = false;

        private readonly MCPressInfo m_press = new MCPressInfo();
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();
        private readonly AVTPLCType m_plcType = AVTPLCType.eAVTPLCBeckhoffCX50xx;

        #endregion
    }
}
