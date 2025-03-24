// ***********************************************************************
// Author           : Mark C
// Created          : 2-Dec-2016
//
// ***********************************************************************
// <copyright file="MercuryServerOptions.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class is responsible to store the Mercury Server options configured in the Site XML file.
//	Also, provides the get and set methods to access each Mercury Server option configured in the Site XML file.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCNWSiteGen
{
    public class MercuryServerOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryServerOptions"/> class.
        /// </summary>
        public MercuryServerOptions()
        {
            m_simulationEnabled = false;
            m_cpuAffinityEnabled = false;
            m_noStressOnSPUEnabled = false;
            m_spu3DebugEnabled = false;
            m_fixCOMPortsEnabled = false;
            m_ignoreSPUResponseEnabled = true;
            m_logDataEnabled = true;
            m_logIODataEnabled = true;
        }

        #region implementation

        /// <summary>
        /// Gets or sets a value indicating whether [log data option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [log data option]; otherwise, <c>false</c>.
        /// </value>
        public bool LogDataOption
        {
            get { return m_logDataEnabled; }
            set { m_logDataEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [log io data option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [log io data option]; otherwise, <c>false</c>.
        /// </value>
        public bool LogIODataOption
        {
            get { return m_logIODataEnabled; }
            set { m_logIODataEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [simulation option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [simulation option]; otherwise, <c>false</c>.
        /// </value>
        public bool SimulationOption
        {
            get { return m_simulationEnabled; }
            set { m_simulationEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [cpu affinity option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [cpu affinity option]; otherwise, <c>false</c>.
        /// </value>
        public bool CPUAffinityOption
        {
            get { return m_cpuAffinityEnabled; }
            set { m_cpuAffinityEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [no stress option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [no stress option]; otherwise, <c>false</c>.
        /// </value>
        public bool NoStressOption
        {
            get { return m_noStressOnSPUEnabled; }
            set { m_noStressOnSPUEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [sp u3 debug option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [sp u3 debug option]; otherwise, <c>false</c>.
        /// </value>
        public bool SPU3DebugOption
        {
            get { return m_spu3DebugEnabled; }
            set { m_spu3DebugEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [ignore spu response option].
        /// </summary>
        /// <value>
        /// <c>true</c> if [ignore spu response option]; otherwise, <c>false</c>.
        /// </value>
        public bool IgnoreSPUResponseOption
        {
            get { return m_ignoreSPUResponseEnabled; }
            set { m_ignoreSPUResponseEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [fix COM ports option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fix COM ports option]; otherwise, <c>false</c>.
        /// </value>
        public bool FixCOMPortsOption
        {
            get { return m_fixCOMPortsEnabled; }
            set { m_fixCOMPortsEnabled = value; }
        }

        #endregion


        #region members

        private bool m_simulationEnabled = false;
        private bool m_cpuAffinityEnabled = false;
        private bool m_noStressOnSPUEnabled = false;
        private bool m_spu3DebugEnabled = false;
        private bool m_ignoreSPUResponseEnabled = false;
        private bool m_fixCOMPortsEnabled = false;
        private bool m_logDataEnabled = false;
        private bool m_logIODataEnabled = false;

        #endregion

    }
}
