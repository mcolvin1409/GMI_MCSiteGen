// ***********************************************************************
// Author           : Mark C
// Created          : 27-Sep-17
//
// ***********************************************************************
// <copyright file="MercuryAVTPLCVoltagesConfig.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace MCNWSiteGen
{
    /// <summary>
    /// AVT PLC Inker Voltages Config class
    /// </summary>
    public class MercuryAVTPLCInkerConfigVoltages
    {
        public MercuryAVTPLCInkerConfigVoltages()
        {
        }

        /// <summary>
        /// Gets the sweep input voltages.
        /// </summary>
        /// <value>
        /// The sweep input voltages.
        /// </value>
        public MercuryAVTPLCSweepInputVoltages SweepInputVoltages
        {
            get { return m_sweepInputVoltages; }
        }

        /// <summary>
        /// Gets the water output voltages.
        /// </summary>
        /// <value>
        /// The water output voltages.
        /// </value>
        public MercuryAVTPLCWaterOutputVoltages WaterOutputVoltages
        {
            get { return m_waterOutputVoltages; }
        }

        #region Members

        private readonly MercuryAVTPLCSweepInputVoltages m_sweepInputVoltages = new MercuryAVTPLCSweepInputVoltages();
        private readonly MercuryAVTPLCWaterOutputVoltages m_waterOutputVoltages = new MercuryAVTPLCWaterOutputVoltages();

        #endregion
    }

    /// <summary>
    /// AVT PLC Press Speed Voltages 
    /// </summary>
    public class MercuryAVTPLCPressSpeedVoltages
    {
        public MercuryAVTPLCPressSpeedVoltages()
        {
        }

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public float MinValue
        {
            get { return m_minValue; }
            set { m_minValue = value; }
        }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public float MaxValue
        {
            get { return m_maxValue; }
            set { m_maxValue = value; }
        }

        #region Members

        private float m_minValue = 0.0f;
        private float m_maxValue = 10.0f;

        #endregion
    }

    /// <summary>
    /// AVT PLC Sweep Input Voltages 
    /// </summary>
    public class MercuryAVTPLCSweepInputVoltages
    {
        public MercuryAVTPLCSweepInputVoltages()
        {
        }

        public float MinValue
        {
            get { return m_inputMin; }
            set { m_inputMin = value; }
        }

        public float MaxValue
        {
            get { return m_inputMax; }
            set { m_inputMax = value; }
        }

        #region Members

        private float m_inputMin = 0.0f;
        private float m_inputMax = 10.0f;

        #endregion
    }

    /// <summary>
    /// AVT PLC Water Output Voltages 
    /// </summary>
    public class MercuryAVTPLCWaterOutputVoltages
    {
        public MercuryAVTPLCWaterOutputVoltages()
        {
        }

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public float MinValue
        {
            get { return m_outPutMin; }
            set { m_outPutMin = value; }
        }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public float MaxValue
        {
            get { return m_outPutMax; }
            set { m_outPutMax = value; }
        }

        #region Members

        private float m_outPutMin = 0.0f;
        private float m_outPutMax = 10.0f;

        #endregion
    }
}
