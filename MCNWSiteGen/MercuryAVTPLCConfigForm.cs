// ***********************************************************************
// Author           : Mark C
// Created          : 19-Jul-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCConfigForm.cs" company="AVT">
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
    public partial class MercuryAVTPLCConfigForm : Form
    {

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCConfigForm" /> class.
        /// </summary>
        /// <param name="press">The press.</param>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        /// <param name="avtPLCSweepControlSelected">if set to <c>true</c> [avt PLC sweep control selected].</param>
        public MercuryAVTPLCConfigForm( MCPressInfo press, MercuryAVTPLCConfig avtPLCConfig, bool avtPLCSweepControlSelected )
        {
            this.m_press = press;
            this.m_avtPLCConfig = avtPLCConfig;
            this.m_avtPLCSweepControlSelected = avtPLCSweepControlSelected;
            InitializeComponent();
        }

        #region implementation

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Applies the data to GUI.
        /// </summary>
        private void ApplyDataToGUI()
        {
            LoadPLCConfiguration();
            LoadSweepConfiguration();
            LoadWaterConfiguration();
            LoadPressSpeedConfiguration();
            LoadPlateInfoConfiguration();
            EnableVoltageConfiguration();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History:  05-Nov-18, Mark C, WI182050: Add support for 'Sync Sweep / Water console values' option       
        ///         
        /// ]]>
        /// <summary>
        /// Loads the PLC configuration.
        /// </summary>
        private void LoadPLCConfiguration()
        {
            // PLC Configuration details
            int plcType = Convert.ToInt32( m_avtPLCConfig.PLCType );
            if ( plcType < m_plcTypeComboBox.Items.Count )
            {
                m_plcTypeComboBox.SelectedIndex = plcType;
            }

            m_plcIPAddressTextBox.Text = m_avtPLCConfig.PLCIPAdrress;
            m_plcPortTextBox.Text = m_avtPLCConfig.PLCPortNum.ToString();
            m_syncSwpWtrConsoleValues.Checked = m_avtPLCConfig.SyncSweepWaterConsoleValues;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///          21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///          
        /// ]]>
        /// <summary>
        /// Loads the water configuration.
        /// </summary>
        private void LoadWaterConfiguration()
        {
            m_waterGroupBox.Enabled = ( !m_avtPLCSweepControlSelected );

            bool waterEnabled = m_avtPLCConfig.WaterEnabled;
            bool isCX50XXSelected = IsPLCCX50XXSelected();
            m_waterOptionCheckBox.Checked = waterEnabled;
            m_floodGroupBox.Enabled = waterEnabled && isCX50XXSelected;
            m_waterRampGroupBox.Enabled = waterEnabled && isCX50XXSelected;
            m_waterOptionsButton.Enabled = waterEnabled && isCX50XXSelected;
            m_waterFunControlOptionCheckBox.Enabled = waterEnabled && isCX50XXSelected;

            m_floodOptionCheckBox.Checked = m_avtPLCConfig.WaterConfig.FloodEnabled && isCX50XXSelected;
            m_waterRampOptionCheckBox.Checked = m_avtPLCConfig.WaterConfig.RampingEnabled && isCX50XXSelected;
            
            m_waterMasterControlOptionGroupBox.Enabled = m_avtPLCConfig.WaterConfig.RampingEnabled &&
                m_avtPLCConfig.WaterConfig.Ramping.MasterWaterControlEnabled && isCX50XXSelected;

            m_waterFunControlOptionCheckBox.Checked = m_avtPLCConfig.WaterConfig.FunctionControl.WaterFuncControlEnabled && isCX50XXSelected;
            m_waterMasterControlOptionCheckBox.Checked = m_avtPLCConfig.WaterConfig.Ramping.MasterWaterControlEnabled && isCX50XXSelected;

            // Flood details
            m_waterDefaultONTimeTextBox.Text = m_avtPLCConfig.WaterConfig.Flood.DefaultONTime.ToString();
            m_waterMaxONTimeTextBox.Text = m_avtPLCConfig.WaterConfig.Flood.MaxONTime.ToString();
            
            int methodOfFlood = Convert.ToInt32( m_avtPLCConfig.WaterConfig.Flood.FloodMethod );
            if ( methodOfFlood < m_waterMethodOfFloodComboBox.Items.Count )
            {
                m_waterMethodOfFloodComboBox.SelectedIndex = methodOfFlood;
            }

            int floodDevice = Convert.ToInt32( m_avtPLCConfig.WaterConfig.Flood.FloodDevice );
            if ( floodDevice < m_waterFloodDeviceComboBox.Items.Count )
            {
                m_waterFloodDeviceComboBox.SelectedIndex = floodDevice;
            }

            // Water Ramping
            m_waterTrimInfluenceTextBox.Text = m_avtPLCConfig.WaterConfig.Ramping.TrimInfluence.ToString();            
            m_waterMasterInfluenceTextBox.Text = m_avtPLCConfig.WaterConfig.Ramping.MasterInfluence.ToString();
            m_waterMasterSettingTextBox.Text = m_avtPLCConfig.WaterConfig.Ramping.WaterMasterSetting.ToString();

            EnableWaterFloodControls();
            EnableWaterRampingControls();
            EnableWaterFunctionControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///          21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters         
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///          
        /// ]]>
        /// <summary>
        /// Loads the sweep configuration.
        /// </summary>
        private void LoadSweepConfiguration()
        {
            m_sweepGroupBox.Enabled = m_avtPLCSweepControlSelected;

            bool sweepEnabled = m_avtPLCConfig.SweepEnabled;
            bool isCX50XXSelected = IsPLCCX50XXSelected();
            m_sweepOptionCheckBox.Checked = sweepEnabled;
            m_inkSurgeGroupBox.Enabled = sweepEnabled && isCX50XXSelected;
            m_sweepRampGroupBox.Enabled = sweepEnabled && isCX50XXSelected;
            m_ductorHoldOffGroupBox.Enabled = sweepEnabled && isCX50XXSelected;
            m_inkerWashupFeatureGroupBox.Enabled = sweepEnabled && isCX50XXSelected;
            m_inkerOptionsButton.Enabled = sweepEnabled && isCX50XXSelected;
            m_sweepFuncControlOptionCheckBox.Enabled = sweepEnabled && isCX50XXSelected;

            m_inkerWashupFeatureCheckBox.Checked = m_avtPLCConfig.SweepConfig.InkerWashupEnabled && isCX50XXSelected;
            m_inkSurgeOptionCheckBox.Checked = m_avtPLCConfig.SweepConfig.SurgeEnabled && isCX50XXSelected;
            m_sweepRampOptionCheckBox.Checked = m_avtPLCConfig.SweepConfig.RampingEnabled && isCX50XXSelected;
            m_ductorHoldOffOptionCheckBox.Checked = m_avtPLCConfig.SweepConfig.DuctorHoldOffEnabled && isCX50XXSelected;
            
            m_sweepMasterControlOptionGroupBox.Enabled = m_avtPLCConfig.SweepConfig.RampingEnabled &&
                m_avtPLCConfig.SweepConfig.Ramping.MasterSweepControlEnabled && isCX50XXSelected;

            m_sweepFuncControlOptionCheckBox.Checked = m_avtPLCConfig.SweepConfig.FunctionControl.SweepFuncControlEnabled && isCX50XXSelected;
            m_sweepMasterControlOptionCheckBox.Checked = m_avtPLCConfig.SweepConfig.Ramping.MasterSweepControlEnabled && isCX50XXSelected;

            // Ink Surge details
            m_sweepDefaultONTimeTextBox.Text = m_avtPLCConfig.SweepConfig.InkSurge.DefaultONTime.ToString();
            m_sweepMaxONTimeTextBox.Text = m_avtPLCConfig.SweepConfig.InkSurge.MaxONTime.ToString();
            

            int methodOfSurge = Convert.ToInt32( m_avtPLCConfig.SweepConfig.InkSurge.SurgeMethod );
            if ( methodOfSurge < m_methodOfSurgeComboBox.Items.Count )
            {
                m_methodOfSurgeComboBox.SelectedIndex = methodOfSurge;
            }

            int surgeDevice = Convert.ToInt32( m_avtPLCConfig.SweepConfig.InkSurge.SurgeDevice );
            if ( surgeDevice < m_surgeDeviceComboBox.Items.Count )
            {
                m_surgeDeviceComboBox.SelectedIndex = surgeDevice;
            }

            // Sweep Ramping details
            m_sweepTrimInfluenceTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.TrimInfluence.ToString();
            m_sweepMasterInfluenceTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.MasterInfluence.ToString();
            m_inkerMasterSettingTextBox.Text = m_avtPLCConfig.SweepConfig.Ramping.InkMasterSetting.ToString();

            // Sweep Ductor Hold-off details
            m_sweepNumberOfRangesTextBox.Text = m_avtPLCConfig.SweepConfig.DuctorHoldOff.NumOfRanges.ToString();

            EnableInkSurgeControls();
            EnableSweepRampingControls();
            EnableSweepFunctionControls();
            EnableDuctorHoldOffControls();
            UpdateDuctorHoldOffRangesListView();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///          
        /// ]]>
        /// <summary>
        /// Loads the press speed configuration.
        /// </summary>
        private void LoadPressSpeedConfiguration()
        {
            m_pressSpeedGroupBox.Enabled = IsPLCCX50XXSelected();

            m_minPressSpeedTextBox.Text = m_avtPLCConfig.PressSpeedConfig.MinPressSpeed.ToString();
            m_maxPressSpeedTextBox.Text = m_avtPLCConfig.PressSpeedConfig.MaxPressSpeed.ToString();

            int dispPressSpeedOption = Convert.ToInt32( m_avtPLCConfig.PressSpeedConfig.DisplayPressSpeedOption );
            if( dispPressSpeedOption < m_displayPressSpeedComboBox.Items.Count )
            {
                m_displayPressSpeedComboBox.SelectedIndex = dispPressSpeedOption;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///          
        /// ]]>
        /// <summary>
        /// Loads the plate information configuration.
        /// </summary>
        private void LoadPlateInfoConfiguration()
        {
            m_plateInfoGroupBox.Enabled = IsPLCCX50XXSelected();

            m_impressionLengthOfPlateTextBox.Text = m_avtPLCConfig.PlateInfoConfig.ImpressionLengthOfPlate.ToString();
            m_numberOfPlatesInFountainComboBox.Text = m_avtPLCConfig.PlateInfoConfig.NumOfPlatesInFountain.ToString();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            UpdatePLCConfigData();
            UpdateSweepConfigData();
            UpdateWaterConfigData();
            UpdatePressSpeedConfigData();
            UpdatePlateInfoConfigData();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History:  05-Nov-18, Mark C, WI182050: Add support for 'Sync Sweep / Water console values' option       
        ///         
        /// ]]>
        /// <summary>
        /// Updates the PLC configuration data.
        /// </summary>
        private void UpdatePLCConfigData()
        {
            // PLC Config details
            m_avtPLCConfig.PLCType = ( AVTPLCType ) ( m_plcTypeComboBox.SelectedIndex );
            m_avtPLCConfig.PLCIPAdrress = m_plcIPAddressTextBox.Text.Trim();
            m_avtPLCConfig.PLCPortNum = Convert.ToInt32( m_plcPortTextBox.Text.Trim() );
            m_avtPLCConfig.SyncSweepWaterConsoleValues = m_syncSwpWtrConsoleValues.Checked;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        /// 
        /// ]]>
        /// <summary>
        /// Updates the sweep configuration data.
        /// </summary>
        private void UpdateSweepConfigData()
        {
            // Sweep Config details
            m_avtPLCConfig.SweepEnabled = m_sweepOptionCheckBox.Checked;

            // Sweep - Ink Surge config details
            m_avtPLCConfig.SweepConfig.SurgeEnabled = m_inkSurgeOptionCheckBox.Checked;
            m_avtPLCConfig.SweepConfig.InkSurge.DefaultONTime = Convert.ToInt32( m_sweepDefaultONTimeTextBox.Text.Trim() );
            m_avtPLCConfig.SweepConfig.InkSurge.MaxONTime = Convert.ToInt32( m_sweepMaxONTimeTextBox.Text.Trim() );            
            m_avtPLCConfig.SweepConfig.InkSurge.SurgeMethod = ( MethodOfSurge ) ( m_methodOfSurgeComboBox.SelectedIndex );
            m_avtPLCConfig.SweepConfig.InkSurge.SurgeDevice = ( SurgeDevice ) ( m_surgeDeviceComboBox.SelectedIndex );

            // Inker Wash up configuration
            m_avtPLCConfig.SweepConfig.InkerWashupEnabled = m_inkerWashupFeatureCheckBox.Checked;

            // Sweep - ramping config details
            m_avtPLCConfig.SweepConfig.RampingEnabled = m_sweepRampOptionCheckBox.Checked;
            m_avtPLCConfig.SweepConfig.Ramping.TrimInfluence = Convert.ToInt32( m_sweepTrimInfluenceTextBox.Text.Trim() );
            m_avtPLCConfig.SweepConfig.Ramping.InkMasterSetting = Convert.ToInt32( m_inkerMasterSettingTextBox.Text.Trim() );

            // Sweep - function control
            m_avtPLCConfig.SweepConfig.FunctionControl.SweepFuncControlEnabled = m_sweepFuncControlOptionCheckBox.Checked;
            
            // Sweep - master Sweep Control
            m_avtPLCConfig.SweepConfig.Ramping.MasterSweepControlEnabled = m_sweepMasterControlOptionCheckBox.Checked;
            m_avtPLCConfig.SweepConfig.Ramping.MasterInfluence = Convert.ToInt32( m_sweepMasterInfluenceTextBox.Text.Trim() );
            
            // Sweep - Ductor hold-off details
            m_avtPLCConfig.SweepConfig.DuctorHoldOffEnabled = m_ductorHoldOffOptionCheckBox.Checked;
            m_avtPLCConfig.SweepConfig.DuctorHoldOff.NumOfRanges = Convert.ToInt32( m_sweepNumberOfRangesTextBox.Text.Trim() );

            m_avtPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Clear();

            foreach ( GLItem item in m_ductorRangesListView.Items )
            {
                if ( string.IsNullOrEmpty( item.SubItems[ VALUE_COL ].Control.Text ) )
                {
                    continue;
                }

                MercuryAVTPLCSweep_DuctorHoldOffRange rangeItem = new MercuryAVTPLCSweep_DuctorHoldOffRange();                
                rangeItem.Value = Convert.ToInt32( item.SubItems[ VALUE_COL ].Control.Text );

                m_avtPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Add( rangeItem );
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          
        /// ]]>
        /// <summary>
        /// Updates the water configuration data.
        /// </summary>
        private void UpdateWaterConfigData()
        {
            // Water Config details
            m_avtPLCConfig.WaterEnabled = m_waterOptionCheckBox.Checked;

            // Water - Flood config details
            m_avtPLCConfig.WaterConfig.FloodEnabled = m_floodOptionCheckBox.Checked;
            m_avtPLCConfig.WaterConfig.Flood.DefaultONTime = Convert.ToInt32( m_waterDefaultONTimeTextBox.Text.Trim() );
            m_avtPLCConfig.WaterConfig.Flood.MaxONTime = Convert.ToInt32( m_waterMaxONTimeTextBox.Text.Trim() );            
            m_avtPLCConfig.WaterConfig.Flood.FloodMethod = ( MethodOfFlood ) ( m_waterMethodOfFloodComboBox.SelectedIndex );
            m_avtPLCConfig.WaterConfig.Flood.FloodDevice = ( FloodDevice ) ( m_waterFloodDeviceComboBox.SelectedIndex );

            // Water - Ramping config details
            m_avtPLCConfig.WaterConfig.RampingEnabled = m_waterRampOptionCheckBox.Checked;
            m_avtPLCConfig.WaterConfig.Ramping.TrimInfluence = Convert.ToInt32( m_waterTrimInfluenceTextBox.Text.Trim() );
            
            // Water - Function control details
            m_avtPLCConfig.WaterConfig.FunctionControl.WaterFuncControlEnabled = m_waterFunControlOptionCheckBox.Checked;
            
            // Water - Master Water control
            m_avtPLCConfig.WaterConfig.Ramping.MasterWaterControlEnabled = m_waterMasterControlOptionCheckBox.Checked;
            m_avtPLCConfig.WaterConfig.Ramping.MasterInfluence = Convert.ToInt32( m_waterMasterInfluenceTextBox.Text.Trim() );

            // Water - Master Setting
            m_avtPLCConfig.WaterConfig.Ramping.WaterMasterSetting = Convert.ToInt32( m_waterMasterSettingTextBox.Text.Trim() );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the press speed configuration data.
        /// </summary>
        private void UpdatePressSpeedConfigData()
        {
            // Press Speed - Min, Max and Display Speed Option
            m_avtPLCConfig.PressSpeedConfig.MinPressSpeed = Convert.ToInt32( m_minPressSpeedTextBox.Text.Trim() );
            m_avtPLCConfig.PressSpeedConfig.MaxPressSpeed = Convert.ToInt32( m_maxPressSpeedTextBox.Text.Trim() );
            m_avtPLCConfig.PressSpeedConfig.DisplayPressSpeedOption = ( DisplayPressSpeedOption )( m_displayPressSpeedComboBox.SelectedIndex );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the plate information configuration data.
        /// </summary>
        private void UpdatePlateInfoConfigData()
        {
            // Plate Info - Impression Length of Plate, #of plates in Fountain
            m_avtPLCConfig.PlateInfoConfig.ImpressionLengthOfPlate = Convert.ToInt32( m_impressionLengthOfPlateTextBox.Text.Trim() );
            m_avtPLCConfig.PlateInfoConfig.NumOfPlatesInFountain = Convert.ToInt32( m_numberOfPlatesInFountainComboBox.Text );
        }

        #endregion

        #region events

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
        private void MercuryServerOptionsForm_Load( object sender, EventArgs e )
        {
            m_dlgTitle.Text = (m_avtPLCSweepControlSelected ? "Sweep" : "Water") + " - " + m_dlgTitle.Text;
            CreateDuctorHoldOffRangeListView();
            ApplyDataToGUI();            
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Creates the ductor hold off range ListView.
        /// </summary>
        private void CreateDuctorHoldOffRangeListView()
        {
            m_rangeIndexColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_rangeIndexColumn.Name = "Index";
            m_rangeIndexColumn.Text = "Index";
            m_rangeIndexColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            m_rangeValueColumn.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.None;
            m_rangeValueColumn.Name = "Value";
            m_rangeValueColumn.Text = "Value %\n( 0-100 )";
            m_rangeValueColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            m_ductorRangesListView.Columns.AddRange( new MC3Column[] {
                    m_rangeIndexColumn,
                    m_rangeValueColumn} );

            if ( 0 != m_ductorRangesListView.Columns.Count )
            {
                int desiredColumnWidth = ( m_ductorRangesListView.Width / m_ductorRangesListView.Columns.Count );
                m_rangeIndexColumn.Width = desiredColumnWidth;
                m_rangeValueColumn.Width = desiredColumnWidth;
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

        #endregion

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping        
        ///          21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Called when [sweep option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            bool sweepEnabled = m_sweepOptionCheckBox.Checked && IsPLCCX50XXSelected();
            m_inkSurgeGroupBox.Enabled = sweepEnabled;
            m_sweepRampGroupBox.Enabled = sweepEnabled;
            m_ductorHoldOffGroupBox.Enabled = sweepEnabled;
            m_inkerWashupFeatureGroupBox.Enabled = sweepEnabled;            
            m_inkerOptionsButton.Enabled = sweepEnabled;
            m_sweepFuncControlOptionCheckBox.Enabled = sweepEnabled;

            m_inkerWashupFeatureCheckBox.Checked = sweepEnabled && m_inkerWashupFeatureCheckBox.Checked;
            m_inkSurgeOptionCheckBox.Checked = sweepEnabled && m_inkSurgeOptionCheckBox.Checked;
            m_sweepRampOptionCheckBox.Checked = sweepEnabled && m_sweepRampOptionCheckBox.Checked;
            m_sweepFuncControlOptionCheckBox.Checked = sweepEnabled && m_sweepFuncControlOptionCheckBox.Checked;
            m_ductorHoldOffOptionCheckBox.Checked = sweepEnabled && m_ductorHoldOffOptionCheckBox.Checked;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping                
        ///          21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        /// 		 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// Called when [water option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            bool waterEnabled = m_waterOptionCheckBox.Checked && IsPLCCX50XXSelected();
            m_floodGroupBox.Enabled = waterEnabled;
            m_waterRampGroupBox.Enabled = waterEnabled;            
            m_waterOptionsButton.Enabled = waterEnabled;
            m_waterFunControlOptionCheckBox.Enabled = waterEnabled;

            m_floodOptionCheckBox.Checked = waterEnabled && m_floodOptionCheckBox.Checked;
            m_waterRampOptionCheckBox.Checked = waterEnabled && m_waterRampOptionCheckBox.Checked;
            m_waterFunControlOptionCheckBox.Checked = waterEnabled && m_waterFunControlOptionCheckBox.Checked;
        }

        /// <summary>
        /// Called when [sweep ramp option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepRampOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableSweepRampingControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///          
        /// ]]>
        /// <summary>
        /// Enables the sweep ramping controls.
        /// </summary>
        private void EnableSweepRampingControls()
        {
            bool sweepRampEnabled = m_sweepRampOptionCheckBox.Checked;
            // Enable / Disable Sweep Trim Influence as per Sweep Ramp option
            m_sweepTrimInfluenceLabel.Enabled = sweepRampEnabled;
            m_sweepTrimInfluenceUnits.Enabled = sweepRampEnabled;
            m_sweepTrimInfluenceTextBox.Enabled = sweepRampEnabled;
            // Enable / Disable Ink Master Setting  as per Sweep Ramp option
            m_inkerMasterSettingLabel.Enabled = sweepRampEnabled;
            m_inkerMasterSettingTextBox.Enabled = sweepRampEnabled;
            m_inkerMasterSettingUnits.Enabled = sweepRampEnabled;

            m_sweepMasterControlOptionGroupBox.Enabled = sweepRampEnabled;           
            m_sweepMasterControlOptionCheckBox.Checked = sweepRampEnabled && m_sweepMasterControlOptionCheckBox.Checked;

            EnableSweepMasterControls();
        }

        /// <summary>
        /// Called when [water ramp option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterRampOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableWaterRampingControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        /// 		 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///         
        /// ]]>
        /// <summary>
        /// Enables the water ramping controls.
        /// </summary>
        private void EnableWaterRampingControls()
        {
            bool waterRampEnabled = m_waterRampOptionCheckBox.Checked;
            // Enable / Disable Water Trim influence as per Water Ramp Eabled
            m_waterTrimInfluenceLabel.Enabled = waterRampEnabled;
            m_waterTrimInfluenceUnits.Enabled = waterRampEnabled;
            m_waterTrimInfluenceTextBox.Enabled = waterRampEnabled;

            // Enable / Disable Water Master Setting as per Water Ramp Enabled
            m_waterMasterSettingLabel.Enabled = waterRampEnabled;
            m_waterMasterSettingTextBox.Enabled = waterRampEnabled;
            m_waterMasterSettingUnits.Enabled = waterRampEnabled;            
            
            m_waterMasterControlOptionGroupBox.Enabled = waterRampEnabled;
            m_waterMasterControlOptionCheckBox.Checked = waterRampEnabled && m_waterMasterControlOptionCheckBox.Checked;
                        
            EnableWaterMasterControls();
        }

        /// <summary>
        /// Called when [ink surge option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnInkSurgeOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableInkSurgeControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///         
        /// ]]>
        /// <summary>
        /// Enables the ink surge controls.
        /// </summary>
        private void EnableInkSurgeControls()
        {
            bool inkSurgeEnbaled = m_inkSurgeOptionCheckBox.Checked;
            m_sweepDefaultONTimeLabel.Enabled = inkSurgeEnbaled;
            m_sweepDefaultONTimeUnits.Enabled = inkSurgeEnbaled;
            m_sweepDefaultONTimeTextBox.Enabled = inkSurgeEnbaled;

            m_sweepMaxONTimeLabel.Enabled = inkSurgeEnbaled;
            m_sweepMaxONTimeUnits.Enabled = inkSurgeEnbaled;
            m_sweepMaxONTimeTextBox.Enabled = inkSurgeEnbaled;

            m_sweepMethodOfSurgelabel.Enabled = inkSurgeEnbaled;
            m_methodOfSurgeComboBox.Enabled = inkSurgeEnbaled;

            m_sweepSurgeDeviceLabel.Enabled = inkSurgeEnbaled;
            m_surgeDeviceComboBox.Enabled = inkSurgeEnbaled;
        }

        /// <summary>
        /// Called when [ductor hold off option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnDuctorHoldOffOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableDuctorHoldOffControls();
        }

        /// <summary>
        /// Enables the ductor hold off controls.
        /// </summary>
        private void EnableDuctorHoldOffControls()
        {
            bool ductorHoldOffEnabled = m_ductorHoldOffOptionCheckBox.Checked;
            m_sweepNumberOfRangesLabel.Enabled = ductorHoldOffEnabled;
            m_sweepNumberOfRangesUnits.Enabled = ductorHoldOffEnabled;
            m_sweepNumberOfRangesTextBox.Enabled = ductorHoldOffEnabled;

            m_ductorRangesListView.Enabled = ductorHoldOffEnabled;
        }

        /// <summary>
        /// Called when [flood option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnFloodOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableWaterFloodControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///         
        /// ]]>
        /// <summary>
        /// Enables the water flood controls.
        /// </summary>
        private void EnableWaterFloodControls()
        {
            bool floodOptionEnabled = m_floodOptionCheckBox.Checked;
            m_waterDefaultOnTimeLabel.Enabled = floodOptionEnabled;
            m_waterDefaultOnTimeUnits.Enabled = floodOptionEnabled;
            m_waterDefaultONTimeTextBox.Enabled = floodOptionEnabled;

            m_waterMaxONTimeLabel.Enabled = floodOptionEnabled;
            m_waterMaxONTimeUnits.Enabled = floodOptionEnabled;
            m_waterMaxONTimeTextBox.Enabled = floodOptionEnabled;

            m_waterMethodOfFloodLabel.Enabled = floodOptionEnabled;
            m_waterMethodOfFloodComboBox.Enabled = floodOptionEnabled;

            m_waterFloodDeviceLabel.Enabled = floodOptionEnabled;
            m_waterFloodDeviceComboBox.Enabled = floodOptionEnabled;
        }

        /// <summary>
        /// Called when [sweep function control option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepFuncControlOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableSweepFunctionControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///         
        /// ]]>
        /// <summary>
        /// Enables the sweep function controls.
        /// </summary>
        private void EnableSweepFunctionControls()
        {
            bool sweepFuncEnabled = m_sweepFuncControlOptionCheckBox.Checked;
        }

        /// <summary>
        /// Called when [sweep master control option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSweepMasterControlOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableSweepMasterControls();
        }

        /// <summary>
        /// Enables the sweep master controls.
        /// </summary>
        private void EnableSweepMasterControls()
        {
            bool sweepMasterEnabled = m_sweepMasterControlOptionCheckBox.Checked;
            m_sweepMasterInfluenceLabel.Enabled = sweepMasterEnabled;
            m_sweepMasterInfluenceUnits.Enabled = sweepMasterEnabled;
            m_sweepMasterInfluenceTextBox.Enabled = sweepMasterEnabled;
        }

        /// <summary>
        /// Called when [water fun control option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterFunControlOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableWaterFunctionControls();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///         
        /// ]]>
        /// <summary>
        /// Enables the water function controls.
        /// </summary>
        private void EnableWaterFunctionControls()
        {
            bool waterFuncEnabled = m_waterFunControlOptionCheckBox.Checked;
        }

        /// <summary>
        /// Called when [water master control option CheckBox checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterMasterControlOptionCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            EnableWaterMasterControls();
        }

        /// <summary>
        /// Enables the water master controls.
        /// </summary>
        private void EnableWaterMasterControls()
        {
            bool waterMasterEnabled = m_waterMasterControlOptionCheckBox.Checked;
            m_waterMasterInfluenceLabel.Enabled = waterMasterEnabled;
            m_waterMasterInfluenceUnits.Enabled = waterMasterEnabled;
            m_waterMasterInfluenceTextBox.Enabled = waterMasterEnabled;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the ductor hold off ranges ListView.
        /// </summary>
        private void UpdateDuctorHoldOffRangesListView()
        {
            if ( string.IsNullOrEmpty( m_sweepNumberOfRangesTextBox.Text.Trim() ) )
            {
                return;
            }

            m_ductorRangesListView.Items.Clear();

            int itemsCount = Convert.ToInt32( m_sweepNumberOfRangesTextBox.Text );
            for ( int itemIndex = 0; itemIndex < itemsCount; ++itemIndex )
            {
                UpdateRangeListView_IndexColumn( itemIndex );
                UpdateRangeListView_ValueColumn( itemIndex );
            }

            PopulateDuctorHoldOffRangesListView();

            m_ductorRangesListView.Refresh();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Populates the ductor hold off ranges ListView.
        /// </summary>
        private void PopulateDuctorHoldOffRangesListView()
        {
            int counter = 0;
            foreach ( MercuryAVTPLCSweep_DuctorHoldOffRange rangeItem in m_avtPLCConfig.SweepConfig.DuctorHoldOff.RangeList )
            {
                if ( counter < m_ductorRangesListView.Items.Count )
                {                    
                    m_ductorRangesListView.Items[ counter ].SubItems[ VALUE_COL ].Control.Text = rangeItem.Value.ToString();
                    counter++;
                }
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the range ListView index column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        private void UpdateRangeListView_IndexColumn( int itemIndex )
        {
            string recordName = string.Format( "{0}", ( itemIndex + 1 ) );
            m_ductorRangesListView.Items.Add( recordName );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Updates the range ListView value column.
        /// </summary>
        /// <param name="itemIndex">Index of the item.</param>
        private void UpdateRangeListView_ValueColumn( int itemIndex )
        {
            TextBox valueTextBox = new TextBox();
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.MaxLength = 3;
            valueTextBox.Text = "0";            
            valueTextBox.Validating += OnValueTextBox_Validating;

            if ( itemIndex < m_ductorRangesListView.Items.Count )
            {
                m_ductorRangesListView.Items[ itemIndex ].SubItems[ VALUE_COL ].Control = valueTextBox;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [value text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnValueTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox valueText = sender as TextBox;
            if ( null == valueText )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( valueText.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Value. Please input valid data." );
                valueText.SelectAll();
                valueText.Focus();
                return;
            }

            int tmpValueText = Convert.ToInt32( valueText.Text.Trim() );
            if ( ( tmpValueText < 0 ) ||
                ( tmpValueText > 99 ) )
            {
                MessageBox.Show( "Invalid Value. Valid Range is 0 to 99." );
                valueText.SelectAll();
                valueText.Focus();
            }
        }

        /// <summary>
        /// Called when [PLC ip address text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnPlcIPAddressTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox ipAddressTextBox = sender as TextBox;
            if ( null == ipAddressTextBox )
            {
                return;
            }

            System.Net.IPAddress IPAddress;
            if ( !string.IsNullOrEmpty( ipAddressTextBox.Text ) &&
                 System.Net.IPAddress.TryParse( ipAddressTextBox.Text.Trim(), out IPAddress ) )
            {
                if ( null != IPAddress )
                {
                    string newIPAddress = IPAddress.ToString();
                    ipAddressTextBox.Text = newIPAddress;
                }
            }
            else
            {
                MessageBox.Show( "Invalid IP Address. Please input valid IP Address." );                
                ipAddressTextBox.SelectAll();
                ipAddressTextBox.Focus();
            }
        }

        /// <summary>
        /// Called when [sweep default on time text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepDefaultONTimeTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox defaultOnTime = sender as TextBox;
            if ( null == defaultOnTime )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( defaultOnTime.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Default ON Time. Please input valid data." );
                defaultOnTime.SelectAll();
                defaultOnTime.Focus();
                return;
            }

            // validate range            
            int tmpDefaultOnTime = Convert.ToInt32( defaultOnTime.Text.Trim() );
            if ( ( tmpDefaultOnTime < 1 ) ||
                ( tmpDefaultOnTime > 99 ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Valid Range is 1 to 99." );
                defaultOnTime.SelectAll();
                defaultOnTime.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [sweep maximum on time text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepMaxONTimeTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox maxOnTime = sender as TextBox;
            if ( null == maxOnTime )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( maxOnTime.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Please input valid data." );
                maxOnTime.SelectAll();
                maxOnTime.Focus();
                return;
            }

            int tmpMaxOnTime = Convert.ToInt32( maxOnTime.Text.Trim() );
            if( ( tmpMaxOnTime < 1 ) ||
                ( tmpMaxOnTime > 200 ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Valid Range is 1 to 200." );
                maxOnTime.SelectAll();
                maxOnTime.Focus();
            }
            else
            {
                int defaultOnTime = Convert.ToInt32( m_sweepDefaultONTimeTextBox.Text.Trim() );
                // Max ON Time should be greater than Default ON Time.
                if( tmpMaxOnTime <= defaultOnTime )
                {
                    MessageBox.Show( "Max ON Time should be greater than Default ON Time. Please input valid data." );
                    maxOnTime.SelectAll();
                    maxOnTime.Focus();
                }
            }            
        }

        /// <summary>
        /// Called when [sweep surge trim text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepSurgeTrimTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox surgeTrim = sender as TextBox;
            if ( null == surgeTrim )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( surgeTrim.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Surge Trim. Please input valid data." );
                surgeTrim.SelectAll();
                surgeTrim.Focus();
                return;
            }

            int tmpSurgeTrim = Convert.ToInt32( surgeTrim.Text.Trim() );
            if ( ( tmpSurgeTrim < 0 ) ||
                ( tmpSurgeTrim > 99 ) )
            {
                MessageBox.Show( "Invalid Surge Trim. Valid Range is 0 to 99." );
                surgeTrim.SelectAll();
                surgeTrim.Focus();
            }
        }

        /// <summary>
        /// Called when [sweep trim influence text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepTrimInfluenceTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox trimInfluence = sender as TextBox;
            if ( null == trimInfluence )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( trimInfluence.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Trim Influence. Please input valid data." );
                trimInfluence.SelectAll();
                trimInfluence.Focus();
                return;
            }

            int tmpTrimInfluence = Convert.ToInt32( trimInfluence.Text.Trim() );
            if ( ( tmpTrimInfluence < 0 ) ||
                ( tmpTrimInfluence > 50 ) )
            {
                MessageBox.Show( "Invalid Trim Influence. Valid Range is 0 to 50." );
                trimInfluence.SelectAll();
                trimInfluence.Focus();
            }
        }

        /// <summary>
        /// Called when [sweep trim setting manual text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepTrimSettingManualTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox trimSetting = sender as TextBox;
            if ( null == trimSetting )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( trimSetting.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Trim Setting Manual. Please input valid data." );
                trimSetting.SelectAll();
                trimSetting.Focus();
                return;
            }

            int tmpTrimSetting = Convert.ToInt32( trimSetting.Text.Trim() );
            if ( ( tmpTrimSetting < 0 ) ||
                ( tmpTrimSetting > 99 ) )
            {
                MessageBox.Show( "Invalid Trim Setting Manual. Valid Range is 0 to 99." );
                trimSetting.SelectAll();
                trimSetting.Focus();
            }
        }

        /// <summary>
        /// Called when [sweep master influence text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepMasterInfluenceTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox masterInfluence = sender as TextBox;
            if ( null == masterInfluence )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( masterInfluence.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Master Influence. Please input valid data." );
                masterInfluence.SelectAll();
                masterInfluence.Focus();
                return;
            }

            int tmpMasterInfluence = Convert.ToInt32( masterInfluence.Text.Trim() );
            if ( ( tmpMasterInfluence < 0 ) ||
                ( tmpMasterInfluence > 50 ) )
            {
                MessageBox.Show( "Invalid Master Influence. Valid Range is 0 to 50." );
                masterInfluence.SelectAll();
                masterInfluence.Focus();
            }
        }

        /// <summary>
        /// Called when [sweep number of ranges text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnSweepNumberOfRangesTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox numOfRanges = sender as TextBox;
            if ( null == numOfRanges )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( numOfRanges.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Num Of Ranges. Please input valid data." );
                numOfRanges.SelectAll();
                numOfRanges.Focus();
                return;
            }

            int tmpNumOfRanges = Convert.ToInt32( numOfRanges.Text.Trim() );
            if ( ( tmpNumOfRanges < 1 ) ||
                ( tmpNumOfRanges > 10 ) )
            {
                MessageBox.Show( "Invalid Num Of Ranges. Valid Range is 1 to 10." );
                numOfRanges.SelectAll();
                numOfRanges.Focus();
            }
            else
            {
                UpdateDuctorHoldOffRangesListView();
            }
        }

        /// <summary>
        /// Called when [water default on time text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterDefaultONTimeTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox defaultOnTime = sender as TextBox;
            if ( null == defaultOnTime )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( defaultOnTime.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Default ON Time. Please input valid data." );
                defaultOnTime.SelectAll();
                defaultOnTime.Focus();
                return;
            }

            // validate range            
            int tmpDefaultOnTime = Convert.ToInt32( defaultOnTime.Text.Trim() );
            if ( ( tmpDefaultOnTime < 1 ) ||
                ( tmpDefaultOnTime > 99 ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Valid Range is 1 to 99." );
                defaultOnTime.SelectAll();
                defaultOnTime.Focus();
            }
        }

        /// <summary>
        /// Called when [water maximum on time text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterMaxONTimeTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox maxOnTime = sender as TextBox;
            if ( null == maxOnTime )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( maxOnTime.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Please input valid data." );
                maxOnTime.SelectAll();
                maxOnTime.Focus();
                return;
            }

            int tmpMaxOnTime = Convert.ToInt32( maxOnTime.Text.Trim() );
            if ( ( tmpMaxOnTime < 1 ) ||
                ( tmpMaxOnTime > 200 ) )
            {
                MessageBox.Show( "Invalid Max ON Time. Valid Range is 1 to 200." );
                maxOnTime.SelectAll();
                maxOnTime.Focus();
            }
        }

        /// <summary>
        /// Called when [water flood trim text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterFloodTrimTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox floodTrim = sender as TextBox;
            if ( null == floodTrim )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( floodTrim.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Flood Trim. Please input valid data." );
                floodTrim.SelectAll();
                floodTrim.Focus();
                return;
            }

            int tmpFloodTrim = Convert.ToInt32( floodTrim.Text.Trim() );
            if ( ( tmpFloodTrim < 0 ) ||
                ( tmpFloodTrim > 99 ) )
            {
                MessageBox.Show( "Invalid Flood Trim. Valid Range is 0 to 99." );
                floodTrim.SelectAll();
                floodTrim.Focus();
            }
        }

        /// <summary>
        /// Called when [water trim influence text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterTrimInfluenceTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox trimInfluence = sender as TextBox;
            if ( null == trimInfluence )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( trimInfluence.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Trim Influence. Please input valid data." );
                trimInfluence.SelectAll();
                trimInfluence.Focus();
                return;
            }

            int tmpTrimInfluence = Convert.ToInt32( trimInfluence.Text.Trim() );
            if ( ( tmpTrimInfluence < 0 ) ||
                ( tmpTrimInfluence > 50 ) )
            {
                MessageBox.Show( "Invalid Trim Influence. Valid Range is 0 to 50." );
                trimInfluence.SelectAll();
                trimInfluence.Focus();
            }
        }

        /// <summary>
        /// Called when [water trim setting manual text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterTrimSettingManualTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox trimSetting = sender as TextBox;
            if ( null == trimSetting )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( trimSetting.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Trim Setting Manual. Please input valid data." );
                trimSetting.SelectAll();
                trimSetting.Focus();
                return;
            }

            int tmpTrimSetting = Convert.ToInt32( trimSetting.Text.Trim() );
            if ( ( tmpTrimSetting < 0 ) ||
                ( tmpTrimSetting > 99 ) )
            {
                MessageBox.Show( "Invalid Trim Setting Manual. Valid Range is 0 to 99." );
                trimSetting.SelectAll();
                trimSetting.Focus();
            }
        }

        /// <summary>
        /// Called when [water master influence text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterMasterInfluenceTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox masterInfluence = sender as TextBox;
            if ( null == masterInfluence )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( masterInfluence.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Master Influence. Please input valid data." );
                masterInfluence.SelectAll();
                masterInfluence.Focus();
                return;
            }

            int tmpMasterInfluence = Convert.ToInt32( masterInfluence.Text.Trim() );
            if ( ( tmpMasterInfluence < 0 ) ||
                ( tmpMasterInfluence > 50 ) )
            {
                MessageBox.Show( "Invalid Master Influence. Valid Range is 0 to 50." );
                masterInfluence.SelectAll();
                masterInfluence.Focus();
            }
        }


        /// <summary>
        /// Called when [PLC port text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnPlcPortTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox plcPort = sender as TextBox;
            if ( null == plcPort )
            {
                return;
            }

            // Validate input data - numeric value only
            if ( !Regex.IsMatch( plcPort.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Port Number. Please input valid data." );
                plcPort.SelectAll();
                plcPort.Focus();
                return;
            }

            int tmpPortNumber = Convert.ToInt32( plcPort.Text.Trim() );
            if( 0 == tmpPortNumber )
            {
                MessageBox.Show( "Invalid Port Number. Please input valid data." );
                plcPort.SelectAll();
                plcPort.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [minimum press speed text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMinPressSpeedTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox minPressSpeed = sender as TextBox;
            if( null == minPressSpeed )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( minPressSpeed.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Min Press Speed. Please input valid data." );
                minPressSpeed.SelectAll();
                minPressSpeed.Focus();
                return;
            }

            int tmpMinPressSpeed = Convert.ToInt32( minPressSpeed.Text.Trim() );
            if( ( tmpMinPressSpeed < 0 ) ||
                ( tmpMinPressSpeed > 1000 ) )
            {
                MessageBox.Show( "Invalid Min Press Speed. Valid Range is 0 to 1000." );
                minPressSpeed.SelectAll();
                minPressSpeed.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC >> Ramping >> Press Speed parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [maximum press speed text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnMaxPressSpeedTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox maxPressSpeed = sender as TextBox;
            if( null == maxPressSpeed )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( maxPressSpeed.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Max Press Speed. Please input valid data." );
                maxPressSpeed.SelectAll();
                maxPressSpeed.Focus();
                return;
            }

            int tmpMaxPressSpeed = Convert.ToInt32( maxPressSpeed.Text.Trim() );
            if( ( tmpMaxPressSpeed < 100 ) ||
                ( tmpMaxPressSpeed > 4000 ) )
            {
                MessageBox.Show( "Invalid Max Press Speed. Valid Range is 100 to 4000." );
                maxPressSpeed.SelectAll();
                maxPressSpeed.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [ink master setting text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnInkMasterSettingTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox inkMasterSetting = sender as TextBox;
            if( null == inkMasterSetting )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( inkMasterSetting.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Ink Master Setting. Please input valid data." );
                inkMasterSetting.SelectAll();
                inkMasterSetting.Focus();
                return;
            }

            int tmpInkMasterSetting = Convert.ToInt32( inkMasterSetting.Text.Trim() );
            if( ( tmpInkMasterSetting < 0 ) ||
                ( tmpInkMasterSetting > 100 ) )
            {
                MessageBox.Show( "Invalid Ink Master Setting. Valid Range is 0 to 100." );
                inkMasterSetting.SelectAll();
                inkMasterSetting.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [water master setting text box validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnWaterMasterSettingTextBox_Validating( object sender, CancelEventArgs e )
        {
            TextBox waterMasterSetting = sender as TextBox;
            if( null == waterMasterSetting )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( waterMasterSetting.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Water Master Setting. Please input valid data." );
                waterMasterSetting.SelectAll();
                waterMasterSetting.Focus();
                return;
            }

            int tmpWaterMasterSetting = Convert.ToInt32( waterMasterSetting.Text.Trim() );
            if( ( tmpWaterMasterSetting < 0 ) ||
                ( tmpWaterMasterSetting > 100 ) )
            {
                MessageBox.Show( "Invalid Water Master Setting. Valid Range is 0 to 100." );
                waterMasterSetting.SelectAll();
                waterMasterSetting.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          28-Nov-2018 dlg, (177481) Change units from 10/200 (cm) to 100/2000 (mm)
        ///         
        /// ]]>
        /// <summary>
        /// Called when [impression length of plate validating].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void OnImpressionLengthOfPlateValidating( object sender, CancelEventArgs e )
        {
            TextBox impressionLengthOfPlate = sender as TextBox;
            if( null == impressionLengthOfPlate )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( impressionLengthOfPlate.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Impression Length of Plate. Please input valid data." );
                impressionLengthOfPlate.SelectAll();
                impressionLengthOfPlate.Focus();
                return;
            }

            int tmpImpressionLengthOfPlate = Convert.ToInt32( impressionLengthOfPlate.Text.Trim() );
            if( ( tmpImpressionLengthOfPlate < 100 ) ||
                ( tmpImpressionLengthOfPlate > 2000 ) )
            {
                MessageBox.Show( "Invalid Impression Length of Plate. Valid Range is 100 to 2000." );
                impressionLengthOfPlate.SelectAll();
                impressionLengthOfPlate.Focus();
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Called when [configuration voltages clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnConfigVoltages_Clicked( object sender, EventArgs e )
        {
            bool sweepEnabled = m_sweepOptionCheckBox.Checked;
            bool waterEnabled = m_waterOptionCheckBox.Checked;

            using( MercuryAVTPLCConfigVoltagesForm form = new MercuryAVTPLCConfigVoltagesForm( sweepEnabled, waterEnabled, m_press, m_avtPLCConfig ) )
            {
                form.ShowDialog();
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Created
        /// 		 	18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Called when [inker options button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnInkerOptionsButton_Click( object sender, EventArgs e )
        {
            bool sweepEnabled = m_sweepOptionCheckBox.Checked;
            bool sweepRampEnabled = m_sweepRampOptionCheckBox.Checked;

            using( MercuryAVTPLCInkerOptionsForm form = new MercuryAVTPLCInkerOptionsForm( sweepEnabled, sweepRampEnabled, m_press, m_avtPLCConfig ) )
            {
                form.ShowDialog();
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Created
        /// 		 	18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Called when [water options button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWaterOptionsButton_Click( object sender, EventArgs e )
        {            
            bool waterEnabled = m_waterOptionCheckBox.Checked;
            bool waterRampEnabled = m_waterRampOptionCheckBox.Checked;

            using( MercuryAVTPLCWaterOptionsForm form = new MercuryAVTPLCWaterOptionsForm( waterEnabled, waterRampEnabled, m_press, m_avtPLCConfig ) )
            {
                form.ShowDialog();
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Called when [recall form options button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRecallFormOptionsButton_Click( object sender, EventArgs e )
        {
            bool sweepEnabled = m_sweepOptionCheckBox.Checked;
            bool sweepFunctionEnabled = m_sweepFuncControlOptionCheckBox.Checked;
            bool ductorHoldOffEnabled = m_ductorHoldOffOptionCheckBox.Checked;
            bool waterEnabled = m_waterOptionCheckBox.Checked;
            bool waterFunctionEnabled = m_waterFunControlOptionCheckBox.Checked;

            using( MercuryAVTPLCRecallFormOptions form = new MercuryAVTPLCRecallFormOptions( sweepEnabled, sweepFunctionEnabled, ductorHoldOffEnabled,
                waterEnabled, waterFunctionEnabled, m_press, m_avtPLCConfig, (AVTPLCType) m_plcTypeComboBox.SelectedIndex ) )
            {
                form.ShowDialog();
            }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///
        /// ]]>
        /// <summary>
        /// Determines whether [is PLCC X50 xx selected].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is PLCC X50 xx selected]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsPLCCX50XXSelected()
        {
            return ( AVTPLCType.eAVTPLCBeckhoffCX50xx == ( AVTPLCType )m_plcTypeComboBox.SelectedIndex );
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///
        /// ]]>
        /// <summary>
        /// Determines whether [is PLCC X8190 selected].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is PLCC X8190 selected]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsPLCCX8190Selected()
        {
            return ( AVTPLCType.eAVTPLCBeckhoffCX8190 == ( AVTPLCType )m_plcTypeComboBox.SelectedIndex );
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///
        /// ]]>
        /// <summary>
        /// Enables the voltage configuration.
        /// </summary>
        private void EnableVoltageConfiguration()
        {
            m_configVoltages.Enabled = IsPLCCX50XXSelected();
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///
        /// ]]>
        /// <summary>
        /// Called when [PLC type ComboBox selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPLCTypeComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {            
            LoadSweepConfiguration();
            LoadWaterConfiguration();
            LoadPressSpeedConfiguration();
            LoadPlateInfoConfiguration();
            EnableVoltageConfiguration();
        }
        
        #region members

        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();
        private readonly MC3Column m_rangeIndexColumn = new MC3Column();
        private readonly MC3Column m_rangeValueColumn = new MC3Column();        
        private const int VALUE_COL = 1;
        private bool m_avtPLCSweepControlSelected = false;
        private readonly MCPressInfo m_press = new MCPressInfo();

        #endregion        

    }
}
