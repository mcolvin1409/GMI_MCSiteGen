// ***********************************************************************
// Author           : Don Gerber
// Created          : 15-Oct-2018
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCRegisterConfig.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCNWSiteGen
{
    /// <summary>
    /// Register motor limit switch options
    /// </summary>
    public enum eMOTOR_LIMIT_SWITCHES
    {
        /// <summary>
        /// Motor has no limit switches
        /// </summary>
        eMotorLimitsNone = 0,
        /// <summary>
        /// Motor has one (1) limit switch
        /// </summary>
        eMotorLimitsOne,
        /// <summary>
        /// Motor has two (2) limit switches
        /// </summary>
        eMotorLimitsTwo
    }

    /// <![CDATA[              
    /// 
    /// Author: Don Gerber
    /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
    ///         
    /// ]]>
    /// <summary>
    /// AVT PLC Register Motor configuration data
    /// </summary>
    public class MercuryAVTPLCRegisterMotorConfig
    {
        #region Properties


        /// <summary>
        /// Gets or sets the motor max travel.
        /// </summary>
        /// <value>
        /// The max travel.
        /// </value>
        public float MaxTravel
        {
            get { return m_fMaxTravel; }
            set { m_fMaxTravel = value; }
        }

        /// <summary>
        /// Gets or sets the motor slope.
        /// </summary>
        /// <value>
        /// The slope.
        /// </value>
        public int Slope
        {
            get { return m_iSlope; }
            set { m_iSlope = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the motor has pot feedback.
        /// </summary>
        /// <value>
        ///   <c>true</c> if potfeed back is supported; otherwise, <c>false</c>.
        /// </value>
        public bool PotFeedBack
        {
            get { return m_bPotFeedback; }
            set { m_bPotFeedback = value; }
        }

        /// <summary>
        /// Gets or sets the motor pot feedback min.
        /// </summary>
        /// <value>
        /// The pot feedback min.
        /// </value>
        public float PotFeedbackMin
        {
            get { return m_fPotFeedbackMin; }
            set { m_fPotFeedbackMin = value; }
        }

        /// <summary>
        /// Gets or sets the motor pot feedback max.
        /// </summary>
        /// <value>
        /// The pot feedback max.
        /// </value>
        public float PotFeedbackMax
        {
            get { return m_fPotFeedbackMax; }
            set { m_fPotFeedbackMax = value; }
        }

        /// <summary>
        /// Gets or sets the motor limit switch support.
        /// </summary>
        /// <value>
        /// The limit switches.
        /// </value>
        public eMOTOR_LIMIT_SWITCHES LimitSwitches
        {
            get { return m_eLimitSwitches; }
            set { m_eLimitSwitches = value; }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 29-May-19, Mark C, WI188815: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [block motor when press stopped].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [block motor when press stopped]; otherwise, <c>false</c>.
        /// </value>
        public bool BlockMotorWhenPressStopped
        {
            get { return m_bBlockMotorWhenPressStopped; }
            set { m_bBlockMotorWhenPressStopped = value; }
        }
        
        #endregion

        #region Implementation

        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCRegisterMotorConfig"/> class.
        /// </summary>
        public MercuryAVTPLCRegisterMotorConfig()
        {
        }

        #endregion

        #region Members

        private float m_fMaxTravel = DefineAndConst.SystemCapacities.REGISTER_MOTOR_MAX_TRAVEL;
        private eMOTOR_LIMIT_SWITCHES m_eLimitSwitches = eMOTOR_LIMIT_SWITCHES.eMotorLimitsNone;
        private int m_iSlope = DefineAndConst.SystemCapacities.REGISTER_SLOPE_MIN;
        private bool m_bPotFeedback = false;
        private float m_fPotFeedbackMin = DefineAndConst.SystemCapacities.REGISTER_POT_FEEDBACK_MIN;
        private float m_fPotFeedbackMax = DefineAndConst.SystemCapacities.REGISTER_POT_FEEDBACK_MAX;
        private bool m_bBlockMotorWhenPressStopped = false;

        #endregion
    }

    /// <![CDATA[              
    /// 
    /// Author: Don Gerber
    /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
    ///         
    /// ]]>
    /// <summary>
    /// AVT PLC Register Inker configuration data
    /// </summary>
    public class MercuryAVTPLCRegisterInkerConfig
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether skew is supported.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [skew motor] is supported; otherwise, <c>false</c>.
        /// </value>
        public bool SkewEnabled
        {
            get { return m_bSkew; }
            set { m_bSkew = value; }
        }

        /// <summary>
        /// Gets or sets the lateral motor.
        /// </summary>
        /// <value>
        /// The lateral motor.
        /// </value>
        public MercuryAVTPLCRegisterMotorConfig LateralMotor
        {
            get { return m_motorLateral; }
            set { m_motorLateral = value; }
        }

        /// <summary>
        /// Gets or sets the circ motor.
        /// </summary>
        /// <value>
        /// The circ motor.
        /// </value>
        public MercuryAVTPLCRegisterMotorConfig CircMotor
        {
            get { return m_motorCirc; }
            set { m_motorCirc = value; }
        }

        /// <summary>
        /// Gets or sets the skew motor.
        /// </summary>
        /// <value>
        /// The skew motor.
        /// </value>
        public MercuryAVTPLCRegisterMotorConfig SkewMotor
        {
            get { return m_motorSkew; }
            set { m_motorSkew = value; }
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCRegisterInkerConfig"/> class.
        /// </summary>
        public MercuryAVTPLCRegisterInkerConfig()
        {
        }

        #endregion

        #region Members

        private MercuryAVTPLCRegisterMotorConfig m_motorLateral = new MercuryAVTPLCRegisterMotorConfig();
        private MercuryAVTPLCRegisterMotorConfig m_motorCirc = new MercuryAVTPLCRegisterMotorConfig();
        private bool m_bSkew = false;
        private MercuryAVTPLCRegisterMotorConfig m_motorSkew = new MercuryAVTPLCRegisterMotorConfig();

        #endregion
    }

    /// <![CDATA[              
    /// 
    /// Author: Don Gerber
    /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
    ///         
    /// ]]>
    /// <summary>
    /// AVT PLC Register configuration data
    /// </summary>
    public class MercuryAVTPLCRegisterConfig
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether [operator on left].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [operator on left]; otherwise, <c>false</c>.
        /// </value>
        public bool OperatorOnLeft
        {
            get { return m_bOperatorOnLeft; }
            set { m_bOperatorOnLeft = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [advance on top].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [advance on top]; otherwise, <c>false</c>.
        /// </value>
        public bool AdvanceOnTop
        {
            get { return m_bAdvanceOnTop; }
            set { m_bAdvanceOnTop = value; }
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryAVTPLCRegisterConfig"/> class.
        /// </summary>
        public MercuryAVTPLCRegisterConfig()
        {
        }

        #endregion

        #region Members

        private bool m_bOperatorOnLeft = true;
        private bool m_bAdvanceOnTop = true;

        #endregion

    }
}
