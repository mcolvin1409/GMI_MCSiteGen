// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionBroadsheet.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents a broadsheet of an Inker. This class holds Plates data.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;


namespace ImpositionImport
{
    public class CMCImpositionBroadsheet
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionBroadsheet"/> class.
        /// </summary>
        public CMCImpositionBroadsheet()
        {
            m_plateMap.Clear();
        }

        #endregion

        #region properties

        #endregion

        #region methods

        /// <summary>
        /// Gets the plate data at.
        /// </summary>
        /// <param name="indexAround">The index around.</param>
        /// <param name="indexAcross">The index across.</param>
        /// <returns></returns>
        public CMCImpositionPlate GetPlateDataAt(byte indexAround, byte indexAcross)
        {
            if (!m_plateMap.ContainsKey(indexAround))
            {
                new IndexOutOfRangeException( "GetPlateDataAt - Invalid Index Around" + indexAround );
            }

            if (!m_plateMap[indexAround].ContainsKey(indexAcross))
            {
                new IndexOutOfRangeException( "GetPlateDataAt - Invalid Index Across" + indexAcross );
            }

            return m_plateMap[indexAround][indexAcross];
        }

        /// <summary>
        /// Sets the plate data at.
        /// </summary>
        /// <param name="indexAround">The index around.</param>
        /// <param name="indexAcross">The index across.</param>
        /// <param name="plateData">The plate data.</param>
        public void SetPlateDataAt(byte indexAround, byte indexAcross, CMCImpositionPlate plateData)
        {
            if (!m_plateMap.ContainsKey(indexAround))
            {
                Dictionary<byte, CMCImpositionPlate> tempPlateData = new Dictionary<byte, CMCImpositionPlate>();
                tempPlateData.Add(indexAcross, plateData);
                m_plateMap.Add(indexAround, tempPlateData);
            }
            else if (!m_plateMap[indexAround].ContainsKey(indexAcross))
            {
                m_plateMap[indexAround].Add(indexAcross, plateData);
            }
            else
            {
                m_plateMap[indexAround][indexAcross] = plateData;
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
        /// <param name="broadSheet">The broad sheet.</param>
        /// <returns></returns>
        public bool UpdateData(ImpositionImport_API.IMPOSITION_BROADSHEET broadSheet)
        {
            if (null == broadSheet)
            {
                new InvalidOperationException( "UpdateData - Broadsheet data cannot be null" );
            }

            bool updateData = false;
            for (byte pageAroundIndex = 0; pageAroundIndex < ImpositionImport_API.PAGES_AROUND; ++pageAroundIndex)
            {
                for (byte pageAcrossIndex = 0; pageAcrossIndex < ImpositionImport_API.PAGES_ACROSS; ++pageAcrossIndex)
                {
                    CMCImpositionPlate plateData = new CMCImpositionPlate();
                    if ( plateData.UpdateData( broadSheet.ayPages[pageAroundIndex, pageAcrossIndex] ) )
                    {
                        // inert page data into broad sheet
                        SetPlateDataAt(pageAroundIndex, pageAcrossIndex, plateData);
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
        /// Gets all pages.
        /// </summary>
        /// <returns></returns>
        public List<CMCImpositionPlate> GetAllPages()
        {
            List<CMCImpositionPlate> pagesList = new List<CMCImpositionPlate>();

            foreach (KeyValuePair<byte, Dictionary<byte, CMCImpositionPlate>> plateAroundData in m_plateMap)
            {
                int plateAroundIndex = plateAroundData.Key;
                foreach (KeyValuePair<byte, CMCImpositionPlate> plateAcrossData in plateAroundData.Value)
                {
                    int plateAcrossIndex = plateAcrossData.Key;
                    CMCImpositionPlate plateData = plateAcrossData.Value;
                    if (null != plateData)
                    {
                        pagesList.Add(plateData);
                    }
                }
            }

            return pagesList;
        }

        #endregion

        #region implementation

        private readonly Dictionary<byte, Dictionary<byte, CMCImpositionPlate>> m_plateMap = new Dictionary<byte, Dictionary<byte, CMCImpositionPlate>>();

        #endregion

    }
}
