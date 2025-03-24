// ***********************************************************************
// Author           : Mark C
// Created          : 12-Feb-2015
//
// ***********************************************************************
// <copyright file="CMCImpositionFormerWebPath.cs" company="AVT">
//     Copyright (c) AVT. All rights reserved.
// </copyright>
// <summary>
//	This class represents a Former Web Path of a Unit. This class holds feeder number and web path direction information.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace ImpositionImport
{

    public enum FORMER_WEB_PATH_DIRECTION
    {
        FORMER_WEB_PATH_FROM_LEFT_OVER = 0,
        FORMER_WEB_PATH_FROM_LEFT_UNDER,
        FORMER_WEB_PATH_FROM_RIGHT_OVER,
        FORMER_WEB_PATH_FROM_RIGHT_UNDER
    };

    public class CMCImpositionFormerWebPath
    {
        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CMCImpositionFormerWebPath"/> class.
        /// </summary>
        public CMCImpositionFormerWebPath()
        {
            m_feederNumber = 0;
            m_webPathDirection = Convert.ToByte(FORMER_WEB_PATH_DIRECTION.FORMER_WEB_PATH_FROM_LEFT_OVER);
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the feeder number.
        /// </summary>
        /// <value>
        /// The feeder number.
        /// </value>
        public byte FeederNumber
        {
            get { return m_feederNumber; }
            set { m_feederNumber = value; }
        }

        /// <summary>
        /// Gets or sets the web path direction.
        /// </summary>
        /// <value>
        /// The web path direction.
        /// </value>
        public byte WebPathDirection
        {
            get { return m_webPathDirection; }
            set { m_webPathDirection = value; }
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
        /// <param name="webPath">The web path.</param>
        /// <returns></returns>
        /// <exception cref="InvalidValueException">UpdateData - WebPath cannot be null</exception>
        public bool UpdateData(ImpositionImport_API.IMPOSITION_UNIT_FORMER_WEB_PATH webPath)
        {
            if (null == webPath)
            {
                throw new InvalidOperationException( "UpdateData - WebPath cannot be null" );
            }

            m_feederNumber = webPath.byFeederNumber;
            m_webPathDirection = webPath.byWebPathDir;

            return true;
        }

        #endregion

        #region implementation

        /// <summary>source feeder number</summary>
        private byte m_feederNumber;
        /// <summary>Web path from left or right</summary>
        private byte m_webPathDirection;

        #endregion
    }
}
