// ***********************************************************************
// Author           : Mark C
// Created          : 19-Jul-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCSweepConfig.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

using System.Collections.Generic;

namespace MCNWSiteGen
{
    /// <summary>
    /// MethodOfSurge
    /// </summary>
    public enum MethodOfSurge
    {
        /// <summary>
        /// The trim settings changed
        /// </summary>
        TrimSettingsChanged = 0,
        /// <summary>
        /// The surge device activated
        /// </summary>
        SurgeDeviceActivated,
        /// <summary>
        /// The trim setting and device changed
        /// </summary>
        TrimSettingAndDeviceChanged
    }

    /// <summary>
    /// SurgeDevice
    /// </summary>
    public enum SurgeDevice
    {
        /// <summary>
        /// The PLC surge output
        /// </summary>
        PLCSurgeOutput = 0,
        /// <summary>
        /// The spu3 device attached to sweep port
        /// </summary>
        SPU3DeviceAttachedToSweepPort,
        /// <summary>
        /// The spu2 device attached to sweep port
        /// </summary>
        SPU2DeviceAttachedToSweepPort
    }

    /// <summary>
    /// 21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
    /// </summary>
    public enum InkerHardwareInterfaceType
    {
        DigitalControlsOnly = 0,
        DigitalControlsWithPotFeedback = 1,
        AnalogOutput = 2
    }

    /// <summary>
    /// 21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
    /// </summary>
    public enum WaterHardwareInterfaceType
    {
        DigitalControlsOnly = 0,
        DigitalControlsWithPotFeedback = 1,
        AnalogOutput = 2
    }

    /// <summary>
    /// MercuryAVTPLCSweep_InkSurgeConfig
    /// </summary>
    public class MercuryAVTPLCSweep_InkSurgeConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_InkSurgeConfig"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_InkSurgeConfig()
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
            get { return m_defaultONTime; }
            set { m_defaultONTime = value; }
        }

        /// <summary>
        /// Gets or sets the maximum on time.
        /// </summary>
        /// <value>
        /// The maximum on time.
        /// </value>
        public int MaxONTime
        {
            get { return m_maxONTime; }
            set { m_maxONTime = value; }
        }

        /// <summary>
        /// Gets or sets the surge trim.
        /// </summary>
        /// <value>
        /// The surge trim.
        /// </value>
        public int SurgeTrim
        {
            get { return m_surgeTrim; }
            set { m_surgeTrim = value; }
        }

        /// <summary>
        /// Gets or sets the surge method.
        /// </summary>
        /// <value>
        /// The surge method.
        /// </value>
        public MethodOfSurge SurgeMethod
        {
            get { return m_surgeMethod; }
            set { m_surgeMethod = value; }
        }

        /// <summary>
        /// Gets or sets the surge device.
        /// </summary>
        /// <value>
        /// The surge device.
        /// </value>
        public SurgeDevice SurgeDevice
        {
            get { return m_surgeDevice; }
            set { m_surgeDevice = value; }
        }

        #region Members
        
        private int m_defaultONTime = 3;    //seconds
        private int m_maxONTime = 60;       //seconds
        private int m_surgeTrim = 99;       //percentage, this parameter is not configurable now
        private MethodOfSurge m_surgeMethod = MethodOfSurge.TrimSettingsChanged;
        private SurgeDevice m_surgeDevice = SurgeDevice.PLCSurgeOutput;

        #endregion
    }

    /// <summary>
    /// MercuryAVTPLCSweep_Ramping
    /// </summary>
    public class MercuryAVTPLCSweep_Ramping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_Ramping"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_Ramping()
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
        /// Gets or sets a value indicating whether [master sweep control enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [master sweep control enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool MasterSweepControlEnabled
        {
            get { return m_masterSweepControlEnabled; }
            set { m_masterSweepControlEnabled = value; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Remove obsolete parameters of Ductor holdoff
        ///         
        /// ]]>
        /// <summary>
        /// Gets or sets the ink master setting.
        /// </summary>
        /// <value>
        /// The ink master setting.
        /// </value>
        public int InkMasterSetting
        {
            get { return m_inkMasterSetting; }
            set { m_inkMasterSetting = value; }
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

        #region Members

        private int m_trimInfluence = 10;      //percentage
        private bool m_masterSweepControlEnabled = false;
        private int m_masterInfluence = 10;    //percentage
        private int m_inkMasterSetting = 10;   //percentage 
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
    /// MercuryAVTPLCSweep_FunctionControl
    /// </summary>
    public class MercuryAVTPLCSweep_FunctionControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_FunctionControl"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_FunctionControl()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether [sweep function control enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [sweep function control enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool SweepFuncControlEnabled
        {
            get { return m_sweepFuncControlEnabled; }
            set { m_sweepFuncControlEnabled = value; }
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

        #region Members

        private bool m_sweepFuncControlEnabled = false;
        private int m_trimSettingManual = 99;   //percentage, this parameter is not configurable now

        #endregion
    }

    /// <summary>
    /// MercuryAVTPLCSweep_DuctorHoldOffRange
    /// </summary>
    public class MercuryAVTPLCSweep_DuctorHoldOffRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_DuctorHoldOffRange"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_DuctorHoldOffRange()
        {
        }

        /// <summary>
        /// Gets or sets the index of the range.
        /// </summary>
        /// <value>
        /// The index of the range.
        /// </value>
        public int RangeIndex
        {
            get { return m_rangeIndex; }
            set { m_rangeIndex = value; }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public int Value
        {
            get { return m_value; }
            set { m_value = value; }
        }

        #region members

        private int m_rangeIndex = 0;
        private int m_value = 0;

        #endregion
    }


    /// <summary>
    /// MercuryAVTPLCSweep_DuctorHoldOff
    /// </summary>
    public class MercuryAVTPLCSweep_DuctorHoldOff
    {
        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Remove obsolete parameters of Ductor holdoff
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_DuctorHoldOff"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_DuctorHoldOff()
        {
            RangeList.Add( new MercuryAVTPLCSweep_DuctorHoldOffRange { RangeIndex = 0, Value = 0 } );
            RangeList.Add( new MercuryAVTPLCSweep_DuctorHoldOffRange { RangeIndex = 1, Value = 33 } );
            RangeList.Add( new MercuryAVTPLCSweep_DuctorHoldOffRange { RangeIndex = 2, Value = 50 } );
            RangeList.Add( new MercuryAVTPLCSweep_DuctorHoldOffRange { RangeIndex = 3, Value = 100 } );
        }

        /// <summary>
        /// Gets the range list.
        /// </summary>
        /// <value>
        /// The range list.
        /// </value>
        public List<MercuryAVTPLCSweep_DuctorHoldOffRange> RangeList
        {
            get { return m_rangeList; }
        }

        /// <summary>
        /// Gets or sets the number of ranges.
        /// </summary>
        /// <value>
        /// The number of ranges.
        /// </value>
        public int NumOfRanges
        {
            get { return m_numOfRanges; }
            set { m_numOfRanges = value; }
        }

        #region Members

        private int m_numOfRanges = 4;
        private List<MercuryAVTPLCSweep_DuctorHoldOffRange> m_rangeList = new List<MercuryAVTPLCSweep_DuctorHoldOffRange>();

        #endregion
    }

    /// <summary>
    /// 21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
    /// </summary>
    public class MercuryAVTPLCSweep_InkerAdjustmentOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_InkerAdjustmentOptions"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_InkerAdjustmentOptions()
        {
        }

        /// <summary>
        /// Gets or sets the type of the hardware interface.
        /// </summary>
        /// <value>
        /// The type of the hardware interface.
        /// </value>
        public InkerHardwareInterfaceType HardwareInterfaceType
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

        private InkerHardwareInterfaceType m_hardwareInterfaceType = InkerHardwareInterfaceType.DigitalControlsWithPotFeedback;
        private bool m_enableDigitalControlCancel = false; 

        #endregion 
    }

    /// <summary>
    /// 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
    /// </summary>
    public class MercuryAVTPLCSweep_RecallFormOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweep_RecallFormOptions"/> class.
        /// </summary>
        public MercuryAVTPLCSweep_RecallFormOptions()
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

        /// <summary>
        /// Gets or sets a value indicating whether [ductor holdoff parameter selected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ductor holdoff parameter selected]; otherwise, <c>false</c>.
        /// </value>
        public bool DuctorHoldoffParamSelected
        {
            get { return m_ductorHoldOffParamSelected; }
            set { m_ductorHoldOffParamSelected = value; }
        }
        
        #region Members

        private bool m_trimParamSelected = false;
        private bool m_functionParamSelected = false;
        private bool m_ductorHoldOffParamSelected = false;

        #endregion
    }

    /// <summary>
    /// MercuryAVTPLCSweepConfig
    /// </summary>
    public class MercuryAVTPLCSweepConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCSweepConfig"/> class.
        /// </summary>
        public MercuryAVTPLCSweepConfig()
        {

        }

        /// <summary>
        /// Gets or sets a value indicating whether [surge enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [surge enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool SurgeEnabled
        {
            get { return m_surgeEnabled; }
            set { m_surgeEnabled = value; }
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

        /// <summary>
        /// Gets or sets a value indicating whether [ductor hold off enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ductor hold off enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool DuctorHoldOffEnabled
        {
            get { return m_ductorHoldOffEnabled; }
            set { m_ductorHoldOffEnabled = value; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Remove obsolete parameters of Ductor holdoff
        ///         
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [inker washup enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [inker washup enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool InkerWashupEnabled
        {
            get { return m_inkerWashupEnabled; }
            set { m_inkerWashupEnabled = value; }
        }

        /// <summary>
        /// Gets the ink surge.
        /// </summary>
        /// <value>
        /// The ink surge.
        /// </value>
        public MercuryAVTPLCSweep_InkSurgeConfig InkSurge
        {
            get { return m_inkSurgeConfig; }
        }

        /// <summary>
        /// Gets the ramping.
        /// </summary>
        /// <value>
        /// The ramping.
        /// </value>
        public MercuryAVTPLCSweep_Ramping Ramping
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
        public MercuryAVTPLCSweep_FunctionControl FunctionControl
        {
            get { return m_functionControl; }
        }

        /// <summary>
        /// Gets the ductor hold off.
        /// </summary>
        /// <value>
        /// The ductor hold off.
        /// </value>
        public MercuryAVTPLCSweep_DuctorHoldOff DuctorHoldOff
        {
            get { return m_ductorHoldOff; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters
        ///
        /// ]]>
        /// <summary>
        /// Gets the inker options.
        /// </summary>
        /// <value>
        /// The inker options.
        /// </value>
        public MercuryAVTPLCSweep_InkerAdjustmentOptions InkerOptions
        {
            get { return m_inkerOptions; }
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Gets the recall form options.
        /// </summary>
        /// <value>
        /// The recall form options.
        /// </value>
        public MercuryAVTPLCSweep_RecallFormOptions RecallFormOptions
        {
            get { return m_recallFormOptions; }
        }

        #region Members

        private readonly MercuryAVTPLCSweep_InkSurgeConfig m_inkSurgeConfig = new MercuryAVTPLCSweep_InkSurgeConfig();
        private readonly MercuryAVTPLCSweep_Ramping m_rampingConfig = new MercuryAVTPLCSweep_Ramping();
        private readonly MercuryAVTPLCSweep_DuctorHoldOff m_ductorHoldOff = new MercuryAVTPLCSweep_DuctorHoldOff();
        private readonly MercuryAVTPLCSweep_FunctionControl m_functionControl = new MercuryAVTPLCSweep_FunctionControl();
        private readonly MercuryAVTPLCSweep_InkerAdjustmentOptions m_inkerOptions = new MercuryAVTPLCSweep_InkerAdjustmentOptions();
        private readonly MercuryAVTPLCSweep_RecallFormOptions m_recallFormOptions = new MercuryAVTPLCSweep_RecallFormOptions();
        private bool m_surgeEnabled = false;
        private bool m_rampingEnabled = false;
        private bool m_ductorHoldOffEnabled = false;
        private bool m_inkerWashupEnabled = false;

        #endregion
    }
}
