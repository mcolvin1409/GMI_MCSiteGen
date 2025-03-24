/////////////////////////////////////////////////////////////////////////////
//  
// MCSiteConfigData.cs: MC Site Config Data
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/MCSiteConfigData.cs-arc   1.28   May 11 2012 00:49:58   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/MCSiteConfigData.cs-arc  $
///  
///     Rev 1.28   May 11 2012 00:49:58   MColvin
///  MT17149 - MCSiteGen - PLC sweep - Ragsdale inkstripe
///  
///     Rev 1.27   Mar 23 2012 10:24:38   BEttinger
///  MT17624
///  
///     Rev 1.26   Mar 14 2012 09:49:16   SBabu
///  MT 17637 - Added support for configuring help path and show help options
///  
///     Rev 1.25   Feb 08 2012 11:06:54   SBabu
///  MT 17529 - Modified for Auto Zero Servo feature
///  
///     Rev 1.24   Jul 21 2011 14:47:10   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.23   Apr 15 2011 14:48:38   SBabu
///  MT-16925:Reverted changes made for OCU3 Zone width conversion to milli meters
///  
///     Rev 1.22   Jan 17 2011 00:38:58   SRajarapu
///  13878: MC3SiteGen: Implement funny Fountains support
///  
///     Rev 1.21   Dec 13 2010 02:08:54   HNarala
///  Mercury SiteGen: Configure password protection access to diagnostic operations from Client
///  
///     Rev 1.20   Aug 13 2010 00:10:32   SSomashekaran
///  MCNWSiteGen: The default System file path should be "C:\GMI\MC3\SYSTEM"
///  
///     Rev 1.19   Aug 10 2010 02:57:40   SSomashekaran
///  MC3 AS - ALL data file paths should be configurable
///  
///     Rev 1.18   Jun 10 2010 03:45:28   SRajarapu
///  15844: Invalid values displayed from 'Servo Turns' edit box while creating new site file from SiteGen application.
///  
///     Rev 1.17   May 27 2010 22:59:40   SSomashekaran
///  MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility.
///  
///     Rev 1.16   May 14 2010 01:18:30   SRajarapu
///  15456: MC3Client - Add option to rotate CIP3 image and data
///  
///     Rev 1.15   Apr 08 2010 23:39:28   HNarala
///  to support localization
///  
///     Rev 1.14   Mar 26 2010 00:06:14   SSomashekaran
///  MC3 - MC3SiteGen - Add Crabtree ducting support via serial Mits PLC
///  
///     Rev 1.13   Jan 24 2010 23:44:34   HNarala
///  to fix 15015,15017
///  
///     Rev 1.12   Sep 02 2009 08:23:50   HNarala
///  to Implement support for 64 zones per Inker
///  
///     Rev 1.11   Aug 11 2009 15:55:48   LMask
///  MT13404, Add CLC communication with CQ2
///  
///     Rev 1.10   Aug 07 2009 05:50:40   HNarala
///  13972: MC3SiteGen: Modify the CIP3 and CIP3 Image path to set manually
///  
///     Rev 1.9   Jun 04 2009 04:59:40   HNarala
///  For MT: 13469
///  
///     Rev 1.8   May 27 2009 06:03:16   HNarala
///  to support Auto scan cal feature
///  
///     Rev 1.7   May 14 2009 08:05:20   HNarala
///  13162
///  
///     Rev 1.6   May 14 2009 03:51:32   HNarala
///  for mt 13162
///  
///     Rev 1.5   Feb 19 2009 01:26:10   HNarala
///  MC3 System Weird behavior.
///  
///     Rev 1.4   Jan 22 2009 16:07:30   HQi
///  fixed a bug in prev check in
///  
///     Rev 1.3   Jan 19 2009 18:26:36   HQi
///  Add inker properties table
///  
///     Rev 1.2   Nov 20 2008 22:43:12   HNarala
///  MT: 11891
///  
///     Rev 1.1   Oct 22 2008 03:36:48   HNarala
///  MT: 11396
///  
///     Rev 1.0   03 Oct 2008 14:42:08   knadler
///  Initial revision.
///  Resolution for 11396: Create MC3 Siteset application
// 
//
/////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net;
using System.Linq;
using ImpositionImport;
using System.Windows.Forms;
using System.IO;

namespace MCNWSiteGen
{
    enum INKERTYPE
    {
        UPPER = 1,
        LOWER = 0
    };
    public class MCInkerKeys
    {
        float m_fKeyWidth;
        public MCInkerKeys()
        {
            m_fKeyWidth = 27.725f;
        }
        public float KeyWidth
        {
            get
            {
                return m_fKeyWidth;
            }
            set
            {
                m_fKeyWidth = value;
            }
        }
    }
    public class ServoBanks
    {
        string m_strSPUName;
        int m_iPortOnSPU;
        int m_iTotalKeys;
        int m_iStartKey;
        float m_fKeyWidth;
        bool m_bBankInverted;

        public ServoBanks()
        {
            m_iTotalKeys = 16;
            m_iStartKey = 0;
            m_strSPUName = "SPU";
            m_iPortOnSPU = 0;
            m_fKeyWidth = 27.725f;
            m_bBankInverted = false;
        }
        public int PortOnSPU
        {
            get { return m_iPortOnSPU; }
            set { m_iPortOnSPU = value; }
        }
        public int StartKey
        {
            get { return m_iStartKey; }
            set { m_iStartKey = value; }
        }
        public int TotalKeys
        {
            get { return m_iTotalKeys; }
            set { m_iTotalKeys = value; }
        }
        public float KeyWidth
        {
            get { return m_fKeyWidth; }
            set { m_fKeyWidth = value; }
        }
        public string SPUName
        {
            get { return m_strSPUName; }
            set { m_strSPUName = value; }
        }
        public bool BankInverted
        {
            get { return m_bBankInverted; }
            set { m_bBankInverted = value; }
        }
    }
    public class UnitGroupMembers
    {
        string m_strName;								// Unit group name
        ArrayList m_strUnitGroupMembers;
        public UnitGroupMembers()
        {
            m_strName = "";
            m_strUnitGroupMembers = new ArrayList();
            string strUnitGp = "";
            for (int iUnit = 0; iUnit < 6; iUnit++)
            {
                strUnitGp = "Unit " + iUnit;
                m_strUnitGroupMembers.Add(strUnitGp);
            }
        }
       
        public string Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }

        public ArrayList UnitNames
        {
            get { return m_strUnitGroupMembers; }
            set { m_strUnitGroupMembers = value; }
        }
        //============METHODS    =================================
        public int GetNumUnitGroupMem()
        {
            return m_strUnitGroupMembers.Count;
        }

        public string GetUnitMemNameAt(byte wIndex)
        {
            if (wIndex >= m_strUnitGroupMembers.Count)
                return null;
            return (string)m_strUnitGroupMembers[wIndex];
        }

        public void SetUnitMemNameAt(byte bIndex, string str)
        {
            m_strUnitGroupMembers[bIndex] = str;
        }
    }
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface
    // MT17149 markc Aug 25, 2011   add RAGSDALE PLC interface
    /// MarkC 11/6/12 WI29958 add AB PLC5 type 
    /// MarkC 2/8/13 MT18035  add AB poll type and rate

    public class WaterControlInterface
    {
        //string m_strComment;
        int m_iControlType;
        struct PLCCONTROL
        {
            public bool m_bUsed;                        // PLC interface is being used (COMM port is turned on, init'd, data sent)
            public int m_iPLCType;                      // PLC type; 0 is Nilpeter, 1 is Crabtree, 2 is Digital to Analog, 3 is Ragsdale
            public string m_strCommPort;                // COMx port label from OS, connected to Digi port
            public int m_iWashCycle;                    // wash cycle time ? default? range?
            public int m_iMechDelayInMS;                // time to delay pneumatic actuator to retract the ductor from fountain, higher delay
                                            // will produce a larger inkstripe(Dwell time). default 50ms  range is 10 to 250ms
            public int m_iTachPulsePerExecution;        // detected pulses from arm (press cycle) before triggering the actuator (frequency of ducting)
                                            // default? range?
            public int m_iDtoASampleTime;              // time in milliseconds to sample the press speed encoder and 
                                            //  send a total encoder pulse count to calculations.
                                            //  Default is 100 ms, Range to 5 to 500 ms.
            public int m_iDtoASweepDivisor;            // curve multiplier for ink flow control. Single point control for 
                                            //  ink/water ramping curve calculation.
                                            //  Default is 30, Range is 1 to 100. Units are unknown.
            public int m_iDtoAWaterDivisor;            // curve multiplier for water control. Single point control for 
                                            //  ink/water ramping curve calculation.
                                            //  Default is 16, Range is 1 to 100. Units are unknown.
            public int m_iDtoAWaterOutputMin;          // lowest possible setting to PLC DtoA module for sweep and water.
                                            //  Default is 100 ( about 0.5 volt), Range is 0 to 200 (0.0 to 1.0 volts)
            public int m_iDtoAWaterStartSpeedMin;      // lowest RPM setting of press speed for engaging the water surge mode.
                                            //  Default is 60 rpm (about 80 FPM), Range is 0 to 200 
            public int m_iDtoAWaterStartSpeedMax;      // highest RPM setting of press speed for engaging the water surge mode.
                                            //  Default is 120 rpm (about 200 FPM), Range is 0 to 200
            public int m_iDtoAWaterStartupVolt;        // water voltage setting for water surge mode 
                                            //  (PLC DtoA module range of 0 to 2000 = 0.0 to 10.0 voltage output)
                                            //  Default is 1000 (or about 5.0 volts), Range is 0 to 2000 ( 0.0 to 10.0 volts)
            public int m_iAB_type;		                //AB PLC type: 0=PLC3, 1=PLC5, 2=SLC504, 3=ControlLogix
            public string m_strDH_baud;		            //String DH+: "57600","115200", "230400"	Baud rates
            public int m_iAB_plc_node;	                //AB plc controller node address
            public int m_iAB_as_node;		            //AB plc app server node address
            public string m_strAB_filename;	            //AB plc filename (i.e. $N18)
            public int m_iAB_mod_type;	                //AB plc modification type: 0=direct, 1=nudge through ladder logic
            public int m_iAB_plc_map;		            //AB plc address mapping scheme for plc controller
            public int m_iAB_poll_type;		            //AB plc poll type - 0 is whole PLC page, 1 is fountain by fountain
            public int m_iAB_poll_rate;		            //AB plc poll rate in ms - 100 to 5000

        };
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 2/8/13 MT18035  add AB poll type and rate
		/// MarkC WI 193061 8-23-2019 - fix the AB PLC map setting
        /// </summary>
        PLCCONTROL m_mcPLCControl;
        public WaterControlInterface()
        {
            // m_strComment = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            m_iControlType = 4;
            m_mcPLCControl = new PLCCONTROL();
            m_mcPLCControl.m_bUsed = true;
            m_mcPLCControl.m_iPLCType = 0; //Default is 0 - Nilpeter
            m_mcPLCControl.m_strCommPort = "COM8";
            m_mcPLCControl.m_iWashCycle = 10;
            m_mcPLCControl.m_iTachPulsePerExecution = 5;
            m_mcPLCControl.m_iMechDelayInMS = 200;
            m_mcPLCControl.m_iDtoASampleTime = 250;
            m_mcPLCControl.m_iDtoASweepDivisor = 60;
            m_mcPLCControl.m_iDtoAWaterDivisor = 20;
            m_mcPLCControl.m_iDtoAWaterOutputMin = 100;
            m_mcPLCControl.m_iDtoAWaterStartSpeedMin = 60;
            m_mcPLCControl.m_iDtoAWaterStartSpeedMax = 400;
            m_mcPLCControl.m_iDtoAWaterStartupVolt = 1000;
            m_mcPLCControl.m_iAB_type = 2;		                //AB PLC type: 1=PLC3, 2=PLC5, 3=SLC504, 4=ControlLogix
            m_mcPLCControl.m_strDH_baud = "57600";	            //String DH+: "57600","115200", "230400"	Baud rates
            m_mcPLCControl.m_iAB_plc_node = 0;	                //AB plc controller node address
            m_mcPLCControl.m_iAB_as_node = 46;		            //AB plc app server node address
            m_mcPLCControl.m_strAB_filename = "N18";            //AB plc filename (i.e. N18)
            m_mcPLCControl.m_iAB_mod_type = 1;	                //AB plc modification type: 0=direct, 1=nudge through ladder logic
            m_mcPLCControl.m_iAB_plc_map = 50;		            //AB plc address mapping scheme for plc controller
            m_mcPLCControl.m_iAB_poll_type = 0;		            //AB plc poll type - 0 is whole PLC page, 1 is fountain by fountain
            m_mcPLCControl.m_iAB_poll_rate = 1000;		            //AB plc poll rate in ms - 100 to 5000

        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCTachPulsePerExec
        {
            get { return m_mcPLCControl.m_iTachPulsePerExecution; }
            set { m_mcPLCControl.m_iTachPulsePerExecution = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCMechDelayInMS
        {
            get { return m_mcPLCControl.m_iMechDelayInMS; }
            set { m_mcPLCControl.m_iMechDelayInMS = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCWashCycle
        {
            get { return m_mcPLCControl.m_iWashCycle; }
            set { m_mcPLCControl.m_iWashCycle = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public string PLCCOMMPort
        {
            get
            {
                return m_mcPLCControl.m_strCommPort;
            }
            set
            {
                m_mcPLCControl.m_strCommPort = value;
            }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCType
        {
            get
            {
                return m_mcPLCControl.m_iPLCType;
            }
            set
            {
                m_mcPLCControl.m_iPLCType = value;
            }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public bool IsPLCUsed
        {
            get
            {
                return m_mcPLCControl.m_bUsed;
            }
            set
            {
                m_mcPLCControl.m_bUsed = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCSampleTime
        {
            get
            {
                return m_mcPLCControl.m_iDtoASampleTime;
            }
            set
            {
                m_mcPLCControl.m_iDtoASampleTime = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCSweepDivisor
        {
            get
            {
                return m_mcPLCControl.m_iDtoASweepDivisor;
            }
            set
            {
                m_mcPLCControl.m_iDtoASweepDivisor = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterDivisor
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterDivisor;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterDivisor = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterOutputMin
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterOutputMin;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterOutputMin = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartSpeedMin
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartSpeedMin;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartSpeedMin = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartSpeedMax
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartSpeedMax;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartSpeedMax = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartupVolt
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartupVolt;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartupVolt = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABType
        {
            get
            {
                return m_mcPLCControl.m_iAB_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_type = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public string PLCABDHBaud
        {
            get
            {
                return m_mcPLCControl.m_strDH_baud;
            }
            set
            {
                m_mcPLCControl.m_strDH_baud = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABPLCNode
        {
            get
            {
                return m_mcPLCControl.m_iAB_plc_node;
            }
            set
            {
                m_mcPLCControl.m_iAB_plc_node = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABASNode
        {
            get
            {
                return m_mcPLCControl.m_iAB_as_node;
            }
            set
            {
                m_mcPLCControl.m_iAB_as_node = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public string PLCABFilename
        {
            get
            {
                return m_mcPLCControl.m_strAB_filename;
            }
            set
            {
                m_mcPLCControl.m_strAB_filename = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABModType
        {
            get
            {
                return m_mcPLCControl.m_iAB_mod_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_mod_type = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABPLCMap
        {
            get
            {
                return m_mcPLCControl.m_iAB_plc_map;
            }
            set
            {
                m_mcPLCControl.m_iAB_plc_map = value;
            }
        }
        /// <summary>
        /// MarkC MT18035  2/8/13  Add poll type and rate
        /// </summary>
        public int PLCABPOLLTYPE
        {
            get
            {
                return m_mcPLCControl.m_iAB_poll_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_poll_type = value;
            }
        }
        /// <summary>
        /// MarkC MT18035  2/8/13  Add poll type and rate
        /// </summary>
        public int PLCABPOLLRATE
        {
            get
            {
                return m_mcPLCControl.m_iAB_poll_rate;
            }
            set
            {
                m_mcPLCControl.m_iAB_poll_rate = value;
            }
        }
        public int ControlType
        {
            get { return m_iControlType; }
            set { m_iControlType = value; }
        }
    }
    /// <summary>
    /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
    /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
    /// MT17149 markc Aug 25, 2011   add RAGSDALE PLC interface
    /// MarkC 11/6/12 WI29958 add AB PLC5 type 
    /// MarkC 2/8/13 MT18035 add poll type and rate
    /// </summary>
    public class SweepControlInterface
    {
        //string m_strComment;
        int m_iControlType;
        struct PLCCONTROL
        {
            public bool m_bUsed;                        // PLC interface is being used (COMM port is turned on, init'd, data sent)
            public int m_iPLCType;                      // PLC type; 0 is Nilpeter, 1 is Crabtree, 2 is Digital to Analog, 3 is Ragsdale
            public string m_strCommPort;                // COMx port label from OS, connected to Digi port
            public int m_iWashCycle;                    // wash cycle time ? default? range?
            public int m_iMechDelayInMS;                // time to delay pneumatic actuator to retract the ductor from fountain, higher delay
                                                        // will produce a larger inkstripe(Dwell time). default 50ms  range is 10 to 250ms
            public int m_iTachPulsePerExecution;        // detected pulses from arm (press cycle) before triggering the actuator (frequency of ducting)
                                                        // default? range?
            public int m_iDtoASampleTime;              // time in milliseconds to sample the press speed encoder and 
                                                        //  send a total encoder pulse count to calculations.
                                                        //  Default is 100 ms, Range to 5 to 500 ms.
            public int m_iDtoASweepDivisor;            // curve multiplier for ink flow control. Single point control for 
                                                        //  ink/water ramping curve calculation.
                                                        //  Default is 30, Range is 1 to 100. Units are unknown.
            public int m_iDtoAWaterDivisor;            // curve multiplier for water control. Single point control for 
                                                        //  ink/water ramping curve calculation.
                                                        //  Default is 16, Range is 1 to 100. Units are unknown.
            public int m_iDtoAWaterOutputMin;          // lowest possible setting to PLC DtoA module for sweep and water.
                                                        //  Default is 100 ( about 0.5 volt), Range is 0 to 200 (0.0 to 1.0 volts)
            public int m_iDtoAWaterStartSpeedMin;      // lowest RPM setting of press speed for engaging the water surge mode.
                                                        //  Default is 60 rpm (about 80 FPM), Range is 0 to 200 
            public int m_iDtoAWaterStartSpeedMax;      // highest RPM setting of press speed for engaging the water surge mode.
                                                        //  Default is 120 rpm (about 200 FPM), Range is 0 to 200
            public int m_iDtoAWaterStartupVolt;        // water voltage setting for water surge mode 
                                                        //  (PLC DtoA module range of 0 to 2000 = 0.0 to 10.0 voltage output)
                                                        //  Default is 1000 (or about 5.0 volts), Range is 0 to 2000 ( 0.0 to 10.0 volts)
            public int m_iAB_type;		                //AB PLC type: 0=PLC3, 1=PLC5, 2=SLC504, 3=ControlLogix
            public string m_strDH_baud;		            //String DH+: "57600","115200", "230400"	Baud rates
            public int m_iAB_plc_node;	                //AB plc controller node address
            public int m_iAB_as_node;		            //AB plc app server node address
            public string m_strAB_filename;	            //AB plc filename (i.e. $N18)
            public int m_iAB_mod_type;	                //AB plc modification type: 0=direct, 1=nudge through ladder logic
            public int m_iAB_plc_map;		            //AB plc address mapping scheme for plc controller
            public int m_iAB_poll_type;		            //AB plc poll type - 0 is whole PLC page, 1 is fountain by fountain
            public int m_iAB_poll_rate;		            //AB plc poll rate in ms - 100 to 5000
            public int m_iNLCurve;                      // Non-Linear Curve setting (def 2, 0-4)
            public int m_iMotorSpeed;                   // minimum sweep motor setting (def 15, 0 to 30)
            public int m_iMotorTurns;                   // SPU sweep motor setting (def 25, 0 to 60)
        };
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        PLCCONTROL m_mcPLCControl;
        public SweepControlInterface()
        {
           // m_strComment = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            m_iControlType = 4;
            m_mcPLCControl = new PLCCONTROL();
            m_mcPLCControl.m_bUsed = true;
            m_mcPLCControl.m_iPLCType = 0; //Default is 0 - Nilpeter
            m_mcPLCControl.m_strCommPort = "COM8";
            m_mcPLCControl.m_iWashCycle = 10;
            m_mcPLCControl.m_iTachPulsePerExecution = 3;
            m_mcPLCControl.m_iMechDelayInMS = 70;
            m_mcPLCControl.m_iDtoASampleTime = 100;
            m_mcPLCControl.m_iDtoASweepDivisor = 30;
            m_mcPLCControl.m_iDtoAWaterDivisor = 16;
            m_mcPLCControl.m_iDtoAWaterOutputMin = 100;
            m_mcPLCControl.m_iDtoAWaterStartSpeedMin = 60;
            m_mcPLCControl.m_iDtoAWaterStartSpeedMax = 120;
            m_mcPLCControl.m_iDtoAWaterStartupVolt = 1000;
            m_mcPLCControl.m_iAB_type = 2;		                //AB PLC type: 1=PLC3, 2=PLC5, 3=SLC504, 4=ControlLogix
            m_mcPLCControl.m_strDH_baud = "57600";	            //String DH+: "57600","115200", "230400"	Baud rates
            m_mcPLCControl.m_iAB_plc_node = 0;	                //AB plc controller node address
            m_mcPLCControl.m_iAB_as_node = 46;		            //AB plc app server node address
            m_mcPLCControl.m_strAB_filename = "N18";            //AB plc filename (i.e. N18)
            m_mcPLCControl.m_iAB_mod_type = 1;	                //AB plc modification type: 0=direct, 1=nudge through ladder logic
            m_mcPLCControl.m_iAB_plc_map = 50;		            //AB plc address mapping scheme for plc controller
            m_mcPLCControl.m_iAB_poll_type = 0;		            //AB plc poll type - 0 is whole PLC page, 1 is fountain by fountain
            m_mcPLCControl.m_iAB_poll_rate = 1000;		            //AB plc poll rate in ms - 100 to 5000
            m_mcPLCControl.m_iNLCurve = 2;
            m_mcPLCControl.m_iMotorSpeed = 15;
            m_mcPLCControl.m_iMotorTurns = 28;

        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCTachPulsePerExec
        {
            get { return m_mcPLCControl.m_iTachPulsePerExecution; }
            set { m_mcPLCControl.m_iTachPulsePerExecution = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCMechDelayInMS
        {
            get { return m_mcPLCControl.m_iMechDelayInMS; }
            set { m_mcPLCControl.m_iMechDelayInMS = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCWashCycle
        {
            get { return m_mcPLCControl.m_iWashCycle; }
            set { m_mcPLCControl.m_iWashCycle = value; }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public string PLCCOMMPort
        {
            get
            {
                return m_mcPLCControl.m_strCommPort;
            }
            set
            {
                m_mcPLCControl.m_strCommPort = value;
            }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public int PLCType
        {
            get
            {
                return m_mcPLCControl.m_iPLCType;
            }
            set
            {
                m_mcPLCControl.m_iPLCType = value;
            }
        }
        /// <summary>
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// </summary>
        public bool IsPLCUsed
        {
            get
            {
                return m_mcPLCControl.m_bUsed;
            }
            set
            {
                m_mcPLCControl.m_bUsed = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCSampleTime
        {
            get
            {
                return m_mcPLCControl.m_iDtoASampleTime;
            }
            set
            {
                m_mcPLCControl.m_iDtoASampleTime = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCSweepDivisor
        {
            get
            {
                return m_mcPLCControl.m_iDtoASweepDivisor;
            }
            set
            {
                m_mcPLCControl.m_iDtoASweepDivisor = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterDivisor
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterDivisor;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterDivisor = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterOutputMin
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterOutputMin;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterOutputMin = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartSpeedMin
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartSpeedMin;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartSpeedMin = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartSpeedMax
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartSpeedMax;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartSpeedMax = value;
            }
        }
        /// <summary>
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
        /// </summary>
        public int PLCWaterStartupVolt
        {
            get
            {
                return m_mcPLCControl.m_iDtoAWaterStartupVolt;
            }
            set
            {
                m_mcPLCControl.m_iDtoAWaterStartupVolt = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABType
        {
            get
            {
                return m_mcPLCControl.m_iAB_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_type = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public string PLCABDHBaud
        {
            get
            {
                return m_mcPLCControl.m_strDH_baud;
            }
            set
            {
                m_mcPLCControl.m_strDH_baud = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABPLCNode
        {
            get
            {
                return m_mcPLCControl.m_iAB_plc_node;
            }
            set
            {
                m_mcPLCControl.m_iAB_plc_node = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABASNode
        {
            get
            {
                return m_mcPLCControl.m_iAB_as_node;
            }
            set
            {
                m_mcPLCControl.m_iAB_as_node = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public string PLCABFilename
        {
            get
            {
                return m_mcPLCControl.m_strAB_filename;
            }
            set
            {
                m_mcPLCControl.m_strAB_filename = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABModType
        {
            get
            {
                return m_mcPLCControl.m_iAB_mod_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_mod_type = value;
            }
        }
        /// <summary>
        /// MarkC WI 29958 11/6/12 Add AB PLC PLC/5 Sweep and Water control
        /// </summary>
        public int PLCABPLCMap
        {
            get
            {
                return m_mcPLCControl.m_iAB_plc_map;
            }
            set
            {
                m_mcPLCControl.m_iAB_plc_map = value;
            }
        }
        /// <summary>
        /// MarkC 2/8/13 MT18035 add poll type and rate
        /// </summary>
        public int PLCABPOLLTYPE
        {
            get
            {
                return m_mcPLCControl.m_iAB_poll_type;
            }
            set
            {
                m_mcPLCControl.m_iAB_poll_type = value;
            }
        }
        /// <summary>
        /// MarkC 2/8/13 MT18035 add poll type and rate
        /// </summary>
        public int PLCABPOLLRATE
        {
            get
            {
                return m_mcPLCControl.m_iAB_poll_rate;
            }
            set
            {
                m_mcPLCControl.m_iAB_poll_rate = value;
            }
        }
        /// <summary>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// </summary>
        public int PLCNLCurve
        {
            get
            {
                return m_mcPLCControl.m_iNLCurve;
            }
            set
            {
                m_mcPLCControl.m_iNLCurve = value;
            }
        }
        /// <summary>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// </summary>
        public int PLCMotorSpeed
        {
            get
            {
                return m_mcPLCControl.m_iMotorSpeed;
            }
            set
            {
                m_mcPLCControl.m_iMotorSpeed = value;
            }
        }
        /// <summary>
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// </summary>
        public int PLCMotorTurns
        {
            get
            {
                return m_mcPLCControl.m_iMotorTurns;
            }
            set
            {
                m_mcPLCControl.m_iMotorTurns = value;
            }
        }
        
        public int ControlType
        {
            get { return m_iControlType; }
            set { m_iControlType = value; }
        }

    }
    public class MCPressNFSTable
    {
        int m_iBreakPoint;
        int m_iMaxKeyTurnsAtConsole99;
        public MCPressNFSTable()
        {
            m_iBreakPoint = 50;
            m_iMaxKeyTurnsAtConsole99 = 150; //WI37033 - SiteGen defaults

        }
        public int BreakPoint
        {
            get { return m_iBreakPoint; }
            set { m_iBreakPoint = value; }
        }
        public int MaxKeyTurnsAtConsole99
        {
            get { return m_iMaxKeyTurnsAtConsole99; }
            set { m_iMaxKeyTurnsAtConsole99 = value; }
        }


    }
	///   WI31010   8/8/13 Markc
    public class SweepMotorServoControlInterface
    {
        int controlType;
        bool stepEnabled;
        double servoTurns;
        double turns2;
        bool reversed;
        bool lowBacklashUsed;
        bool offsetEnabled;
        bool specialMapping;
        bool useBank1;
        bool readFromFile;
        int pcu_pulseWidth;
        int pcu_distNudge;
        int pcu_maxStalls;
        int pcu_tolerance;
        /// <![CDATA[
        /// 
        /// < Function: SweepMotorServoControlInterface>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        ///          Suresh, JUNE-07-2010, DEF 15844: Invalid values displayed from 'Servo Turns' edit box while creating new site file from SiteGen application.  
        /// ]]>
        /// <summary>  WI31010   8/8/13 Markc
        /// </summary>

        public SweepMotorServoControlInterface()
        {
            controlType = 1; // m_strComment = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            stepEnabled = false; 
            servoTurns = 0.2;
            turns2 = 0.0;
            reversed = false; ;
            lowBacklashUsed = false;
            offsetEnabled = false;
            useBank1 = true;
            readFromFile = false;
            pcu_pulseWidth = 10;
            pcu_distNudge  = 40 ;
            pcu_maxStalls  = 3;
            pcu_tolerance  = 11;
        }
        public int ControlType
        {
            get { return controlType; }
            set { controlType = value; }
        }
        public bool StepEnabled
        {
            get { return stepEnabled; }
            set { stepEnabled = value; }
        }
        public double ServoTurns
        {
            get { return servoTurns; }
            set { servoTurns = value; }
        }
        public double Turns2
        {
            get { return turns2; }
            set { turns2 = value; }
        }
        public bool Reversed
        {
            get { return reversed; }
            set { reversed = value; }
        }
        public bool LowBacklashUsed
        {
            get { return lowBacklashUsed; }
            set { lowBacklashUsed = value; }
        }
        public bool OffsetEnabled
        {
            get { return offsetEnabled; }
            set { offsetEnabled = value; }
        }
        public bool SpecialMapping
        {
            get { return specialMapping; }
            set { specialMapping = value; }
        }
        public bool UseBank1
        {
            get { return useBank1; }
            set { useBank1 = value; }
        }
        public bool ReadFromFile
        {
            get { return readFromFile; }
            set { readFromFile = value; }
        }
	///   WI31010   8/8/13 Markc
        public int PCU_pulseWidth
        {
            get { return pcu_pulseWidth; }
            set { pcu_pulseWidth = value; }
        }
        public int PCU_tolerance
        {
            get { return pcu_tolerance; }
            set { pcu_tolerance = value; }
        }
        public int PCU_distNudge
        {
            get { return pcu_distNudge; }
            set { pcu_distNudge = value; }
        }
        public int PCU_maxStalls
        {
            get { return pcu_maxStalls; }
            set { pcu_maxStalls = value; }
        }
    }
    public class ServoControl
    {
        bool isServoControl;
        public ServoControl()
        {
            isServoControl = false; 
        }
        public bool IsServoControl
        {
            get { return isServoControl; }
            set { isServoControl = value; }
        } 
    }

    public class WaterMotorServoControlInterface
    {
        int controlType;
        int initialSurge;
        double servoTurns;
        double turns2;
        int incrementalSurge;
        bool reversed;
        bool specialMapping;
        bool useBank1;
        bool readFromFile;
        int pcu_pulseWidth;
        int pcu_distNudge;
        int pcu_maxStalls;
        int pcu_tolerance;
        /// <![CDATA[
        /// 
        /// < Function: WaterMotorServoControlInterface>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        ///          Suresh, JUNE-07-2010, DEF 15844: Invalid values displayed from 'Servo Turns' edit box while creating new site file from SiteGen application.  
	///   WI31010   8/8/13 Markc
        /// ]]>
        /// <summary>
        /// </summary>

        public WaterMotorServoControlInterface()
        {
            controlType = 1; // m_strComment = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            initialSurge = 0;
            servoTurns = 0.2;
            turns2 = 0.0;
            reversed = false; ;
            incrementalSurge = 0; ;
            specialMapping = false;
            useBank1 = true;
            readFromFile = false;
            pcu_pulseWidth = 10;
            pcu_distNudge = 40;
            pcu_maxStalls = 3;
            pcu_tolerance = 11;
        }
        public int ControlType
        {
            get { return controlType; }
            set { controlType = value; }
        }
        public int InitialSurge
        {
            get { return initialSurge; }
            set { initialSurge = value; }
        }
        public double ServoTurns
        {
            get { return servoTurns; }
            set { servoTurns = value; }
        }
        public double Turns2
        {
            get { return turns2; }
            set { turns2 = value; }
        }
        public bool Reversed
        {
            get { return reversed; }
            set { reversed = value; }
        }
        public int IncrementalSurge
        {
            get { return incrementalSurge; }
            set { incrementalSurge = value; }
        }
        public bool SpecialMapping
        {
            get { return specialMapping; }
            set { specialMapping = value; }
        }
        public bool UseBank1
        {
            get { return useBank1; }
            set { useBank1 = value; }
        }
        public bool ReadFromFile
        {
            get { return readFromFile; }
            set { readFromFile = value; }
        }
        public int PCU_pulseWidth
        {
            get { return pcu_pulseWidth; }
            set { pcu_pulseWidth = value; }
        }
        public int PCU_tolerance
        {
            get { return pcu_tolerance; }
            set { pcu_tolerance = value; }
        }
        public int PCU_distNudge
        {
            get { return pcu_distNudge; }
            set { pcu_distNudge = value; }
        }
        public int PCU_maxStalls
        {
            get { return pcu_maxStalls; }
            set { pcu_maxStalls = value; }
        }
    }
    /// <summary>
    /// //////
    /// </summary>
    public class AutoScanCal
    {
        bool autoScanEnabled;
        double sweepZoneRatio;
        int zoneMargin;
        double EWMAFilterParam;
        int scanSweepAdjust;
        int sweepDefault;
        int webType;
        bool enableLimitCheck;
        int bladeTolerance;
        string cip3Path;
        string cip3ImagesPath;
        string impositionPath;
        bool impositionDataEnabled;

        public AutoScanCal()
        {
            autoScanEnabled = false;
            sweepZoneRatio = 1.0;
            zoneMargin = 2;
            EWMAFilterParam = 0.1; // WI37033 - changed to 0.1 by default (reduces ASC learning issues)
            scanSweepAdjust = 1;
            sweepDefault = 40;
            webType = 0;
            enableLimitCheck = false;
            bladeTolerance = 50;
            cip3Path = @"D:\GMI\MC3\CIP3\";
            cip3ImagesPath = @"D:\GMI\MC3\CIP3IMAGES\";
            impositionPath = @"D:\GMI\MC3\IMPOSITION\";
        }
        public bool AutoScanEnabled
        {
            get { return autoScanEnabled; }
            set { autoScanEnabled = value; }
        }
        public double SweepZoneRatio
        {
            get { return sweepZoneRatio; }
            set { sweepZoneRatio = value; }
        }
        public int ZoneMargin
        {
            get { return zoneMargin; }
            set { zoneMargin = value; }
        }
        public double EWMAFactor
        {
            get { return EWMAFilterParam; }
            set { EWMAFilterParam = value; }
        }
        public int ScanSweepAdjust
        {
            get { return scanSweepAdjust; }
            set { scanSweepAdjust = value; }
        }
        public int SweepDefault
        {
            get { return sweepDefault; }
            set { sweepDefault = value; }
        }
        public int WebType
        {
            get { return webType; }
            set { webType = value; }
        }
        public bool EnableLimitCheck
        {
            get { return enableLimitCheck; }
            set { enableLimitCheck = value; }
        }
        public int BladeTolerance
        {
            get { return bladeTolerance; }
            set { bladeTolerance = value; }
        }
        public string Cip3Path
        {
            get { return cip3Path; }
            set { cip3Path = value; }
        }
        public string Cip3ImagesPath
        {
            get { return cip3ImagesPath; }
            set { cip3ImagesPath = value; }
        }
        public bool ImpositionDataEnabled
        {
            get { return impositionDataEnabled; }
            set { impositionDataEnabled = value; }
        }
        public string ImpositionPath
        {
            get { return impositionPath; }
            set { impositionPath = value; }
        }
    }
        /// <![CDATA[
        /// < Author: Sreejit Kumar S >
        /// 
        /// History: Sreejit, July-30-2010, ENH 16062: MC3 AS - ALL data file paths should be configurable  
		///          29-May-19, Mark C, WI177016 - Add support for Job Management view paths
        /// ]]>
        /// <summary>
        ///  ServerDataPathConfig class - to store the Server file locations
        /// </summary>
    public class ServerDataPathConfig
    {
        string systemPath;
        string applicationData;
        string logPath;
        string RuntimeConfigPath;
        string m_jobsPath;
        string m_jobsArchivePath;
        string m_formTemplatePath;
               
        public ServerDataPathConfig()
        {
            // Modified by Sreejit on Aug-13-2010 for ENH 16186: MCNWSiteGen: The default 
            // System file path should be "C:\GMI\MC3\SYSTEM"
            systemPath        = @"C:\GMI\MC3\SYSTEM\";
            applicationData   = @"D:\GMI\MC3\JOB_DATA\";
            logPath           = @"D:\GMI\MC3\LOGS\";
            RuntimeConfigPath = @"D:\GMI\MC3\MC3AS\RUNTIME\";
            m_jobsPath          = @"D:\GMI\MC3\JOBS\";
            m_jobsArchivePath   = @"D:\GMI\MC3\JOBS_ARCHIVE\";
            m_formTemplatePath  = @"D:\GMI\MC3\FORM_TEMPLATE\";
        }

        public string SystemPath
        {
            get { return systemPath; }
            set { systemPath = value; }
        }

        public string ApplicationData
        {
            get { return applicationData; }
            set { applicationData = value; }
        }
        public string LogPath
        {
            get { return logPath; }
            set { logPath = value; }
        }
        public string SystemRuntimeConfigPath
        {
            get { return RuntimeConfigPath; }
            set { RuntimeConfigPath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the jobs path.
        /// </summary>
        /// <value>
        /// The jobs path.
        /// </value>
        public string JobsPath
        {
            get { return m_jobsPath; }
            set { m_jobsPath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the jobs archive path.
        /// </summary>
        /// <value>
        /// The jobs archive path.
        /// </value>
        public string JobsArchivePath
        {
            get { return m_jobsArchivePath; }
            set { m_jobsArchivePath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the form template path.
        /// </summary>
        /// <value>
        /// The form template path.
        /// </value>
        public string FormTemplatePath
        {
            get { return m_formTemplatePath; }
            set { m_formTemplatePath = value; }
        }
        
    }
        /// <![CDATA[
        /// < Author: Sreejit Kumar S >
        /// 
        /// History: Sreejit, July-30-2010, ENH 16062: MC3 AS - ALL data file paths should be configurable  
        ///          08-Mar-12, Mark C, MT 17637 - Add support for configuring Help file location folder
        /// 18-Mar-2014, Chetan, Modified for supporting Keyboard Layouts folder.
        /// ]]>
        /// <summary>
        ///  ClientDataPathConfig class - to store the Client file locations
        /// </summary>
     public class ClientDataPathConfig
     {
         string clientConfigPath;
         string m_HelpPath;
         string m_strKeyboardLayoutFiles;
         string m_logFilesPath;


         /// <![CDATA[
         ///
         /// Author: unknown
         /// 
         /// History: 28-Apr-15, Mark C, WI55780: Add support for Log folder
         /// 
         /// ]]>
         /// <summary>
         /// Initializes a new instance of the <see cref="ClientDataPathConfig"/> class.
         /// </summary>
         public ClientDataPathConfig()
         {
             clientConfigPath = @"D:\GMI\MC3\MC3CLIENT\CONFIG\";
             m_HelpPath = @"D:\GMI\MC3\MC3CLIENT\HELP\";
             m_logFilesPath = @"D:\GMI\MC3\Logs\";
         }

         /// <summary>
         /// Gets or sets the help path.
         /// </summary>
         /// <value>The help path.</value>
         public string HelpPath
         {
             get { return m_HelpPath; }
             set { m_HelpPath = value; }
         }

         /// <summary>
         /// Gets or sets the Keyboard Lyouts path.
         /// </summary>
         /// <value>The help path.</value>
         public string KBDLayoutFolder
         {
             get { return m_strKeyboardLayoutFiles; }
             set { m_strKeyboardLayoutFiles = value; }
         }
         public string ClientConfigPath
         {
             get { return clientConfigPath; }
             set { clientConfigPath = value; }
         }


         /// <![CDATA[
         ///
         /// Author: Mark C
         /// 
         /// History: 28-Apr-15, Mark C, WI55780: Add support for Log folder
         /// 
         /// ]]>
         /// <summary>
         /// Gets or sets the log files path.
         /// </summary>
         /// <value>
         /// The log files path.
         /// </value>
         public string LogFilesPath
         {
             get { return m_logFilesPath; }
             set { m_logFilesPath = value; }
         } 
     }
    public class MCAutoTest
    {
        int totalSpusToTest;
        int totalUnitsToTest;
        int totalServosToTest;
        int closeKeysUpTo;
        int timeDelay;
        int numberOfCycles;
        int loopType;
        int openKeysUpTo;

        public MCAutoTest()
        {
            totalSpusToTest = 1;
            totalUnitsToTest = 1;
            totalServosToTest = 16;
            closeKeysUpTo = 1;
            timeDelay = 1;
            numberOfCycles = 1;
            loopType = 1;
            openKeysUpTo = 1;
        }
        public int TotalSpusToTest
        {
            get { return totalSpusToTest; }
            set { totalSpusToTest = value; }
        }
        public int TotalUnitsToTest
        {
            get { return totalUnitsToTest; }
            set { totalUnitsToTest = value; }
        }
        public int TotalServosToTest
        {
            get { return totalServosToTest; }
            set { totalServosToTest = value; }
        }
        public int CloseKeysUpTo
        {
            get { return closeKeysUpTo; }
            set { closeKeysUpTo = value; }
        }
        public int TimeDelay
        {
            get { return timeDelay; }
            set { timeDelay = value; }
        }
        public int NumberOfCycles
        {
            get { return numberOfCycles; }
            set { numberOfCycles = value; }
        }
        public int LoopType
        {
            get { return loopType; }
            set { loopType = value; }
        }
        public int OpenKeysUpTo
        {
            get { return openKeysUpTo; }
            set { openKeysUpTo = value; }
        }
    }

    public class MCSweepTest
    {
        int totalSpusToTest;
        int whichPortToTest;
        int totalSweepsToTest;
        int timeDelay;
        int numberOfCycles;
        int openSweepUpTo;

        public MCSweepTest()
        {
            totalSpusToTest = 1;
            whichPortToTest = 1;
            totalSweepsToTest = 1;
            timeDelay = 1;
            numberOfCycles = 1;
            openSweepUpTo = 1;
        }
        public int TotalSpusToTest
        {
            get { return totalSpusToTest; }
            set { totalSpusToTest = value; }
        }
        public int WhichPortToTest
        {
            get { return whichPortToTest; }
            set { whichPortToTest = value; }
        }
        public int TotalSweepsToTest
        {
            get { return totalSweepsToTest; }
            set { totalSweepsToTest = value; }
        }
        public int TimeDelay
        {
            get { return timeDelay; }
            set { timeDelay = value; }
        }
        public int NumberOfCycles
        {
            get { return numberOfCycles; }
            set { numberOfCycles = value; }
        }
        public int OpenSweepUpTo
        {
            get { return openSweepUpTo; }
            set { openSweepUpTo = value; }
        }

    }

    public class MCPressConsoleZones
    {
        int m_iNumOfZones;
        float m_fZoneWidth;
        int m_iMinValue;
        int m_iMaxValue;
        public MCPressConsoleZones()
        {
            m_iNumOfZones = 16;
            m_fZoneWidth = 2.7725f; //OCU3 - Zone width should always be in CM
            m_iMaxValue = 99;
            m_iMinValue = 0;
        }
        public int NumberOfZones
        {
            get { return m_iNumOfZones; }
            set { m_iNumOfZones = value; }
        }
        public float ZoneWidth
        {
            get { return m_fZoneWidth; }
            set { m_fZoneWidth = value; }
        }
        public int MinValue
        {
            get { return m_iMinValue; }
            set { m_iMinValue = value; }
        }
        public int MaxValue
        {
            get { return m_iMaxValue; }
            set { m_iMaxValue = value; }
        }

    }
    public class MCClientInterfaceFeatures
    {

        float m_fBladeStiffness;
        int m_iMaxNeighborKeyDelta;
        string m_strNonLinearTablePath;
        string m_strLinearTablePath;
        int m_iDefaultOffset;
        public int m_iServoPulsesZoneAtZero;
        int m_iPressZeroBackoffInPulses;
        bool m_bWidePress;
        bool m_bFunnyFountains;
        bool m_bVirtualInkers;

        struct MCCLIENT_FEATURES
        {
            public bool m_bCIP3Feature;
            public int m_iLinear;
            public int m_iNonLinear;
            public bool m_bNonLinear;
            public bool m_bBladeComp;
            public bool m_bMeterOffset;
            public bool m_bSweepControl;
            public bool m_bWaterControl;
        };
        MCCLIENT_FEATURES m_mcClientFeatures;
        public MCClientInterfaceFeatures()
        {
            m_fBladeStiffness      = 0.0f;
            m_iMaxNeighborKeyDelta = 99; //WI37033 - Disable Blade smoothing by default
            m_mcClientFeatures = new MCCLIENT_FEATURES();
            m_mcClientFeatures.m_bBladeComp = false; //WI37033 - Disable Blade compensation by default
            m_mcClientFeatures.m_bCIP3Feature = false;
            m_mcClientFeatures.m_bSweepControl = true;  // should be true by default 
            m_mcClientFeatures.m_bWaterControl = true;	// 03-Aug-17, Mark C, WI102725: Enable water control by default
            m_mcClientFeatures.m_iNonLinear = 1; //WI37033 - Enable NonLinear Type 1 by default
            m_mcClientFeatures.m_iLinear = 0;
            m_mcClientFeatures.m_bNonLinear = false;
            m_mcClientFeatures.m_bMeterOffset = false;   //WI37033 - Disable Blade compensation by default
            m_strNonLinearTablePath = "0";
            m_strLinearTablePath = "0";
            m_iDefaultOffset = 0;
            m_iServoPulsesZoneAtZero = 0;
            m_iPressZeroBackoffInPulses = 0;
            m_bWidePress = false;
            m_bFunnyFountains = false;
            m_bVirtualInkers = false;           //20240315 Mark C - refactor for SiteGen virtual inkers
        }
        public bool WidePress
        {
            get { return m_bWidePress; }
            set { m_bWidePress = value; }
        }
        public bool FunnyFountains
        {
            get { return m_bFunnyFountains; }
            set { m_bFunnyFountains = value; }
        }
        public bool VirtualInkers
        {
            get { return m_bVirtualInkers; }
            set { m_bVirtualInkers = value; }
        }
        public bool BladeCompensation
        {
            get { return m_mcClientFeatures.m_bBladeComp; }
            set { m_mcClientFeatures.m_bBladeComp = value; }
        }
        public bool CIP3Enabled
        {
            get { return m_mcClientFeatures.m_bBladeComp; }
            set { m_mcClientFeatures.m_bBladeComp = value; }
        }
        public bool SweepControl
        {
            get { return m_mcClientFeatures.m_bSweepControl; }
            set { m_mcClientFeatures.m_bSweepControl = value; }
        }
        public bool WaterControl
        {
            get { return m_mcClientFeatures.m_bWaterControl; }
            set { m_mcClientFeatures.m_bWaterControl = value; }
        }
        public int NonLinear
        {
            get { return m_mcClientFeatures.m_iNonLinear; }
            set { m_mcClientFeatures.m_iNonLinear = value; }
        }
        public bool CIP3Presetting
        {
            get { return m_mcClientFeatures.m_bCIP3Feature; }
            set { m_mcClientFeatures.m_bCIP3Feature = value; }
        }
        public bool MeteringRoller
        {
            get { return m_mcClientFeatures.m_bMeterOffset; }
            set { m_mcClientFeatures.m_bMeterOffset = value; }
        }
        public int Linear
        {
            get { return m_mcClientFeatures.m_iLinear; }
            set { m_mcClientFeatures.m_iLinear = value; }
        }

        public bool NonLinearBool
        {
            set { m_mcClientFeatures.m_bNonLinear = value; }
            get { return m_mcClientFeatures.m_bNonLinear; }
        }

        public bool MeterOffset
        {
            set { m_mcClientFeatures.m_bMeterOffset = value; }
            get { return m_mcClientFeatures.m_bMeterOffset; }
        }
        public string NFSTableNonLinearPath
        {
            get{return m_strNonLinearTablePath;}
            set { m_strNonLinearTablePath = value; }
        }

        public string NFSTableLinearPath
        {
            get { return m_strLinearTablePath; }
            set { m_strLinearTablePath = value; }
        }
        //public string LINTablePath
        //{
        //    get { return m_strNonLinearTablePath; }
        //    set { m_strNonLinearTablePath = value; }
        //}

        public int DefaultOffset
        {
            get { return m_iDefaultOffset; }
            set { m_iDefaultOffset = value; }
        }
        public float BladeStiffNess
        {
            get { return m_fBladeStiffness; }
            set { m_fBladeStiffness = value; }
        }
        public int MaxKeyDelta
        {
            get { return m_iMaxNeighborKeyDelta; }
            set { m_iMaxNeighborKeyDelta = value; }
        }
        public int ServoPulsesZoneAtZero
        {
            get { return m_iServoPulsesZoneAtZero; }
            set { m_iServoPulsesZoneAtZero = value; }
        }
        public int PressZeroBackoffInPulses
        {
            get { return m_iPressZeroBackoffInPulses; }
            set { m_iPressZeroBackoffInPulses = value; }
        }


    }

    public class PressClientInterface
    {
        struct CLIENT_PASSWORDS
        {
            public string m_strLevel1;
            public string m_strLevel2;
            public string m_strLevel3;
            public string m_strOptionalLevels;
            public string m_strFactory;
            public string m_strInstaller;
            public string m_strAdvUser;
        };
        struct DATA_PATHS
        {
            public string m_strRemoteDataStorage;
            public string m_strLocalStorage;
            public string m_strJobStorageShare;
            public string m_strClientBkupDrive;
        };
        struct DISPLAYOPTION
        {
            public bool m_bOperatorOnLeft;
            public bool m_bWebDirectionUP;
            public bool m_bDispKeyLeft2Right;
        };
        CLIENT_PASSWORDS clientPassword;
        DATA_PATHS dataPaths;
        DISPLAYOPTION displayOptionsTOP;
        DISPLAYOPTION displayOptionsBOTTOM;
        ArrayList m_ayFilterNames;
        string m_strCurrentLanguage;
        bool m_bMetricsDisplay;
        int m_iSpeedDispFormat;
        int m_iImpCountMethod;
        bool m_bShowHelp = false;       //true - Help enabled, false - Help disabled
        bool m_bShow2SidesThumbs = false;//true - 2 Sides Thumbs enabled, false - 2 Sides Thumbs disabled

        public PressClientInterface()
        {
            clientPassword.m_strLevel1 = MCNWSiteGen.DefineAndConst.StringConstant.DEFAULT_CONFIGURATON_PASSWORD;
            clientPassword.m_strLevel2 = MCNWSiteGen.DefineAndConst.StringConstant.DEFAULT_DIAGNOSTIC_PASSWORD;
            clientPassword.m_strLevel3 = MCNWSiteGen.DefineAndConst.StringConstant.DEFAULT_EXIT_PASSWORD;
            clientPassword.m_strOptionalLevels = "1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0";
            clientPassword.m_strFactory = "";
            clientPassword.m_strInstaller = "";
            clientPassword.m_strAdvUser = MCNWSiteGen.DefineAndConst.StringConstant.DEFAULT_RUNTIME_PASSWORD;

            dataPaths.m_strRemoteDataStorage = @"D:\GMI\MC3\JOB_DATA";               //WI36451  change remote path to same as Local
            dataPaths.m_strLocalStorage      = @"D:\GMI\MC3\JOB_DATA";
            dataPaths.m_strJobStorageShare   = "MC3_JOB_DATA";
            dataPaths.m_strClientBkupDrive   = @"D:\";

            displayOptionsTOP.m_bDispKeyLeft2Right = false;
            displayOptionsTOP.m_bOperatorOnLeft = false;
            displayOptionsTOP.m_bWebDirectionUP = false;

            displayOptionsBOTTOM.m_bDispKeyLeft2Right = false;
            displayOptionsBOTTOM.m_bOperatorOnLeft = false;
            displayOptionsBOTTOM.m_bWebDirectionUP = false;
            m_strCurrentLanguage = DefineAndConst.Culture.English; // WI37033 - English as the default language
            m_ayFilterNames = new ArrayList();
            string strFilter = "KEY";
            m_ayFilterNames.Add(strFilter);
            strFilter = "CYN";
            m_ayFilterNames.Add(strFilter);
            strFilter = "MAG";
            m_ayFilterNames.Add(strFilter);
            strFilter = "YEL";
            m_ayFilterNames.Add(strFilter);
            m_bMetricsDisplay = false;
            m_iSpeedDispFormat = 0;
            m_iImpCountMethod = 0;
        }

        public int SpeedDispFormat
        {
            get { return m_iSpeedDispFormat; }
            set { m_iSpeedDispFormat = value; }
        }
        public int ImpCountMethod
        {
            get { return m_iImpCountMethod; }
            set { m_iImpCountMethod = value; }
        }
        public bool MetricsDisplay
        {
            get { return m_bMetricsDisplay; }
            set { m_bMetricsDisplay = value; }
        }
       
        public ArrayList FilterNames
        {
            get { return m_ayFilterNames; }
        }
        public string CurrentLanguage
        {
            get { return m_strCurrentLanguage; }
            set { m_strCurrentLanguage = value; }
        }
        /// Added by Sreejit on July-30-2010 to support ENH 14660: MC3SiteGen: Not able to 
        ///configure 'Network form Storage' location from SiteGen application
        public string StandardPath // Local Storage Path
        {
            get { return dataPaths.m_strLocalStorage; }
            set { dataPaths.m_strLocalStorage = value; }
        }
        public string NetworkPath  // Remote Storage Path
        {
            get { return dataPaths.m_strRemoteDataStorage; }
            set { dataPaths.m_strRemoteDataStorage = value; }
        }
        public string ClientBackUpDrive
        {
            get { return dataPaths.m_strClientBkupDrive; }
            set { dataPaths.m_strClientBkupDrive = value; }
        }

        public string ConfigurationPassword
        {
            get
            {
                return clientPassword.m_strLevel1;
            }
            set
            {
                clientPassword.m_strLevel1 = value;
            }
        }
        public string DiagnosticPassword
        {
            get
            {
                return clientPassword.m_strLevel2;
            }
            set
            {
                clientPassword.m_strLevel2 = value;
            }
        }
        public string ExitPassword
        {
            get
            {
                return clientPassword.m_strLevel3;
            }
            set
            {
                clientPassword.m_strLevel3 = value;
            }
        }
        public string AdvUser
        {
            get
            {
                return clientPassword.m_strAdvUser;
            }
            set
            {
                clientPassword.m_strAdvUser = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show help].
        /// </summary>
        /// <value><c>true</c> if [show help]; otherwise, <c>false</c>.</value>
        public bool ShowHelp
        {
            get{ return m_bShowHelp; }
            set { m_bShowHelp = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show 2 Sides Thumbs].
        /// </summary>
        /// <value><c>true</c> if [show 2 Sides Thumbs]; otherwise, <c>false</c>.</value>
        public bool Show2SidesThumbs
        {
            get { return m_bShow2SidesThumbs; }
            set { m_bShow2SidesThumbs = value; }
        }

    }
        
    public class ReelStands
    {
        string m_strReelStand;
        public ReelStands()
        {
            m_strReelStand = "RS01";
        }
        public string Name
        {
            get { return m_strReelStand; }
            set { m_strReelStand = value; }
        }
    }
    public class PressSPU
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PressSPU"/> class.
        /// </summary>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>       
        public PressSPU()
        {
            m_strSPUName = "";
            m_strCOMMPort = "";
            m_strIPAddress = "0.0.0.0";
            m_strcommType = CommType.Serial;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PressSPU"/> class.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="commName">Name of the comm.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <history>
        ///     21-Apr-14, Mark C, WI36192: Added support for IPAddress
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        public PressSPU(string spuName, string commType, string commName, string ipAddress)
        {
            m_strSPUName = spuName;
            m_strcommType = commType;
            m_strCOMMPort = commName;
            m_strIPAddress = ipAddress;
        }

        /// <summary>
        /// Gets or sets the name of the spu.
        /// </summary>
        /// <value>
        /// The name of the spu.
        /// </value>
        public string SPUName
        {
            get { return m_strSPUName; }
            set { m_strSPUName = value; }
        }

        /// <summary>
        /// Gets or sets the spu comm port.
        /// </summary>
        /// <value>
        /// The spu comm port.
        /// </value>
        public string SPUCommPort
        {
            get { return m_strCOMMPort; }
            set { m_strCOMMPort = value; }
        }

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>
        /// The ip address.
        /// </value>
        public string IPAddress
        {
            get { return m_strIPAddress; }
            set { m_strIPAddress = value; }
        }

        /// <summary>
        /// Gets or sets the type of the comm.
        /// </summary>
        /// <value>
        /// The type of the comm.
        /// </value>
        public string COMMType
        {
            get { return m_strcommType; }
            set { m_strcommType = value; }
        }

        #region Implementation
                
        string m_strcommType;
        string m_strSPUName;
        string m_strCOMMPort;
        string m_strIPAddress;

        #endregion
    }

    /// <![CDATA[              
    /// 
    /// Author: 
    /// History: 15-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
    ///         
    /// ]]>
    /// <summary>
    /// MicroColor / Mercury Inker configuration data
    /// </summary>
    public class MCInker
    {
        string m_strInkerName;
        bool m_bFirstKeyOperatorSide;
        int  m_nUpperOrLowerInker;
        string m_strUpperLowerInker;
        float m_fServoTurns;
        int m_nTotalKeys;
        ArrayList m_ayInkerKeys;
        int m_iMinConsoleVal;
        int m_iMaxConsoleVal;
        int m_iTotalBanks;
        ArrayList m_ayServoBanks;
        bool m_bInverted;
        int m_iLTIndex;
        int m_iLTSize;
        float m_fEachKeyWidth;
        int m_iCIP3ImageRotateDegrees;
        bool m_bCIP3DataRotation;
        bool m_isLeftSideToCIC;     // Is Inker on the left side to CIC? Applicable to CIC Press type
        MercuryAVTPLCInkerConfigVoltages m_avtPLCVoltages = new MercuryAVTPLCInkerConfigVoltages();
        private MercuryAVTPLCRegisterInkerConfig m_avtPLCRegister = new MercuryAVTPLCRegisterInkerConfig();


        public int CIP3ImageRotateDegrees
        {
            get { return m_iCIP3ImageRotateDegrees; }
            set { m_iCIP3ImageRotateDegrees = value; }
        }

        public bool CIP3DataRotation
        {
            get { return m_bCIP3DataRotation; }
            set { m_bCIP3DataRotation = value; }
        }

        public int TotalKeys
        {
            get { return m_nTotalKeys; }
            set { m_nTotalKeys = value; }
        }
        public string UpperLowerInker
        {
            get { return m_strUpperLowerInker; }
            set { m_strUpperLowerInker = value; }
        }
        public float KeyWidth
        {
            get { return m_fEachKeyWidth; }
            set { m_fEachKeyWidth = value; }
        }
        public bool Inverted
        {
            get { return m_bInverted; }
            set { m_bInverted = value; }
        }
        public bool KeyOneOPSide
        {
            get { return m_bFirstKeyOperatorSide; }
            set { m_bFirstKeyOperatorSide = value; }
        }
        public string ServoTurns
        {
            get { return m_fServoTurns.ToString(); }
            set
            {
                if (value == "")
                    return;
                m_fServoTurns = float.Parse(value);
            }

        }

        public string MinConsole
        {
            get { return m_iMinConsoleVal.ToString(); }
            set
            {
                if (value == "")
                    return;
                m_iMinConsoleVal = int.Parse(value);
            }
        }

        public string MaxConsole
        {
            get { return m_iMaxConsoleVal.ToString(); }
            set
            {
                if (value == "")
                    return;
                m_iMaxConsoleVal = int.Parse(value);
            }
        }

        public string LinTableSize
        {
            get { return m_iLTSize.ToString(); }
            set
            {
                if (value == "")
                    return;
                m_iLTSize = int.Parse(value);
            }

        }
        public bool UpperOrLower
        {
            get
            {
                if (m_nUpperOrLowerInker > 0)
                    return true;
                return false;
            }
            set
            {
                m_nUpperOrLowerInker = (value == true) ? 1 : 0;
            }
        }
        public void InitInkerKey()
        {
            m_ayInkerKeys.Clear();
            for (int iKey = 0; iKey < m_nTotalKeys; iKey++)
            {
                MCInkerKeys inkerKey = new MCInkerKeys();
                inkerKey.KeyWidth = m_fEachKeyWidth;
                m_ayInkerKeys.Add(inkerKey);
            }
        }

        public bool IsLeftSide
        {
            get { return m_isLeftSideToCIC; }
            set { m_isLeftSideToCIC = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCInker"/> class.
        /// </summary>
        /// <history>
        /// 01-May-2013, Mark C, WI30688: Set linear table size to 100 (NO NFS)
        ///     by default.
        /// 5-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// </history>
        public MCInker()
        {
            m_bFirstKeyOperatorSide = true;
            m_nUpperOrLowerInker = (int)MCNWSiteGen.INKERTYPE.UPPER;
            m_strUpperLowerInker = "Upper";
            m_fServoTurns = 0.7f;
            m_nTotalKeys = 0;
            m_ayServoBanks = new ArrayList();
            m_ayInkerKeys = new ArrayList();
            m_fEachKeyWidth = 27.725f;
            m_iMinConsoleVal = 0;
            m_iMaxConsoleVal = 99;
            m_iTotalBanks = 0;           
            m_bInverted = false;
            m_iLTIndex = 0;
            m_iLTSize = 100; // default will be NO NFS while creating a new Site XML
            m_isLeftSideToCIC = true;   // set the Inker on the left side to CIC ( default )
        }
        //=============================================================================
        ///<Function Name>AddServoBank </Function>
        /// <Auther> Chetan              09/10/2008</Auther>
        /// <summary>
        /// Add Servo Bank
        /// </summary>
        /// <param name=>ServoBanks </param>
        /// <returns></returns>
        /// <History>Hema Kumar Dt:11/18/2008 MT#11891
        /// 
        /// </History>
        /// ======================================================================================
        public void AddServoBank(ServoBanks servoBank)
        {
            m_ayServoBanks.Add(servoBank);
            //m_iTotalBanks++;
            m_iTotalBanks = m_ayServoBanks.Count;
        }
        public ServoBanks GetServoBankAt(int iBank)
        {
            if (m_ayServoBanks == null)
                return null;
            if (iBank > m_ayServoBanks.Count)
                return null;
            return ((ServoBanks)(m_ayServoBanks[iBank]));
        }
        public void ClearServoBanks()
        {
            if (m_ayServoBanks == null)
                m_ayServoBanks = new ArrayList();

            m_ayServoBanks.Clear();
            m_iTotalBanks = 0;
        }
        public string InkerName
        {
            get { return m_strInkerName; }
            set { m_strInkerName = value; }
        }

        public bool FirstKeyOperatorSide
        {
            get { return m_bFirstKeyOperatorSide; }
            set { m_bFirstKeyOperatorSide = value; }
        }

        public int UpperOrLowerInker
        {
            get { return m_nUpperOrLowerInker; }
            set { m_nUpperOrLowerInker = value; }
        }

        public ArrayList InkerKeys
        {
            get { return m_ayInkerKeys; }
            set { m_ayInkerKeys = value; }
        }

        public float EachKeyWidth
        {
            get { return m_fEachKeyWidth; }
            set { m_fEachKeyWidth = value; }
        }

        public int MinConsoleVal
        {
            get { return m_iMinConsoleVal; }
            set { m_iMinConsoleVal = value; }
        }

        public int MaxConsoleVal
        {
            get { return m_iMaxConsoleVal; }
            set { m_iMaxConsoleVal = value; }
        }

        public int TotalBanks
        {
            get { return m_iTotalBanks; }
            set { m_iTotalBanks = value; }
        }

        public ArrayList ServoBanks
        {
            get { return m_ayServoBanks; }
            set { m_ayServoBanks = value; }
        }
               
        public int LTIndex
        {
            get { return m_iLTIndex; }
            set { m_iLTIndex = value; }
        }

        public int LTSize
        {
            get { return m_iLTSize; }
            set { m_iLTSize = value; }
        }

        /// <summary>
        /// Creates the servo banks.
        /// </summary>
        /// <history>
        ///     17-Aug-12, Mark C, WI29261: Create servo banks
        /// </history>
        public void CreateServoBanks()
        {
            m_ayServoBanks.Clear();
            for (int index = 0; index < m_iTotalBanks; ++index )
            {
                m_ayServoBanks.Add(new ServoBanks());
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Voltage parameters ( Press Speed, Sweep Input and Water Output )
        ///         
        /// ]]>
        /// <summary>
        /// Gets the AVT PLC voltages.
        /// </summary>
        /// <value>
        /// The AVT PLC voltages.
        /// </value>
        public MercuryAVTPLCInkerConfigVoltages AVTPLCVoltages
        {
            get { return m_avtPLCVoltages; }
        }

        /// <summary>
        /// Gets or sets the AVT PLC register configuration.
        /// </summary>
        /// <value>
        /// The AVT PLC register configuration.
        /// </value>
        public MercuryAVTPLCRegisterInkerConfig AVTPLCRegister
        {
            get { return m_avtPLCRegister; }
            set { m_avtPLCRegister = value; }
        }
    }

    public class MCPressUnit
    {
        string m_strUnitName;
        int     m_nInkers;
        ArrayList m_ayInkers;
        public MCPressUnit()
        {
            m_strUnitName = "";
            m_nInkers = 1;
            m_ayInkers = new ArrayList();
        }
        
        public int TotalInkers
        {
            get{return m_nInkers;}
            set
            {
                m_nInkers = value;
                m_ayInkers.Clear();
            }
        }

        public int InkerCount
        {
            get { return m_ayInkers.Count; }
        }
        public void InitializeInker(MCInker mcInker)
        {
            m_ayInkers.Add(mcInker);
        }
        public object GetInkerAt(int iInker)
        {
            if (iInker < m_ayInkers.Count)
                return (object)m_ayInkers[iInker];
            return null;
        }

        public string UnitName
        {
            get { return m_strUnitName; }
            set { m_strUnitName = value; }
        }

        /// <summary>
        /// Creates the inkers.
        /// </summary>
        /// <history>
        ///     17-Aug-12, Mark C, WI29261: Create inkers
        /// </history>
        public void CreateInkers()
        {
            m_ayInkers.Clear();
            for (int index = 0; index < m_nInkers; index++ )
            {
                m_ayInkers.Add(new MCInker());
            }
        }

        /// <summary>
        /// Gets the inker list.
        /// </summary>
        /// <history>
        ///     17-Aug-12, Mark C, WI29261: Get inkers list
        /// </history>
        public ArrayList InkerList
        {
            get { return m_ayInkers; }
        }
    }
    public class TurnBars
    {
        string m_strName;
        string m_strAfterWhichUnit;
        bool m_bActive;
        public TurnBars()
        {
            m_strName = "";
            m_strAfterWhichUnit = "";
            m_bActive = false;
        }
        public string Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }
        public string Predecessor
        {
            get { return m_strAfterWhichUnit; }
            set { m_strAfterWhichUnit = value; }
        }
        public bool Checked
        {
            get { return m_bActive; }
            set { m_bActive = value; }
        }
    }
    public class MCPressInfo
    {
        string  m_strPressName;
        int     m_nPressType;
        float   m_fPressWidth;
        int     m_nFolderCount;
        ArrayList m_ayPressFolders;
        int     m_nPressUnit  = 2;                
        ArrayList m_ayPressUnits;
        ArrayList m_UnitGroups;
        ArrayList m_ayReelStands;				// available reelstands.

        ArrayList m_ayPresSPUS;
        PressClientInterface m_ayPressClientInterface;
        MCClientInterfaceFeatures m_MCClientInterface;
        MCPressConsoleZones m_MCPressConsoleZones;
        MCPressNFSTable m_MCPressNFSTable;
        SweepControlInterface m_MCSweepCtrlInterface;
        WaterControlInterface m_MCWaterCtrlInterface;
        ArrayList m_ayTurnBars;
        //arrary for all the inkers in the system - NEW
        ArrayList m_ayInkers;
        MCAutoTest autoTest;
        MCSweepTest sweepTest;
        PressSPU pressSpu;
        SweepMotorServoControlInterface sweepMotorServoInterface;
        WaterMotorServoControlInterface waterMotorServoInterface;
        ArrayList sweepServo;
        ArrayList waterServo;
        AutoScanCal autoScanCal;
        int m_iMostCommonKeysPerFountain = 16;
        int m_iDisplayKeys = 16;

        private bool isCLCOEM;
        private string clcIPAddress;
        private ushort clcCQPort;
        private bool autoZeroServosEnabled = true; //WI37033 - Enable Auto Zero calibration by default
        private PressAutoZero m_pressAutoZero;
        private byte maxFountainPortCountPerSPU = 6;
        private List< AirbarConfigurationDetails > m_listAirbarConfiguration;
        private int m_totalNumberOfWebs = 2;

        // Press constructor data from 1.PRS file, applicable only for Tower press        
        private readonly CMCImpositionPressConstructor m_impositionPRS = new CMCImpositionPressConstructor( );	

        /// <summary>
        /// Gets or sets a value indicating whether [auto zero servos enabled].
        /// </summary>
        /// <value><c>true</c> if [auto zero servos enabled]; otherwise, <c>false</c>.</value>
        public bool AutoZeroServosEnabled
        {
            get { return autoZeroServosEnabled; }
            set { this.autoZeroServosEnabled = value; }
        }
        
        public int PressType
        {
            get
            {
                return m_nPressType;
            }
            set
            {
                m_nPressType = value;
            }
        }
        
        public ArrayList UnitGroups
        {
            get
            {
                return m_UnitGroups;
            }
            set
            {
                m_UnitGroups = value;
            }
        }

        /// <![CDATA[
        /// 
        /// Property: KeysPerFrame 
        ///
        /// Author: Suresh
        /// 
        /// History: Crested for ENH: , MAR-18-2010
        /// 
        /// ]]>
        /// <summary>
        /// Get and Set for keys to display on client
        /// </summary>
        public int DisplayKeys
        {
            get { return m_iDisplayKeys; }
            set { m_iDisplayKeys = value; }
        }

        /// <![CDATA[
        /// 
        /// Property: IsCLCOEM 
        ///
        /// Author: LMask
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// 
        /// ]]>
        /// <summary>
        /// Get and Set to handle whether the system is part of the clc
        /// </summary>
        public bool IsCLCOEM
        {
            get { return isCLCOEM; }
            set { this.isCLCOEM = value; }
        }

        /// <![CDATA[
        /// 
        /// Property: CLCIPAddress 
        ///
        /// Author: Lonnie Mask
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// 
        /// ]]>
        /// <summary>
        /// Get and Set for the IP address of the CQ server
        /// </summary>
        public string CLCIPAddress
        {
            get { return clcIPAddress; }
            set { this.clcIPAddress = value; }
        }

        /// <![CDATA[
        /// 
        /// Property: CLCCQPort 
        ///
        /// Author: Lonnie Mask
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// 
        /// ]]>
        /// <summary>
        /// Get and Set for the port of the CQ Server
        /// </summary>
        public ushort CLCCQPort
        {
            get { return clcCQPort; }
            set { this.clcCQPort = value; }
        }

        public int GetNumPressUnitGroups()
        {
            return m_UnitGroups.Count;
        }
        public void SetPressUnitGroupAt(int byIndex, UnitGroupMembers PressUnitGroup)
        {
            if (byIndex >= 0)
                m_UnitGroups[byIndex] = PressUnitGroup;
        }
        public UnitGroupMembers GetGroupByName(string strName)
        {
            foreach (UnitGroupMembers Group in m_UnitGroups)
            {
                if (Group.Name.CompareTo(strName) == 0)
                    return Group;
            }
            return null;
        }
        public UnitGroupMembers GetPressUnitGroupAt(int iIndex)
        {
            if ((iIndex < 0) || (iIndex >= m_UnitGroups.Count))
                return null;
            return (UnitGroupMembers)m_UnitGroups[iIndex];
        }


        /// <summary>
        /// Gets or sets the total units.
        /// </summary>
        /// <value>
        /// The total units.
        /// </value>
        /// <history>
        ///     03-Apr-13, Mark C, WI 30603: Changed to allow more than
        ///         6 inker ports per SPU
        /// </history>
        public int TotalUnits
        {
            get 
            {
                if (m_ayPressUnits.Count > 0)
                    return m_ayPressUnits.Count;
                else if (m_ayPresSPUS.Count > 0)
                    return (maxFountainPortCountPerSPU * m_ayPresSPUS.Count);
                else
                    return m_nPressUnit; 
            }
            set { m_nPressUnit = value; }
        }

        public MCClientInterfaceFeatures ClientInterface
        {
            get { return m_MCClientInterface; }
            set { m_MCClientInterface = value; }
        }
        public MCAutoTest AutoTest
        {
            get { return autoTest; }
            set { autoTest = value; }
        }
        public MCSweepTest SweepTest
        {
            get { return sweepTest; }
            set { sweepTest = value; }
        }
        public PressClientInterface PressClientInterface
        {
            get
            {
                return m_ayPressClientInterface;
            }
            set
            {
                m_ayPressClientInterface = value;
            }
        }

        public MCPressConsoleZones OCUInterface
        {
            get { return m_MCPressConsoleZones; }
        }
        public SweepControlInterface SweepInterface
        {
            get { return m_MCSweepCtrlInterface; }
        }
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface
        public WaterControlInterface WaterInterface
        {
            get { return m_MCWaterCtrlInterface; }
        }
        public MCPressNFSTable NFSTable
        {
            get { return m_MCPressNFSTable; }
        }
        //public int TotalUnits
        //{
        //    get { return m_nPressUnit; }
        //    set { m_nPressUnit = value; }
        //}
        public void InitTotalSPUS(int iTotalSPUS)
        {
            if( m_ayPresSPUS != null )
                m_ayPresSPUS.Clear();
            m_ayPresSPUS = new ArrayList();

            for (int iSPU = 0; iSPU < iTotalSPUS; iSPU++)
            {
                PressSPU spu = new PressSPU();
                m_ayPresSPUS.Add(spu);
            }
        }
        public void InitTotalTurnBars(int iTotalTurnBars)
        {
            if (m_ayTurnBars != null)
                m_ayTurnBars.Clear();
            m_ayTurnBars = new ArrayList();

            for (int iTurnBar = 0; iTurnBar < iTotalTurnBars; iTurnBar++)
            {
                TurnBars turn = new TurnBars();
                m_ayTurnBars.Add(turn);
            }
        }
        public int GetTotalSPUS()
        {
            if( m_ayPresSPUS != null )
                return m_ayPresSPUS.Count;
            return 0;
        }
        public void SetSPUParams(int iSPU, string strCOMMPort,string strSPUName)
        {
            if (iSPU < m_ayPresSPUS.Count)
            {
                PressSPU spu = (PressSPU)m_ayPresSPUS[iSPU];
                spu.SPUCommPort = strCOMMPort;
                spu.SPUName = strSPUName;
            }
        }
        public PressSPU SPU(int iSPU)
        {
            if (m_ayPresSPUS != null)
            {
                if (iSPU < m_ayPresSPUS.Count)
                    return ((PressSPU)m_ayPresSPUS[iSPU]);

                return null;
            }
            return null;
        }
       
        public MCPressUnit GetUnitAt(int iUnit)
        {
            if (iUnit < m_ayPressUnits.Count)
                return (MCPressUnit)m_ayPressUnits[iUnit];

            return null;
        }
        public string PressName
        {
            get
            {
                return m_strPressName;
            }
            set
            {
                m_strPressName = value;
            }

        }
        public float PressWidth
        {
            get
            {
                return m_fPressWidth;
            }
            set
            {
                m_fPressWidth = value;
            }
        }
        //public int PressType
        //{
        //    get
        //    {
        //        return m_nPressType;
        //    }
        //    set
        //    {
        //        m_nPressType = value;
        //    }
        //}
        public int FolderCount
        {
            get
            {
                return m_nFolderCount;
            }
            set
            {
                m_nFolderCount = value;
            }
        }
        public ArrayList PressFolderName
        {
            get
            {
                return m_ayPressFolders;
            }
            set
            {
                m_ayPressFolders = value;
            }
        }
        public ArrayList ReelStands
        {
            get
            {
                return m_ayReelStands;
            }
            set
            {
                m_ayReelStands = value;
            }
        }
        //REELSTANDS
        public void SetPressReelStandAt(int byIndex, ReelStands ReelStand)
        {
            if (byIndex > 0)
                m_ayReelStands[byIndex] = ReelStand;
        }

        public ReelStands GetPressReelStandAt(int byIndex)
        {
            if ((byIndex < 0) || (byIndex >= m_ayReelStands.Count))
                return null;
            else
                return (ReelStands)m_ayReelStands[byIndex];
        }

        public int GetNumReelStands()
        {
            return m_ayReelStands.Count;
        }
        // SPU
        public PressSPU GetSPUAt(byte byIndex)
        {
            if ((byIndex < 0) || (byIndex > m_ayPresSPUS.Count))
                return null;
            else
                return (PressSPU)m_ayPresSPUS[byIndex];
        }
        public byte GetNumOfSPUs() { return (byte)m_ayPresSPUS.Count; }
        //public Turnbars GetTurnBarAt(byte byIndex)
        //{
        //    if ((byIndex < 0) || (byIndex > m_ayTurnBars.Count))
        //        return null;
        //    else
        //        return (Turnbars)m_ayTurnBars[byIndex];
        //}

        //======================================================================================
        /// <![CDATA[
        /// <Function>GetMostCommonKeysPerFountain</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Gets Most Common Keys Per Fountain
        /// </summary>
        /// <History>
        /// Hema Kumar MT: 15015, 15017 Dt: Jan-13-2010
        /// Hema Kumar MT: 15495, Dt: MAr-25-2010
        /// </History>
        /// ]]>
        ///=====================================================================================
        public int GetMostCommonKeysPerFountain()
        {
            int iMaxFountainKeys = MCNWSiteGen.DefineAndConst.SystemCapacities.CQ_MAX_FOUNTAIN_KEYS;
            int [] ayKeyNums = new int[iMaxFountainKeys+1];

            for (int iUnit = 0; iUnit < TotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    int iTotalKeys = mcInker.TotalKeys;
                    m_iMostCommonKeysPerFountain = iTotalKeys;
                    if (iTotalKeys < iMaxFountainKeys)
                    {
                        ayKeyNums[iTotalKeys]++;
                    }
                }
            }
            //find the most used number
            int iMax =0;
            int iRet= 0;
            for (int iI = 1; iI <= MCNWSiteGen.DefineAndConst.SystemCapacities.CQ_MAX_FOUNTAIN_KEYS; iI++)
            {
                if (iMax < ayKeyNums[iI])
                {
                    iMax = ayKeyNums[iI];
                    iRet = iI;
                }
            }
            if (iMax == 0)
                iMax = m_iMostCommonKeysPerFountain;
            else
                iMax = iRet;
            return iMax;
        }

        public void SetMostCommonKeysPerFountain(int iVal)
        {
            if (iVal <= DefineAndConst.SystemCapacities.CQ_MAX_FOUNTAIN_KEYS)
                m_iMostCommonKeysPerFountain = iVal;
        }

        public ArrayList UnitList
        {
            get
            {
                return this.m_ayPressUnits;
            }
        }

        //======================================================================================
        /// <Function>GenerateUnits</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Generate Units
        /// </summary>
        /// 
        ///=====================================================================================
        public void GenerateUnits()
        {
            m_ayPressUnits.Clear();
            for (int iUnit = 1; iUnit <= m_nPressUnit; iUnit++)
            {
                MCPressUnit pressUnit = new MCPressUnit();
                string strUnit = "Unit" + iUnit.ToString();
                pressUnit.UnitName = strUnit;
                m_ayPressUnits.Add(pressUnit);
            }
        }

        ///<history>
        /// 13-Aug-12, Mark C, WI28788: Added support for storing PressAutoZero settings
        /// 23-Apr-13, Mark C, WI30347: Create a list for holding Airbar details
        ///</history>
        /// <summary>
        /// Initializes a new instance of the <see cref="MCPressInfo"/> class.
        /// </summary>
        public MCPressInfo()
        {
            m_strPressName = "PRESS NAME";
            m_nPressType   = 0;
            m_fPressWidth  = 137.7f;
            m_nFolderCount = 1;
            m_ayPressFolders = new ArrayList();
            // Initialize FOLDER FO1 by Default.            
            for (int iFolder = 1; iFolder <= m_nFolderCount; iFolder++)
            {
                string strFolderName = "FO" + iFolder.ToString();
                m_ayPressFolders.Add(strFolderName);
            }
            m_nPressUnit = 2;
            m_iMostCommonKeysPerFountain = 16;
        
            m_ayPressUnits = new ArrayList();                                 
            m_UnitGroups = new ArrayList();            
            m_ayReelStands = new ArrayList();
            m_ayPressClientInterface = new PressClientInterface();
            m_MCClientInterface = new MCClientInterfaceFeatures();
            m_MCPressConsoleZones = new MCPressConsoleZones();
            m_ayPresSPUS = new ArrayList();
            for (int iSup = 0; iSup < m_ayPresSPUS.Count; iSup++)
            {
                PressSPU SPU = new PressSPU();
                m_ayPresSPUS.Add(SPU);
            }
            m_MCPressNFSTable = new MCPressNFSTable();
            m_MCSweepCtrlInterface = new SweepControlInterface();
            m_MCWaterCtrlInterface = new WaterControlInterface();
            m_ayTurnBars = new ArrayList();
            for (int iTurnBar = 0; iTurnBar < 2; iTurnBar++)
            {
                TurnBars turnBar = new TurnBars();
                m_ayTurnBars.Add(turnBar);
            }
            m_ayInkers = new ArrayList();
            pressSpu = new PressSPU();
            autoTest = new MCAutoTest();
            sweepTest = new MCSweepTest();
            sweepServo = new ArrayList();
            waterServo = new ArrayList();
            sweepMotorServoInterface = new SweepMotorServoControlInterface();
            waterMotorServoInterface = new WaterMotorServoControlInterface();
            autoScanCal = new AutoScanCal();
            m_pressAutoZero = new PressAutoZero();
            m_listAirbarConfiguration = new List<AirbarConfigurationDetails>();
        }
        public void GenerateInkerList()
        {
            for (int idx = 0; idx < m_ayPressUnits.Count; idx++)
            {
                MCPressUnit aUnit = GetPressUnitAt(idx);
                for (int inker = 0; inker < aUnit.InkerCount; inker++)
                {
                    MCInker aInker = (MCInker)aUnit.GetInkerAt(inker);
                    m_ayInkers.Add(aInker);

                }
            }
        }

        public ArrayList InkerList
        {
            get { return m_ayInkers; }
            set { m_ayInkers = value; }
        }

        public int TotalTurnBars
        {
            get { 
                if( m_ayTurnBars != null)
                    return m_ayTurnBars.Count;
                return 0;
            }
        }

        public TurnBars GetTurnBarByName(string TBarName)
        {
            for (int i = 0; i < m_ayTurnBars.Count; i++)
            {
                TurnBars TurnBar = this.GetTurnBarAt(i);
                if (TurnBar != null)
                {
                    if (TurnBar.Name == TBarName)
                    {
                        return TurnBar;
                    }
                }
            }
            return null;
        }

        public TurnBars GetTurnBarAt(int iIndex)
        {
            if ((iIndex < 0) || (iIndex >= m_ayTurnBars.Count))
                return null;
            return (TurnBars)m_ayTurnBars[iIndex];
        }
        public void ClearAllTurnBars()
        {
            m_ayTurnBars.Clear();
            m_ayTurnBars = new ArrayList();
        }
        public void AddTurnBar(TurnBars turnBar)
        {
            m_ayTurnBars.Add(turnBar);
        }
        public MCPressUnit GetUnitByName(string strUnitName)
        {
            for (int idx = 0; idx < m_ayPressUnits.Count; idx++)
            {
                MCPressUnit pPUnit = GetPressUnitAt(idx);
                string strPName = pPUnit.UnitName;
                if (strPName.CompareTo(strUnitName) == 0)
                {
                    return pPUnit;
                }
            }
            return null;
        }
        public MCPressUnit GetPressUnitAt(int index)
        {
            if (index >= m_ayPressUnits.Count)
                return null;
            else
                return (MCPressUnit)m_ayPressUnits[index];
        }
        public TurnBars TurnBar(int iTurnBar)
        {
            if (m_ayTurnBars != null)
            {
                if (iTurnBar < m_ayTurnBars.Count)
                    return ((TurnBars)(m_ayTurnBars[iTurnBar]));
                
                return null;
            }
            return null;
        }
        public MCClientInterfaceFeatures MCClientInterface
        {
            get
            {
                return m_MCClientInterface;
            }
            set
            {
                m_MCClientInterface = value;
            }
        }
        public ArrayList SweepServo
        {
            get {return sweepServo;}
            set {sweepServo = value;}
        }
        public ArrayList WaterServo
        {
            get {return waterServo;}
            set {waterServo = value;}
        }
        public SweepMotorServoControlInterface SweepMotorServoControl
        {
            get { return sweepMotorServoInterface; }
            set {sweepMotorServoInterface = value; }
        }
        public WaterMotorServoControlInterface WaterMotorServoControl
        {
            get { return waterMotorServoInterface; }
            set { waterMotorServoInterface = value; }
        }

        public bool IsWidePress()
        {
            bool bret = false;
            for (int i = 0; i < InkerList.Count; i++)
            {
                MCInker aInker = InkerList[i] as MCInker;
                if( aInker.TotalKeys > DefineAndConst.SystemCapacities.MAX_SERVOS_PER_SPU_PORT )
                    return true;
            }
            return bret;
        }
        public AutoScanCal AutoScanCalibration
        {
            get { return autoScanCal; }
            set { autoScanCal = value; }
        }

        /// <summary>
        /// Gets the press auto zero.
        /// </summary>
        public PressAutoZero PressAutoZero
        {
            get { return m_pressAutoZero; }            
        }

        /// <summary>
        /// Gets the press SPU list.
        /// </summary>
        /// <history>
        ///     17-Aug-12, Mark C, WI29261: Get SPU list
        /// </history>
        public ArrayList PressSPUList
        {
            get { return m_ayPresSPUS; }
        }

        /// <summary>
        /// Gets or sets the max fountain port count per SPU.
        /// </summary>
        /// <value>
        /// The max fountain port count per SPU.
        /// </value>
        /// <history>
        ///     03-Apr-13, Mark C, WI30603: Created
        /// </history>
        public byte MaxFountainPortCountPerSPU
        {
            get { return maxFountainPortCountPerSPU; }
            set { maxFountainPortCountPerSPU = value; }
        }

        /// <summary>
        /// Gets the airbar list.
        /// </summary>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Created
        /// </history>
        public List<AirbarConfigurationDetails> AirbarList
        {
            get { return m_listAirbarConfiguration; }
        }

        /// <summary>
        /// Gets or sets the total number of webs.
        /// </summary>
        /// <value>
        /// The total number of webs.
        /// </value>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Created
        /// </history>
        public int TotalNumberOfWebs
        {
            set { m_totalNumberOfWebs = value; }
            get { return m_totalNumberOfWebs; }
        }

        /// <summary>
        /// Initializes the airbar list.
        /// </summary>
        /// <param name="listSize">Size of the list.</param>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Created
        /// </history>
        public void InitializeAirbarList(int listSize)
        {
            // clear the list first
            AirbarList.Clear();
            for (int airbarIndex = 0; airbarIndex < listSize; ++airbarIndex)
            {
                AirbarList.Add(new AirbarConfigurationDetails());
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-15, Mark C, WI57901: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the PRS data.
        /// </summary>
        /// <value>
        /// The PRS data.
        /// </value>
        public CMCImpositionPressConstructor PRSData
        {
            get { return m_impositionPRS; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is CIC press.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is CIC press; otherwise, <c>false</c>.
        /// </value>
        public bool IsCICPress
        {
            get { return (enPressTypes.SINGLE_SIDED_CIC_PRESS == (enPressTypes)PressType); }
        }
    }
     
    class MCSiteConfigData
    {
        public const ushort DEFAULT_CLC_CQ_PORT = 8545;

        private static string m_applicationBuiltTime = string.Empty;
        private static string m_versionString = string.Empty;

        float m_fSYSTEMCONFIGVERSION;
        string    m_strSITENAME;
        int       m_nSITENUMBER;
        ArrayList m_MCPresses;
        int       m_nPressCount;
        MC3ProductOptions m_productOptions = new MC3ProductOptions();
        MC3ServerConfiguration m_serverConfiguration = new MC3ServerConfiguration();
        MercuryServerOptions m_serverOptions = new MercuryServerOptions();
        MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();
        MercuryGUIOptions m_guiOptions = new MercuryGUIOptions();

        public enum MCSITEFILETAGS
        {
        };

        /// <![CDATA[
        /// 
        /// Function: AddPress
        ///
        /// Author: Someone
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        ///             set the default port
        /// 
        /// ]]>
        /// <summary>
        /// Add a new press to the container
        /// </summary>
        public void AddPress()
        {
            MCPressInfo mcPress = new MCPressInfo ();

            // set the port to the default
            mcPress.CLCCQPort = DEFAULT_CLC_CQ_PORT;

            m_MCPresses.Add(mcPress);
        }

        public void RemovePress()
        {
            m_MCPresses.RemoveAt(m_MCPresses.Count - 1);
        }
        
        public MCPressInfo GetPressAt(int iPressIdx)
        {
            if (iPressIdx < m_MCPresses.Count)
                return (MCPressInfo)m_MCPresses[iPressIdx];
            else
                return null;
        }
        
        public float SystemConfig
        {
            get { return m_fSYSTEMCONFIGVERSION; }
            set { m_fSYSTEMCONFIGVERSION = value; }
        }
        
        public int PressCount()
        {
            return m_MCPresses.Count;
        }
        
        public string SiteName
        {
            get { return m_strSITENAME; }
            set { m_strSITENAME = value; }
        }
        
        public int SiteNumber
        {
            get { return m_nSITENUMBER; }
            set { m_nSITENUMBER = value; }
        }


        /// <summary>
        /// Gets the product options.
        /// </summary>
        public MC3ProductOptions ProductOptions
        {
            get { return m_productOptions; }   
        }

        /// <summary>
        /// Gets the Server Configuration.
        /// </summary>
        public MC3ServerConfiguration ServerConfiguration
        {
            get { return m_serverConfiguration; }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 06-Dec-16, Mark C, WI67306: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the server options.
        /// </summary>
        /// <value>
        /// The server options.
        /// </value>
        public MercuryServerOptions ServerOptions
        {
            get { return m_serverOptions; }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Created
        ///         
        /// ]]>
        /// <summary>
        /// Gets the AVT PLC configuration.
        /// </summary>
        /// <value>
        /// The AVT PLC configuration.
        /// </value>
        public MercuryAVTPLCConfig AVTPLCConfig
        {
            get { return m_avtPLCConfig; }
        }

        /// <summary>
        /// Gets the GUI options.
        /// </summary>
        /// <value>
        /// The GUI options.
        /// </value>
        public MercuryGUIOptions GUIOptions
        {
            get { return m_guiOptions; }
        }

        /// <![CDATA[
        /// 
        /// Function: Constructor
        ///
        /// Author: Someone
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        ///             Modified to call the function that already creates presses
        ///          28-Oct-14, Mark C, WI41821: Initialize Mercury Server's IP Address
        /// ]]>
        /// <summary>
        /// Constructor
        /// </summary>
        public MCSiteConfigData()
        {
            m_nPressCount = 1;
            m_fSYSTEMCONFIGVERSION = 1.0f;      //not used anywhere in SiteGen app
            m_strSITENAME = "MCNW";
            m_nSITENUMBER = 1111;
            m_MCPresses = new ArrayList();
            
            for (int iPress = 0; iPress < m_nPressCount; iPress++)
            {
               AddPress();
            }

            m_nPressCount = 0;            
            m_serverConfiguration.IPAddress = GetLocalHostIPAddress();
            // get the Application built time details
            m_applicationBuiltTime = GetApplicationbuiltTime();

        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Oct-14, Mark C, WI41821: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the local host IP address. Returns the first IP Address, if there are more than one NIC available.
        /// </summary>
        /// <returns></returns>
        private string GetLocalHostIPAddress()
        {            
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
        }
        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the applicationbuilt time.
        /// </summary>
        /// <returns></returns>
        private static string GetApplicationbuiltTime()
        {
            string strExePath = Application.ExecutablePath;
            return File.GetLastWriteTime(strExePath).ToString();
        }
        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the application built time.
        /// </summary>
        /// <value>
        /// The application built time.
        /// </value>
        public static string ApplicationBuiltTime
        {
            get { return m_applicationBuiltTime; }
            set { m_applicationBuiltTime = value; }
        }
        /// <![CDATA[
        /// 
        /// Author: Mark C
        /// 
        /// History: 25-NOV-13, Mark C, WI33368, Added support to log message details between OCU3
        ///          and Mercury Client. 
        /// 
        /// ]]>
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public static string Version
        {
            get { return m_versionString; }
        }

    }


    /// <summary>
    /// 13-Aug-12, Mark C, WI28788: Created
    /// 07-May-13, BEttinger, WI30488: added code to support multi-source Auto Zero
    /// </summary>
    public class PressAutoZero
    {
        #region methods

        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Added new member m_timeDelayToCloseFountain
        /// 
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="PressAutoZero"/> class.
        /// </summary>
        public PressAutoZero()
        {
            m_autoZeroEnabled = false;
            m_mode = 0;
            m_deviceIpAddress = "255.255.255.255";
            m_deviceID = 0;
            m_timeDelay = 0;
            m_pollTimePeriod = 0;
            m_factorFrequency = 0;
            m_idleThresholdFPM = 0;
            m_dryContactIdleState = false;
            m_timeDelayToCloseFountain = 30000;
              //WI30488
            m_iNumberOfDrySensors = 0;
            m_iNumberOfFrequencySensors = 0;
            m_dicAZchannelMap_Dry = new Dictionary<byte, string>();
            m_dicAZchannelMap_Frq = new Dictionary<byte, string>();
        }

        #endregion


        #region implementation

        /// <summary>
        /// Gets or sets a value indicating whether [auto zero enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [auto zero enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoZeroEnabled
        {
            set { m_autoZeroEnabled = value; }
            get { return m_autoZeroEnabled; }
        }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public byte Mode
        {
            set { m_mode = value; }
            get { return m_mode; }
        }

        /// <summary>
        /// Gets or sets the device IP address.
        /// </summary>
        /// <value>
        /// The device IP address.
        /// </value>
        public string DeviceIPAddress
        {
            set { m_deviceIpAddress = value; }
            get { return m_deviceIpAddress; }
        }

        /// <summary>
        /// Gets or sets the device ID.
        /// </summary>
        /// <value>
        /// The device ID.
        /// </value>
        public byte DeviceID
        {
            set { m_deviceID = value; }
            get { return m_deviceID; }
        }

        /// <summary>
        /// Gets or sets the time delay.
        /// </summary>
        /// <value>
        /// The time delay.
        /// </value>
        public int TimeDelay
        {
            set { m_timeDelay = value; }
            get { return m_timeDelay; }
        }

        /// <summary>
        /// Gets or sets the poll time period.
        /// </summary>
        /// <value>
        /// The poll time period.
        /// </value>
        public int PollTimePeriod
        {
            set { m_pollTimePeriod = value; }
            get { return m_pollTimePeriod; }
        }

        /// <summary>
        /// Gets or sets the factor frequency.
        /// </summary>
        /// <value>
        /// The factor frequency.
        /// </value>
        public int FactorFrequency
        {
            set { m_factorFrequency = value; }
            get { return m_factorFrequency; }
        }

        /// <summary>
        /// Gets or sets the idle threshold FPM.
        /// </summary>
        /// <value>
        /// The idle threshold FPM.
        /// </value>
        public int IdleThresholdFPM
        {
            set { m_idleThresholdFPM = value; }
            get { return m_idleThresholdFPM; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dry contact idle state].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [dry contact idle state]; otherwise, <c>false</c>.
        /// </value>
        public bool DryContactIdleState
        {
            set { m_dryContactIdleState = value; }
            get { return m_dryContactIdleState; }
        }


        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Added
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the time delay to close fountain.
        /// </summary>
        /// <value>
        /// The time delay to close fountain.
        /// </value>
        public int TimeDelayToCloseFountain
        {
            set { m_timeDelayToCloseFountain = value; }
            get { return m_timeDelayToCloseFountain; }
        }


        /// <![CDATA[
        /// 
        /// History: 
        ///         08-May-13, BEttinger, WI30488: Added
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the number of Dry sensors (channels).
        /// </summary>
        /// <value>
        /// The number of Dry sensors (channels).
        /// </value>
        public int NumberOfDrySensors
        {
            set { m_iNumberOfDrySensors = value; }
            get { return m_iNumberOfDrySensors; }
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         08-May-13, BEttinger, WI30488: Added
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the number of Frequency sensors (channels).
        /// </summary>
        /// <value>
        /// The number of Frequency sensors (channels).
        /// </value>
        public int NumberOfFrequencySensors
        {
            set { m_iNumberOfFrequencySensors = value; }
            get { return m_iNumberOfFrequencySensors; }
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         08-May-13, BEttinger, WI30488: Added
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the Dry channels map.
        /// </summary>
        /// <value>
        /// The Dry channels map.
        /// </value>
        public Dictionary<byte, string> DryChannelsMap
        {
            set {
                    m_dicAZchannelMap_Dry.Clear();
                    foreach (KeyValuePair<byte, string> kvp in value)
                    {
                        byte chanelId =  kvp.Key;
                        string unitName = kvp.Value;
                        m_dicAZchannelMap_Dry[chanelId] = unitName;
                    }
                }

            get { return m_dicAZchannelMap_Dry; }
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         08-May-13, BEttinger, WI30488: Added
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets the Frequency channels map.
        /// </summary>
        /// <value>
        /// The Frequency channels map.
        /// </value>
        public Dictionary<byte, string> FrqChannelsMap
        {
            set
            {
                m_dicAZchannelMap_Frq.Clear();
                foreach (KeyValuePair<byte, string> kvp in value)
                {
                    byte chanelId = kvp.Key;
                    string unitName = kvp.Value;
                    m_dicAZchannelMap_Frq[chanelId] = unitName;
                }
            }

            get { return m_dicAZchannelMap_Frq; }
        }

        #endregion

        #region members

        private bool m_autoZeroEnabled = false;
        private byte m_mode = 0;
        private string m_deviceIpAddress = "255.255.255.255";
        private byte m_deviceID = 0;
        private int m_timeDelay = 0;
        private int m_pollTimePeriod = 0;
        private int m_factorFrequency = 0;
        private int m_idleThresholdFPM = 0;
        private bool m_dryContactIdleState = false;
        private int m_timeDelayToCloseFountain = 30000;
              //WI30488
        private int m_iNumberOfDrySensors = 0;// number of AZ Dry sensors (Dry Contact ADAM channels)
        private int m_iNumberOfFrequencySensors = 0;// number of AZ Frquency sensors (Frequency ADAM channels)
        private Dictionary<byte, string> m_dicAZchannelMap_Dry;//Dry Contact channels map (channel id to Unit name)
        private Dictionary<byte, string> m_dicAZchannelMap_Frq;//Frequency channels map (channel id to Unit name)
        #endregion
    }
    /// <summary>
    /// 23-Apr-13, Mark C, WI30347: Created
    /// </summary>
    public class AirbarConfigurationDetails
    {
        #region methods

        /// <summary>
        /// Initializes a new instance of the <see cref="AirbarConfigurationDetails"/> class.
        /// </summary>
        public AirbarConfigurationDetails()
        {
            this.m_name = string.Empty;
            this.m_afterWhichUnit = string.Empty;
        }

        #endregion

        #region implementation

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { m_name = value; }
            get { return m_name;  }
        }

        /// <summary>
        /// Gets or sets the after which unit.
        /// </summary>
        /// <value>
        /// The after which unit.
        /// </value>
        public string AfterWhichUnit
        {
            set { m_afterWhichUnit = value; }
            get { return m_afterWhichUnit; }
        }

        #endregion

        #region members

        string m_name;
        string m_afterWhichUnit;

        #endregion
    }


    /// <summary>
    /// This class contains Mercury product options
    /// </summary>
    /// <history>
    ///     10-Jun-13, Mark C, WI30950: Created
    /// </history>
    public class MC3ProductOptions
    {

        #region methods

        /// <![CDATA[               
        ///
        /// Author: someone
        /// 
        /// History: 
        ///         23-Feb-16, Mark C, WI68970: Add support for Mercury Newspaper Navigation View option
 		/// 		09-Aug-16, Mark C, WI81328: Add support for label Towers with numbers option
        /// 
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="MC3ProductOptions"/> class.
        /// </summary>
        public MC3ProductOptions()
        {
            m_jobModeEnabled = false;
            m_keepOnlyLastVersionProfiles = false;
            m_promptZAINeededOnServerRestart = true;
            m_newspaperNavigationViewOption = false;
            m_labelTowersWithNumberOption = false;
        }

        #endregion

        #region implementation

        /// <summary>
        /// Gets or sets a value indicating whether [job mode enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [job mode enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool JobModeEnabled
        {
            get { return m_jobModeEnabled; }
            set { m_jobModeEnabled = value; }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Oct-13, Mark C, WI33030: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [keep only last version profiles].
        /// </summary>
        /// <value>
        /// <c>true</c> if [keep only last version profiles]; otherwise, <c>false</c>.
        /// </value>
        public bool KeepOnlyLastVersionProfiles
        {
            get { return m_keepOnlyLastVersionProfiles; }
            set { m_keepOnlyLastVersionProfiles = value; }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-14, Mark C, WI37511: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [prompt ZAI needed configuration server restart].
        /// </summary>
        /// <value>
        /// <c>true</c> if [prompt ZAI needed configuration server restart]; otherwise, <c>false</c>.
        /// </value>
        public bool PromptZAINeededOnServerRestart
        {
            get { return m_promptZAINeededOnServerRestart; }
            set { m_promptZAINeededOnServerRestart = value; }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Feb-16, Mark C, WI68970: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [newspaper navigation view option].
        /// </summary>
        /// <value>
        /// <c>true</c> if [newspaper navigation view option]; otherwise, <c>false</c>.
        /// </value>
        public bool NewspaperNavigationViewOption
        {
            get { return m_newspaperNavigationViewOption; }
            set { m_newspaperNavigationViewOption = value; }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 09-Aug-16, Mark C, WI81328: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets or sets a value indicating whether [label towers with numbers option].
        /// </summary>
        /// <value>
        /// <c>true</c> if [label towers with numbers option]; otherwise, <c>false</c>.
        /// </value>
        public bool LabelTowersWithNumbersOption
        {
            get { return m_labelTowersWithNumberOption; }
            set { m_labelTowersWithNumberOption = value; }
        }

        #endregion

        #region members

        private bool m_jobModeEnabled = false;
        private bool m_keepOnlyLastVersionProfiles = false;
        private bool m_promptZAINeededOnServerRestart = true;
        private bool m_newspaperNavigationViewOption = false;
        private bool m_labelTowersWithNumberOption = false;

        #endregion
    }


    /// <summary>
    /// This class holds the Mercury Server configuration details for SPU3 
    /// Ethernet communications - IP Address and Port number details
    /// </summary>
    /// <history>
    ///     28-Oct-14, Mark C, WI41281: Created
    /// </history>
    public class MC3ServerConfiguration
    {

        #region methods

        /// <summary>
        /// Initializes a new instance of the <see cref="MC3ServerConfiguration"/> class.
        /// </summary>
        public MC3ServerConfiguration()
        {
            m_IPAddress = string.Empty;
            m_serverPort = 1655;
        }

        #endregion

        #region implementation

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        /// <value>
        /// The IP address.
        /// </value>
        public string IPAddress
        {
            get { return m_IPAddress; }
            set { m_IPAddress = value; }
        }

        /// <summary>
        /// Gets or sets the port number.
        /// </summary>
        /// <value>
        /// The port number.
        /// </value>
        public int PortNumber
        {
            get { return m_serverPort; }
            set { m_serverPort = value; }
        }

        #endregion


        #region members
        
        private string m_IPAddress = string.Empty;
        private int m_serverPort = 1655;

        #endregion
    }


    /// <summary>
    /// Class to get PLC Name by PLC Type
    /// and to get PLC Type by PLC Name
    /// </summary>
    public class PLCNameAndType
    {
        /// <summary>
        /// Gets the type of the PLC.
        /// </summary>
        /// <param name="plcName">Name of the PLC.</param>
        /// <returns></returns>
        public static int GetPLCType(string plcName)
        {
            ePLCType plcType = ePLCType.ePLC_NILPETER;

            switch (plcName)
            {
                case DefineAndConst.StringConstant.PLC_AVT:
                    plcType = ePLCType.ePLC_AVT;
                    break;
                case DefineAndConst.StringConstant.PLC_CRABTREE:
                    plcType = ePLCType.ePLC_CRABTREE;
                    break;
                case DefineAndConst.StringConstant.PLC_DTOA:
                    plcType = ePLCType.ePLC_DTOA;
                    break;
                case DefineAndConst.StringConstant.PLC_NILPETER:
                    plcType = ePLCType.ePLC_NILPETER;
                    break;
                case DefineAndConst.StringConstant.PLC_RAGSDALE:
                    plcType = ePLCType.ePLC_RAGSDALE;
                    break;
                case DefineAndConst.StringConstant.PLC_TI:
                    plcType = ePLCType.ePLC_TI;
                    break;
                case DefineAndConst.StringConstant.PLC_AB_PLC5:
                    plcType = ePLCType.ePLC_ALLEN_BRADLEY;
                    break;
                case DefineAndConst.StringConstant.PLC_HO_DTOA:
                    plcType = ePLCType.ePLC_HO_DTOA;
                    break;
                case DefineAndConst.StringConstant.PLC_HO_MOTOR:
                    plcType = ePLCType.ePLC_HO_MOTOR;
                    break;
            }

            return (int)plcType;
        }

        /// <summary>
        /// Gets the name of the PLC.
        /// </summary>
        /// <param name="plcType">Type of the PLC.</param>
        /// <returns></returns>
        public static string GetPLCName(ePLCType plcType)
        {
            string plcName = string.Empty;

            switch (plcType)
            {
                case ePLCType.ePLC_AVT:
                    plcName = DefineAndConst.StringConstant.PLC_AVT;
                    break;
                case ePLCType.ePLC_CRABTREE:
                    plcName = DefineAndConst.StringConstant.PLC_CRABTREE;
                    break;
                case ePLCType.ePLC_DTOA:
                    plcName = DefineAndConst.StringConstant.PLC_DTOA;
                    break;
                case ePLCType.ePLC_NILPETER:
                    plcName = DefineAndConst.StringConstant.PLC_NILPETER;
                    break;
                case ePLCType.ePLC_RAGSDALE:
                    plcName = DefineAndConst.StringConstant.PLC_RAGSDALE;
                    break;
                case ePLCType.ePLC_TI:
                    plcName = DefineAndConst.StringConstant.PLC_TI;
                    break;
                case ePLCType.ePLC_ALLEN_BRADLEY:
                    plcName = DefineAndConst.StringConstant.PLC_AB_PLC5;
                    break;
                case ePLCType.ePLC_HO_DTOA:
                    plcName = DefineAndConst.StringConstant.PLC_HO_DTOA;
                    break;
                case ePLCType.ePLC_HO_MOTOR:
                    plcName = DefineAndConst.StringConstant.PLC_HO_MOTOR;
                    break;
            }

            return plcName;
        }

    }

}
