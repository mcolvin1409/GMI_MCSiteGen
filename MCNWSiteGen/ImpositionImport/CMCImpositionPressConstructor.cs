// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionPressConstructor.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents the Press constructor data, i.e. imported .PRS file data. 
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;


namespace ImpositionImport
{
    public class CMCImpositionPressConstructor
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionPressConstructor"/> class.
        /// </summary>
        public CMCImpositionPressConstructor()
        {
            m_currentVersion = 0;
            m_description = string.Empty;
            m_pressType = string.Empty;
            m_autoLabelMode.Clear();
            m_labelTable.Clear();
            m_inkerLabelMode = 0;
            m_pressWidth = 0;
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public int Version
        {
            get { return m_currentVersion; }
            set { m_currentVersion = value; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        /// <summary>
        /// Gets or sets the type of the press.
        /// </summary>
        /// <value>
        /// The type of the press.
        /// </value>
        public string PressType
        {
            get { return m_pressType; }
            set { m_pressType = value; }
        }

        /// <summary>
        /// Gets or sets the inker lable mode.
        /// </summary>
        /// <value>
        /// The inker lable mode.
        /// </value>
        public int InkerLableMode
        {
            get { return m_inkerLabelMode; }
            set { m_inkerLabelMode = value; }
        }

        /// <summary>
        /// Gets or sets the width of the press.
        /// </summary>
        /// <value>
        /// The width of the press.
        /// </value>
        public short PressWidth
        {
            get { return m_pressWidth; }
            set { m_pressWidth = value; }
        }

        /// <summary>
        /// Gets the web data.
        /// </summary>
        /// <value>
        /// The web data.
        /// </value>
        public CMCImpositionPressConstructorWeb WebData
        {
            get { return m_webPRSData; }
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the automatic label mode at.
        /// </summary>
        /// <param name="labelType">Type of the label.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetAutoLabelModeAt - Invalid Label Type + labelType</exception>
        public bool GetAutoLabelModeAt(int labelType)
        {
            if (!m_autoLabelMode.ContainsKey(labelType))
            {
                throw new IndexOutOfRangeException("GetAutoLabelModeAt - Invalid Label Type" + labelType);
            }

            return m_autoLabelMode[labelType];
        }

        /// <summary>
        /// Sets the automatic label mode at.
        /// </summary>
        /// <param name="labelType">Type of the label.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void SetAutoLabelModeAt(int labelType, bool value)
        {
            if (!m_autoLabelMode.ContainsKey(labelType))
            {
                m_autoLabelMode.Add(labelType, value);
            }
            else
            {
                m_autoLabelMode[labelType] = value;
            }
        }

        /// <summary>
        /// Gets the automatic label table at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetAutoLabelTableAt - Invalid label position value + position</exception>
        public int GetAutoLabelTableAt(int position)
        {
            if (!m_labelTable.ContainsKey(position))
            {
                throw new IndexOutOfRangeException("GetAutoLabelTableAt - Invalid label position value" + position);
            }

            return m_labelTable[position];
        }

        /// <summary>
        /// Sets the automatic label table at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="value">The value.</param>
        public void SetAutoLabelTableAt(int position, int value)
        {
            if (!m_labelTable.ContainsKey(position))
            {
                m_labelTable.Add(position, value);
            }
            else
            {
                m_labelTable[position] = value;
            }
        }

        public bool UpdateData( ImpositionImport_API.IMPOSITION_IMPORT_PRS importPRS )
        {
            if ( null == importPRS )
            {
                throw new InvalidOperationException( "CMCImpositionPressConstructor::UpdateData - Import PRS data cannot be NULL" );
            }

            m_currentVersion = importPRS.iCurVersion;
            m_description = importPRS.strPressDescription;
            m_pressType = importPRS.strPressType;
            m_inkerLabelMode = importPRS.iInkerLabelMode;
            m_pressWidth = importPRS.sPressWidth;

            // fill auto label mode details	
            for ( byte typeIndex = 0; typeIndex < ImpositionImport_API.NUM_LABEL_TYPES; ++typeIndex )
            {
                SetAutoLabelModeAt( typeIndex, ( importPRS.aybAutoLabelMode[ typeIndex ] == 1 ) );
            }

            // fill label table	
            for ( byte index = 0; index < ImpositionImport_API.MAX_COLUMNS; ++index )
            {
                SetAutoLabelTableAt( index, importPRS.ayiLabelTable[ index ] );
            }

            // update Web PRS data
            return m_webPRSData.UpdateData( importPRS.webprsData );
        }

        #endregion

        #region implementation

        /// <summary>Current Version</summary>
        private int m_currentVersion;
        /// <summary>Press Description</summary>
        private string m_description;
        /// <summary>Press Type</summary>
        private string m_pressType;
        /// <summary>true if Auto Label Mode</summary>
        private Dictionary<int, bool> m_autoLabelMode = new Dictionary<int, bool>();
        /// <summary>Label Table</summary>
        private Dictionary<int, int> m_labelTable = new Dictionary<int, int>();
        /// <summary>0=Tower Inker, 1=Tower Inker Side</summary>
        private int m_inkerLabelMode;
        /// <summary>Press width (v1 file only)</summary>
        private short m_pressWidth;
        /// <summary>Data common between .WEB and .PRS files</summary>
        private readonly CMCImpositionPressConstructorWeb m_webPRSData = new CMCImpositionPressConstructorWeb();

        #endregion

    }
}
