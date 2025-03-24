// ***********************************************************************
// Author           : Mark C
// Created          : 19-Jul-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCConfig.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

namespace MCNWSiteGen
{
    public enum AVTPLCType
    {
        eAVTPLCBeckhoffCX50xx = 0,
        eAVTPLCBeckhoffCX8190
    }

    public enum DisplayPressSpeedOption
    {
        eFeetsPerMinute = 0,
        eMetersPerMinute,
        eCopiesPerHour
    }

    /// <![CDATA[              
    /// 
    /// Author: 
    /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
    ///         
    /// ]]>
    /// <summary>
    /// AVT PLC configuration data
    /// </summary>
    public class MercuryAVTPLCConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCConfig"/> class.
        /// </summary>
        public MercuryAVTPLCConfig()
        {

        }

        /// <summary>
        /// Gets or sets the PLC IP adrress.
        /// </summary>
        /// <value>
        /// The PLC IP adrress.
        /// </value>
        public string PLCIPAdrress
        {
            get { return m_plcIPAddress; }
            set { m_plcIPAddress = value; }
        }

        /// <summary>
        /// Gets or sets the PLC type.
        /// </summary>
        /// <value>
        /// The PLC type.
        /// </value>
        public AVTPLCType PLCType
        {
            get { return m_plcType; }
            set { m_plcType = value; }
        }

        /// <summary>
        /// Gets or sets the PLC port number.
        /// </summary>
        /// <value>
        /// The PLC port number.
        /// </value>
        public int PLCPortNum
        {
            get { return m_plcPortNum; }
            set { m_plcPortNum = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [sweep enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [sweep enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool SweepEnabled
        {
            get { return m_sweepEnabled; }
            set { m_sweepEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [water enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [water enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool WaterEnabled
        {
            get { return m_waterEnabled; }
            set { m_waterEnabled = value; }
        }

        /// <summary>
        /// Gets the sweep configuration.
        /// </summary>
        /// <value>
        /// The sweep configuration.
        /// </value>
        public MercuryAVTPLCSweepConfig SweepConfig
        {
            get { return m_avtPLCSweepConfig; }
        }

        /// <summary>
        /// Gets the water configuration.
        /// </summary>
        /// <value>
        /// The water configuration.
        /// </value>
        public MercuryAVTPLCWaterConfig WaterConfig
        {
            get { return m_avtPLCWaterConfig; }
        }

        /// <summary>
        /// Gets the press speed configuration.
        /// </summary>
        /// <value>
        /// The press speed configuration.
        /// </value>
        public MercuryAVTPLCPressSpeedConfig PressSpeedConfig
        {
            get { return m_avtPLCPressSpeedConfig; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Plate info config
        ///         
        /// ]]>
        /// <summary>
        /// Gets the plate information configuration.
        /// </summary>
        /// <value>
        /// The plate information configuration.
        /// </value>
        public MercuryAVTPLCPlateInfoConfig PlateInfoConfig
        {
            get { return m_avtPLCPlateInfoConfig; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Press Speed Voltage config
        ///         
        /// ]]>
        /// <summary>
        /// Gets the press speed voltages configuration.
        /// </summary>
        /// <value>
        /// The press speed voltages configuration.
        /// </value>
        public MercuryAVTPLCPressSpeedVoltages PressSpeedVoltagesConfig
        {
            get { return m_avtPLCPressSpeedVoltagesConfig; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 05-Nov-18, Mark C, WI182050: Add support for 'Sync Sweep / Water console values' option
        ///         
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [synchronize sweep water console values].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [synchronize sweep water console values]; otherwise, <c>false</c>.
        /// </value>
        public bool SyncSweepWaterConsoleValues
        {
            get { return m_syncSweepWaterConsoleValues; }
            set { m_syncSweepWaterConsoleValues = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [register enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [register enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool RegisterEnabled
        {
            get { return m_bRegisterEnabled; }
            set { m_bRegisterEnabled = value; }
        }

        /// <summary>
        /// Gets or sets the register configuration
        /// </summary>
        /// <value>
        /// The register config.
        /// </value>
        public MercuryAVTPLCRegisterConfig RegisterConfig
        {
            get { return m_registerConfig; }
            set { m_registerConfig = value; }
        }

        #region Members

        private readonly MercuryAVTPLCSweepConfig m_avtPLCSweepConfig = new MercuryAVTPLCSweepConfig();
        private readonly MercuryAVTPLCWaterConfig m_avtPLCWaterConfig = new MercuryAVTPLCWaterConfig();
        private readonly MercuryAVTPLCPressSpeedConfig m_avtPLCPressSpeedConfig = new MercuryAVTPLCPressSpeedConfig();
        private readonly MercuryAVTPLCPlateInfoConfig m_avtPLCPlateInfoConfig = new MercuryAVTPLCPlateInfoConfig();
        private readonly MercuryAVTPLCPressSpeedVoltages m_avtPLCPressSpeedVoltagesConfig = new MercuryAVTPLCPressSpeedVoltages();
        private bool m_sweepEnabled = false;
        private bool m_waterEnabled = false;
        private AVTPLCType m_plcType = AVTPLCType.eAVTPLCBeckhoffCX50xx;
        private string m_plcIPAddress = "172.31.1.91";
        private int m_plcPortNum = 502;
        private bool m_syncSweepWaterConsoleValues = true;
        private bool m_bRegisterEnabled = false;
        private MercuryAVTPLCRegisterConfig m_registerConfig = new MercuryAVTPLCRegisterConfig();

        #endregion
    }

    public class MercuryAVTPLCPressSpeedConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCPressSpeedConfig" /> class.
        /// </summary>
        public MercuryAVTPLCPressSpeedConfig()
        {
        }

        /// <summary>
        /// Gets or sets the minimum press speed.
        /// </summary>
        /// <value>
        /// The minimum press speed.
        /// </value>
        public int MinPressSpeed
        {
            get { return m_minPressSpeed; }
            set { m_minPressSpeed = value; }
        }

        /// <summary>
        /// Gets or sets the maximum press speed.
        /// </summary>
        /// <value>
        /// The maximum press speed.
        /// </value>
        public int MaxPressSpeed
        {
            get { return m_maxPressSpeed; }
            set { m_maxPressSpeed = value; }
        }

        /// <summary>
        /// Gets or sets the display press speed option.
        /// </summary>
        /// <value>
        /// The display press speed option.
        /// </value>
        public DisplayPressSpeedOption DisplayPressSpeedOption
        {
            get { return m_displayPressSpeed; }
            set { m_displayPressSpeed = value; }
        }

        #region Members

        private int m_minPressSpeed = 0;
        private int m_maxPressSpeed = 1000;
        private DisplayPressSpeedOption m_displayPressSpeed = DisplayPressSpeedOption.eFeetsPerMinute;

        #endregion
    }

    /// <summary>
    /// WI128160 - Plate Info config class
    /// </summary>
    public class MercuryAVTPLCPlateInfoConfig
    {
        public MercuryAVTPLCPlateInfoConfig()
        {
        }

        /// <summary>
        /// Gets or sets the impression length of plate.
        /// </summary>
        /// <value>
        /// The impression length of plate.
        /// </value>
        public int ImpressionLengthOfPlate
        {
            get { return m_impressionLengthOfPlate; }
            set { m_impressionLengthOfPlate = value; }
        }

        /// <summary>
        /// Gets or sets the number of plates in fountain.
        /// </summary>
        /// <value>
        /// The number of plates in fountain.
        /// </value>
        public int NumOfPlatesInFountain
        {
            get { return m_numOfPlatesInFountain; }
            set { m_numOfPlatesInFountain = value; }
        }

        #region Members

        private int m_impressionLengthOfPlate = 62; // Centimeters
        private int m_numOfPlatesInFountain = 1;    // Number of plates in Fountain

        #endregion
    }
}
