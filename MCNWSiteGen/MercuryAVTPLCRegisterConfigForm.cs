// ***********************************************************************
// Author           : Don Gerber
// Created          : 10-Oct-2018
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCRegisterConfigForm.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MCNWSiteGen
{
    public partial class MercuryAVTPLCRegisterConfigForm : Form
    {
        #region Properties

        /// <summary>
        /// Gets or sets the inker register configuration.
        /// </summary>
        /// <value>
        /// The inker register.
        /// </value>
        public List<MercuryAVTPLCRegisterInkerConfig> InkerConfig
        {
            get { return m_listInkerConfig; }
            set { m_listInkerConfig = value; }
        }

        /// <summary>
        /// Gets or sets the selected inker.
        /// </summary>
        /// <value>
        /// The selected inker.
        /// </value>
        public int SelectedInker
        {
            get { return m_iSelectedInker; }
            set { m_iSelectedInker = value; }
        }

        #endregion 

        #region Members

        private readonly MCPressInfo m_press = new MCPressInfo();
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();
        private List<MercuryAVTPLCRegisterInkerConfig> m_listInkerConfig = new List<MercuryAVTPLCRegisterInkerConfig>();
        private int m_iSelectedInker = -1;

        #endregion

        #region Implementation

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCRegisterConfigForm" /> class.
        /// </summary>
        /// <param name="press">The press.</param>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        public MercuryAVTPLCRegisterConfigForm(MCPressInfo press, MercuryAVTPLCConfig avtPLCConfig)
        {
            this.m_press = press;
            this.m_avtPLCConfig = avtPLCConfig;
            InitializeComponent();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            LoadPLCConfiguration();
            LoadInkerRegisterConfig();

            OnRegisterOptionCheckBox_CheckedChanged( null, null );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Loads the PLC configuration data into the dialog.
        /// </summary>
        private void LoadPLCConfiguration()
        {
            // PLC Configuration details
            int plcType = Convert.ToInt32(m_avtPLCConfig.PLCType);
            if (plcType < m_plcTypeComboBox.Items.Count)
            {
                m_plcTypeComboBox.SelectedIndex = plcType;
            }

            m_plcIPAddressTextBox.Text = m_avtPLCConfig.PLCIPAdrress;
            m_plcPortTextBox.Text = m_avtPLCConfig.PLCPortNum.ToString();

            // Register configuration details
            m_registerOptionCheckBox.Checked = m_avtPLCConfig.RegisterEnabled && IsPLCCX50XXSelected();
            m_OperatorOnLeftCheckBox.Checked = m_avtPLCConfig.RegisterConfig.OperatorOnLeft;
            m_AdvanceOnTopCheckBox.Checked = m_avtPLCConfig.RegisterConfig.AdvanceOnTop;
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///        	29-May-19, Mark C, WI188815 - Ardagh Manual Plate Register interlock options 
        ///         
        /// ]]>
        /// <summary>
        /// Loads the Inker register data into the dialog
        /// </summary>
        private void LoadInkerRegisterConfig()
        {
            // Remove any inker data
            InkerConfig.Clear();
            m_registerInkerComboBox.Items.Clear();

            // Load Inker data
            foreach (MCInker inker in m_press.InkerList)
            {
                if (inker != null)
                {
                    // Get Inker register data
                    MercuryAVTPLCRegisterInkerConfig regInker = new MercuryAVTPLCRegisterInkerConfig();
                    regInker.LateralMotor = inker.AVTPLCRegister.LateralMotor;
                    regInker.CircMotor = inker.AVTPLCRegister.CircMotor;
                    regInker.SkewEnabled = inker.AVTPLCRegister.SkewEnabled;
                    regInker.SkewMotor = inker.AVTPLCRegister.SkewMotor;

                    // Register interlock options
                    regInker.LateralMotor.BlockMotorWhenPressStopped = inker.AVTPLCRegister.LateralMotor.BlockMotorWhenPressStopped;
                    regInker.CircMotor.BlockMotorWhenPressStopped = inker.AVTPLCRegister.CircMotor.BlockMotorWhenPressStopped;
                    regInker.SkewMotor.BlockMotorWhenPressStopped = inker.AVTPLCRegister.SkewMotor.BlockMotorWhenPressStopped;
                    
                    // Validate Skew Motor max travel due to it's different range
                    if( regInker.SkewMotor.MaxTravel < DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MIN_TRAVEL )
                        regInker.SkewMotor.MaxTravel = DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MIN_TRAVEL;
                    if( regInker.SkewMotor.MaxTravel > DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MAX_TRAVEL )
                        regInker.SkewMotor.MaxTravel = DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MAX_TRAVEL;

                    // Add Inker data
                    InkerConfig.Add(regInker);

                    // Add Inker Name to selection list
                    m_registerInkerComboBox.Items.Add(inker.InkerName);
                }
            }

            // Init selected inker
            if( m_registerInkerComboBox.Items.Count > 0 )
            {
                m_registerInkerComboBox.SelectedIndex = 0;
            }            
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            UpdatePLCConfigData();
            UpdateInkerRegisterConfig();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Updates the PLC configuration data.
        /// </summary>
        private void UpdatePLCConfigData()
        {
            // PLC Config details
            m_avtPLCConfig.PLCType = (AVTPLCType)(m_plcTypeComboBox.SelectedIndex);
            m_avtPLCConfig.PLCIPAdrress = m_plcIPAddressTextBox.Text.Trim();
            m_avtPLCConfig.PLCPortNum = Convert.ToInt32( m_plcPortTextBox.Text.Trim() );

            // Register configuration details
            m_avtPLCConfig.RegisterEnabled = m_registerOptionCheckBox.Checked;
            m_avtPLCConfig.RegisterConfig.OperatorOnLeft = m_OperatorOnLeftCheckBox.Checked;
            m_avtPLCConfig.RegisterConfig.AdvanceOnTop = m_AdvanceOnTopCheckBox.Checked;
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///        	29-May-19, Mark C, WI188815 - Ardagh Manual Plate Register interlock options 
        ///         
        /// ]]>
        /// <summary>
        /// Updates the Inker register data from the dialog
        /// </summary>
        private void UpdateInkerRegisterConfig()
        {
            // For each Inker ...
            for( int iInkerIndex = 0; iInkerIndex < InkerConfig.Count; iInkerIndex++ )
            {
                MercuryAVTPLCRegisterInkerConfig inkerSource = InkerConfig[ iInkerIndex ];
                MCInker inker = (MCInker)m_press.InkerList[ iInkerIndex ];
                MercuryAVTPLCRegisterInkerConfig inkerDest = inker.AVTPLCRegister;

                // Copy dialog data
                inkerDest.LateralMotor = inkerSource.LateralMotor;
                inkerDest.CircMotor = inkerSource.CircMotor;
                inkerDest.SkewEnabled = inkerSource.SkewEnabled;
                inkerDest.SkewMotor = inkerSource.SkewMotor;

                // Register interlock options
                inkerDest.LateralMotor.BlockMotorWhenPressStopped = inkerSource.LateralMotor.BlockMotorWhenPressStopped;
                inkerDest.CircMotor.BlockMotorWhenPressStopped = inkerSource.CircMotor.BlockMotorWhenPressStopped;
                inkerDest.SkewMotor.BlockMotorWhenPressStopped = inkerSource.SkewMotor.BlockMotorWhenPressStopped;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Determines whether PLC type is CX50xx.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if PLC CX50xx selected; otherwise, <c>false</c>.
        /// </returns>
        private bool IsPLCCX50XXSelected()
        {
            return (AVTPLCType.eAVTPLCBeckhoffCX50xx == (AVTPLCType)m_plcTypeComboBox.SelectedIndex);
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Updates the lateral pot feedback controls.
        /// </summary>
        private void UpdateLateralPotFeedbackControls()
        {
            if( m_latPotFeedbackCheckBox.Checked )
            {
                m_latPotFeedbackMinLabel.Enabled = true;
                m_latPotFeedbackMinTextBox.Enabled = true;
                m_latPotFeedbackMaxLabel.Enabled = true;
                m_latPotFeedbackMaxTextBox.Enabled = true;
            }
            else
            {
                m_latPotFeedbackMinLabel.Enabled = false;
                m_latPotFeedbackMinTextBox.Enabled = false;
                m_latPotFeedbackMaxLabel.Enabled = false;
                m_latPotFeedbackMaxTextBox.Enabled = false;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Updates the circ pot feedback controls.
        /// </summary>
        private void UpdateCircPotFeedbackControls()
        {
            if( m_circPotFeedbackCheckBox.Checked )
            {
                m_circPotFeedbackMinLabel.Enabled = true;
                m_circPotFeedbackMinTextBox.Enabled = true;
                m_circPotFeedbackMaxLabel.Enabled = true;
                m_circPotFeedbackMaxTextBox.Enabled = true;
            }
            else
            {
                m_circPotFeedbackMinLabel.Enabled = false;
                m_circPotFeedbackMinTextBox.Enabled = false;
                m_circPotFeedbackMaxLabel.Enabled = false;
                m_circPotFeedbackMaxTextBox.Enabled = false;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///        	29-May-19, Mark C, WI188815 - Ardagh Manual Plate Register interlock options 
        ///         
        /// ]]>
        /// <summary>
        /// Updates the skew controls.
        /// </summary>
        private void UpdateSkewControls()
        {
            if( m_skewOptionCheckBox.Checked )
            {
                m_skewMaxTravelLabel.Enabled = true;
                m_skewMaxTravelTextBox.Enabled = true;
                m_skewLimitSwitchComboBox.Enabled = true;
                m_skewLimitSwitchLabel.Enabled = true;
                m_skewSlopeLabel.Enabled = true;
                m_skewSlopeTextBox.Enabled = true;
                m_skewPotFeedbackGroupBox.Enabled = true;
                m_blockSkewMotorOption.Enabled = true;
            }
            else
            {
                m_skewMaxTravelLabel.Enabled = false;
                m_skewMaxTravelTextBox.Enabled = false;
                m_skewLimitSwitchComboBox.Enabled = false;
                m_skewLimitSwitchLabel.Enabled = false;
                m_skewSlopeLabel.Enabled = false;
                m_skewSlopeTextBox.Enabled = false;
                m_skewPotFeedbackGroupBox.Enabled = false;
                m_blockSkewMotorOption.Enabled = false;
            }

            if( m_skewPotFeedbackCheckBox.Checked && m_skewOptionCheckBox.Checked )
            {
                m_skewPotFeedbackMinLabel.Enabled = true;
                m_skewPotFeedbackMinTextBox.Enabled = true;
                m_skewPotFeedbackMaxLabel.Enabled = true;
                m_skewPotFeedbackMaxTextBox.Enabled = true;
            }
            else
            {
                m_skewPotFeedbackMinLabel.Enabled = false;
                m_skewPotFeedbackMinTextBox.Enabled = false;
                m_skewPotFeedbackMaxLabel.Enabled = false;
                m_skewPotFeedbackMaxTextBox.Enabled = false;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///        	29-May-19, Mark C, WI188815 - Ardagh Manual Plate Register interlock options 
        ///         
        /// ]]>
        /// <summary>
        /// Sets the inker dialog data.
        /// </summary>
        /// <param name="iInkerIndex">Index of the Inker.</param>
        private void SetInkerDialogData( int iInkerIndex )
        {
            if( (iInkerIndex >= 0) && (iInkerIndex < m_listInkerConfig.Count) )
            {
                MercuryAVTPLCRegisterInkerConfig registerInker = m_listInkerConfig[ iInkerIndex ];

                // Update Lateral Motor
                registerInker.LateralMotor.MaxTravel = (float)Convert.ToDouble( m_latMaxTravelTextBox.Text );
                registerInker.LateralMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)m_latLimitSwitchComboBox.SelectedIndex;
                registerInker.LateralMotor.Slope = Convert.ToInt32( m_latSlopeTextBox.Text );
                registerInker.LateralMotor.PotFeedBack = m_latPotFeedbackCheckBox.Checked;
                registerInker.LateralMotor.PotFeedbackMin = (float)Convert.ToDouble( m_latPotFeedbackMinTextBox.Text );
                registerInker.LateralMotor.PotFeedbackMax = (float)Convert.ToDouble( m_latPotFeedbackMaxTextBox.Text );
                registerInker.LateralMotor.BlockMotorWhenPressStopped = m_blockSidelayMotorOption.Checked;

                // Update Circ Motor
                registerInker.CircMotor.MaxTravel = (float)Convert.ToDouble( m_circMaxTravelTextBox.Text );
                registerInker.CircMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)m_circLimitSwitchComboBox.SelectedIndex;
                registerInker.CircMotor.Slope = Convert.ToInt32( m_circSlopeTextBox.Text );
                registerInker.CircMotor.PotFeedBack = m_circPotFeedbackCheckBox.Checked;
                registerInker.CircMotor.PotFeedbackMin = (float)Convert.ToDouble( m_circPotFeedbackMinTextBox.Text );
                registerInker.CircMotor.PotFeedbackMax = (float)Convert.ToDouble( m_circPotFeedbackMaxTextBox.Text );
                registerInker.CircMotor.BlockMotorWhenPressStopped = m_blockCircMotorOption.Checked;

                // Update Skew Motor
                registerInker.SkewEnabled = m_skewOptionCheckBox.Checked;
                registerInker.SkewMotor.MaxTravel = (float)Convert.ToDouble( m_skewMaxTravelTextBox.Text );
                registerInker.SkewMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)m_skewLimitSwitchComboBox.SelectedIndex;
                registerInker.SkewMotor.Slope = Convert.ToInt32( m_skewSlopeTextBox.Text );
                registerInker.SkewMotor.PotFeedBack = m_skewPotFeedbackCheckBox.Checked;
                registerInker.SkewMotor.PotFeedbackMin = (float)Convert.ToDouble( m_skewPotFeedbackMinTextBox.Text );
                registerInker.SkewMotor.PotFeedbackMax = (float)Convert.ToDouble( m_skewPotFeedbackMaxTextBox.Text );
                registerInker.SkewMotor.BlockMotorWhenPressStopped = m_blockSkewMotorOption.Checked;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///        	29-May-19, Mark C, WI188815 - Ardagh Manual Plate Register interlock options 
        ///         
        /// ]]>
        /// <summary>
        /// <summary>
        /// Gets the inker dialog data.
        /// </summary>
        private void GetInkerDialogData()
        {
            if( (m_iSelectedInker >= 0) && ( m_iSelectedInker < m_listInkerConfig.Count ) )
            {
                MercuryAVTPLCRegisterInkerConfig registerInker = m_listInkerConfig[ m_iSelectedInker ];

                // Update Lateral Motor
                m_latMaxTravelTextBox.Text = registerInker.LateralMotor.MaxTravel.ToString();
                m_latLimitSwitchComboBox.SelectedIndex = (int)registerInker.LateralMotor.LimitSwitches;
                m_latSlopeTextBox.Text = registerInker.LateralMotor.Slope.ToString();
                m_latPotFeedbackCheckBox.Checked = registerInker.LateralMotor.PotFeedBack;
                m_latPotFeedbackMinTextBox.Text = registerInker.LateralMotor.PotFeedbackMin.ToString();
                m_latPotFeedbackMaxTextBox.Text = registerInker.LateralMotor.PotFeedbackMax.ToString();
                m_blockSidelayMotorOption.Checked = registerInker.LateralMotor.BlockMotorWhenPressStopped;
                UpdateLateralPotFeedbackControls();

                // Update Circ Motor
                m_circMaxTravelTextBox.Text = registerInker.CircMotor.MaxTravel.ToString();
                m_circLimitSwitchComboBox.SelectedIndex = (int)registerInker.CircMotor.LimitSwitches;
                m_circSlopeTextBox.Text = registerInker.CircMotor.Slope.ToString();
                m_circPotFeedbackCheckBox.Checked = registerInker.CircMotor.PotFeedBack;
                m_circPotFeedbackMinTextBox.Text = registerInker.CircMotor.PotFeedbackMin.ToString();
                m_circPotFeedbackMaxTextBox.Text = registerInker.CircMotor.PotFeedbackMax.ToString();
                m_blockCircMotorOption.Checked = registerInker.CircMotor.BlockMotorWhenPressStopped;
                UpdateCircPotFeedbackControls();

                // Update Skew Motor
                m_skewOptionCheckBox.Checked = registerInker.SkewEnabled;
                m_skewMaxTravelTextBox.Text = registerInker.SkewMotor.MaxTravel.ToString();
                m_skewLimitSwitchComboBox.SelectedIndex = (int)registerInker.SkewMotor.LimitSwitches;
                m_skewSlopeTextBox.Text = registerInker.SkewMotor.Slope.ToString();
                m_skewPotFeedbackCheckBox.Checked = registerInker.SkewMotor.PotFeedBack;
                m_skewPotFeedbackMinTextBox.Text = registerInker.SkewMotor.PotFeedbackMin.ToString();
                m_skewPotFeedbackMaxTextBox.Text = registerInker.SkewMotor.PotFeedbackMax.ToString();
                m_blockSkewMotorOption.Checked = registerInker.SkewMotor.BlockMotorWhenPressStopped;
                UpdateSkewControls();
            }
        }

        #endregion

        #region Events

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Change the title of the AVT PLC Configuration to include the PLC Control type ( Sweep / Water )
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Load event of the MercuryServerOptionsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryServerOptionsForm_Load(object sender, EventArgs e)
        {
            m_dlgTitle.Text = "Register" + " - " + m_dlgTitle.Text;
            ApplyDataToGUI();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [PLC Type combo box selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPlcTypeComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            // Update Register enable option based on PLC type selected
            m_registerOptionCheckBox.Checked = m_avtPLCConfig.RegisterEnabled && IsPLCCX50XXSelected();

            // Force update
            OnRegisterOptionCheckBox_CheckedChanged( null, null );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Handles the CheckedChanged event of the m_registerOptionCheckBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRegisterOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if( IsPLCCX50XXSelected() )
            {
                m_registerGroupBox.Enabled = true;

                if( m_registerOptionCheckBox.Checked )
                {
                    m_registerControlsGroupBox.Enabled = true;
                    m_registerInkerGroupBox.Enabled = true;
                }
                else
                {
                    m_registerControlsGroupBox.Enabled = false;
                    m_registerInkerGroupBox.Enabled = false;
                }
            }
            else
            {
                m_registerGroupBox.Enabled = false;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [register inker combo box selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRegisterInkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store any updates from current inker
            if( (m_iSelectedInker >= 0) && (m_iSelectedInker < m_listInkerConfig.Count) )
                SetInkerDialogData( m_iSelectedInker );

            // Update inker selection
            m_iSelectedInker = m_registerInkerComboBox.SelectedIndex;

            // Get selected inker data
            GetInkerDialogData();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// <summary>
        /// Called when [lat pot feedback check box checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLatPotFeedbackCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            UpdateLateralPotFeedbackControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// <summary>
        /// Called when [circ pot feedback check box checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCircPotFeedbackCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            UpdateCircPotFeedbackControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// <summary>
        /// Called when [skew pot feedback check box checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSkewPotFeedbackCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            UpdateSkewControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// <summary>
        /// Called when [skew option check box checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSkewOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            UpdateSkewControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [slope text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSlopeTextBox_Validating( object sender, CancelEventArgs e )
        {
            // Validate parameters
            TextBox boxSlope = sender as TextBox;
            if( boxSlope == null )
            {
                return;
            }

            // Validate input data - numeric value only
            int tmpValue;
            if( !int.TryParse( boxSlope.Text, out tmpValue ) )
            {
                MessageBox.Show( "Invalid Slope. Please input numeric data only.", "Invalid Entry" );
                boxSlope.SelectAll();
                boxSlope.Focus();
                return;
            }

            // Validate range            
            tmpValue = Convert.ToInt32( boxSlope.Text.Trim() );
            int minValue = DefineAndConst.SystemCapacities.REGISTER_SLOPE_MIN;
            int maxValue = DefineAndConst.SystemCapacities.REGISTER_SLOPE_MAX;
            if( (tmpValue < minValue) || (tmpValue > maxValue) )
            {
                string strText = "Invalid Slope. Valid Range is " +
                    minValue.ToString() + " to " + maxValue.ToString();
                MessageBox.Show( strText, "Invalid Entry" );
                boxSlope.SelectAll();
                boxSlope.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [max travel text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMaxTravelTextBox_Validating( object sender, CancelEventArgs e )
        {
            // Validate parameters
            TextBox boxMaxTravel = sender as TextBox;
            if( boxMaxTravel == null )
            {
                return;
            }

            // Validate input data - numeric value only
            float tmpValue;
            if( !float.TryParse( boxMaxTravel.Text, out tmpValue ) )
            {
                MessageBox.Show( "Invalid Max Travel. Please input numeric data only.", "Invalid Entry" );
                boxMaxTravel.SelectAll();
                boxMaxTravel.Focus();
                return;
            }

            // Validate range            
            tmpValue = (float)Convert.ToDouble( boxMaxTravel.Text.Trim() );
            float minValue = DefineAndConst.SystemCapacities.REGISTER_MOTOR_MIN_TRAVEL;
            float maxValue = DefineAndConst.SystemCapacities.REGISTER_MOTOR_MAX_TRAVEL;
            if( (tmpValue < minValue ) || (tmpValue > maxValue ) ) 
            {
                string strText = "Invalid Max Travel. Valid Range is " + 
                    minValue.ToString() + " to " + maxValue.ToString();
                MessageBox.Show( strText, "Invalid Entry" );
                boxMaxTravel.SelectAll();
                boxMaxTravel.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [skew max travel text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSkewMaxTravelTextBox_Validating( object sender, CancelEventArgs e )
        {
            // Validate parameters
            TextBox boxMaxTravel = sender as TextBox;
            if( boxMaxTravel == null )
            {
                return;
            }

            // Validate input data - numeric value only
            float tmpValue;
            if( !float.TryParse( boxMaxTravel.Text, out tmpValue ) )
            {
                MessageBox.Show( "Invalid Skew Max Travel. Please input numeric data only.", "Invalid Entry" );
                boxMaxTravel.SelectAll();
                boxMaxTravel.Focus();
                return;
            }

            // Validate range            
            tmpValue = (float)Convert.ToDouble( boxMaxTravel.Text.Trim() );
            float minValue = DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MIN_TRAVEL;
            float maxValue = DefineAndConst.SystemCapacities.REGISTER_SKEW_MOTOR_MAX_TRAVEL;
            if( (tmpValue < minValue) || (tmpValue > maxValue) )
            {
                string strText = "Invalid Skew Max Travel. Valid Range is " +
                    minValue.ToString() + " to " + maxValue.ToString();
                MessageBox.Show( strText, "Invalid Entry" );
                boxMaxTravel.SelectAll();
                boxMaxTravel.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [pot feedback voltage text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnPotFeedbackVoltageTextBox_Validating( object sender, CancelEventArgs e )
        {
            // Validate parameters
            TextBox boxPotFeedbackVolts = sender as TextBox;
            if( boxPotFeedbackVolts == null )
            {
                return;
            }

            // Validate input data - numeric value only
            float tmpValue;
            if( !float.TryParse( boxPotFeedbackVolts.Text, out tmpValue ) )
            {
                MessageBox.Show( "Invalid Pot Feedback Voltage. Please input numeric data only.", "Invalid Entry" );
                boxPotFeedbackVolts.SelectAll();
                boxPotFeedbackVolts.Focus();
                return;
            }

            // Validate range            
            tmpValue = (float)Convert.ToDouble( boxPotFeedbackVolts.Text.Trim() );
            float minValue = DefineAndConst.SystemCapacities.REGISTER_POT_FEEDBACK_MIN;
            float maxValue = DefineAndConst.SystemCapacities.REGISTER_POT_FEEDBACK_MAX;
            if( (tmpValue < minValue) || (tmpValue > maxValue) )
            {
                string strText = String.Format( "Invalid Pot Feedback voltage. Valid range is {0} to {1}",
                    minValue.ToString(), maxValue.ToString() );
                MessageBox.Show( strText, "Invalid Entry" );
                boxPotFeedbackVolts.SelectAll();
                boxPotFeedbackVolts.Focus();
            }

        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Called when [register inker copy button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRegisterInkerCopyButton_Click( object sender, EventArgs e )
        {
            string strText = String.Format( "Copy values of Inker \"{0}\" to all other Inkers?",
                    m_registerInkerComboBox.Text );
            DialogResult result = MessageBox.Show( strText, "Confirm Operation", MessageBoxButtons.YesNo );
            if( result == System.Windows.Forms.DialogResult.Yes )
            {
                // For each Inker ...
                for( int iInkerIndex = 0; iInkerIndex < InkerConfig.Count; iInkerIndex++ )
                {
                    // Copy dialog data
                    SetInkerDialogData( iInkerIndex );
                }
            }

        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            // Store any updates from current inker
            if( (m_iSelectedInker >= 0) && (m_iSelectedInker < m_listInkerConfig.Count) )
                SetInkerDialogData( m_iSelectedInker );

            // Copy dialog data to press
            UpdateDataFromGUI();
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///         
        /// ]]>
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



    }
}
