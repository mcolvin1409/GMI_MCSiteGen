// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionPressConstructorWeb.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents the Press constructor's Web data. This web data is common 
//		between .PRS and .WEB files of Imposition applicaiton.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace ImpositionImport
{
    public class CMCImpositionPressConstructorWeb
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionPressConstructorWeb"/> class.
        /// </summary>
        public CMCImpositionPressConstructorWeb()
        {
            m_numberBaseLine = 0;
            m_numPlatesAround = 0;
            m_numPlatesAcross = 0;
            m_leftToGear10 = false;
            m_leftToGear13 = false;
            m_zoneOrientMap.Clear();
            m_towerNumbers.Clear();
            m_towerToUnitsMap.Clear();
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the number base line.
        /// </summary>
        /// <value>
        /// The number base line.
        /// </value>
        public short NumberBaseLine
        {
            get { return m_numberBaseLine; }
            set { m_numberBaseLine = value; }
        }

        /// <summary>
        /// Gets or sets the number of plates around.
        /// </summary>
        /// <value>
        /// The number of plates around.
        /// </value>
        public short NumberOfPlatesAround
        {
            get { return m_numPlatesAround; }
            set { m_numPlatesAround = value; }
        }

        /// <summary>
        /// Gets or sets the number of plates across.
        /// </summary>
        /// <value>
        /// The number of plates across.
        /// </value>
        public short NumberOfPlatesAcross
        {
            get { return m_numPlatesAcross; }
            set { m_numPlatesAcross = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [left to gear10].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [left to gear10]; otherwise, <c>false</c>.
        /// </value>
        public bool LeftToGear10
        {
            get { return m_leftToGear10; }
            set { m_leftToGear10 = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [left to gear13].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [left to gear13]; otherwise, <c>false</c>.
        /// </value>
        public bool LeftToGear13
        {
            get { return m_leftToGear13; }
            set { m_leftToGear13 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the zone orientation.
        /// </summary>
        /// <param name="webSide">The web side.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetZoneOrientation - Invalid web side value + webSide</exception>
        public byte GetZoneOrientation(byte webSide)
        {
            if (!m_zoneOrientMap.ContainsKey(webSide))
            {
                throw new IndexOutOfRangeException("GetZoneOrientation - Invalid web side value" + webSide);
            }

            return m_zoneOrientMap[webSide];
        }

        /// <summary>
        /// Sets the zone orientation.
        /// </summary>
        /// <param name="webSide">The web side.</param>
        /// <param name="orientation">The orientation.</param>
        public void SetZoneOrientation(byte webSide, byte orientation)
        {
            if (!m_zoneOrientMap.ContainsKey(webSide))
            {
                m_zoneOrientMap.Add(webSide, orientation);
            }
            else
            {
                m_zoneOrientMap[webSide] = orientation;
            }
        }

        /// <summary>
        /// Gets the tower number at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetTowerNumberAt - Invalid tower position value + position</exception>
        public int GetTowerNumberAt(byte position)
        {
            if (!m_towerNumbers.ContainsKey(position))
            {
                throw new IndexOutOfRangeException( "GetTowerNumberAt - Invalid tower position value" + position );
            }

            return m_towerNumbers[position];
        }

        /// <summary>
        /// Sets the tower number at.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="towerNumber">The tower number.</param>
        public void SetTowerNumberAt(byte position, int towerNumber)
        {
            if (!m_towerNumbers.ContainsKey(position))
            {
                m_towerNumbers.Add(position, towerNumber);
            }
            else
            {
                m_towerNumbers[position] = towerNumber;
            }
        }

        /// <summary>
        /// Gets the unit at.
        /// </summary>
        /// <param name="towerPosition">The tower position.</param>
        /// <param name="unitPosition">The unit position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">
        /// GetUnitAt - Invalid tower position value + towerPosition
        /// or
        /// GetUnitAt - Invalid unit position value + unitPosition
        /// </exception>
        public CMCImpositionUnit GetUnitAt(int towerPosition, byte unitPosition)
        {
            if (!m_towerToUnitsMap.ContainsKey(towerPosition))
            {
                throw new IndexOutOfRangeException("GetUnitAt - Invalid tower position value" + towerPosition);
            }

            if (!m_towerToUnitsMap[towerPosition].ContainsKey(unitPosition))
            {
                throw new IndexOutOfRangeException( "GetUnitAt - Invalid unit position value" + unitPosition );
            }

            return m_towerToUnitsMap[towerPosition][unitPosition];
        }

        /// <summary>
        /// Sets the unit at.
        /// </summary>
        /// <param name="towerPosition">The tower position.</param>
        /// <param name="unitPosition">The unit position.</param>
        /// <param name="unit">The unit.</param>
        public void SetUnitAt(int towerPosition, byte unitPosition, CMCImpositionUnit unit)
        {
            if (!m_towerToUnitsMap.ContainsKey(towerPosition))
            {
                Dictionary<byte, CMCImpositionUnit> tempMap = new Dictionary<byte, CMCImpositionUnit>();
                tempMap.Add(unitPosition, unit);
                m_towerToUnitsMap.Add(towerPosition, tempMap);
            }
            else if (!m_towerToUnitsMap[towerPosition].ContainsKey(unitPosition))
            {
                m_towerToUnitsMap[towerPosition].Add(unitPosition, unit);
            }
            else
            {
                m_towerToUnitsMap[towerPosition][unitPosition] = unit;
            }

        }

        /// <summary>
        /// Gets the units of tower at.
        /// </summary>
        /// <param name="towerPosition">The tower position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetUnitsOfTowerAt - Invalid tower position value + towerPosition</exception>
        public Dictionary<byte, CMCImpositionUnit> GetUnitsOfTowerAt(int towerPosition)
        {
            if (!m_towerToUnitsMap.ContainsKey(towerPosition))
            {
                throw new IndexOutOfRangeException( "GetUnitsOfTowerAt - Invalid tower position value" + towerPosition );
            }

            return m_towerToUnitsMap[towerPosition];
        }

        /// <summary>
        /// Gets the number of towers.
        /// </summary>
        /// <returns></returns>
        public byte GetNumberOfTowers()
        {
            return Convert.ToByte(m_towerNumbers.Count);
        }

        /// <summary>
        /// Gets the number of towers and folders.
        /// </summary>
        /// <returns></returns>
        public byte GetNumberOfTowersAndFolders()
        {
            return Convert.ToByte(m_towerToUnitsMap.Count);
        }


        /// <summary>
        /// Gets the number of units at.
        /// </summary>
        /// <param name="towerPosition">The tower position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">GetNumberOfUnitsAt - Invalid tower position value + towerPosition</exception>
        public byte GetNumberOfUnitsAt(int towerPosition)
        {
            if (!m_towerToUnitsMap.ContainsKey(towerPosition))
            {
                throw new IndexOutOfRangeException( "GetNumberOfUnitsAt - Invalid tower position value" + towerPosition );
            }

            return Convert.ToByte(m_towerToUnitsMap[towerPosition].Count);
        }

        /// <summary>
        /// Gets the number of units.
        /// </summary>
        /// <returns></returns>
        public byte GetNumberOfUnits()
        {
            byte numberOfUnits = 0;

            foreach (KeyValuePair<int, Dictionary<byte, CMCImpositionUnit>> towerToUnitsMap in m_towerToUnitsMap)
            {
                foreach (KeyValuePair<byte, CMCImpositionUnit> unitsMap in towerToUnitsMap.Value)
                {
                    if (!unitsMap.Value.IsFolder())
                    {
                        ++numberOfUnits;
                    }
                }
            }

            return numberOfUnits;
        }

        /// <summary>
        /// Gets the number of inkers.
        /// </summary>
        /// <returns></returns>
        public byte GetNumOfInkers()
        {
            byte numberOfInkers = 0;

            foreach (KeyValuePair<int, Dictionary<byte, CMCImpositionUnit>> towerToUnitsMap in m_towerToUnitsMap)
            {
                foreach (KeyValuePair<byte, CMCImpositionUnit> unitsMap in towerToUnitsMap.Value)
                {
                    if (!unitsMap.Value.IsFolder())
                    {
                        numberOfInkers += unitsMap.Value.GetNumberOfInkers();
                    }
                }
            }

            return numberOfInkers;
        }

        /// <summary>
        /// Determines whether [is folder located at] [the specified tower position].
        /// </summary>
        /// <param name="towerPosition">The tower position.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">IsFolderAt - Invalid tower position value + towerPosition</exception>
        public bool IsFolderLocatedAt(int towerPosition)
        {
            bool folderExists = false;

            if (!m_towerToUnitsMap.ContainsKey(towerPosition))
            {
                throw new IndexOutOfRangeException( "IsFolderAt - Invalid tower position value" + towerPosition );
            }

            byte numberOfUnits = GetNumberOfUnitsAt(towerPosition);
            for (byte unitCounter = 0; unitCounter < numberOfUnits; ++unitCounter)
            {
                CMCImpositionUnit unit = GetUnitAt(towerPosition, unitCounter);
                if (null != unit)
                {
                    folderExists = unit.IsFolder();
                    break;
                }
            }

            return folderExists;
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
        /// <param name="webprsData">The webprs data.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException"> UpdateData - Imposition Import Web PRS data cannot be null </exception>
        public bool UpdateData(ImpositionImport_API.IMPOSITION_IMPORT_WEB_PRS webprsData)
        {
            if (null == webprsData)
            {
                throw new InvalidOperationException( " UpdateData - Imposition Import Web PRS data cannot be null " );
            }

            // basic web details
            m_numberBaseLine = webprsData.sNumBaseLine;
            m_numPlatesAround = webprsData.sNumPlateAround;
            m_numPlatesAcross = webprsData.sNumPlateAcross;
            m_leftToGear10 = ((uint)(1) == webprsData.bLeftToGear10);
            m_leftToGear13 = ((uint)(1) == webprsData.bLeftToGear13);

            // fill zone orientation	
            for (byte sideIndex = 0; sideIndex < ImpositionImport_API.MAX_WEB_SIDES; ++sideIndex)
            {
                SetZoneOrientation( sideIndex, (byte)( webprsData.aybZoneOrient[sideIndex] ) );
            }

            // fill tower numbers	
            byte towerIndex = 0;
            for (byte towerCounter = 0; towerCounter < ImpositionImport_API.MAX_COLUMNS; ++towerCounter)
            {
                int towerNumber = webprsData.ayiTowerNums[towerCounter];
                // Let us consider only valid Towers, i.e.  valid Tower number
                if (towerNumber > 0)
                {
                    SetTowerNumberAt(towerIndex++, towerNumber);
                }
            }


            bool updateData = false;

            // fill Units data in each Tower
            byte towerPosition = 0;
            for (byte colIndex = 0; colIndex < ImpositionImport_API.MAX_COLUMNS; ++colIndex)
            {
                byte unitIndex = 0;
                for (byte rowIndex = (ImpositionImport_API.MAX_ROWS - 1); rowIndex > 0; --rowIndex)
                {
                    ImpositionImport_API.IMPOSITION_UNIT impositionUnit = webprsData.ayUnits[rowIndex, colIndex];
                    // Consider only valid Unit data
                    // Note: The Imposition data seems to consider Folder data as Units data with unit type = 6 
                    CMCImpositionUnit unit = new CMCImpositionUnit();
                    if (unit.UpdateData(impositionUnit))
                    {
                        SetUnitAt(towerPosition, unitIndex++, unit);
                        updateData = true;
                    }
                }

                ++towerPosition;
            }

            return updateData;
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the units list.
        /// </summary>
        /// <returns></returns>
        public List<CMCImpositionUnit> GetUnitsList()
        {
            List<CMCImpositionUnit> unitsList = new List<CMCImpositionUnit>();

            foreach (KeyValuePair<int, Dictionary<byte, CMCImpositionUnit>> towerToUnitsMap in m_towerToUnitsMap)
            {
                foreach (KeyValuePair<byte, CMCImpositionUnit> unitsMap in towerToUnitsMap.Value)
                {
                    // get only Units
                    if (!unitsMap.Value.IsFolder())
                    {
                        unitsList.Add(unitsMap.Value);
                    }
                }
            }

            return unitsList;
        }

        public List<CMCImpositionInker> GetAllImpositionInkers()
        {
            List<CMCImpositionInker> inkersList = new List<CMCImpositionInker>( );

            List<CMCImpositionUnit> unitsList = GetUnitsList( );
            foreach ( CMCImpositionUnit unit in unitsList )
            {
                int numberOfInkers = unit.GetNumberOfInkers( );
                for ( int inkerCounter = 0; inkerCounter < numberOfInkers; ++inkerCounter )
                {
                    CMCImpositionInker inker = unit.GetInkerAt( inkerCounter );
                    if ( null != inker )
                    {
                        inkersList.Add( inker );
                    }
                }
            }

            return inkersList;
        }

        #endregion

        #region implementation

        /// <summary>Base line number</summary>
        private short m_numberBaseLine;
        /// <summary>Number of plates around</summary>
        private short m_numPlatesAround;
        /// <summary>Number of plates across (0=Single, 1=Double, 2=Tripple) </summary>
        private short m_numPlatesAcross;
        /// <summary>true if left is to gear on 10-side</summary>
        private bool m_leftToGear10;
        /// <summary>true if left is to gear on 13-side</summary>
        private bool m_leftToGear13;
        /// <summary>0=10-side, 1=13-side -AND- 0=RightToLeft, 1=LeftToRight</summary>
        private readonly Dictionary<byte, byte> m_zoneOrientMap = new Dictionary<byte, byte>();
        /// <summary>Tower numbers</summary>
        private readonly Dictionary<byte, int> m_towerNumbers = new Dictionary<byte, int>();
        /// <summary>Units list in each Tower</summary>
        private readonly Dictionary<int, Dictionary<byte, CMCImpositionUnit>> m_towerToUnitsMap = new Dictionary<int, Dictionary<byte, CMCImpositionUnit>>();

        #endregion
    }
}
