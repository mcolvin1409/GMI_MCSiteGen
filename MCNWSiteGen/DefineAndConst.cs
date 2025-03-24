/////////////////////////////////////////////////////////////////////////////
//  
// DefineAndConst.cs: Constants declaration
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/DefineAndConst.cs-arc   1.23   Jul 26 2011 12:26:02   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/DefineAndConst.cs-arc  $
///  
///     Rev 1.23   Jul 26 2011 12:26:02   MColvin
///  MT 17082, 17103 - max sweep turns and funny fountain key count and key width validation.
///  
///     Rev 1.22   Jul 21 2011 14:47:00   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.21   Apr 26 2011 09:53:46   SBabu
///  Added support for 20 SPUs and more than 40 inkers
///  
///     Rev 1.20   Jan 12 2011 05:00:50   HNarala
///  Mercury Client: Implement password protection access to diagnostic operations from Client
///  
///     Rev 1.19   Dec 13 2010 02:08:26   HNarala
///  Mercury SiteGen: Configure password protection access to diagnostic operations from Client
///  
///     Rev 1.18   Dec 10 2010 04:27:14   HNarala
///  MC3 Client - Turkish language support
///  
///     Rev 1.17   Oct 25 2010 01:21:50   SBabu
///  16544: Support inkers upto 32 (DCOS requirement)
///  
///     Rev 1.16   May 26 2010 01:32:22   SRajarapu
///  15752: Localization support for French language.
///  
///     Rev 1.15   Apr 08 2010 23:39:20   HNarala
///  to support localization
///  
///     Rev 1.14   Mar 26 2010 00:06:08   SSomashekaran
///  MC3 - MC3SiteGen - Add Crabtree ducting support via serial Mits PLC
///  
///     Rev 1.13   Mar 12 2010 00:09:06   SRajarapu
///  15258: Client 1.19 crashes with the attached site file.
///  
///     Rev 1.12   Mar 04 2010 04:39:32   HNarala
///  To fix 15342, 45333
///  
///     Rev 1.11   Feb 17 2010 00:41:36   SRajarapu
///  15094: Wide Press: With the attached site file, extra Unit/Inker displayed from Units, Status and Thumbnail views.
///  
///     Rev 1.10   Jan 24 2010 23:44:32   HNarala
///  to fix 15015,15017
///  
///     Rev 1.9   Sep 02 2009 08:23:40   HNarala
///  to Implement support for 64 zones per Inker
///  
///     Rev 1.8   Aug 07 2009 05:50:32   HNarala
///  13972: MC3SiteGen: Modify the CIP3 and CIP3 Image path to set manually
///  
///     Rev 1.7   May 27 2009 06:03:04   HNarala
///  to support Auto scan cal feature
///  
///     Rev 1.6   May 14 2009 03:51:20   HNarala
///  for mt 13162
///  
///     Rev 1.5   Feb 19 2009 01:25:58   HNarala
///  MC3 System Weird behavior.
///  
///     Rev 1.4   Jan 29 2009 18:41:10   HNarala
///  to fix the validation
///  
///     Rev 1.3   Jan 21 2009 17:46:36   HQi
///  Inker table enhancement
///  
///     Rev 1.2   Jan 19 2009 18:26:10   HQi
///  Add inker properties table
///  
///     Rev 1.1   Nov 12 2008 21:37:58   HNarala
///  for the screen resolution of 1440 X 900
///  
///     Rev 1.0   03 Oct 2008 14:42:02   knadler
///  Initial revision.
///  Resolution for 11396: Create MC3 Siteset application
///  16-Dec-14, spa, WI 51029 Add support for Tower mode.
// 
//
/////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace MCNWSiteGen
{
    public enum enPressTypes
    {
        UNITIZED_WEB_PRESS_NO_TURNBAR,
        UNITIZED_WEB_PRESS_WITH_TURNBAR,
        SHEET_FED_PRESS,
        SINGLE_WEB_PRESS,
        MULTI_WEB_PRESS, // WI30347
        NEWSPAPER_PRESS,
        TOWER_PRESS,
        SINGLE_SIDED_CIC_PRESS,   // WI177003
        UNKNOWN_PRESS_TYPE = 255
    }
    public enum UnitTypes
    {
        UNIT_TYPE_MM = 0,
        UNIT_TYPE_CMS = 1,
        UNIT_TYPE_INCHS = 2
    };
    public enum ScanSweep
    {
        NONE,
        SCAN_SWEEP_DEFAULT,
        SCAN_SWEEP_ADJUST,
        SCAN_SWEEP_RETAIN
    };
    public enum WebType
    {
        SHEETFED,
        SINGLE_WEB_PRESS,
        TWO_WEB_SPLIT_PRESS
    };
    class DefineAndConst
    {
        //public enum enPressTypes
        //{
        //    UNITIZED_WEB_PRESS_NO_TURNBAR,
        //    UNITIZED_WEB_PRESS_WITH_TURNBAR,
        //    SHEET_FED_PRESS,
        //    SINGLE_WEB_PRESS,
        //    MULTI_WEB_PRESS,
        //    NEWSPAPER_PRESS,
        //    UNKNOWN_PRESS_TYPE = 255
        //}
        //public enum UnitTypes
        //{
        //    UNIT_TYPE_MM = 0,
        //    UNIT_TYPE_CMS = 1,
        //    UNIT_TYPE_INCHS = 2
        //};

        /// <![CDATA[
        /// Author: unknown
        /// 
        /// History: Sep-02-2010, Hema Kumar, ENH 16257
        /// 16-Dec-14, spa, WI 51029 Add support for Tower mode.
        /// ]]>
        /// <summary>
        /// Holds the string constant information
        /// </summary>
        public class StringConstant
        {
            public const string UNITIZED_WEB_PRESS_NO_TURNBAR = "Unitized Web Press Without Turnbar";
            public const string UNITIZED_WEB_PRESS_WITH_TURNBAR = "Unitized Web Press With Turnbar";
            public const string SHEET_FED_PRESS = "Sheet fed Press";
            public const string SINGLE_WEB_PRESS = "Single Web Press";
            public const string MULTI_WEB_PRESS = "Dual / Multi Web Press"; // WI30347
            public const string NEWSPAPER_PRESS = "Newspaper Press";
            public const string UNKNOWN_PRESS_TYPE = "Unknown Press Type";
            public const string TOWER_PRESS_TYPE = "Tower Press";
            public const string SINGLE_SIDED_CIC_PRESS = "Single Sided CIC";  // WI177003
            public const string MM = "mm";
            public const string INCHE = "inches";
            public const string CMS = "cms";
            public const string Rail1 = " - Rail 1";
            public const string Rail2 = " - Rail 2";
            public const string PLC_NILPETER = "Nilpeter";//Added by Sreejit for MT#15294
            public const string PLC_CRABTREE = "Crabtree";//Added by Sreejit for MT#15294
            public const string PLC_DTOA = "Digital to Analog";  //Added by Mark C for MT#16792
            public const string PLC_RAGSDALE = "Ragsdale";       //Added by Mark C for MT#16792
            public const string PLC_AB_PLC5 = "Allen Bradley";       //Added by Mark C for WI29958
            public const string PLC_HO_MOTOR = "HO + Motor";
            public const string PLC_HO_DTOA = "HO + D to A";
            public const string PLC_TI = "Texas Instruments"; // WI#35675
            public const string PLC_AVT = "AVT PLC";   // WI102725
            public const string PASSWORD_SEC_KEY = "AVT-GMI@DSI";
            public const string DEFAULT_RUNTIME_PASSWORD = "386192";
            public const string DEFAULT_EXIT_PASSWORD = "408397";
            public const string DEFAULT_CONFIGURATON_PASSWORD = "183694";
            public const string DEFAULT_DIAGNOSTIC_PASSWORD = "574068";
            public const string NA = "NA";
        }
        public class SystemCapacities
        {
            public const byte CQ_MAX_FOUNTAIN_KEYS = 80;
            public const byte MAX_UNITS_PER_GROUP = 16;
            //16981: Support inkers upto 96 (48 inkers on each surface)
            public const byte MAX_SPUS_PER_AS = 20;     //18059  12 x 8 = 96 rails   max 12 serial ports on 2U dual core
            public const byte MAX_PRESS_FEEDERS = 10;
            public const byte CQ_MAX_PRESS_FOLDERS = 10;
            //16981: Support inkers upto 96 (48 inkers on each surface)
            public const byte CQ_MAX_FOUNTAINS = 128;   //18059 same as above
            public const byte MAX_SIDES = 2;
            public const byte MAX_NUM_DISPLAY_INKERS = 14;
            public const int ZONE_VALUE_CHANGE_STOPPED_TIME_OUT = 500;     //If user stopped making change for 0.5sec, the values changed will be sent to server
            public const int ZONE_VALUE_CHANGING_TIME_OUT = 1000;          //If user keeps changing 1 sec, the value changed will be sent to server
            public const int INTERVAL_CHECKING_INC_DEC_BUTTON_STATUS = 125; //check the time after button pressed down 
            public const int MAX_INKER_BANKS = 2;
            public const int MIN_OFFSET = 0;
            public const int MAX_OFFSET = 50;
            public const int MAX_SERVOCONSOLE_VALUE = 149;
            public const int ZERO_OFFSET = 0;
            //SITE CONFIGURATION
            public const float MAX_KEY_TURNS = 8.0F;    //20250207 Mark max was 2.0, now 8.0 - fountain key max
            public const float MIN_KEY_TURNS = 0.1F;
            public const int NON_LINEARITY_TYPE1 = 150; 
            public const int NON_LINEARITY_TYPE2 = 200;
            public const int NON_LINEARITY_NO_NFS = 100;
            public const int NFS_TABLE_BREAK_POINT = 50;
            public const int WIDEPRESS_MIN_KEYS = 45;
            public const int WIDEPRESS_MAX_KEYS = 80;
            public const int MAX_KEYS_DISPLAY_ON_CLIENT = 40;
            // 
            public const double MAX_SERVO_TURNS = 2.95;     //SPU sweep servo max turns
            public const double MIN_SERVO_TURNS = 0.20;     //SPU sweep servo min turns
            public const double DEFAULT_SERVO_TURNS = 0.0;  //SPU sweep turns default
            public const int MAX_SWEEP_MOTOR_TURNS = 60;   //MT17082 markc jul 22, 2011  no more than 60 for any assy
            public const int MAX_WATER_MOTOR_TURNS = 60;    //SPU sweep controller turns max
            // PLC paramter limits
            // MT16792 markc jun 20, 2011 - added DtoA PLC type
            public const int MAX_PLC_MECH_DELAY = 300; //PLC mech delay(ms), 0 to 300, default 200
            public const int MIN_PLC_MECH_DELAY = 0;
            public const int MAX_PLC_WASH_CYCLE = 100; //PLC wash cycle time(0.1 sec), 1 to 100, default 10
            public const int MIN_PLC_WASH_CYCLE = 1;
            public const int MAX_PLC_TACH_PULSE = 127; //PLC tach pulses per cycle, 1 to 127, default 5
            public const int MIN_PLC_TACH_PULSE = 1;
            public const int MAX_PLC_SAMPLE_TIME = 1000; //PLC encoder sample time(ms), 100 to 1000, default 250
            public const int MIN_PLC_SAMPLE_TIME = 100;
            public const int MAX_PLC_SWP_DIVISOR = 1000; //PLC sweep multiplier, 10 to 1000, default 60
            public const int MIN_PLC_SWP_DIVISOR = 10;
            public const int MAX_PLC_WTR_DIVISOR = 1000; //PLC water multiplier, 10 to 1000, default 20
            public const int MIN_PLC_WTR_DIVISOR = 10;
            public const int MAX_PLC_MIN_OUTPUT = 1000; //PLC minimum voltage , 0 to 1000, default 100 (0.5 volt)
            public const int MIN_PLC_MIN_OUTPUT = 0;
            public const int MAX_PLC_START_SPEED_MIN = 1000; //PLC water surge speed, low (RPM), 0 to 1000, default 60
            public const int MIN_PLC_START_SPEED_MIN = 0;
            public const int MAX_PLC_START_SPEED_MAX = 1000; //PLC water surge speed, high (RPM), 0 to 1000, default 400
            public const int MIN_PLC_START_SPEED_MAX = 0;
            public const int MAX_PLC_START_SPEED_VOLT = 2000; //PLC water surge voltage, 0 to 2000, default 1000 (5 volts)
            public const int MIN_PLC_START_SPEED_VOLT = 0;
            public const int MAX_PLC_NL_CURVE = 4;      //PLC NL Curve, 0 to 4, default 2
            public const int MIN_PLC_NL_CURVE = 0;
            public const int MAX_PLC_MOTOR_SPEED = 30;  //PLC motor speed, 0 to 30, default 15
            public const int MIN_PLC_MOTOR_SPEED = 0;
            public const int MIN_SWEEP_MOTOR_TURNS = 0; //SPU sweep motor
            // MarkC 11/6/12 WI29958 add AB PLC5 type 

            //Auto Scan Calibration - CIP3 Presetting           
            public const double MAX_SWEEP_ZONE_RATIO = 5.0;
            public const double MIN_SWEEP_ZONE_RATIO = 0.6;
            public const int MIN_ZONE_MARGIN = 0;           //MT18059  allow zero zones on mergins during preset
            public const int MAX_ZONE_MARGIN = 6;
            public const double MAX_EWMAFACTOR = 1.0;
            public const double MIN_EWMAFACTOR = 0.0;
            public const int MIN_SWEEP_DEFAULT = 0;
            public const int MAX_SWEEP_DEFAULT = 99;
            public const int MIN_BLADE_TOLERANCE = 0;
            public const int MAX_BLADE_TOLERANCE = 99;
            public const string CIP3_PATH = @"d:\gmi\mc3\cip3\";        //MT18059  correct default paths
            public const string CIP3_IMAGE_PATH = @"d:\gmi\mc3\CIP3Images\";
            public const int MAX_NUMBER_DIGIT = 10;
            public const int SWEEP_PORT = 7;
            public const int PASSWORD_LENGTH = 6;
            //Press Auto Zero
            public const byte MAX_AUTO_ZERO_CHANNELS = 12;//WI30488
            public const int MAX_TOWER_SPLITS = 12;

            // Register control
            public const float REGISTER_POT_FEEDBACK_MIN = 0.0f;
            public const float REGISTER_POT_FEEDBACK_MAX = 10.0f;
            public const float REGISTER_MOTOR_MIN_TRAVEL = 1.0f;
            public const float REGISTER_MOTOR_MAX_TRAVEL = 20.0f;
            public const float REGISTER_SKEW_MOTOR_MIN_TRAVEL = 0.5f;
            public const float REGISTER_SKEW_MOTOR_MAX_TRAVEL = 10.0f;
            public const int REGISTER_SLOPE_MIN = 1;
            public const int REGISTER_SLOPE_MAX = 15000;

            public const float AUTO_RUN_DELAY_TIME_MIN = 0.0f;
            public const float AUTO_RUN_DELAY_TIME_MAX = 9.9f;
            public const float AUTO_RUN_DELAY_TIME_DEF = 0.0f;

            public const int MAX_SERVOS_PER_SPU_PORT = 44;
            
        };

        public class DataFieldLength
        {
            public const byte NUM_FILTERS = 4;
            public const byte SITE_NAME_LTH = 80 + 1;
            public const byte PRESS_NAME_LTH = 16 + 1;
            public const byte UNIT_NAME_LTH_LONG = 6 + 1;
            public const byte FOUNTAIN_NAME_LTH_LONG = 16 + 1;
            public const byte INK_NAME_LTH_LONG = 32 + 1;
            public const byte SPU_NAME_LTH = 6 + 1;
            public const byte COMPORT_NAME_LTH = 8 + 1;
            public const byte LANGUAGE_LTH = 3 + 1; //(3+1)
            public const byte FILTER_NAME_LTH = 8 + 1;
            public const byte CQ_FOLDER_NAME_LTH = 5 + 1;
            public const byte CQ_FEEDER_NAME_LTH = 5 + 1;
            public const byte PRESS_UNIT_GROUP_NAME_LTH = 4 + 1;
            public const byte INK_DESC_LTH = 12 + 1;
            public const byte MC_WEB_NAME_LTH = 16 + 1;
            public const byte MC_JOB_NAME_LTH = 64 + 1;
            public const byte MC_FORM_NAME_LTH = 64 + 1;
            public const byte MC_FORM_DESCRIPTION = 22 + 1;			//SAME AS cq
            public const int MAX_PATH = 260;                        //stardard windows constant
            public const byte TURN_BAR_NAME_LTH = 12 + 1;			//

        }
        public class ControlTypes
        {
            public const byte NONE = 0;
            public const byte MOTOR = 1;
            public const byte SERVO = 2;
            public const byte BOTH_MOTOR_AND_SERVO = 3;
            public const byte PLC = 4;
            public const byte PCU = 5;
            public const byte GOSS_MPU = 6;
        }
        public class WebType
        {
            public const string SHEETFED = "SHEETFED";
            public const string SINGLE_WEB_PRESS = "SINGLE_WEB_PRESS";
            public const string TWO_WEB_SPLIT_PRESS = "TWO_WEB_SPLIT_PRESS";
        }
        public class ScanSweepAdjust
        {
            public const string SCAN_SWEEP_DEFAULT = "SCAN_SWEEP_DEFAULT";
            public const string SCAN_SWEEP_ADJUST = "SCAN_SWEEP_ADJUST";
            public const string SCAN_SWEEP_RETAIN = "SCAN_SWEEP_RETAIN";
        }
        /// <![CDATA[
        /// Author: Hema Kumar
        /// 
        /// History: 23-Mar-2010, Hema Kumar, MT14169: Created
        ///          Suresh, May-24-2009, ENH 15752
        ///          Hema Dt: Oct/12/2010 MT:16162  Turkey support
        /// ]]>
        /// <summary>
        /// Hold the Language Culture information
        /// </summary>
        public class Culture
        {
            public const string English = "English";
            public const string EnglishCultureName = "EN";
        }
    }

    /// <summary>
    /// Indicate the password type
    /// </summary> 
    public enum PasswordType { Configuration, Diagnostic, Exit, RuntimeOption };

    /// <summary>
    /// Indicate the Communication Interface Type
    /// </summary>
    public class CommType
    {
        public const string Ethernet = "ETHERNET";
        public const string Serial = "SERIAL";
    }

    /// <summary>
    /// PLC Types
    /// </summary>
    public enum ePLCType
    {
        ePLC_NILPETER = 0, 
        ePLC_CRABTREE, 
        ePLC_DTOA,
        ePLC_RAGSDALE,
        ePLC_ALLEN_BRADLEY,
        ePLC_HO_MOTOR,
        ePLC_HO_DTOA,
        ePLC_TI,
        ePLC_AVT
    }
}
