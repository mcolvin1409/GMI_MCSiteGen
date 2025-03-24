
// ***********************************************************************
// Author           : Mark C
// Created          : 3/25/2015
//
// ***********************************************************************
// <copyright file="TowerCIP3SectionConversion.cs" company="AVT">
//     Copyright (c) 2015 AVT. All rights reserved.
// </copyright>
// <summary>
// This is a helper class to convert section number to a Section Page Text description
//  and page number to a page string
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace ImpositionImport
{
    public class TowerCIP3SectionConversion
    {
        private const int NUM_SECTION_CHARS = 26;	// A..Z

        /// <summary>
        /// Gets the section string.
        /// </summary>
        /// <param name="sectionNumber">The section number.</param>
        /// <returns></returns>
        public static string GetSectionString( int sectionNumber )
        {
            string sectionString = string.Empty;

            //only one letter 
            if ( ( sectionNumber > 0 ) && ( sectionNumber <= NUM_SECTION_CHARS ) )
            {
                sectionString = Convert.ToChar( 'A' + sectionNumber - 1 ).ToString( );
            }
            //two letters AA (257) TO ZZ (6682)
            else if ( ( sectionNumber >= 257 ) && ( sectionNumber <= 6682 ) )
            {
                //Convert sectionNumber to a hex number
                string sectionNumberInHex = sectionNumber.ToString( "X" );
                int strLength = sectionNumberInHex.Length;
                string s2 = sectionNumberInHex.Substring( strLength - 2 );
                string s1 = sectionNumberInHex.Substring( 0, strLength - 2 );

                // Convert the hex string back to the number
                int i1 = Int32.Parse( s1, System.Globalization.NumberStyles.HexNumber );
                int i2 = Int32.Parse( s2, System.Globalization.NumberStyles.HexNumber );

                sectionString = string.Format( "{0}{1}", Convert.ToChar( 'A' + i1 - 1 ), Convert.ToChar( 'A' + i2 - 1 ) );
            }

            return sectionString;
        }

        /// <summary>
        /// Gets the page string.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <returns></returns>
        public static string GetPageString( int pageNumber )
        {
            string pageString = string.Empty;

            if ( pageNumber > 0 )
            {
                pageString = string.Format( "{0}", pageNumber );
            }

            return pageString;
        }
    }
}
