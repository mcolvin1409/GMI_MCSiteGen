// ***********************************************************************
// Author           : Mark C
// Created          : 21-Dec-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCInkerOptionsForm.cs" company="AVT">
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
    public partial class MercuryAVTPLCInkerOptionsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCInkerOptionsForm"/> class.
        /// </summary>
        /// <param name="sweepEnabled">if set to <c>true</c> [sweep enabled].</param>
        /// <param name="sweepRampEnabled">if set to <c>true</c> [sweep ramp enabled].</param>
        /// <param name="press">The press.</param>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        public MercuryAVTPLCInkerOptionsForm( bool sweepEnabled, bool sweepRampEnabled, MCPressInfo press, MercuryAVTPLCConfig avtPLCConfig )
        {
            this.m_sweepEnabled = sweepEnabled;
            this.m_sweepRampEnabled = sweepRampEnabled;
            this.m_press = press;
            this.m_avtPLCConfig = avtPLCConfig;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MercuryAVTPLCInkerOptionsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryAVTPLCInkerOptionsForm_Load( object sender, EventArgs e )
        {
            ApplyDataToGUI();
        }

        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            LoadInkerOptions();
            LoadCurveParameters();
        }

        /// <summary>
        /// Loads the inker options.
        /// </summary>
        private void LoadInkerOptions()
        {
            this.m_optionsGroupBox.Enabled = m_sweepEnabled;

            int hardwareIntType = Convert.ToInt32( m_avtPLCConfig.SweepConfig.InkerOptions.HardwareInterfaceType );
            if( hardwareIntType < m_hardwareInterfaceTypeComboBox.Items.Count )
            {
                this.m_hardwareInterfaceTypeComboBox.SelectedIndex = hardwareIntType;
            }

            this.m_enableDigitalControlCancelCheckBox.Checked = m_avtPLCConfig.SweepConfig.InkerOptions.EnableDigitalControlCancel;
        }

        /// <summary>
        /// Loads the curve parameters.
        /// </summary>
        private void LoadCurveParameters()
        {
            this.m_rampCurveParamsGroupBox.Enabled = m_sweepEnabled && m_sweepRampEnabled;
            this.m_speedInfluenceTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.SpeedInfluence.ToString();
            this.m_baseCurveMaxTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.BaseCurveMax.ToString();
            this.m_motorClampMinTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.MotorClampMin.ToString();
            this.m_motorClampMaxTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.MotorClampMax.ToString();
        }

        /// <summary>
        /// Called when [speed influence text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSpeedInfluenceTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - integer value only
            int value = 0;
            if( !int.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Speed Influence Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 100 ) )
            {
                MessageBox.Show( "Invalid Speed Influence Value. Valid Range is 0 to 100." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Called when [base curve maximum text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnBaseCurveMaxTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - integer value only
            int value = 0;
            if( !int.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Base Curve Max Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 100 ) )
            {
                MessageBox.Show( "Invalid Base Curve Max Value. Valid Range is 0 to 100." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Called when [motor clamp minimum text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMotorClampMinTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - integer value only
            int value = 0;
            if( !int.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Motor Clamp Min Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 100 ) )
            {
                MessageBox.Show( "Invalid Motor Clamp Min Value. Valid Range is 0 to 100." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Called when [motor clamp maximum text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMotorClampMaxTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - integer value only
            int value = 0;
            if( !int.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Motor Clamp Max Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 100 ) )
            {
                MessageBox.Show( "Invalid Motor Clamp Max Value. Valid Range is 0 to 100." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            UpdateInkerOptionsData();
            UpdatedLoadCurveParametersData();
        }

        /// <summary>
        /// Updates the inker options data.
        /// </summary>
        private void UpdateInkerOptionsData()
        {
            m_avtPLCConfig.SweepConfig.InkerOptions.HardwareInterfaceType = ( InkerHardwareInterfaceType )m_hardwareInterfaceTypeComboBox.SelectedIndex;
            m_avtPLCConfig.SweepConfig.InkerOptions.EnableDigitalControlCancel = m_enableDigitalControlCancelCheckBox.Checked;
        }

        /// <summary>
        /// Updateds the load curve parameters data.
        /// </summary>
        private void UpdatedLoadCurveParametersData()
        {
            m_avtPLCConfig.SweepConfig.Ramping.SpeedInfluence = Convert.ToInt32( m_speedInfluenceTextBox.Text );
            m_avtPLCConfig.SweepConfig.Ramping.BaseCurveMax = Convert.ToInt32( m_baseCurveMaxTextBox.Text );
            m_avtPLCConfig.SweepConfig.Ramping.MotorClampMin = Convert.ToInt32( m_motorClampMinTextBox.Text );
            m_avtPLCConfig.SweepConfig.Ramping.MotorClampMax = Convert.ToInt32( m_motorClampMaxTextBox.Text );
        }

        /// <summary>
        /// Called when [hardware interface type ComboBox selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnHardwareInterfaceTypeComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            InkerHardwareInterfaceType interfaceType = ( InkerHardwareInterfaceType )m_hardwareInterfaceTypeComboBox.SelectedIndex;
            if( InkerHardwareInterfaceType.AnalogOutput == interfaceType )
            {
                m_enableDigitalControlCancelCheckBox.Checked = false;
                m_enableDigitalControlCancelCheckBox.Enabled = false;
            }
            else
            {
                m_enableDigitalControlCancelCheckBox.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            UpdateDataFromGUI();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #region Members

        private readonly MCPressInfo m_press = new MCPressInfo();
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();
        private readonly bool m_sweepEnabled = false;
        private readonly bool m_sweepRampEnabled = false;

        #endregion

    }
}
