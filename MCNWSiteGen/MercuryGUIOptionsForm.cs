// ***********************************************************************
// Author           : Mark C
// Created          : 26-Sep-2018
//
// ***********************************************************************
// <copyright file="MercuryGUIOptionsForm.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This Form class provides GUI to choose Mercury GUI options.
// </summary>
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
    /// <![CDATA[              
    /// 
    /// Author:     Mark C
    /// History:    17-Dec-2018 dlg, (183514) Add auto run delay time
    ///         
    /// ]]>
    /// <summary>
    /// This Form class provides GUI to choose Mercury GUI options.
    /// </summary>
    public partial class MercuryGUIOptionsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryServerOptionsForm" /> class.
        /// </summary>
        /// <param name="guiOptions">The GUI options.</param>
        public MercuryGUIOptionsForm( MercuryGUIOptions guiOptions )
        {
            this.m_guiOptions = guiOptions;
            InitializeComponent( );
        }

        #region implementation

        /// <![CDATA[              
        /// 
        /// Author:     Mark C
        /// History:    17-Dec-2018 dlg, (183514) Add auto run delay time
        ///         
        /// ]]>
        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            m_removalOfRunButtonOption.Checked = m_guiOptions.RemovalOfRunButtonOption;
            m_invertPresetProfileOption.Checked = m_guiOptions.InvertPresetProfileOption;
            m_saveAndUndoSweepConsoleSettings.Checked = m_guiOptions.SaveAndUndoSweepConsoleSettings;
            m_saveAndUndoWaterConsoleSettings.Checked = m_guiOptions.SaveAndUndoWaterConsoleSettings;

            string defaultThumbnailSize = m_guiOptions.DefaultThumbnailSize.ToString();
            if( m_defaultThumbnailSizeCB.Items.Contains( defaultThumbnailSize ) )
            {
                m_defaultThumbnailSizeCB.SelectedItem = defaultThumbnailSize;
            }

            m_autoRunDelayTimeTextBox.Text = m_guiOptions.AutoRunDelayTime.ToString( "0.0" );
        }

        /// <![CDATA[              
        /// 
        /// Author:     Mark C
        /// History:    17-Dec-2018 dlg, (183514) Add auto run delay time
        ///         
        /// ]]>
        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            m_guiOptions.RemovalOfRunButtonOption = m_removalOfRunButtonOption.Checked;
            m_guiOptions.InvertPresetProfileOption = m_invertPresetProfileOption.Checked;
            m_guiOptions.SaveAndUndoSweepConsoleSettings = m_saveAndUndoSweepConsoleSettings.Checked;
            m_guiOptions.SaveAndUndoWaterConsoleSettings = m_saveAndUndoWaterConsoleSettings.Checked;

            if( null != m_defaultThumbnailSizeCB.SelectedItem )
                m_guiOptions.DefaultThumbnailSize = Convert.ToInt32( m_defaultThumbnailSizeCB.SelectedItem );

            m_guiOptions.AutoRunDelayTime = (float)Convert.ToDouble( m_autoRunDelayTimeTextBox.Text );
        }

        #endregion

        #region events

        /// <summary>
        /// Handles the Load event of the MercuryServerOptionsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MercuryServerOptionsForm_Load( object sender, EventArgs e )
        {
            this.Location = new Point( Location.X + 165, Location.Y + 35 );
            ApplyDataToGUI( );
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            UpdateDataFromGUI( );
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <![CDATA[              
        /// 
        /// Author:     Don Gerber
        /// History:    17-Dec-2018 dlg, (183514) Created
        ///         
        /// ]]>
        /// <summary>
        /// Called when [removal of run button option] checked changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRemovalOfRunButtonOption_CheckedChanged( object sender, EventArgs e )
        {
            // Update Auto Run Delay Time based on feature selection
            if( m_removalOfRunButtonOption.Checked )
            {
                autoRunDelayTimeLabel.Enabled = true;
                m_autoRunDelayTimeTextBox.Enabled = true;
            }
            else
            {
                autoRunDelayTimeLabel.Enabled = false;
                m_autoRunDelayTimeTextBox.Enabled = false;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author:     Don Gerber
        /// History:    17-Dec-2018 dlg, (183514) Created
        ///         
        /// ]]>
        /// <summary>
        /// Called when [auto run delay time text box] validating.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnAutoRunDelayTimeTextBox_Validating( object sender, CancelEventArgs e )
        {
            // Validate parameters
            TextBox boxAutoRunDelayTime = sender as TextBox;
            if( boxAutoRunDelayTime == null )
            {
                return;
            }

            // Validate input data - numeric value only
            float tmpValue;
            if( !float.TryParse( boxAutoRunDelayTime.Text, out tmpValue ) )
            {
                MessageBox.Show( "Invalid Auto Run Delay Time. Please input numeric data only.", "Invalid Entry" );
                boxAutoRunDelayTime.SelectAll();
                boxAutoRunDelayTime.Focus();
                return;
            }

            // Validate range            
            tmpValue = (float)Convert.ToDouble( boxAutoRunDelayTime.Text.Trim() );
            float minValue = DefineAndConst.SystemCapacities.AUTO_RUN_DELAY_TIME_MIN;
            float maxValue = DefineAndConst.SystemCapacities.AUTO_RUN_DELAY_TIME_MAX;
            if( (tmpValue < minValue) || (tmpValue > maxValue) )
            {
                string strText = String.Format( "Invalid Auto Run Delay Time. Valid range is {0} to {1}",
                    minValue.ToString(), maxValue.ToString() );
                MessageBox.Show( strText, "Invalid Entry" );
                boxAutoRunDelayTime.SelectAll();
                boxAutoRunDelayTime.Focus();
            }
        }

        #endregion

        #region members

        /// <summary>
        /// The m GUI options
        /// </summary>
        MercuryGUIOptions m_guiOptions = new MercuryGUIOptions( );

        #endregion


    }
}
