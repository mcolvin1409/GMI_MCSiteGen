// ***********************************************************************
// Author           : Mark C
// Created          : 2-Dec-2016
//
// ***********************************************************************
// <copyright file="MercuryServerOptionsForm.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This Form class provides GUI to choose Mercury Server options.
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
    public partial class MercuryServerOptionsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryServerOptionsForm"/> class.
        /// </summary>
        /// <param name="serverOptions">The server options.</param>
        public MercuryServerOptionsForm( MercuryServerOptions serverOptions )
        {
            this.m_serverOptions = serverOptions;
            InitializeComponent( );
        }

        #region implementation

        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            this.m_fullSimulationOption.Checked = m_serverOptions.SimulationOption;
            this.m_cpuAffinityOption.Checked = m_serverOptions.CPUAffinityOption;
            this.m_spuNoStressOption.Checked = m_serverOptions.NoStressOption;
            this.m_spu3DebugOption.Checked = m_serverOptions.SPU3DebugOption;
            this.m_fixComPortsOption.Checked = m_serverOptions.FixCOMPortsOption;
        }

        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            m_serverOptions.SimulationOption = m_fullSimulationOption.Checked;
            m_serverOptions.CPUAffinityOption = m_cpuAffinityOption.Checked;
            m_serverOptions.NoStressOption = m_spuNoStressOption.Checked;
            m_serverOptions.SPU3DebugOption = m_spu3DebugOption.Checked;
            m_serverOptions.FixCOMPortsOption = m_fixComPortsOption.Checked;
        }

        #endregion

        #region events

        /// <summary>
        /// Handles the Load event of the MercuryServerOptionsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryServerOptionsForm_Load( object sender, EventArgs e )
        {
            this.Location = new Point( Location.X + 165, Location.Y + 35 );
            ApplyDataToGUI( );
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            UpdateDataFromGUI( );
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

        #endregion

        #region members

        MercuryServerOptions m_serverOptions = new MercuryServerOptions( );

        #endregion
    }
}
