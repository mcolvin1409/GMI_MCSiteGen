// ***********************************************************************
// Author           : Mark C
// Created          : 27-Sep-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCConfigVoltagesForm.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MC3Components.Controls;

namespace MCNWSiteGen
{
    public partial class MercuryAVTPLCConfigVoltagesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCConfigVoltagesForm" /> class.
        /// </summary>
        /// <param name="sweepEnabled">if set to <c>true</c> [sweep enabled].</param>
        /// <param name="waterEnabled">if set to <c>true</c> [water enabled].</param>
        /// <param name="press">The press.</param>
        /// <param name="avtPLCConfig">The AVT PLC configuration.</param>
        public MercuryAVTPLCConfigVoltagesForm( bool sweepEnabled, bool waterEnabled, MCPressInfo press, MercuryAVTPLCConfig avtPLCConfig )
        {
            this.m_sweepEnabled = sweepEnabled;
            this.m_waterEnabled = waterEnabled;
            this.m_press = press;
            this.m_avtPLCConfig = avtPLCConfig;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MercuryAVTPLCConfigVoltagesForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryAVTPLCConfigVoltagesForm_Load( object sender, EventArgs e )
        {
            CreateVoltagesListView();
            ApplyDataToGUI();
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

        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            LoadPressSpeedVoltages();
            LoadSweepAndWaterVoltages();
        }

        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            UpdatePressSpeedVoltageData();
            UpdateWaterSweepVoltageData();
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Change the Sweep / Water input min & max voltages
        ///
        /// ]]>
        /// <summary>
        /// Creates the voltages ListView.
        /// </summary>
        private void CreateVoltagesListView()
        {
            // Inker Name column
            m_inkerNameColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_inkerNameColumn.Name = "InkerName";
            m_inkerNameColumn.Text = "Inker Name";
            m_inkerNameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // Sweep Input Min Voltage column
            m_inkSweepInputMinVoltageColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_inkSweepInputMinVoltageColumn.Name = "SweepInputMin";
            m_inkSweepInputMinVoltageColumn.Text = "Sweep Input Min Voltage\n( 0 - 11 V )";
            m_inkSweepInputMinVoltageColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // Sweep Input Max Voltage column
            m_inkSweepInputMaxVoltageColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_inkSweepInputMaxVoltageColumn.Name = "SweepInputMax";
            m_inkSweepInputMaxVoltageColumn.Text = "Sweep Input Max Voltage\n( 0 - 11 V )";
            m_inkSweepInputMaxVoltageColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // Water Input Min Voltage column
            m_waterSweepOutputMinVoltageColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_waterSweepOutputMinVoltageColumn.Name = "WaterOutputMin";
            m_waterSweepOutputMinVoltageColumn.Text = "Water Output Min Voltage\n( 0 - 11 V )";
            m_waterSweepOutputMinVoltageColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // Water Input Max Voltage column
            m_waterSweepOutputMaxVoltageColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_waterSweepOutputMaxVoltageColumn.Name = "WateroutputMax";
            m_waterSweepOutputMaxVoltageColumn.Text = "Water Output Max Voltage\n( 0 - 11 V )";
            m_waterSweepOutputMaxVoltageColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            m_inkerSweepWaterVoltagesListView.Columns.AddRange( new MC3Column[] {
                    m_inkerNameColumn,
                    m_inkSweepInputMinVoltageColumn,
                    m_inkSweepInputMaxVoltageColumn,
                    m_waterSweepOutputMinVoltageColumn,
                    m_waterSweepOutputMaxVoltageColumn} );

            if( 0 != m_inkerSweepWaterVoltagesListView.Columns.Count )
            {
                int desiredColumnWidth = ( m_inkerSweepWaterVoltagesListView.Width / m_inkerSweepWaterVoltagesListView.Columns.Count );
                m_inkerNameColumn.Width = desiredColumnWidth;
                m_inkSweepInputMinVoltageColumn.Width = desiredColumnWidth;
                m_inkSweepInputMaxVoltageColumn.Width = desiredColumnWidth;
                m_waterSweepOutputMinVoltageColumn.Width = desiredColumnWidth;
                m_waterSweepOutputMaxVoltageColumn.Width = desiredColumnWidth;
            }
        }

        /// <summary>
        /// Loads the press speed voltages.
        /// </summary>
        private void LoadPressSpeedVoltages()
        {
            m_pressSpeedMinVoltageTextBox.Text = m_avtPLCConfig.PressSpeedVoltagesConfig.MinValue.ToString();
            m_pressSpeedMaximumVoltageTextBox.Text = m_avtPLCConfig.PressSpeedVoltagesConfig.MaxValue.ToString();
        }

        /// <summary>
        /// Loads the sweep and water voltages.
        /// </summary>
        private void LoadSweepAndWaterVoltages()
        {
            m_inkerSweepWaterVoltagesListView.Items.Clear();

            int itemIndex = 0;
            foreach( MCInker inker in m_press.InkerList )
            {
                if( null != inker )
                {
                    // Add Inker Name
                    m_inkerSweepWaterVoltagesListView.Items.Add( inker.InkerName );
                    UpdateSweepInputMinColumn( itemIndex, inker.AVTPLCVoltages.SweepInputVoltages.MinValue );
                    UpdateSweepInputMaxColumn( itemIndex, inker.AVTPLCVoltages.SweepInputVoltages.MaxValue );
                    UpdateWaterOutputMinColumn( itemIndex, inker.AVTPLCVoltages.WaterOutputVoltages.MinValue );
                    UpdateWaterOutputMaxColumn( itemIndex, inker.AVTPLCVoltages.WaterOutputVoltages.MaxValue );

                    ++itemIndex;
                }
            }

            m_inkerSweepWaterVoltagesListView.Refresh();
        }

        /// <summary>
        /// Updates the sweep input minimum column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        /// <param name="value">The value.</param>
        private void UpdateSweepInputMinColumn( int itemIndex, float value )
        {
            TextBox valueTextBox = new TextBox();
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.MaxLength = 6;
            valueTextBox.Text = value.ToString();
            valueTextBox.Enabled = m_sweepEnabled;
            valueTextBox.Validating += OnMinValueTextBox_Validating;

            if( itemIndex < m_inkerSweepWaterVoltagesListView.Items.Count )
            {
                m_inkerSweepWaterVoltagesListView.Items[itemIndex].SubItems[INK_SWEEP_INPUT_MIN_VOLTAGE_COL].Control = valueTextBox;
            }
        }

        /// <summary>
        /// Updates the sweep input maximum column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        /// <param name="value">The value.</param>
        private void UpdateSweepInputMaxColumn( int itemIndex, float value )
        {
            TextBox valueTextBox = new TextBox();
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.MaxLength = 6;
            valueTextBox.Text = value.ToString();
            valueTextBox.Enabled = m_sweepEnabled;
            valueTextBox.Validating += OnMaxValueTextBox_Validating;

            if( itemIndex < m_inkerSweepWaterVoltagesListView.Items.Count )
            {
                m_inkerSweepWaterVoltagesListView.Items[itemIndex].SubItems[INK_SWEEP_INPUT_MAX_VOLTAGE_COL].Control = valueTextBox;
            }
        }

        /// <summary>
        /// Updates the water output minimum column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        /// <param name="value">The value.</param>
        private void UpdateWaterOutputMinColumn( int itemIndex, float value )
        {
            TextBox valueTextBox = new TextBox();
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.MaxLength = 6;
            valueTextBox.Text = value.ToString();
            valueTextBox.Enabled = m_waterEnabled;
            valueTextBox.Validating += OnMinValueTextBox_Validating;

            if( itemIndex < m_inkerSweepWaterVoltagesListView.Items.Count )
            {
                m_inkerSweepWaterVoltagesListView.Items[itemIndex].SubItems[INK_WATER_OUTPUT_MIN_VOLTAGE_COL].Control = valueTextBox;
            }
        }

        /// <summary>
        /// Updates the water output maximum column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        /// <param name="value">The value.</param>
        private void UpdateWaterOutputMaxColumn( int itemIndex, float value )
        {
            TextBox valueTextBox = new TextBox();
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.MaxLength = 6;
            valueTextBox.Text = value.ToString();
            valueTextBox.Enabled = m_waterEnabled;
            valueTextBox.Validating += OnMaxValueTextBox_Validating;

            if( itemIndex < m_inkerSweepWaterVoltagesListView.Items.Count )
            {
                m_inkerSweepWaterVoltagesListView.Items[itemIndex].SubItems[INK_WATER_OUTPUT_MAX_VOLTAGE_COL].Control = valueTextBox;
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Change the Sweep / Water input min & max voltages
        ///
        /// ]]>
        /// <summary>
        /// Called when [minimum value text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMinValueTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - float value only
            float value = 0.0f;
            if( !float.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Min Voltage Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 11 ) )
            {
                MessageBox.Show( "Invalid Min Voltage Value. Valid Range is 0 to 11 Volts." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Change the Sweep / Water input min & max voltages
        ///
        /// ]]>
        /// <summary>
        /// Called when [maximum value text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMaxValueTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if( null == valueText )
            {
                return;
            }

            // Validate input data - float value only
            float value = 0.0f;
            if( !float.TryParse( valueText.Text, out value ) )
            {
                MessageBox.Show( "Invalid Max Voltage Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            if( ( value < 0 ) ||
                ( value > 11 ) )
            {
                MessageBox.Show( "Invalid Max Voltage Value. Valid Range is 0 to 11 Volts." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Updates the press speed voltage data.
        /// </summary>
        private void UpdatePressSpeedVoltageData()
        {
            m_avtPLCConfig.PressSpeedVoltagesConfig.MinValue = Convert.ToSingle( m_pressSpeedMinVoltageTextBox.Text.Trim() );
            m_avtPLCConfig.PressSpeedVoltagesConfig.MaxValue = Convert.ToSingle( m_pressSpeedMaximumVoltageTextBox.Text.Trim() );
        }

        /// <summary>
        /// Updates the water sweep voltage data.
        /// </summary>
        private void UpdateWaterSweepVoltageData()
        {
            int inkerIndex = 0;
            foreach( GLItem item in m_inkerSweepWaterVoltagesListView.Items )
            {
                if( inkerIndex >= m_press.InkerList.Count )
                {
                    break;
                }

                MCInker inker = m_press.InkerList[inkerIndex] as MCInker;
                if( ( null == inker ) ||
                    ( null == item ) )
                {
                    continue;
                }

                if( !string.IsNullOrEmpty( item.SubItems[INK_SWEEP_INPUT_MIN_VOLTAGE_COL].Control.Text ) )
                {
                    inker.AVTPLCVoltages.SweepInputVoltages.MinValue = Convert.ToSingle( item.SubItems[INK_SWEEP_INPUT_MIN_VOLTAGE_COL].Control.Text.Trim() );
                }

                if( !string.IsNullOrEmpty( item.SubItems[INK_SWEEP_INPUT_MAX_VOLTAGE_COL].Control.Text ) )
                {
                    inker.AVTPLCVoltages.SweepInputVoltages.MaxValue = Convert.ToSingle( item.SubItems[INK_SWEEP_INPUT_MAX_VOLTAGE_COL].Control.Text.Trim() );
                }

                if( !string.IsNullOrEmpty( item.SubItems[INK_WATER_OUTPUT_MIN_VOLTAGE_COL].Control.Text ) )
                {
                    inker.AVTPLCVoltages.WaterOutputVoltages.MinValue = Convert.ToSingle( item.SubItems[INK_WATER_OUTPUT_MIN_VOLTAGE_COL].Control.Text.Trim() ); ;
                }

                if( !string.IsNullOrEmpty( item.SubItems[INK_WATER_OUTPUT_MAX_VOLTAGE_COL].Control.Text ) )
                {
                    inker.AVTPLCVoltages.WaterOutputVoltages.MaxValue = Convert.ToSingle( item.SubItems[INK_WATER_OUTPUT_MAX_VOLTAGE_COL].Control.Text.Trim() ); ;
                }

                // Move to next Inker
                ++inkerIndex;
            }
        }

        #region Members

        private readonly MC3Column m_inkerNameColumn = new MC3Column();
        private readonly MC3Column m_inkSweepInputMinVoltageColumn = new MC3Column();
        private readonly MC3Column m_inkSweepInputMaxVoltageColumn = new MC3Column();
        private readonly MC3Column m_waterSweepOutputMinVoltageColumn = new MC3Column();
        private readonly MC3Column m_waterSweepOutputMaxVoltageColumn = new MC3Column();

        private const int INK_SWEEP_INPUT_MIN_VOLTAGE_COL = 1;
        private const int INK_SWEEP_INPUT_MAX_VOLTAGE_COL = 2;
        private const int INK_WATER_OUTPUT_MIN_VOLTAGE_COL = 3;
        private const int INK_WATER_OUTPUT_MAX_VOLTAGE_COL = 4;

        private readonly MCPressInfo m_press = new MCPressInfo();
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();

        private readonly bool m_sweepEnabled = false;
        private readonly bool m_waterEnabled = false;

        #endregion
    }
}
