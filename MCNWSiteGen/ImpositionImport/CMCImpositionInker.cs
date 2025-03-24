// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionInker.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents an Inker of a Unit. This class holds inker specific data and Broadsheets data.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ImpositionImport
{
    public class CMCImpositionInker
    {

        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionInker"/> class.
        /// </summary>
        public CMCImpositionInker()
        {
            m_colorIndex = 0;
            m_webSide = 0;
            m_directInker = false;
            m_pageFormat = 0;
            m_webNumber = 0;
            m_inkerName = string.Empty;
            m_broadSheetMap.Clear();
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the index of the color.
        /// </summary>
        /// <value>
        /// The index of the color.
        /// </value>
        public short ColorIndex
        {
            get { return m_colorIndex; }
            set { m_colorIndex = value; }
        }

        /// <summary>
        /// Gets or sets the web side.
        /// </summary>
        /// <value>
        /// The web side.
        /// </value>
        public short WebSide
        {
            get { return m_webSide; }
            set { m_webSide = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [direct inker].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [direct inker]; otherwise, <c>false</c>.
        /// </value>
        public bool DirectInker
        {
            get { return m_directInker; }
            set { m_directInker = value; }
        }

        /// <summary>
        /// Gets or sets the page format.
        /// </summary>
        /// <value>
        /// The page format.
        /// </value>
        public byte PageFormat
        {
            get { return m_pageFormat; }
            set { m_pageFormat = value; }
        }

        /// <summary>
        /// Gets or sets the web number.
        /// </summary>
        /// <value>
        /// The web number.
        /// </value>
        public byte WebNumber
        {
            get { return m_webNumber; }
            set { m_webNumber = value; }
        }

        /// <summary>
        /// Gets or sets the name of the inker.
        /// </summary>
        /// <value>
        /// The name of the inker.
        /// </value>
        public string InkerName
        {
            get { return m_inkerName; }
            set { m_inkerName = value; }
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the broadsheet data at.
        /// </summary>
        /// <param name="sheetAroundIndex">Index of the sheet around.</param>
        /// <param name="sheetAcrossIndex">Index of the sheet across.</param>
        /// <returns></returns>
        public CMCImpositionBroadsheet GetBroadsheetDataAt(byte sheetAroundIndex, byte sheetAcrossIndex)
        {
            if (!m_broadSheetMap.ContainsKey(sheetAroundIndex))
            {
                new IndexOutOfRangeException( "GetBroadsheetDataAt - Invalid sheet around index" + sheetAroundIndex );
            }

            if (!m_broadSheetMap[sheetAroundIndex].ContainsKey(sheetAcrossIndex))
            {
                new IndexOutOfRangeException( "GetBroadsheetDataAt - Invalid sheet across index" + sheetAcrossIndex );
            }

            return m_broadSheetMap[sheetAroundIndex][sheetAcrossIndex];
        }

        /// <summary>
        /// Sets the broadsheet data at.
        /// </summary>
        /// <param name="sheetAroundIndex">Index of the sheet around.</param>
        /// <param name="sheetAcrossIndex">Index of the sheet across.</param>
        /// <param name="sheetData">The sheet data.</param>
        public void SetBroadsheetDataAt(byte sheetAroundIndex, byte sheetAcrossIndex, CMCImpositionBroadsheet sheetData)
        {
            if (!m_broadSheetMap.ContainsKey(sheetAroundIndex))
            {
                Dictionary<byte, CMCImpositionBroadsheet> tempSheetData = new Dictionary<byte, CMCImpositionBroadsheet>();
                tempSheetData.Add(sheetAcrossIndex, sheetData);
                m_broadSheetMap.Add(sheetAroundIndex, tempSheetData);
            }
            else if (!m_broadSheetMap[sheetAroundIndex].ContainsKey(sheetAcrossIndex))
            {
                m_broadSheetMap[sheetAroundIndex].Add(sheetAcrossIndex, sheetData);
            }
            else
            {
                m_broadSheetMap[sheetAroundIndex][sheetAcrossIndex] = sheetData;
            }
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
        /// <param name="inkerIndex">Index of the inker.</param>
        /// <param name="impositionUnit">The imposition unit.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">UpdateData - Import Unit data cannot be null</exception>
        public bool UpdateData(byte inkerIndex, ImpositionImport_API.IMPOSITION_UNIT impositionUnit)
        {
            if (null == impositionUnit)
            {
                throw new InvalidOperationException( "UpdateData - Import Unit data cannot be null" );
            }

            m_inkerName = impositionUnit.aybyInkerLabels[inkerIndex];
            // Fill the data only for Valid inkers
            if ( string.IsNullOrEmpty( m_inkerName) )
            {
                return false;
            }

            m_colorIndex = impositionUnit.aysInkerColors[inkerIndex];
            m_directInker = (impositionUnit.aybyDirectInk[inkerIndex] == 1);
            m_webSide = impositionUnit.aysWebSide[inkerIndex];

            bool updateData = false;

            // Fill Imposition broadsheet data
            for (byte sheetAroundIndex = 0; sheetAroundIndex < ImpositionImport_API.BROADSHEETS_AROUND; ++sheetAroundIndex)
            {
                for (byte sheetAcrossIndex = 0; sheetAcrossIndex < ImpositionImport_API.BROADSHEETS_ACROSS; ++sheetAcrossIndex)
                {
                    CMCImpositionBroadsheet broadSheet = new CMCImpositionBroadsheet();
                    if ( broadSheet.UpdateData( impositionUnit.ayBroadsheets[inkerIndex, sheetAroundIndex, sheetAcrossIndex] ) )
                    {
                        // insert broadsheet data into Inker
                        SetBroadsheetDataAt(sheetAroundIndex, sheetAcrossIndex, broadSheet);
                        updateData = true;
                    }
                }
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
        /// Gets the high side pages.
        /// </summary>
        /// <returns></returns>
        public List<string> GetHighSidePages()
        {
            List<CMCImpositionPlate> pagesList = new List<CMCImpositionPlate>( );

            if ( m_broadSheetMap.ContainsKey( SheetHighSide ) )
            {
                foreach ( KeyValuePair<byte, CMCImpositionBroadsheet> sheetAcrossData in m_broadSheetMap[ SheetHighSide ] )
                {
                    int sheetAcrossIndex = sheetAcrossData.Key;
                    CMCImpositionBroadsheet broadSheetData = sheetAcrossData.Value;
                    if ( null != broadSheetData )
                    {
                        pagesList.AddRange( broadSheetData.GetAllPages( ) );
                    }
                }
            }

            // Sort the Pages List by Page Number and Section Number
            List<CMCImpositionPlate> sortedPagesList = pagesList.OrderBy( item => item.PageNumber ).OrderBy( item => item.SectionNumber ).ToList( );
            List<string> sortedPagesStringList = new List<string>( );
            // convert each page number and section number to display texts
            foreach ( CMCImpositionPlate plateData in sortedPagesList )
            {
                if ( null != plateData )
                {
                    string sectionPageString = plateData.ToSectionPageString( );
                    sortedPagesStringList.Add( sectionPageString );
                }
            }

            // Finally, get only the Unique pages  
            List<string> uniquePagesStringList = new List<string>( );
            uniquePagesStringList.AddRange( sortedPagesStringList.Distinct( ) );

            return uniquePagesStringList;
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the low side pages.
        /// </summary>
        /// <returns></returns>
        public List<string> GetLowSidePages()
        {
            List<CMCImpositionPlate> pagesList = new List<CMCImpositionPlate>( );

            if ( m_broadSheetMap.ContainsKey( SheetLowSide ) )
            {
                foreach ( KeyValuePair<byte, CMCImpositionBroadsheet> sheetAcrossData in m_broadSheetMap[ SheetLowSide ] )
                {
                    int sheetAcrossIndex = sheetAcrossData.Key;
                    CMCImpositionBroadsheet broadSheetData = sheetAcrossData.Value;
                    if ( null != broadSheetData )
                    {
                        pagesList.AddRange( broadSheetData.GetAllPages( ) );
                    }
                }
            }

            // Sort the Pages List by Page Number and Section Number
            List<CMCImpositionPlate> sortedPagesList = pagesList.OrderBy( item => item.PageNumber ).OrderBy( item => item.SectionNumber ).ToList( );
            List<string> sortedPagesStringList = new List<string>( );
            // convert each page number and section number to display texts
            foreach ( CMCImpositionPlate plateData in sortedPagesList )
            {
                if ( null != plateData )
                {
                    string sectionPageString = plateData.ToSectionPageString( );
                    sortedPagesStringList.Add( sectionPageString );
                }
            }

            // Finally, get only the Unique pages  
            List<string> uniquePagesStringList = new List<string>( );
            uniquePagesStringList.AddRange( sortedPagesStringList.Distinct( ) );

            return uniquePagesStringList;
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// Gets all pages.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllPages()
        {
            List<CMCImpositionPlate> pagesList = new List<CMCImpositionPlate>();

            foreach( KeyValuePair<byte, Dictionary<byte, CMCImpositionBroadsheet>> sheetAroundData in m_broadSheetMap)
            {
                int sheetAroundIndex = sheetAroundData.Key;
                foreach(KeyValuePair<byte, CMCImpositionBroadsheet> sheetAcrossData in sheetAroundData.Value)
                {
                    int sheetAcrossIndex = sheetAcrossData.Key;
                    CMCImpositionBroadsheet broadSheetData = sheetAcrossData.Value;
                    if (null != broadSheetData)
                    {
                        pagesList.AddRange(broadSheetData.GetAllPages());
                    }
                }
            }

            // Sort the Pages List by Page Number and Section Number
            List<CMCImpositionPlate> sortedPagesList = pagesList.OrderBy(item => item.PageNumber).OrderBy(item => item.SectionNumber).ToList();                     
            List<string> sortedPagesStringList = new List<string>();
            // convert each page number and section number to display texts
            foreach (CMCImpositionPlate plateData in sortedPagesList)
            {
                if (null != plateData)
                {
                    string sectionPageString = plateData.ToSectionPageString();
                    sortedPagesStringList.Add(sectionPageString);                    
                }
            }

            // Finally, get only the Unique pages  
            List<string> uniquePagesStringList = new List<string>();
            uniquePagesStringList.AddRange( sortedPagesStringList.Distinct() );

            return uniquePagesStringList;
        }

        #endregion

        #region implementation

        /// <summary>Color Index</summary>
        private short m_colorIndex;
        /// <summary>Side of the Web (0=Top, 1=Bottom)</summary>		
        private short m_webSide;
        /// <summary>Is a direct Inker or NOT, 0=false, 1=true</summary>		
        private bool m_directInker;
        /// <summary>Page Format, 0=panorama, 1= broadsheet,  2=tabloid, 3=quarterfolder,  4=digest</summary>		
        private byte m_pageFormat;
        /// <summary>WebNumber of the Inker - calculated based on the Feeder(Feeder is the starting point of a Web)</summary>		
        private byte m_webNumber;
        /// <summary>Inker Name</summary>		
        private string m_inkerName;
        private const byte SheetLowSide = 1;
        private const byte SheetHighSide = 0;
        /// <summary>Broadsheet Map, m_broadSheetMap( sheetAround, sheetAcross ) </summary>		
        private readonly Dictionary<byte, Dictionary<byte, CMCImpositionBroadsheet>> m_broadSheetMap = new Dictionary<byte, Dictionary<byte, CMCImpositionBroadsheet>>();

        #endregion

    }
}
