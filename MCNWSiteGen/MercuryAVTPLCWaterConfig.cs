// ***********************************************************************
// Author           : Mark C
// Created          : 19-Jul-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCWaterConfig.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

namespace MCNWSiteGen
{
    /// <summary>
    /// MethodOfFlood
    /// </summary>
    public enum MethodOfFlood
    {
        /// <summary>
        /// The trim settings changed
        /// </summary>
        TrimSettingsChanged = 0,
        /// <summary>
        /// The flood device activated
        /// </summary>
        FloodDeviceActivated,
        /// <summary>
        /// The trim setting and device changed
        /// </summary>
        TrimSettingAndDeviceChanged
    }

    /// <summary>
    /// FloodDevice
    /// </summary>
    public enum FloodDevice
    {
        /// <summary>
        /// The PLC flood output
        /// </summary>
        PLCFloodOutput = 0,
        /// <summary>
        /// The spu3 device attached to water port
        /// </summary>
        SPU3DeviceAttachedToWaterPort,
        /// <summary>
        /// The spu2 device attached to water port
        /// </summary>
        SPU2DeviceAttachedToWaterPort
    }

    /// <summary>
    /// MercuryAVTPLCWaterConfig_Flood
    /// </summary>
    public class MercuryAVTPLCWaterConfig_Flood
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCWaterConfig_Flood"/> class.
        /// </summary>
        public MercuryAVTPLCWaterConfig_Flood()
        {
        }

        /// <summary>
        /// Gets or sets the default on time.
        /// </summary>
        /// <value>
        /// The default on time.
        /// </value>
        public int DefaultONTime
        {
            set { m_defaultONTime = value; }
            get { return m_defaultONTime; }
        }

        /// <summary>
        /// Gets or sets the maximum on time.
        /// </summary>
        /// <value>
        /// The maximum on time.
        /// </value>
        public int MaxONTime
        {
            set { m_maxONTime = value; }
            get { return m_maxONTime; }
        }

        /// <summary>
        /// Gets or sets the flood trim.
        /// </summary>
        /// <value>
        /// The flood trim.
        /// </value>
        public int FloodTrim
        {
            set { m_floodTrim = value; }
            get { return m_floodTrim; }
        }

        /// <summary>
        /// Gets or sets the flood method.
        /// </summary>
        /// <value>
        /// The flood method.
        /// </value>
        public MethodOfFlood FloodMethod
        {
            set { m_floodMethod = value; }
            get { return m_floodMethod; }
        }

        /// <summary>
        /// Gets or sets the flood device.
        /// </summary>
        /// <value>
        /// The flood device.
        /// </value>
        public FloodDevice FloodDevice
        {
            set { m_floodDevice = value; }
            get { return m_floodDevice; }
        }

        #region members
        
        private int m_defaultONTime = 3;    // seconds
        private int m_maxONTime = 60;       // seconds
        private int m_floodTrim = 99;       // percentage, this parameter is not configurable now
        private MethodOfFlood m_floodMethod = MethodOfFlood.TrimSettingsChanged;
        private FloodDevice m_floodDevice = FloodDevice.PLCFloodOutput;

        #endregion
    }

    /// <summary>
    /// MercuryAVTPLCWaterConfig_Ramping
    /// </summary>
    public class MercuryAVTPLCWaterConfig_Ramping
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCWaterConfig_Ramping"/> class.
        /// </summary>
        public MercuryAVTPLCWaterConfig_Ramping()
        {
        }

        /// <summary>
        /// Gets or sets the trim influence.
        /// </summary>
        /// <value>
        /// The trim influence.
        /// </value>
        public int TrimInfluence
        {
            get { return m_trimInfluence; }
            set { m_trimInfluence = value; }
        }

        /// <summary>
        /// Gets or sets the master influence.
        /// </summary>
        /// <value>
        /// The master influence.
        /// </value>
        public int MasterInfluence
        {
            get { return m_masterInfluence; }
            set { m_masterInfluence = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [master water control enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [master water control enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool MasterWaterControlEnabled
        {
            get { return m_masterWaterControl; }
            set { m_masterWaterControl = value; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///         
        /// ]]>
        /// <summary>
        /// Gets or sets the water master setting.
        /// </summary>
        /// <value>
        /// The water master setting.
        /// </value>
        public int WaterMasterSetting
        {
            get { return m_waterMasterSetting; }
            set { m_waterMasterSetting = value; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets or sets the speed influence.
        /// </summary>
        /// <value>
        /// The speed influence.
        /// </value>
        public int SpeedInfluence
        {
            get { return m_speedInfluence; }
            set { m_speedInfluence = value; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets or sets the base curve maximum.
        /// </summary>
        /// <value>
        /// The base curve maximum.
        /// </value>
        public int BaseCurveMax
        {
            get { return m_baseCurveMax; }
            set { m_baseCurveMax = value; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets or sets the motor clamp minimum.
        /// </summary>
        /// <value>
        /// The motor clamp minimum.
        /// </value>
        public int MotorClampMin
        {
            get { return m_motorClampMin; }
            set { m_motorClampMin = value; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets or sets the motor clamp maximum.
        /// </summary>
        /// <value>
        /// The motor clamp maximum.
        /// </value>
        public int MotorClampMax
        {
            get { return m_motorClampMax; }
            set { m_motorClampMax = value; }
        }

        #region members

        private int m_trimInfluence = 10;  //Percentage
        private bool m_masterWaterControl = false;       
        private int m_masterInfluence = 10;  // Percentage
        private int m_waterMasterSetting = 10; // Percentage
        private int m_speedInfluence = 100;    //percentage 
        private int m_baseCurveMax = 85;    //percentage 
        private int m_motorClampMin = 20;    //percentage 
        private int m_motorClampMax = 100;    //percentage 

        #endregion
    }

    /// <![CDATA[              
    /// 
    /// Author: Mark C
    /// History: 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
    ///         
    /// ]]>
    /// <summary>
    /// MercuryAVTPLCWaterConfig_FunctionControl
    /// </summary>
    public class MercuryAVTPLCWaterConfig_FunctionControl
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="MercuryAVTPLCWaterConfig_FunctionControl"/> class from being created.
        /// </summary>
        public MercuryAVTPLCWaterConfig_FunctionControl()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether [water function control enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [water function control enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool WaterFuncControlEnabled
        {
            get { return m_waterFuncControlEnabled; }
            set { m_waterFuncControlEnabled = value; }
        }

        /// <summary>
        /// Gets or sets the trim setting manual.
        /// </summary>
        /// <value>
        /// The trim setting manual.
        /// </value>
        public int TrimSettingManual
        {
            get { return m_trimSettingManual; }
            set { m_trimSettingManual = value; }
        }

        #region members

        private bool m_waterFuncControlEnabled = false;
        private int m_trimSettingManual = 99; // Percentage, this parameter is not configurable now

        #endregion
    }

    /// <summary>
    /// 21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
    /// </summary>
    public class MercuryAVTPLCWater_WaterAdjustmentOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCWater_WaterAdjustmentOptions"/> class.
        /// </summary>
        public MercuryAVTPLCWater_WaterAdjustmentOptions()
        {
        }

        /// <summary>
        /// Gets or sets the type of the hardware interface.
        /// </summary>
        /// <value>
        /// The type of the hardware interface.
        /// </value>
        public WaterHardwareInterfaceType HardwareInterfaceType
        {
            get { return m_hardwareInterfaceType; }
            set { m_hardwareInterfaceType = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable digital control cancel].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable digital control cancel]; otherwise, <c>false</c>.
        /// </value>
        public bool EnableDigitalControlCancel
        {
            get { return m_enableDigitalControlCancel; }
            set { m_enableDigitalControlCancel = value; }
        }

        #region Members

        private WaterHardwareInterfaceType m_hardwareInterfaceType = WaterHardwareInterfaceType.DigitalControlsWithPotFeedback;
        private bool m_enableDigitalControlCancel = false;

        #endregion
    }

    /// <summary>
    /// 18-Feb-18, Mark C, WI149990: Add support for new Ramp curve parameters
    /// </summary>
    public class MercuryAVTPLCWater_RecallFormOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCWater_RecallFormOptions"/> class.
        /// </summary>
        public MercuryAVTPLCWater_RecallFormOptions()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether [trim parameter selected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [trim parameter selected]; otherwise, <c>false</c>.
        /// </value>
        public bool TrimParamSelected
        {
            get { return m_trimParamSelected; }
            set { m_trimParamSelected = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [function parameter selected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [function parameter selected]; otherwise, <c>false</c>.
        /// </value>
        public bool FunctionParamSelected
        {
            get { return m_functionParamSelected; }
            set { m_functionParamSelected = value; }
        }

        #region Members

        private bool m_trimParamSelected = false;
        private bool m_functionParamSelected = false;

        #endregion
    }

    /// <summary>
    /// MercuryAVTPLCWaterConfig
    /// </summary>
    public class MercuryAVTPLCWaterConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCWaterConfig"/> class.
        /// </summary>
        public MercuryAVTPLCWaterConfig()
        {
        }

        /// <summary>
        /// Gets the flood.
        /// </summary>
        /// <value>
        /// The flood.
        /// </value>
        public MercuryAVTPLCWaterConfig_Flood Flood
        {
            get { return m_floodConfig; }
        }

        /// <summary>
        /// Gets the ramping.
        /// </summary>
        /// <value>
        /// The ramping.
        /// </value>
        public MercuryAVTPLCWaterConfig_Ramping Ramping
        {
            get { return m_rampingConfig; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///         
        /// ]]>
        /// <summary>
        /// Gets the function control.
        /// </summary>
        /// <value>
        /// The function control.
        /// </value>
        public MercuryAVTPLCWaterConfig_FunctionControl FunctionControl
        {
            get { return m_functionControl; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [flood enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [flood enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool FloodEnabled
        {
            get { return m_floodEnabled; }
            set { m_floodEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [ramping enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ramping enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool RampingEnabled
        {
            get { return m_rampingEnabled; }
            set { m_rampingEnabled = value; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets the water options.
        /// </summary>
        /// <value>
        /// The water options.
        /// </value>
        public MercuryAVTPLCWater_WaterAdjustmentOptions WaterOptions
        {
            get { return m_waterOptions; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets the recall form options.
        /// </summary>
        /// <value>
        /// The recall form options.
        /// </value>
        public MercuryAVTPLCWater_RecallFormOptions RecallFormOptions
        {
            get { return m_waterRecallOptions; }
        }

        #region members

        private readonly MercuryAVTPLCWaterConfig_Flood m_floodConfig = new MercuryAVTPLCWaterConfig_Flood();
        private readonly MercuryAVTPLCWaterConfig_Ramping m_rampingConfig = new MercuryAVTPLCWaterConfig_Ramping();
        private readonly MercuryAVTPLCWaterConfig_FunctionControl m_functionControl = new MercuryAVTPLCWaterConfig_FunctionControl();
        private readonly MercuryAVTPLCWater_WaterAdjustmentOptions m_waterOptions = new MercuryAVTPLCWater_WaterAdjustmentOptions();
        private readonly MercuryAVTPLCWater_RecallFormOptions m_waterRecallOptions = new MercuryAVTPLCWater_RecallFormOptions();
        private bool m_floodEnabled = false;
        private bool m_rampingEnabled = false;

        #endregion
    }
}
