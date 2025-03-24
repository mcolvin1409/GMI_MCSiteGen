// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionPlate.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents a plate of a broadsheet. This class holds section number and page number information.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace ImpositionImport
{
    public class CMCImpositionPlate
    {

        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionPlate"/> class.
        /// </summary>
        public CMCImpositionPlate()
        {
            m_sectionNumber = 0;
            m_pageNumber = 0;
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the section number.
        /// </summary>
        /// <value>
        /// The section number.
        /// </value>
        public ushort SectionNumber
        {
            get { return m_sectionNumber; }
            set { m_sectionNumber = value; }
        }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>
        /// The page number.
        /// </value>
        public ushort PageNumber
        {
            get { return m_pageNumber; }
            set { m_pageNumber = value; }
        }

        #endregion

        #region methods

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="plateData">The plate data.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">UpdateData - Plate data cannot be null</exception>
        public bool UpdateData(ImpositionImport_API.IMPOSITION_BROADSHEET_PLATE plateData)
        {
            if (null == plateData)
            {
                throw new InvalidOperationException("UpdateData - Plate data cannot be null");
            }

            m_sectionNumber = plateData.wSection;
            m_pageNumber = plateData.wPage;

            return true;
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  25-Mar-15, Mark C, WI51037 - created
        /// 
        /// ]]>
        /// <summary>
        /// To the section page string.
        /// </summary>
        /// <returns></returns>
        public string ToSectionPageString()
        {
            string pageString = string.Empty;
            pageString = string.Format("{0}{1}", TowerCIP3SectionConversion.GetSectionString(m_sectionNumber), 
                TowerCIP3SectionConversion.GetPageString(m_pageNumber) ) ;

            return pageString;
        }

        #endregion

        #region implementation

        /// <summary> Section Number ( A=1, B=2 ..| AA =257, AB = 258 ..| BA=513, BB=514.. )</summary>
        private ushort m_sectionNumber;
        /// <summary> Page Number </summary>
        private ushort m_pageNumber;

        #endregion
    }
}
