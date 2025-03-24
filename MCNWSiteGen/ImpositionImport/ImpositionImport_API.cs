//******************************************************************************
//
//  ImpositionImport_API.cs - Imposition Import Library Interface
//
//  Author:         Don Gerber                          Date: 01/26/2015
//
//******************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace ImpositionImport
{
    /// <author>Don Gerber</author><date>01-26-2015</date>
    /// <summary>
    /// Imposition Import API
    /// </summary>
    public class ImpositionImport_API
    {
        ////////////////////////////////////////////////////////////////////////
        //
        //  INTERFACE DEFINITIONS
        //

        #region Constants

        /// <summary>Size (bytes) of PRS Library results</summary>
        public const int IMPORT_PRS_SIZE = 120156;
        /// <summary>Size (bytes) of IMP Library results</summary>
        public const int IMPORT_IMP_SIZE = 59238;
        /// <summary>Size (bytes) of WEB Library results</summary>
        public const int IMPORT_WEB_SIZE = 318458;
        /// <summary>Size (bytes) of IMP Description Library results</summary>
        public const int IMPORT_IMP_DESCRIPTION_SIZE = 86;
        /// <summary>Size (bytes) of WEB Description Library results</summary>
        public const int IMPORT_WEB_DESCRIPTION_SIZE = 660;

        /// <summary>quarter fold pages per broadsheet PLATE</summary>
        public const byte PAGES_AROUND = 2;
        /// <summary>quarter fold pages per broadsheet PLATE</summary>
        public const byte PAGES_ACROSS = 2;
        /// <summary>Maximum Broadsheets across</summary>
        public const byte BROADSHEETS_ACROSS = 6;
        /// <summary>Maximum Broadsheets around</summary>
        public const byte BROADSHEETS_AROUND = 2;
        /// <summary>Maximum Broadsheets across for each plate</summary>
        public const byte BROADSHEETS_ACROSS_PER_PLATE = 2;
        /// <summary>.IMP file Inker object count</summary>
        public const ushort MAX_TOTAL_INKER = 300;
        /// <summary>Maximum unit inker count</summary>
        public const byte MAX_UNIT_INKER = 4;
        /// <summary>Maximum former count</summary>
        public const byte MAX_FORMERS = 4;
        /// <summary>Maximum description string length</summary>
        public const byte MAX_DESCRIPTION_LEN = 80;
        /// <summary>Maximum number of special colors</summary>
        public const byte NUM_SPECIAL_COLORS = 8;
        /// <summary>Maximum number of webs</summary>
        public const byte MAX_NUM_WEBS = 20;
        /// <summary>Maximum number of press constructor columns</summary>
        public const byte MAX_COLUMNS = 24;
        /// <summary>Maximum number of press constructor rows</summary>
        public const byte MAX_ROWS = 5;
        /// <summary>Maximum number of points defined in each Web Path</summary>
        public const UInt16 MAX_WEB_PATH_POINTS = 1000;
        /// <summary>Maximum length of inker label text</summary>
        public const byte MAX_INKER_LABEL_LEN = 5;
        /// <summary>inkers, PQ Units, and Folders</summary>
        public const byte NUM_LABEL_TYPES = 3;
        /// <summary>Maximum number of web sides</summary>
        public const byte MAX_WEB_SIDES = 2;
        /// <summary>Default tower number</summary>
        public const byte DEFAULT_TOWER_NUM = 10;
        /// <summary>Pathname length (ASCIIZ)</summary>
        public const ushort IMPOSITION_PATHNAME_LTH = (255 + 1);
        /// <summary>Maximum number of plates across</summary>
        public const byte PLATE_ACROSS = 3;

        #endregion

        #region Enums (All are for reference only except Error Codes)

        /// <summary>
        /// Number of plates across press
        /// </summary>
        public enum ePRESS_WIDTH
        {
            /// <summary>Single</summary>
            ePRESS_WIDTH_SINGLE = 0,
            /// <summary>Double</summary>
            ePRESS_WIDTH_DOUBLE,
            /// <summary>Tripple</summary>
            ePRESS_WIDTH_TRIPLE
        };

        /// <summary>
        /// Inker label modes
        /// </summary>
        public enum eINKER_LABEL_MODE
        {
            /// <summary>Tower-Inker</summary>
            eINKER_LABEL_TOWER_INKER = 0,
            /// <summary>Tower-Inker-Side</summary>
            eINKER_LABEL_TOWER_INKER_SIDE 
        };

        /// <summary>
        /// Zone orientations
        /// </summary>
        public enum eZONE_ORIENTATION
        {
            /// <summary>Right to left</summary>
            eZONE_RIGHT_TO_LEFT = 0,
            /// <summary>Left to right</summary>
            eZONE_LEFT_TO_RIGHT 
        };

        /// <summary>
        /// Page sizes
        /// </summary>
        public enum ePAGE_SIZE
        {
            /// <summary>Panorama</summary>
            ePAGE_SIZE_PANORAMA = 0,
            /// <summary>Broadsheet</summary>
            ePAGE_SIZE_BROADSHEET,
            /// <summary>Tabloid</summary>
            ePAGE_SIZE_TABLOID,
            /// <summary>Magazine</summary>
            ePAGE_SIZE_MAGAZINE,
            /// <summary>Digest</summary>
            ePAGE_SIZE_DIGEST 
        };

        /// <summary>
        /// Page types
        /// </summary>
        public enum ePAGE_TYPE
        {
            /// <summary>Collect</summary>
            ePAGE_TYPE_COLLECT = 0,
            /// <summary>Straight</summary>
            ePAGE_TYPE_STRAIGHT
        };

        /// <summary>
        /// Former web paths
        /// </summary>
        public enum eFORMER_WEB_PATH
        {
            /// <summary>Left Over</summary>
            eFORMER_WEB_PATH_FROM_LEFT_OVER = 0,
            /// <summary>Left Under</summary>
            eFORMER_WEB_PATH_FROM_LEFT_UNDER,
            /// <summary>Right Over</summary>
            eFORMER_WEB_PATH_FROM_RIGHT_OVER,
            /// <summary>Right Under</summary>
            eFORMER_WEB_PATH_FROM_RIGHT_UNDER
        };


        /// <summary>
        /// Interface Error Return Codes
        /// </summary>
        public enum eIMPORT_ERRORS
        {
            /// <summary>Successful, no error</summary>
            eIMPORT_ERR_NONE = 0,
            /// <summary>Failed, insufficient memory</summary>
            eIMPORT_ERR_MEMORY,
            /// <summary>Failed, file pathname supplied is invalid</summary>
            eIMPORT_ERR_INVALID_PATHNAME,
            /// <summary>Failed, result structure is invalid</summary>
            eIMPORT_ERR_INVALID_RESULT,
            /// <summary>Failed, file could not be opened for reading</summary>
            eIMPORT_ERR_FILE_OPEN,
            /// <summary>Failed, file could not be read completely</summary>
            eIMPORT_ERR_FILE_READ,
            /// <summary>Failed, attempt to read beyond buffer length</summary>
            eIMPORT_ERR_BUFFER_LTH_EXCEEDED,
            /// <summary>Failed, unexpected unicode string detected</summary>
            eIMPORT_ERR_UNEXPECTED_UNICODE,
            /// <summary>End of Errors</summary>
            eIMPORT_ERR_LIST_END
        };

        #endregion

        #region Data Structures
        ////////////////////////////////////////////////////////////////////////
        //
        //  INTERFACE DATA STRUCTURES
        //

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Broadsheet Plate interface data
        /// (Original import data size is 4 bytes)
        /// </summary>
        public class IMPOSITION_BROADSHEET_PLATE
        {
            /// <summary>A=1, B=2, etc. AA =257, AB = 258... BA=513, BB=514..</summary>
            public ushort wSection;
            /// <summary>Page Number</summary>
            public ushort wPage;	
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Broadsheet interface data
        /// (Original import data size is 16 bytes)
        /// </summary>
        public class IMPOSITION_BROADSHEET
        {
            /// <summary>Broadsheet Plate Data</summary>
            public IMPOSITION_BROADSHEET_PLATE[,] ayPages = new IMPOSITION_BROADSHEET_PLATE[ PAGES_AROUND, PAGES_ACROSS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Unit Former Web Path (Feeder) interface data
        /// (Original import data size is 2 bytes)
        /// </summary>
        public class IMPOSITION_UNIT_FORMER_WEB_PATH
        {
            /// <summary>Source feeder number</summary>
            public byte byFeederNumber;
            /// <summary>0=From Left Over, 1=From Left Under, 2=From Right Over, 3=From Right Under - Web path direction (Version 3)</summary>
            public byte byWebPathDir;
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Unit Former interface data
        /// (Original import data size is 44 bytes)
        /// </summary>
        public class IMPOSITION_UNIT_FORMER
        {
            /// <summary>Number of Former Web Path definitions</summary>
            public int     iWebPathCount;
            /// <summary>Web Paths (Feeders)</summary>
            public IMPOSITION_UNIT_FORMER_WEB_PATH[] webFeeders = new IMPOSITION_UNIT_FORMER_WEB_PATH[ MAX_NUM_WEBS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Inker interface data
        /// (Original import data size is 197 bytes)
        /// </summary>
        public class IMPOSITION_INKER
        {
            /// <summary>Color Index</summary>
            public byte byColor;
            /// <summary>0=Top, 1=Bottom</summary>
            public byte byWebSide;
            /// <summary>-1=Unknown, 0=Offset, 1=10-Side, 2=13-Side</summary>
            public byte byDirectInker;
            /// <summary>0=panorama, 1=broadsheet,  2=tabloid, 3=quarterfolder, 4=digest</summary>
            public byte byPageFormat;
            /// <summary>Calculated based on the Feeder (Feeder is the starting point of a web)</summary>
            public byte byWebNumber;
            /// <summary>Broadsheet definitions</summary>
            public IMPOSITION_BROADSHEET[,] ayBroadsheets = new IMPOSITION_BROADSHEET[ BROADSHEETS_AROUND, BROADSHEETS_ACROSS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Unit interface data
        /// (Original import data size is 998 bytes)
        /// </summary>
        public class IMPOSITION_UNIT
        {
            ////////////////////////////////////////////////////////////////////////
            // 
            // Data from .PRS and .WEB files (30 bytes)

            /// <summary>Unit Type</summary>
            public short   sUnitType;
            /// <summary>Inker Labels</summary>
            public string[] aybyInkerLabels = new string[ MAX_UNIT_INKER ];
            /// <summary>Inker Colors</summary>
            public short[] aysInkerColors = new short[ MAX_UNIT_INKER ];

            ////////////////////////////////////////////////////////////////////////
            // 
            // Data from .WEB file only (968 bytes)

            /// <summary>Side of web</summary>
            public short[] aysWebSide = new short[ MAX_UNIT_INKER ];
            /// <summary>-1=Unknown, 0=Offset, 1=10-Side, 2=13-Side</summary>
            public byte[]  aybyDirectInk = new byte[ MAX_UNIT_INKER ];
            /// <summary>Feeder Position</summary>
            public byte[]  aybyFeederPos = new byte[ MAX_UNIT_INKER ]; 
            /// <summary>what is my order within the web?</summary>
            public int iUnitSequenceInWeb;
            /// <summary>-1=Unknown, 0=Offset, 1=10-Side, 2=13-Side</summary>
            public int iDirectUnit;
            /// <summary>Broadsheet definitions (768 bytes)</summary>
            public IMPOSITION_BROADSHEET[,,] ayBroadsheets = new IMPOSITION_BROADSHEET[ MAX_UNIT_INKER, BROADSHEETS_AROUND, BROADSHEETS_ACROSS ];
            /// <summary>Former defintions (176 bytes)</summary>
            public IMPOSITION_UNIT_FORMER[] ayFormers = new IMPOSITION_UNIT_FORMER[ MAX_FORMERS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Web Path interface data
        /// (Original import data size is 8972 bytes)
        /// </summary>
        public class IMPOSITION_WEB_PATH
        {
            /// <summary>Drawing color</summary>
            public uint    crefPenColor;
            /// <summary>Feeder Position</summary>
            public int     iFeederPos; 
            /// <summary>unknown</summary>
            public uint[,] aybUnitArray = new uint[ MAX_ROWS, MAX_COLUMNS ];
            /// <summary>unknown</summary>
            public int[,]  ayiUnitEntryType = new int[ MAX_ROWS, MAX_COLUMNS ];
            /// <summary>Number of active Point definitions</summary>
            public uint    dwpPointCount;
            /// <summary>Point data (original data is 2 LONGS or 2 signed 32-bit integers, or 8 bytes each POINT)</summary>
            public Point[] ayPoints = new Point[ MAX_WEB_PATH_POINTS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library Plate Layout interface data
        /// (Original import data size is 128 bytes)
        /// </summary>
        public class IMPOSITION_PLATE_LAYOUT
        {
            /// <summary>Broadsheet data</summary>
            public IMPOSITION_BROADSHEET[,] ayBroadsheets = new IMPOSITION_BROADSHEET[ BROADSHEETS_AROUND * BROADSHEETS_ACROSS_PER_PLATE, MAX_WEB_SIDES ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library WEB and PRS file interface data
        /// (Original import data size is 119878 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_WEB_PRS
        {
            /// <summary>Base Line</summary>
            public short  sNumBaseLine;
            /// <summary>Number of plates around</summary>
            public short  sNumPlateAround;
            /// <summary>0=Single, 1=Double, 2=Tripple plates accross</summary>
            public short  sNumPlateAcross;
            /// <summary>TRUE if left is to gear on 10-side</summary>
            public uint   bLeftToGear10;
            /// <summary>TRUE if left is to gear on 13-side</summary>
            public uint   bLeftToGear13;
            /// <summary>0=10-side, 1=13-side -AND- 0=RightToLeft, 1=LeftToRight</summary>
            public uint[] aybZoneOrient = new uint[ MAX_WEB_SIDES ];
            /// <summary>tower number, init to 0s</summary>
            public int[]  ayiTowerNums = new int[ MAX_COLUMNS ];
            /// <summary>Unit Definitions</summary>
            public IMPOSITION_UNIT[,] ayUnits = new IMPOSITION_UNIT[ MAX_ROWS, MAX_COLUMNS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library PRS file interface data
        /// (Original import data size is 120156 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_PRS
        {
            /// <summary>Current Version</summary>
            public int    iCurVersion;
            /// <summary>Press Description</summary>
            public string strPressDescription;
            /// <summary>Press Type</summary>
            public string strPressType;
            /// <summary>TRUE (1) if Auto Label Mode</summary>
            public uint[] aybAutoLabelMode = new uint[ NUM_LABEL_TYPES ];
            /// <summary>Label Table</summary>
            public int[]  ayiLabelTable = new int[ MAX_COLUMNS ];
            /// <summary>0=Tower Inker, 1=Tower Inker Side</summary>
            public int    iInkerLabelMode;
            /// <summary>Press width</summary>
            public short  sPressWidth;
            /// <summary>Data common between .WEB and .PRS files</summary>
            public IMPOSITION_IMPORT_WEB_PRS webprsData = new IMPOSITION_IMPORT_WEB_PRS();
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library IMP file interface data
        /// (Original import data size is 59238 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_IMP
        {
            /// <summary>Imposition Version</summary>
            public ushort wImpVersion;
            /// <summary>Imposition Number</summary>
            public int    lImpNumber; 
            /// <summary>Imposition Description</summary>
            public string strDescription;
            /// <summary>Special Colors</summary>
            public uint[] crfSpecialColor = new uint[ NUM_SPECIAL_COLORS ];
            /// <summary>Folder Numbers</summary>
            public byte[] aybyFolderNum = new byte[ MAX_NUM_WEBS ];
            /// <summary>Inker Definitions</summary>
            public IMPOSITION_INKER[] ayInkers = new IMPOSITION_INKER[ MAX_TOTAL_INKER ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library IMP file description interface data
        /// (Original import data size is 86 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_IMP_DESCRIPTION
        {
            /// <summary>Imposition Version</summary>
            public ushort wImpVersion;
            /// <summary>Imposition Number</summary>
            public int    lImpNumber;
            /// <summary>Imposition Description</summary>
            public string strDescription;
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library WEB file interface data
        /// (Original import data size is 318458 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_WEB
        {
            /// <summary>Doc Version</summary>
            public uint    dwDocVersion;
            /// <summary>TRUE if cell is used</summary>
            public uint[,] aybCellIsUsed = new uint[ MAX_ROWS, MAX_COLUMNS ];
            /// <summary>unknown</summary>
            public int[]   ayiLineCounter = new int[ MAX_COLUMNS ];
            /// <summary>Description</summary>
            public string  strDescription;
            /// <summary>Imposition Number</summary>
            public int     lImpNumber;
            /// <summary>Press Type</summary>
            public short   sPressType;
            /// <summary>Feeder Position</summary>
            public short   sFeederPos;
            /// <summary>0=Panorama, 1=Broadsheet, 2=Tabloid, 3=Magazine, 4=Digest</summary>
            public short   sPageSize;
            /// <summary>0=Collect, 1=Straight</summary>
            public short   sPageType;
            /// <summary>Number of active Web Path definitions</summary>
            public uint    dwpWebPathCount;
            /// <summary>Web Path data</summary>
            public IMPOSITION_WEB_PATH[]      webPath = new IMPOSITION_WEB_PATH[ MAX_NUM_WEBS ];
            /// <summary>Plate layout data</summary>
            public IMPOSITION_PLATE_LAYOUT[,] plateID = new IMPOSITION_PLATE_LAYOUT[ 2 * MAX_COLUMNS, PLATE_ACROSS ];     
            /// <summary>Data common between .WEB and .PRS files</summary>
            public IMPOSITION_IMPORT_WEB_PRS webprsData = new IMPOSITION_IMPORT_WEB_PRS();
            /// <summary>Special Colors</summary>
            public uint[] crfSpecialColor = new uint[ NUM_SPECIAL_COLORS ];
        };

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Imposition Import Library WEB file description interface data
        /// (Original import data size is 660 bytes)
        /// </summary>
        public class IMPOSITION_IMPORT_WEB_DESCRIPTION
        {
            /// <summary>Doc Version</summary>
            public UInt32  dwDocVersion;
            /// <summary>TRUE (1) if cell is used</summary>
            public UInt32[,] aybCellIsUsed = new UInt32[ MAX_ROWS, MAX_COLUMNS ];
            /// <summary>unknown</summary>
            public Int32[]  ayiLineCounter = new Int32[ MAX_COLUMNS ];
            /// <summary>Description</summary>
            public string strDescription;
        };

        #endregion

        ////////////////////////////////////////////////////////////////////////
        //
        //  INTERFACE METHODS
        //

        #region Imported Methods

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Exported method to Read the .PRS file into the Imposition Import Library object
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        [DllImport( "ImpositionImport.dll", EntryPoint = "_ReadPRSData@8" )]
        public static extern eIMPORT_ERRORS ReadPRSData( string strPathname, byte[] importData );

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Exported method to Read the .IMP file into the Imposition Import Library object
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        [DllImport( "ImpositionImport.dll", EntryPoint = "_ReadIMPData@8" )]
        public static extern eIMPORT_ERRORS ReadIMPData( string strPathname, byte[] importData );

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Exported method to Read the .WEB file into the Imposition Import Library object
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        [DllImport( "ImpositionImport.dll", EntryPoint = "_ReadWEBData@8" )]
        public static extern eIMPORT_ERRORS ReadWEBData( string strPathname, byte[] importData );

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Gets the .PRS data from the supplied file
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        [DllImport( "ImpositionImport.dll", EntryPoint="_GetIMPDescription@8" )]
        public static extern eIMPORT_ERRORS GetIMPDescription( string strPathname, byte[] importData );

        /// <author>Don Gerber</author><date>01-27-2015</date>
        /// <summary>
        /// Gets the .PRS data from the supplied file
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        [DllImport( "ImpositionImport.dll", EntryPoint="_GetWEBDescription@8" )]
        public static extern eIMPORT_ERRORS GetWEBDescription( string strPathname, byte[] importData );

        #endregion

        #region Primary Conversion Methods

        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Reads the Imposition PRS File
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS ReadPRSData( string strPathname, IMPOSITION_IMPORT_PRS importData )
        {
            // Allocate import data
            byte[] prsData = new byte[ IMPORT_PRS_SIZE ];
            if( prsData == null )
                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;
            
            // Prep pathname for library interface
            if( strPathname.Length < ImpositionImport_API.IMPOSITION_PATHNAME_LTH )
                strPathname = strPathname.PadRight( ImpositionImport_API.IMPOSITION_PATHNAME_LTH, ' ' );

            // Make call to Imposition Import Library
            retCode = ReadPRSData( strPathname, prsData );

            // Convert buffer data object
            if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
            {
                int iIndex = 0;

                importData.iCurVersion = BitConverter.ToInt32( prsData, iIndex );
                iIndex += 4;

                string strTemp = ByteArrayASCIIZ2String( ref prsData, iIndex, MAX_DESCRIPTION_LEN );
                importData.strPressDescription = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;
                
                strTemp = ByteArrayASCIIZ2String( ref prsData, iIndex, MAX_DESCRIPTION_LEN );
                importData.strPressType = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;

                for( int iLabel = 0; iLabel < NUM_LABEL_TYPES; iLabel++ )
                {
                    importData.aybAutoLabelMode[ iLabel ] = BitConverter.ToUInt32( prsData, iIndex );
                    iIndex += 4;
                }

                for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                {
                    importData.ayiLabelTable[ iCol ] = BitConverter.ToInt32( prsData, iIndex );
                    iIndex += 4;
                }

                importData.iInkerLabelMode = BitConverter.ToInt32( prsData, iIndex );
                iIndex += 4;

                importData.sPressWidth = BitConverter.ToInt16( prsData, iIndex );
                iIndex += 2;

                retCode = ConvertImpositionImportWebPrs( prsData, iIndex, importData.webprsData );
            }

            return retCode;
        }

        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Reads the Imposition IMP File
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS ReadIMPData( string strPathname, IMPOSITION_IMPORT_IMP importData )
        {
            // Allocate import data
            byte[] impData = new byte[ IMPORT_IMP_SIZE ];
            if( impData == null )
                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;

            // Prep pathname for library interface
            if( strPathname.Length < ImpositionImport_API.IMPOSITION_PATHNAME_LTH )
                strPathname = strPathname.PadRight( ImpositionImport_API.IMPOSITION_PATHNAME_LTH, ' ' );

            // Make call to Imposition Import Library
            retCode = ReadIMPData( strPathname, impData );

            // Convert buffer data object
            if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
            {
                int iIndex = 0;

                importData.wImpVersion = BitConverter.ToUInt16( impData, iIndex );
                iIndex += 2;

                importData.lImpNumber = BitConverter.ToInt32( impData, iIndex );
                iIndex += 4;
                
                string strTemp = ByteArrayASCIIZ2String( ref impData, iIndex, MAX_DESCRIPTION_LEN );
                importData.strDescription = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;
                
                for( int iColor = 0; iColor < NUM_SPECIAL_COLORS; iColor++ )
                {
                    importData.crfSpecialColor[ iColor ] = BitConverter.ToUInt32( impData, iIndex );
                    iIndex += 4;
                }
                
                for( int iWeb = 0; iWeb < MAX_NUM_WEBS; iWeb++ )
                    importData.aybyFolderNum[ iWeb ] = impData[ iIndex++ ];
                
                for( int iInker = 0; iInker < MAX_TOTAL_INKER; iInker++ )
                {
                    importData.ayInkers[ iInker ] = new IMPOSITION_INKER();
                    if( importData.ayInkers[ iInker ] == null )
                        return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                    importData.ayInkers[ iInker ].byColor = impData[ iIndex++ ];
                    importData.ayInkers[ iInker ].byWebSide = impData[ iIndex++ ];
                    importData.ayInkers[ iInker ].byDirectInker = impData[ iIndex++ ];
                    importData.ayInkers[ iInker ].byPageFormat = impData[ iIndex++ ];
                    importData.ayInkers[ iInker ].byWebNumber = impData[ iIndex++ ];

                    for( int iAround = 0; iAround < BROADSHEETS_AROUND; iAround++ )
                    {
                        for( int iAcross = 0; iAcross < BROADSHEETS_ACROSS; iAcross++ )
                        {
                            importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ] = new IMPOSITION_BROADSHEET();
                            if( importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ] == null )
                                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                            for( int iPageAround = 0; iPageAround < PAGES_AROUND; iPageAround++ )
                            {
                                for( int iPageAcross = 0; iPageAcross < PAGES_ACROSS; iPageAcross++ )
                                {
                                    importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ].ayPages[ iPageAround, iPageAcross ] = new IMPOSITION_BROADSHEET_PLATE();
                                    if( importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ].ayPages[ iPageAround, iPageAcross ] == null )
                                        return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                                    importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ].ayPages[ iPageAround, iPageAcross ].wSection = BitConverter.ToUInt16( impData, iIndex );
                                    iIndex += 2;

                                    importData.ayInkers[ iInker ].ayBroadsheets[ iAround, iAcross ].ayPages[ iPageAround, iPageAcross ].wPage = BitConverter.ToUInt16( impData, iIndex );
                                    iIndex += 2;
                                }
                            }
                        }
                    }
                }
            }

            return retCode;
        }
        
        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Reads the Imposition WEB File
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS ReadWEBData( string strPathname, IMPOSITION_IMPORT_WEB importData )
        {
            // Allocate import data
            byte[] webData = new byte[ IMPORT_WEB_SIZE ];
            if( webData == null )
                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;

            // Prep pathname for library interface
            if( strPathname.Length < ImpositionImport_API.IMPOSITION_PATHNAME_LTH )
                strPathname = strPathname.PadRight( ImpositionImport_API.IMPOSITION_PATHNAME_LTH, ' ' );

            // Make call to Imposition Import Library
            retCode = ReadWEBData( strPathname, webData );

            // Convert buffer data object
            if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
            {
                int iIndex = 0;

                importData.dwDocVersion = BitConverter.ToUInt16( webData, iIndex );
                iIndex += 4;

                for( int iRow = 0; iRow < MAX_ROWS; iRow++ )
                {
                    for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                    {
                        importData.aybCellIsUsed[ iRow, iCol ] = BitConverter.ToUInt32( webData, iIndex );
                        iIndex += 4;
                    }
                }

                for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                {
                    importData.ayiLineCounter[ iCol ] = BitConverter.ToInt32( webData, iIndex );
                    iIndex += 4;
                }

                string strTemp = ByteArrayASCIIZ2String( ref webData, iIndex, MAX_DESCRIPTION_LEN );
                importData.strDescription = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;

                importData.lImpNumber = BitConverter.ToInt32( webData, iIndex );
                iIndex += 4;

                importData.sPressType = BitConverter.ToInt16( webData, iIndex );
                iIndex += 2;

                importData.sFeederPos = BitConverter.ToInt16( webData, iIndex );
                iIndex += 2;

                importData.sPageSize = BitConverter.ToInt16( webData, iIndex );
                iIndex += 2;

                importData.sPageType = BitConverter.ToInt16( webData, iIndex );
                iIndex += 2;

                importData.dwpWebPathCount = BitConverter.ToUInt32( webData, iIndex );
                iIndex += 4;

                for( int iWeb = 0; iWeb < MAX_NUM_WEBS; iWeb++ )
                {
                    importData.webPath[ iWeb ] = new IMPOSITION_WEB_PATH();
                    if( importData.webPath[ iWeb ] == null )
                        return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                    importData.webPath[ iWeb ].crefPenColor = BitConverter.ToUInt32( webData, iIndex );
                    iIndex += 4;

                    importData.webPath[ iWeb ].iFeederPos = BitConverter.ToInt32( webData, iIndex );
                    iIndex += 4;

                    for( int iRow = 0; iRow < MAX_ROWS; iRow++ )
                    {
                        for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                        {
                            importData.webPath[ iWeb ].aybUnitArray[ iRow, iCol ] = BitConverter.ToUInt32( webData, iIndex );
                            iIndex += 4;
                        }
                    }

                    for( int iRow = 0; iRow < MAX_ROWS; iRow++ )
                    {
                        for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                        {
                            importData.webPath[ iWeb ].ayiUnitEntryType[ iRow, iCol ] = BitConverter.ToInt32( webData, iIndex );
                            iIndex += 4;
                        }
                    }

                    importData.webPath[ iWeb ].dwpPointCount = BitConverter.ToUInt32( webData, iIndex );
                    iIndex += 4;

                    for( int iPoint = 0; iPoint < MAX_WEB_PATH_POINTS; iPoint++ )
                    {
                        importData.webPath[ iWeb ].ayPoints[ iPoint ] = new Point();
                        if( importData.webPath[ iWeb ].ayPoints[ iPoint ] == null )
                            return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                        importData.webPath[ iWeb ].ayPoints[ iPoint ].X = BitConverter.ToInt32( webData, iIndex );
                        iIndex += 4;

                        importData.webPath[ iWeb ].ayPoints[ iPoint ].Y = BitConverter.ToInt32( webData, iIndex );
                        iIndex += 4;
                    }
                }

                for( int iCol = 0; iCol < (2 * MAX_COLUMNS); iCol++ )
                {
                    for( int iAcross = 0; iAcross < PLATE_ACROSS; iAcross++ )
                    {
                        importData.plateID[ iCol, iAcross ] = new IMPOSITION_PLATE_LAYOUT();
                        if( importData.plateID[ iCol, iAcross ] == null )
                            return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                        for( int iAround = 0; iAround < (BROADSHEETS_AROUND * BROADSHEETS_ACROSS_PER_PLATE); iAround++ )
                        {
                            for( int iSide = 0; iSide < MAX_WEB_SIDES; iSide++ )
                            {
                                importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ] = new IMPOSITION_BROADSHEET();
                                if( importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ] == null )
                                    return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;


                                for( int iPageAround = 0; iPageAround < PAGES_AROUND; iPageAround++ )
                                {
                                    for( int iPageAcross = 0; iPageAcross < PAGES_ACROSS; iPageAcross++ )
                                    {
                                        importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ].ayPages[ iPageAround, iPageAcross ] = new IMPOSITION_BROADSHEET_PLATE();
                                        if( importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ].ayPages[ iPageAround, iPageAcross ] == null )
                                            return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                                        importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ].ayPages[ iPageAround, iPageAcross ].wSection = BitConverter.ToUInt16( webData, iIndex );
                                        iIndex += 2;

                                        importData.plateID[ iCol, iAcross ].ayBroadsheets[ iAround, iSide ].ayPages[ iPageAround, iPageAcross ].wPage = BitConverter.ToUInt16( webData, iIndex );
                                        iIndex += 2;
                                    }
                                }

                            }
                        }
                    }
                }

                retCode = ConvertImpositionImportWebPrs( webData, iIndex, importData.webprsData );

                if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
                {
                    for( int iColor = 0; iColor < NUM_SPECIAL_COLORS; iColor++ )
                    {
                        importData.crfSpecialColor[ iColor ] = BitConverter.ToUInt32( webData, iIndex );
                        iIndex += 4;
                    }
                }
            }

            return retCode;
        }

        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Gets the Imposition IMP Description data
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS GetIMPDescription( string strPathname, IMPOSITION_IMPORT_IMP_DESCRIPTION importData )
        {
            // Allocate import data
            byte[] impDesc = new byte[ IMPORT_IMP_DESCRIPTION_SIZE ];
            if( impDesc == null )
                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;

            // Prep pathname for library interface
            if( strPathname.Length < ImpositionImport_API.IMPOSITION_PATHNAME_LTH )
                strPathname = strPathname.PadRight( ImpositionImport_API.IMPOSITION_PATHNAME_LTH, ' ' );

            // Make call to Imposition Import Library
            retCode = GetIMPDescription( strPathname, impDesc );

            // Convert buffer data object
            if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
            {
                int iIndex = 0;

                importData.wImpVersion = BitConverter.ToUInt16( impDesc, iIndex );
                iIndex += 2;

                importData.lImpNumber = BitConverter.ToInt32( impDesc, iIndex );
                iIndex += 4;

                string strTemp = ByteArrayASCIIZ2String( ref impDesc, iIndex, MAX_DESCRIPTION_LEN );
                importData.strDescription = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;
            }

            return retCode;
        }

        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Gets the Imposition WEB Description data
        /// </summary>
        /// <param name="strPathname">File Pathname</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS GetWEBDescription( string strPathname, IMPOSITION_IMPORT_WEB_DESCRIPTION importData )
        {
            // Allocate import data
            byte[] webDesc = new byte[ IMPORT_WEB_DESCRIPTION_SIZE ];
            if( webDesc == null )
                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;

            // Prep pathname for library interface
            if( strPathname.Length < ImpositionImport_API.IMPOSITION_PATHNAME_LTH )
                strPathname = strPathname.PadRight( ImpositionImport_API.IMPOSITION_PATHNAME_LTH, ' ' );

            // Make call to Imposition Import Library
            retCode = GetWEBDescription( strPathname, webDesc );

            // Convert buffer data object
            if( retCode == eIMPORT_ERRORS.eIMPORT_ERR_NONE )
            {
                int iIndex = 0;

                importData.dwDocVersion = BitConverter.ToUInt16( webDesc, iIndex );
                iIndex += 4;

                for( int iRow = 0; iRow < MAX_ROWS; iRow++ )
                {
                    for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                    {
                        importData.aybCellIsUsed[ iRow, iCol ] = BitConverter.ToUInt32( webDesc, iIndex );
                        iIndex += 4;
                    }
                }

                for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                {
                    importData.ayiLineCounter[ iCol ] = BitConverter.ToInt32( webDesc, iIndex );
                    iIndex += 4;
                }

                string strTemp = ByteArrayASCIIZ2String( ref webDesc, iIndex, MAX_DESCRIPTION_LEN );
                importData.strDescription = strTemp.TrimEnd();
                iIndex += MAX_DESCRIPTION_LEN;
            }

            return retCode;
        }


        #endregion

        #region Support Methods

        /// <author>Don Gerber</author><date>09-10-05</date>
        /// <summary>
        /// Converts byte array representing ASCIIZ string, to a string
        /// </summary>
        /// <param name="data">Byte Array</param>
        /// <param name="iIndex">Starting Index</param>
        /// <param name="iLength">Length of String</param>
        /// <returns>ASCIIZ in string</returns>
        public string ByteArrayASCIIZ2String( ref byte[] data, int iIndex, int iLength )
        {
            bool found = false;
            byte[] byString = new byte[ iLength ];

            for( int loop = 0; loop < iLength; ++loop )
            {
                // Copy original
                byString[ loop ] = data[ iIndex + loop ];

                // Look for ASCIIZ Terminator
                if( byString[ loop ] == 0 )
                    found = true;

                // Fill remainder with spaces
                if( found )
                    byString[ loop ] = 0x20;
            }

            return Encoding.ASCII.GetString( byString );
        }

        /// <author>Don Gerber</author><date>01-28-2015</date>
        /// <summary>
        /// Converts the Imposition Import WEB and PRS data
        /// </summary>
        /// <param name="data">Library Source Data</param>
        /// <param name="iIndex">Source Data Index</param>
        /// <param name="importData">File Data [OUT]</param>
        /// <returns>Error Code</returns>
        public eIMPORT_ERRORS ConvertImpositionImportWebPrs( byte[] data, int iIndex, IMPOSITION_IMPORT_WEB_PRS importData )
        {
            eIMPORT_ERRORS retCode = eIMPORT_ERRORS.eIMPORT_ERR_NONE;

            importData.sNumBaseLine = BitConverter.ToInt16( data, iIndex );
            iIndex += 2;

            importData.sNumPlateAround = BitConverter.ToInt16( data, iIndex );
            iIndex += 2;

            importData.sNumPlateAcross = BitConverter.ToInt16( data, iIndex );
            iIndex += 2;

            importData.bLeftToGear10 = BitConverter.ToUInt32( data, iIndex );
            iIndex += 4;

            importData.bLeftToGear13 = BitConverter.ToUInt32( data, iIndex );
            iIndex += 4;

            for( int iSide = 0; iSide < MAX_WEB_SIDES; iSide++ )
            {
                importData.aybZoneOrient[ iSide ] = BitConverter.ToUInt32( data, iIndex );
                iIndex += 4;
            }

            for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
            {
                importData.ayiTowerNums[ iCol ] = BitConverter.ToInt32( data, iIndex );
                iIndex += 4;
            }

            string strTemp;

            for( int iRow = 0; iRow < MAX_ROWS; iRow++ )
            {
                for( int iCol = 0; iCol < MAX_COLUMNS; iCol++ )
                {
                    importData.ayUnits[ iRow, iCol ] = new IMPOSITION_UNIT();
                    if( importData.ayUnits[ iRow, iCol ] == null )
                        return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                    importData.ayUnits[ iRow, iCol ].sUnitType = BitConverter.ToInt16( data, iIndex );
                    iIndex += 2;

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                    {
                        strTemp = ByteArrayASCIIZ2String( ref data, iIndex, MAX_INKER_LABEL_LEN );
                        importData.ayUnits[ iRow, iCol ].aybyInkerLabels[ iInker ] = strTemp.TrimEnd();
                        iIndex += MAX_INKER_LABEL_LEN;
                    }

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                    {
                        importData.ayUnits[ iRow, iCol ].aysInkerColors[ iInker ] = BitConverter.ToInt16( data, iIndex );
                        iIndex += 2;
                    }

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                    {
                        importData.ayUnits[ iRow, iCol ].aysWebSide[ iInker ] = BitConverter.ToInt16( data, iIndex );
                        iIndex += 2;
                    }

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                        importData.ayUnits[ iRow, iCol ].aybyDirectInk[ iInker ] = data[ iIndex++ ];

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                        importData.ayUnits[ iRow, iCol ].aybyFeederPos[ iInker ] = data[ iIndex++ ];

                    importData.ayUnits[ iRow, iCol ].iUnitSequenceInWeb = BitConverter.ToInt32( data, iIndex );
                    iIndex += 4;

                    importData.ayUnits[ iRow, iCol ].iDirectUnit = BitConverter.ToInt32( data, iIndex );
                    iIndex += 4;

                    for( int iInker = 0; iInker < MAX_UNIT_INKER; iInker++ )
                    {
                        for( int iAround = 0; iAround < BROADSHEETS_AROUND; iAround++ )
                        {
                            for( int iAcross = 0; iAcross < BROADSHEETS_ACROSS; iAcross++ )
                            {
                                importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ] = new IMPOSITION_BROADSHEET();
                                if( importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ] == null )
                                    return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                                for( int iPageAround = 0; iPageAround < PAGES_AROUND; iPageAround++ )
                                {
                                    for( int iPageAcross = 0; iPageAcross < PAGES_ACROSS; iPageAcross++ )
                                    {
                                        importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ].ayPages[ iPageAround, iPageAcross ] = new IMPOSITION_BROADSHEET_PLATE();
                                        if( importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ].ayPages[ iPageAround, iPageAcross ] == null )
                                            return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                                        importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ].ayPages[ iPageAround, iPageAcross ].wSection = BitConverter.ToUInt16( data, iIndex );
                                        iIndex += 2;

                                        importData.ayUnits[ iRow, iCol ].ayBroadsheets[ iInker, iAround, iAcross ].ayPages[ iPageAround, iPageAcross ].wPage = BitConverter.ToUInt16( data, iIndex );
                                        iIndex += 2;
                                    }
                                }

                            }
                        }
                    }

                    for( int iFormer = 0; iFormer < MAX_FORMERS; iFormer++ )
                    {
                        importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ] = new IMPOSITION_UNIT_FORMER();
                        if( importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ] == null )
                            return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                        importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ].iWebPathCount = BitConverter.ToInt32( data, iIndex );
                        iIndex += 4;

                        for( int iWeb = 0; iWeb < MAX_NUM_WEBS; iWeb++ )
                        {
                            importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ].webFeeders[ iWeb ] = new IMPOSITION_UNIT_FORMER_WEB_PATH();
                            if( importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ].webFeeders[ iWeb ] == null )
                                return eIMPORT_ERRORS.eIMPORT_ERR_MEMORY;

                            importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ].webFeeders[ iWeb ].byFeederNumber = data[ iIndex++ ];
                            importData.ayUnits[ iRow, iCol ].ayFormers[ iFormer ].webFeeders[ iWeb ].byWebPathDir = data[ iIndex++ ];
                        }
                    }
                }
            }

            return retCode;
        }

        #endregion

    }
}
