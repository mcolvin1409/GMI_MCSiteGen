// ***********************************************************************
// Author           : Mark C
// Created          : 26-Sept-2018
//
// ***********************************************************************
// <copyright file="MercuryGUIOptions.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class is responsible for storing the Mercury GUI options.
//	Also, provides the get and set methods to access each Mercury GUI option.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCNWSiteGen
{
    /// <![CDATA[              
    /// 
    /// Author:     Mark C
    /// History:    17-Dec-2018 dlg, (183514) Add auto run delay time
    ///         
    /// ]]>
    /// <summary>
    /// Mercury GUI Options
    /// </summary>
    public class MercuryGUIOptions
    {
        /// <![CDATA[              
        /// 
        /// Author:     Mark C
        /// History:    17-Dec-2018 dlg, (183514) Add auto run delay time
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MercuryGUIOptions" /> class.
        /// </summary>
        public MercuryGUIOptions()
        {
            m_removalOfRunButtonEnabled = false;
            m_invertPresetProfileEnabled = false;
            m_defaultThumbnailSize = 100;
            m_autoRunDelayTime = DefineAndConst.SystemCapacities.AUTO_RUN_DELAY_TIME_DEF;
        }

        #region implementation

        /// <summary>
        /// Gets or sets a value indicating whether [removal of run button option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [removal of run button option]; otherwise, <c>false</c>.
        /// </value>
        public bool RemovalOfRunButtonOption
        {
            get { return m_removalOfRunButtonEnabled; }
            set { m_removalOfRunButtonEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [invert preset profile option].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [invert preset profile option]; otherwise, <c>false</c>.
        /// </value>
        public bool InvertPresetProfileOption
        {
            get { return m_invertPresetProfileEnabled; }
            set { m_invertPresetProfileEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [save and undo sweep console settings].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [save and undo sweep console settings]; otherwise, <c>false</c>.
        /// </value>
        public bool SaveAndUndoSweepConsoleSettings
        {
            get { return m_saveAndUndoSweepConsoleSettings; }
            set { m_saveAndUndoSweepConsoleSettings = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [save and undo water console settings].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [save and undo water console settings]; otherwise, <c>false</c>.
        /// </value>
        public bool SaveAndUndoWaterConsoleSettings
        {
            get { return m_saveAndUndoWaterConsoleSettings; }
            set { m_saveAndUndoWaterConsoleSettings = value; }
        }

        /// <summary>
        /// Gets or sets the default size of the thumbnail.
        /// </summary>
        /// <value>
        /// The default size of the thumbnail.
        /// </value>
        public int DefaultThumbnailSize
        {
            get { return m_defaultThumbnailSize; }
            set { m_defaultThumbnailSize = value; }
        }

        /// <summary>
        /// Gets or sets the auto run delay time.
        /// </summary>
        /// <value>
        /// The auto run delay time.
        /// </value>
        public float AutoRunDelayTime
        {
            get { return m_autoRunDelayTime; }
            set { m_autoRunDelayTime = value; }
        }

        #endregion

        #region members

        private bool m_removalOfRunButtonEnabled = false;
        private bool m_invertPresetProfileEnabled = false;
        private bool m_saveAndUndoSweepConsoleSettings = false;
        private bool m_saveAndUndoWaterConsoleSettings = false;
        private int m_defaultThumbnailSize = 100;   // 100% - Thumbnail default display size
        private float m_autoRunDelayTime = DefineAndConst.SystemCapacities.AUTO_RUN_DELAY_TIME_DEF;

        #endregion
    }
}
