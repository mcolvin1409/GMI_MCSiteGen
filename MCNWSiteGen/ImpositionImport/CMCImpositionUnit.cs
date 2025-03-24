// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionUnit.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents a Unit ( OR ) a Folder of an Imposition. This class holds Inkers data and Former Web Paths data.
//  Note: The press constructor data (1.PRS) considers both Unit and Folder data as same except the unit type ( Unit = 2, Folder = 6, 12, 13, 14 ).
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace ImpositionImport
{

    /// <summary>
    /// Imposition Unit Types
    /// </summary>
    public enum ImpositionUnitType { UNIT_TYPE1 = 1, UNIT_TYPE2 = 2, UNIT_TYPE3 = 3, UNIT_TYPE4 = 4, UNIT_TYPE5 = 5 };
    /// <summary>
    /// Imposition Folder Types
    /// </summary>
    public enum ImpositionFolderType { FOLDER_TYPE1 = 6, FOLDER_TYPE2 = 12, FOLDER_TYPE3 = 13, FOLDER_TYPE4 = 14 };

    public class CMCImpositionUnit
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionUnit"/> class.
        /// </summary>
        public CMCImpositionUnit()
        {
            m_unitType = 0;
            m_directUnit = 0;
            m_unitSequenceNum = 0;
            m_inkerMap.Clear();
            m_formerWebPathMap.Clear();
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the type of the unit.
        /// </summary>
        /// <value>
        /// The type of the unit.
        /// </value>
        public short UnitType
        {
            get { return m_unitType; }
            set { m_unitType = value; }
        }

        /// <summary>
        /// Gets or sets the direct unit.
        /// </summary>
        /// <value>
        /// The direct unit.
        /// </value>
        public int DirectUnit
        {
            get { return m_directUnit; }
            set { m_directUnit = value; }
        }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// <value>
        /// The sequence number.
        /// </value>
        public int SequenceNumber
        {
            get { return m_unitSequenceNum; }
            set { m_unitSequenceNum = value; }
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the inker at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetInkerAt - Invalid Inker Position Value + position</exception>
        public CMCImpositionInker GetInkerAt(int position)
        {
            if (!m_inkerMap.ContainsKey(position))
            {
                throw new IndexOutOfRangeException( "GetInkerAt - Invalid Inker Position Value" + position );
            }

            return m_inkerMap[position];
        }

        /// <summary>
        /// Sets the inker at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="inker">The inker.</param>
        public void SetInkerAt(int position, CMCImpositionInker inker)
        {
            if (!m_inkerMap.ContainsKey(position))
            {
                m_inkerMap.Add(position, inker);
            }
            else
            {
                m_inkerMap[position] = inker;
            }
        }

        /// <summary>
        /// Gets the web path list at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetWebPathListAt - Invalid Web Path Position value + position</exception>
        public List<CMCImpositionFormerWebPath> GetWebPathListAt(int position)
        {
            if (!m_formerWebPathMap.ContainsKey(position))
            {
                throw new IndexOutOfRangeException( "GetWebPathListAt - Invalid Web Path Position value" + position );
            }

            return m_formerWebPathMap[position];
        }

        /// <summary>
        /// Sets the web path list.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="webPathList">The web path list.</param>
        public void SetWebPathList(int position, List<CMCImpositionFormerWebPath> webPathList)
        {
            if (!m_formerWebPathMap.ContainsKey(position))
            {
                m_formerWebPathMap.Add(position, webPathList);
            }
            else
            {
                m_formerWebPathMap[position] = webPathList;
            }
        }

        /// <summary>
        /// Determines whether this instance is folder.
        /// </summary>
        /// <returns></returns>
        public bool IsFolder()
        {
            return Enum.IsDefined(typeof(ImpositionFolderType), (ImpositionFolderType)(m_unitType));
        }

        /// <summary>
        /// Gets the number of inkers.
        /// </summary>
        /// <returns></returns>
        public byte GetNumberOfInkers()
        {
            return Convert.ToByte(m_inkerMap.Count);
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="impositionUnit">The imposition unit.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">UpdateData - Import Unit data cannot be null</exception>
        public bool UpdateData(ImpositionImport_API.IMPOSITION_UNIT impositionUnit)
        {
            if (null == impositionUnit)
            {
                throw new InvalidOperationException( "UpdateData - Import Unit data cannot be null" );               
            }

            // Check for valid Unit type, Unit Type = 2 for Units; 6, 12, 13 and 14 for Folders
            if (0 == impositionUnit.sUnitType)
            {
                return false;
            }

            m_unitType = impositionUnit.sUnitType;
            m_directUnit = impositionUnit.iDirectUnit;
            m_unitSequenceNum = impositionUnit.iUnitSequenceInWeb;

            bool updateData = false;

            // Fill Inker data
            for (byte inkerIndex = 0; inkerIndex < ImpositionImport_API.MAX_UNIT_INKER; ++inkerIndex)
            {
                CMCImpositionInker impositionInker = new CMCImpositionInker();
                // update the rest of the Inker data
                if ( impositionInker.UpdateData(inkerIndex, impositionUnit) )
                {
                    // update Inker map
                    SetInkerAt(inkerIndex, impositionInker);
                    updateData = true;
                }
            }

            // TODO?? - Fill the Former web path data m_formerWebPathMap
            // Former web path data is empty in PRS file, i.e. NO web paths are defined in press constructor file,
            //	it is defined only in the Imposition data (.WEB, .IMP)            

            return updateData;
        }

        #endregion

        #region implementation

        /// <summary>Unit Type</summary>
        private short m_unitType;
        /// <summary>Web Type</summary>
        private int m_directUnit;
        /// <summary>Unit sequence number in the Web</summary>
        private int m_unitSequenceNum;
        /// <summary>Inkers belong to the Unit</summary>
        private Dictionary<int, CMCImpositionInker> m_inkerMap = new Dictionary<int, CMCImpositionInker>();
        /// <summary>Former Web path list for former (max 4)</summary>
        private Dictionary<int, List<CMCImpositionFormerWebPath>> m_formerWebPathMap = new Dictionary<int, List<CMCImpositionFormerWebPath>>();

        #endregion

    }
}
