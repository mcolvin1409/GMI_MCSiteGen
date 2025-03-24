/////////////////////////////////////////////////////////////////////////////
//  
// frmSiteConfigGen.cs: MCN Site generator main form
//
//  Author:	Chetan           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmSiteConfigGen.cs-arc   1.73   Jun 15 2012 09:53:10   BEttinger  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmSiteConfigGen.cs-arc  $
///  
///     Rev 1.73   Jun 15 2012 09:53:10   BEttinger
///  MT17683
///  
///     Rev 1.72   May 11 2012 15:45:08   MColvin
///  MT17718,17719 - Added Swedish and Danish, sorted the language list
///  
///     Rev 1.71   Mar 23 2012 10:21:24   BEttinger
///  MT17624
///  
///     Rev 1.70   Mar 14 2012 09:49:14   SBabu
///  MT 17637 - Added support for configuring help path and show help options
///  
///     Rev 1.69   Feb 08 2012 11:06:54   SBabu
///  MT 17529 - Modified for Auto Zero Servo feature
///  
///     Rev 1.68   Dec 12 2011 13:08:06   MColvin
///  MT16585,16777,17318,17427,17428 - adding languages NL, PT, ZN, PO, ES-MX
///  
///     Rev 1.67   Oct 31 2011 10:13:20   MColvin
///  MT 17347 - allow SPU name to be NA for virtual fountains
///  
///     Rev 1.66   Jul 26 2011 12:26:06   MColvin
///  MT 17082, 17103 - max sweep turns and funny fountain key count and key width validation.
///  
///     Rev 1.65   Jul 21 2011 14:47:06   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.64   May 05 2011 15:17:24   LMask
///  Include language name in the Site XML file instead of a short name
///  
///     Rev 1.63   Apr 15 2011 14:48:38   SBabu
///  MT-16925:Reverted changes made for OCU3 Zone width conversion to milli meters
///  
///     Rev 1.62   Feb 03 2011 00:56:30   HNarala
///  Mercury Client: Operator configuration of  'Sweep Test' under diagnostics
///  
///     Rev 1.61   Jan 17 2011 03:34:26   SRajarapu
///  13878: MC3SiteGen: Implement funny Fountains support
///  
///     Rev 1.60   Jan 17 2011 00:38:52   SRajarapu
///  13878: MC3SiteGen: Implement funny Fountains support
///  
///     Rev 1.59   Jan 12 2011 05:00:52   HNarala
///  Mercury Client: Implement password protection access to diagnostic operations from Client
///  
///     Rev 1.58   Dec 13 2010 02:08:34   HNarala
///  Mercury SiteGen: Configure password protection access to diagnostic operations from Client
///  
///     Rev 1.57   Dec 10 2010 04:27:20   HNarala
///  MC3 Client - Turkish language support
///  
///     Rev 1.56   Dec 03 2010 02:30:22   SRajarapu
///  fixes: 16025, 15935
///  
///     Rev 1.55   Aug 10 2010 02:57:24   SSomashekaran
///  MC3 AS - ALL data file paths should be configurable
///  
///     Rev 1.54   Jul 02 2010 00:22:28   HNarala
///  fix to 15968,15955
///  
///     Rev 1.53   Jun 17 2010 06:16:52   SRajarapu
///  15937: Mercury builds: Create beta builds for Mercury 1.19L version
///  
///     Rev 1.52   Jun 11 2010 03:24:12   SRajarapu
///  15907: Create beta build 1.19k for Mercury Client, Application Server and SiteGen Applications
///  
///     Rev 1.51   May 31 2010 23:49:58   SRajarapu
///  15798: When accessed 'Utility > Auto/Sweep Test' from the attached site file, 'Range of SPUs to test is 1 -1' message popup is displayed.
///  
///     Rev 1.50   May 27 2010 23:25:04   SRajarapu
///  15827: Mercury SiteGen build 1.19j
///  
///     Rev 1.49   May 27 2010 22:59:36   SSomashekaran
///  MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility.
///  
///     Rev 1.48   May 26 2010 01:34:14   SRajarapu
///  15752:Localization support for French language
///  
///     Rev 1.47   May 21 2010 04:09:48   SBabu
///  Changed version info to 1.19i
///  
///     Rev 1.46   May 14 2010 03:26:20   SRajarapu
///  15737: Mercury: Create beta builds 1.19h for Server, Client, SiteGen and Protection application
///  
///     Rev 1.45   May 14 2010 01:18:26   SRajarapu
///  15456: MC3Client - Add option to rotate CIP3 image and data
///  
///     Rev 1.44   Apr 20 2010 01:09:02   SSomashekaran
///  MC3SiteGen: Create beta build 1.19d for Mercury SiteGen application
///  
///     Rev 1.43   Apr 09 2010 05:09:34   SSomashekaran
///  Create MC3 Site Gen Utility build 1.19c
///  
///     Rev 1.42   Apr 09 2010 03:00:00   HNarala
///  MC3SiteGen: Add new option to select the default language
///  
///     Rev 1.41   Apr 08 2010 23:39:22   HNarala
///  to support localization
///  
///     Rev 1.40   Mar 26 2010 00:06:10   SSomashekaran
///  MC3 - MC3SiteGen - Add Crabtree ducting support via serial Mits PLC
///  
///     Rev 1.39   Mar 12 2010 00:09:10   SRajarapu
///  15258: Client 1.19 crashes with the attached site file.
///  
///     Rev 1.38   Mar 04 2010 04:39:38   HNarala
///  To fix 15342, 45333
///  
///     Rev 1.37   Mar 03 2010 04:16:04   SRajarapu
///  some issues
///  
///     Rev 1.36   Feb 17 2010 00:41:38   SRajarapu
///  15094: Wide Press: With the attached site file, extra Unit/Inker displayed from Units, Status and Thumbnail views.
///  
///     Rev 1.35   Nov 13 2009 03:29:44   HNarala
///  MC3SiteGen: Changes to the total keys is not updating the OCU zones count
///  
///     Rev 1.34   Oct 15 2009 01:55:58   HNarala
///  to fix 14520
///  
///     Rev 1.33   Oct 06 2009 01:20:32   HNarala
///  to build MC3SiteGen 1.18
///  
///     Rev 1.32   Sep 15 2009 04:56:56   SRajarapu
///  14368: Inker name not updated properly from Fountain configuration dialog box.
///  
///     Rev 1.31   Sep 02 2009 08:23:44   HNarala
///  to Implement support for 64 zones per Inker
///  
///     Rev 1.30   Aug 11 2009 15:55:44   LMask
///  MT13404, Add CLC communication with CQ2
///  
///     Rev 1.29   Jul 15 2009 04:19:00   HNarala
///  For MT 12885
///  
///     Rev 1.28   Jun 16 2009 05:36:16   HNarala
///  site file generator defect fixes
///  
///     Rev 1.27   Jun 04 2009 04:59:34   HNarala
///  For MT: 13469
///  
///     Rev 1.26   May 27 2009 06:28:10   HNarala
///  For MT 13405
///  
///     Rev 1.25   May 27 2009 06:05:28   HNarala
///  to support Auto scan cal feature
///  
///     Rev 1.24   May 15 2009 01:48:52   HNarala
///  For 13162
///  
///     Rev 1.23   May 14 2009 08:05:06   HNarala
///  13162
///  
///     Rev 1.22   May 14 2009 03:51:24   HNarala
///  for mt 13162
///  
///     Rev 1.21   Feb 19 2009 01:26:06   HNarala
///  MC3 System Weird behavior.
///  
///     Rev 1.20   Jan 29 2009 18:41:14   HNarala
///  to fix the validation
///  
///     Rev 1.19   Jan 22 2009 16:05:42   HQi
///  fixed a bug in the prev check in
///  
///     Rev 1.18   Jan 22 2009 05:23:18   HNarala
///  to split up the inkers evenly
///  
///     Rev 1.17   Jan 22 2009 05:06:22   HNarala
///  to fix the Ken's mentioned issues
///  
///     Rev 1.16   Jan 21 2009 17:46:38   HQi
///  Inker table enhancement
///  
///     Rev 1.15   Jan 19 2009 18:26:14   HQi
///  Add inker properties table
///  
///     Rev 1.14   Jan 13 2009 17:42:18   HQi
///  Show Finish button when Fountain Configuration Wizard reaches the last page
///  
///     Rev 1.13   Jan 13 2009 14:33:44   HQi
///  removed key1operatorside from dlg box
///  
///     Rev 1.12   Jan 13 2009 04:18:20   HNarala
///  to fix MT: 12324, 12264
///  
///     Rev 1.11   Jan 12 2009 15:40:54   HQi
///  removed user logon window
///  
///     Rev 1.10   Jan 06 2009 23:07:04   HNarala
///  MT 12164, 12322
///  
///     Rev 1.9   Dec 14 2008 21:28:30   HNarala
///  to adjust the decimal values to 2 decimal points
///  
///     Rev 1.8   Dec 10 2008 03:51:48   HNarala
///  Key width to be read from the open file
///  
///     Rev 1.7   Nov 21 2008 03:42:56   SRajarapu
///  MT#12064: When applied Save, incorrect overwritten message popup displayed.
///  
///     Rev 1.6   Nov 21 2008 00:38:06   HNarala
///  MT: 12062
///  
///     Rev 1.5   Nov 20 2008 22:40:06   HNarala
///  site file modify usin ConfigGen tool
///  
///     Rev 1.4   Nov 12 2008 23:09:54   HNarala
///  to create the spu in new file
///  
///     Rev 1.3   Nov 10 2008 21:45:20   SRajarapu
///  MT#11808: MCNWSiteGen:  Application crashed while deleting servo turn value
///  
///     Rev 1.2   Nov 03 2008 21:28:24   SRajarapu
///  MT#11807 and MT#11800
///  
///     Rev 1.1   Oct 22 2008 03:36:30   HNarala
///  MT: 11396
///  
///     Rev 1.0   03 Oct 2008 14:42:04   knadler
///  Initial revision.
///  Resolution for 11396: Create MC3 Siteset application
// 
//
/////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using MC3Components.Controls;

using System.IO;
using System.Diagnostics;
using System.Net;
using System.Globalization;
using System.Security.Cryptography;
using System.Configuration;

namespace MCNWSiteGen
{
    enum GetInputType
    {
        InputPressType = 0,
        InputPressName = 1,
        InputPressWidth = 2

    }
    enum FountainWizardStates
    {
        Initial = 0,
        Second = 1,
        Third  = 2
    }
    //public enum UnitTypes
    //{
    //    UNIT_TYPE_MM = 0,
    //    UNIT_TYPE_CMS = 1,
    //    UNIT_TYPE_INCHS = 2
    //};
    enum ListviewColumnHead
    {
        InkerName =0,
        InkerUpperSide,
        InkerInverted,
        NumberOfKeys,
        KeyWidth,
        ServoTurns,
        SPUName,
        SPUPortNumber,
        SPUName2,           //for wide press
        SPUPortNumber2     //for wide press
     }

    enum WidePressListviewColumnHead
    {
        RailInkerName = 0,
        KeyalignMent,
        StartKey,
        TotalKeys,
        KeyWidth,
        SPUName,
        SPUPortNumber,
    }

    public struct INKER_DETAIL_RECORD
    {
        public string strName;
        public bool bUpperInker;        //true = upper
        public bool IsLeftSide;        //true - if Inker is on the left side to CIC, false otherwise 
        public bool bInverted;          //true = inverted
        public int iNumOfKeys;
        public float fKeyWidth;
        public string strServoTurns;
        public string strSPUName;
        public int iSPUPortNum;
    }
    public struct WIDEPRESS_INKER_DETAIL_RECORD
    {
        public string strInkerRail;
        public bool bOpSide;
        public int iRailStartKey;
        public int iRailTotalKeys;
        public float fKeyWidth;
        public string strRailSPUName;
        public int iRailSPUPortNum;
    }

    public delegate void PressTypeChanged();
    public partial class frmMain : Form
    {
        //string m_strUSERLoggedIn;
        MCSiteConfigData m_mcSiteConfigData;
        /// Added by Sreejit on July-30-2010 to support ENH 16062
        ServerDataPathConfig m_mcPathConfigData;
        ClientDataPathConfig m_mcClientConfigData;
        MCPressInfo m_CurPress;

        bool m_bAdminLoggedIN;
        int m_iPressIdx;
        int m_iFountainWzrdState;
        int m_iInkersPerUnit;
        MCInker mcCurrentInker;
        bool m_bFountainConfigured;
        public bool m_bNewFileOpen;
        bool m_bFileOpenMode;
        UnitTypes m_CurrentUnit, m_PressCurrentUnit;
        string strfilePath = "";
        float m_PressWidthInCM;
        bool m_bSPUConfigured;
        string strFileName = "";
        //int iTotalFountains = 1;
        public int m_iSelectedInker;
        private bool exitMCNWSiteGen;
        private int sweepConfiguration, waterConfiguration;
        private bool m_bSecondListView;
        private bool m_bFirstListView;
        int iFirstView;
        private bool m_bCreate;
        private int m_iOldKeysValue;
        private float m_fKeyWidth;
        private bool m_bUpdatedPressData = false;   //WI97682: Used to indicate whether Press related data was OK'ed or NOT

        MC3Components.Controls.MC3Column NameColumn; 
        MC3Components.Controls.MC3Column SurfaceColumn; 
        MC3Components.Controls.MC3Column InvertedColumn; 
        MC3Components.Controls.MC3Column KeysColumn;
        MC3Components.Controls.MC3Column KeyWidthColumn;
        MC3Components.Controls.MC3Column ServosColumn; 
        MC3Components.Controls.MC3Column SPUNameColumn; 
        MC3Components.Controls.MC3Column SPUPortColumn;
        MC3Components.Controls.MC3Column InkerLeftToCICColumn;     //Is Inker located on the left side of the CIC or not? Applicable only for CIC Press Type(s)

        public frmMain()
        {
            NameColumn = new MC3Components.Controls.MC3Column();
            SurfaceColumn = new MC3Components.Controls.MC3Column();
            InvertedColumn = new MC3Components.Controls.MC3Column();
            KeysColumn = new MC3Components.Controls.MC3Column();
            KeyWidthColumn = new MC3Components.Controls.MC3Column();
            ServosColumn = new MC3Components.Controls.MC3Column();
            SPUNameColumn = new MC3Components.Controls.MC3Column();
            SPUPortColumn = new MC3Components.Controls.MC3Column();
            InkerLeftToCICColumn = new MC3Components.Controls.MC3Column();

            InitializeComponent();
            //need to allow laptop with 768 vertical resolution to see all, also issue with display scaling down
            if( Screen.PrimaryScreen.WorkingArea.Height < 999 )  //was 910 (dropped off last PW field)
            {
                this.groupBox7.Location = new System.Drawing.Point(330, 500); //password fields, to the right and up 
                this.gpLanguage.Location = new System.Drawing.Point(600, 535);	 // client options - shift to right & up if small screen
            }
            //  20240315 Mark C - added screen size to title bar
            this.label1.Text = String.Format("MC3 Site Configuration Generator    Screen {0} x {1}",
                    Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                                //  WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            m_bAdminLoggedIN = false;
            m_mcSiteConfigData = new MCSiteConfigData();
            /// Added by Sreejit on July-30-2010 to support ENH 16062
            m_mcPathConfigData = new ServerDataPathConfig();
            m_mcClientConfigData = new ClientDataPathConfig();
            m_CurPress = new MCPressInfo();

            m_iPressIdx = 0;
            m_iFountainWzrdState = (int)FountainWizardStates.Initial;
            m_iInkersPerUnit = 1;
            mcCurrentInker = null;
            m_bNewFileOpen = false;
            m_bFileOpenMode = false;
            m_CurrentUnit = new UnitTypes();
            m_CurrentUnit = UnitTypes.UNIT_TYPE_MM;
            m_bSPUConfigured = false;
            m_iSelectedInker = -1;
            exitMCNWSiteGen = false;
            sweepConfiguration = waterConfiguration = -1;

            PressInformation.pressTypeChanged += new PressTypeChanged(PressInformation_pressTypeChanged);
            m_PressWidthInCM = 137.7f;      
            m_bSecondListView = false;
            m_bFirstListView = true;
            iFirstView = 0;
            m_bCreate = false;
            m_bUpdatedPressData = false;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSystemDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createSiteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openSiteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSystemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPathDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.newServerPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.openServerPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newClientPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openClientPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPathSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelpDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.gpCreateNew = new System.Windows.Forms.GroupBox();
            this.ServerIPAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.MercuryServerPortText = new System.Windows.Forms.TextBox();
            this.MercuryServerPortLabel = new System.Windows.Forms.Label();
            this.MercuryServerIPAddressLabel = new System.Windows.Forms.Label();
            this.MercuryServerIPAddressText = new System.Windows.Forms.TextBox();
            this.productOptions = new System.Windows.Forms.GroupBox();
            this.m_labelTowersWithNumbersOption = new System.Windows.Forms.CheckBox();
            this.m_newspaperNavigationViewOption = new System.Windows.Forms.CheckBox();
            this.m_promptZAI = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepLastVersion = new System.Windows.Forms.CheckBox();
            this.jobManagementOption = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbRuntimePassword = new System.Windows.Forms.TextBox();
            this.lbRuntimePassword = new System.Windows.Forms.Label();
            this.tbExitPassword = new System.Windows.Forms.TextBox();
            this.lbExitPassword = new System.Windows.Forms.Label();
            this.tbConfigurationPassword = new System.Windows.Forms.TextBox();
            this.lbConfigurationPassword = new System.Windows.Forms.Label();
            this.tbDiagnosticPassword = new System.Windows.Forms.TextBox();
            this.lbDiagnosticPassword = new System.Windows.Forms.Label();
            this.gpLanguage = new System.Windows.Forms.GroupBox();
            this.label2Sides = new System.Windows.Forms.Label();
            this.checkBox2Sides = new System.Windows.Forms.CheckBox();
            this.checkBoxHelp = new System.Windows.Forms.CheckBox();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.Language = new System.Windows.Forms.Label();
            this.clcGroupBox = new System.Windows.Forms.GroupBox();
            this.cqPortTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.cqIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.isCLCOEMCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCloseNew = new System.Windows.Forms.Button();
            this.gpSiteInformation = new System.Windows.Forms.GroupBox();
            this.txtSiteNumber = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.labelSiteNumber = new System.Windows.Forms.Label();
            this.labelSiteName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxCMS = new System.Windows.Forms.CheckBox();
            this.checkBoxInches = new System.Windows.Forms.CheckBox();
            this.checkBoxMM = new System.Windows.Forms.CheckBox();
            this.txtPressWidth = new System.Windows.Forms.TextBox();
            this.txtPressName = new System.Windows.Forms.TextBox();
            this.labelPressWidth = new System.Windows.Forms.Label();
            this.labelPressName = new System.Windows.Forms.Label();
            this.comboBoxPressType = new System.Windows.Forms.ComboBox();
            this.labelPressType = new System.Windows.Forms.Label();
            this.gpPressConfigurations = new System.Windows.Forms.GroupBox();
            this.pnlFountainWizard = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_importPRSGroupBox = new System.Windows.Forms.GroupBox();
            this.m_prsLabelPath = new System.Windows.Forms.Label();
            this.m_PRSFileLocationText = new System.Windows.Forms.TextBox();
            this.m_importPRSButton = new System.Windows.Forms.Button();
            this.cbFunnyfountains = new System.Windows.Forms.CheckBox();
            this.cbVirtualInkers = new System.Windows.Forms.CheckBox();
            this.isWidePressCheckBox = new System.Windows.Forms.CheckBox();
            this.m_commonSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tbDisplayZones = new System.Windows.Forms.TextBox();
            this.lblDisplayZones = new System.Windows.Forms.Label();
            this.lblKeyWidthUnits = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkCms = new System.Windows.Forms.CheckBox();
            this.chkInches = new System.Windows.Forms.CheckBox();
            this.chkMM = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKeysPerfountain = new System.Windows.Forms.TextBox();
            this.txtKeyWidth = new System.Windows.Forms.TextBox();
            this.txtFountainCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstPressType = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkTurnBar = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rButtonOneSurface = new System.Windows.Forms.RadioButton();
            this.rbtnOneToTwo = new System.Windows.Forms.RadioButton();
            this.rbtnInkerOneToOne = new System.Windows.Forms.RadioButton();
            this.gpInkerConfigurations = new System.Windows.Forms.GroupBox();
            this.ListViewInkers = new MC3Components.Controls.MC3ListView();
            this.checkBoxVirtualInker = new System.Windows.Forms.CheckBox();
            this.btnInkerNameChange = new System.Windows.Forms.Button();
            this.txtMaxConsole = new System.Windows.Forms.TextBox();
            this.txtMinConsole = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtServoTurns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpBank2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.gpBank1 = new System.Windows.Forms.GroupBox();
            this.cboSPU = new System.Windows.Forms.ComboBox();
            this.txtFirstKey = new System.Windows.Forms.TextBox();
            this.txtTotalKeysToCtrl = new System.Windows.Forms.TextBox();
            this.txtPortOnInker = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboInkerList = new System.Windows.Forms.ComboBox();
            this.chkInverted = new System.Windows.Forms.CheckBox();
            this.chkUpperInker = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNFSType = new System.Windows.Forms.Label();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.txtLintableSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.IndicateProgress = new System.Windows.Forms.ProgressBar();
            this.stripPressConfig = new System.Windows.Forms.ToolStrip();
            this.toolStripSetups = new System.Windows.Forms.ToolStripDropDownButton();
            this.sPUInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OCUSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fountainConfigurationWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webConfigWizardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFSSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressInterfaceFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressSiteSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoZeroSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripPressInfo = new System.Windows.Forms.ToolStripButton();
            this.toolTurnBars = new System.Windows.Forms.ToolStripButton();
            this.toolPressFeatures = new System.Windows.Forms.ToolStripButton();
            this.toolbtnSweeps = new System.Windows.Forms.ToolStripDropDownButton();
            this.sweepInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnWaters = new System.Windows.Forms.ToolStripDropDownButton();
            this.tStripcboWaters = new System.Windows.Forms.ToolStripComboBox();
            this.autoTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweepTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegister = new System.Windows.Forms.ToolStripDropDownButton();
            this.registerInterfacetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WaterInterface = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripWaterInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripServerOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripGUIOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripAutoScanCal = new System.Windows.Forms.ToolStripButton();
            this.toolStripDataPathButton = new System.Windows.Forms.ToolStripButton();
            this.btnSiteInfo = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.gpCreateNew.SuspendLayout();
            this.ServerIPAddressGroupBox.SuspendLayout();
            this.productOptions.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gpLanguage.SuspendLayout();
            this.clcGroupBox.SuspendLayout();
            this.gpSiteInformation.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gpPressConfigurations.SuspendLayout();
            this.pnlFountainWizard.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.m_importPRSGroupBox.SuspendLayout();
            this.m_commonSettingsGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpInkerConfigurations.SuspendLayout();
            this.gpBank2.SuspendLayout();
            this.gpBank1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.stripPressConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1036, 40);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MC3 Site Configuration Generator";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(985, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BackColor = System.Drawing.Color.Transparent;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.toolStripMenu);
            this.pnlSettings.Controls.Add(this.gpCreateNew);
            this.pnlSettings.Location = new System.Drawing.Point(0, 40);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1036, 699);
            this.pnlSettings.TabIndex = 2;
            this.pnlSettings.Visible = false;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripMenu.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.toolStripMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSystemDropDownButton,
            this.toolStripSystemSeparator,
            this.toolStripPathDropDownButton,
            this.toolStripPathSeparator,
            this.toolStripHelpDropDownButton,
            this.toolStripHelpSeparator} );
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(1034, 29);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripSystemDropDownButton
            // 
            this.toolStripSystemDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSystemDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.createSiteFileToolStripMenuItem,
            this.toolStripSeparator4,
            this.openSiteFileToolStripMenuItem,
            this.toolStripSeparator5});
            this.toolStripSystemDropDownButton.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.toolStripSystemDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSystemDropDownButton.Image")));
            this.toolStripSystemDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSystemDropDownButton.Name = "toolStripSystemDropDownButton";
            this.toolStripSystemDropDownButton.Size = new System.Drawing.Size(80, 26);
            this.toolStripSystemDropDownButton.Text = "System";
            this.toolStripSystemDropDownButton.ToolTipText = "Create / Modify System File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // createSiteFileToolStripMenuItem
            // 
            this.createSiteFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.createSiteFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createSiteFileToolStripMenuItem.Image")));
            this.createSiteFileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.createSiteFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createSiteFileToolStripMenuItem.Name = "createSiteFileToolStripMenuItem";
            this.createSiteFileToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.createSiteFileToolStripMenuItem.Text = "New ...";
            this.createSiteFileToolStripMenuItem.Click += new System.EventHandler(this.createSiteFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // openSiteFileToolStripMenuItem
            // 
            this.openSiteFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.openSiteFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openSiteFileToolStripMenuItem.Image")));
            this.openSiteFileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.openSiteFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openSiteFileToolStripMenuItem.Name = "openSiteFileToolStripMenuItem";
            this.openSiteFileToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.openSiteFileToolStripMenuItem.Text = "Open ...";
            this.openSiteFileToolStripMenuItem.Click += new System.EventHandler(this.openSiteFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripSystemSeparator
            // 
            this.toolStripSystemSeparator.Name = "toolStripSystemSeparator";
            this.toolStripSystemSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripPathDropDownButton
            // 
            this.toolStripPathDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripPathDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.ServerToolStripMenuItem,
            this.toolStripSeparator7,
            this.ClientToolStripMenuItem,
            this.toolStripSeparator8});
            this.toolStripPathDropDownButton.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.toolStripPathDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPathDropDownButton.Image")));
            this.toolStripPathDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPathDropDownButton.Name = "toolStripPathDropDownButton";
            this.toolStripPathDropDownButton.Size = new System.Drawing.Size(58, 26);
            this.toolStripPathDropDownButton.Text = "Path";
            this.toolStripPathDropDownButton.ToolTipText = "Create / Modify Path File";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(179, 6);
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator12,
            this.newServerPathToolStripMenuItem,
            this.toolStripSeparator13,
            this.openServerPathToolStripMenuItem,
            this.toolStripSeparator14});
            this.ServerToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.ServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ServerToolStripMenuItem.Image")));
            this.ServerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ServerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(182, 54);
            this.ServerToolStripMenuItem.Text = "Server ...";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(184, 6);
            // 
            // newServerPathToolStripMenuItem
            // 
            this.newServerPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newServerPathToolStripMenuItem.Image")));
            this.newServerPathToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newServerPathToolStripMenuItem.Name = "newServerPathToolStripMenuItem";
            this.newServerPathToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.newServerPathToolStripMenuItem.Text = "New ...";
            this.newServerPathToolStripMenuItem.Click += new System.EventHandler(this.newServerPathToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(184, 6);
            // 
            // openServerPathToolStripMenuItem
            // 
            this.openServerPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openServerPathToolStripMenuItem.Image")));
            this.openServerPathToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openServerPathToolStripMenuItem.Name = "openServerPathToolStripMenuItem";
            this.openServerPathToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.openServerPathToolStripMenuItem.Text = "Open ...";
            this.openServerPathToolStripMenuItem.Click += new System.EventHandler(this.openServerPathToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(179, 6);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.newClientPathToolStripMenuItem,
            this.toolStripSeparator1,
            this.openClientPathToolStripMenuItem,
            this.toolStripSeparator11});
            this.ClientToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.ClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClientToolStripMenuItem.Image")));
            this.ClientToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(182, 54);
            this.ClientToolStripMenuItem.Text = "Client ...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // newClientPathToolStripMenuItem
            // 
            this.newClientPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newClientPathToolStripMenuItem.Image")));
            this.newClientPathToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newClientPathToolStripMenuItem.Name = "newClientPathToolStripMenuItem";
            this.newClientPathToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.newClientPathToolStripMenuItem.Text = "New ...";
            this.newClientPathToolStripMenuItem.Click += new System.EventHandler(this.newClientPathToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // openClientPathToolStripMenuItem
            // 
            this.openClientPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openClientPathToolStripMenuItem.Image")));
            this.openClientPathToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openClientPathToolStripMenuItem.Name = "openClientPathToolStripMenuItem";
            this.openClientPathToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
            this.openClientPathToolStripMenuItem.Text = "Open ...";
            this.openClientPathToolStripMenuItem.Click += new System.EventHandler(this.openClientPathToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripPathSeparator
            // 
            this.toolStripPathSeparator.Name = "toolStripPathSeparator";
            this.toolStripPathSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripHelpDropDownButton
            // 
            this.toolStripHelpDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripHelpDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.helpToolStripMenuItem,
            this.toolStripSeparator10});
            this.toolStripHelpDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelpDropDownButton.Image")));
            this.toolStripHelpDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripHelpDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelpDropDownButton.Name = "toolStripHelpDropDownButton";
            this.toolStripHelpDropDownButton.Size = new System.Drawing.Size(58, 26);
            this.toolStripHelpDropDownButton.Text = "Help";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(140, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(143, 38);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(140, 6);
            // 
            // toolStripHelpSeparator
            // 
            this.toolStripHelpSeparator.Name = "toolStripHelpSeparator";
            this.toolStripHelpSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // gpCreateNew
            // 
            this.gpCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCreateNew.Controls.Add(this.ServerIPAddressGroupBox);
            this.gpCreateNew.Controls.Add(this.productOptions);
            this.gpCreateNew.Controls.Add(this.groupBox7);
            this.gpCreateNew.Controls.Add(this.gpLanguage);
            this.gpCreateNew.Controls.Add(this.clcGroupBox);
            this.gpCreateNew.Controls.Add(this.btnSave);
            this.gpCreateNew.Controls.Add(this.btnCloseNew);
            this.gpCreateNew.Controls.Add(this.gpSiteInformation);
            this.gpCreateNew.Controls.Add(this.gpPressConfigurations);
            this.gpCreateNew.Controls.Add(this.btnSiteInfo);
            this.gpCreateNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpCreateNew.Location = new System.Drawing.Point(9, 62);
            this.gpCreateNew.Name = "gpCreateNew";
            this.gpCreateNew.Size = new System.Drawing.Size(1018, 625);
            this.gpCreateNew.TabIndex = 2;
            this.gpCreateNew.TabStop = false;
            this.gpCreateNew.Text = "Create A New Configuration";
            this.gpCreateNew.Visible = false;
            this.gpCreateNew.Enter += new System.EventHandler(this.gpCreateNew_Enter);
            // 
            // ServerIPAddressGroupBox
            // 
            this.ServerIPAddressGroupBox.Controls.Add(this.MercuryServerPortText);
            this.ServerIPAddressGroupBox.Controls.Add(this.MercuryServerPortLabel);
            this.ServerIPAddressGroupBox.Controls.Add(this.MercuryServerIPAddressLabel);
            this.ServerIPAddressGroupBox.Controls.Add(this.MercuryServerIPAddressText);
            this.ServerIPAddressGroupBox.ForeColor = System.Drawing.Color.White;
            this.ServerIPAddressGroupBox.Location = new System.Drawing.Point(9, 453);
            this.ServerIPAddressGroupBox.Name = "ServerIPAddressGroupBox";
            this.ServerIPAddressGroupBox.Size = new System.Drawing.Size(316, 80);
            this.ServerIPAddressGroupBox.TabIndex = 37;
            this.ServerIPAddressGroupBox.TabStop = false;
            this.ServerIPAddressGroupBox.Text = "Mercury Server Configuration - PRESSNET";
            // 
            // MercuryServerPortText
            // 
            this.MercuryServerPortText.Location = new System.Drawing.Point(150, 51);
            this.MercuryServerPortText.MaxLength = 4;
            this.MercuryServerPortText.Name = "MercuryServerPortText";
            this.MercuryServerPortText.Size = new System.Drawing.Size(157, 20);
            this.MercuryServerPortText.TabIndex = 3;
            this.MercuryServerPortText.Text = "1655";
            this.MercuryServerPortText.Leave += new System.EventHandler(this.MercuryServerPortText_Leave);
            // 
            // MercuryServerPortLabel
            // 
            this.MercuryServerPortLabel.AutoSize = true;
            this.MercuryServerPortLabel.Location = new System.Drawing.Point(42, 52);
            this.MercuryServerPortLabel.Name = "MercuryServerPortLabel";
            this.MercuryServerPortLabel.Size = new System.Drawing.Size(104, 13);
            this.MercuryServerPortLabel.TabIndex = 2;
            this.MercuryServerPortLabel.Text = "Mercury Server Port:";
            // 
            // MercuryServerIPAddressLabel
            // 
            this.MercuryServerIPAddressLabel.AutoSize = true;
            this.MercuryServerIPAddressLabel.Location = new System.Drawing.Point(10, 23);
            this.MercuryServerIPAddressLabel.Name = "MercuryServerIPAddressLabel";
            this.MercuryServerIPAddressLabel.Size = new System.Drawing.Size(136, 13);
            this.MercuryServerIPAddressLabel.TabIndex = 1;
            this.MercuryServerIPAddressLabel.Text = "App Server IP Address:";
            // 
            // MercuryServerIPAddressText
            // 
            this.MercuryServerIPAddressText.Location = new System.Drawing.Point(150, 20);
            this.MercuryServerIPAddressText.MaxLength = 15;
            this.MercuryServerIPAddressText.Name = "MercuryServerIPAddressText";
            this.MercuryServerIPAddressText.Size = new System.Drawing.Size(157, 20);
            this.MercuryServerIPAddressText.TabIndex = 0;
            this.MercuryServerIPAddressText.Leave += new System.EventHandler(this.MercuryServerIPAddressText_Leave);
            // 
            // productOptions
            // 
            this.productOptions.Controls.Add(this.m_labelTowersWithNumbersOption);
            this.productOptions.Controls.Add(this.m_newspaperNavigationViewOption);
            this.productOptions.Controls.Add(this.m_promptZAI);
            this.productOptions.Controls.Add(this.checkBoxKeepLastVersion);
            this.productOptions.Controls.Add(this.jobManagementOption);
            this.productOptions.ForeColor = System.Drawing.Color.White;
            this.productOptions.Location = new System.Drawing.Point(9, 335);
            this.productOptions.Name = "productOptions";
            this.productOptions.Size = new System.Drawing.Size(317, 114);
            this.productOptions.TabIndex = 36;
            this.productOptions.TabStop = false;
            this.productOptions.Text = "Product Options";
            // 
            // m_labelTowersWithNumbersOption
            // 
            this.m_labelTowersWithNumbersOption.AutoSize = true;
            this.m_labelTowersWithNumbersOption.Location = new System.Drawing.Point(13, 90);
            this.m_labelTowersWithNumbersOption.Name = "m_labelTowersWithNumbersOption";
            this.m_labelTowersWithNumbersOption.Size = new System.Drawing.Size(155, 17);
            this.m_labelTowersWithNumbersOption.TabIndex = 4;
            this.m_labelTowersWithNumbersOption.Text = "Label Towers with numbers";
            this.m_labelTowersWithNumbersOption.UseVisualStyleBackColor = true;
            this.m_labelTowersWithNumbersOption.CheckedChanged += new System.EventHandler(this.OnTowerWithNumbersOptionChanged);
            // 
            // m_newspaperNavigationViewOption
            // 
            this.m_newspaperNavigationViewOption.AutoSize = true;
            this.m_newspaperNavigationViewOption.Location = new System.Drawing.Point(13, 66);
            this.m_newspaperNavigationViewOption.Name = "m_newspaperNavigationViewOption";
            this.m_newspaperNavigationViewOption.Size = new System.Drawing.Size(160, 17);
            this.m_newspaperNavigationViewOption.TabIndex = 3;
            this.m_newspaperNavigationViewOption.Text = "Newspaper Navigation View";
            this.m_newspaperNavigationViewOption.UseVisualStyleBackColor = true;
            this.m_newspaperNavigationViewOption.CheckedChanged += new System.EventHandler(this.OnNewspaperNavigationViewOptionChanged);
            // 
            // m_promptZAI
            // 
            this.m_promptZAI.AutoSize = true;
            this.m_promptZAI.Location = new System.Drawing.Point(13, 43);
            this.m_promptZAI.Name = "m_promptZAI";
            this.m_promptZAI.Size = new System.Drawing.Size(306, 17);
            this.m_promptZAI.TabIndex = 2;
            this.m_promptZAI.Text = "Prompt for Zero All Inkers needed on every restart of Server";
            this.m_promptZAI.UseVisualStyleBackColor = true;
            this.m_promptZAI.CheckedChanged += new System.EventHandler(this.OnPromptZAICheckedChanged);
            // 
            // checkBoxKeepLastVersion
            // 
            this.checkBoxKeepLastVersion.AutoSize = true;
            this.checkBoxKeepLastVersion.Location = new System.Drawing.Point(133, 19);
            this.checkBoxKeepLastVersion.Name = "checkBoxKeepLastVersion";
            this.checkBoxKeepLastVersion.Size = new System.Drawing.Size(179, 17);
            this.checkBoxKeepLastVersion.TabIndex = 1;
            this.checkBoxKeepLastVersion.Text = "Keep only last Version of Profiles";
            this.checkBoxKeepLastVersion.UseVisualStyleBackColor = true;
            this.checkBoxKeepLastVersion.CheckedChanged += new System.EventHandler(this.OnKeeepOnlyLastVersionOption);
            // 
            // jobManagementOption
            // 
            this.jobManagementOption.AutoSize = true;
            this.jobManagementOption.Location = new System.Drawing.Point(13, 19);
            this.jobManagementOption.Name = "jobManagementOption";
            this.jobManagementOption.Size = new System.Drawing.Size(113, 17);
            this.jobManagementOption.TabIndex = 0;
            this.jobManagementOption.Text = "Jobs Management";
            this.jobManagementOption.UseVisualStyleBackColor = true;
            this.jobManagementOption.CheckedChanged += new System.EventHandler(this.jobManagementOptionClicked);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbRuntimePassword);
            this.groupBox7.Controls.Add(this.lbRuntimePassword);
            this.groupBox7.Controls.Add(this.tbExitPassword);
            this.groupBox7.Controls.Add(this.lbExitPassword);
            this.groupBox7.Controls.Add(this.tbConfigurationPassword);
            this.groupBox7.Controls.Add(this.lbConfigurationPassword);
            this.groupBox7.Controls.Add(this.tbDiagnosticPassword);
            this.groupBox7.Controls.Add(this.lbDiagnosticPassword);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(9, 736);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(280, 147);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Passwords";
            // 
            // tbRuntimePassword
            // 
            this.tbRuntimePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRuntimePassword.Location = new System.Drawing.Point(143, 32);
            this.tbRuntimePassword.MaxLength = 6;
            this.tbRuntimePassword.Name = "tbRuntimePassword";
            this.tbRuntimePassword.Size = new System.Drawing.Size(121, 20);
            this.tbRuntimePassword.TabIndex = 34;
            this.tbRuntimePassword.Text = "123456";
            this.tbRuntimePassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbRuntimePassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbRuntimePassword
            // 
            this.lbRuntimePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuntimePassword.ForeColor = System.Drawing.Color.White;
            this.lbRuntimePassword.Location = new System.Drawing.Point(-3, 34);
            this.lbRuntimePassword.Name = "lbRuntimePassword";
            this.lbRuntimePassword.Size = new System.Drawing.Size(140, 13);
            this.lbRuntimePassword.TabIndex = 34;
            this.lbRuntimePassword.Text = "Runtime Options";
            this.lbRuntimePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbExitPassword
            // 
            this.tbExitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExitPassword.Location = new System.Drawing.Point(143, 118);
            this.tbExitPassword.MaxLength = 6;
            this.tbExitPassword.Name = "tbExitPassword";
            this.tbExitPassword.Size = new System.Drawing.Size(121, 20);
            this.tbExitPassword.TabIndex = 40;
            this.tbExitPassword.Text = "123456";
            this.tbExitPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbExitPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbExitPassword
            // 
            this.lbExitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExitPassword.ForeColor = System.Drawing.Color.White;
            this.lbExitPassword.Location = new System.Drawing.Point(-3, 120);
            this.lbExitPassword.Name = "lbExitPassword";
            this.lbExitPassword.Size = new System.Drawing.Size(140, 13);
            this.lbExitPassword.TabIndex = 39;
            this.lbExitPassword.Text = "Exit";
            this.lbExitPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbConfigurationPassword
            // 
            this.tbConfigurationPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfigurationPassword.Location = new System.Drawing.Point(143, 91);
            this.tbConfigurationPassword.MaxLength = 6;
            this.tbConfigurationPassword.Name = "tbConfigurationPassword";
            this.tbConfigurationPassword.Size = new System.Drawing.Size(121, 20);
            this.tbConfigurationPassword.TabIndex = 37;
            this.tbConfigurationPassword.Text = "123456";
            this.tbConfigurationPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbConfigurationPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbConfigurationPassword
            // 
            this.lbConfigurationPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfigurationPassword.ForeColor = System.Drawing.Color.White;
            this.lbConfigurationPassword.Location = new System.Drawing.Point(-3, 93);
            this.lbConfigurationPassword.Name = "lbConfigurationPassword";
            this.lbConfigurationPassword.Size = new System.Drawing.Size(140, 13);
            this.lbConfigurationPassword.TabIndex = 38;
            this.lbConfigurationPassword.Text = "Configuration";
            this.lbConfigurationPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDiagnosticPassword
            // 
            this.tbDiagnosticPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiagnosticPassword.Location = new System.Drawing.Point(143, 61);
            this.tbDiagnosticPassword.MaxLength = 6;
            this.tbDiagnosticPassword.Name = "tbDiagnosticPassword";
            this.tbDiagnosticPassword.Size = new System.Drawing.Size(121, 20);
            this.tbDiagnosticPassword.TabIndex = 36;
            this.tbDiagnosticPassword.Text = "123456";
            this.tbDiagnosticPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbDiagnosticPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbDiagnosticPassword
            // 
            this.lbDiagnosticPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagnosticPassword.ForeColor = System.Drawing.Color.White;
            this.lbDiagnosticPassword.Location = new System.Drawing.Point(-3, 63);
            this.lbDiagnosticPassword.Name = "lbDiagnosticPassword";
            this.lbDiagnosticPassword.Size = new System.Drawing.Size(140, 13);
            this.lbDiagnosticPassword.TabIndex = 35;
            this.lbDiagnosticPassword.Text = "Diagnostic";
            this.lbDiagnosticPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpLanguage
            // 
            this.gpLanguage.Controls.Add(this.label2Sides);
            this.gpLanguage.Controls.Add(this.checkBox2Sides);
            this.gpLanguage.Controls.Add(this.checkBoxHelp);
            this.gpLanguage.Controls.Add(this.cbLanguages);
            this.gpLanguage.Controls.Add(this.Language);
            this.gpLanguage.ForeColor = System.Drawing.Color.White;
            this.gpLanguage.Location = new System.Drawing.Point(6, 635);
            this.gpLanguage.Name = "gpLanguage";
            this.gpLanguage.Size = new System.Drawing.Size(317, 98);
            this.gpLanguage.TabIndex = 34;
            this.gpLanguage.TabStop = false;
            this.gpLanguage.Text = "Client Options";
            // 
            // label2Sides
            // 
            this.label2Sides.AutoSize = true;
            this.label2Sides.Location = new System.Drawing.Point(25, 58);
            this.label2Sides.Name = "label2Sides";
            this.label2Sides.Size = new System.Drawing.Size(113, 13);
            this.label2Sides.TabIndex = 37;
            this.label2Sides.Text = "Show 2 Sides Thumbs";
            this.label2Sides.Visible = false;
            // 
            // checkBox2Sides
            // 
            this.checkBox2Sides.AutoSize = true;
            this.checkBox2Sides.Location = new System.Drawing.Point(10, 58);
            this.checkBox2Sides.Name = "checkBox2Sides";
            this.checkBox2Sides.Size = new System.Drawing.Size(15, 14);
            this.checkBox2Sides.TabIndex = 36;
            this.checkBox2Sides.UseVisualStyleBackColor = true;
            this.checkBox2Sides.Visible = false;
            // 
            // checkBoxHelp
            // 
            this.checkBoxHelp.AutoSize = true;
            this.checkBoxHelp.Location = new System.Drawing.Point(153, 58);
            this.checkBoxHelp.Name = "checkBoxHelp";
            this.checkBoxHelp.Size = new System.Drawing.Size(78, 17);
            this.checkBoxHelp.TabIndex = 35;
            this.checkBoxHelp.Text = "Show Help";
            this.checkBoxHelp.UseVisualStyleBackColor = true;
            // 
            // cbLanguages
            // 
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Items.AddRange(new object[] {
            "English",
            "Chinese",
            "Danish",
            "Dutch",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Polish",
            "Portuguese (Brazil)",
            "Spanish (Spain)",
            "Spanish (Mexico)",
            "Swedish",
            "Turkish"});
            this.cbLanguages.Location = new System.Drawing.Point(153, 23);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(121, 23);
            this.cbLanguages.TabIndex = 33;
            // 
            // Language
            // 
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.ForeColor = System.Drawing.Color.White;
            this.Language.Location = new System.Drawing.Point(62, 26);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(85, 13);
            this.Language.TabIndex = 32;
            this.Language.Text = "Press Language";
            this.Language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clcGroupBox
            // 
            this.clcGroupBox.Controls.Add(this.cqPortTextBox);
            this.clcGroupBox.Controls.Add(this.portLabel);
            this.clcGroupBox.Controls.Add(this.cqIPAddressTextBox);
            this.clcGroupBox.Controls.Add(this.ipAddressLabel);
            this.clcGroupBox.Controls.Add(this.isCLCOEMCheckBox);
            this.clcGroupBox.ForeColor = System.Drawing.Color.White;
            this.clcGroupBox.Location = new System.Drawing.Point(9, 535);
            this.clcGroupBox.Name = "clcGroupBox";
            this.clcGroupBox.Size = new System.Drawing.Size(317, 96);
            this.clcGroupBox.TabIndex = 31;
            this.clcGroupBox.TabStop = false;
            this.clcGroupBox.Text = "Clarios Closed Loop Color - GMINET";
            // 
            // cqPortTextBox
            // 
            this.cqPortTextBox.Enabled = false;
            this.cqPortTextBox.Location = new System.Drawing.Point(153, 66);
            this.cqPortTextBox.Name = "cqPortTextBox";
            this.cqPortTextBox.Size = new System.Drawing.Size(146, 20);
            this.cqPortTextBox.TabIndex = 4;
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(21, 65);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(126, 23);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "CQ Server Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cqIPAddressTextBox
            // 
            this.cqIPAddressTextBox.Enabled = false;
            this.cqIPAddressTextBox.Location = new System.Drawing.Point(153, 40);
            this.cqIPAddressTextBox.Name = "cqIPAddressTextBox";
            this.cqIPAddressTextBox.Size = new System.Drawing.Size(146, 20);
            this.cqIPAddressTextBox.TabIndex = 2;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.Location = new System.Drawing.Point(21, 39);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(126, 23);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "CQ App Server IP Address";
            this.ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isCLCOEMCheckBox
            // 
            this.isCLCOEMCheckBox.AutoSize = true;
            this.isCLCOEMCheckBox.ForeColor = System.Drawing.Color.White;
            this.isCLCOEMCheckBox.Location = new System.Drawing.Point(7, 20);
            this.isCLCOEMCheckBox.Name = "isCLCOEMCheckBox";
            this.isCLCOEMCheckBox.Size = new System.Drawing.Size(193, 17);
            this.isCLCOEMCheckBox.TabIndex = 0;
            this.isCLCOEMCheckBox.Text = "Configure as Color Quick CLC OEM";
            this.isCLCOEMCheckBox.UseVisualStyleBackColor = true;
            this.isCLCOEMCheckBox.CheckedChanged += new System.EventHandler(this.isCLCOEMCheckBox_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(871, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseNew
            // 
            this.btnCloseNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseNew.Image")));
            this.btnCloseNew.Location = new System.Drawing.Point(935, 569);
            this.btnCloseNew.Name = "btnCloseNew";
            this.btnCloseNew.Size = new System.Drawing.Size(58, 51);
            this.btnCloseNew.TabIndex = 30;
            this.btnCloseNew.UseVisualStyleBackColor = true;
            this.btnCloseNew.Click += new System.EventHandler(this.btnCloseNew_Click);
            // 
            // gpSiteInformation
            // 
            this.gpSiteInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpSiteInformation.Controls.Add(this.txtSiteNumber);
            this.gpSiteInformation.Controls.Add(this.txtSiteName);
            this.gpSiteInformation.Controls.Add(this.labelSiteNumber);
            this.gpSiteInformation.Controls.Add(this.labelSiteName);
            this.gpSiteInformation.Controls.Add(this.buttonCancel);
            this.gpSiteInformation.Controls.Add(this.buttonOK);
            this.gpSiteInformation.Controls.Add(this.groupBox6);
            this.gpSiteInformation.Controls.Add(this.txtPressWidth);
            this.gpSiteInformation.Controls.Add(this.txtPressName);
            this.gpSiteInformation.Controls.Add(this.labelPressWidth);
            this.gpSiteInformation.Controls.Add(this.labelPressName);
            this.gpSiteInformation.Controls.Add(this.comboBoxPressType);
            this.gpSiteInformation.Controls.Add(this.labelPressType);
            this.gpSiteInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSiteInformation.ForeColor = System.Drawing.Color.White;
            this.gpSiteInformation.Location = new System.Drawing.Point(9, 17);
            this.gpSiteInformation.Name = "gpSiteInformation";
            this.gpSiteInformation.Size = new System.Drawing.Size(363, 316);
            this.gpSiteInformation.TabIndex = 22;
            this.gpSiteInformation.TabStop = false;
            this.gpSiteInformation.Text = "Site Information";
            // 
            // txtSiteNumber
            // 
            this.txtSiteNumber.Location = new System.Drawing.Point(100, 126);
            this.txtSiteNumber.MaxLength = 4;
            this.txtSiteNumber.Name = "txtSiteNumber";
            this.txtSiteNumber.Size = new System.Drawing.Size(241, 20);
            this.txtSiteNumber.TabIndex = 33;
            this.txtSiteNumber.TextChanged += new System.EventHandler(this.txtSiteNumber_TextChanged);
            this.txtSiteNumber.Leave += new System.EventHandler(this.txtSiteNumber_Leave);
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(100, 92);
            this.txtSiteName.MaxLength = 62;
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(241, 20);
            this.txtSiteName.TabIndex = 32;
            this.txtSiteName.TextChanged += new System.EventHandler(this.txtSiteName_TextChanged);
            this.txtSiteName.Leave += new System.EventHandler(this.txtSiteName_Leave);
            // 
            // labelSiteNumber
            // 
            this.labelSiteNumber.ForeColor = System.Drawing.Color.White;
            this.labelSiteNumber.Location = new System.Drawing.Point(13, 129);
            this.labelSiteNumber.Name = "labelSiteNumber";
            this.labelSiteNumber.Size = new System.Drawing.Size(81, 13);
            this.labelSiteNumber.TabIndex = 31;
            this.labelSiteNumber.Text = "Site Number";
            this.labelSiteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSiteName
            // 
            this.labelSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiteName.ForeColor = System.Drawing.Color.White;
            this.labelSiteName.Location = new System.Drawing.Point(13, 95);
            this.labelSiteName.Name = "labelSiteName";
            this.labelSiteName.Size = new System.Drawing.Size(81, 13);
            this.labelSiteName.TabIndex = 30;
            this.labelSiteName.Text = "Site Name";
            this.labelSiteName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.buttonCancel.Location = new System.Drawing.Point(199, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(58, 51);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonOK.Enabled = false;
            this.buttonOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.buttonOK.Location = new System.Drawing.Point(120, 255);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(58, 51);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxCMS);
            this.groupBox6.Controls.Add(this.checkBoxInches);
            this.groupBox6.Controls.Add(this.checkBoxMM);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(25, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 57);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Unit of measurement";
            // 
            // checkBoxCMS
            // 
            this.checkBoxCMS.AutoSize = true;
            this.checkBoxCMS.Checked = true;
            this.checkBoxCMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCMS.Location = new System.Drawing.Point(123, 26);
            this.checkBoxCMS.Name = "checkBoxCMS";
            this.checkBoxCMS.Size = new System.Drawing.Size(40, 17);
            this.checkBoxCMS.TabIndex = 2;
            this.checkBoxCMS.Text = "cm";
            this.checkBoxCMS.UseVisualStyleBackColor = true;
            this.checkBoxCMS.CheckedChanged += new System.EventHandler(this.checkBoxCMS_CheckedChanged);
            // 
            // checkBoxInches
            // 
            this.checkBoxInches.AutoSize = true;
            this.checkBoxInches.Location = new System.Drawing.Point(202, 26);
            this.checkBoxInches.Name = "checkBoxInches";
            this.checkBoxInches.Size = new System.Drawing.Size(57, 17);
            this.checkBoxInches.TabIndex = 1;
            this.checkBoxInches.Text = "inches";
            this.checkBoxInches.UseVisualStyleBackColor = true;
            this.checkBoxInches.CheckedChanged += new System.EventHandler(this.checkBoxInches_CheckedChanged);
            // 
            // checkBoxMM
            // 
            this.checkBoxMM.AutoSize = true;
            this.checkBoxMM.Location = new System.Drawing.Point(47, 26);
            this.checkBoxMM.Name = "checkBoxMM";
            this.checkBoxMM.Size = new System.Drawing.Size(42, 17);
            this.checkBoxMM.TabIndex = 0;
            this.checkBoxMM.Text = "mm";
            this.checkBoxMM.UseVisualStyleBackColor = true;
            this.checkBoxMM.CheckedChanged += new System.EventHandler(this.checkBoxMM_CheckedChanged);
            // 
            // txtPressWidth
            // 
            this.txtPressWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPressWidth.Location = new System.Drawing.Point(100, 160);
            this.txtPressWidth.MaxLength = 10;
            this.txtPressWidth.Name = "txtPressWidth";
            this.txtPressWidth.Size = new System.Drawing.Size(241, 20);
            this.txtPressWidth.TabIndex = 25;
            this.txtPressWidth.TextChanged += new System.EventHandler(this.txtPressWidth_TextChanged);
            this.txtPressWidth.Leave += new System.EventHandler(this.txtPressWidth_Leave);
            // 
            // txtPressName
            // 
            this.txtPressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPressName.Location = new System.Drawing.Point(100, 58);
            this.txtPressName.MaxLength = 62;
            this.txtPressName.Name = "txtPressName";
            this.txtPressName.Size = new System.Drawing.Size(241, 20);
            this.txtPressName.TabIndex = 24;
            this.txtPressName.TextChanged += new System.EventHandler(this.txtPressName_TextChanged);
            this.txtPressName.Leave += new System.EventHandler(this.txtPressName_Leave);
            // 
            // labelPressWidth
            // 
            this.labelPressWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressWidth.ForeColor = System.Drawing.Color.White;
            this.labelPressWidth.Location = new System.Drawing.Point(13, 163);
            this.labelPressWidth.Name = "labelPressWidth";
            this.labelPressWidth.Size = new System.Drawing.Size(81, 13);
            this.labelPressWidth.TabIndex = 23;
            this.labelPressWidth.Text = "Press Width";
            this.labelPressWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPressName
            // 
            this.labelPressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressName.ForeColor = System.Drawing.Color.White;
            this.labelPressName.Location = new System.Drawing.Point(13, 61);
            this.labelPressName.Name = "labelPressName";
            this.labelPressName.Size = new System.Drawing.Size(81, 13);
            this.labelPressName.TabIndex = 22;
            this.labelPressName.Text = "Press Name";
            this.labelPressName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPressType
            // 
            this.comboBoxPressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPressType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPressType.FormattingEnabled = true;
            this.comboBoxPressType.Items.AddRange(new object[] {
            "Unitized Web Press Without Turnbar",
            "Unitized Web Press With Turnbar",
            "Single Web Press",
            "Dual / Multi Web Press",
            "Tower Press",
            "Single Sided CIC"});
            this.comboBoxPressType.Location = new System.Drawing.Point(100, 23);
            this.comboBoxPressType.Name = "comboBoxPressType";
            this.comboBoxPressType.Size = new System.Drawing.Size(241, 21);
            this.comboBoxPressType.TabIndex = 20;
            this.comboBoxPressType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPressType_SelectedIndexChanged);
            this.comboBoxPressType.Leave += new System.EventHandler(this.comboBoxPressType_Leave);
            // 
            // labelPressType
            // 
            this.labelPressType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressType.ForeColor = System.Drawing.Color.White;
            this.labelPressType.Location = new System.Drawing.Point(13, 26);
            this.labelPressType.Name = "labelPressType";
            this.labelPressType.Size = new System.Drawing.Size(81, 13);
            this.labelPressType.TabIndex = 10;
            this.labelPressType.Text = "Press Type";
            this.labelPressType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpPressConfigurations
            // 
            this.gpPressConfigurations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPressConfigurations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpPressConfigurations.Controls.Add(this.pnlFountainWizard);
            this.gpPressConfigurations.Controls.Add(this.stripPressConfig);
            this.gpPressConfigurations.Enabled = false;
            this.gpPressConfigurations.ForeColor = System.Drawing.Color.White;
            this.gpPressConfigurations.Location = new System.Drawing.Point(384, 17);
            this.gpPressConfigurations.Name = "gpPressConfigurations";
            this.gpPressConfigurations.Size = new System.Drawing.Size(609, 550);
            this.gpPressConfigurations.TabIndex = 21;
            this.gpPressConfigurations.TabStop = false;
            this.gpPressConfigurations.Text = "Press Setup";
            // 
            // pnlFountainWizard
            // 
            this.pnlFountainWizard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFountainWizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFountainWizard.Controls.Add(this.groupBox3);
            this.pnlFountainWizard.Controls.Add(this.gpInkerConfigurations);
            this.pnlFountainWizard.Controls.Add(this.btnBack);
            this.pnlFountainWizard.Controls.Add(this.pnlWizardTitle);
            this.pnlFountainWizard.Controls.Add(this.btnCancel);
            this.pnlFountainWizard.Controls.Add(this.btnNext);
            this.pnlFountainWizard.Controls.Add(this.IndicateProgress);
            this.pnlFountainWizard.Location = new System.Drawing.Point(6, 52);
            this.pnlFountainWizard.Name = "pnlFountainWizard";
            this.pnlFountainWizard.Size = new System.Drawing.Size(597, 497);
            this.pnlFountainWizard.TabIndex = 37;
            this.pnlFountainWizard.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.m_importPRSGroupBox);      //import Press Constructor PRS config file settings group
            this.groupBox3.Controls.Add(this.cbFunnyfountains);         //Funny Fountains option control
            this.groupBox3.Controls.Add(this.cbVirtualInkers);   //Virtual Innkers option control
            this.groupBox3.Controls.Add(this.isWidePressCheckBox);      //Wide Press option control
            this.groupBox3.Controls.Add(this.m_commonSettingsGroupBox); //Common Settings Fountain settings grouup
            this.groupBox3.Controls.Add(this.lstPressType);             //list box for Press Type (Fountain Wizard view #1 only)
//            this.groupBox3.Controls.Add(this.groupBox4);                //group 4 - was TurnBar option here but now orphaned - now part of stripPressConfig
                                                                // See TurnBars.cs code
            this.groupBox3.Controls.Add(this.rbtnOneToTwo);             //Two fountains in One Unit indicator   (related to Press Type)
            this.groupBox3.Controls.Add(this.rbtnInkerOneToOne);        //One Fountain in One Unit indicator  (related to Press Type)
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(7, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unit to Fountain Mapping...";
            // 
            // m_importPRSGroupBox
            // 
            this.m_importPRSGroupBox.Controls.Add(this.m_prsLabelPath);
            this.m_importPRSGroupBox.Controls.Add(this.m_PRSFileLocationText);
            this.m_importPRSGroupBox.Controls.Add(this.m_importPRSButton);
            this.m_importPRSGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_importPRSGroupBox.Location = new System.Drawing.Point(9, 98);
            this.m_importPRSGroupBox.Name = "m_importPRSGroupBox";
            this.m_importPRSGroupBox.Size = new System.Drawing.Size(535, 62);
            this.m_importPRSGroupBox.TabIndex = 4;
            this.m_importPRSGroupBox.TabStop = false;
            this.m_importPRSGroupBox.Text = "Import PRS File:";
            this.m_importPRSGroupBox.Visible = false;
            // 
            // m_prsLabelPath
            // 
            this.m_prsLabelPath.AutoSize = true;
            this.m_prsLabelPath.Location = new System.Drawing.Point(8, 28);
            this.m_prsLabelPath.Name = "m_prsLabelPath";
            this.m_prsLabelPath.Size = new System.Drawing.Size(76, 13);
            this.m_prsLabelPath.TabIndex = 2;
            this.m_prsLabelPath.Text = "PRS File Path:";
            // 
            // m_PRSFileLocationText
            // 
            this.m_PRSFileLocationText.Enabled = false;
            this.m_PRSFileLocationText.Location = new System.Drawing.Point(87, 25);
            this.m_PRSFileLocationText.Name = "m_PRSFileLocationText";
            this.m_PRSFileLocationText.Size = new System.Drawing.Size(367, 20);
            this.m_PRSFileLocationText.TabIndex = 1;
            // 
            // m_importPRSButton
            // 
            this.m_importPRSButton.BackColor = System.Drawing.Color.DimGray;
            this.m_importPRSButton.ForeColor = System.Drawing.Color.White;
            this.m_importPRSButton.Location = new System.Drawing.Point(460, 19);
            this.m_importPRSButton.Name = "m_importPRSButton";
            this.m_importPRSButton.Size = new System.Drawing.Size(69, 31);
            this.m_importPRSButton.TabIndex = 0;
            this.m_importPRSButton.Text = "Browse ...";
            this.m_importPRSButton.UseVisualStyleBackColor = false;
            this.m_importPRSButton.Click += new System.EventHandler(this.OnImportPRSFileButtonClick);
            // 
            // cbFunnyfountains
            // 
            this.cbFunnyfountains.AutoSize = true;
            this.cbFunnyfountains.Location = new System.Drawing.Point(30, 78);
            this.cbFunnyfountains.Name = "cbFunnyfountains";
            this.cbFunnyfountains.Size = new System.Drawing.Size(101, 17);
            this.cbFunnyfountains.TabIndex = 3;
            this.cbFunnyfountains.Text = "Funny fountains";
            this.cbFunnyfountains.UseVisualStyleBackColor = true;
            this.cbFunnyfountains.CheckedChanged += new System.EventHandler(this.cbFunnyfountains_CheckedChanged);
            // 
            // cbVirtualInkers
            // 
            this.cbVirtualInkers.AutoSize = true;
            this.cbVirtualInkers.Location = new System.Drawing.Point(30, 98);
            this.cbVirtualInkers.Name = "cbVirtualInkers";
            this.cbVirtualInkers.Size = new System.Drawing.Size(101, 17);
            this.cbVirtualInkers.TabIndex = 4;
            this.cbVirtualInkers.Text = "Virtual Inkers";
            this.cbVirtualInkers.UseVisualStyleBackColor = true;
            this.cbVirtualInkers.CheckedChanged += new System.EventHandler(this.cbVirtualInkers_CheckedChanged);
            // 
            // isWidePressCheckBox
            // 
            this.isWidePressCheckBox.AutoSize = true;
            this.isWidePressCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.isWidePressCheckBox.Location = new System.Drawing.Point(30, 58);
            this.isWidePressCheckBox.Name = "isWidePressCheckBox";
            this.isWidePressCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isWidePressCheckBox.TabIndex = 2;
            this.isWidePressCheckBox.Text = "Wide Press";
            this.isWidePressCheckBox.UseVisualStyleBackColor = true;
            this.isWidePressCheckBox.CheckedChanged += new System.EventHandler(this.IsWidePressCheckBox_CheckedChanged);
            // 
            // m_commonSettingsGroupBox
            // 
            this.m_commonSettingsGroupBox.Controls.Add(this.tbDisplayZones);
            this.m_commonSettingsGroupBox.Controls.Add(this.lblDisplayZones);
            this.m_commonSettingsGroupBox.Controls.Add(this.lblKeyWidthUnits);
            this.m_commonSettingsGroupBox.Controls.Add(this.groupBox5);
            this.m_commonSettingsGroupBox.Controls.Add(this.label10);
            this.m_commonSettingsGroupBox.Controls.Add(this.txtKeysPerfountain);
            this.m_commonSettingsGroupBox.Controls.Add(this.txtKeyWidth);
            this.m_commonSettingsGroupBox.Controls.Add(this.txtFountainCount);
            this.m_commonSettingsGroupBox.Controls.Add(this.label9);
            this.m_commonSettingsGroupBox.Controls.Add(this.label7);
            this.m_commonSettingsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_commonSettingsGroupBox.Location = new System.Drawing.Point(9, 164);
            this.m_commonSettingsGroupBox.Name = "m_commonSettingsGroupBox";
            this.m_commonSettingsGroupBox.Size = new System.Drawing.Size(332, 245);
            this.m_commonSettingsGroupBox.TabIndex = 5;
            this.m_commonSettingsGroupBox.TabStop = false;
            this.m_commonSettingsGroupBox.Text = "Common Settings for all the fountain";
            // 
            // tbDisplayZones
            // 
            this.tbDisplayZones.Location = new System.Drawing.Point(169, 94);
            this.tbDisplayZones.MaxLength = 2;
            this.tbDisplayZones.Name = "tbDisplayZones";
            this.tbDisplayZones.Size = new System.Drawing.Size(110, 20);
            this.tbDisplayZones.TabIndex = 2;
            this.tbDisplayZones.Text = "16";
            this.tbDisplayZones.Leave += new EventHandler( tbDisplayZones_Leave );
            // 
            // lblDisplayZones
            // 
            this.lblDisplayZones.AutoSize = true;
            this.lblDisplayZones.Location = new System.Drawing.Point(87, 98);
            this.lblDisplayZones.Name = "lblDisplayZones";
            this.lblDisplayZones.Size = new System.Drawing.Size(74, 13);
            this.lblDisplayZones.TabIndex = 34;
            this.lblDisplayZones.Text = "Display Zones";
            this.lblDisplayZones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKeyWidthUnits
            // 
            this.lblKeyWidthUnits.AutoSize = true;
            this.lblKeyWidthUnits.Location = new System.Drawing.Point(283, 130);
            this.lblKeyWidthUnits.Name = "lblKeyWidthUnits";
            this.lblKeyWidthUnits.Size = new System.Drawing.Size(23, 13);
            this.lblKeyWidthUnits.TabIndex = 10;
            this.lblKeyWidthUnits.Text = "mm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkCms);
            this.groupBox5.Controls.Add(this.chkInches);
            this.groupBox5.Controls.Add(this.chkMM);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(14, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 64);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unit of measurement";
            // 
            // chkCms
            // 
            this.chkCms.AutoSize = true;
            this.chkCms.Location = new System.Drawing.Point(215, 30);
            this.chkCms.Name = "chkCms";
            this.chkCms.Size = new System.Drawing.Size(45, 17);
            this.chkCms.TabIndex = 2;
            this.chkCms.Text = "cms";
            this.chkCms.UseVisualStyleBackColor = true;
            this.chkCms.CheckedChanged += new System.EventHandler(this.chkCms_CheckedChanged);
            // 
            // chkInches
            // 
            this.chkInches.AutoSize = true;
            this.chkInches.Location = new System.Drawing.Point(118, 30);
            this.chkInches.Name = "chkInches";
            this.chkInches.Size = new System.Drawing.Size(57, 17);
            this.chkInches.TabIndex = 1;
            this.chkInches.Text = "inches";
            this.chkInches.UseVisualStyleBackColor = true;
            this.chkInches.CheckedChanged += new System.EventHandler(this.chkInches_CheckedChanged);
            // 
            // chkMM
            // 
            this.chkMM.AutoSize = true;
            this.chkMM.Checked = true;
            this.chkMM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMM.Location = new System.Drawing.Point(46, 30);
            this.chkMM.Name = "chkMM";
            this.chkMM.Size = new System.Drawing.Size(42, 17);
            this.chkMM.TabIndex = 0;
            this.chkMM.Text = "mm";
            this.chkMM.UseVisualStyleBackColor = true;
            this.chkMM.CheckedChanged += new System.EventHandler(this.chkMM_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(60, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Key Width";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKeysPerfountain
            // 
            this.txtKeysPerfountain.Location = new System.Drawing.Point(169, 64);
            this.txtKeysPerfountain.MaxLength = 5;
            this.txtKeysPerfountain.Name = "txtKeysPerfountain";
            this.txtKeysPerfountain.ReadOnly = true;
            this.txtKeysPerfountain.Size = new System.Drawing.Size(110, 20);
            this.txtKeysPerfountain.TabIndex = 1;
            this.txtKeysPerfountain.Text = "16";
            this.txtKeysPerfountain.TextChanged += new System.EventHandler(this.txtKeysPerfountain_TextChanged);
            this.txtKeysPerfountain.Leave += new System.EventHandler(this.txtKeysPerfountain_Leave);
            // 
            // txtKeyWidth
            // 
            this.txtKeyWidth.Location = new System.Drawing.Point(169, 126);
            this.txtKeyWidth.MaxLength = 10;
            this.txtKeyWidth.Name = "txtKeyWidth";
            this.txtKeyWidth.Size = new System.Drawing.Size(110, 20);
            this.txtKeyWidth.TabIndex = 3;
            this.txtKeyWidth.Text = "27.725";
            this.txtKeyWidth.TextChanged += new System.EventHandler(this.txtKeyWidth_TextChanged);
            this.txtKeyWidth.Leave += new System.EventHandler(this.txtKeyWidth_Leave);
            // 
            // txtFountainCount
            // 
            this.txtFountainCount.Location = new System.Drawing.Point(169, 33);
            this.txtFountainCount.MaxLength = 5;
            this.txtFountainCount.Name = "txtFountainCount";
            this.txtFountainCount.Size = new System.Drawing.Size(110, 20);
            this.txtFountainCount.TabIndex = 0;
            this.txtFountainCount.Text = "12";
            this.txtFountainCount.TextChanged += new System.EventHandler(this.txtFountainCount_TextChanged);
            this.txtFountainCount.Leave += new System.EventHandler(this.txtFountainCount_Leave);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Servos on Fountain";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(36, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Fountains";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstPressType
            // 
            this.lstPressType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPressType.FormattingEnabled = true;
            this.lstPressType.Items.AddRange(new object[] {
            "Unitized Press For Label Printing"});
            this.lstPressType.Location = new System.Drawing.Point(343, 16);
            this.lstPressType.Name = "lstPressType";
            this.lstPressType.Size = new System.Drawing.Size(201, 20);
            this.lstPressType.TabIndex = 1;
            this.lstPressType.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkTurnBar);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.rButtonOneSurface);
            this.groupBox4.Location = new System.Drawing.Point(361, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // chkTurnBar
            // 
            this.chkTurnBar.AutoSize = true;
            this.chkTurnBar.Location = new System.Drawing.Point(16, 81);
            this.chkTurnBar.Name = "chkTurnBar";
            this.chkTurnBar.Size = new System.Drawing.Size(114, 17);
            this.chkTurnBar.TabIndex = 7;
            this.chkTurnBar.Text = "Turn Bars Enabled";
            this.chkTurnBar.UseVisualStyleBackColor = true;
            this.chkTurnBar.CheckedChanged += new System.EventHandler(this.chkTurnBar_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(16, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Two Surface Printing";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rButtonOneSurface
            // 
            this.rButtonOneSurface.AutoSize = true;
            this.rButtonOneSurface.Checked = true;
            this.rButtonOneSurface.Location = new System.Drawing.Point(15, 19);
            this.rButtonOneSurface.Name = "rButtonOneSurface";
            this.rButtonOneSurface.Size = new System.Drawing.Size(123, 17);
            this.rButtonOneSurface.TabIndex = 5;
            this.rButtonOneSurface.TabStop = true;
            this.rButtonOneSurface.Text = "One Surface Printing";
            this.rButtonOneSurface.UseVisualStyleBackColor = true;
            this.rButtonOneSurface.CheckedChanged += new System.EventHandler(this.rButtonOneSurface_CheckedChanged);
            // 
            // rbtnOneToTwo
            // 
            this.rbtnOneToTwo.AutoSize = true;
            this.rbtnOneToTwo.Enabled = false;
            this.rbtnOneToTwo.Location = new System.Drawing.Point(30, 37);
            this.rbtnOneToTwo.Name = "rbtnOneToTwo";
            this.rbtnOneToTwo.Size = new System.Drawing.Size(176, 17);
            this.rbtnOneToTwo.TabIndex = 1;
            this.rbtnOneToTwo.Text = "Two Fountain Maps to One Unit";
            this.rbtnOneToTwo.UseVisualStyleBackColor = true;
            // 
            // rbtnInkerOneToOne
            // 
            this.rbtnInkerOneToOne.AutoSize = true;
            this.rbtnInkerOneToOne.Location = new System.Drawing.Point(30, 19);
            this.rbtnInkerOneToOne.Name = "rbtnInkerOneToOne";
            this.rbtnInkerOneToOne.Size = new System.Drawing.Size(130, 17);
            this.rbtnInkerOneToOne.TabIndex = 0;
            this.rbtnInkerOneToOne.Text = "One Fountain Per Unit";
            this.rbtnInkerOneToOne.UseVisualStyleBackColor = true;
            // 
            // gpInkerConfigurations
            // 
            this.gpInkerConfigurations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpInkerConfigurations.Controls.Add(this.ListViewInkers);
            this.gpInkerConfigurations.Controls.Add(this.checkBoxVirtualInker);
            this.gpInkerConfigurations.Controls.Add(this.btnInkerNameChange);
            this.gpInkerConfigurations.Controls.Add(this.txtMaxConsole);
            this.gpInkerConfigurations.Controls.Add(this.txtMinConsole);
            this.gpInkerConfigurations.Controls.Add(this.label12);
            this.gpInkerConfigurations.Controls.Add(this.label11);
            this.gpInkerConfigurations.Controls.Add(this.txtServoTurns);
            this.gpInkerConfigurations.Controls.Add(this.label8);
            this.gpInkerConfigurations.Controls.Add(this.gpBank2);
            this.gpInkerConfigurations.Controls.Add(this.gpBank1);
            this.gpInkerConfigurations.Controls.Add(this.label14);
            this.gpInkerConfigurations.Controls.Add(this.cboInkerList);
            this.gpInkerConfigurations.Controls.Add(this.chkInverted);
            this.gpInkerConfigurations.Controls.Add(this.chkUpperInker);
            this.gpInkerConfigurations.Controls.Add(this.groupBox2);
            this.gpInkerConfigurations.ForeColor = System.Drawing.Color.White;
            this.gpInkerConfigurations.Location = new System.Drawing.Point(6, 34);
            this.gpInkerConfigurations.Name = "gpInkerConfigurations";
            this.gpInkerConfigurations.Size = new System.Drawing.Size(586, 413);
            this.gpInkerConfigurations.TabIndex = 9;
            this.gpInkerConfigurations.TabStop = false;
            this.gpInkerConfigurations.Text = "Inker Specifications";
            this.gpInkerConfigurations.Visible = false;
            // 
            // ListViewInkers
            // 
            this.ListViewInkers.AllowColumnResize = true;
            this.ListViewInkers.AllowMultiselect = false;
            this.ListViewInkers.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.ListViewInkers.AlternatingColors = false;
            this.ListViewInkers.AutoHeight = true;
            this.ListViewInkers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListViewInkers.BackgroundStretchToFit = true;
            this.ListViewInkers.ControlStyle = MC3Components.Controls.GLControlStyles.Normal;
            this.ListViewInkers.ForeColor = System.Drawing.Color.Black;
            this.ListViewInkers.FullRowSelect = false;
            this.ListViewInkers.GridColor = System.Drawing.Color.LightGray;
            this.ListViewInkers.GridLines = MC3Components.Controls.GLGridLines.gridBoth;
            this.ListViewInkers.GridLineStyle = MC3Components.Controls.GLGridLineStyles.gridSolid;
            this.ListViewInkers.GridTypes = MC3Components.Controls.GLGridTypes.gridOnExists;
            this.ListViewInkers.HeaderHeight = 35;
            this.ListViewInkers.HeaderVisible = true;
            this.ListViewInkers.HeaderWordWrap = true;
            this.ListViewInkers.HotColumnTracking = false;
            this.ListViewInkers.HotItemTracking = false;
            this.ListViewInkers.HotTrackingColor = System.Drawing.Color.LightGray;
            this.ListViewInkers.HoverEvents = false;
            this.ListViewInkers.HoverTime = 1;
            this.ListViewInkers.ImageList = null;
            this.ListViewInkers.ItemHeight = 16;
            this.ListViewInkers.ItemWordWrap = false;
            this.ListViewInkers.Location = new System.Drawing.Point(16, 14);
            this.ListViewInkers.Name = "ListViewInkers";
            this.ListViewInkers.Selectable = true;
            this.ListViewInkers.SelectedTextColor = System.Drawing.Color.White;
            this.ListViewInkers.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.ListViewInkers.ShowBorder = true;
            this.ListViewInkers.ShowFocusRect = false;
            this.ListViewInkers.Size = new System.Drawing.Size(537, 281);
            this.ListViewInkers.SortType = MC3Components.Controls.SortTypes.None;
            this.ListViewInkers.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.ListViewInkers.TabIndex = 11;
            this.ListViewInkers.Text = "mC3ListView1";
            // 
            // checkBoxVirtualInker
            // 
            this.checkBoxVirtualInker.AutoSize = true;
            this.checkBoxVirtualInker.Location = new System.Drawing.Point(189, 185);
            this.checkBoxVirtualInker.Name = "checkBoxVirtualInker";
            this.checkBoxVirtualInker.Size = new System.Drawing.Size(82, 17);
            this.checkBoxVirtualInker.TabIndex = 25;
            this.checkBoxVirtualInker.Text = "Virtual Inker";
            this.checkBoxVirtualInker.UseVisualStyleBackColor = true;
            this.checkBoxVirtualInker.CheckedChanged += new System.EventHandler(this.checkBoxVirtualInker_CheckedChanged);
            // 
            // btnInkerNameChange
            // 
            this.btnInkerNameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInkerNameChange.ForeColor = System.Drawing.Color.Black;
            this.btnInkerNameChange.Location = new System.Drawing.Point(177, 46);
            this.btnInkerNameChange.Name = "btnInkerNameChange";
            this.btnInkerNameChange.Size = new System.Drawing.Size(83, 23);
            this.btnInkerNameChange.TabIndex = 24;
            this.btnInkerNameChange.Text = "Change...";
            this.btnInkerNameChange.UseVisualStyleBackColor = true;
            this.btnInkerNameChange.Click += new System.EventHandler(this.btnInkerNameChange_Click);
            // 
            // txtMaxConsole
            // 
            this.txtMaxConsole.Location = new System.Drawing.Point(430, 35);
            this.txtMaxConsole.Name = "txtMaxConsole";
            this.txtMaxConsole.ReadOnly = true;
            this.txtMaxConsole.Size = new System.Drawing.Size(100, 20);
            this.txtMaxConsole.TabIndex = 20;
            this.txtMaxConsole.Text = "99";
            this.txtMaxConsole.Visible = false;
            this.txtMaxConsole.TextChanged += new System.EventHandler(this.txtMaxConsole_TextChanged);
            // 
            // txtMinConsole
            // 
            this.txtMinConsole.Location = new System.Drawing.Point(430, 66);
            this.txtMinConsole.Name = "txtMinConsole";
            this.txtMinConsole.ReadOnly = true;
            this.txtMinConsole.Size = new System.Drawing.Size(100, 20);
            this.txtMinConsole.TabIndex = 19;
            this.txtMinConsole.Text = "0";
            this.txtMinConsole.Visible = false;
            this.txtMinConsole.TextChanged += new System.EventHandler(this.txtMinConsole_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Max Console Value";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Min Console Value";
            this.label11.Visible = false;
            // 
            // txtServoTurns
            // 
            this.txtServoTurns.Location = new System.Drawing.Point(430, 98);
            this.txtServoTurns.MaxLength = 5;
            this.txtServoTurns.Name = "txtServoTurns";
            this.txtServoTurns.Size = new System.Drawing.Size(100, 20);
            this.txtServoTurns.TabIndex = 16;
            this.txtServoTurns.Text = "0.7";
            this.txtServoTurns.Visible = false;
            this.txtServoTurns.TextChanged += new System.EventHandler(this.txtServoTurns_TextChanged);
            this.txtServoTurns.Leave += new System.EventHandler(this.txtServoTurns_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Servo Turns";
            // 
            // gpBank2
            // 
            this.gpBank2.Controls.Add(this.textBox2);
            this.gpBank2.Controls.Add(this.textBox3);
            this.gpBank2.Controls.Add(this.textBox4);
            this.gpBank2.Controls.Add(this.textBox5);
            this.gpBank2.Controls.Add(this.label19);
            this.gpBank2.Controls.Add(this.label20);
            this.gpBank2.Controls.Add(this.label21);
            this.gpBank2.Controls.Add(this.label22);
            this.gpBank2.Enabled = false;
            this.gpBank2.ForeColor = System.Drawing.Color.White;
            this.gpBank2.Location = new System.Drawing.Point(312, 225);
            this.gpBank2.Name = "gpBank2";
            this.gpBank2.Size = new System.Drawing.Size(230, 144);
            this.gpBank2.TabIndex = 14;
            this.gpBank2.TabStop = false;
            this.gpBank2.Text = "Bank 2 Information";
            this.gpBank2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Start From Key";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Total Keys To control";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Port of Inker On SPU";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "SPU Name";
            // 
            // gpBank1
            // 
            this.gpBank1.Controls.Add(this.cboSPU);
            this.gpBank1.Controls.Add(this.txtFirstKey);
            this.gpBank1.Controls.Add(this.txtTotalKeysToCtrl);
            this.gpBank1.Controls.Add(this.txtPortOnInker);
            this.gpBank1.Controls.Add(this.label18);
            this.gpBank1.Controls.Add(this.label17);
            this.gpBank1.Controls.Add(this.label16);
            this.gpBank1.Controls.Add(this.label15);
            this.gpBank1.ForeColor = System.Drawing.Color.White;
            this.gpBank1.Location = new System.Drawing.Point(17, 222);
            this.gpBank1.Name = "gpBank1";
            this.gpBank1.Size = new System.Drawing.Size(230, 145);
            this.gpBank1.TabIndex = 13;
            this.gpBank1.TabStop = false;
            this.gpBank1.Text = "Bank 1 Information";
            this.gpBank1.Visible = false;
            // 
            // cboSPU
            // 
            this.cboSPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSPU.FormattingEnabled = true;
            this.cboSPU.Location = new System.Drawing.Point(124, 29);
            this.cboSPU.Name = "cboSPU";
            this.cboSPU.Size = new System.Drawing.Size(100, 21);
            this.cboSPU.TabIndex = 8;
            this.cboSPU.SelectedIndexChanged += new System.EventHandler(this.cboSPU_SelectedIndexChanged);
            // 
            // txtFirstKey
            // 
            this.txtFirstKey.Location = new System.Drawing.Point(124, 110);
            this.txtFirstKey.MaxLength = 5;
            this.txtFirstKey.Name = "txtFirstKey";
            this.txtFirstKey.Size = new System.Drawing.Size(100, 20);
            this.txtFirstKey.TabIndex = 7;
            this.txtFirstKey.Text = "0";
            this.txtFirstKey.TextChanged += new System.EventHandler(this.txtFirstKey_TextChanged);
            // 
            // txtTotalKeysToCtrl
            // 
            this.txtTotalKeysToCtrl.Location = new System.Drawing.Point(124, 84);
            this.txtTotalKeysToCtrl.MaxLength = 2;
            this.txtTotalKeysToCtrl.Name = "txtTotalKeysToCtrl";
            this.txtTotalKeysToCtrl.Size = new System.Drawing.Size(100, 20);
            this.txtTotalKeysToCtrl.TabIndex = 6;
            this.txtTotalKeysToCtrl.Text = "0";
            this.txtTotalKeysToCtrl.TextChanged += new System.EventHandler(this.txtTotalKeysToCtrl_TextChanged);
            this.txtTotalKeysToCtrl.Leave += new System.EventHandler(this.txtTotalKeysToCtrl_Leave);
            // 
            // txtPortOnInker
            // 
            this.txtPortOnInker.Location = new System.Drawing.Point(125, 57);
            this.txtPortOnInker.MaxLength = 5;
            this.txtPortOnInker.Name = "txtPortOnInker";
            this.txtPortOnInker.Size = new System.Drawing.Size(100, 20);
            this.txtPortOnInker.TabIndex = 5;
            this.txtPortOnInker.Text = "0";
            this.txtPortOnInker.TextChanged += new System.EventHandler(this.txtPortOnInker_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Start From Key";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Total Keys To control";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Port of Inker On SPU";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "SPU Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Select Inker:";
            this.label14.Visible = false;
            // 
            // cboInkerList
            // 
            this.cboInkerList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboInkerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboInkerList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboInkerList.FormattingEnabled = true;
            this.cboInkerList.Location = new System.Drawing.Point(14, 46);
            this.cboInkerList.Name = "cboInkerList";
            this.cboInkerList.Size = new System.Drawing.Size(157, 156);
            this.cboInkerList.TabIndex = 11;
            this.cboInkerList.Visible = false;
            this.cboInkerList.SelectedIndexChanged += new System.EventHandler(this.cboInkerList_SelectedIndexChanged);
            this.cboInkerList.TextChanged += new System.EventHandler(this.cboInkerList_TextChanged);
            // 
            // chkInverted
            // 
            this.chkInverted.AutoSize = true;
            this.chkInverted.Checked = true;
            this.chkInverted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInverted.Location = new System.Drawing.Point(189, 153);
            this.chkInverted.Name = "chkInverted";
            this.chkInverted.Size = new System.Drawing.Size(65, 17);
            this.chkInverted.TabIndex = 8;
            this.chkInverted.Text = "Inverted";
            this.chkInverted.UseVisualStyleBackColor = true;
            this.chkInverted.CheckedChanged += new System.EventHandler(this.chkInverted_CheckedChanged);
            // 
            // chkUpperInker
            // 
            this.chkUpperInker.AutoSize = true;
            this.chkUpperInker.Checked = true;
            this.chkUpperInker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpperInker.Location = new System.Drawing.Point(189, 92);
            this.chkUpperInker.Name = "chkUpperInker";
            this.chkUpperInker.Size = new System.Drawing.Size(82, 17);
            this.chkUpperInker.TabIndex = 1;
            this.chkUpperInker.Text = "Upper Inker";
            this.chkUpperInker.UseVisualStyleBackColor = true;
            this.chkUpperInker.CheckedChanged += new System.EventHandler(this.chkUpperInker_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.lblNFSType);
            this.groupBox2.Controls.Add(this.btnApplyAll);
            this.groupBox2.Controls.Add(this.txtLintableSize);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(315, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 181);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key Settings";
            this.groupBox2.Visible = false;
            // 
            // lblNFSType
            // 
            this.lblNFSType.AutoSize = true;
            this.lblNFSType.ForeColor = System.Drawing.Color.Lime;
            this.lblNFSType.Location = new System.Drawing.Point(15, 119);
            this.lblNFSType.Name = "lblNFSType";
            this.lblNFSType.Size = new System.Drawing.Size(58, 13);
            this.lblNFSType.TabIndex = 23;
            this.lblNFSType.Text = "NFS Type:";
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.ForeColor = System.Drawing.Color.Black;
            this.btnApplyAll.Location = new System.Drawing.Point(74, 142);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(75, 23);
            this.btnApplyAll.TabIndex = 0;
            this.btnApplyAll.Text = "Appl&y All";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            this.btnApplyAll.Click += new System.EventHandler(this.btnApplyAll_Click);
            // 
            // txtLintableSize
            // 
            this.txtLintableSize.Location = new System.Drawing.Point(484, 134);
            this.txtLintableSize.Name = "txtLintableSize";
            this.txtLintableSize.ReadOnly = true;
            this.txtLintableSize.Size = new System.Drawing.Size(100, 20);
            this.txtLintableSize.TabIndex = 22;
            this.txtLintableSize.Text = "150";
            this.txtLintableSize.TextChanged += new System.EventHandler(this.txtLintableSize_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Linear Table Size";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(320, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 28);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<< Ba&ck";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label6);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(595, 31);
            this.pnlWizardTitle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(198, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fountain Configurations";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(402, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Clo&se";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(483, 463);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Ne&xt >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // IndicateProgress
            // 
            this.IndicateProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IndicateProgress.Location = new System.Drawing.Point(18, 469);
            this.IndicateProgress.Name = "IndicateProgress";
            this.IndicateProgress.Size = new System.Drawing.Size(108, 14);
            this.IndicateProgress.TabIndex = 5;
            this.IndicateProgress.Visible = false;
            // 
            // stripPressConfig
            // 
            this.stripPressConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripPressConfig.AutoSize = false;
            this.stripPressConfig.Dock = System.Windows.Forms.DockStyle.None;
            this.stripPressConfig.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripPressConfig.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSetups,
            this.toolstripPressInfo,
            this.toolTurnBars,
            this.toolPressFeatures,
            this.toolbtnSweeps,
            this.toolbtnWaters,
            this.WaterInterface,
            this.toolStripRegister,
            this.toolStripGUIOptions,
            this.toolStripServerOptions,
            this.toolStripAutoScanCal,
            this.toolStripDataPathButton} );
            this.stripPressConfig.Location = new System.Drawing.Point(2, 16);
            this.stripPressConfig.Name = "stripPressConfig";
            this.stripPressConfig.Size = new System.Drawing.Size(616, 25);
            this.stripPressConfig.TabIndex = 38;
            this.stripPressConfig.Text = "toolstripPressCOnfig";
            // 
            // toolStripSetups
            // 
            this.toolStripSetups.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sPUInformationToolStripMenuItem,
            this.OCUSettingsToolStripMenuItem,
            this.fountainConfigurationWizardToolStripMenuItem,
            this.webConfigWizardMenuItem,
            this.nFSSettingsToolStripMenuItem,
            this.pressInterfaceFeaturesToolStripMenuItem,
            this.pressSiteSettingsToolStripMenuItem,
            this.autoZeroSettingsToolStripMenuItem});
            this.toolStripSetups.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSetups.ForeColor = System.Drawing.Color.Black;
            this.toolStripSetups.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSetups.Image")));
            this.toolStripSetups.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripSetups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSetups.Name = "toolStripSetups";
            this.toolStripSetups.Size = new System.Drawing.Size(104, 22);
            this.toolStripSetups.Text = "Press Settings";
            // 
            // sPUInformationToolStripMenuItem
            // 
            this.sPUInformationToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPUInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sPUInformationToolStripMenuItem.Image")));
            this.sPUInformationToolStripMenuItem.Name = "sPUInformationToolStripMenuItem";
            this.sPUInformationToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.sPUInformationToolStripMenuItem.Text = "SPU Information";
            this.sPUInformationToolStripMenuItem.Click += new System.EventHandler(this.sPUInformationToolStripMenuItem_Click);
            // 
            // OCUSettingsToolStripMenuItem
            // 
            this.OCUSettingsToolStripMenuItem.Name = "OCUSettingsToolStripMenuItem";
            this.OCUSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.OCUSettingsToolStripMenuItem.Text = "OCU Settings";
            this.OCUSettingsToolStripMenuItem.Click += new System.EventHandler(this.OCUSettingsToolStripMenuItem_Click);
            // 
            // fountainConfigurationWizardToolStripMenuItem
            // 
            this.fountainConfigurationWizardToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fountainConfigurationWizardToolStripMenuItem.Name = "fountainConfigurationWizardToolStripMenuItem";
            this.fountainConfigurationWizardToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.fountainConfigurationWizardToolStripMenuItem.Text = "Fountain Configuration Wizard...";
            this.fountainConfigurationWizardToolStripMenuItem.Click += new System.EventHandler(this.fountainConfigurationWizardToolStripMenuItem_Click);
            // 
            // webConfigWizardMenuItem
            // 
            this.webConfigWizardMenuItem.Name = "webConfigWizardMenuItem";
            this.webConfigWizardMenuItem.Size = new System.Drawing.Size(240, 22);
            this.webConfigWizardMenuItem.Text = "Web Configuration Wizard";
            this.webConfigWizardMenuItem.Click += new System.EventHandler(this.webConfigWizardMenuItem_Click);
            // 
            // nFSSettingsToolStripMenuItem
            // 
            this.nFSSettingsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFSSettingsToolStripMenuItem.Name = "nFSSettingsToolStripMenuItem";
            this.nFSSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.nFSSettingsToolStripMenuItem.Text = "Non Linear Fountain Scale Settings";
            this.nFSSettingsToolStripMenuItem.Visible = false;
            this.nFSSettingsToolStripMenuItem.Click += new System.EventHandler(this.nFSSettingsToolStripMenuItem_Click);
            // 
            // pressInterfaceFeaturesToolStripMenuItem
            // 
            this.pressInterfaceFeaturesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressInterfaceFeaturesToolStripMenuItem.Name = "pressInterfaceFeaturesToolStripMenuItem";
            this.pressInterfaceFeaturesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pressInterfaceFeaturesToolStripMenuItem.Text = "Press Interface Features";
            this.pressInterfaceFeaturesToolStripMenuItem.Visible = false;
            this.pressInterfaceFeaturesToolStripMenuItem.Click += new System.EventHandler(this.pressInterfaceFeaturesToolStripMenuItem_Click);
            // 
            // pressSiteSettingsToolStripMenuItem
            // 
            this.pressSiteSettingsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressSiteSettingsToolStripMenuItem.Name = "pressSiteSettingsToolStripMenuItem";
            this.pressSiteSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pressSiteSettingsToolStripMenuItem.Text = "Press Site Settings";
            this.pressSiteSettingsToolStripMenuItem.Click += new System.EventHandler(this.pressSiteSettingsToolStripMenuItem_Click);
            // 
            // autoZeroSettingsToolStripMenuItem
            // 
            this.autoZeroSettingsToolStripMenuItem.Name = "autoZeroSettingsToolStripMenuItem";
            this.autoZeroSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.autoZeroSettingsToolStripMenuItem.Text = "Auto Zero Settings";
            this.autoZeroSettingsToolStripMenuItem.Click += new System.EventHandler(this.autoZeroSettingsToolStripMenuItem_Click);
            // 
            // toolstripPressInfo
            // 
            this.toolstripPressInfo.BackColor = System.Drawing.Color.Transparent;
            this.toolstripPressInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripPressInfo.ForeColor = System.Drawing.Color.Black;
            this.toolstripPressInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPressInfo.Image")));
            this.toolstripPressInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPressInfo.Name = "toolstripPressInfo";
            this.toolstripPressInfo.Size = new System.Drawing.Size(80, 22);
            this.toolstripPressInfo.Text = "Press Info.";
            this.toolstripPressInfo.Visible = false;
            this.toolstripPressInfo.Click += new System.EventHandler(this.toolstripPressInfo_Click);
            // 
            // toolTurnBars
            // 
            this.toolTurnBars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTurnBars.ForeColor = System.Drawing.Color.Black;
            this.toolTurnBars.Image = ((System.Drawing.Image)(resources.GetObject("toolTurnBars.Image")));
            this.toolTurnBars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTurnBars.Name = "toolTurnBars";
            this.toolTurnBars.Size = new System.Drawing.Size(73, 22);
            this.toolTurnBars.Text = "Turn Bars";
            this.toolTurnBars.Click += new System.EventHandler(this.toolTurnBars_Click);
            // 
            // toolPressFeatures
            // 
            this.toolPressFeatures.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPressFeatures.ForeColor = System.Drawing.Color.Black;
            this.toolPressFeatures.Image = global::MCNWSiteGen.Properties.Resources.PressFeatures;
            this.toolPressFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPressFeatures.Name = "toolPressFeatures";
            this.toolPressFeatures.Size = new System.Drawing.Size(99, 22);
            this.toolPressFeatures.Text = "Press Features";
            this.toolPressFeatures.Visible = false;
            this.toolPressFeatures.Click += new System.EventHandler(this.pressInterfaceFeaturesToolStripMenuItem_Click);
            // 
            // toolbtnSweeps
            // 
            this.toolbtnSweeps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sweepInterfacesToolStripMenuItem});
            this.toolbtnSweeps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbtnSweeps.ForeColor = System.Drawing.Color.Black;
            this.toolbtnSweeps.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnSweeps.Image")));
            this.toolbtnSweeps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSweeps.Name = "toolbtnSweeps";
            this.toolbtnSweeps.Size = new System.Drawing.Size(102, 22);
            this.toolbtnSweeps.Text = "Press Sweeps";
            this.toolbtnSweeps.Click += new System.EventHandler(this.toolbtnSweeps_Click);
            // 
            // sweepInterfacesToolStripMenuItem
            // 
            this.sweepInterfacesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sweepInterfacesToolStripMenuItem.Name = "sweepInterfacesToolStripMenuItem";
            this.sweepInterfacesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sweepInterfacesToolStripMenuItem.Text = "Sweep Interfaces";
            this.sweepInterfacesToolStripMenuItem.Click += new System.EventHandler(this.sweepInterfacesToolStripMenuItem_Click);
            // 
            // toolbtnWaters
            // 
            this.toolbtnWaters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripcboWaters,
            this.autoTestToolStripMenuItem,
            this.sweepTestToolStripMenuItem});
            this.toolbtnWaters.Enabled = false;
            this.toolbtnWaters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbtnWaters.ForeColor = System.Drawing.Color.Black;
            this.toolbtnWaters.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnWaters.Image")));
            this.toolbtnWaters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnWaters.Name = "toolbtnWaters";
            this.toolbtnWaters.Size = new System.Drawing.Size(100, 22);
            this.toolbtnWaters.Text = "Press Waters";
            this.toolbtnWaters.Visible = false;
            // 
            // tStripcboWaters
            // 
            this.tStripcboWaters.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tStripcboWaters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tStripcboWaters.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tStripcboWaters.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripcboWaters.Items.AddRange(new object[] {
            "1. Water Motor",
            "2. Water Servo",
            "3. Miyakoshi Water",
            "4.  PLC",
            "5.  PCU ",
            "6.  GOSS MPU GATEWAY"});
            this.tStripcboWaters.Name = "tStripcboWaters";
            this.tStripcboWaters.Size = new System.Drawing.Size(121, 27);
            this.tStripcboWaters.SelectedIndexChanged += new System.EventHandler(this.tStripcboWaters_SelectedIndexChanged);
            this.tStripcboWaters.Click += new System.EventHandler(this.tStripcboWaters_Click);
            // 
            // autoTestToolStripMenuItem
            // 
            this.autoTestToolStripMenuItem.Name = "autoTestToolStripMenuItem";
            this.autoTestToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.autoTestToolStripMenuItem.Text = "Auto Test";
            this.autoTestToolStripMenuItem.Click += new System.EventHandler(this.autoTestToolStripMenuItem_Click);
            // 
            // sweepTestToolStripMenuItem
            // 
            this.sweepTestToolStripMenuItem.Name = "sweepTestToolStripMenuItem";
            this.sweepTestToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sweepTestToolStripMenuItem.Text = "Sweep Test";
            // 
            // toolStripRegister
            // 
            this.toolStripRegister.BackColor = System.Drawing.Color.Transparent;
            this.toolStripRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerInterfacetoolStripMenuItem});
            this.toolStripRegister.ForeColor = System.Drawing.Color.Black;
            this.toolStripRegister.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegister.Image")));
            this.toolStripRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegister.Name = "toolStripRegister";
            this.toolStripRegister.Size = new System.Drawing.Size(105, 20);
            this.toolStripRegister.Text = "Press Register";
            // 
            // registerInterfacetoolStripMenuItem
            // 
            this.registerInterfacetoolStripMenuItem.Name = "registerInterfacetoolStripMenuItem";
            this.registerInterfacetoolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registerInterfacetoolStripMenuItem.Text = "Register Interface";
            this.registerInterfacetoolStripMenuItem.Click += new System.EventHandler(this.registerInterfacesToolStripMenuItem_Click);
            // 
            // WaterInterface
            // 
            this.WaterInterface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripWaterInterface});
            this.WaterInterface.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterInterface.ForeColor = System.Drawing.Color.Black;
            this.WaterInterface.Image = global::MCNWSiteGen.Properties.Resources.dfrgres_dll_Ico17_ico_Ico1;
            this.WaterInterface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WaterInterface.Name = "WaterInterface";
            this.WaterInterface.Size = new System.Drawing.Size(95, 20);
            this.WaterInterface.Text = "Press Water";
            this.WaterInterface.Click += new System.EventHandler(this.WaterInterface_Click);
            // 
            // toolStripWaterInterface
            // 
            this.toolStripWaterInterface.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripWaterInterface.Name = "toolStripWaterInterface";
            this.toolStripWaterInterface.Size = new System.Drawing.Size(157, 22);
            this.toolStripWaterInterface.Text = "Water Interfaces";
            this.toolStripWaterInterface.Click += new System.EventHandler(this.toolStripWaterInterface_Click);
            // 
            // toolStripServerOptions
            // 
            this.toolStripServerOptions.ForeColor = System.Drawing.Color.Black;
            this.toolStripServerOptions.Image = global::MCNWSiteGen.Properties.Resources.ServerOptions;
            this.toolStripServerOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripServerOptions.Name = "toolStripServerOptions";
            this.toolStripServerOptions.Size = new System.Drawing.Size(99, 20);
            this.toolStripServerOptions.Text = "Server Options";
            this.toolStripServerOptions.ToolTipText = "Server Options";
            this.toolStripServerOptions.Click += new System.EventHandler(this.toolStripServerOptions_Click);
            // 
            // toolStripGUIOptions
            // 
            this.toolStripGUIOptions.ForeColor = System.Drawing.Color.Black;
            this.toolStripGUIOptions.Image = global::MCNWSiteGen.Properties.Resources.GUIOptions;
            this.toolStripGUIOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGUIOptions.Name = "toolStripGUIOptions";
            this.toolStripGUIOptions.Size = new System.Drawing.Size(85, 20);
            this.toolStripGUIOptions.Text = "GUI Options";
            this.toolStripGUIOptions.Click += new System.EventHandler( this.toolStripGUIOptions_Click );
            // 
            // toolStripAutoScanCal
            // 
            this.toolStripAutoScanCal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripAutoScanCal.ForeColor = System.Drawing.Color.Black;
            this.toolStripAutoScanCal.Image = global::MCNWSiteGen.Properties.Resources.AutoScanCal;
            this.toolStripAutoScanCal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAutoScanCal.Name = "toolStripAutoScanCal";
            this.toolStripAutoScanCal.Size = new System.Drawing.Size(102, 20);
            this.toolStripAutoScanCal.Text = "CIP3 Presetting";
            this.toolStripAutoScanCal.Click += new System.EventHandler(this.toolStripAutoScanCal_Click);
            // 
            // toolStripDataPathButton
            // 
            this.toolStripDataPathButton.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDataPathButton.ForeColor = System.Drawing.Color.Black;
            this.toolStripDataPathButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDataPathButton.Image")));
            this.toolStripDataPathButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDataPathButton.Name = "toolStripDataPathButton";
            this.toolStripDataPathButton.Size = new System.Drawing.Size(116, 20);
            this.toolStripDataPathButton.Text = "Data Path Storage";
            this.toolStripDataPathButton.Click += new System.EventHandler(this.toolStripDataPathButton_Click);
            // 
            // btnSiteInfo
            // 
            this.btnSiteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiteInfo.ForeColor = System.Drawing.Color.Black;
            this.btnSiteInfo.Location = new System.Drawing.Point(473, 567);
            this.btnSiteInfo.Name = "btnSiteInfo";
            this.btnSiteInfo.Size = new System.Drawing.Size(83, 55);
            this.btnSiteInfo.TabIndex = 4;
            this.btnSiteInfo.Text = "Site Information";
            this.btnSiteInfo.UseVisualStyleBackColor = true;
            this.btnSiteInfo.Visible = false;
            this.btnSiteInfo.Click += new System.EventHandler(this.btnSiteInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1036, 739);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MC3 Site Configuration Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.btnClose_Click);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gpCreateNew.ResumeLayout(false);
            this.ServerIPAddressGroupBox.ResumeLayout(false);
            this.ServerIPAddressGroupBox.PerformLayout();
            this.productOptions.ResumeLayout(false);
            this.productOptions.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gpLanguage.ResumeLayout(false);
            this.gpLanguage.PerformLayout();
            this.clcGroupBox.ResumeLayout(false);
            this.clcGroupBox.PerformLayout();
            this.gpSiteInformation.ResumeLayout(false);
            this.gpSiteInformation.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gpPressConfigurations.ResumeLayout(false);
            this.pnlFountainWizard.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.m_importPRSGroupBox.ResumeLayout(false);
            this.m_importPRSGroupBox.PerformLayout();
            this.m_commonSettingsGroupBox.ResumeLayout(false);
            this.m_commonSettingsGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpInkerConfigurations.ResumeLayout(false);
            this.gpInkerConfigurations.PerformLayout();
            this.gpBank2.ResumeLayout(false);
            this.gpBank2.PerformLayout();
            this.gpBank1.ResumeLayout(false);
            this.gpBank1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.stripPressConfig.ResumeLayout(false);
            this.stripPressConfig.PerformLayout();
            this.ResumeLayout(false);

        } 

        public bool NewFileOpen
        {
            set { m_bNewFileOpen = value; }
            get { return m_bNewFileOpen; }
        }

        public bool WidePressListView 
        {
            set { m_bSecondListView = value; }
            get { return m_bSecondListView; }
        }

        /// <summary>
        /// Gets/Sets wide press
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 06/30/2010 MT: 15955
        /// </History>
        public bool IsWidePress
        {
            set { isWidePressCheckBox.Checked = value; }
            get { return isWidePressCheckBox.Checked; }
        }
        
        //======================================================================================
        /// <Function>frmMain_Load</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Oct-15-2008</Date>
        /// <summary>
        /// frmMain Load
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 11/192008 MT: 11719
        /// Hema, SEP-02-2010, ENH 16257, Add Password to the Config view
        /// </History>
        ///=====================================================================================
        void frmMain_Load(object sender, System.EventArgs e)
        {
            LoadPressDetails();
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 1000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.btnClose, "Exit");
            SetTagInfoForPassword();
        }

        /// <![CDATA[
        /// Author: Hema Kumar   Oct-15-2008
        /// 
        /// History: 
        /// Hema Dt: 12-10-2008 MT: 12065
        /// LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// Hema Dt: 09/01/2009 MT: 13873
        /// Hema Dt: 10/12/2009 MT: 14520
        /// Hema Dt: 06/04/2010 MT: 15443
        /// Hema, SEP-02-2010, ENH 16257, to implement password
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
		///	05-MAY-11, LMask, MT17043: Write out the full language name
        /// 05-Mar-12, Mark C, MT 17637 - Update the ShowHelp check box details
        /// 20-Mar-12, BEttinger, MT 17624 - Update the Show2SidesThumbs check box details
        /// 23-Apr-13, Mark C, WI30347: Added a new menu item to configure Multi Web configuration when
        ///     press type is 'Dual / Multi Web press configuration'
        /// 01-MAY-13, Mark C, WI30684: Removed support for 'Show2Sides' feature. This option is no longer 
        ///     useful since Mercury Client has Summary View available for all press types.
        /// 10-Jun-13, Mark C, WI30950: Added support for product options - Jobs Management
        /// 23-Oct-13, Mark C, WI33030: Added support for product options - Keep Only Last Version of Profiles
        /// 27-May-14, Mark C, WI37511: Added support for product options - prompt for Zero All Inker needed on every restart of Server
        /// 28-Oct-14, Mark C, WI41821: Added support for Mercury Server configuration - IP Address and Port Number
        /// 23-Feb-16, Mark C, WI68970: Add support for Mercury Newspaper Navigation View option
        /// 09-Aug-16, Mark C, WI81328: Add support for label Towers with numbers option
        /// 07-July-20, Mark C, 200927: Correct display zones when total keys changes
        ///     
        /// ]]>
        /// <summary>
        /// Loads the Press Details to the GUI
        /// </summary>
        private void LoadPressDetails()
        {
            int iPressType = 0;
            MCPressInfo mcPressInfo = GetCurrentPress();
            if (mcPressInfo != null)
            {
                txtPressName.Text = mcPressInfo.PressName;
                txtPressWidth.Text = mcPressInfo.PressWidth.ToString();
                m_PressCurrentUnit = UnitTypes.UNIT_TYPE_CMS;
                iPressType = mcPressInfo.PressType;                    
                DisplayPressType(iPressType);
                checkBoxCMS.Checked = chkMM.Checked = true; // Hema 01/19/2009
                checkBoxMM.Checked = checkBoxInches.Checked = chkCms.Checked = chkInches.Checked = false;
                PressInformation_pressTypeChanged();
                //chkTurnBar.Checked = (mcPressInfo.PressType == 0) ? false : true;

                MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
                this.txtKeysPerfountain.Text = mcConsoleZones.NumberOfZones.ToString();
                this.tbDisplayZones.Text = GetCurrentPress().DisplayKeys.ToString();
                if (mcPressInfo.ClientInterface.WidePress)
                {
                    isWidePressCheckBox.Checked = true;
                }
                else
                {
                    isWidePressCheckBox.Checked = false;
                }

                if (mcPressInfo.ClientInterface.FunnyFountains)
                {
                    cbFunnyfountains.Checked = true;
                }
                else
                {
                    cbFunnyfountains.Checked = false;
                }
                if (mcPressInfo.ClientInterface.VirtualInkers)
                {
                    cbVirtualInkers.Checked = true;
                }
                else
                {
                    cbVirtualInkers.Checked = false;
                }
            }
            txtSiteName.Text = m_mcSiteConfigData.SiteName;
            txtSiteNumber.Text = m_mcSiteConfigData.SiteNumber.ToString();
            string strTemLanguage = mcPressInfo.PressClientInterface.CurrentLanguage;
            if (strTemLanguage.Equals(string.Empty))
            {
                cbLanguages.Text = DefineAndConst.Culture.English;
            }
            else
            {
                cbLanguages.Text = strTemLanguage;
            }
            // get the current runtime password
            string password = mcPressInfo.PressClientInterface.AdvUser;
            if (!string.IsNullOrEmpty(password))
            {
                this.tbRuntimePassword.Text = password;
            }
            // get the current Configuration password
            password = mcPressInfo.PressClientInterface.ConfigurationPassword;
            if (!string.IsNullOrEmpty(password))
            {
                this.tbConfigurationPassword.Text = password;
            }
            // get the current Diagnostic password
            password = mcPressInfo.PressClientInterface.DiagnosticPassword;
            if (!string.IsNullOrEmpty(password))
            {
                this.tbDiagnosticPassword.Text = password;
            }
            // get the current Exit password
            password = mcPressInfo.PressClientInterface.ExitPassword;
            if (!string.IsNullOrEmpty(password))
            {
                this.tbExitPassword.Text = password;
            }

            // update ShowHelp option
            this.checkBoxHelp.Checked = mcPressInfo.PressClientInterface.ShowHelp;
            // update Jobs Management options 
            this.jobManagementOption.Checked = m_mcSiteConfigData.ProductOptions.JobModeEnabled;
            this.checkBoxKeepLastVersion.Checked = m_mcSiteConfigData.ProductOptions.KeepOnlyLastVersionProfiles;
            this.m_promptZAI.Checked = m_mcSiteConfigData.ProductOptions.PromptZAINeededOnServerRestart;
            // update Newspaper Navigation View option
            this.m_newspaperNavigationViewOption.Checked = m_mcSiteConfigData.ProductOptions.NewspaperNavigationViewOption;
            // update Towers with numbers option
            this.m_labelTowersWithNumbersOption.Checked = m_mcSiteConfigData.ProductOptions.LabelTowersWithNumbersOption;

            // update Mercury Server configuration details
            this.MercuryServerIPAddressText.Text = m_mcSiteConfigData.ServerConfiguration.IPAddress;
            this.MercuryServerPortText.Text = m_mcSiteConfigData.ServerConfiguration.PortNumber.ToString();

            UpdatePressSettingsMenu();

            LoggedIn();
        }

        /// <![CDATA[
        /// Author: Hema Kumar
        /// 
        /// History: 08-Apr-2010, Hema Kumar, MT14169: Created
		///	Suresh, May-24-2009, ENH 15752
        /// Hema Dt: Oct/12/2010 MT:16162  Turkey support
        /// ]]>
        /// <summary>
        /// Get Language Name From Culture
        /// </summary>
        private string GetLanguageNameFromCulture(string LanguageCulture)
        {
            string strLanguage = DefineAndConst.Culture.English;
            LanguageCulture = LanguageCulture.ToUpper();
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                string cultureName = culture.ToString().ToUpper();
                // culture id from the site file is of 2 characters (Eg: JA for japan.
                // and normally culture id is of format "ja-JP", so check for the ja in the ja-JP
                if (cultureName.Contains(LanguageCulture))
                {
                    cultureName = culture.EnglishName;
                    strLanguage = RemoveNationNameFromCultureInfo(cultureName);
                    break;
                }
            }
            return strLanguage;
        }

        /// <![CDATA[
        /// Author: Hema Kumar
        /// 
        /// History: 08-Apr-2010, Hema Kumar, MT14169: Created
		///	Suresh, May-24-2009, ENH 15752
        /// Hema Dt: Oct/12/2010 MT:16162  Turkey support
        /// ]]>
        /// <summary>
        /// Get Language Name From Culture
        /// </summary>        
        private string GetCultureNameFromLanguage(string Language)
        {
            string strCulture = DefineAndConst.Culture.EnglishCultureName;
            Language = Language.ToUpper();
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            { 
                string cultureName = culture.EnglishName.ToUpper();
                // culture id from the site file is of 2 characters (Eg: JA for japan.
                // and normally culture id is of format "ja-JP", so check for the ja in the ja-JP
                if (cultureName.Contains(Language))
                {
                    // get only the starting 2 characters to store in the site file
                    cultureName = culture.ToString();
                    strCulture = cultureName.ToUpper();
                    break;
                }
            }
            return strCulture;
        }       

        //======================================================================================
        /// <Function>DisplayPressType</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Display Press Type
        /// </summary>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Changed press type from DUAL_WEB_PRESS to MULTI_WEB_PRESS
        ///     16-Dec-14, spa, WI 51029 Add support for Tower mode.
        ///     15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// </history>
        ///=====================================================================================
        private void DisplayPressType(int iPressType)
        {
            switch (iPressType)
            {
                case (int)enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;

                case (int)enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_WITH_TURNBAR;
                    break;

                case (int)enPressTypes.SHEET_FED_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SHEET_FED_PRESS;
                    break;

                case (int)enPressTypes.SINGLE_WEB_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_WEB_PRESS;
                    break;

                case (int)enPressTypes.MULTI_WEB_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.MULTI_WEB_PRESS;
                    break;

                case (int)enPressTypes.NEWSPAPER_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.NEWSPAPER_PRESS;
                    break;

                case (int)enPressTypes.TOWER_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.TOWER_PRESS_TYPE;
                    break;

                case (int)enPressTypes.SINGLE_SIDED_CIC_PRESS:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_SIDED_CIC_PRESS;
                    break;

                case (int)enPressTypes.UNKNOWN_PRESS_TYPE:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNKNOWN_PRESS_TYPE;
                    break;

                default:
                    comboBoxPressType.Text = MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;
            }
        }

        /// <summary>
        /// Presses the type_ selected index changed.
        /// </summary>
        /// <returns>
        ///     Return press type selected
        /// </returns>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Changed press type from DUAL_WEB_PRESS to MULTI_WEB_PRESS
        ///     16-Dec-14, spa, WI 51029 Add support for Tower mode.
        /// </history>
        private int PressType_SelectedIndexChanged()
        {
            string strComboBoxEntry = comboBoxPressType.SelectedItem.ToString();
            int iPressType = 0;
            switch (strComboBoxEntry)
            {
                case MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_NO_TURNBAR:
                    iPressType = (int)enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.UNITIZED_WEB_PRESS_WITH_TURNBAR:
                    iPressType = (int)enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SHEET_FED_PRESS:
                    iPressType = (int)enPressTypes.SHEET_FED_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_WEB_PRESS:
                    iPressType = (int)enPressTypes.SINGLE_WEB_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.MULTI_WEB_PRESS:
                    iPressType = (int)enPressTypes.MULTI_WEB_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.NEWSPAPER_PRESS:
                    iPressType = (int)enPressTypes.NEWSPAPER_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.TOWER_PRESS_TYPE:
                    iPressType = (int)enPressTypes.TOWER_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.SINGLE_SIDED_CIC_PRESS:
                    iPressType = (int)enPressTypes.SINGLE_SIDED_CIC_PRESS;
                    break;

                case MCNWSiteGen.DefineAndConst.StringConstant.UNKNOWN_PRESS_TYPE:
                    iPressType = (int)enPressTypes.UNKNOWN_PRESS_TYPE;
                    break;

            }
            return iPressType;
        }


        //======================================================================================
        /// <Function>PressInformation_pressTypeChanged</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// to change the press type
        /// </summary>
        /// <history>
        ///     23-Apr-13, Mark C, WI30347: Update status of the menu item 'Multi Web Configuration..' 
        /// </history>
        ///=====================================================================================
        void PressInformation_pressTypeChanged()
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress != null)
            {
                if (CurrentPress.PressType == 1)
                    toolTurnBars.Visible = true;
                else
                    toolTurnBars.Visible = false;
            }

            UpdatePressSettingsMenu();
        }

        ///=====================================================================================
        /// <Function>GetCurrentPress</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// to get the current press info
        /// </summary>
        /// 
        ///=====================================================================================
        public MCPressInfo GetCurrentPress()
        {
            return m_mcSiteConfigData.GetPressAt(m_iPressIdx);
        }
        ///=====================================================================================
        /// <Function>GetCurrentSystemPath</Function>
        /// <Author>Sreejit</Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// to get the current system file path
        /// </summary>
        /// 
        ///=====================================================================================

        public string GetCurrentSystemPath()
        {
            return m_mcPathConfigData.SystemPath;
        }
        ///=====================================================================================
        /// <Function>GetCurrentApplicationDataPath</Function>
        /// <Author>Sreejit</Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// to get the current job data path
        /// </summary>
        /// 
        ///=====================================================================================
        public string GetCurrentApplicationDataPath()
        {
            return m_mcPathConfigData.ApplicationData;
        }
        ///=====================================================================================
        /// <Function>GetCurrentLogPath</Function>
        /// <Author>Sreejit</Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// to get the current log file path
        /// </summary>
        /// 
        ///=====================================================================================
        public string GetCurrentLogPath()
        {
            return m_mcPathConfigData.LogPath;
        }
        ///=====================================================================================
        /// <Function>GetCurrentRuntimeConfigPath</Function>
        /// <Author>Sreejit</Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// to get the current runtime file path
        /// </summary>
        /// 
        ///=====================================================================================
        public string GetCurrentRuntimeConfigPath()
        {
            return m_mcPathConfigData.SystemRuntimeConfigPath;
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets the current Jobs path.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentJobsPath()
        {
            return m_mcPathConfigData.JobsPath;
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets the current Jobs Archive path.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentJobsArchivePath()
        {
            return m_mcPathConfigData.JobsArchivePath;
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets the current Form Template path.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentFormTemplatePath()
        {
            return m_mcPathConfigData.FormTemplatePath;
        }

        ///=====================================================================================
        /// <Function>GetClientConfigPath</Function>
        /// <Author>Sreejit</Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// to get the Client active options file path
        /// </summary>
        /// 
        ///=====================================================================================

        public string GetClientConfigPath()
        {
            return m_mcClientConfigData.ClientConfigPath;
        }

        /// <summary>
        /// Gets KBDLayouts path.
        /// </summary>
        /// <returns></returns>
        public string GetKBDLayoutsPath()
        {
           return m_mcClientConfigData.KBDLayoutFolder;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the log files path.
        /// </summary>
        /// <returns></returns>
        public string GetLogFilesPath()
        {
            return m_mcClientConfigData.LogFilesPath;
        }

        /// <summary>
        /// Gets the help path.
        /// </summary>
        /// <returns></returns>
        public string GetHelpPath()
        {
            return m_mcClientConfigData.HelpPath;
        }

        private void btnClose_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                exitMCNWSiteGen = true;
            }
            if (!this.exitMCNWSiteGen)
            {
                e.Cancel = true;
            }
        }

        #region Events
        //public static event CreateNewSiteFile createNewSiteFile;
        #endregion

        //======================================================================================
        /// <Function>LoggedIn</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Log in details
        /// </summary>
        /// 
        ///=====================================================================================
        private void LoggedIn()
        {
            //gpLogin.Enabled = false;
            //gpLogin.Visible = false;
            pnlSettings.Visible = true;
        }
        /*private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboUsers.Text == "USER")
            {
                if (txtPassword.Text == "user1234")
                {
                    //Logged IN.
                    m_strUSERLoggedIn = "Generic USER";
                    LoggedIn();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            else if (cboUsers.Text == "ADMIN")
            {
                if (txtPassword.Text == "admin127827")
                {
                    m_bAdminLoggedIN = true;
                    //Logged IN.
                    m_strUSERLoggedIn = "Administrator";
                    LoggedIn();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Select a USER");
            }
        }*/

        private void btnNew_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnOpen_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }

        //======================================================================================
        /// <Function>btnCloseNew_Click</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>Sep-15-2008</Date>
        /// <summary>
        /// close the configuration window
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11804
        /// Hema Dt: getting confermation to close the file
        /// </History>
        ///=====================================================================================
        private void btnCloseNew_Click(object sender, EventArgs e)
        {
            if ((GetCurrentPress().GetTotalSPUS() != 0) && (GetCurrentPress().TotalUnits != 0) && (GetCurrentPress().InkerList.Count != 0))
            {

                DialogResult Result;
                Result = MessageBox.Show("Do you want to save the Site configuration changes?", "Save", MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes)
                    btnSave_Click(sender, e);
                else if (Result == DialogResult.Cancel)
                    return;
            }
            closeTheConfiguration();
            m_iFountainWzrdState = (int)FountainWizardStates.Initial;
            SwitchFountainWzrdStates();                                 //close new, no to save
			if (Screen.PrimaryScreen.WorkingArea.Height < 910) //make the moved groups for small screen visible again
			{
				groupBox7.Visible = true;
				gpLanguage.Visible = true;
			}
            pnlFountainWizard.Visible = false;
            m_bFountainConfigured = true;
            btnBack.Enabled = false;
            btnSave.Enabled = true;
            stripPressConfig.Enabled = true;
            gpSiteInformation.Enabled = true;
            sweepConfiguration = waterConfiguration = -1;
            m_PressWidthInCM = 137.7f;                    
        }

        /// <![CDATA[
        /// <Function>closeTheConfiguration</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Oct-15-2008</Date>
        /// <History>
        /// Hema Dt: 10/12/2009 MT: 14520
        /// </History>
        /// ]]>
        /// <summary>
        /// while closing the configuration sets the default values
        /// Sreejit Dt: 30-July-10 ENH 16062 -MC3 AS - ALL data file paths should be configurable
        /// 11-Jan-17, Mark C, WI97682: clear the status of press data updated flag (m_bUpdatedPressData) 
        /// </summary>
        private void closeTheConfiguration()
        {
            gpCreateNew.Visible = false;
            m_bNewFileOpen = false;
            this.NewFileOpen = false;
            m_bFileOpenMode = false;
            m_bSPUConfigured = false;
            clearPressdata();
            activateSaveCancel(false);
            btnCancel_Click(null, null);
            cqIPAddressTextBox.Text = "";
            cqPortTextBox.Text = "";
            this.isCLCOEMCheckBox.Checked = false;   
            this.toolStripPathDropDownButton.Visible = true;
            this.toolStripPathSeparator.Visible = true;
            m_bCreate = false;
            m_bUpdatedPressData = false;
        }

        //======================================================================================
        /// <Function>clearPressdata</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>Nov-15-2008</Date>
        /// <summary>
        /// clears the Pressdata
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11801 
        /// </History>
        ///=====================================================================================
        private void clearPressdata()
        {
            m_mcSiteConfigData = new MCSiteConfigData();
        }

        private void btnSiteInfo_Click(object sender, EventArgs e)
        {
            SiteInfo siteInfo = new SiteInfo();
            siteInfo.StartPosition = FormStartPosition.CenterParent;
            siteInfo.SiteNumber = m_mcSiteConfigData.SiteNumber;
            siteInfo.SetSiteName = m_mcSiteConfigData.SiteName;
            siteInfo.ConfigVersion = m_mcSiteConfigData.SystemConfig;
            siteInfo.PressCount = m_mcSiteConfigData.PressCount();
            siteInfo.EnableDisableCtrls(m_bAdminLoggedIN);
            siteInfo.ShowDialog();

            m_mcSiteConfigData.SiteNumber = siteInfo.SiteNumber;
            m_mcSiteConfigData.SiteName = siteInfo.SetSiteName;
            m_mcSiteConfigData.SystemConfig = siteInfo.ConfigVersion;

            if (m_mcSiteConfigData.PressCount() < siteInfo.PressCount)
                while (m_mcSiteConfigData.PressCount() < siteInfo.PressCount)
                    m_mcSiteConfigData.AddPress();
            else
                while (m_mcSiteConfigData.PressCount() > siteInfo.PressCount)
                {
                    m_mcSiteConfigData.RemovePress();
                }

            siteInfo.Dispose();
        }

        private void btnWaterSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnFountainInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnInkerInfo_Click(object sender, EventArgs e)
        {
            pnlFountainWizard.Visible = true;
			if (Screen.PrimaryScreen.WorkingArea.Height < 910) //make the moved groups for small screen invisible while wizard
			{
				groupBox7.Visible = false;
				gpLanguage.Visible = false;
			}

        }

        public bool DuplicatInkerNameEntered(string strName)
        {
            int Count = 0;
            for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
            {
                string str = this.ListViewInkers.Items[iRow].SubItems[0].Control.Text;
                if (str.CompareTo(strName) == 0)
                    Count++;
            }
            return (Count > 1);
        }

        /// <![CDATA[
        /// 
        /// Function: DuplicatedSPUPortEntered
        ///
        /// Author: Someone
        /// 
        /// History: Hema Dt: 09/01/2009 MT: 13873
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         MarkC Oct 29, 2011 MT 17347 allow NA for SPU name duplicated
        /// 
        /// ]]>
        /// <summary>
        /// checks for Duplicated SPU Port Entered
        /// </summary>
        /// <param name="strNameSPU"></param>
        /// <param name="strSPUPort"></param>
        public bool DuplicatedSPUPortEntered(string strNameSPU, string strSPUPort)
        {
            int Count = 0;
            for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
            {
                if (m_bSecondListView)
                {
                    string strName = this.ListViewInkers.Items[iRow].SubItems[(int)WidePressListviewColumnHead.SPUName].Control.Text;
                    string strPort = this.ListViewInkers.Items[iRow].SubItems[(int)WidePressListviewColumnHead.SPUPortNumber].Control.Text;
                    if ((strName.CompareTo(strNameSPU) == 0) && (strPort.CompareTo(strSPUPort) == 0))
                    {
                        Count++;
                    }
                }
                else
                {
                    string strName = this.ListViewInkers.Items[iRow].SubItems[(int)ListviewColumnHead.SPUName].Control.Text;
                    string strPort = this.ListViewInkers.Items[iRow].SubItems[(int)ListviewColumnHead.SPUPortNumber].Control.Text;
                    if ((strName.CompareTo(strNameSPU) == 0) && (strPort.CompareTo(strSPUPort) == 0))
                    {
                        Count++;
                    }
                    if (this.ListViewInkers.Columns.Count > (int)ListviewColumnHead.SPUPortNumber + 1) //wide press
                    {
                        strName = this.ListViewInkers.Items[iRow].SubItems[(int)ListviewColumnHead.SPUName2].Control.Text;
                        strPort = this.ListViewInkers.Items[iRow].SubItems[(int)ListviewColumnHead.SPUPortNumber2].Control.Text;
                        if ((strName.CompareTo(strNameSPU) == 0) && (strPort.CompareTo(strSPUPort) == 0))
                        {
                            Count++;
                        }
                    }
                }
            }
            if (strNameSPU == "NA")  // MT17347 allowed for virtual fountains to be duplicated
            {
                Count = 1;
            }
            return (Count > 1);
        }

        /// <![CDATA[
        /// 
        /// Function: ValidateInkerListViewData
        ///
        /// Author: Someone
        /// 
        /// History: MarkC Oct 29, 2011 MT 17347 allow NA for SPU name
        /// 
        /// 
        /// ]]>
        /// <summary>
        /// Validates inker data in inker list
        /// </summary>
        public Point ValidateInkerListViewData()
        {
            Point ptProblemRow = new Point(-1, -1);     //used for record the cell (col and row) that has problem
            for (int iCol = 0; iCol < this.ListViewInkers.Columns.Count; iCol++)
            {
                switch ((ListviewColumnHead)iCol)
                {
                    case ListviewColumnHead.InkerName: //inker name
                        {
                            for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                            {
                                //validate the inker names - no duplicated name and length is OK
                                string str = this.ListViewInkers.Items[iRow].SubItems[iCol].Text;
                                if (str.Length > MCNWSiteGen.DefineAndConst.DataFieldLength.FOUNTAIN_NAME_LTH_LONG)
                                {
                                    ptProblemRow.X = iCol;
                                    ptProblemRow.Y = iRow;
                                    MessageBox.Show("Inker Name can not be longer than 16");
                                    break;
                                }
                                if (DuplicatInkerNameEntered(str))
                                {
                                    ptProblemRow.X = iCol;
                                    ptProblemRow.Y = iRow;
                                    MessageBox.Show("Inker Name must be unique");
                                    break;
                                }
                            }
                        }
                        break;
                    
                    case ListviewColumnHead.NumberOfKeys:
                        {
                            for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                            {
                                //validate the inker names - no duplicated name and length is OK
                                string str = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;
                                Regex regex = new Regex("^[0-9]*$");
                                if (!regex.IsMatch(str))
                                {
                                    ptProblemRow.X = iCol;
                                    ptProblemRow.Y = iRow;
                                    MessageBox.Show("The Range of Number of Inkers is: " + "1" +
                                        DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS.ToString());
                                    break; 
                                }
                                int iNumKeys = int.Parse(str);
                                if (iNumKeys > MCNWSiteGen.DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS)
                                {
                                    ptProblemRow.X = iCol;
                                    ptProblemRow.Y = iRow;
                                    MessageBox.Show("Number of Inkers can not be greater than" +
                                        DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS.ToString());
                                    break; 
                                }
                                //check make sure all non-inkers have SPU port configured
                                if (!IsWidePress)
                                {
                                    if (iNumKeys > 0)
                                    {
                                        string strName = this.ListViewInkers.Items[iRow].SubItems[(int)ListviewColumnHead.SPUName].Control.Text;
//                                        if (strName == "NA")  // MT17347 allowed for virtual fountains
//                                        {
//                                            ptProblemRow.X = (int)ListviewColumnHead.SPUName;
//                                            ptProblemRow.Y = iRow;
//                                            MessageBox.Show("Inker must be assigned to a SPU.");
//                                            break;
//                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case ListviewColumnHead.ServoTurns:
                        for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                        {
                            //validate the inker names - no duplicated name and length is OK
                            string str = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;
                            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                            if (!regex.IsMatch(str))
                            {
                                ptProblemRow.X = iCol;
                                ptProblemRow.Y = iRow;
                                MessageBox.Show("The Range of Key turns is: " + MCNWSiteGen.DefineAndConst.SystemCapacities.MIN_KEY_TURNS.ToString() + " - " +
                                    DefineAndConst.SystemCapacities.MAX_KEY_TURNS.ToString());
                                break;
                            }
                            float fValue = float.Parse(str);
                            if (fValue < MCNWSiteGen.DefineAndConst.SystemCapacities.MIN_KEY_TURNS ||
                                fValue > MCNWSiteGen.DefineAndConst.SystemCapacities.MAX_KEY_TURNS)
                            {
                                ptProblemRow.X = iCol;
                                ptProblemRow.Y = iRow;
                                MessageBox.Show("Key turns can not be greater than" +
                                    DefineAndConst.SystemCapacities.MAX_KEY_TURNS.ToString());
                                break; 
                            }
                        }
                        break;
                    case ListviewColumnHead.SPUPortNumber:
                        {
                            if (!IsWidePress)
                            {
                                //check to see if more than one inkers are to be assigned to the same port 
                                for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                                {
                                    string strName = this.ListViewInkers.Items[iRow].SubItems[iCol - 1].Control.Text;
                                    string strPort = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;

                                    string str = strName + " " + strPort;
                                    if (DuplicatedSPUPortEntered(strName, strPort))
                                    {
                                        ptProblemRow.X = iCol;
                                        ptProblemRow.Y = iRow;
                                        MessageBox.Show("More than one inkers have been assigned to the same SPU port");
                                        break; ;
                                    }
                                }
                            }
                        }
                        break;
                    case ListviewColumnHead.SPUPortNumber2: //inker name
                        {
                            if (!IsWidePress)
                            {
                                for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                                {
                                    string strName = this.ListViewInkers.Items[iRow].SubItems[iCol - 1].Control.Text;
                                    string strPort = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;

                                    string str = strName + " " + strPort;
                                    if (DuplicatedSPUPortEntered(strName, strPort))
                                    {
                                        ptProblemRow.X = iCol;
                                        ptProblemRow.Y = iRow;
                                        MessageBox.Show("More than one inkers have been assigned to the same SPU port");
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    default:
                           break;
                }
                if (ptProblemRow.X >= 0) 
                    break;
            }
            return ptProblemRow;
        }

        /// <![CDATA[
        /// 
        /// Function: SaveInkerRecords
        ///
        /// Author: Someone
        /// 
        /// History:    Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///             BEttinger, 14-JUN-12, MT17683: fixed indexing (to cover the case of odd inker count)
        ///             15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// to SaveInkerRecords
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        public void SaveInkerRecords(ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            int iTotalInkersNdx = 0;
           
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                    {
                        continue;
                    }
                    if (iTotalInkersNdx < ayInkerRecords.Count)
                    {
                        //INKER_DETAIL_RECORD recInker = (INKER_DETAIL_RECORD)ayInkerRecords[iUnit * mcUnit.TotalInkers + iInker];
                        INKER_DETAIL_RECORD recInker = (INKER_DETAIL_RECORD)ayInkerRecords[iTotalInkersNdx];
                        mcInker.InkerName = recInker.strName;
                        mcInker.UpperOrLower = recInker.bUpperInker;        //to do 
                        mcInker.Inverted = recInker.bInverted;
                        mcInker.TotalKeys = recInker.iNumOfKeys;
                        mcInker.KeyWidth = recInker.fKeyWidth;
                        mcInker.ServoTurns = recInker.strServoTurns;
                        mcInker.IsLeftSide = recInker.IsLeftSide;
                        if (!IsWidePress)
                        {
                            ((ServoBanks)mcInker.ServoBanks[0]).SPUName = recInker.strSPUName;
                            ((ServoBanks)mcInker.ServoBanks[0]).PortOnSPU = recInker.iSPUPortNum;
                        }
                        iTotalInkersNdx++;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect inker number");
                    }
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: btnCancel_Click
        ///
        /// Author: someone
        /// 
        /// History: Hema Dt: 09/01/2009 MT: 13873
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// Cancel button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_iFountainWzrdState == (int)FountainWizardStates.Third) //hq: last page "Finish" button
            {
                Point ptProblemRow;
                this.ListViewInkers.Refresh();
                if (iFirstView == 2)
                {
                    ptProblemRow = ValidateWidePressInkerListViewData();
                }
                else
                {
                    ptProblemRow = ValidateInkerListViewData();
                }
                if (ptProblemRow.X  >= 0)   //error occured
                {
                    //set the selection and return
                    ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Select();
                    ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Invalidate();
                    return;
                }
                ArrayList ayInkerRecords = new ArrayList();
                if (IsWidePress)
                {
                    if (iFirstView == 2)
                    {
                        GetDataFromSecondListView(ref ayInkerRecords);
                        SaveSecondListViewRecords(ayInkerRecords);                        
                    }
                    else
                    {
                        GetDataFromInkerListView(ref ayInkerRecords);
                        SaveInkerRecords(ayInkerRecords);
                    }
                }
                else
                {
                    GetDataFromInkerListView(ref ayInkerRecords);
                    SaveInkerRecords(ayInkerRecords);
                }
            }
            m_iFountainWzrdState = (int)FountainWizardStates.Initial;
            SwitchFountainWzrdStates();                                      //cancel button
            pnlFountainWizard.Visible = false;
			if (Screen.PrimaryScreen.WorkingArea.Height < 910) //make the moved groups for small screen visible again
			{
				groupBox7.Visible = true;
				gpLanguage.Visible = true;
			}
            m_bFountainConfigured = true;
            btnBack.Enabled = false;
            btnSave.Enabled = true;
            stripPressConfig.Enabled = true;
            gpSiteInformation.Enabled = true;
            m_bSecondListView = false;
            m_bFirstListView = true;
            iFirstView = 0;
        }
              
        /// <![CDATA[
        /// 
        /// Function: SaveSecondListViewRecords
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema Dt: 09/01/2009 MT: 13873
        ///          15-Apr-11, Mark C, MT16925:Set Key width
        ///          07-July-20, Mark C, 200927: Save changes to the start key and total keys
        /// 
        /// ]]>
        /// <summary>
        /// Save the wide press SecondListView Records
        /// </summary>
        /// <param name="ayInkerRecords">Iinkers list</param>        
        private void SaveSecondListViewRecords(ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            int iRecordCount = 0;
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (null == mcInker)
                        continue;
                    int iIndex = iUnit * (iInker - 1);
                    if ((iIndex + iInker) < ayInkerRecords.Count)
                    {
                        for (int iRail = 0; iRail < mcInker.ServoBanks.Count; iRail++)
                        {
                            if (iRecordCount < ayInkerRecords.Count)
                            {
                                WIDEPRESS_INKER_DETAIL_RECORD recInker = (WIDEPRESS_INKER_DETAIL_RECORD)ayInkerRecords[iRecordCount];
                                if (IsWidePress)
                                {
                                    ServoBanks servoBank = mcInker.ServoBanks[ iRail ] as ServoBanks;
                                    if( null != servoBank )
                                    {
                                        servoBank.SPUName = recInker.strRailSPUName;
                                        servoBank.PortOnSPU = recInker.iRailSPUPortNum;
                                        servoBank.BankInverted = recInker.bOpSide;
                                        servoBank.KeyWidth = recInker.fKeyWidth;
                                        servoBank.StartKey = recInker.iRailStartKey;
                                        servoBank.TotalKeys = recInker.iRailTotalKeys;
                                    }
                                }
                                iRecordCount++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect inker number");
                    }
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: btnNext_Click
        ///
        /// Author: someone
        /// 
        /// History: Hema Dt: 12/16/2008 MT: 12164 
        ///         Hema Dt: 09/01/2009 MT: 13873
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// btn Next Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MeaurementSelected())   //unit of measure setting test is OK
            {
                if (!IsWidePress)
                {
                    m_bFirstListView = true;
                    m_bSecondListView = false;
                }
                btnBack.Enabled = true;
                if ((!m_bSecondListView) || (m_iFountainWzrdState == 0))
                {
                    m_bFirstListView = true;
                    m_iFountainWzrdState++;
                }
                if (bValuesChanged())
                    m_bFileOpenMode = false; //Hema 01/20/2009
                SwitchFountainWzrdStates();                         //next button
                m_bFileOpenMode = true;
            }
            else
            {
                //unit of measure is NOT set
                MessageBox.Show("Please select any measurement unit");
            }
        }

        private bool MeaurementSelected()
        {
            bool status = false;
            if (chkMM.Checked || chkCms.Checked || chkInches.Checked)
            {
                status = true;
            }
            return status;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <History>Jan-19-2009 HQ- decouple the Keys per fountain with inker [0] 
        ///  Hema Dt: 09/01/2009 MT: 13873
        /// </History>
        private bool CheckChangeInUnitData()
        {
            bool bStatus = false;
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return true;
            //if ((Convert.ToInt32(txtFountainCount.Text) != CurrentPress.TotalUnits) || Convert.ToInt32(txtKeysPerfountain.Text) != mcCurrentInker.TotalKeys)
            if ((Convert.ToInt32(txtFountainCount.Text) != CurrentPress.InkerList.Count) || 
                Convert.ToInt32(txtKeysPerfountain.Text)!= GetCurrentPress ().GetMostCommonKeysPerFountain())
                bStatus = true;
            else
                bStatus = false;
            return bStatus;
        }

        //======================================================================================
        /// <Function>assignTheTotalKeysToControl</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Nov-21-2008</Date>
        /// <summary>
        /// assign The Total Keys To Control
        /// </summary>
        /// 
        ///=====================================================================================
        private void assignTheTotalKeysToControl()
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            int iTotalKeys = Convert.ToInt32(this.txtKeysPerfountain.Text);
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    mcInker.TotalKeys = iTotalKeys;
                    ServoBanks servoBank = mcInker.GetServoBankAt(0);
                    if ( servoBank.TotalKeys > iTotalKeys)
                        servoBank.TotalKeys = iTotalKeys;
                }
            }
        }        

        //======================================================================================
        /// <Function>SwitchFountainWzrdStates</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Fountain wizard state chages
        /// </summary>
        /// Hema Dt: 12/16/2008 MT: 12164 
        /// Hema Dt: 09/01/2009 MT: 13873
        /// 08-Dec-16, Mark C, WI83371: Add support to assign Port assignments 
        ///         by surface, if it is a Single Web press.        
        /// 
        ///=====================================================================================
        void SwitchFountainWzrdStates()
        {
            btnCancel.Enabled = false;

            switch (m_iFountainWzrdState)
            {
                case (int)FountainWizardStates.Initial:     //first settings view
                    lstPressType.Visible = true;
                    groupBox3.Visible = true;
                    IndicateProgress.Value = 0;
                    IndicateProgress.Visible = false;
                    btnNext.Enabled = true;
                    btnNext.Visible = true;
                    btnCancel.Visible = true;
                    btnCancel.Enabled= true;
                    btnCancel.Text = "Clo&se";

                    gpInkerConfigurations.Visible = false;
                    break;
                case (int)FountainWizardStates.Third:                     
                    if (m_bFirstListView)
                    {
                        ChangeListViewSettings();
                        if ((!IsWidePress) || (m_bSecondListView))
                        {
                            btnCancel.Enabled = true;
                            btnNext.Visible = false;
                            btnCancel.Visible = true;
                            btnCancel.Text = "&Finish";
                            btnSave.Enabled = true;
                        }
                        ArrayList ayInkers = new ArrayList();       //show the inker list grid
                        GenerateInkerRecords(ref ayInkers);
                        m_iFountainWzrdState = (int)FountainWizardStates.Third;
                        if (!m_bSecondListView)
                        {
                            m_bFirstListView = false;
                            m_bSecondListView = true;
                        }
                        iFirstView = 1;
                        if (IsWidePress)
                        {
                            btnSave.Enabled = false;
                        }
                    }
                    else
                    {                  

                        Point ptProblemRow;         //display inker grid and point to bad row.
                        {                            
                            this.ListViewInkers.Refresh();
                            ptProblemRow = ValidateInkerListViewData();                            
                        }
                        if (ptProblemRow.X >= 0)   //error occured
                        {
                            //set the selection and return
                            ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Select();
                            ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Invalidate();
                            return;
                        }
                        ArrayList ayInkers = new ArrayList();
                        GetDataFromInkerListView(ref ayInkers);
                        SaveInkerRecords(ayInkers);
                        btnCancel.Enabled = true;
                        btnNext.Visible = false;
                        btnCancel.Visible = true;
                        btnCancel.Text = "&Finish";
                        ayInkers.Clear();
                                         
                        GenerateWidePressInkerRecord(ref ayInkers);                        
                        ChangeListViewSettings();
                        ShowWidePressInkerListView(ayInkers);

                        iFirstView = 2;

                        btnSave.Enabled = true;
                    }
                    gpInkerConfigurations.Visible = true;
                    break;
                case (int)FountainWizardStates.Second:      // in between first view and inker view, 
                                                            // inker config is being created here
                    // genrate Unitized web for now.
                    lstPressType.Visible = false;
                    groupBox3.Visible = false;
                    IndicateProgress.Visible = true;
                    IndicateProgress.BringToFront();
                    //terminate this wizard here.
                    if (bValuesChanged() || (!m_bFileOpenMode))
                    {
                        GenerateFountainConfigurations();
                        UpdateInkerToSPUAndPortMap();
                    }
                    m_iFountainWzrdState++;
                    SwitchFountainWzrdStates();             //end of the Second state
                    break;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: GenerateWidePressInkerRecord
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema MT:13873  Dt: 09/01/09
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         15-Apr-11, Mark C, MT16925:Set key width to the servo banks
        /// ]]>
        /// <summary>
        /// Wide press inker record gerator
        /// </summary>
        /// <param name="ayInkers"></param>
        private void GenerateWidePressInkerRecord(ref ArrayList ayInkers)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            //generate an inker list
            string strRail1 = DefineAndConst.StringConstant.Rail1;
            string strRail2 = DefineAndConst.StringConstant.Rail2;
            string strTempRail = "";
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (null == mcInker)
                    {
                        continue;
                    }
                    if(IsWidePress)
                    {
                        for (int iRail = 0; iRail < mcInker.ServoBanks.Count; iRail++)
                        {
                            WIDEPRESS_INKER_DETAIL_RECORD recInker = new WIDEPRESS_INKER_DETAIL_RECORD();
                            if (iRail == 0)
                            {
                                strTempRail = string.Concat(mcInker.InkerName, strRail1);
                                recInker.strInkerRail = strTempRail;
                            }
                            else
                            {
                                strTempRail = string.Concat(mcInker.InkerName, strRail2);
                                recInker.strInkerRail = strTempRail;
                            }
                            ServoBanks servoBank = (ServoBanks)mcInker.ServoBanks[iRail];
                            if (null != servoBank)
                            {
                                //If funny fountains get the values from list view
                                if (cbFunnyfountains.Checked)
                                {
                                    int iKeys = mcInker.TotalKeys / 2;

                                    if (servoBank.StartKey != 1)
                                    {
                                        servoBank.TotalKeys = (mcInker.TotalKeys - iKeys);
                                        iKeys++;
                                        servoBank.StartKey = iKeys;
                                    }
                                    else
                                    {
                                        servoBank.TotalKeys = iKeys;
                                    }
                                }

                                servoBank.KeyWidth = mcInker.KeyWidth;

                                recInker.bOpSide = servoBank.BankInverted;
                                recInker.iRailStartKey = servoBank.StartKey;
                                recInker.iRailTotalKeys = servoBank.TotalKeys;
                                recInker.fKeyWidth = servoBank.KeyWidth;
                                recInker.strRailSPUName = servoBank.SPUName;
                                recInker.iRailSPUPortNum = servoBank.PortOnSPU;
                                ayInkers.Add(recInker);
                            }                            
                        }
                    }
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: GenerateInkerRecords
        ///
        /// Author: someone
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///          BEttinger, 14-JUN-12, MT17683 (fixed bUpperLower )
        ///          spa, 16-Dec-14, WI 51029 Add support for Tower mode.
        ///          27-May-15, Mark C, WI57901: In Tower press, update default Inker names with Inker names from PRS file 
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// to GenerateInkerRecords
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        public void GenerateInkerRecords(ref ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;

            int iTotalUnits = CurrentPress.TotalUnits;
            //generate an inker list
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    INKER_DETAIL_RECORD recInker = new INKER_DETAIL_RECORD();            
                    recInker.strName = mcInker.InkerName;
                    recInker.bUpperInker = ( mcInker.UpperOrLowerInker == ( int ) MCNWSiteGen.INKERTYPE.UPPER );
                    recInker.bInverted = mcInker.Inverted;
                    recInker.iNumOfKeys = mcInker.TotalKeys;
                    recInker.fKeyWidth = mcInker.KeyWidth;
                    recInker.strServoTurns = mcInker.ServoTurns;
                    recInker.strSPUName = ((ServoBanks)mcInker.ServoBanks[0]).SPUName;
                    recInker.iSPUPortNum = ((ServoBanks)mcInker.ServoBanks[0]).PortOnSPU;
                    recInker.IsLeftSide = mcInker.IsLeftSide;
                    ayInkerRecords.Add(recInker);
                }
            }
            //In Tower press, update default Inker names with Inker names from PRS file
            UpdateInkerNamesInTowePress( ayInkerRecords );            
            ShowInkerListView(ayInkerRecords);
            this.ListViewInkers.Refresh();
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-15, Mark C, WI57901: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the inker names in towe press.
        /// </summary>
        /// <param name="ayInkerRecords">The inker records.</param>
        private void UpdateInkerNamesInTowePress( ArrayList ayInkerRecords )
        {
            MCPressInfo currentPress = GetCurrentPress( );
            enPressTypes pressType = ( enPressTypes ) ( currentPress.PressType );         
            
            if ( ( enPressTypes.TOWER_PRESS == pressType ) && ( !m_bFileOpenMode ) )
            {
                List<ImpositionImport.CMCImpositionInker> inkerNamesList = currentPress.PRSData.WebData.GetAllImpositionInkers( );
                int inkerCount = ayInkerRecords.Count;
                for ( int inkerCounter = 0; inkerCounter < inkerCount; ++inkerCounter )
                {
                    if ( inkerCounter < inkerNamesList.Count )
                    {
                        INKER_DETAIL_RECORD inkerRecord = ( INKER_DETAIL_RECORD ) ( ayInkerRecords[ inkerCounter ] );
                        inkerRecord.strName = inkerNamesList[ inkerCounter ].InkerName;
                        ayInkerRecords[ inkerCounter ] = inkerRecord;
                    }
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: ShowWidePressInkerListView
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema MT:13873  Dt: 09/01/09
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         03-Apr-13, Mark C, WI30603: Changed to support more than 6 fountain ports / SPU
        ///         07-July-20, Mark C, 200927: Make Total Keys field editable
        ///             
        /// ]]>
        /// <summary>
        /// Wide Press Inker List View
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        public void ShowWidePressInkerListView(ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            this.ListViewInkers.Visible = false;
            this.ListViewInkers.Items.Clear();
            //figure out the size
            int iWid = 0;
            int iListViewInkersColumnsCount = this.ListViewInkers.Columns.Count;
            for (int iCol = 0; iCol < iListViewInkersColumnsCount; iCol++)
            {
                MC3Column aColumn = this.ListViewInkers.Columns[iCol] as MC3Column;
                iWid += aColumn.Width;
            }
            this.ListViewInkers.Width = iWid + 4;
            //populate the list view
            for (int iRecord = 0; iRecord < ayInkerRecords.Count; iRecord++)
            {
                WIDEPRESS_INKER_DETAIL_RECORD aRec = (WIDEPRESS_INKER_DETAIL_RECORD)ayInkerRecords[iRecord];
                string Name = aRec.strInkerRail;
                this.ListViewInkers.Items.Add(Name);
                //add 5 columns 
                for (int iCol = 0; iCol < iListViewInkersColumnsCount; iCol++)
                {
                    int iSel = -1;
                    switch (iCol)
                    {
                        case (int)WidePressListviewColumnHead.RailInkerName://inker rail name
                            TextBox txtName = new TextBox();
                            txtName.Text = Name;
                            txtName.Enabled = false;
                            this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = txtName;
                            break;
                        case (int)WidePressListviewColumnHead.KeyalignMent: // Op / Gear side
                            {
                                ComboBox cmb = new ComboBox();
                                cmb.Items.Add("OP Side");
                                cmb.Items.Add("Gear Side");
                                if (!aRec.bOpSide)
                                {
                                    cmb.SelectedIndex = 0;
                                }
                                else
                                {
                                    cmb.SelectedIndex = 1;
                                }
                                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = cmb;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.StartKey: //Start Key
                            {
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Text = aRec.iRailStartKey.ToString();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Enabled = false;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.TotalKeys: //Total keys
                            {
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Text = aRec.iRailTotalKeys.ToString();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Enabled = true;
                                this.ListViewInkers.Items[ iRecord ].SubItems[ iCol ].Control.Tag = aRec;
                                this.ListViewInkers.Items[ iRecord ].SubItems[ iCol ].Control.Leave += OnTotalKeysChanged;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.KeyWidth: //Key width
                            {
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Text = aRec.fKeyWidth.ToString();
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control.Enabled = false;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.SPUName:     //SPU Name
                            {
                                ComboBox cmb = new ComboBox();
                                for (int iSpu = 0; iSpu < CurrentPress.GetNumOfSPUs(); iSpu++)
                                {
                                    PressSPU aSPU = (PressSPU)CurrentPress.GetSPUAt(Convert.ToByte(iSpu));
                                    cmb.Items.Add(aSPU.SPUName);
                                    if (aSPU.SPUName.CompareTo(aRec.strRailSPUName) == 0)
                                    {
                                        iSel = iSpu;
                                    }
                                }
                                cmb.Items.Add("NA");
                                if (iSel >= 0)
                                {
                                    cmb.SelectedIndex = iSel;
                                }
                                else
                                {
                                    cmb.SelectedIndex = cmb.Items.Count - 1; //set to NA
                                }
                                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = cmb;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.SPUPortNumber:     //SPU port
                            {
                                ComboBox cmb = new ComboBox();
                                for (int iSpu = 1; iSpu <= GetCurrentPress().MaxFountainPortCountPerSPU; iSpu++)       //1 based in aRec
                                {
                                    cmb.Items.Add(iSpu.ToString());
                                    if (aRec.iRailSPUPortNum == iSpu)
                                    {
                                        iSel = iSpu - 1;
                                    }
                                }
                                if (iSel >= 0)
                                    cmb.SelectedIndex = iSel;
                                else
                                {
                                    MessageBox.Show("Invalid spu port number is detected");
                                    cmb.SelectedIndex = 0;
                                }
                                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                this.ListViewInkers.Items[iRecord].SubItems[iCol].Control = cmb;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            this.ListViewInkers.Refresh();
            this.ListViewInkers.Visible = true;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 07-July-20, Mark C, 200927: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [total keys changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTotalKeysChanged( object sender, EventArgs e )
        {
            TextBox textBox = sender as TextBox;
            if( null == textBox )
            {
                return;
            }

            // Validate input data - numeric value only
            if( !Regex.IsMatch( textBox.Text.Trim(), "^[0-9]+$" ) )
            {
                MessageBox.Show( "Invalid Total Keys. Please input valid data." );
                textBox.SelectAll();
                textBox.Focus();
                return;
            }

            WIDEPRESS_INKER_DETAIL_RECORD inkerDetailRecord = ( WIDEPRESS_INKER_DETAIL_RECORD )textBox.Tag;
            int inputTotalKeys = Convert.ToInt32( textBox.Text.Trim() );
            bool dataChanged = ( inkerDetailRecord.iRailTotalKeys != inputTotalKeys );
            if( !dataChanged )
            {
                return;
            }
            
            // Validate the total #of Keys
            if( ( inputTotalKeys < 1 ) || ( inputTotalKeys > DefineAndConst.SystemCapacities.MAX_SERVOS_PER_SPU_PORT ) )
            {
                MessageBox.Show( "Invalid Total Keys. Valid Range is 1 to 44." );
                textBox.SelectAll();
                textBox.Focus();
                return;
            }
                        
            // Get Inker associated with this change
            MCInker inker = GetInkerDetailsBySPU( inkerDetailRecord );
            if( null == inker )
            {
                return;
            }

            if( ( inker.TotalKeys - inputTotalKeys ) > DefineAndConst.SystemCapacities.MAX_SERVOS_PER_SPU_PORT )
            {
                MessageBox.Show( "Invalid input for Total Keys. Other Inker rail cannot have more than 44 Keys." );

                textBox.SelectAll();
                textBox.Focus();
                return;
            }

            bool firstRail = ( 1 == inkerDetailRecord.iRailStartKey );
            if( firstRail )
            {
                ServoBanks servoBank1 = ( ServoBanks )inker.ServoBanks[ 0 ];
                servoBank1.TotalKeys = inputTotalKeys;

                ServoBanks servoBank2 = ( ServoBanks )inker.ServoBanks[ 1 ];
                servoBank2.StartKey = ( inputTotalKeys + 1 );
                servoBank2.TotalKeys = ( inker.TotalKeys - inputTotalKeys );
            }
            else
            {
                ServoBanks servoBank2 = ( ServoBanks )inker.ServoBanks[ 1 ];
                servoBank2.TotalKeys = inputTotalKeys;

                ServoBanks servoBank1 = ( ServoBanks )inker.ServoBanks[ 0 ];
                servoBank1.TotalKeys = ( inker.TotalKeys - inputTotalKeys );

                servoBank2.StartKey = ( servoBank1.TotalKeys + 1 );
            }

            // Update List view 
            UpdateInkerListView( inker );
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 07-July-20, Mark C, 200927: Created
        /// 
        /// ]]>
        /// <summary>
        /// Gets the inker details by SPU.
        /// </summary>
        /// <param name="inkerDetailRecord">The inker detail record.</param>
        /// <returns></returns>
        private MCInker GetInkerDetailsBySPU( WIDEPRESS_INKER_DETAIL_RECORD inkerDetailRecord )
        {
            MCPressInfo press = GetCurrentPress();
            // for each Inker
            foreach( MCInker inker in press.InkerList )
            {
                // for each Servo bank ( rail )
                foreach( ServoBanks servoBank in inker.ServoBanks )
                {
                    if( ( inkerDetailRecord.strInkerRail.Contains( inker.InkerName ) ) &&
                        ( 0 == string.Compare( inkerDetailRecord.strRailSPUName, servoBank.SPUName, true ) ) &&
                        ( inkerDetailRecord.iRailSPUPortNum == servoBank.PortOnSPU ) )
                    {                        
                        return inker;
                    }
                }
            }

            return null;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 07-July-20, Mark C, 200927: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the inker ListView.
        /// </summary>
        /// <param name="inker">The inker.</param>
        private void UpdateInkerListView( MCInker inker )
        {
            foreach( GLItem item in ListViewInkers.Items )
            {
                string inkerRailName = item.SubItems[ ( int )WidePressListviewColumnHead.RailInkerName ].Control.Text.Trim();
                string SPUName = item.SubItems[ ( int )WidePressListviewColumnHead.SPUName ].Control.Text.Trim();
                int SPUPortNumber = Convert.ToInt32( item.SubItems[ ( int )WidePressListviewColumnHead.SPUPortNumber ].Control.Text.Trim() );

                foreach( ServoBanks servoBank in inker.ServoBanks )
                {
                    if( ( inkerRailName.Contains( inker.InkerName ) ) &&
                        ( 0 == string.Compare( SPUName, servoBank.SPUName, true ) ) &&
                        ( SPUPortNumber == servoBank.PortOnSPU ) )
                    {
                        item.SubItems[ ( int )WidePressListviewColumnHead.StartKey ].Control.Text = servoBank.StartKey.ToString();
                        item.SubItems[ ( int )WidePressListviewColumnHead.StartKey ].Control.Update();
                        item.SubItems[ ( int )WidePressListviewColumnHead.TotalKeys ].Control.Text = servoBank.TotalKeys.ToString();
                        item.SubItems[ ( int )WidePressListviewColumnHead.TotalKeys ].Control.Update();
                    }
                }       
            }            
        }

        /// <![CDATA[
        /// 
        /// Function: ChangeListViewSettings
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema MT:13873  Dt: 09/01/09
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 		11-Jan-17, Mark C, WI97682: Changed text from "Number of Keys" to "Servos on Fountain" 
        /// 		15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Changes ListView Settings
        /// </summary>
        private void ChangeListViewSettings()
        {
            if (null != ListViewInkers)
            {
                if (ListViewInkers.Columns.Count >= 1)
                {
                    ListViewInkers.Columns.Clear();
                }
            }
            this.ListViewInkers.AllowColumnResize = false;
            this.ListViewInkers.AllowMultiselect = false;
            this.ListViewInkers.AlternateBackground = System.Drawing.Color.WhiteSmoke;
            this.ListViewInkers.AlternatingColors = false;
            this.ListViewInkers.AutoHeight = false;
            this.ListViewInkers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListViewInkers.BackgroundStretchToFit = true;
            if (m_bSecondListView)
            {
                if (IsWidePress)
                {
                    NameColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    NameColumn.CheckBoxes = false;
                    NameColumn.ImageIndex = -1;
                    NameColumn.Name = "Rail";
                    NameColumn.NumericSort = false;
                    NameColumn.Text = "Rail";
                    NameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    NameColumn.Width = 100;
                    SurfaceColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    SurfaceColumn.CheckBoxes = false;
                    SurfaceColumn.ImageIndex = -1;
                    SurfaceColumn.Name = "KeyAlignment";
                    SurfaceColumn.NumericSort = false;
                    SurfaceColumn.Text = "Key Alignment";
                    SurfaceColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    SurfaceColumn.Width = 80;
                    InvertedColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    InvertedColumn.CheckBoxes = false;
                    InvertedColumn.ImageIndex = -1;
                    InvertedColumn.Name = "StartKey";
                    InvertedColumn.NumericSort = false;
                    InvertedColumn.Text = "Start Key";
                    InvertedColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    InvertedColumn.Width = 75;
                    KeysColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    KeysColumn.CheckBoxes = false;
                    KeysColumn.ImageIndex = -1;
                    KeysColumn.Name = "TotalKeys";
                    KeysColumn.NumericSort = false;
                    KeysColumn.Text = "Total Keys";
                    KeysColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    KeysColumn.Width = 75;                    
                    KeyWidthColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    KeyWidthColumn.CheckBoxes = false;
                    KeyWidthColumn.ImageIndex = -1;
                    KeyWidthColumn.Name = "Key Width";
                    KeyWidthColumn.NumericSort = false;
                    KeyWidthColumn.Text = "Key Width";
                    KeyWidthColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    KeyWidthColumn.Width = 75;
                    ServosColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    ServosColumn.CheckBoxes = false;
                    ServosColumn.ImageIndex = -1;
                    ServosColumn.Name = "SPUName";
                    ServosColumn.NumericSort = false;
                    ServosColumn.Text = "SPU #";
                    ServosColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    ServosColumn.Width = 75;
                    SPUNameColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    SPUNameColumn.CheckBoxes = false;
                    SPUNameColumn.ImageIndex = -1;
                    SPUNameColumn.Name = "SPUPort";
                    SPUNameColumn.NumericSort = false;
                    SPUNameColumn.Text = "SPU Port";
                    SPUNameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    SPUNameColumn.Width = 60;
                    this.ListViewInkers.Columns.AddRange( new MC3Components.Controls.MC3Column[] {
                    NameColumn,
                    SurfaceColumn,
                    InvertedColumn,
                    KeysColumn,
                    KeyWidthColumn,
                    ServosColumn,
                    SPUNameColumn} );
                }
            }
            else
            {
                NameColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                NameColumn.CheckBoxes = false;
                NameColumn.ImageIndex = -1;
                NameColumn.Name = "InkerName";
                NameColumn.NumericSort = false;
                NameColumn.Text = "Inker Name";
                NameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                NameColumn.Width = 100;
                
                InkerLeftToCICColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                InkerLeftToCICColumn.CheckBoxes = false;
                InkerLeftToCICColumn.ImageIndex = -1;
                InkerLeftToCICColumn.Name = "IsInkerLeftToCIC";
                InkerLeftToCICColumn.NumericSort = false;
                InkerLeftToCICColumn.Text = "Left Side?";
                InkerLeftToCICColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                InkerLeftToCICColumn.Width = 80;

                SurfaceColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                SurfaceColumn.CheckBoxes = false;
                SurfaceColumn.ImageIndex = -1;
                SurfaceColumn.Name = "InkerSide";
                SurfaceColumn.NumericSort = false;
                SurfaceColumn.Text = "Upper Inker?";
                SurfaceColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                SurfaceColumn.Width = 80;
                InvertedColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                InvertedColumn.CheckBoxes = false;
                InvertedColumn.ImageIndex = -1;
                InvertedColumn.Name = "Inverted";
                InvertedColumn.NumericSort = false;
                InvertedColumn.Text = "Inverted?";
                InvertedColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                InvertedColumn.Width = 75;
                KeysColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                KeysColumn.CheckBoxes = false;
                KeysColumn.ImageIndex = -1;
                KeysColumn.Name = "ServosOnFountain";
                KeysColumn.NumericSort = false;
                KeysColumn.Text = "Servos on Fountain";
                KeysColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                KeysColumn.Width = 75;
                KeyWidthColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                KeyWidthColumn.CheckBoxes = false;
                KeyWidthColumn.ImageIndex = -1;
                KeyWidthColumn.Name = "Key Width";
                KeyWidthColumn.NumericSort = false;
                KeyWidthColumn.Text = "Key Width";
                KeyWidthColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                KeyWidthColumn.Width = 75;
                ServosColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                ServosColumn.CheckBoxes = false;
                ServosColumn.ImageIndex = -1;
                ServosColumn.Name = "ServoTurns";
                ServosColumn.NumericSort = false;
                ServosColumn.Text = "Servo Turns";
                ServosColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                ServosColumn.Width = 75;
                if (!IsWidePress)
                {
                    SPUNameColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    SPUNameColumn.CheckBoxes = false;
                    SPUNameColumn.ImageIndex = -1;
                    SPUNameColumn.Name = "SPUName";
                    SPUNameColumn.NumericSort = false;
                    SPUNameColumn.Text = "SPU #";
                    SPUNameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    SPUNameColumn.Width = 75;
                    SPUPortColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
                    SPUPortColumn.CheckBoxes = false;
                    SPUPortColumn.ImageIndex = -1;
                    SPUPortColumn.Name = "SPUPort";
                    SPUPortColumn.NumericSort = false;
                    SPUPortColumn.Text = "SPU Port";
                    SPUPortColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                    SPUPortColumn.Width = 60;

                    if( GetCurrentPress().PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
                    {
                        this.ListViewInkers.Columns.AddRange( new MC3Components.Controls.MC3Column[] {
                        NameColumn,
                        InkerLeftToCICColumn,
                        InvertedColumn,
                        KeysColumn,
                        KeyWidthColumn,
                        ServosColumn,
                        SPUNameColumn,
                        SPUPortColumn} );
                    }
                    else
                    {
                        this.ListViewInkers.Columns.AddRange( new MC3Components.Controls.MC3Column[] {
                        NameColumn,
                        SurfaceColumn,
                        InvertedColumn,
                        KeysColumn,
                        KeyWidthColumn,
                        ServosColumn,
                        SPUNameColumn,
                        SPUPortColumn} );
                    }
                }
                else
                {
                    if( GetCurrentPress().PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
                    {
                        this.ListViewInkers.Columns.AddRange( new MC3Components.Controls.MC3Column[] {
                        NameColumn,
                        InkerLeftToCICColumn,                        
                        InvertedColumn,
                        KeysColumn,
                        KeyWidthColumn,
                        ServosColumn} );
                    }
                    else
                    {
                        this.ListViewInkers.Columns.AddRange( new MC3Components.Controls.MC3Column[] {
                        NameColumn,
                        SurfaceColumn,
                        InvertedColumn,
                        KeysColumn,
                        KeyWidthColumn,
                        ServosColumn} );
                    }
                }
            }
        }                   

        /// <![CDATA[
        /// 
        /// Function: ShowInkerListView
        ///
        /// Author: Huimin Qi
        /// 
        /// History: Hema MT:13873  Dt: 09/01/09
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         15-Apr-11, Mark C, MT16925: Allow user to update keys and width
        ///             MarkC Jul 22, 2011 - MT 17082 added tabindex update to track ftn index during key width test
        ///         03-Apr-13, Mark C, WI30603: Changed to support more than 6 fountain ports / SPU
        /// 		11-Jan-17, Mark C, WI97682: Allow editing #of Servos per Fountain only if Funny Fountains setting is selected
        ///         15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///         
        /// ]]>
        /// <summary>
        /// this function is called to populat listview using the data from internal buffer.
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        public void ShowInkerListView(ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            this.ListViewInkers.Visible = false;
            this.ListViewInkers.Items.Clear();

            //figure out the size
            int iWid = 0;
            int iTabIndex = 1;
            int iListViewInkersColumnsCount = this.ListViewInkers.Columns.Count;
            if (IsWidePress)
            {
                iListViewInkersColumnsCount = 6;
            }
            for (int iCol = 0; iCol < iListViewInkersColumnsCount; iCol++)
            {
                MC3Column aColumn = this.ListViewInkers.Columns[iCol] as MC3Column;
                iWid += aColumn.Width;
            }
            this.ListViewInkers.Width = iWid + 4;
            //populate the list view
            for (int i = 0; i < ayInkerRecords.Count; i++)
            {
                INKER_DETAIL_RECORD aRec = (INKER_DETAIL_RECORD)ayInkerRecords[i];
                string Name = aRec.strName;
                this.ListViewInkers.Items.Add(Name);
                //add 5 columns 
                for (int iCol = 0; iCol < iListViewInkersColumnsCount; iCol++)
                {
                    int iSel = -1;
                    switch (iCol)
                    {
                        case 0://inker name
                            {
                                this.ListViewInkers.Items[i].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Text = Name;
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                                break;
                            }
                        case 1: //upper/lower
                            {
                                if( CurrentPress.PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
                                {
                                    ComboBox cmb = new ComboBox();
                                    cmb.Items.Add( "Yes" );
                                    cmb.Items.Add( "No" );

                                    if( aRec.IsLeftSide )
                                        cmb.SelectedIndex = 0;
                                    else
                                        cmb.SelectedIndex = 1;

                                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control = cmb;
                                    this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control.TabIndex = ++iTabIndex;
                                }
                                else
                                {
                                    ComboBox cmb = new ComboBox();
                                    cmb.Items.Add( "Yes" );
                                    cmb.Items.Add( "No" );
                                    if( aRec.bUpperInker )
                                        cmb.SelectedIndex = 0;
                                    else
                                        cmb.SelectedIndex = 1;

                                    if( ( CurrentPress.PressType == ( int )enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR ) ||
                                        ( CurrentPress.PressType == ( int )enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR ) )
                                    {
                                        cmb.SelectedIndex = 0;
                                        cmb.Enabled = false;
                                    }
                                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control = cmb;
                                    this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control.TabIndex = ++iTabIndex;
                                }
                            }
                            break;
                        case 2: //inverted
                            {
                                ComboBox cmb = new ComboBox();
                                cmb.Items.Add("Yes");
                                cmb.Items.Add("No");
                                if (aRec.bInverted)
                                    cmb.SelectedIndex = 0;
                                else
                                    cmb.SelectedIndex = 1;
                                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                this.ListViewInkers.Items[i].SubItems[iCol].Control = cmb;
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                            }
                            break;
                        case 3: //number of keys
                            {
                                this.ListViewInkers.Items[i].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Text = aRec.iNumOfKeys.ToString();
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Leave += new EventHandler(ValidateNumberOfKeysFromListView);
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Enabled = cbFunnyfountains.Checked;
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                            }
                            break;

                        case 4: //key width
                            {
                                this.ListViewInkers.Items[i].SubItems[iCol].Control = new TextBox();
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Text = aRec.fKeyWidth.ToString();
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Leave += new EventHandler(ValidateKeyWidthFromListView);
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.Enabled = true;
                                this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                            }
                            break;

                        case 5:     //Turns
                            this.ListViewInkers.Items[i].SubItems[iCol].Control = new TextBox();
                            this.ListViewInkers.Items[i].SubItems[iCol].Control.Text = aRec.strServoTurns;
                            this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                            break;

                        case 6:     //SPU Num
                            {
                                if (!IsWidePress)
                                {
                                    ComboBox cmb = new ComboBox();
                                    for (int iSpu = 0; iSpu < CurrentPress.GetNumOfSPUs(); iSpu++)
                                    {
                                        PressSPU aSPU = (PressSPU)CurrentPress.GetSPUAt(Convert.ToByte(iSpu));
                                        cmb.Items.Add(aSPU.SPUName);
                                        if (aSPU.SPUName.CompareTo(aRec.strSPUName) == 0)
                                            iSel = iSpu;
                                    }
                                    cmb.Items.Add("NA");
                                    if (iSel >= 0)
                                        cmb.SelectedIndex = iSel;
                                    else
                                    {
                                        cmb.SelectedIndex = cmb.Items.Count - 1; //set to NA
                                    }
                                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control = cmb;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                                }
                            }
                            break;
                        case 7:     //SPU port
                            {
                                if (!IsWidePress)
                                {
                                    ComboBox cmb = new ComboBox();
                                    for (int iSpu = 1; iSpu <= GetCurrentPress().MaxFountainPortCountPerSPU; iSpu++)       //1 based in aRec
                                    {
                                        cmb.Items.Add(iSpu.ToString());
                                        if (aRec.iSPUPortNum == iSpu)
                                            iSel = iSpu - 1;
                                    }
                                    if (iSel >= 0)
                                        cmb.SelectedIndex = iSel;
                                    else
                                    {
                                        MessageBox.Show("Invalid spu port number is detected");
                                        cmb.SelectedIndex = 0;
                                    }
                                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control = cmb;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                                }
                            }
                            break;
                        case 8:     //SPU Num
                            {
                                if (!IsWidePress)
                                {
                                    ComboBox cmb = new ComboBox();
                                    for (int iSpu = 0; iSpu < CurrentPress.GetNumOfSPUs(); iSpu++)
                                    {
                                        PressSPU aSPU = (PressSPU)CurrentPress.GetSPUAt(Convert.ToByte(iSpu));
                                        cmb.Items.Add(aSPU.SPUName);
                                        if (aSPU.SPUName.CompareTo(aRec.strSPUName) == 0)
                                            iSel = iSpu;
                                    }
                                    if (iSel >= 0)
                                        cmb.SelectedIndex = iSel;
                                    else
                                    {
                                        cmb.SelectedIndex = cmb.Items.Count - 1; //set to NA
                                    }
                                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control = cmb;
                                    this.ListViewInkers.Items[i].SubItems[iCol].Control.TabIndex = ++iTabIndex;
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            this.ListViewInkers.Visible = true;

            if (cbFunnyfountains.Checked)
            {
                if (null != CurrentPress.OCUInterface)
                {
                    txtKeysPerfountain.Text = CurrentPress.OCUInterface.NumberOfZones.ToString();
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: ValidateNumberOfKeysFromListView
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///             MarkC Jul 22, 2011 - MT 17082 allow up to +/-8 keys from the number of zones.
        /// ]]>
        /// <summary>
        /// to validate the no.of keys from the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValidateNumberOfKeysFromListView(object sender, EventArgs e)
        {
            TextBox tbKeys = (TextBox)sender;
            int iKeys = int.Parse(tbKeys.Text);

            //Take OCU zones as base
            MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
            int iBaseKeys = mcConsoleZones.NumberOfZones;
           
            if (iKeys < (iBaseKeys - FountainLimits.FF_MAX_DIFF_KEYS ) ||         // validate fountain key count with console zone count
                iKeys > (iBaseKeys + FountainLimits.FF_MAX_DIFF_KEYS))
            {
                MessageBox.Show("Please enter the number between " + (iBaseKeys - FountainLimits.FF_MAX_DIFF_KEYS) +
                    " - " + (iBaseKeys + FountainLimits.FF_MAX_DIFF_KEYS));
                tbKeys.Text = iBaseKeys.ToString();
                tbKeys.Focus();
            }
        }

        /// <![CDATA[
        /// 
        /// Function: ValidateKeyWidthFromListView
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///          15-Apr-11, Mark C, MT16925:Validate Key width only for Funny Fountains
        ///             MarkC Jul 22, 2011 - MT 17082 allow up to 10 inches of fountain width difference from console width
        /// ]]>
        /// <summary>
        /// to validate the key width from the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValidateKeyWidthFromListView(object sender, EventArgs e)
        {
            TextBox tbKeyWidth = (TextBox)sender;
            float fKeyWidth = float.Parse(tbKeyWidth.Text);

            int iTabIndex;      // use the tabindex to determine which fountain is being validated
            if (GetCurrentPress().MCClientInterface.WidePress)
            {
                iTabIndex = tbKeyWidth.TabIndex / 6;   //assumes ftn config table is 6 columns for wide press
            }
            else
            {
                iTabIndex = tbKeyWidth.TabIndex / 8;   //assumes ftn config table is 8 columns wide normally
            }
            int fNumberKeys = int.Parse(this.ListViewInkers.Items[iTabIndex].SubItems[3].Control.Text);
            bool bWidthOK = true;
            float fMinKeyWidth = 0.0f;
            float fMaxKeyWidth = 0.0f;

            //Take OCU zone width as base
            MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
            float fBaseKeyWidth = ( mcConsoleZones.ZoneWidth * (float)UnitConverters.fCmsToInch );  // inches
            if (fBaseKeyWidth < (float)FountainLimits.MIN_KEY_WIDTH)
                fBaseKeyWidth = (float)FountainLimits.MIN_KEY_WIDTH;       //test against min key width
            if (fBaseKeyWidth > (float)FountainLimits.MAX_KEY_WIDTH)
                fBaseKeyWidth = (float)FountainLimits.MAX_KEY_WIDTH;       //test against max key width
            float fBaseConsoleWidth = fBaseKeyWidth * mcConsoleZones.NumberOfZones;                 // console width inches
            float fFtnWidth = (fKeyWidth * (float)UnitConverters.fMMToInch) * (float)fNumberKeys;   //proposed ftn width inches
            fMinKeyWidth = (fBaseConsoleWidth - (float)FountainLimits.FF_MAX_DIFF_FTN_WIDTH) / (float)fNumberKeys;    // min key width in inches
            fMaxKeyWidth = (fBaseConsoleWidth + (float)FountainLimits.FF_MAX_DIFF_FTN_WIDTH) / (float)fNumberKeys;    // max key width in inches
            if (Math.Abs(fFtnWidth - fBaseConsoleWidth) > (float)FountainLimits.FF_MAX_DIFF_FTN_WIDTH)   // test if new ftn total width under or over console width +/- 10 inches
                bWidthOK = false;       // too big or small?
            if (fMinKeyWidth < (float)FountainLimits.MIN_KEY_WIDTH)
                fMinKeyWidth = (float)FountainLimits.MIN_KEY_WIDTH;       //test against min key width
            if (fMaxKeyWidth > (float)FountainLimits.MAX_KEY_WIDTH)
                fMaxKeyWidth = (float)FountainLimits.MAX_KEY_WIDTH;       //test against max key width
            if ((fKeyWidth * (float)UnitConverters.fMMToInch) < (float)FountainLimits.MIN_KEY_WIDTH)
                bWidthOK = false;       // too big or small?
            if ((fKeyWidth * (float)UnitConverters.fMMToInch) > (float)FountainLimits.MAX_KEY_WIDTH)
                bWidthOK = false;       // too big or small?
            //Validate only when the Press is configured for funny fountains
            if (GetCurrentPress().MCClientInterface.FunnyFountains)
            {
                //double check with the Funny Fountain design for these validations
                if (!bWidthOK)   //width is too small or too large
                {                // display key width range in mm
                    MessageBox.Show("Please enter the number between " + (float)(fMinKeyWidth * (float)UnitConverters.fInchToMM) +
                        " - " + (float)(fMaxKeyWidth * (float)UnitConverters.fInchToMM));
                    fBaseKeyWidth *= (float)UnitConverters.fInchToMM;
                    tbKeyWidth.Text = fBaseKeyWidth.ToString();
                    tbKeyWidth.Focus();
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: GetDataFromInkerListView
        ///
        /// Author: someone
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///             MarkC Oct 29, 2011 MT 17347 allow NA for SPU name
        ///         15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// to getDataFromInkerListView
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        public void GetDataFromInkerListView(ref ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            for (int i = 0; i < ListViewInkers.Items.Count; i++)
            {
                INKER_DETAIL_RECORD aRec = new INKER_DETAIL_RECORD();
                for (int iCol = 0; iCol < this.ListViewInkers.Columns.Count; iCol++)
                {
                    switch (iCol)
                    {
                        case 0://inker name
                            aRec.strName = this.ListViewInkers.Items[i].SubItems[iCol].Control.Text;
                            break;
                        case 1: //upper/lower
                            {
                                if( CurrentPress.PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
                                {
                                    ComboBox cmb = this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control as ComboBox;
                                    aRec.IsLeftSide = ( cmb.SelectedIndex == 0 ) ? true : false;
                                }
                                else
                                {
                                    ComboBox cmb = this.ListViewInkers.Items[ i ].SubItems[ iCol ].Control as ComboBox;
                                    aRec.bUpperInker = ( cmb.SelectedIndex == 0 ) ? true : false;
                                }
                            }
                            break;
                        case 2: //inverted
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.bInverted = (cmb.SelectedIndex == 0) ? true : false;
                            }
                            break;
                        case 3: //number of keys
                            {
                                aRec.iNumOfKeys = int.Parse(this.ListViewInkers.Items[i].SubItems[iCol].Control.Text);
                            }
                            break;
                        case 4: //key width
                            {
                                aRec.fKeyWidth = float.Parse(this.ListViewInkers.Items[i].SubItems[iCol].Control.Text);
                            }
                            break;
                        case 5:     //Turns
                            aRec.strServoTurns = this.ListViewInkers.Items[i].SubItems[iCol].Control.Text;
                            break;
                        case 6:     //SPU Num
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.strSPUName = cmb.Text;
//                                if (aRec.strSPUName == "NA")   // MT17347
//                                    aRec.strSPUName = "";
                            }
                            break;
                        case 7:     //SPU port
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.iSPUPortNum = int.Parse(cmb.Text);
                            }
                            break;
                        case 8:     //SPU Num to do for wide press
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.strSPUName = cmb.Text;
//                                if (aRec.strSPUName == "NA")   // MT17347
//                                    aRec.strSPUName = "";
                            }
                            break;

                        default:
                            break;
                    }
                }
                ayInkerRecords.Add(aRec);
            }
        }

        //======================================================================================
        /// <Function>GenerateInkerDetails</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Inker details generator
        /// </summary>
        /// 
        ///=====================================================================================
        public void GenerateInkerDetails()
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            cboInkerList.Items.Clear();
            cboSPU.Items.Clear();
            int iTotalSPUs = GetCurrentPress().GetTotalSPUS();
            for (int iSPU = 0; iSPU < iTotalSPUs; iSPU++)
            {
                PressSPU pressSPU = GetCurrentPress().SPU(iSPU);
                if (pressSPU == null)
                    continue; cboSPU.Items.Add(pressSPU.SPUName);

            }
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    cboInkerList.Items.Add(mcInker.InkerName);
                }
            }
            GenerateLinTableSizes();
        }

        //======================================================================================
        /// <Function>GenerateLinTableSizes</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Lin table sizes gerator
        /// </summary>
        /// 
        ///=====================================================================================
        public void GenerateLinTableSizes()
        {
            switch (GetCurrentPress().MCClientInterface.NonLinear)
            {
                case 0:
                    lblNFSType.Text = "No NFS";
                    txtLintableSize.Text = "100";
                    break;

                case 1:
                    lblNFSType.Text = "NFS Type1";
                    txtLintableSize.Text = "200";
                    break;

                case 49:
                    lblNFSType.Text = "NFS Type2";
                    txtLintableSize.Text = "250";
                    break;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: GenerateFountainConfigurations
        ///
        /// Author: Chetan
        /// 
        ///     purpose: confirm the number of fountains and keys will fit on the number of SPUs and ports available.
        ///     update the new fountain/unit data if more was added in the first view.
        ///     
        /// History: Hema Dt: 01/22/2009 MT: 12264 to split up inkers evenly between SPUs  
        ///         Hema Dt: 05/27/2009 MT: 13380
        ///         Hema MT: 13873  Dt: 09/01/09   
        ///         Hema Dt: 11/13/2009 MT: 14770
        ///         Hema Dt: 04-03-2010 MT: 15342
        ///         Suresh, 28-May-2010, MT: 15798
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         15-Apr-11, Mark C, MT16925:Removed updating Zone width for OCU3
        ///         14-JUN-12, BEttinger, MT17683: change code for calculation inkers per unit
        ///         23-Apr-13, Mark C, WI30347: Added support for Multi web press type
        ///         16-Dec-14, spa, WI 51029 Added support for Tower mode.
        ///         27-May-15, Mark C, WI57901: Update the data member 'UpperOrLowerInker' of MCInker class
        ///         15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///         29-May-19, Mark C, WI115419: Add support to retain the Inker configuration when SPUs are added/deleted
        ///         21-Jul-20, Mark C, 200927: Do NOT reset the Key Alignment value when total key count changes
        /// ]]>
        /// <summary>
        /// to GenerateFountainConfigurations
        /// </summary>
        void GenerateFountainConfigurations()
        {
            string strPrevSpu = "";
            IndicateProgress.Visible = true;
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;

            int totalInkers = Convert.ToInt16(txtFountainCount.Text);   //fountain count from first view
            if (totalInkers < 0)
                return;
            int iTotalUnits;
            iTotalUnits = totalInkers;      //this is correct if unitized press or CIC
            if ( (CurrentPress.PressType == (int)enPressTypes.SINGLE_WEB_PRESS) ||
                 (CurrentPress.PressType == (int)enPressTypes.MULTI_WEB_PRESS) ||
                 (CurrentPress.PressType == (int)enPressTypes.TOWER_PRESS) )
            {
                iTotalUnits = totalInkers / 2;
                if (totalInkers % 2 != 0)
                {
                    iTotalUnits++;
                }
            }

            int iTotalKeysPerFountain = int.Parse(txtKeysPerfountain.Text);     //key count from first view
            float fKeyWidth = float.Parse(txtKeyWidth.Text);    //key width from first view
            txtKeyWidth.Text = fKeyWidth.ToString();            //refresh from conversion
            fKeyWidth = float.Parse(txtKeyWidth.Text);          //convert key width again
            if (m_CurrentUnit != UnitTypes.UNIT_TYPE_MM)        //calc are using mm for widths
            {
                float fTemp = UnitConversions(fKeyWidth, m_CurrentUnit, UnitTypes.UNIT_TYPE_MM);
                fKeyWidth = fTemp;
            }

            CurrentPress.TotalUnits = iTotalUnits;              //update the press config Total units
            CurrentPress.AutoTest.TotalUnitsToTest = iTotalUnits;   //update the AutoTest total
            CurrentPress.GenerateUnits();               //<<<<<<<<<<<<< create list m_ayPressUnits[]
            int availableInkers = totalInkers;
            int iAvailableSpu = GetCurrentPress().GetTotalSPUS();   //get number of SPU from press
            int iTotalSpus = iAvailableSpu;
            int iPercentComplete = 0;                       //reset the accumulators
            int iPortOnSPU = 0, iTemp = 0, iSpu = 0;
            int inkerCount = 0;

            // Copy all Inkers data to an Array 
            Array tempInkers = Array.CreateInstance( typeof( MCInker ), CurrentPress.InkerList.Count );            
            CurrentPress.InkerList.CopyTo( tempInkers );          
            // Clear press Inkers list
            CurrentPress.InkerList.Clear();         

            int iRail1TotalKeys = iTotalKeysPerFountain / 2;
            int iRail2TotalKeys = iRail1TotalKeys;
            int iRail2StartKey = iRail1TotalKeys + 1;
            if (IsWidePress)
            {
                if (iTotalKeysPerFountain % 2 != 0)
                {
                    iRail1TotalKeys++;
                    iRail2StartKey = iRail1TotalKeys + 1;
                    iRail2TotalKeys = (iTotalKeysPerFountain - iRail1TotalKeys);
                }
            }

            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                mcUnit.UnitName = "Unit" + (iUnit + 1).ToString();
                mcUnit.TotalInkers = Math.Min(m_iInkersPerUnit, (totalInkers - inkerCount));

                for (int side = 0; side < m_iInkersPerUnit; side++)
                {
                    if (inkerCount < totalInkers)   //processing next inker count versus the count from first view
                    {
                        MCInker mcInker = null;
                        if( inkerCount < tempInkers.Length )    //check the press inker count
                        {
                            mcInker = tempInkers.GetValue( inkerCount ) as MCInker; //restore inker info from press
                        }
                        else    //this is a new inker to be added to press
                        {
                            mcInker = new MCInker();
                            // Generate Inker names as per the Press type selected
                            string surfaceName = ( CurrentPress.IsCICPress ? "Deck" : "Upper" );
                            if( side == 1 )
                            {
                                surfaceName = "Lower";
                                mcInker.UpperLowerInker = surfaceName;
                            }
                            //
                            // There are too many members to represent the WebSide of an Inker. Let us use one data member consistently to represent 
                            // the WebSide of an Inker.
                            //
                            mcInker.UpperOrLowerInker = ( int )( ( side == 0 ) ? MCNWSiteGen.INKERTYPE.UPPER : MCNWSiteGen.INKERTYPE.LOWER );
                            if( cbVirtualInkers.Checked && (inkerCount > 0))            //update the inker name is Virtual Inkers after the first inker
                                surfaceName = "Virtual";                                // 20240315 Mark C
                            mcInker.InkerName = surfaceName + " " + ( iUnit + 1 ).ToString();
                        }

                        // Copy Servo banks info
                        Array tempServoBanks = Array.CreateInstance( typeof( ServoBanks ), mcInker.ServoBanks.Count );
                        mcInker.ServoBanks.CopyTo( tempServoBanks );

                        mcInker.TotalKeys = iTotalKeysPerFountain;
                        mcInker.KeyWidth = fKeyWidth;
                        mcInker.InitInkerKey();             //<<<<<<<<< create list m_ayInkerKeys[]
                        mcInker.ClearServoBanks();          //<<<<<<<<< create list m_ayServoBanks[]

                        //
                        int iCount = 0;
                        if (availableInkers % iAvailableSpu == 0)   //do total of inkers fit on avail SPU?
                        {
                            iCount = availableInkers / iAvailableSpu;
                            if (iTemp == iCount)
                            {
                                if (iTotalSpus % 2 == 0)
                                {
                                    if (iTotalSpus != 2)
                                        iTemp = 1;
                                    else
                                        iTemp = 0;
                                }
                                else
                                    iTemp = 1;
                                iSpu++;
                            }
                            else
                                iTemp++;
                        }
                        else
                        {
                            iCount = availableInkers / iAvailableSpu;
                            iCount++;
                            if (iTemp == iCount)
                            {
                                iTemp = 1;
                                iSpu++;
                                availableInkers -= iCount;
                                iAvailableSpu--;
                            }
                            else
                                iTemp++;
                        }
                        //
                        int iTotalBanks = ( iTotalKeysPerFountain > DefineAndConst.SystemCapacities.MAX_SERVOS_PER_SPU_PORT ) ? 2 : 1;
                                                                /*a bank can have max of 44 keys*/
                        for (int iBank = 0; iBank < iTotalBanks; iBank++)
                        {
                            PressSPU spu = GetCurrentPress().SPU(iSpu);
                            if (spu == null)
                            {
                                continue;
                            }

                            ServoBanks servoBank = new ServoBanks();

                            if (cbVirtualInkers.Checked && (inkerCount > 0))            //update the SPU data to servo bank if Virtual Inkers after the first inker
                            {                                                           // 20240315 Mark C
                                servoBank.SPUName = "NA";
                                servoBank.PortOnSPU = 1;
                                servoBank.StartKey = (iBank == 0) ? 1 : iTotalKeysPerFountain;
                                servoBank.TotalKeys = iTotalKeysPerFountain;
                                servoBank.BankInverted = false;
                                mcInker.AddServoBank(servoBank);
                                continue;
                            }
                            servoBank.SPUName = spu.SPUName;
                            {
                                if (strPrevSpu == "")
                                {
                                    strPrevSpu = spu.SPUName;
                                    iPortOnSPU = 1;
                                }
                                else
                                {
                                    if (strPrevSpu == spu.SPUName)
                                        iPortOnSPU++;
                                    else
                                    {
                                        strPrevSpu = spu.SPUName;
                                        iPortOnSPU = 1;
                                    }
                                }
                            }
                            servoBank.PortOnSPU = iPortOnSPU;
                            if (IsWidePress)
                            {
                                int iStartKey = 1;
                                int iTotalKeysToControl = 0;
                                if (iBank == 0)
                                {
                                    iStartKey = 1;
                                    iTotalKeysToControl = iRail1TotalKeys;
                                }
                                else
                                {
                                    iStartKey = iRail2StartKey;
                                    iTotalKeysToControl = iRail2TotalKeys;
                                }
                                servoBank.StartKey = iStartKey;
                                servoBank.TotalKeys = iTotalKeysToControl;
                            }
                            else
                            {
                                servoBank.StartKey = (iBank == 0) ? 1 : iTotalKeysPerFountain;
                                servoBank.TotalKeys = iTotalKeysPerFountain;
                            }

                            // Keep the Key alignment  
                            if( iBank < tempServoBanks.Length )
                            {
                                if( tempServoBanks.GetValue( iBank ) is ServoBanks )
                                {
                                    ServoBanks tempBank = tempServoBanks.GetValue( iBank ) as ServoBanks;
                                    servoBank.BankInverted = tempBank.BankInverted;
                                }
                            }                                

                            mcInker.AddServoBank(servoBank);
                        }// bank loop

                        mcUnit.InitializeInker(mcInker);    //add this inker info to list m_ayInkers
                        CurrentPress.InkerList.Add(mcInker);    //add this inker info to press info
                        inkerCount++;
                    }// next inker
                    iPercentComplete += (int)(((float)iUnit / iTotalUnits) * 100.0);
                    if (iPercentComplete > 100)
                        iPercentComplete = 100;
                    IndicateProgress.Value = iPercentComplete;
                    System.Threading.Thread.Sleep(100);
                    CurrentPress.OCUInterface.NumberOfZones = iTotalKeysPerFountain;
                }// side loop (surface)
            }//unit loop
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 08-Dec-16, Mark C, WI83371: Created    
        ///         
        /// ]]>
        /// <summary>
        /// Updates the inker to SPU and port map.
        /// </summary>
        private void UpdateInkerToSPUAndPortMap()
        {
            // First, generate the Inker to SPU and Port map
            Dictionary<int, SPUToPortMap> indexToSPUPortMap = new Dictionary<int, SPUToPortMap>( );
            if ( GenerateInkerToSPUAndPortMap( indexToSPUPortMap ) )
            {
                // Apply the updated Inker to SPU and Port map data
                UpdateInkerToSPUAndPortMap( indexToSPUPortMap );
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 08-Dec-16, Mark C, WI83371: Created    
        ///         
        /// ]]>
        /// <summary>
        /// Generates the inker to SPU and port map, like this:
		/// Standard ever since the first web press we did has always been Uppers on SPU 1, Lowers on SPU2.
		/// If more than two SPUs, then split them up evenly.
		/// For example , a 8x8 will have 4 inkers on each SPU.
		/// Units 5-8 will be SPUs 3 (upper) and 4 (lower).
		/// for multi-web presses, treat all units like ONE web press for SPU port assignments.
        /// </summary>
        /// <param name="indexToSPUPortMap">The index to SPU port map.</param>
        /// <returns></returns>
        private bool GenerateInkerToSPUAndPortMap( Dictionary<int, SPUToPortMap> indexToSPUPortMap )
        {
            MCPressInfo press = GetCurrentPress( );
            if ( null == press )
            {
                return false;
            }

            // Perform the port assignments ONLY if it is a Single web or Multi-web press
            if ( (( int ) enPressTypes.SINGLE_WEB_PRESS != press.PressType) &&
				  ((int)enPressTypes.MULTI_WEB_PRESS != press.PressType))
            {
                return false;
            }

            int totalNumOfPorts = ( ( IsWidePress ) ? ( press.InkerList.Count * 2 ) : press.InkerList.Count );
            int spuCount = press.GetTotalSPUS( );
            if ( ( totalNumOfPorts <= 0 ) || ( spuCount <= 1 ) )
            {
                return false;
            }

            int portCountPerSPU = 0;
            // calculate the #of ports per SPU
            if ( ( totalNumOfPorts % spuCount ) == 0 )
            {
                portCountPerSPU = ( totalNumOfPorts / spuCount );
            }
            else
            {
                portCountPerSPU = ( totalNumOfPorts / spuCount );
                portCountPerSPU++;
            }

            int currentSPUIndex = 0;
            int index = 0;

            do
            {
                // for each port
                for ( int portIndex = 0; portIndex < portCountPerSPU; ++portIndex )
                {
                    // for each SPU
                    for ( int spuIndex = currentSPUIndex; spuIndex < Math.Min( currentSPUIndex + 2, spuCount ); ++spuIndex )
                    {
                        if ( index < totalNumOfPorts )
                        {
                            string spuName = string.Format( "SPU{0}", ( spuIndex + 1 ) );
                            indexToSPUPortMap.Add( index++, new SPUToPortMap( spuName, ( portIndex + 1 ) ) );
                        }
                    }
                }
                // move to next available SPUs
                currentSPUIndex += 2;

            } while ( currentSPUIndex < spuCount );

            return true;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 08-Dec-16, Mark C, WI83371: Created    
        ///         
        /// ]]>
        /// <summary>
        /// Updates the inker to spu and port map.
        /// </summary>
        /// <param name="indexToSPUPortMap">The index to spu port map.</param>
        private void UpdateInkerToSPUAndPortMap( Dictionary<int, SPUToPortMap> indexToSPUPortMap )
        {
            MCPressInfo press = GetCurrentPress( );
            if ( null == press )
            {
                return;
            }

            int index = 0;
            // for each Inker
            foreach ( MCInker inker in press.InkerList )        //every inker in this list is assigned SPU and port
            {
                // for each Servo bank ( rail )
                foreach ( ServoBanks servoBank in inker.ServoBanks )
                {
                    if ( indexToSPUPortMap.ContainsKey( index ) )       //this index to SPU port must have a key.
                    {
                        servoBank.SPUName = indexToSPUPortMap[ index ].SPUName;
                        servoBank.PortOnSPU = indexToSPUPortMap[ index ].PortIndex;
                        ++index;
                    }
                }
            }
        }

        private void rButtonOneSurface_CheckedChanged(object sender, EventArgs e)
        {
            m_iInkersPerUnit = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            m_iInkersPerUnit = 2;
        }

        private void btnInkerInfo_Click_1(object sender, EventArgs e)
        {
            btnInkerInfo_Click(sender, e);
        }

        private void btnSPUInformation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
       
        /// <![CDATA[
        /// Author: Hema Kumar   09/10/2008
        /// 
        /// History:  
        ///         Hema Dt: 04-03-2010 MT: 15333
        ///         Hema Dt: 14-10-2010 MT: 16257, to provide the passwords to System view options
        ///         Hema Dt: 14-01-2011 MT: 16254, to change the open sweep up to by percentage
        ///         Chetan, WI#31061, Added support to write JOBS folder shared name
        ///         18-Mar-2014, Chetan, Support for keyboard layouts path.
        ///         06-Jan-2015, spa 51032 Add Imposition data field
        ///         19-Jul-17, Mark C, WI102725: Add XML data elements of AVT PLC Configuration
        ///         16-Oct-18 dlg, (177481) Add XML data elements for Register control
        /// ]]>
        /// <summary>
        /// Declaring the xml node constants 
        /// </summary>
        public class XMLNodeDictionary
        {
            #region XML NODE NAME
            public const string COMMENT_MULTIPLE = "Can have more than one child";
            public const string COMMENT_CONTROLS = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            public const string COMMENT_WATER_CONTROL_INTERFACE = "Motr=1, Srv=2, Miyakoshi Water =3, PLC=4, PCU =5, GOSS MPU GATEWAY = 6";
            public const string COMMENT_KEY_MEMBER_STARTS_FROM = "Key number starts from 1";
            public const string COMMENT_CLOSE_KEYS_POSITION = "0 = 1, 0.1 = 2, 0.3 = 3";
            public const string COMMENT_UTILITY_TEST_TIME_DELAY = "1 sec = 1, 30 sec = 2, 60 sec = 3";
            public const string COMMENT_SCAN_SWEEP_ADJUST = "SCAN_SWEEP_DEFAULT = 1, SCAN_SWEEP_ADJUST = 2, SCAN_SWEEP_RETAIN = 3";
            public const string COMMENT_WEB_TYPE = "SHEETFED==0, SINGLE_WEB_PRESS==1, TWO_WEB_SPLIT_PRESS==2";
            
            public const string COMMENT_UTILITY_TEST_NUMBER_OF_CYCLES = "1 , 20 , 50";
            public const string COMMENT_UTILITY_TEST_LOOP_TYPE = "Sequential=1, Simultaneous=2";
            public const string COMMENT_OPEN_KEYS_UP_TO = "630 , 2982 , 1000 ";
            public const string C0MMENT_TOTAL_SWEEP_TO_TEST= "(0 - 6)";
            public const string C0MMENT_TOTAL_SPUS_TO_TEST = "(1 - 4)";
            public const string C0MMENT_WHICH_PORT_TO_TEST = "(1 - 8)";
            public const string COMMENT_OPEN_KEYS_PERCENTAGE = "(0 - 99 %)";
            

            public const string COMMENT_OTHERMEMBERS = "TO DO : Other Members";
            public const string COMMENT_KEY_WIDTH_IN_MM = "Key widths are in mm";

            public const string COMMENT_EXIT_PASSWORD = "Password to Exit the MC3 Application";
            public const string COMMENT_RUNTIME_OPTIONS_PASSWORD = "Password to open the Runtime Options";
            public const string COMMENT_DIAGNOSTIC_PASSWORD = "Password to open the Diagnostic Operations";
            public const string COMMENT_SYSTEM_CONFIGURATION_PASSWORD = "Password to open the System Configurations";

            public const string VALUE = "Value";
            public const string PATH = "Path";
            public const string NAME = "NAME";
            public const string ARRAY_SIZE = "Count";
            public const string XT_MCSYSTEM_CONFIG = "MCSYSTEM_CONFIG";
            public const string XT_SYSTEM_SITENAME = "SITE_NAME";
            public const string XT_SYSTEM_SITENUMBER = "SITE_NUMBER";
            public const string XT_SYSTEM_PRESSNAME = "PRESS NAME";
            public const string XT_MCSYSTEM_PRESSES = "MCPRESSES";
            public const string XT_SYSTEM_PRESS = "PRESS";
            public const string XT_COUNT = "COUNT";
            public const string XT_VALUE = "VALUE";
            
            //public const string CQSYSTEM_CQJOBS				= "CQJOBS";

            public const string XT_MCSYSTEMCONFIG_VERSION = "Version";
            
            // PRESS
            public const string XT_PRESS_WIDTH = "PressWidth";
            public const string XT_PRESS_UNITS = "PRESS_UNITS";
            public const string XT_PRESS_UNIT = "UNIT";
            public const string XT_PRESS_UNITNAME = "UNIT NAME";
            public const string XT_PRESS_FOLDERS = "PRESS_FOLDERS";
            public const string XT_PRESS_FOLDER = "FOLDER";
            public const string XT_PRESS_FOLDERNAME = "FOLDER NAME";
            public const string XT_PRESS_UNITGROUPS = "PRESS_UNITGROUPS";
            public const string XT_PRESS_UNITGROUP = "UNITGROUP";
            public const string XT_PRESS_REELSTANDS = "PRESS_REELSTANDS";
            public const string XT_PRESS_REELSTAND = "PRESS_REELSTAND";
            public const string XT_MCPRESS_SPUS = "PRESS_SPUS";
            public const string XT_MCPRESS_SPU = "SPU";
            public const string XT_PRESS_CLIENTINTERFACE = "PRESS_CLIENTINTERFACE";
            public const string XT_MCPRESS_CLIENTINTERFACE = "MCPRESS_CLIENTINTERFACE";
            public const string XT_MCPRESS_OCU = "PRESS_OCU";
            public const string XT_MCPRESS_NFSTABLE = "PRESS_NFSTABLE";
            public const string XT_MAX_FOUNTAIN_PORTS_SPU = "MAX_FOUNTAIN_PORTS";
            public const string XT_MAX_WEBS = "PRESS_MAX_WEBS";

            public const string XT_CQ_CLC_CONFIGURATION = "CQ_CLC_CONFIGURATION";
            public const string XT_CQ_CLC_ISCONFIGURED = "IsCQCLCConfigured";
            public const string IP_ADDRESS = "IP_ADDRESS";
            public const string PORT = "PORT";
            public const string XT_COMM_TYPE = "COMM_TYPE"; //WI40392: Type of communication - Serial or Ethernet 

            public const string XT_MCPRESS_PRESS_SWEEP_CONTROL_INTERFACE = "PRESS_SWEEP_CONTROL_INTERFACE";
            public const string XT_MCPRESS_PRESS_CONTROL_TYPE = "CONTROL_TYPE";
            public const string XT_MCPRESS_PRESS_WATER_CONTROL_INTERFACE = "PRESS_WATER_CONTROL_INTERFACE";

            public const string XT_MCPRESS_PRESS_PLC_CONTROL = "PLC_CONTROL";
            public const string XT_MCPRESS_PRESS_PLC_TYPE  = "PLC_TYPE";   // Modified by Sreejit for ENH MT#15294
            public const string XT_MCPRESS_PRESS_PLC_CONFIG = "PLC_CONFIG"; // Modified by Sreejit for ENH MT#15294
            public const string XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC = "WASH_CYCLE_TIME_IN_10TH_SEC";
            public const string XT_MCPRESS_PRESS_MECH_DELAY_IN_MS = "MECH_DELAY_IN_MS";
            public const string XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE = "TACH_PULSE_PER_EXECUTION_CYCLE";
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface
            public const string XT_SAMPLE_TIME_MS = "SAMPLE_TIME_IN_MS";  //18 Feb 2010 Mark Colvin MT16792
            public const string XT_SWEEP_DIVISOR = "SWEEP_DIVISOR";
            public const string XT_WATER_DIVISOR = "WATER_DIVISOR";
            public const string XT_WATER_OUTPUT_MIN = "WATER_OUTPUT_MIN";
            public const string XT_WATER_START_SPEED_MIN = "WATER_START_SPEED_MIN";
            public const string XT_WATER_START_SPEED_MAX = "WATER_START_SPEED_MAX";
            public const string XT_WATER_STARTUP_VOLTAGE = "WATER_STARTUP_VOLTAGE";
            /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
            public const string XT_SWEEP_NL_CURVE = "SWEEP_NL_CURVE";               
            public const string XT_SWEEP_MOTOR_SPEED = "SWEEP_MOTOR_SPEED";
            public const string XT_SWEEP_MOTOR_TURNS = "SWEEP_MOTOR_TURNS";

            //Allen Bradley Sweeps												WI29958  markc 11/6/12
            public const string XT_AB_TYPE = "AB_TYPE";
            public const string XT_AB_BAUD = "AB_BAUD";
            public const string XT_AB_PLC_NODE = "AB_PLC_NODE";
            public const string XT_AB_AS_NODE = "AB_AS_NODE";
            public const string XT_AB_FILENAME = "AB_FILENAME";
            public const string XT_AB_MOD_TYPE = "AB_MOD_TYPE";
            public const string XT_AB_PLC_MAP = "AB_PLC_MAP";
            public const string XT_AB_POLL_TYPE = "AB_POLL_TYPE";       //MT18035  MarkC 2/8/13 add poll type and rate
            public const string XT_AB_POLL_RATE = "AB_POLL_RATE";

            public const string XT_MCPRESS_PRESS_MOTOR_CONTROL = "MOTOR_CONTROL";
            public const string XT_MCPRESS_PRESS_SERVOTURNS = "SERVOTURNS";
            public const string XT_MCPRESS_PRESS_INITIAL_SURGE = "INITIAL_SURGE";
            public const string XT_MCPRESS_PRESS_INCREMENTAL_SURGE = "INCREMENTAL_SURGE";
            public const string XT_MCPRESS_PRESS_USE_BANK_1 = "USE_BANK_1";
            public const string XT_MCPRESS_PRESS_REVERSED = "REVERSED";

            public const string XT_MCPRESS_PRESS_STEP_ENABLED = "STEP_ENABLED";
            public const string XT_MCPRESS_PRESS_LOW_BACKLASH_USED = "LOW_BACKLASH_USED";
            public const string XT_MCPRESS_PRESS_OFFSET_ENABLED = "OFFSET_ENABLED";
            public const string XT_MCPRESS_PRESS_SERVO_CONTROL = "SERVO_CONTROL";
            public const string XT_MCPRESS_PRESS_MOTOR_AND_SERVO_CONTROL = "MOTOR_AND_SERVO_CONTROL";
            public const string XT_MCPRESS_PRESS_TURNS2 = "TURNS2";

            public const string XT_MCPRESS_PRESS_SWEEP_SERVO = "SWEEP_SERVO";
            public const string XT_MCPRESS_PRESS_WATER_SERVO = "WATER_SERVO";
            public const string XT_MCPRESS_PRESS_SPECIAL_MAPPING = "SPECIAL_MAPPING";

            //WI31010 PCU SWEEP/WATER members
            public const string XT_MCPRESS_PRESS_PCU_CONTROL = "PCU_CONTROL";
            public const string XT_MCPRESS_PCU_SWEEP_PULSE_WIDTH = "PCU_SWEEP_PULSE_WIDTH";
            public const string XT_MCPRESS_PCU_SWEEP_DIST_NUDGE = "PCU_SWEEP_DIST_NUDGE";
            public const string XT_MCPRESS_PCU_SWEEP_MAX_STALLS = "PCU_SWEEP_MAX_STALLS";
            public const string XT_MCPRESS_PCU_SWEEP_TOLERANCE = "PCU_SWEEP_TOLERANCE";
            public const string XT_MCPRESS_PCU_WATER_PULSE_WIDTH = "PCU_WATER_PULSE_WIDTH";
            public const string XT_MCPRESS_PCU_WATER_DIST_NUDGE = "PCU_WATER_DIST_NUDGE";
            public const string XT_MCPRESS_PCU_WATER_MAX_STALLS = "PCU_WATER_MAX_STALLS";
            public const string XT_MCPRESS_PCU_WATER_TOLERANCE = "PCU_WATER_TOLERANCE";


            public const string XT_PRESS_TYPE = "PRESS_TYPE";
            public const string XT_PRESS_CONSOLE_ZONES = "PRESS_CONSOLE_ZONES";
            public const string XT_PRESS_IS_USED = "IS_USED";
            // AUTO TEST
            public const string XT_PRESS_AUTO_TEST = "PRESS_AUTO_TEST";
            public const string XT_PRESS_TOTAL_SPUS_TO_TEST = "TotalSPUsToTest";
            public const string XT_PRESS_TOTAL_UNITS_TO_TEST = "TotalUnitsToTest";
            public const string XT_PRESS_TOTAL_SERVOS_TO_TEST = "TotalServosToTest";
            public const string XT_PRESS_CLOSE_KEYS_UP_TO = "CloseKeysUpTo";
            public const string XT_PRESS_TIME_DELAY = "TimeDelay";
            public const string XT_PRESS_NUMBER_OF_CYCLES = "NoOfCycles";
            public const string XT_PRESS_LOOP_TYPE = "LoopType";
            public const string XT_PRESS_OPEN_KEYS_UP_TO = "OpenKeysUpTo";
            // MC SWEEP TEST
            public const string XT_PRESS_SWEEP_TEST = "PRESS_SWEEP_TEST";
            public const string XT_PRESS_WHICH_PORT_TO_TEST = "WhichPortToTest";
            public const string XT_PRESS_TOTAL_SWEEP_TO_TEST = "TotalSweepToTest";
            public const string XT_PRESS_OPEN_SWEEP_UP_TO = "OpenSweepUpTo";
            // MC PRESS TURN BAR
            public const string XT_PRESS_TURN_BARS = "PRESS_TURN_BARS";
            public const string XT_PRESS_TURN_BAR = "TURN_BAR";
            public const string XT_PRESS_TURN_BAR1 = "TurnBar1";
            public const string XT_PRESS_TURN_BAR2 = "TurnBar2";

            // MC AUTO SCAN CAL
            public const string XT_PRESS_AUTO_SCAN_CAL = "AUTOSCANCAL";
            public const string XT_PRESS_SWEEP_ZONE_RATIO = "SweepZoneRatio";
            public const string XT_PRESS_ZONE_MARGIN = "ZoneMargin";
            public const string XT_PRESS_EWMAFACTOR = "EWMAFilterParam";
            public const string XT_PRESS_SCAN_SWEEP_ADJUST = "ScanSweepAdjust";
            public const string XT_PRESS_SWEEP_DEFAULT = "SweepDefault";
            public const string XT_PRESS_WEB_TYPE = "WEB_TYPE";
            public const string XT_PRESS_ENABLE_LIMIT_CHECK = "EnableLimitCheck";
            public const string XT_PRESS_BLADE_TOLERANCE = "BladeTolerance";
            public const string XT_PRESS_CIP3_PATH = "CIP3Path";
            public const string XT_PRESS_CIP3_IMAGES_PATH = "CIP3ImagesPath";
            public const string XT_PRESS_AUTO_ZERO_SERVOS = "AutoZeroServos";
            public const string XT_PRESS_ENABLE_IMPOSITION_DATA = "EnableImpositionData";
            public const string XT_PRESS_IMPO_PATH = "ImpositionDataPath";

            // Press AutoZero Setting  - parameters, WI28788
            public const string XT_PRESS_AUTO_ZERO = "PressAutoZero";
            public const string XT_PRESS_AUTO_ZERO_ENABLED = "AutoZeroEnabled";
            public const string XT_PRESS_AUTO_ZERO_MODE = "AutoZeroMode";
            public const string XT_PRESS_AUTO_ZERO_DEV_IPADDR = "DeviceIPAddress";
            public const string XT_PRESS_AUTO_ZERO_DEV_ID = "DeviceID";
            public const string XT_PRESS_AUTO_ZERO_TIME_DELAY = "AutoZeroTimeDelay";
            public const string XT_PRESS_AUTO_ZERO_POLL_TIME = "PollTimePeriod";
            public const string XT_PRESS_AUTO_ZERO_FACTOR_FREQUENCY = "FactorFrequency";
            public const string XT_PRESS_AUTO_ZERO_IDLE_THRESHOLD_FPM = "IdleThresholdFPM";
            public const string XT_PRESS_AUTO_ZERO_DRY_CON_IDLE_STATE = "DryContactIdleState";
            public const string XT_PRESS_AUTO_ZERO_DELAY_FOUNTAIN_CLOSE = "DelayForFountainClose";
                   //WI30488 - multiple sources Auto Zero configuration set up
            public const string XT_PRESS_AZ_NUMBER_OF_SENSORS = "NumberOfSensors";
            public const string XT_PRESS_AZ_DRY_CHANNELS_MAPPING = "DryChannelsMapping";
            public const string XT_PRESS_AZ_FREQUENCY_CHANNELS_MAPPING = "FrequencyChannelsMapping";
            public const string XT_PRESS_AZ_MAPPING_ELEMENT = "MappingElement";
            public const string XT_PRESS_AZ_INPUT_CHANNEL_ID = "InputChannelId";
            public const string XT_PRESS_AZ_UNIT_NAME = "UnitName";

            

            public const string XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT = "AFTER_WHICH_UNIT";
            public const string XT_PRESS_UNIT4 = "Unit4";
            public const string XT_PRESS_UNIT8 = "Unit8";
            public const string XT_PRESS_ACTIVATED = "ACTIVATED";
            public const string XT_PRESS_FALSE = "FALSE";
            public const string XT_PRESS_TRUE = "TRUE";


            // MC PRESS - PRESS UNIT
            public const string XT_NAME = "Name";
            public const string XT_INKERS = "INKERS";
            public const string XT_INKER = "INKER";
            public const string XT_INKERNAME = "INKER NAME";

            // PRESS UNIT - UNIT INKER
            public const string XT_UNIT_INKER_KEY1OPERATORSIDE = "Key1OperatorSide";
            public const string XT_MCUNIT_INKER_SIDE = "UpperLowerInker";
            public const string XT_MCUNIT_INKER_SERVOTURNS = "ServoTurns";
            public const string XT_MCUNIT_INKER_STURN = "STurn";
            public const string XT_UNIT_INKER_MINVALUE = "MinValue";
            public const string XT_UNIT_INKER_MAXVALUE = "MaxValue";
            public const string XT_MCUNIT_INKER_KEYS = "INKER_KEYS";
            public const string XT_MCUNIT_INKER_KEY = "INKER_KEY";
            public const string XT_MCUNIT_INKER_SERVO_BANKS = "SERVO_BANKS";
            public const string XT_MCUNIT_INKER_SERVO_BANK = "SERVO_BANK";
            public const string XT_MCUNIT_KEY_WIDTHS_ARE_IN_MM = "Key widths are in mm";
            public const string XT_MCUNIT_INKER_INVERTED = "Inverted";
            public const string XT_MCUNIT_INKER_LINEAR_TABLE_INDEX = "LinearTableIndex";
            public const string XT_MCUNIT_INKER_LINEAR_TABLE_SIZE = "LinearTableSize";
            public const string XT_KEYS_DISPLAY_ON_CLIENT = "NumberOfDisplayKeys";
            public const string XT_CIP3_IMAGE_ROTATE_DEGREES = "CIP3_image_rotate_degrees";
            public const string XT_CIP3_DATA_ROTATION = "CIP3_data_rotation";
            public const string XT_INKER_LEFT_SIDE = "INKER_LEFT_SIDE"; // To represent the location of an Inker in CIC Press Type(s)

            // Inker Register Configuration
            public const string XT_INKER_REGISTER_CONFIG = "INKER_REGISTER_CONFIG";
            public const string XT_INKER_REGISTER_LAT_MOTOR = "INKER_REGISTER_LAT_MOTOR";
            public const string XT_INKER_REGISTER_CIRC_MOTOR = "INKER_REGISTER_CIRC_MOTOR";
            public const string XT_INKER_REGISTER_SKEW_MOTOR = "INKER_REGISTER_SKEW_MOTOR";
            public const string XT_REGISTER_LAT_MAX_TRAVEL = "LatMotorMaxTravel";
            public const string XT_REGISTER_LAT_LIMIT_SWITCHES = "LatMotorLimitSwitches";
            public const string XT_REGISTER_LAT_SLOPE = "LatMotorSlope";
            public const string XT_REGISTER_LAT_POT_FEEDBACK = "REGISTER_LAT_MOTOR_POT_FEEDBACK";
            public const string XT_REGISTER_LAT_POT_FB_MIN = "LatMotorPotFeedBackMin";
            public const string XT_REGISTER_LAT_POT_FB_MAX = "LatMotorPotFeedBackMax";
            public const string XT_REGISTER_LAT_BLOCK_MOTOR_WHEN_PRESS_STOPPED = "BlockSidelayMotorWhenPressStopped";
            public const string XT_REGISTER_CIRC_MAX_TRAVEL = "CircMotorMaxTravel";
            public const string XT_REGISTER_CIRC_LIMIT_SWITCHES = "CircMotorLimitSwitches";
            public const string XT_REGISTER_CIRC_SLOPE = "CircMotorSlope";            
            public const string XT_REGISTER_CIRC_POT_FEEDBACK = "REGISTER_CIRC_MOTOR_POT_FEEDBACK";
            public const string XT_REGISTER_CIRC_POT_FB_MIN = "CircMotorPotFeedBackMin";
            public const string XT_REGISTER_CIRC_POT_FB_MAX = "CircMotorPotFeedBackMax";
            public const string XT_REGISTER_CIRC_BLOCK_MOTOR_WHEN_PRESS_STOPPED = "BlockCircMotorWhenPressStopped";
            public const string XT_REGISTER_SKEW_MAX_TRAVEL = "SkewMotorMaxTravel";
            public const string XT_REGISTER_SKEW_LIMIT_SWITCHES = "SkewMotorLimitSwitches";
            public const string XT_REGISTER_SKEW_SLOPE = "SkewMotorSlope";
            public const string XT_REGISTER_SKEW_POT_FEEDBACK = "REGISTER_SKEW_MOTOR_POT_FEEDBACK";
            public const string XT_REGISTER_SKEW_POT_FB_MIN = "SkewMotorPotFeedBackMin";
            public const string XT_REGISTER_SKEW_POT_FB_MAX = "SkewMotorPotFeedBackMax";
            public const string XT_REGISTER_SKEW_BLOCK_MOTOR_WHEN_PRESS_STOPPED = "BlockSkewMotorWhenPressStopped";
            

            // UNIT INKER - INKER KEY
            public const string XT_UNIT_INKER_ATTRIB_WIDTH = "Width";

            // UNIT INKER - SERVO BANK
            public const string XT_MCINKER_SERVO_ADDRESS = "ServoAddress";
            public const string XT_MCINKER_SERVO_TOTALKEYS = "TotalKeysToCtrl";
            public const string XT_MCINKER_SERVO_START_KEY = "StartFromKey";
            public const string XT_MCINKER_SERVO_BANK_INVERTED = "BankInverted";

            public const string XT_MCSERVO_BANK_SPU_NAME = "SPUName";
            public const string XT_MCSERVO_BANK_SPU_PORT = "SPUPort";

            // PRESS - UNITGROUP
            public const string XT_UNITGROUP_UNITGROUPMEMS = "UNITGROUP_MEMS";
            public const string XT_UNITGROUP_UNITGROUPMEM = "UnitGroupMem";

            // PRESS SPUS
            public const string XT_MCPRESS_SPU_COMPORT = "COMPORT";

            // PRESS OCU 
            public const string XT_NUM_ZONES = "NumOfZones";
            public const string XT_MCPRESS_OCU_ZONE_WIDTH = "ZoneWidthInCM";

            //PRESS_NFSTABLE
            public const string XT_MCPRESS_NFSTABLE_BREAKPOINT = "BreakPoint";
            public const string XT_MCPRESS_NFSTABLE_GAIN = "MaxKeyTurnsAtConsoleZone99";


            // MC Press Client Interface 
            public const string XT_MC_CLIENT_BLADE_STIFFNESS = "BladeStiffness";
            public const string XT_MC_CLIENT_MAX_NEIGH_KEY_DELTA = "MaxNeighborKeyDelta";
            public const string XT_MC_CLIENT_LINEAR_TABLE = "LinearTable";
            public const string XT_MC_CLIENT_NON_LINEAR_TABLE = "NonLinearTable";
            public const string XT_MC_CLIENT_DEFAULT_OFFSET = "DefaultOffset";
            public const string XT_MC_CLIENT_SERVO_PULSES_ZONE_AT_ZERO = "ServoPulsesZoneAtZero";
            public const string XT_MC_CLIENT_ZERO_BACKOFF = "PressZeroBackoffInPulses";
            public const string XT_MC_CLIENTINTERFACE_CLIENTFEATURES = "MCCLIENT_FEATURES";
            public const string XT_MC_CLIENTINTERFACE_WIDEPRESS = "WidePress";
            public const string XT_MC_CLIENTINTERFACE_FUNNY_FOUNTAINS = "FunnyFountains";
            public const string XT_MC_CLIENTINTERFACE_VIRTUAL_INKERS = "VirtualInkers";

            //MC PRESS CLIENT FEATURES
            public const string XT_MC_CLIENT_FEATURE_NON_LINEAR = "NonLinear";
            public const string XT_MC_CLIENT_FEATURE_BLADE_COMPENSATION = "BladeCompensation";
            public const string XT_MC_CLIENT_FEATURE_CIP3_PRESETTING = "CIP3Presetting";
            public const string XT_MC_CLIENT_FEATURE_METER_OFFSET = "MeterOffset";
            public const string XT_MC_CLIENT_FEATURE_SWEEP_CONTROL = "SWEEP_CONTROL";
            public const string XT_MC_CLIENT_FEATURE_WATER_CONTROL = "WATER_CONTROL";

            public const string XT_TOP = "Top";
            public const string XT_UPPER = "Upper";
            public const string XT_BOTTOM = "Bottom";
            public const string XT_LOWER = "Lower";
            public const string XT_CIC_INKER_TEXT = "Deck"; // Inker label text for Common Impression Cylinder (CIC) press type

            // Press Client Interface
            public const string XT_CLIENTINTERFACE_CLIENTFEATURES = "CLIENT_FEATURES";
            // Press Client Interface - Passwords
            public const string XT_CLIENTINTERFACE_CLIENTPASSWORDS = "CLIENT_PASSWORDS";
            public const string XT_CLIENTINTERFACE_CLEVEL1 = "Level1";
            public const string XT_CLIENTINTERFACE_CLEVEL2 = "Level2";
            public const string XT_CLIENTINTERFACE_CLEVEL3 = "Level3";
            public const string XT_CLIENTINTERFACE_COPTIONLEVELS = "OptionLevels";
            public const string XT_CLIENTINTERFACE_CFACTORY = "Factory";
            public const string XT_CLIENTINTERFACE_CINSTALLER = "Installer";
            public const string XT_CLIENTINTERFACE_CADVUSER = "AdvUser";
            // Press Client Interface - Path names
            public const string XT_CLIENTINTERFACE_CLIENTDATAFILEPATHES = "DATA_FILE_PATHES";
            public const string XT_CLIENTINTERFACE_CLIENTPATHNAMES = "CLIENT_PATHNAMES";
            public const string XT_CLIENTINTERFACE_CREMOTEDATASTORAGE = "REMOTE_DATA_STORAGE";
            public const string XT_CLIENTINTERFACE_CLOCALDATASTORAGE = "LOCAL_DATA_STORAGE";
            public const string XT_CLIENTINTERFACE_CJOBSTORAGESHARENAME = "JOB_STORAGE_SHARE_NAME";
            public const string XT_CLIENTINTERCACE_CJOBARCHIVESTORAGESHARENAME = "ARCHIVE_STORAGE_SHARE_NAME"; //WI#30968 provide archives share name
            public const string XT_CLIENTINTERFACE_JMVJOBS_STORAGESHARENAME = "JOBS_STORAGE_SHARE_NAME"; // WI#31061
            public const string XT_CLIENTINTERFACE_CCLIENTBACKUPDRIVE = "CLIENT_BACKUP_DRIVE";
            //WI31065 - Add shared name for Form Template storage
            public const string XT_CLIENTINTERFACE_FORM_TEMPLATE_STORAGE_SHARENAME = "TEMPLATE_STORAGE_SHARE_NAME"; 



            public const string XT_CLIENTINTERFACE_DISPLAYOPTIONTOP = "DISPLAYOPTION_TOP";
            public const string XT_CLIENTINTERFACE_OPERATORONLEFT = "OperatorOnLeft";
            public const string XT_CLIENTINTERFACE_WEBDIRECTIONUP = "WebDirectionUp";
            public const string XT_CLIENTINTERFACE_DISPLAYKEYLEFTTORIGHT = "DisplayKeyLeftToRight";


            public const string XT_CLIENTINTERFACE_DISPLAYOPTIONBOT = "DISPLAYOPTION_BOTTOM";
            public const string XT_CLIENTINTERFACE_CURRENTLANGUAGE = "CurrentLanguage";
            public const string XT_CLIENTINTERFACE_FILTERNAMES = "FilterNames";
            public const string XT_CLIENTINTERFACE_FILTERNAME = "Filter";
            public const string XT_CLIENTINTERFACE_SHOW_HELP = "ShowHelp";
            public const string XT_CLIENTINTERFACE_SHOW_2SIDES = "Show2Sides";

            public const string XT_CLIENTINTERFACE_KEY = "KEY";
            public const string XT_CLIENTINTERFACE_CYN = "CYN";
            public const string XT_CLIENTINTERFACE_MAG = "MAG";
            public const string XT_CLIENTINTERFACE_YEL = "YEL";

            public const string XT_CLIENTINTERFACE_METRICDISPLAYS = "MetricDisplays";
            public const string XT_CLIENTINTERFACE_SPEEDDISPLAYFORMAT = "SpeedDisplayFormat";
            public const string XT_CLIENTINTERFACE_IMPCOUNTINGMETHOD = "ImpCountingMethod";
            public const string XT_MC_SERVER_PATH_CONFIG = "MC_SERVER_PATH_CONFIG";
            public const string XT_MC_CLIENT_PATH_CONFIG = "MC_CLIENT_PATH_CONFIG";
            public const string XT_MCSYSTEM_PATH = "SYSTEM_PATH";
            public const string XT_MCAPPLICATIONDATA_PATH = "DATA_PATH";
            public const string XT_MCLOG_PATH = "LOG_PATH";
            public const string XT_MCSYSTEM_RUNTIME_PATH = "SYSTEM_RUNTIME_PATH";
            public const string XT_MCJOBS_XML_PATH = "JOBS_XML_PATH";
            public const string XT_MCJOBS_ARCHIVE_PATH = "JOBS_ARCHIVE_PATH";
            public const string XT_FORM_TEMPLATE_PATH = "FORM_TEMPLATE_PATH";     

            public const string XT_MCCLIENT_ACT_OPTIONS_PATH = "MCCLIENT_ACT_OPTIONS_PATH";//16062
            public const string XT_MCCLIENT_HELP_PATH = "MCCLIENT_HELP_PATH";
	        // 18-Mar-2014, Chetan, Modified for supporting Keyboard Layouts folder.
            public const string XT_MCCLIENT_KEYBOARD_LAYOUTS_PATH = "MCCLIENT_KBD_FILES_PATH";
            public const string XT_MCCLIENT_LOG_FILES_PATH = "MCCLIENT_LOG_FILES_PATH";

            // Airbar configuration XML tags
            public const string XT_AIR_BARS = "PRESS_AIR_BARS";
            public const string XT_AIR_BAR = "AIR_BAR";

            // Product options
            public const string XT_PRODUCT_OPTIONS = "PRODUCT_OPTIONS";
            public const string XT_JOBS_MANAGEMENT_OPTION = "JOBS_MANAGEMENT";
            public const string XT_KEEP_LAST_VERSION_PROFILES_OPTION = "KEEP_ONLY_LAST_VERSION_PROFILES";
            public const string XT_PROMPT_ZAI_NEEDED_ON_SERVER_RESTART = "PROMPT_ZEROALLINKER_ON_SERVER_RESTART";
            // 23-Feb-16, Mark C, WI68970: Add support for Mercury Newspaper Navigation View option
            public const string XT_NEWSPAPER_NAVIGATION_VIEW_OPTION = "NEWSPAPER_NAVIGATION_VIEW";
            public const string XT_LABEL_TOWERS_WITH_NUMBERS_OPTION = "LABEL_TOWERS_WITH_NUMBERS"; //WI81328

            //WI41821: Mercury Server configuration
            public const string XT_MERCURY_SERVER_CONFIG = "MERCURY_SERVER_CONFIG";
            public const string XT_MERCURY_SERVER = "MERCURY_SERVER";

            //WI67306: Mercury Server options
            public const string XT_MERCURY_SERVER_OPTIONS = "MERCURY_SERVER_OPTIONS";
            public const string XT_SERVER_LOGDATA = "LOGDATA";
            public const string XT_SERVER_LOGIODATA = "LOGIODATA";
            public const string XT_SERVER_SIMULATION = "SIMULATION";
            public const string XT_SERVER_CPU_AFFINITY = "CPU_AFFINITY";
            public const string XT_SERVER_SPU_NOSTRESS = "SPU_NOSTRESS";
            public const string XT_SERVER_SPU3DEBUG = "SPU3DEBUG";            
            public const string XT_SERVER_IGNORE_SPU_RESPONSE = "IGNORE_SPU_RESPONSE"; 
            public const string XT_SERVER_FIXCOMPORTS = "FIXCOMPORTS";

            // WI177003: Mercury GUI Options
            public const string XT_MERCURY_GUI_OPTIONS = "MERCURY_GUI_OPTIONS";
            public const string XT_GUI_REMOVAL_RUN_BUTTON = "SHOW_REMOVAL_RUN_BUTTON";
            public const string XT_GUI_INVERT_PRESET_PROFILE_BUTTON = "SHOW_INVERT_PRESET_PROFILE_BUTTON";
            public const string XT_GUI_DEF_THUMBNAIL_SIZE = "DEFAULT_THUMBNAIL_SIZE";
            public const string XT_GUI_SAVE_AND_UNDO_SWEEP_SETTINGS = "SAVE_AND_UNDO_SWEEP_SETTINGS";
            public const string XT_GUI_SAVE_AND_UNDO_WATER_SETTINGS = "SAVE_AND_UNDO_WATER_SETTINGS";
            public const string XT_GUI_AUTO_RUN_DELAY_TIME = "AUTO_RUN_DELAY_TIME";

            // WI102725: AVT PLC Configuration
            public const string XT_MERCURY_AVT_PLC_CONFIG = "MERCURY_AVT_PLC_CONFIG";
            public const string XT_AVT_PLC = "AVT_PLC";
            // Sweep configuration members
            public const string XT_SWEEP_CONFIG = "SWEEP_CONFIG";
            public const string XT_SWEEP_SURGE = "SWEEP_SURGE";
            public const string XT_SWEEP_DEF_ONTIME = "SWEEP_DEF_ONTIME";
            public const string XT_SWEEP_MAX_ONTIME = "SWEEP_MAX_ONTIME";
            public const string XT_SWEEP_SURGE_TRIM = "SWEEP_SURGE_TRIM";
            public const string XT_SWEEP_METHOD_OF_SURGE = "SWEEP_METHOD_OF_SURGE";
            public const string XT_SWEEP_SURGE_DEVICE = "SWEEP_SURGE_DEVICE";
            public const string XT_SWEEP_RAMPING = "SWEEP_RAMPING";
            public const string XT_SWEEP_TRIM_INFLUENCE = "SWEEP_TRIM_INFLUENCE";
            public const string XT_SWEEP_FUNC_CONTROL = "SWEEP_FUNC_CONTROL";
            public const string XT_SWEEP_TRIM_MANUAL = "SWEEP_TRIM_MANUAL";
            public const string XT_SWEEP_MASTER_CONTROL = "SWEEP_MASTER_CONTROL";
            public const string XT_SWEEP_MASTER_INFLUENCE = "SWEEP_MASTER_INFLUENCE";
            public const string XT_SWEEP_DUCT_HOLDOFF = "SWEEP_DUCT_HOLDOFF";
            public const string XT_SWEEP_DUCT_RANGES = "SWEEP_DUCT_RANGES";
            public const string XT_SWEEP_DUCT_RANGE = "SWEEP_DUCT_RANGE";
            public const string XT_SWEEP_INKER_WASH_UP = "SWEEP_INKER_WASH_UP";
            public const string XT_SWEEP_INK_MASTER_SETTING = "SWEEP_INK_MASTER_SETTING";
            // 21-Dec-17, Mark C, WI145675: Sweep Ramp curve parameters 
            public const string XT_SWEEP_SPEED_INFLUENCE = "SWEEP_SPEED_INFLUENCE";
            public const string XT_SWEEP_BASE_CURVE_MAX = "SWEEP_BASE_CURVE_MAX";
            public const string XT_SWEEP_MOTOR_CLAMP_MIN = "SWEEP_MOTOR_CLAMP_MIN";
            public const string XT_SWEEP_MOTOR_CLAMP_MAX = "SWEEP_MOTOR_CLAMP_MAX";
            public const string XT_SWEEP_OPTIONS = "SWEEP_OPTIONS";
            public const string XT_SWEEP_HARDWARE_INTERFACE_TYPE = "SWEEP_HARDWARE_INTERFACE_TYPE";
            public const string XT_SWEEP_ENABLE_DIGITAL_CTRL_CANCEL = "SWEEP_ENABLE_DIGITAL_CTRL_CANCEL";
            // 18-Feb-18: Recall Form Options of Sweep control
            public const string XT_SWEEP_RECALL_FORM_OPTIONS = "SWEEP_RECALL_FORM_OPTIONS";
            public const string XT_SWEEP_TRIM_SELECTED = "SWEEP_TRIM_SELECTED";
            public const string XT_SWEEP_FUNC_SETTING_SELECTED = "SWEEP_FUNC_SETTING_SELECTED";
            public const string XT_SWEEP_DUCT_SETTING_SELECTED = "SWEEP_DUCT_SETTING_SELECTED";

            // Water configuration members
            public const string XT_WATER_CONFIG = "WATER_CONFIG";
            public const string XT_WATER_FLOOD = "WATER_FLOOD";
            public const string XT_WATER_DEF_ONTIME = "WATER_DEF_ONTIME";
            public const string XT_WATER_MAX_ONTIME = "WATER_MAX_ONTIME";
            public const string XT_WATER_FLOOD_TRIM = "WATER_FLOOD_TRIM";
            public const string XT_WATER_METHOD_OF_FLOOD = "WATER_METHOD_OF_FLOOD";
            public const string XT_WATER_FLOOD_DEVICE = "WATER_FLOOD_DEVICE";
            public const string XT_WATER_RAMPING = "WATER_RAMPING";
            public const string XT_WATER_TRIM_INFLUENCE = "WATER_TRIM_INFLUENCE";
            public const string XT_WATER_FUNC_CONTROL = "WATER_FUNC_CONTROL";
            public const string XT_WATER_TRIM_MANUAL = "WATER_TRIM_MANUAL";
            public const string XT_WATER_MASTER_CONTROL = "WATER_MASTER_CONTROL";
            public const string XT_WATER_MASTER_INFLUENCE = "WATER_MASTER_INFLUENCE";
            public const string XT_WATER_MASTER_SETTING = "WATER_MASTER_SETTING";
            // 21-Dec-17, Mark C, WI145675: Water Ramp curve parameters 
            public const string XT_WATER_SPEED_INFLUENCE = "WATER_SPEED_INFLUENCE";
            public const string XT_WATER_BASE_CURVE_MAX = "WATER_BASE_CURVE_MAX";
            public const string XT_WATER_MOTOR_CLAMP_MIN = "WATER_MOTOR_CLAMP_MIN";
            public const string XT_WATER_MOTOR_CLAMP_MAX = "WATER_MOTOR_CLAMP_MAX";
            public const string XT_WATER_OPTIONS = "WATER_OPTIONS";
            public const string XT_WATER_HARDWARE_INTERFACE_TYPE = "WATER_HARDWARE_INTERFACE_TYPE";
            public const string XT_WATER_ENABLE_DIGITAL_CTRL_CANCEL = "WATER_ENABLE_DIGITAL_CTRL_CANCEL";
            // 18-Feb-18, Recall Form Options of Water control
            public const string XT_WATER_RECALL_FORM_OPTIONS = "WATER_RECALL_FORM_OPTIONS";
            public const string XT_WATER_TRIM_SELECTED = "WATER_TRIM_SELECTED";
            public const string XT_WATER_FUNC_SETTING_SELECTED = "WATER_FUNC_SETTING_SELECTED";
            // Press Speed configuration members
            public const string XT_PRESS_SPEED_CONFIG = "PRESS_SPEED_CONFIG";
            public const string XT_MIN_PRESS_SPEED = "MIN_PRESS_SPEED";
            public const string XT_MAX_PRESS_SPEED = "MAX_PRESS_SPEED";
            public const string XT_DISPLAY_PRESS_SPEED_OPTION = "DISPLAY_PRESS_SPEED_OPTION";
            // Plate Info configuration members
            public const string XT_PLATE_INFO_CONFIG = "PLATE_INFO_CONFIG";
            public const string XT_IMPRESSION_LENGTH_OF_PLATE = "IMPRESSION_LENGTH_OF_PLATE";
            public const string XT_NUM_OF_PLATES_IN_FOUNTAIN = "NUM_OF_PLATES_IN_FOUNTAIN";
            // AVT PLC Voltage configuration members
            public const string XT_MIN = "MIN";
            public const string XT_MAX = "MAX";
            public const string XT_PRESS_SPEED_INPUT_VOLTAGE = "PRESS_SPEED_INPUT_VOLTAGE";
            public const string XT_SWEEP_INPUT_VOLTAGE = "SWEEP_INPUT_VOLTAGE";
            public const string XT_WATER_OUTPUT_VOLTAGE = "WATER_OUTPUT_VOLTAGE";
            // WI182050 - AVT PLC - Sync Sweep / Water console values with OnPress values
            public const string XT_SYNC_SWEEP_WATER_CONSOLE_VALUES = "SYNC_SWEEP_WATER_CONSOLE_VALUES";
            
            // Register configuration members
            public const string XT_REGISTER_CONFIG = "REGISTER_CONFIG";
            public const string XT_REGISTER_OPER_ON_LEFT = "OperatorOnLeft";
            public const string XT_REGISTER_ADVANCE_ON_TOP = "AdvanceOnTop";
            
            #endregion
        }
        private void btnAddSPU_Click(object sender, EventArgs e)
        {

        }

        private void gpSPUConfig_Enter(object sender, EventArgs e)
        {

        }

        /// <![CDATA[
        //======================================================================================
        /// <Function>createMcNSiteFile()</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-10-2008</Date>
        /// <summary>
        /// Creats the site file
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11891 
        /// Hema Dt: 05/27/2009 MT: 13405
        /// LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// Hema MT: 13873  Dt: 09/01/09, Add Wide Press parameters   
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// Suresh MT: 14611  Dt: Mar-25-10
        /// Suresh, MAY-07-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility
        /// Hema, SEP-02-2010, ENH 16257, to implement Password to the config view
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// Hema, JAN-14-2011 ENH: 16254, to change the open sweep up to by percentage
        /// MarkC Jun 20, 2011 - MT 16792 - new PLC type Dtoa Sweep and Water settings
        /// 07-Feb-12, Mark C, MT 17529: Added support for AutoZeroServos option
        /// 05-Mar-12, Mark C, MT 17637: Added support for ShowHelp option under Client interface options
        /// 20-Mar-12, BEttinger, MT 17624: Added support for Show2SidesThumbs option under Client interface options
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// 13-AUG-12, Mark C, WI28788: Added support to write AutoZeroSettings into site XML file and also moved
        ///         AutoZeroServos option ahead in the site XML
        /// 10-Sep-12, Mark C, WI 29423: Added support for new parameter 'DelayForFountainClose' in
        ///         Auto Zero settings
        ///         03-Apr-13, Mark C, WI30603: Disable Sweep / Water ports if the fountain
        ///             ports / SPU are more than 6
        ///         23-Apr-13, Mark C, WI30347: Added support for Multi Web Press type
        ///         01-MAY-13, Mark C, WI30684: Removed support for 'Show2Sides' feature. This option is no longer 
        ///           useful since Mercury Client has Summary View available for all press types.
        ///         09-May-13, BEttinger, WI30488: add channel maps for multiple source Auto Zero
        /// 10-Jun-13, Mark C, WI30950: Added support for Product Options >> Jobs Management option 
        /// 05-Sept-13, Mark C, WI31065: Added support for saving Form Template shared name
        ///         Chetan, WI#31061, Added support to write JOBS folder shared name
        /// 23-Oct-13, Mark C, WI33030: Added support for Product Options >> Keep Only Last Version Profiles
        /// 21-Apr-14, Mark C, WI36192: Added support for saving IP Address of SPU3
        /// Apr 25 2014 MarkC WI36833 - fixed the AZ Frq mapping section
        /// 27-May-14, Mark C, WI37511: Added support for Product Options >> Prompt for 'Zero All Inker' needed
        ///     on every restart of Server
        /// 03-Sept-14, Mark C, WI40392: Added support for selecting the type of communication between SPU3 & Server.
        /// 28-Oct-14, Mark C, WI41821: Added support for configuring IP Address and Port number of Mercury Server. 
        /// 06-Jan-2015, spa 51032 Add Imposition data field
        /// 25-Mar-15, Mark C, WI51037: Add support for Tower Press 
        /// 23-Feb-16, Mark C, WI68970: Add support for Mercury Newspaper Navigation View option
        /// 09-Aug-16, Mark C, WI81328: Add support for label Towers with numbers option
        /// 06-Dec-16, Mark C, WI67306: Move Mercury Server options to Site XML file
        /// 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep & Water interfaces
        /// 03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Ramping >> Press Speed parameters
        /// 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        /// 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 16-Oct-18 dlg, (177481) Add AVT PLC support for Manual Register
        /// </History>
        ///=====================================================================================
        /// ]]>
        private void createMcNSiteFile()
        {
            MCPressInfo mcPress = GetCurrentPress();
            if (mcPress == null)
                return;
            SaveFileDialog SaveFileLocation = new SaveFileDialog();
            if (strfilePath != "")
            {
                string message = "File " + strfilePath + " already exists. Do you want to replace it ?";
                string caption = "Save As";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons);
                if (result == DialogResult.No)
                    strfilePath = "";
            }
            if (strfilePath == "")
            {
                //SaveFileDialog SaveFileLocation = new SaveFileDialog();
                //SaveFileLocation.FileName = "";
                SaveFileLocation.FileName = "MC" + m_mcSiteConfigData.SiteNumber.ToString();
                SaveFileLocation.Filter = "(*.xml)|*.xml";
                if (SaveFileLocation.ShowDialog() == DialogResult.OK)
                {
                    m_mcSiteConfigData.SystemConfig = 3;//Save the version as "3" MT 16792 update the version as 3
                    strfilePath = SaveFileLocation.FileName;
                }
                else
                    return;
            }

            try
            {
                // creates the xml file
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(docNode);

                //create the MC System Config node element
                XmlNode MCSystemConfigNode = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_CONFIG);
                XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSYSTEMCONFIG_VERSION);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.SystemConfig);
                MCSystemConfigNode.Attributes.Append(productAttribute);
                doc.AppendChild(MCSystemConfigNode);

                //Creates the site name element
                XmlNode SiteNameNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_SITENAME);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = m_mcSiteConfigData.SiteName;
                SiteNameNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(SiteNameNode);

                //Creates the site Number element
                XmlNode SiteNumNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_SITENUMBER);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.SiteNumber);
                SiteNumNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(SiteNumNode);


                //Creates the MC Press element
                XmlNode McPressNode = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_PRESSES);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.PressCount());
                McPressNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(McPressNode);


                // Comment

                XmlComment xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_MULTIPLE);
                McPressNode.AppendChild(xmlComment);


                //Creates the MC Press Name element
                XmlNode McPressNameNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_PRESS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                productAttribute.Value = mcPress.PressName;
                McPressNameNode.Attributes.Append(productAttribute);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TYPE);
                productAttribute.Value = Convert.ToString(mcPress.PressType);
                McPressNameNode.Attributes.Append(productAttribute);
                McPressNode.AppendChild(McPressNameNode);

                // Add information for CLC
                XmlElement mcCLCCQElement = doc.CreateElement( XMLNodeDictionary.XT_CQ_CLC_CONFIGURATION );
                XmlAttribute isConfiguredForCLCOperationAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_CQ_CLC_ISCONFIGURED );
                isConfiguredForCLCOperationAttribute.Value = Convert.ToString( mcPress.IsCLCOEM );
                mcCLCCQElement.Attributes.Append( isConfiguredForCLCOperationAttribute );

                if( mcPress.IsCLCOEM )
                {
                    // Add the ip address and port
                    XmlAttribute cqIPAddressAddressAttribute = doc.CreateAttribute( XMLNodeDictionary.IP_ADDRESS );
                    cqIPAddressAddressAttribute.Value = mcPress.CLCIPAddress;
                    mcCLCCQElement.Attributes.Append( cqIPAddressAddressAttribute );

                    XmlAttribute cqPortAttribute = doc.CreateAttribute( XMLNodeDictionary.PORT );
                    cqPortAttribute.Value = Convert.ToString( mcPress.CLCCQPort );
                    mcCLCCQElement.Attributes.Append( cqPortAttribute );
                }

                McPressNameNode.AppendChild( mcCLCCQElement );

                //Create Press width element
                XmlNode McPressWidthNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_WIDTH);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.PressWidth);//"137.7";
                McPressWidthNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(McPressWidthNode);

                //Create Press Folder element
                XmlNode McPressFolderNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_FOLDERS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(mcPress.FolderCount);
                McPressFolderNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(McPressFolderNode);

                // Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_MULTIPLE);
                McPressFolderNode.AppendChild(xmlComment);

                //Create Press Folder Name element
                XmlNode McPressFolderNameNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_FOLDER);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                for (byte byFolder = 0; byFolder < mcPress.PressFolderName.Count; byFolder++)
                {
                    productAttribute.Value = Convert.ToString(mcPress.PressFolderName[byFolder]);
                    McPressFolderNameNode.Attributes.Append(productAttribute);
                    McPressFolderNode.AppendChild(McPressFolderNameNode);
                }

                //Create Press Units element
                XmlNode McPressUnitsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNITS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(mcPress.TotalUnits);
                McPressUnitsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(McPressUnitsNode);

                //Unit information
                for (int iUnit = 0; iUnit < mcPress.TotalUnits; iUnit++)
                {
                    MCPressUnit pressUnit = mcPress.GetUnitAt(iUnit);
                    if (pressUnit == null)
                        continue;
                    // Unit name element
                    XmlNode UnitNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNIT);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = pressUnit.UnitName; ;//"Unit1";
                    UnitNode.Attributes.Append(productAttribute);
                    McPressUnitsNode.AppendChild(UnitNode);

                    // Inkers
                    XmlNode InkerNode = doc.CreateElement(XMLNodeDictionary.XT_INKERS);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                    int iInkerCount = pressUnit.TotalInkers;
                    productAttribute.Value = Convert.ToString(iInkerCount);
                    InkerNode.Attributes.Append(productAttribute);
                    UnitNode.AppendChild(InkerNode);
                    //Comment

                    xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_MULTIPLE);
                    InkerNode.AppendChild(xmlComment);

                    // Inker Name
                    for (int iInker = 0; iInker < iInkerCount; iInker++)
                    {
                        MCInker mcInker = (MCInker)pressUnit.GetInkerAt(iInker);
                        if (mcInker == null)
                            continue;
                        XmlNode InkerNameNode = doc.CreateElement(XMLNodeDictionary.XT_INKER);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                        productAttribute.Value = mcInker.InkerName;//"Upper1";
                        InkerNameNode.Attributes.Append(productAttribute);
                        InkerNode.AppendChild(InkerNameNode);

                        // Key 1 Operator side
                        XmlNode Key1OperatorSideNode = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_KEY1OPERATORSIDE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        if (mcInker.FirstKeyOperatorSide)
                        {
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                        }
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                        Key1OperatorSideNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(Key1OperatorSideNode);

                        if( mcPress.PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
                        {
                            // Is Inker on the left side of CIC - Common Impression Cylinder
                            XmlNode leftSide = doc.CreateElement( XMLNodeDictionary.XT_INKER_LEFT_SIDE );

                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = mcInker.IsLeftSide.ToString().ToUpper();
                            leftSide.Attributes.Append( productAttribute );
                            InkerNameNode.AppendChild( leftSide );
                        }
                        else
                        {
                            // Upper Lower Inker Node 
                            XmlNode UpperLowerInkerNode = doc.CreateElement( XMLNodeDictionary.XT_MCUNIT_INKER_SIDE );

                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = mcInker.UpperLowerInker;
                            UpperLowerInkerNode.Attributes.Append( productAttribute );
                            InkerNameNode.AppendChild( UpperLowerInkerNode );
                        }

                        // Servo Turns
                        XmlNode ServoTurnsNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.ServoTurns);
                        ServoTurnsNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(ServoTurnsNode);

                        // INKER KEYS
                        XmlNode InkerKeysNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_KEYS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                        int iTotalKeys = mcInker.TotalKeys;
                        productAttribute.Value = Convert.ToString(iTotalKeys);
                        InkerKeysNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(InkerKeysNode);

                        //Comment

                        xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_KEY_WIDTH_IN_MM);
                        InkerKeysNode.AppendChild(xmlComment);

                        for (int iInkerKey = 0; iInkerKey < iTotalKeys; iInkerKey++)
                        {
                            // INKER KEY width
                            XmlNode InkerKeyNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_KEY);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_UNIT_INKER_ATTRIB_WIDTH);
                            productAttribute.Value = Convert.ToString(mcInker.EachKeyWidth);
                            InkerKeyNode.Attributes.Append(productAttribute);
                            InkerKeysNode.AppendChild(InkerKeyNode);
                        }

                        // min value
                        XmlNode MinValueNode = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MINVALUE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.MinConsoleVal);
                        MinValueNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(MinValueNode);

                        // Max Value 
                        XmlNode MaxValueNode = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.MaxConsoleVal);
                        MaxValueNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(MaxValueNode);

                        // Servo Banks 
                        XmlNode ServoBanksNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                        productAttribute.Value = Convert.ToString(mcInker.TotalBanks);
                        ServoBanksNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(ServoBanksNode);

                        for (int iServoBank = 0; iServoBank < mcInker.ServoBanks.Count; iServoBank++)
                        {
                            // Servo Bank 
                            XmlNode ServoBankNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANK);
                            ServoBanksNode.AppendChild(ServoBankNode);

                            // Servo address
                            XmlNode ServoAddressNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME);
                            ServoBanks ServoBank = (ServoBanks)mcInker.ServoBanks[iServoBank];
                            if (null == ServoBank)
                            {
                                continue;
                            }
                            productAttribute.Value = ServoBank.SPUName;
                            ServoAddressNode.Attributes.Append(productAttribute);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT);
                            productAttribute.Value = Convert.ToString(ServoBank.PortOnSPU);
                            ServoAddressNode.Attributes.Append(productAttribute);
                            ServoBankNode.AppendChild(ServoAddressNode);

                            // Total Keys to Control
                            XmlNode ServoTotalKeysNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            if (IsWidePress)
                            {
                                productAttribute.Value = Convert.ToString(ServoBank.TotalKeys);
                            }
                            else
                            {
                                productAttribute.Value = mcInker.TotalKeys.ToString();
                            }
                            ServoTotalKeysNode.Attributes.Append(productAttribute);
                            ServoBankNode.AppendChild(ServoTotalKeysNode);

                            // Start from key
                            XmlNode StartFromKeyNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(ServoBank.StartKey);
                            StartFromKeyNode.Attributes.Append(productAttribute);
                            ServoBankNode.AppendChild(StartFromKeyNode);


                            // Comment

                            xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_KEY_MEMBER_STARTS_FROM);
                            StartFromKeyNode.AppendChild(xmlComment);
                            //
                            if (IsWidePress)
                            {
                                // Bank Inverted
                                XmlNode BankInvertedNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_BANK_INVERTED);

                                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                                if (ServoBank.BankInverted)
                                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                                else
                                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                                BankInvertedNode.Attributes.Append(productAttribute);
                                ServoBankNode.AppendChild(BankInvertedNode);
                            }
                        }

                        // Inverted
                        XmlNode InvertedNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        if (mcInker.Inverted)
                        {
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                        }
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;

                        InvertedNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(InvertedNode);

                        // Linear Table Index
                        XmlNode LinearTableIndexNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = "1";
                        LinearTableIndexNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(LinearTableIndexNode);

                        // Linear Table Size
                        XmlNode LinearTableSizeNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.LTSize);
                        LinearTableSizeNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(LinearTableSizeNode);

                        // CIP3 Image Rotate degress
                        XmlNode ImageRotationNode = doc.CreateElement(XMLNodeDictionary.XT_CIP3_IMAGE_ROTATE_DEGREES);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.CIP3ImageRotateDegrees);
                        ImageRotationNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(ImageRotationNode);

                        // CIP3 Data Rotation
                        XmlNode DataRotationNode = doc.CreateElement(XMLNodeDictionary.XT_CIP3_DATA_ROTATION);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.CIP3DataRotation);
                        DataRotationNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(DataRotationNode);

                        // Append Sweep Input Voltages ( Min & Max ) and Water Output Voltages ( Min & Max ), if AVT PLC is configured
                        AppendAVTPLCSweepInputVoltages( mcInker, doc, InkerNameNode );
                        AppendAVTPLCWaterOutputVoltages( mcInker, doc, InkerNameNode );

                        // Append Register Inker configuration, if AVT PLC Register is configured
                        AppendAVTPLCRegisterInkerConfig( mcInker, doc, InkerNameNode );
                    }
                }

                //Create No.Of display keys node
                XmlNode DisplayKeys = doc.CreateElement(XMLNodeDictionary.XT_KEYS_DISPLAY_ON_CLIENT);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = tbDisplayZones.Text.ToString();
                DisplayKeys.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(DisplayKeys);

                //int iNumUnitGroups = mcPress.UnitGroups.Count;
                int iNumUnitGroups = 1;

                //Create Press Unit Groups
                XmlNode PressUnitGroupsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNITGROUPS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = "1";
                PressUnitGroupsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PressUnitGroupsNode);
                for (int iUnitGroup = 0; iUnitGroup < iNumUnitGroups; iUnitGroup++)
                {
                    //Create Unit Group
                    XmlNode UnitGroupNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNITGROUP);

                    // productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute = doc.CreateAttribute("Name");
                    //productAttribute.Value = unitGroups.Name;// "G1";
                    productAttribute.Value = "G1";
                    UnitGroupNode.Attributes.Append(productAttribute);
                    PressUnitGroupsNode.AppendChild(UnitGroupNode);

                    //Create UnitGroup _ Mems
                    XmlNode UnitGroup_MemsNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEMS);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                    int iNumUnitGroupMem = 6;//unitGroups.GetNumUnitGroupMem();
                    productAttribute.Value = Convert.ToString(iNumUnitGroupMem);
                    //productAttribute.Value = "6";
                    UnitGroup_MemsNode.Attributes.Append(productAttribute);
                    UnitGroupNode.AppendChild(UnitGroup_MemsNode);

                    for (byte byUnitGroupMember = 1; byUnitGroupMember <= iNumUnitGroupMem; byUnitGroupMember++)
                    {
                        XmlNode UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                        //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                        productAttribute = doc.CreateAttribute("Name");
                        //productAttribute.Value = strUnitMemName; // "Unit1";
                        productAttribute.Value = "Unit" + byUnitGroupMember;
                        UnitGroupMemNode.Attributes.Append(productAttribute);
                        UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);
                    }
                }

                //Create Press_Reelstands
                int iReelstandsCount = mcPress.GetNumReelStands();
                XmlNode Press_ReelstandsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_REELSTANDS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = "1";
                Press_ReelstandsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(Press_ReelstandsNode);

                for (int iReelstand = 0; iReelstand < 1 /*iReelstandsCount */; iReelstand++)
                {
                    ReelStands ReelStand = (ReelStands)mcPress.GetPressReelStandAt(iReelstand);
                    //Create PressReelstand
                    XmlNode PressReelstandNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_REELSTAND);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = "RS01";
                    PressReelstandNode.Attributes.Append(productAttribute);
                    Press_ReelstandsNode.AppendChild(PressReelstandNode);
                }
                //Create Press_Spus

                byte byNumSpus = mcPress.GetNumOfSPUs();
                XmlNode Press_SpusNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_SPUS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(byNumSpus);// "2";
                Press_SpusNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(Press_SpusNode);

                for (byte bySpu = 0; bySpu < byNumSpus; bySpu++)
                {
                    //Create SPU 1
                    PressSPU Spu = (PressSPU)mcPress.GetSPUAt(bySpu);
                    if (Spu == null)
                        continue;
                    XmlNode SpuNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_SPU);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = Spu.SPUName;
                    SpuNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT);
                    productAttribute.Value = Spu.SPUCommPort;
                    SpuNode.Attributes.Append(productAttribute);
					// SPU - IP Address
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.IP_ADDRESS);
                    productAttribute.Value = Spu.IPAddress;
                    SpuNode.Attributes.Append(productAttribute);

                    //WI40392 - COMM Type - SERIAL OR ETHERNET
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_COMM_TYPE);
                    productAttribute.Value = Spu.COMMType;
                    SpuNode.Attributes.Append(productAttribute);
                    
                    Press_SpusNode.AppendChild(SpuNode);
                }

                XmlNode Press_ClientInterfaceNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CLIENTINTERFACE);
                McPressNameNode.AppendChild(Press_ClientInterfaceNode);

                //Create Client_Passwords
                XmlNode Client_PasswordsNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLIENTPASSWORDS);
                Press_ClientInterfaceNode.AppendChild(Client_PasswordsNode);

                //Create Level1
                // Get the password from
                string password = this.tbConfigurationPassword.Text;
                // encrypt the password
                password = Encrypt(password);
                XmlNode Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL1);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = password;
                Level1Node.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(Level1Node);

                //Comment  "Password to Open the System Configurations"                
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_SYSTEM_CONFIGURATION_PASSWORD);
                Level1Node.AppendChild(xmlComment);

                //Create Level2
                // Get the password 
                password = this.tbDiagnosticPassword.Text;
                // encrypt the password
                password = Encrypt(password);
                Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL2);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = password;
                Level1Node.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(Level1Node);

                //Comment "Password to Open the Diagnostic Operations"
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_DIAGNOSTIC_PASSWORD);
                Level1Node.AppendChild(xmlComment);

                //Create Level3
                // Get the password 
                password = this.tbExitPassword.Text;
                // encrypt the password
                password = Encrypt(password);
                Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL3);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = password;
                Level1Node.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(Level1Node);

                //Comment "Password to Exit the MC3 Application"
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_EXIT_PASSWORD);
                Level1Node.AppendChild(xmlComment);

                //Create Option Levels
                XmlNode OptionLevelsNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_COPTIONLEVELS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0";
                OptionLevelsNode.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(OptionLevelsNode);

                //Create Factory 
                XmlNode FactoryNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CFACTORY);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "59431   ";
                FactoryNode.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(FactoryNode);

                //Create Installer
                XmlNode InstallerNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CINSTALLER);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "675921";
                InstallerNode.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(InstallerNode);
                // Get the password from
                password = this.tbRuntimePassword.Text;
                password = Encrypt(password);
                //Create AdvUser
                XmlNode AdvUserNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CADVUSER);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = password;
                AdvUserNode.Attributes.Append(productAttribute);
                Client_PasswordsNode.AppendChild(AdvUserNode);

                //Comment "Password to Open the Runtime Options"
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_RUNTIME_OPTIONS_PASSWORD);
                AdvUserNode.AppendChild(xmlComment);

                //Create Data_File_Pathes
                XmlNode Data_File_PathesNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLIENTDATAFILEPATHES);
                Press_ClientInterfaceNode.AppendChild(Data_File_PathesNode);

                //Create Remote_Data_Storage
                XmlNode Remote_Data_StorageNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CREMOTEDATASTORAGE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressClientInterface.NetworkPath;
                Remote_Data_StorageNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Remote_Data_StorageNode);

                //Create Local_Data_Storage
                XmlNode Local_Data_StorageNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLOCALDATASTORAGE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressClientInterface.StandardPath;
                Local_Data_StorageNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Local_Data_StorageNode);

                //Create Job_Storage_Share_Name
                XmlNode Job_Storage_Share_NameNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CJOBSTORAGESHARENAME);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"MC3_JOB_DATA";
                Job_Storage_Share_NameNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Job_Storage_Share_NameNode);

                //Create JMV_Job_Storage_Share_Name
                XmlNode JMV_Job_Storage_Share_NameNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_JMVJOBS_STORAGESHARENAME);
                
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"MC3_JOBS_DATA";
                JMV_Job_Storage_Share_NameNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(JMV_Job_Storage_Share_NameNode);


                //Create Archive Job Storage Name //WI#30968 provide archives share name
                XmlNode Job_Archive_Storage_ShareName = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERCACE_CJOBARCHIVESTORAGESHARENAME);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"MC3_ARCHIVE_DATA";
                Job_Archive_Storage_ShareName.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Job_Archive_Storage_ShareName);

                //Create XML element for Form Template shared name
                XmlNode formTemplateSharedName = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FORM_TEMPLATE_STORAGE_SHARENAME);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"MC3_TEMPLATE_DATA";
                formTemplateSharedName.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(formTemplateSharedName);

                //Create Client_Backup_Drive
                XmlNode Client_Backup_DriveNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CCLIENTBACKUPDRIVE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "D:";
                Client_Backup_DriveNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Client_Backup_DriveNode);

                //Create DisplayOption_Top
                XmlNode DisplayOption_TopNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_DISPLAYOPTIONTOP);
                Press_ClientInterfaceNode.AppendChild(DisplayOption_TopNode);

                //Create OperatorOnLeft
                XmlNode OperatorOnLeftNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_OPERATORONLEFT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "TRUE";
                OperatorOnLeftNode.Attributes.Append(productAttribute);
                DisplayOption_TopNode.AppendChild(OperatorOnLeftNode);

                //Create WebDirectionUp
                XmlNode WebDirectionUpNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_WEBDIRECTIONUP);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "FALSE";
                WebDirectionUpNode.Attributes.Append(productAttribute);
                DisplayOption_TopNode.AppendChild(WebDirectionUpNode);

                //Create DisplayKeyLeftToRight
                XmlNode DisplayKeyLeftToRightNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_DISPLAYKEYLEFTTORIGHT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "TRUE";
                DisplayKeyLeftToRightNode.Attributes.Append(productAttribute);
                DisplayOption_TopNode.AppendChild(DisplayKeyLeftToRightNode);
                //Create DisplayOption_Bottom
                XmlNode DisplayOption_BottomNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_DISPLAYOPTIONBOT);
                Press_ClientInterfaceNode.AppendChild(DisplayOption_BottomNode);

                //Create OperatorOnLeft
                OperatorOnLeftNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_OPERATORONLEFT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "TRUE";
                OperatorOnLeftNode.Attributes.Append(productAttribute);
                DisplayOption_BottomNode.AppendChild(OperatorOnLeftNode);

                //Create WebDirectionUp
                WebDirectionUpNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_WEBDIRECTIONUP);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "FALSE";
                WebDirectionUpNode.Attributes.Append(productAttribute);
                DisplayOption_BottomNode.AppendChild(WebDirectionUpNode);

                //Create DisplayKeyLeftToRight
                DisplayKeyLeftToRightNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_DISPLAYKEYLEFTTORIGHT);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = "FALSE";
                DisplayKeyLeftToRightNode.Attributes.Append(productAttribute);
                DisplayOption_BottomNode.AppendChild(DisplayKeyLeftToRightNode);

                //Create CurrentLanguage
                XmlNode CurrentLanguageNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CURRENTLANGUAGE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressClientInterface.CurrentLanguage;
                CurrentLanguageNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(CurrentLanguageNode);

                //Create FilterNames
                XmlNode FilterNamesNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FILTERNAMES);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = "4";
                FilterNamesNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(FilterNamesNode);

                //Create Filter Key
                XmlNode FilterNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FILTERNAME);
                FilterNode.AppendChild(doc.CreateTextNode("KEY"));
                FilterNamesNode.AppendChild(FilterNode);

                //Create Filter Cyn
                FilterNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FILTERNAME);
                FilterNode.AppendChild(doc.CreateTextNode("CYN"));
                FilterNamesNode.AppendChild(FilterNode);

                //Create Filter MAG
                FilterNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FILTERNAME);
                FilterNode.AppendChild(doc.CreateTextNode("MAG"));
                FilterNamesNode.AppendChild(FilterNode);

                //Create Filter YEL
                FilterNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_FILTERNAME);
                FilterNode.AppendChild(doc.CreateTextNode("YEL"));
                FilterNamesNode.AppendChild(FilterNode);

                //Create MetricDisplays
                XmlNode MetricDisplaysNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_METRICDISPLAYS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.PressClientInterface.MetricsDisplay)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                //productAttribute.Value = Convert.ToString(mcPress.PressClientInterface.MetricsDisplay); // "FALSE";
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                MetricDisplaysNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(MetricDisplaysNode);

                //Create SpeedDisplayFormat
                XmlNode SpeedDisplayFormatNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_SPEEDDISPLAYFORMAT);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.PressClientInterface.SpeedDispFormat);
                SpeedDisplayFormatNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(SpeedDisplayFormatNode);

                //Create ImpCountingMethod
                XmlNode ImpCountingMethodNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_IMPCOUNTINGMETHOD);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.PressClientInterface.ImpCountMethod);
                ImpCountingMethodNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(ImpCountingMethodNode);

                // Create ShowHelp element
                XmlNode showHelpNode = doc.CreateElement( XMLNodeDictionary.XT_CLIENTINTERFACE_SHOW_HELP );
                productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                productAttribute.Value = mcPress.PressClientInterface.ShowHelp.ToString().ToUpper();
                showHelpNode.Attributes.Append( productAttribute );
                Press_ClientInterfaceNode.AppendChild( showHelpNode );

                // Create Show2Sides element
                XmlNode show2SidesNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_SHOW_2SIDES);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE.ToString().ToUpper();
                show2SidesNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(show2SidesNode);

                //Create MCPress_ClientInterface
                XmlNode MCPress_ClientInterface = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_CLIENTINTERFACE);
                McPressNameNode.AppendChild(MCPress_ClientInterface);

                //Create BladeStiffness
                XmlNode BladeStiffnessNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_BLADE_STIFFNESS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.BladeStiffNess);
                BladeStiffnessNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(BladeStiffnessNode);

                //Create MaxNeighbourKeyDelta
                XmlNode MaxNeighbourKeyDeltaNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_MAX_NEIGH_KEY_DELTA);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.MaxKeyDelta);
                MaxNeighbourKeyDeltaNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(MaxNeighbourKeyDeltaNode);

                //Create McClient_Features
                XmlNode McClient_FeaturesNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENTINTERFACE_CLIENTFEATURES);
                MCPress_ClientInterface.AppendChild(McClient_FeaturesNode);

                //Create Cip3Presetting
                XmlNode Cip3PresettingNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_CIP3_PRESETTING);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.MCClientInterface.CIP3Presetting)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                Cip3PresettingNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Cip3PresettingNode);

                //Create NonLinear
                XmlNode NonLinearNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_NON_LINEAR);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //if (mcPress.MCClientInterface.NonLinearBool)
                //    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                //else if (!mcPress.MCClientInterface.NonLinearBool)
                //    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                //else
                productAttribute.Value = mcPress.MCClientInterface.NonLinear.ToString();
                NonLinearNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(NonLinearNode);

                //Create BladeCompensation
                XmlNode BladeCompensationNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_BLADE_COMPENSATION);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.BladeCompensation); // "TRUE";
                if (mcPress.MCClientInterface.BladeCompensation)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                BladeCompensationNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(BladeCompensationNode);


                //Create MeterOffset
                XmlNode MeterOffsetNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_METER_OFFSET);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.MCClientInterface.MeterOffset)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                MeterOffsetNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(MeterOffsetNode);

                //Create Sweep_Control
                XmlNode Sweep_ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_SWEEP_CONTROL);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);                
                if ( mcPress.MCClientInterface.SweepControl )
                {
                    // Enable Sweep, if Sweep is controlled by PLC (OR)
                    // Number of fountain ports on SPU is <= 6.
                    if ( ( mcPress.MaxFountainPortCountPerSPU <= 6 ) ||
                         ( sweepConfiguration == DefineAndConst.ControlTypes.PLC ) )
                    {
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                    }
                    else
                    {
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                    }
                }
                else
                {
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                }
                Sweep_ControlNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Sweep_ControlNode);

                //Create Water_Control
                XmlNode Water_ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_WATER_CONTROL);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if ( mcPress.MCClientInterface.WaterControl )
                {
                    // Enable Water, if Water is controlled by PLC (OR)
                    // Number of fountain ports on SPU is <= 6. 
                    if( ( mcPress.MaxFountainPortCountPerSPU <= 6  ) ||
                        ( waterConfiguration == DefineAndConst.ControlTypes.PLC ) )
                    {
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                    }
                    else
                    {
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                    }
                }
                else
                {
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                }
                Water_ControlNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Water_ControlNode);

                //Create LinearTable
                XmlNode LinearTableNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_LINEAR_TABLE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.PATH);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.Linear);
                productAttribute.Value = mcPress.MCClientInterface.NFSTableLinearPath;
                LinearTableNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(LinearTableNode);

                //Create NonLinearTable
                XmlNode NonLinearTableNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_NON_LINEAR_TABLE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.PATH);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.NonLinear);
                productAttribute.Value = mcPress.MCClientInterface.NFSTableNonLinearPath;
                NonLinearTableNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(NonLinearTableNode);

                //Create DefaultOffset
                XmlNode DefaultOffsetNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_DEFAULT_OFFSET);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.DefaultOffset);
                DefaultOffsetNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(DefaultOffsetNode);

                //Create ServoPulsesZoneAtZero
                XmlNode ServoPulsesZoneAtZeroNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_SERVO_PULSES_ZONE_AT_ZERO);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.ServoPulsesZoneAtZero);
                ServoPulsesZoneAtZeroNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(ServoPulsesZoneAtZeroNode);

                //Create PressZeroBackOffInPulses
                XmlNode PressZeroBackOffInPulsesNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_ZERO_BACKOFF);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.PressZeroBackoffInPulses);
                PressZeroBackOffInPulsesNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(PressZeroBackOffInPulsesNode);

                    // Create Wide Press
                XmlNode WidePress = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENTINTERFACE_WIDEPRESS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.MCClientInterface.WidePress)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                WidePress.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(WidePress);

                // Create Funny Fountians
                XmlNode FunnyFountains = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENTINTERFACE_FUNNY_FOUNTAINS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.MCClientInterface.FunnyFountains)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                FunnyFountains.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(FunnyFountains);

                // Create Virtual Inkers
                XmlNode VirtualInkers = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENTINTERFACE_VIRTUAL_INKERS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.MCClientInterface.VirtualInkers)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                VirtualInkers.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(VirtualInkers);

                //Create Press_Console_Zones_NumOfZones
                XmlNode Press_Console_Zones_NumOfZonesNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CONSOLE_ZONES);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_NUM_ZONES);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.NumberOfZones);
                Press_Console_Zones_NumOfZonesNode.Attributes.Append(productAttribute);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_OCU_ZONE_WIDTH);                
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.ZoneWidth);
                Press_Console_Zones_NumOfZonesNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(Press_Console_Zones_NumOfZonesNode);

                //Create MinValue Node
                XmlNode MinValueNode1 = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MINVALUE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.MinValue);
                MinValueNode1.Attributes.Append(productAttribute);
                Press_Console_Zones_NumOfZonesNode.AppendChild(MinValueNode1);

                //Create MaxValue Node
                XmlNode MaxValueNode1 = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.MaxValue);
                MaxValueNode1.Attributes.Append(productAttribute);
                Press_Console_Zones_NumOfZonesNode.AppendChild(MaxValueNode1);

                //Create Auto Test Node
                XmlNode AutoTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_TEST);
                McPressNameNode.AppendChild(AutoTestNode);

                //Create Total Number of SPUs To test Node
                XmlNode TotalSPUsToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TOTAL_SPUS_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.TotalSpusToTest);
                TotalSPUsToTestNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(TotalSPUsToTestNode);

                //Create Total Number of Units To test Node
                XmlNode TotalUnitsToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TOTAL_UNITS_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.TotalUnitsToTest);
                TotalUnitsToTestNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(TotalUnitsToTestNode);

                //Create Total Number of Servos To test Node
                XmlNode TotalServosToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TOTAL_SERVOS_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.TotalServosToTest);
                TotalServosToTestNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(TotalServosToTestNode);

                //Create Close Keys Up To Node
                XmlNode CloseKeysUpToNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CLOSE_KEYS_UP_TO);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.CloseKeysUpTo);
                CloseKeysUpToNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(CloseKeysUpToNode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_CLOSE_KEYS_POSITION);
                CloseKeysUpToNode.AppendChild(xmlComment);

                //Create Time Delay Node
                XmlNode TimeDelayNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TIME_DELAY);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.TimeDelay);
                TimeDelayNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(TimeDelayNode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_UTILITY_TEST_TIME_DELAY);
                TimeDelayNode.AppendChild(xmlComment);

                //Create Number Of Cycles Node
                XmlNode NumberOfCyclesNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_NUMBER_OF_CYCLES);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.NumberOfCycles);
                NumberOfCyclesNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(NumberOfCyclesNode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_UTILITY_TEST_NUMBER_OF_CYCLES);
                NumberOfCyclesNode.AppendChild(xmlComment);

                //Create Loop Type Node
                XmlNode LoopTypeNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_LOOP_TYPE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.LoopType);
                LoopTypeNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(LoopTypeNode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_UTILITY_TEST_LOOP_TYPE);
                LoopTypeNode.AppendChild(xmlComment);

                //Create Open Keys Node
                XmlNode OpenKeysUpToNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_OPEN_KEYS_UP_TO);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.AutoTest.OpenKeysUpTo);
                OpenKeysUpToNode.Attributes.Append(productAttribute);
                AutoTestNode.AppendChild(OpenKeysUpToNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_OPEN_KEYS_UP_TO);
                OpenKeysUpToNode.AppendChild(xmlComment);

                //Create Sweep Test Node
                XmlNode SweepTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_SWEEP_TEST);
                McPressNameNode.AppendChild(SweepTestNode);

                //Create Total Number of SPUs To test Node
                TotalSPUsToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TOTAL_SPUS_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.TotalSpusToTest);
                TotalSPUsToTestNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(TotalSPUsToTestNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.C0MMENT_TOTAL_SPUS_TO_TEST);
                TotalSPUsToTestNode.AppendChild(xmlComment);

                //Create Which Port To test Node
                XmlNode WhichPortToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_WHICH_PORT_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.WhichPortToTest);
                WhichPortToTestNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(WhichPortToTestNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.C0MMENT_WHICH_PORT_TO_TEST);
                WhichPortToTestNode.AppendChild(xmlComment);

                //Create Total Sweep To test Node
                XmlNode TotalSweepToTestNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TOTAL_SWEEP_TO_TEST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.TotalSweepsToTest);
                TotalSweepToTestNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(TotalSweepToTestNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.C0MMENT_TOTAL_SWEEP_TO_TEST);
                TotalSweepToTestNode.AppendChild(xmlComment);

                //Create Time Delay Node
                TimeDelayNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TIME_DELAY);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.TimeDelay);
                TimeDelayNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(TimeDelayNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_UTILITY_TEST_TIME_DELAY);
                TimeDelayNode.AppendChild(xmlComment);

                //Create Number Of Cycles Node
                NumberOfCyclesNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_NUMBER_OF_CYCLES);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.NumberOfCycles);
                NumberOfCyclesNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(NumberOfCyclesNode);

                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_UTILITY_TEST_NUMBER_OF_CYCLES);
                NumberOfCyclesNode.AppendChild(xmlComment);

                //Create Open Sweep Up To  Node
                XmlNode OpenSweepUpToNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_OPEN_SWEEP_UP_TO);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepTest.OpenSweepUpTo);
                OpenSweepUpToNode.Attributes.Append(productAttribute);
                SweepTestNode.AppendChild(OpenSweepUpToNode);

                //Comment
                //Hema Dt: 14-01-2011 MT: 16254, to change the open sweep up to by percentage
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_OPEN_KEYS_PERCENTAGE);
                OpenSweepUpToNode.AppendChild(xmlComment);

                //Create Press_Nfstable Node
                XmlNode Press_NfstableNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE);
                McPressNameNode.AppendChild(Press_NfstableNode);

                // AutoZeroServos option
                XmlNode autoZeroOption = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_SERVOS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoZeroServosEnabled.ToString().ToUpper();
                autoZeroOption.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(autoZeroOption);

                //Create BreakPoint Node
                XmlNode BreakPointNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE_BREAKPOINT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.NFSTable.BreakPoint);
                BreakPointNode.Attributes.Append(productAttribute);
                Press_NfstableNode.AppendChild(BreakPointNode);

                //Create MaxKeyTurnsAtConsoleZone99 Node
                XmlNode MaxKeyTurnsAtConsoleZone99Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE_GAIN);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.NFSTable.MaxKeyTurnsAtConsole99);
                MaxKeyTurnsAtConsoleZone99Node.Attributes.Append(productAttribute);
                Press_NfstableNode.AppendChild(MaxKeyTurnsAtConsoleZone99Node);


                //Create PRESS_SWEEP_CONTROL_INTERFACE Node
                XmlNode PRESS_SWEEP_CONTROL_INTERFACENode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SWEEP_CONTROL_INTERFACE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_CONTROL_TYPE);
                //productAttribute.Value = Convert.ToString(mcPress.SweepInterface.ControlType);
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface, default sweep type is motor
                if (sweepConfiguration <= 0)
                    sweepConfiguration = (int)DefineAndConst.ControlTypes.MOTOR;
                productAttribute.Value = Convert.ToString(sweepConfiguration);
                PRESS_SWEEP_CONTROL_INTERFACENode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_SWEEP_CONTROL_INTERFACENode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_CONTROLS);
                PRESS_SWEEP_CONTROL_INTERFACENode.AppendChild(xmlComment);

                if( sweepConfiguration > 0 )
                {
                    if( ( sweepConfiguration == ( int )DefineAndConst.ControlTypes.MOTOR )
                        || ( sweepConfiguration == ( int )DefineAndConst.ControlTypes.SERVO )
                        || ( sweepConfiguration == ( int )DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO )
                        || ( sweepConfiguration == ( int )DefineAndConst.ControlTypes.PCU ) )
                    {
                        SweepInterfaceControl( PRESS_SWEEP_CONTROL_INTERFACENode, doc );
                    }
                    else if( sweepConfiguration == ( int )DefineAndConst.ControlTypes.PLC )
                    {
                        //Create PLC_CONTROL Node

                        XmlNode PLC_CONTROLNode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONTROL );
                        PRESS_SWEEP_CONTROL_INTERFACENode.AppendChild( PLC_CONTROLNode );

                        //Create PLC Node
                        XmlNode PLC_Node = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONFIG );

                        productAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_PRESS_IS_USED );
                        if( mcPress.SweepInterface.IsPLCUsed )
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                        PLC_Node.Attributes.Append( productAttribute );

                        // Create PLC Type Node
                        productAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE );
                        productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCType );
                        PLC_Node.Attributes.Append( productAttribute );
                        PLC_CONTROLNode.AppendChild( PLC_Node );

                        // Append additional parameters only when PLC Type is NOT AVT PLC
                        if( ePLCType.ePLC_AVT != ( ePLCType )mcPress.SweepInterface.PLCType )
                        {
                            // Create PLC Comm port Node
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT );
                            productAttribute.Value = mcPress.SweepInterface.PLCCOMMPort;
                            PLC_Node.Attributes.Append( productAttribute );
                            PLC_CONTROLNode.AppendChild( PLC_Node );

                            // Create Wash_cycle Node
                            XmlNode WASH_CYCLE_TIMENode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWashCycle );
                            WASH_CYCLE_TIMENode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( WASH_CYCLE_TIMENode );

                            // Create Mech_Delay Node
                            XmlNode Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_MECH_DELAY_IN_MS );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCMechDelayInMS );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Tach_Pulse Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCTachPulsePerExec );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Sample Time Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SAMPLE_TIME_MS );   //18 Feb 2010 Mark Colvin MT16792
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCSampleTime );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Sweep Divisor Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DIVISOR );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCSweepDivisor );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Divisor Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_DIVISOR );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWaterDivisor );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Ouput Min Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_OUTPUT_MIN );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWaterOutputMin );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Start Speed Min Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_START_SPEED_MIN );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWaterStartSpeedMin );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Start Speed Max Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_START_SPEED_MAX );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWaterStartSpeedMax );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Startup Voltage Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_STARTUP_VOLTAGE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCWaterStartupVolt );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
                            // Create NL Curve Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_NL_CURVE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCNLCurve );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Sweep Motor Speed Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MOTOR_SPEED );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCMotorSpeed );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create SPU Sweep Motor Turns Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MOTOR_TURNS );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCMotorTurns );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_TYPE Node                                     // MarkC 11/6/12 WI29958 add AB PLC5 type 
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_TYPE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABType );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_BAUD Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_BAUD );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = mcPress.SweepInterface.PLCABDHBaud;
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_FILENAME Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_FILENAME );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = mcPress.SweepInterface.PLCABFilename;
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_PLC_NODE Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_PLC_NODE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABPLCNode );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_AS_NODE Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_AS_NODE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABASNode );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_MOD_TYPE Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_MOD_TYPE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABModType );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_PLC_MAP Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_PLC_MAP );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABPLCMap );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );
                            //MT18035  MarkC 2/8/13 add poll type and rate
                            // Create AB_POLL_TYPE Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_POLL_TYPE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABPOLLTYPE );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_POLL_RATE Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_AB_POLL_RATE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.SweepInterface.PLCABPOLLRATE );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );
                        }
                    }
                }
                //Create PRESS_Water_CONTROL_INTERFACE
                XmlNode PRESS_WATER_CONTROL_INTERFACENode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_WATER_CONTROL_INTERFACE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_CONTROL_TYPE);
		// MT16792 markc Jun 20, 2011  add PLC DtoA interface, default water type is motor
                if (waterConfiguration <= 0)
                    waterConfiguration = (int)DefineAndConst.ControlTypes.MOTOR;
                productAttribute.Value = waterConfiguration.ToString();
                PRESS_WATER_CONTROL_INTERFACENode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_WATER_CONTROL_INTERFACENode);
                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_WATER_CONTROL_INTERFACE);
                PRESS_WATER_CONTROL_INTERFACENode.AppendChild(xmlComment);
                if (waterConfiguration > 0)
                {
                    if ((waterConfiguration == (int)DefineAndConst.ControlTypes.MOTOR)
                        || (waterConfiguration == (int)DefineAndConst.ControlTypes.SERVO)
                        || (waterConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
                        || (waterConfiguration == (int)DefineAndConst.ControlTypes.PCU))
                    {
                        WaterInterfaceControl(PRESS_WATER_CONTROL_INTERFACENode, doc);
                    }
                    else if (waterConfiguration == (int)DefineAndConst.ControlTypes.PLC)
                    {
                        //Create PLC_CONTROL Node

                        XmlNode PLC_CONTROLNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONTROL);
                        PRESS_WATER_CONTROL_INTERFACENode.AppendChild(PLC_CONTROLNode);

                        //Create PLC Node
                        XmlNode PLC_Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONFIG);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_IS_USED);
                        if (mcPress.WaterInterface.IsPLCUsed)
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                        PLC_Node.Attributes.Append(productAttribute);

                        // Create PLC Type Node
                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE);
                        productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCType);
                        PLC_Node.Attributes.Append(productAttribute);
                        PLC_CONTROLNode.AppendChild(PLC_Node);

                        // Append additional parameters only when PLC Type is NOT AVT PLC
                        if( ePLCType.ePLC_AVT != ( ePLCType )mcPress.WaterInterface.PLCType )
                        {
                            // Create PLC Comm port Node
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT );
                            productAttribute.Value = mcPress.WaterInterface.PLCCOMMPort;
                            PLC_Node.Attributes.Append( productAttribute );
                            PLC_CONTROLNode.AppendChild( PLC_Node );

                            // Create Wash_cycle Node
                            XmlNode WASH_CYCLE_TIMENode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWashCycle );
                            WASH_CYCLE_TIMENode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( WASH_CYCLE_TIMENode );

                            // Create Mech_Delay Node
                            XmlNode Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_MECH_DELAY_IN_MS );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCMechDelayInMS );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Tach_Pulse Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCTachPulsePerExec );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Sample Time Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SAMPLE_TIME_MS );   //18 Feb 2010 Mark Colvin MT16792
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCSampleTime );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Sweep Divisor Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DIVISOR );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCSweepDivisor );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Divisor Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_DIVISOR );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWaterDivisor );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Ouput Min Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_OUTPUT_MIN );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWaterOutputMin );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Start Speed Min Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_START_SPEED_MIN );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWaterStartSpeedMin );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Start Speed Max Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_START_SPEED_MAX );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWaterStartSpeedMax );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create Water Startup Voltage Node
                            Mech_DelayNode = doc.CreateElement( XMLNodeDictionary.XT_WATER_STARTUP_VOLTAGE );
                            productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                            productAttribute.Value = Convert.ToString( mcPress.WaterInterface.PLCWaterStartupVolt );
                            Mech_DelayNode.Attributes.Append( productAttribute );
                            PLC_Node.AppendChild( Mech_DelayNode );

                            // Create AB_TYPE Node                                     // MarkC 11/6/12 WI29958 add AB PLC5 type 
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_TYPE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABType);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_BAUD Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_BAUD);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = mcPress.WaterInterface.PLCABDHBaud;
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_FILENAME Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_FILENAME);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = mcPress.WaterInterface.PLCABFilename;
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_PLC_NODE Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_PLC_NODE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABPLCNode);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_AS_NODE Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_AS_NODE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABASNode);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_MOD_TYPE Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_MOD_TYPE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABModType);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_PLC_MAP Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_PLC_MAP);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABPLCMap);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);
                                                                                //MT18035  MarkC 2/8/13 add poll type and rate
                            // Create AB_POLL_TYPE Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_POLL_TYPE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABPOLLTYPE);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);

                            // Create AB_POLL_RATE Node
                            Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_AB_POLL_RATE);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                            productAttribute.Value = Convert.ToString(mcPress.WaterInterface.PLCABPOLLRATE);
                            Mech_DelayNode.Attributes.Append(productAttribute);
                            PLC_Node.AppendChild(Mech_DelayNode);
                        }
                    }
                }
                //Create PRESS_TURN_BARS
                int iTurnBarCount = mcPress.TotalTurnBars;
                XmlNode PRESS_TURN_BARSNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TURN_BARS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(iTurnBarCount);
                PRESS_TURN_BARSNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_TURN_BARSNode);

                for (int iTurnBar = 0; iTurnBar < iTurnBarCount; iTurnBar++)
                {
                    TurnBars TurnBar = (TurnBars)mcPress.TurnBar(iTurnBar);
                    if (TurnBar == null)
                        continue;
                    XmlNode PRESS_TURN_BARNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TURN_BAR);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = TurnBar.Name;
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT);
                    productAttribute.Value = TurnBar.Predecessor;
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_ACTIVATED);
                    if (TurnBar.Checked)
                    {
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                    }
                    else
                        productAttribute.Value = productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);
                    PRESS_TURN_BARSNode.AppendChild(PRESS_TURN_BARNode);
                }

                // Create Airbar details only when press type is 'Dual / Multi web press'
                if ( mcPress.PressType == Convert.ToInt32(enPressTypes.MULTI_WEB_PRESS) )
                {
                    // Airbar configuration
                    int airbarCount = mcPress.AirbarList.Count;
                    XmlNode pressAirbars = doc.CreateElement(XMLNodeDictionary.XT_AIR_BARS);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_COUNT);
                    productAttribute.Value = Convert.ToString(airbarCount);
                    pressAirbars.Attributes.Append(productAttribute);

                    for (int counter = 0; counter < airbarCount; ++counter)
                    {
                        AirbarConfigurationDetails airbarDetails = mcPress.AirbarList[counter];
                        if (airbarDetails != null)
                        {
                            // Airbar 
                            XmlNode airbarNode = doc.CreateElement(XMLNodeDictionary.XT_AIR_BAR);
                            // Airbar name
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                            productAttribute.Value = airbarDetails.Name;
                            airbarNode.Attributes.Append(productAttribute);

                            // Airbar location - after which unit (re-using the Turnbar tag)
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT);
                            productAttribute.Value = airbarDetails.AfterWhichUnit;
                            airbarNode.Attributes.Append(productAttribute);

                            // add Airbar node to the Airbars
                            pressAirbars.AppendChild(airbarNode);
                        }

                    }

                    McPressNameNode.AppendChild(pressAirbars);
                }

                // Auto Scan calibration
                XmlNode PRESS_Auto_Scan_Cal = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_SCAN_CAL);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                if (mcPress.AutoScanCalibration.AutoScanEnabled)
                    productAttribute.Value = "TRUE";
                else
                    productAttribute.Value = "FALSE";
                PRESS_Auto_Scan_Cal.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_Auto_Scan_Cal);

                //Sweep Zone Ratio
                XmlNode sweepZoneRatio = doc.CreateElement(XMLNodeDictionary.XT_PRESS_SWEEP_ZONE_RATIO);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.SweepZoneRatio.ToString();
                sweepZoneRatio.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(sweepZoneRatio);

                //Zone Margin
                XmlNode zoneMargin = doc.CreateElement(XMLNodeDictionary.XT_PRESS_ZONE_MARGIN);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.ZoneMargin.ToString();
                zoneMargin.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(zoneMargin);

                // EWMAFilterParam
                XmlNode EWMAFilterParam = doc.CreateElement(XMLNodeDictionary.XT_PRESS_EWMAFACTOR);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.EWMAFactor.ToString();
                EWMAFilterParam.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(EWMAFilterParam);

                // ScanSweepAdjust
                XmlNode scanSweepAdjustNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_SCAN_SWEEP_ADJUST);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.ScanSweepAdjust.ToString();
                scanSweepAdjustNode.Attributes.Append(productAttribute);
                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_SCAN_SWEEP_ADJUST);
                scanSweepAdjustNode.AppendChild(xmlComment);
                PRESS_Auto_Scan_Cal.AppendChild(scanSweepAdjustNode);

                // SweepDefault
                XmlNode sweepDefaultNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_SWEEP_DEFAULT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.SweepDefault.ToString();
                sweepDefaultNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(sweepDefaultNode);

                //WEB_TYPE
                XmlNode webTypeNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_WEB_TYPE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.WebType.ToString();
                webTypeNode.Attributes.Append(productAttribute);
                //Comment
                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_WEB_TYPE);
                webTypeNode.AppendChild(xmlComment);
                PRESS_Auto_Scan_Cal.AppendChild(webTypeNode);

                // EnableLimitCheck
                XmlNode enableLimitCheckNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_ENABLE_LIMIT_CHECK);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                string enableLimitsStatus = XMLNodeDictionary.XT_PRESS_FALSE;
                if (mcPress.AutoScanCalibration.EnableLimitCheck)
                    enableLimitsStatus = XMLNodeDictionary.XT_PRESS_TRUE;
                productAttribute.Value = enableLimitsStatus;
                enableLimitCheckNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(enableLimitCheckNode);

                // BladeTolerance
                XmlNode bladeToleranceNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_BLADE_TOLERANCE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.BladeTolerance.ToString();
                bladeToleranceNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(bladeToleranceNode);
                
                // CIP3Path
                XmlNode cip3PathNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CIP3_PATH);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.Cip3Path;
                cip3PathNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(cip3PathNode);

                // CIP3ImagesPath
                XmlNode cip3ImagesPathNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CIP3_IMAGES_PATH);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.Cip3ImagesPath;
                cip3ImagesPathNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(cip3ImagesPathNode);

                // EnableImpositionData
                XmlNode enableImpositionDataNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_ENABLE_IMPOSITION_DATA);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                string enableImpositionDataStatus = XMLNodeDictionary.XT_PRESS_FALSE;
                if (mcPress.AutoScanCalibration.ImpositionDataEnabled)
                    enableImpositionDataStatus = XMLNodeDictionary.XT_PRESS_TRUE;
                productAttribute.Value = enableImpositionDataStatus;
                enableImpositionDataNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(enableImpositionDataNode);

                // ImpositionPath
                XmlNode impositionPathNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_IMPO_PATH);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.AutoScanCalibration.ImpositionPath;
                impositionPathNode.Attributes.Append(productAttribute);
                PRESS_Auto_Scan_Cal.AppendChild(impositionPathNode);

                // PressAutoZero                                      
                XmlNode pressAutoZeroOption = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO);      
                // PressAutoZero Enabled
                XmlNode pressAutoZeroEnabled = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_ENABLED);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.AutoZeroEnabled.ToString().ToUpper();
                pressAutoZeroEnabled.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroEnabled);

                // PressAutoZero mode
                XmlNode pressAutoZeroMode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_MODE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.Mode.ToString();
                pressAutoZeroMode.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroMode);

                // PressAutoZero deviceIPAddress
                XmlNode pressAutoZeroDeviceIPAddr = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DEV_IPADDR);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.DeviceIPAddress.ToString();
                pressAutoZeroDeviceIPAddr.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroDeviceIPAddr);

                // PressAutoZero deviceID
                XmlNode pressAutoZeroDeviceID = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DEV_ID);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.DeviceID.ToString();
                pressAutoZeroDeviceID.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroDeviceID);

                // PressAutoZero timeDelay
                XmlNode pressAutoZeroTimeDelay = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_TIME_DELAY);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.TimeDelay.ToString();
                pressAutoZeroTimeDelay.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroTimeDelay);

                // PressAutoZero pollTime
                XmlNode pressAutoZeroPollTime = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_POLL_TIME);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.PollTimePeriod.ToString();
                pressAutoZeroPollTime.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroPollTime);

                // PressAutoZero factorFrequency
                XmlNode pressAutoZeroFactorFrequency = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_FACTOR_FREQUENCY);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.FactorFrequency.ToString();
                pressAutoZeroFactorFrequency.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroFactorFrequency);

                // PressAutoZero idleThresholdFPM
                XmlNode pressAutoZeroIdleThreshold = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_IDLE_THRESHOLD_FPM);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.IdleThresholdFPM.ToString();
                pressAutoZeroIdleThreshold.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroIdleThreshold);

                // PressAutoZero dryContactIdleState
                XmlNode pressAutoDryContactIdleState = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DRY_CON_IDLE_STATE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.DryContactIdleState.ToString().ToUpper();
                pressAutoDryContactIdleState.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoDryContactIdleState);

                // PressAutoZero timeDelayFountainClose
                XmlNode pressAutoZeroTimeDelayFountainClose = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DELAY_FOUNTAIN_CLOSE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = mcPress.PressAutoZero.TimeDelayToCloseFountain.ToString();
                pressAutoZeroTimeDelayFountainClose.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroTimeDelayFountainClose);

                // PressAutoZero DryChannelsMapping WI30488
                XmlNode pressAutoZeroDryChannelsMapping = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AZ_DRY_CHANNELS_MAPPING);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = mcPress.PressAutoZero.NumberOfDrySensors.ToString();
                pressAutoZeroDryChannelsMapping.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroDryChannelsMapping);
                    //mapping elements
                for (byte byKey = 0; byKey < DefineAndConst.SystemCapacities.MAX_AUTO_ZERO_CHANNELS; ++byKey)
                {
                    if (mcPress.PressAutoZero.DryChannelsMap.ContainsKey(byKey))
                    {
                        string strUnitName = mcPress.PressAutoZero.DryChannelsMap[byKey];
                        //Create MappingElement
                        XmlNode pressAutoZeroDryChannelsMappingElement = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AZ_MAPPING_ELEMENT);
                        // 
                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_AZ_INPUT_CHANNEL_ID);
                        productAttribute.Value = byKey.ToString();
                        pressAutoZeroDryChannelsMappingElement.Attributes.Append(productAttribute);
                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_AZ_UNIT_NAME);
                        productAttribute.Value = strUnitName;
                        pressAutoZeroDryChannelsMappingElement.Attributes.Append(productAttribute);
                        pressAutoZeroDryChannelsMapping.AppendChild(pressAutoZeroDryChannelsMappingElement);
                    }
                }
                // PressAutoZero FrqChannelsMapping WI30488
                XmlNode pressAutoZeroFrqChannelsMapping = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AZ_FREQUENCY_CHANNELS_MAPPING);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = mcPress.PressAutoZero.NumberOfFrequencySensors.ToString();
                pressAutoZeroFrqChannelsMapping.Attributes.Append(productAttribute);
                pressAutoZeroOption.AppendChild(pressAutoZeroFrqChannelsMapping);
                //mapping elements
                for (byte byKey = 0; byKey < DefineAndConst.SystemCapacities.MAX_AUTO_ZERO_CHANNELS; ++byKey)
                {
                    if (mcPress.PressAutoZero.FrqChannelsMap.ContainsKey(byKey))
                    {
                        string strUnitName = mcPress.PressAutoZero.FrqChannelsMap[byKey];
                        //Create MappingElement
                        XmlNode pressAutoZeroFrqChannelsMappingElement = doc.CreateElement(XMLNodeDictionary.XT_PRESS_AZ_MAPPING_ELEMENT);
                        // 
                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_AZ_INPUT_CHANNEL_ID);
                        productAttribute.Value = byKey.ToString();
                        pressAutoZeroFrqChannelsMappingElement.Attributes.Append(productAttribute);
                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_AZ_UNIT_NAME);
                        productAttribute.Value = strUnitName;
                        pressAutoZeroFrqChannelsMappingElement.Attributes.Append(productAttribute);
                        pressAutoZeroFrqChannelsMapping.AppendChild(pressAutoZeroFrqChannelsMappingElement);  //WI36833 Dry append used instead of Frq
                    }
                }
                
                // Finally append the PressAutoZero to press config details
                McPressNameNode.AppendChild(pressAutoZeroOption);
                //  Assumption: A Tower Split = A Web
                //  If Press type is "Tower press", then include PRESS_MAX_WEBS = 12 
                // 
                if ( mcPress.PressType == Convert.ToInt32( enPressTypes.TOWER_PRESS ) )
                {
                    mcPress.TotalNumberOfWebs = MCNWSiteGen.DefineAndConst.SystemCapacities.MAX_TOWER_SPLITS;
                }

                // If Press type is "Dual / Multi web press" OR "Tower Press", then include PRESS_MAX_WEBS
                if ( ( mcPress.PressType == Convert.ToInt32( enPressTypes.MULTI_WEB_PRESS ) ) ||
                     ( mcPress.PressType == Convert.ToInt32( enPressTypes.TOWER_PRESS ) ) )
                {
                    // Total webs present in the Press
                    XmlNode totalWebs = doc.CreateElement(XMLNodeDictionary.XT_MAX_WEBS);

                    // value
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = mcPress.TotalNumberOfWebs.ToString();

                    // add value to the Xml node
                    totalWebs.Attributes.Append(productAttribute);
                    // Finally, add to the press
                    McPressNameNode.AppendChild(totalWebs);
                }
                               
                // MaxFountainPorts per SPU 
                XmlNode maxFountainPorts = doc.CreateElement(XMLNodeDictionary.XT_MAX_FOUNTAIN_PORTS_SPU);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_COUNT);
                productAttribute.Value = mcPress.MaxFountainPortCountPerSPU.ToString();
                maxFountainPorts.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(maxFountainPorts);
                
                // Product Options
                XmlNode productOptions = doc.CreateElement(XMLNodeDictionary.XT_PRODUCT_OPTIONS);
                // Jobs Management option details
                XmlNode jobManagementOption = doc.CreateElement(XMLNodeDictionary.XT_JOBS_MANAGEMENT_OPTION);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = m_mcSiteConfigData.ProductOptions.JobModeEnabled.ToString().ToUpper();
                jobManagementOption.Attributes.Append(productAttribute);
                // add option 'Jobs Management option'
                productOptions.AppendChild(jobManagementOption);

                // Keep only last version of profiles in a Form
                XmlNode keepLastVersionOption = doc.CreateElement(XMLNodeDictionary.XT_KEEP_LAST_VERSION_PROFILES_OPTION);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = m_mcSiteConfigData.ProductOptions.KeepOnlyLastVersionProfiles.ToString().ToUpper();
                keepLastVersionOption.Attributes.Append(productAttribute);
                // add option 'keep only last version' to product options
                productOptions.AppendChild(keepLastVersionOption);

                // prompt Zero All Inker needed on every restart of Server
                XmlNode promptZAINeeded = doc.CreateElement(XMLNodeDictionary.XT_PROMPT_ZAI_NEEDED_ON_SERVER_RESTART);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = m_mcSiteConfigData.ProductOptions.PromptZAINeededOnServerRestart.ToString().ToUpper();
                promptZAINeeded.Attributes.Append(productAttribute);
                // add option 'prompt Zero All Inker needed on every restart of Server' to product options
                productOptions.AppendChild(promptZAINeeded);

                // If the Press type is "Tower Press", then include NEWSPAPER_NAVIGATION_VIEW_OPTION
                if ( mcPress.PressType == Convert.ToInt32( enPressTypes.TOWER_PRESS ) )
                {
                    // Newspaper Navigation View option 
                    XmlNode newspaperNavigationView = doc.CreateElement( XMLNodeDictionary.XT_NEWSPAPER_NAVIGATION_VIEW_OPTION );
                    productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                    productAttribute.Value = m_mcSiteConfigData.ProductOptions.NewspaperNavigationViewOption.ToString( ).ToUpper( );
                    newspaperNavigationView.Attributes.Append( productAttribute );
                    // add option 'Newspaper Navigation View option' to product options
                    productOptions.AppendChild( newspaperNavigationView );

                    // Label Towers with Numbers option
                    XmlNode towersWithNumbersOption = doc.CreateElement( XMLNodeDictionary.XT_LABEL_TOWERS_WITH_NUMBERS_OPTION );
                    productAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
                    productAttribute.Value = m_mcSiteConfigData.ProductOptions.LabelTowersWithNumbersOption.ToString( ).ToUpper( );
                    towersWithNumbersOption.Attributes.Append( productAttribute );
                    // add option 'Label Towers with Numbers' to product options
                    productOptions.AppendChild( towersWithNumbersOption );
                }
                
                // Add product options to System Configuration
                MCSystemConfigNode.AppendChild(productOptions);

                // Mercury Server Configuration
                XmlNode serverConfig = doc.CreateElement(XMLNodeDictionary.XT_MERCURY_SERVER_CONFIG);
                // Mercury Server 
                XmlNode serverNode = doc.CreateElement(XMLNodeDictionary.XT_MERCURY_SERVER);
                // Mercury Server IP Address
                XmlAttribute serverIPAddress = doc.CreateAttribute(XMLNodeDictionary.IP_ADDRESS);
                serverIPAddress.Value = m_mcSiteConfigData.ServerConfiguration.IPAddress;
                serverNode.Attributes.Append(serverIPAddress);
                // Mercury Server Port number
                XmlAttribute serverPortNum = doc.CreateAttribute(XMLNodeDictionary.PORT);
                serverPortNum.Value = m_mcSiteConfigData.ServerConfiguration.PortNumber.ToString();
                serverNode.Attributes.Append(serverPortNum);
                
                // add Server IP Address to the Server Configuration
                serverConfig.AppendChild(serverNode);

                // Add Mercury Server Configuration to System Configuration
                MCSystemConfigNode.AppendChild(serverConfig);
                                
                // Add Mercury Server options to System Configuration
                AppendMercuryServerOptions( doc, MCSystemConfigNode );

                // Add Mercury GUI options to System Configuration
                AppendMercuryGUIOptions( doc, MCSystemConfigNode );

                // Add Mercury AVT PLC Configuration details to System Configuration
                AppendMercuryAVTPLCConfigDetails( doc, MCSystemConfigNode );

                //save the file               
                doc.Save(strfilePath);
                string strSavedFileName = System.IO.Path.GetFileName(SaveFileLocation.FileName);
                MessageBox.Show(strSavedFileName + " configuration file saved successfully.");
                strfilePath = ""; //MT#12064
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WaterInterfaceControl(XmlNode waterControlInterfaceNode, XmlDocument doc)
        {
            MCPressInfo mcPress = GetCurrentPress();
            if (mcPress == null)
                return;
            XmlNode ControlNode;
            if (waterConfiguration == (int)DefineAndConst.ControlTypes.MOTOR)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_MOTOR_CONTROL);
            else if (waterConfiguration == (int)DefineAndConst.ControlTypes.SERVO)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVO_CONTROL);
            else
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_MOTOR_AND_SERVO_CONTROL);
            if (waterConfiguration == (int)DefineAndConst.ControlTypes.PCU)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_PCU_CONTROL);
            waterControlInterfaceNode.AppendChild(ControlNode);
            XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);

            if (waterConfiguration == (int)DefineAndConst.ControlTypes.PCU)
            {

                //PCU_WATER_PULSE_WIDTH
                XmlNode PCU_pulseWidthNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_WATER_PULSE_WIDTH);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.PCU_pulseWidth);
                PCU_pulseWidthNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_pulseWidthNode);

                //PCU_WATER_DIST_NUDGE
                XmlNode PCU_distNudgeNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_WATER_DIST_NUDGE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.PCU_distNudge);
                PCU_distNudgeNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_distNudgeNode);

                //PCU_WATER_MAX_STALLS
                XmlNode PCU_maxStallsNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_WATER_MAX_STALLS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.PCU_maxStalls);
                PCU_maxStallsNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_maxStallsNode);

                //PCU_WATER_TOLERANCE
                XmlNode PCU_toleranceNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_WATER_TOLERANCE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.PCU_tolerance);
                PCU_toleranceNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_toleranceNode);

                return;
            }

            //SERVOTURNS 
            XmlNode ServoTurnsNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVOTURNS);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.ServoTurns);
            ServoTurnsNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(ServoTurnsNode);

            // Both Motor and Servo Control
            if (waterConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
            {
                XmlNode Turns2Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_TURNS2);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.Turns2);
                Turns2Node.Attributes.Append(productAttribute);
                ControlNode.AppendChild(Turns2Node);
            }

            // Initial Surge
            XmlNode initialSurgeNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_INITIAL_SURGE);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.InitialSurge);
            initialSurgeNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(initialSurgeNode);

            //Incremental Surge
            XmlNode incrementalSurgeNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_INCREMENTAL_SURGE);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            productAttribute.Value = Convert.ToString(mcPress.WaterMotorServoControl.IncrementalSurge);
            incrementalSurgeNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(incrementalSurgeNode);

            //USE_BANK_1 
            XmlNode UseBank1Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_USE_BANK_1);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.WaterMotorServoControl.UseBank1)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            UseBank1Node.Attributes.Append(productAttribute);
            ControlNode.AppendChild(UseBank1Node);

            //SPECIAL_MAPPING
            XmlNode specialMappingNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SPECIAL_MAPPING);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.WaterMotorServoControl.SpecialMapping)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            specialMappingNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(specialMappingNode);

            //REVERSED
            XmlNode ReversedNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_REVERSED);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.WaterMotorServoControl.Reversed)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            ReversedNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(ReversedNode);

            if (waterConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
            {
                // create sweep servo node
                XmlNode waterServoNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_WATER_SERVO);
                ControlNode.AppendChild(waterServoNode);

                // INKERS node
                XmlNode inkersNode = doc.CreateElement(XMLNodeDictionary.XT_INKERS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_COUNT);
                int inkerCount = mcPress.InkerList.Count;
                if (inkerCount > 0)
                {
                    productAttribute.Value = inkerCount.ToString();
                    inkersNode.Attributes.Append(productAttribute);
                    waterServoNode.AppendChild(inkersNode);
                    int waterServoConfigured = 0;
                    if (mcPress.WaterServo != null)
                        waterServoConfigured = mcPress.WaterServo.Count;
                    if (waterServoConfigured > 0)
                    {
                        XmlNode inkerNode;
                        int arrayLength = mcPress.WaterServo.Count;
                        string servo = XMLNodeDictionary.XT_PRESS_FALSE;
                        for (int inker = 0; inker < inkerCount; inker++)
                        {
                            inkerNode = doc.CreateElement(XMLNodeDictionary.XT_INKER);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                            productAttribute.Value = (inker + 1).ToString();
                            inkerNode.Attributes.Append(productAttribute);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVO_CONTROL);
                            if (arrayLength > inker)
                            {
                                servo = (string)mcPress.WaterServo[inker];
                            }
                            if (servo == XMLNodeDictionary.XT_PRESS_TRUE)
                                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                            else
                                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                            inkerNode.Attributes.Append(productAttribute);                            
                            inkersNode.AppendChild(inkerNode);
                        }
                    }
                }
            }
        }

        private void SweepInterfaceControl(XmlNode sweepControlInterfaceNode, XmlDocument doc)
        {
            MCPressInfo mcPress = GetCurrentPress();
            if (mcPress == null)
                return;
            XmlNode ControlNode=null;
            if(sweepConfiguration == (int)DefineAndConst.ControlTypes.MOTOR)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_MOTOR_CONTROL);
            else if (sweepConfiguration == (int)DefineAndConst.ControlTypes.SERVO)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVO_CONTROL);
            if (sweepConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_MOTOR_AND_SERVO_CONTROL);
            if (sweepConfiguration == (int)DefineAndConst.ControlTypes.PCU)
                ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_PCU_CONTROL);

            sweepControlInterfaceNode.AppendChild(ControlNode);

            XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);

            if (sweepConfiguration == (int)DefineAndConst.ControlTypes.PCU)
            {

                //PCU_SWEEP_PULSE_WIDTH
                XmlNode PCU_pulseWidthNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_PULSE_WIDTH);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.PCU_pulseWidth);
                PCU_pulseWidthNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_pulseWidthNode);

                //PCU_SWEEP_DIST_NUDGE
                XmlNode PCU_distNudgeNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_DIST_NUDGE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.PCU_distNudge);
                PCU_distNudgeNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_distNudgeNode);

                //PCU_SWEEP_MAX_STALLS
                XmlNode PCU_maxStallsNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_MAX_STALLS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.PCU_maxStalls);
                PCU_maxStallsNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_maxStallsNode);

                //PCU_SWEEP_TOLERANCE
                XmlNode PCU_toleranceNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_TOLERANCE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.PCU_tolerance);
                PCU_toleranceNode.Attributes.Append(productAttribute);
                ControlNode.AppendChild(PCU_toleranceNode);

                return;
            }

            // create STEP_ENABLED node
            XmlNode stepEnabledNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_STEP_ENABLED);

            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.SweepMotorServoControl.StepEnabled)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            stepEnabledNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(stepEnabledNode);

            //SERVOTURNS 
            XmlNode ServoTurnsNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVOTURNS);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
            productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.ServoTurns);
            ServoTurnsNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(ServoTurnsNode);

            // Both Motor and Servo Control
            if (sweepConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
            {
                XmlNode Turns2Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_TURNS2);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepMotorServoControl.Turns2);
                Turns2Node.Attributes.Append(productAttribute);
                ControlNode.AppendChild(Turns2Node);
            }

            //REVERSED
            XmlNode ReversedNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_REVERSED);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.SweepMotorServoControl.Reversed)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            ReversedNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(ReversedNode);
            // Low BackLash Used
            XmlNode lowBackLashUsedNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_LOW_BACKLASH_USED);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.SweepMotorServoControl.LowBacklashUsed)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            lowBackLashUsedNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(lowBackLashUsedNode);

            //OFFSET_ENABLED 
            XmlNode OffsetEnabledNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_OFFSET_ENABLED);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.SweepMotorServoControl.OffsetEnabled)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            OffsetEnabledNode.Attributes.Append(productAttribute);
            ControlNode.AppendChild(OffsetEnabledNode);

            //USE_BANK_1 
            XmlNode UseBank1Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_USE_BANK_1);
            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
            if (mcPress.SweepMotorServoControl.UseBank1)
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
            else
                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
            UseBank1Node.Attributes.Append(productAttribute);
            ControlNode.AppendChild(UseBank1Node);
            if (sweepConfiguration == (int)DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO)
            {
                // create sweep servo node
                XmlNode sweepServoNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SWEEP_SERVO);
                ControlNode.AppendChild(sweepServoNode);

                // INKERS node
                XmlNode inkersNode = doc.CreateElement(XMLNodeDictionary.XT_INKERS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_COUNT);
                int inkerCount = mcPress.InkerList.Count;
                if(inkerCount > 0)
                {
                    productAttribute.Value = inkerCount.ToString();
                    inkersNode.Attributes.Append(productAttribute);
                    sweepServoNode.AppendChild(inkersNode);
                    int sweepServoConfigured = 0;
                    if (mcPress.SweepServo != null)
                        sweepServoConfigured = mcPress.SweepServo.Count;
                    if (sweepServoConfigured > 0)
                    {
                        XmlNode inkerNode;
                        int arrayLength = mcPress.SweepServo.Count;
                        string servo;
                        for (int inker = 0; inker < inkerCount; inker++)
                        {
                            servo = XMLNodeDictionary.XT_PRESS_FALSE;
                            inkerNode = doc.CreateElement(XMLNodeDictionary.XT_INKER);
                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                            productAttribute.Value = (inker + 1).ToString();
                            inkerNode.Attributes.Append(productAttribute);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_SERVO_CONTROL);
                            if (arrayLength > inker)
                            {
                                servo = (string)mcPress.SweepServo[inker];
                            }
                            if (servo == XMLNodeDictionary.XT_PRESS_TRUE)
                                productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                            else
                                productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                            inkerNode.Attributes.Append(productAttribute);
                            inkersNode.AppendChild(inkerNode);
                        }
                    }
                }
            }
        }      

        private void btnPressSetup_Click(object sender, EventArgs e)
        {
            stripPressConfig.Visible = true;
        }

        private void toolstripPressInfo_Click(object sender, EventArgs e)
        {
            PressInformation pressInfo = new PressInformation();
            pressInfo.PressInfo = GetCurrentPress();
            pressInfo.StartPosition = FormStartPosition.CenterParent;
            pressInfo.ShowDialog();
            pressInfo.Dispose();
            string strPressName = "";
            strPressName = GetCurrentPress().PressName;
        }

        //======================================================================================
        /// <Function>sPUInformationToolStripMenuItem_Click</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// sPU Information ToolStrip MenuItem Click
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11801
        /// Suresh Dt: 09-15-09 MT: 13368
        ///     03-Apr-13, Mark C, WI30603: Disable Sweep / Water menus when fountain ports / SPU
        ///         are more than 6.
        ///     21-Apr-14, Mark C, WI36192: Refactored SPU Configuration Form for configuring IP Address
        /// </History>
        ///=====================================================================================
        private void sPUInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSPUConfiguration frmSPUConfig = new frmSPUConfiguration(m_bSPUConfigured, GetCurrentPress()))
            {                
                frmSPUConfig.ShowDialog();
                if (frmSPUConfig.DataChanged)
                {
                    m_bSPUConfigured = false;
                    m_bFountainConfigured = false;
                    GenerateFountainCount();
                }
            }            
        }

        /// <![CDATA[
        /// 
        /// Function: fountainConfigurationWizardToolStripMenuItem_Click
        ///
        /// Author: Someone
        /// 
        /// History: Hema Dt: 11-12-2008 MT: 11871  
        ///         Hema Dt: 12-10-2008 MT: 12177 
        ///         Hema Dt: 12/16/2008 MT: 12164 
        ///         Hema MT: 13873  Dt: 09/01/09   
        ///         Hema MT: 15342  Dt: 04/03/2010
        ///         Hema MT: 15968  Dt: 06/30/2010
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         15-Apr-11, Mark C, MT16925:Convert OCU3 Zone width from centi meters to milli meters
        ///         23-Apr-13, Mark C, WI30347: Enable options according to the press type
        ///         16-Dec-14, spa, WI 51029 Add support for Tower mode.
        ///         27-May-15, Mark C, WI57901: Update status of Fountain Wizard controls in Tower Press
        ///         15-Oct-18, Mark C, WI177003: Add support for CIC Press Type 
        ///         07-July-20, Mark C, 200927: Correct display zones when total keys changes
        ///         21-July-20, Mark C, 200927: Update the Inker count when the total key count is > 44 ( Wide Press )
        /// 
        /// ]]>
        /// <summary>
        /// click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fountainConfigurationWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                MessageBox.Show("Please Configure SPUs before starting the Fountain wizard");
                return;
            }
            if ((m_bFileOpenMode == false) && m_bFountainConfigured == false)
            {
                GenerateFountainCount();
                if (IsWidePress)
                {
                    // validate and update the wide press details
                    ValidateWidePressData();
                }
            }
            else
            {
                // Wide Press - Special Case
                if( GetCurrentPress().MCClientInterface.WidePress )
                {
                    int currentInkerCount = 0;
                    Int32.TryParse( txtFountainCount.Text, out currentInkerCount );
                    int configurableInkerCount = ConfigurableFountain();
                    if( currentInkerCount > configurableInkerCount )
                    {
                        GenerateFountainCount();
                    }
                }
            }            

            m_bFountainConfigured = false;
            btnInkerInfo_Click(sender, e);
            stripPressConfig.Enabled = false;
            MCPressUnit mcUnit = GetCurrentPress().GetUnitAt(0);
            chkMM.Checked = true; // Hema 01/19/2009
            chkCms.Checked = chkInches.Checked = false;

            m_iOldKeysValue = int.Parse(txtKeysPerfountain.Text);
            MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
            txtKeysPerfountain.Text = mcConsoleZones.NumberOfZones.ToString();
            tbDisplayZones.Text = GetCurrentPress().DisplayKeys.ToString();
            //OCU3 - Zone width will always be in centi meters, changing this would make all existing site XML files invalid
            float OCU3ZoneWidthInMM = (mcConsoleZones.ZoneWidth * (float)UnitConverters.fCmsToMM);            
            txtKeyWidth.Text = OCU3ZoneWidthInMM.ToString();
            m_fKeyWidth = float.Parse(txtKeyWidth.Text);

            if (mcUnit != null)
            {
                mcCurrentInker = ((MCInker)(mcUnit.GetInkerAt(0)));//supports only unitized inker for now
                if (mcCurrentInker != null)
                {
                    LoadPressDetails(); // Hema
                }
                else
                    txtKeyWidth.Text = "1";        //hq
            }
            gpSiteInformation.Enabled = false;
            btnSave.Enabled = true; 
            gpPressConfigurations.Enabled = true;

            // Enable options according to the press type
            if ((GetCurrentPress().PressType == (int)enPressTypes.TOWER_PRESS) ||
                (GetCurrentPress().PressType == ((int)enPressTypes.MULTI_WEB_PRESS)))
            {
                this.rbtnOneToTwo.Enabled = true;
                this.rbtnOneToTwo.Checked = true;
                this.rbtnInkerOneToOne.Enabled = false;
                this.rbtnInkerOneToOne.Checked = false;
            }
            else
            {
                this.rbtnOneToTwo.Enabled = false;
                this.rbtnOneToTwo.Checked = false;
                this.rbtnInkerOneToOne.Enabled = true;
                this.rbtnInkerOneToOne.Checked = true;
            }
            
            // if the Web type is multi web press, then display 'Commercial Perfecting Web Press
            this.lstPressType.Items.Clear();
            this.lstPressType.Items.Add( GetPressTypeText( GetCurrentPress().PressType ) );            
            // Enable controls of Fountain Wizard in Tower Press
            UpdateTowerPressSettings( );

            // Disable the Wide Press, Funny Fountains, Virtual Inkers options, if the Press type is Single Sided CIC Press 
            if( GetCurrentPress().PressType == ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS )
            {
                this.cbFunnyfountains.Enabled = false;
                this.isWidePressCheckBox.Enabled = false;
                this.cbVirtualInkers.Enabled = false;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Apr-13, Mark C, WI30347: Created
        ///          27-May-15, Mark C, WI57901: Add support for Tower press
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///         
        /// ]]>
        /// <summary>
        /// Gets the press type text.
        /// </summary>
        /// <param name="pressType">Type of the press.</param>
        /// <returns>
        ///     Press type text to be displayed in the list control on Fountain selection dialog
        /// </returns>
        private string GetPressTypeText(int pressType)
        {
            string pressTypeText = "Unitized Press For Label Printing";

            switch(pressType)
            {
                case (int)enPressTypes.MULTI_WEB_PRESS:
                    {
                        pressTypeText = "Commercial Perfecting Web Press";
                    }
                    break;
                case (int)enPressTypes.SINGLE_WEB_PRESS:
                case (int)enPressTypes.UNITIZED_WEB_PRESS_NO_TURNBAR:
                case (int)enPressTypes.UNITIZED_WEB_PRESS_WITH_TURNBAR:
                    {
                        pressTypeText = "Unitized Press For Label Printing";
                    }
                    break;
                case ( int ) enPressTypes.TOWER_PRESS:
                    {
                        pressTypeText = "Tower Press";
                    }
                    break;
                case (int)enPressTypes.SINGLE_SIDED_CIC_PRESS:
                    {
                        pressTypeText = "Single Sided CIC Press";
                    }
                    break;
                default:
                    {
                        pressTypeText = "Unitized Press For Label Printing";
                    }
                    break;
            }

            return pressTypeText;
        }

        //======================================================================================
        /// <Function>GenerateFountainCount</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Fountain count generator
        /// </summary>
        /// <History>
        /// Hema Dt: 12/16/2008 MT: 12164 
        /// HQI:01/19/2009 decouple total units with number of SPUS.
        /// Hema MT: 15968  Dt: 06/30/2010
        ///     03-Apr-13, Mark C, WI30603: Changed to support more than 6 fountain ports per SPU
        ///     23-Nov-15, Mark C, WI63659: Use configurable Fountains as per configured #SPUs and 
        ///         number of ports per SPU
        /// </History>
        ///=====================================================================================
        private void GenerateFountainCount()
        {
            lock (txtFountainCount.Text)
            {
                txtFountainCount.Text = ConfigurableFountain().ToString();
            }
        }
        private void tstripOCUSettings_Click(object sender, EventArgs e)
        {
            frmOCUSettings frmOCUSettings = new frmOCUSettings();
            frmOCUSettings.CurrentPress = GetCurrentPress();
            frmOCUSettings.StartPosition = FormStartPosition.CenterParent;
            frmOCUSettings.ShowDialog();
            frmOCUSettings.Dispose();
        }

        private void nFSSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NFSTables frmNFS = new NFSTables();
            frmNFS.CurrentPress = GetCurrentPress();
            frmNFS.StartPosition = FormStartPosition.CenterParent;
            frmNFS.ShowDialog();
            frmNFS.Dispose();
        }

        private void toolstripcboSweeps_Click(object sender, EventArgs e)
        {

        }

        private void tStripcboWaters_Click(object sender, EventArgs e)
        {
        }

        private void tStripcboWaters_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to support this Water functions");

        }

        private void toolstripcboSweeps_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolTurnBars_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().TotalUnits == 0)
            {
                MessageBox.Show("Please Configure Fountains and units before setting up Turnbars");
                return;
            }
            Turnbars turnBar = new Turnbars();
            turnBar.CurrentPress = GetCurrentPress();
            turnBar.StartPosition = FormStartPosition.CenterScreen;
            turnBar.ShowDialog();
            turnBar.Dispose();
        }

        /// <![CDATA[
        /// 
        /// Function: btnSave_Click
        ///
        /// Author: Someone
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        ///          Hema, SEP-02-2010, ENH 16257, Add Password to the Config view
		///			 05-MAY-11, LMask, MT17043: Write out the full language name
        ///          05-Mar-12, Mark C, MT 17637: Update ShowHelp option
        ///          20-Mar-12, BEttinger, MT 17624: Update Show2SidesThumbs option
        ///          01-MAY-13, Mark C, WI30684: Removed support for 'Show2Sides' feature. This option is no longer 
        ///             useful since Mercury Client has Summary View available for all press types.
        ///          
        /// ]]>
        /// <summary>
        /// Handle the button save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <History>
        /// Hema MT: 13873  Dt: 09/01/09   
		/// MarkC WI 193061 8-20-2019 - check PLC sweep and PLC water types matching
        /// </History>
        private void btnSave_Click(object sender, EventArgs e)
        {
            MCPressInfo currentPress = GetCurrentPress();
            WaterControlInterface waterInterface = currentPress.WaterInterface;
            SweepControlInterface sweepInterface = currentPress.SweepInterface;

            if( currentPress.InkerList.Count <= 0 )
            {
                MessageBox.Show("Please Configure Fountains before saving the settings");
                return;
            }
            Point ptProblemRow;
            this.ListViewInkers.Refresh();
            if (IsWidePress)
            {
                m_bSecondListView = true;
                ptProblemRow = ValidateWidePressInkerListViewData();
            }
            else
            {
                ptProblemRow = ValidateInkerListViewData();
            }
            if (ptProblemRow.X >= 0)   //error occured
            {
                //set the selection and return
                ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Select();
                ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Invalidate();
                return;
            }
            //MT#11800
            if (!checkSiteEntries())
                return;

            List< string > messages = new List<string>();
            if( currentPress.GetTotalSPUS() == 0 )
            {
                messages.Add( "No SPUs Configured" );
            }

            if( currentPress.TotalUnits == 0 )
            {
                messages.Add( "No Fountains/Units Defined" );
            }
            // check for the Runtime Password field
            if (string.IsNullOrEmpty(tbRuntimePassword.Text))
            {
                messages.Add("No Runtime Password Defined");
            }

            // check for the Diagnostic Password field
            if (string.IsNullOrEmpty(tbDiagnosticPassword.Text))
            {
                messages.Add("No Diagnostic Password Defined");
            }
            // check for the Configuration Password field
            if (string.IsNullOrEmpty(tbConfigurationPassword.Text))
            {
                messages.Add("No Configuration Password Defined");
            }
            // check for the Exit Password field
            if (string.IsNullOrEmpty(tbExitPassword.Text))
            {
                messages.Add("No Exit Password Defined");
            }

            // Validate the ip address if the clc flag is set
            // Save the values if they are valid
            currentPress.IsCLCOEM = isCLCOEMCheckBox.Checked;
            if( isCLCOEMCheckBox.Checked )
            {
                string cqIPAddress = cqIPAddressTextBox.Text;
                if( IsValidIPAddress( cqIPAddress ) )
                {
                    currentPress.CLCIPAddress = cqIPAddress;
                }
                else
                {
                    messages.Add( "Invalid " + ipAddressLabel.Text );
                }

                if( IsValidPort( cqPortTextBox.Text ) )
                {
                    currentPress.CLCCQPort = Convert.ToUInt16( cqPortTextBox.Text );
                }
                else
                {
                    messages.Add( "Invalid " + portLabel.Text );
                }
            }

			if(currentPress.MCClientInterface.SweepControl && currentPress.MCClientInterface.WaterControl)
			{
				if(sweepInterface.IsPLCUsed && waterInterface.IsPLCUsed)	//if PLC Sweep and PLC water, the same type must be selected
				{
					if( sweepInterface.PLCType.CompareTo(waterInterface.PLCType) != 0 )
						messages.Add( "PLC Sweep and PLC Water must match" );	//if not, water interface will crash the App Server
						
				}
			}
            if( messages.Count > 0 )
            {
                string message = "Cannot save:\n\n" + string.Join( "\n", messages.ToArray() );
                MessageBox.Show( message, "Save Error" );
                return;
            }
            string strLanguageCulture = this.cbLanguages.Text;
            currentPress.PressClientInterface.CurrentLanguage = strLanguageCulture;
            currentPress.PressClientInterface.ShowHelp = this.checkBoxHelp.Checked;            

            m_bNewFileOpen = false;
            createMcNSiteFile();
//            closeTheConfiguration();          //if save system config file, remain to edit same information
        }

        //======================================================================================
        /// <Function>ValidateWidePressInkerListViewData</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-01-2009</Date>
        /// <summary>
        /// Validates WidePress InkerListView Data
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 09/01/2009 MT: 13873
        /// </History>
        ///=====================================================================================
        private Point ValidateWidePressInkerListViewData()
        {
            Point ptProblemRow = new Point(-1, -1);     //used for record the cell (col and row) that has problem
            for (int iCol = 0; iCol < this.ListViewInkers.Columns.Count; iCol++)
            {
                switch ((WidePressListviewColumnHead)iCol)
                {
                    case WidePressListviewColumnHead.RailInkerName: //inker name
                        break;
                    case WidePressListviewColumnHead.KeyalignMent:
                        {
                        }
                        break;
                    case WidePressListviewColumnHead.SPUName:  //ListviewColumnHead.SPUPortNumber:
                        {
                            {
                                //check to see if more than one inkers are to be assigned to the same port 
                                for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                                {
                                    string strName = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;
                                    string strPort = this.ListViewInkers.Items[iRow].SubItems[iCol - 1].Control.Text;

                                    if (DuplicatedSPUPortEntered(strName, strPort))
                                    {
                                        ptProblemRow.X = iCol;
                                        ptProblemRow.Y = iRow;
                                        MessageBox.Show("More than one SPU Name have been assigned to the same SPU port");
                                        break; ;
                                    }
                                }
                            }
                        }
                        break;
                    case WidePressListviewColumnHead.SPUPortNumber:// ListviewColumnHead.SPUPortNumber2: //inker name
                        {
                            {
                                for (int iRow = 0; iRow < this.ListViewInkers.Items.Count; iRow++)
                                {
                                    string strName = this.ListViewInkers.Items[iRow].SubItems[iCol - 1].Control.Text;
                                    string strPort = this.ListViewInkers.Items[iRow].SubItems[iCol].Control.Text;

                                    if (DuplicatedSPUPortEntered(strName, strPort))
                                    {
                                        ptProblemRow.X = iCol;
                                        ptProblemRow.Y = iRow;
                                        MessageBox.Show("More than one inkers have been assigned to the same SPU port");
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (ptProblemRow.X >= 0)
                    break;
            }
            return ptProblemRow;
        }

        private bool IsValidIPAddress( string addressText )
        {
            // Check to see if the address is a valid address
            // by whether or not it can be converted to a good address

            bool isValidAddress = false;

            if( addressText.Equals( "localhost", StringComparison.InvariantCultureIgnoreCase ) )
            {
                isValidAddress = true;
            }
            else
            {
                try
                {
                    IPAddress address = IPAddress.Parse( addressText );
                    isValidAddress = true;
                }
                catch( ArgumentNullException )
                {
                    // Do nothing
                }
                catch( FormatException )
                {
                    // Do nothing
                }
            }

            return isValidAddress;
        }

        private bool IsValidPort( string portText )
        {
            bool isValidPort = false;
            try
            {
                ushort port = Convert.ToUInt16( portText );
                isValidPort = true;
            }
            catch( FormatException )
            {
                // Do nothing
            }
            catch( OverflowException )
            {
                // Do nothing
            }

            return isValidPort;
        }

        //======================================================================================
        /// <Function>activateSaveCancel</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// sPU Information ToolStrip MenuItem Click
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11801 
        /// </History>
        ///=====================================================================================
        private void activateSaveCancel(bool bStatus)
        {
            btnSave.Visible = bStatus;
            btnCloseNew.Visible = bStatus;
        }

        private void rButtonTurnbars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTurnBar_CheckedChanged(object sender, EventArgs e)
        {
            if (m_bNewFileOpen == false)
                return;
            GetCurrentPress().PressType = (1 - GetCurrentPress().PressType);
        }

        //======================================================================================
        /// <Function>btnBack_Click</Function>
        /// <Author>    </Author>
        /// <Date>Sep-01-2009</Date>
        /// <summary>
        /// Back button Click event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 09/01/2009 MT: 13873
        /// </History>
        ///=====================================================================================
        private void btnBack_Click(object sender, EventArgs e)
        {            
            if (m_iFountainWzrdState == (int)FountainWizardStates.Third) //hq: last page "Finish" button
            {
                Point ptProblemRow;
                this.ListViewInkers.Refresh();
                if (IsWidePress)
                {
                    if(iFirstView == 2)
                    {
                        ptProblemRow = ValidateWidePressInkerListViewData();
                    }
                    else
                    {
                        ptProblemRow = ValidateInkerListViewData();
                        m_iFountainWzrdState = m_iFountainWzrdState - 2;
                    }
                }
                else
                {
                    ptProblemRow = ValidateInkerListViewData();
                }
                if (ptProblemRow.X >= 0)   //error occured
                {
                    //set the selection and return
                    ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Select();
                    ListViewInkers.Items[ptProblemRow.Y].SubItems[ptProblemRow.X].Control.Invalidate();
                    return;
                }
                ArrayList ayInkerRecords = new ArrayList();
                if (IsWidePress)
                {
                    if (iFirstView == 2)
                    {
                        GetDataFromSecondListView(ref ayInkerRecords);
                        SaveSecondListViewRecords(ayInkerRecords);
                    }
                    else
                    {
                        GetDataFromInkerListView(ref ayInkerRecords);
                        SaveInkerRecords(ayInkerRecords);
                    }
                }
                else
                {
                    GetDataFromInkerListView(ref ayInkerRecords);
                    SaveInkerRecords(ayInkerRecords);
                }
            }
            btnNext.Enabled = true;
            if (IsWidePress)
            {
                if (!m_bFirstListView)
                {
                    m_bFirstListView = true;
                    m_bSecondListView = false;
                }
                if (m_bSecondListView)
                {
                    m_bFirstListView = true;
                    m_bSecondListView = false;
                }
                if (iFirstView == 2)
                {
                    btnNext.Visible = true;
                }
                else
                {
                    m_iFountainWzrdState = m_iFountainWzrdState - 2;
                }
            }
            else
            {
                // go two steps back.
                m_iFountainWzrdState = m_iFountainWzrdState - 2;
            }            
            if (m_iFountainWzrdState <= 0)
            {
                m_iFountainWzrdState = 0;
                btnBack.Enabled = false;
            }
            SwitchFountainWzrdStates();             //end of the back button
        }

        /// <![CDATA[
        /// 
        /// Function: GetDataFromSecondListView
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema Kumar Dt: 09/01/2009 MT: 13873
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///         MarkC Oct 29, 2011 MT 17347 allow NA for SPU name
        /// 
        /// ]]>
        /// <summary>
        /// Get Data From SecondListView for wide press
        /// </summary>
        /// <param name="ayInkerRecords"></param>
        private void GetDataFromSecondListView(ref ArrayList ayInkerRecords)
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            for (int i = 0; i < ListViewInkers.Items.Count; i++)
            {
                WIDEPRESS_INKER_DETAIL_RECORD aRec = new WIDEPRESS_INKER_DETAIL_RECORD();
                for (int iCol = 0; iCol < this.ListViewInkers.Columns.Count; iCol++)
                {
                    switch (iCol)
                    {
                        case (int)WidePressListviewColumnHead.RailInkerName://inker name
                            aRec.strInkerRail = this.ListViewInkers.Items[i].SubItems[iCol].Control.Text;
                            break;
                        case (int)WidePressListviewColumnHead.KeyalignMent: //op side
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.bOpSide = (cmb.SelectedIndex != 0) ? true : false;
                            }
                            break;
                        case (int)WidePressListviewColumnHead.StartKey: //start key
                            {
                                aRec.iRailStartKey = Convert.ToInt32(this.ListViewInkers.Items[i].SubItems[iCol].Control.Text);
                            }
                            break;
                        case (int)WidePressListviewColumnHead.TotalKeys: //number of keys
                            {
                                aRec.iRailTotalKeys = int.Parse(this.ListViewInkers.Items[i].SubItems[iCol].Control.Text);
                            }
                            break;
                        case (int)WidePressListviewColumnHead.KeyWidth: //keys width
                            {
                                aRec.fKeyWidth = float.Parse(this.ListViewInkers.Items[i].SubItems[iCol].Control.Text);
                            }
                            break;
                        case (int)WidePressListviewColumnHead.SPUName:     //SPU Num
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.strRailSPUName = cmb.Text;
//                                if (aRec.strRailSPUName == "NA")    // MT17347
//                                    aRec.strRailSPUName = "";
                            }
                            break;
                        case (int)WidePressListviewColumnHead.SPUPortNumber:     //SPU port
                            {
                                ComboBox cmb = this.ListViewInkers.Items[i].SubItems[iCol].Control as ComboBox;
                                aRec.iRailSPUPortNum = Convert.ToInt32(cmb.Text);
                            }
                            break;
                        default:
                            break;
                    }
                }
                ayInkerRecords.Add(aRec);
            }
        }

        //======================================================================================
        /// <Function>ConfigurableFountain</Function>
        /// <Author>    </Author>
        /// <Date>Sep-01-2009</Date>
        /// <summary>
        /// ConfigurableFountain
        /// </summary>
        /// <History>
        /// Suresh  Jan-29-2010, MT: 15094
        /// Hema, Juny-02-2010, MT: 15968
        ///     03-Apr-13, Mark C, WI30603: Changed to support more than 6 Fountain ports per SPU
        ///     23-Apr-13, Mark C, WI30347: Added support for MULTI_WEB_PRESS
        ///     23-Nov-15, Mark C, WI63659: Fix logic to calculate number of Fountains configurable
        ///         based on the number of SPUs and number of ports per SPU.
        /// </History>
        ///=====================================================================================
        private int ConfigurableFountain()
        {
            int totalSPUsConfigured = GetCurrentPress( ).GetTotalSPUS( );
            int maxFountainPortCount = GetCurrentPress( ).MaxFountainPortCountPerSPU;
            // calculate max number of Fountains configurable
            int configurableFountainCount = ( totalSPUsConfigured * maxFountainPortCount );

            if ( IsWidePress )
            {
                // In Wide press, each Fountain is split between two SPU ports
                configurableFountainCount /= 2;
            }

            return configurableFountainCount;
        }

        //======================================================================================
        /// <Function>txtFountainCount_TextChanged</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txt FountainCount Text Changed event
        /// </summary>
        /// <History>
        /// Hema Dt: 12/16/2008 MT: 12164
        /// Hema Kumar Dt: 09/01/2009 MT: 13873
        /// Suresh  Feb-01-2010, MT: 15094
        /// 27-May-15, Mark C, WI57901: Corrected the error message when number of Inkers is more than
        ///             the actual number of Inkers that can be controlled by the configured number of SPUs.
        /// 23-Nov-15, Mark C, WI63659: Default Fountain count to number of ports configured per SPU.
        /// 
        /// </History>
        ///=====================================================================================
        private void txtFountainCount_TextChanged(object sender, EventArgs e)
        {
            int totalSPUs = GetCurrentPress().GetTotalSPUS();
            int configurableFountains = ConfigurableFountain();
            Regex regex = new Regex("^[0-9]*$");
            int iCurrentTotalFountains = configurableFountains;
            if (!regex.IsMatch(txtFountainCount.Text))
            {
                if (iCurrentTotalFountains == 0)
                    txtFountainCount.Text = GetCurrentPress().MaxFountainPortCountPerSPU.ToString();
                else
                    txtFountainCount.Text = iCurrentTotalFountains.ToString();
                return;
            }
            checkNullEntries();
            if (txtFountainCount.Text == "")
                return;

            //we should not allow the user to enter more than the configurable fountains
            int iTotalFountains = int.Parse(txtFountainCount.Text);
            // 20240315 Mark C allow total fountain count to exceed SPU config with Virtual Inkers option
            if ((iTotalFountains > iCurrentTotalFountains) && !GetCurrentPress().ClientInterface.VirtualInkers) 
            {
                string message = string.Format( "Cannot add {0} Fountains. Number of SPUs Configured = {1}, Max Configurable Fountains = {2}",
                    iTotalFountains, totalSPUs, configurableFountains );
                MessageBox.Show( message );
                txtFountainCount.Text = iCurrentTotalFountains.ToString();
            }
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            string strServoTurns = txtServoTurns.Text;
            string strMinConsole = txtMinConsole.Text;
            string strMaxConsole = txtMaxConsole.Text;
            string strLinTableSize = txtLintableSize.Text;

            int iTotalUnits = GetCurrentPress().TotalUnits;
            for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
            {
                MCPressUnit mcUnit = GetCurrentPress().GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                {
                    MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    //cboInkerList.Items.Add(mcInker.InkerName);
                    mcInker.ServoTurns = strServoTurns;
                    mcInker.MaxConsole = strMaxConsole;
                    mcInker.MinConsole = strMinConsole;
                    mcInker.LinTableSize = strLinTableSize;
                }
            }
        }

        //======================================================================================
        /// <Function>cboInkerList_SelectedIndexChanged</Function>
        /// <Author> </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// cboBox InkerList Selected Index Changed Event
        /// </summary>
        /// <History>
        ///     Hema Dt: 01/12/2009 MT: 12324  
        /// </History>
        ///=====================================================================================
        private void cboInkerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pdateInkerData();
            SetCurrentInker();
            UpdateDataToUI();
            if (cboInkerList.SelectedIndex < 0)
                btnInkerNameChange.Enabled = false;
            else
                btnInkerNameChange.Enabled = true;
            m_iSelectedInker = cboInkerList.SelectedIndex;  
        }

        //======================================================================================
        /// <Function>UpdateDataToUI</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data To UI
        /// </summary>
        /// <History>
        /// Hema Dt: 11/21/2008 MT # 11871, 11872
        /// </History> 
        ///=====================================================================================
        public void UpdateDataToUI()
        {
            ServoBanks servoBank = mcCurrentInker.GetServoBankAt(0);
            int iTotalKeysToCtrl = 0;
            if (servoBank != null)
            {
                cboSPU.Text = servoBank.SPUName; ;
                txtPortOnInker.Text = servoBank.PortOnSPU.ToString();
                iTotalKeysToCtrl = servoBank.TotalKeys;
                //txtTotalKeysToCtrl.Text = servoBank.TotalKeys.ToString();
                txtTotalKeysToCtrl.Text = iTotalKeysToCtrl.ToString();
                txtFirstKey.Text = servoBank.StartKey.ToString();
            }
            // tood, add servo bank 2.
            chkInverted.Checked = mcCurrentInker.Inverted;
            chkUpperInker.Checked = mcCurrentInker.UpperOrLower;
            txtServoTurns.Text = mcCurrentInker.ServoTurns;
            txtMinConsole.Text = mcCurrentInker.MinConsole;
            txtMaxConsole.Text = GetCurrentPress().OCUInterface.MaxValue.ToString();//mcCurrentInker.MaxConsole;
            mcCurrentInker.MaxConsole = GetCurrentPress().OCUInterface.MaxValue.ToString();
            txtLintableSize.Text = mcCurrentInker.LinTableSize;
            //int iTotalInker = mcCurrentInker.TotalKeys;
            //txtTotalKeysToCtrl.Text = iTotalInker.ToString();

            //if (iTotalInker == 0)
            //    checkBoxVirtualInker.Checked = true;
            //else
            //    checkBoxVirtualInker.Checked = false;
            if (iTotalKeysToCtrl == 0)
                checkBoxVirtualInker.Checked = true;
            else
                checkBoxVirtualInker.Checked = false;
        }

        //======================================================================================
        /// <Function>SetCurrentInker</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Set Current Inker
        /// </summary>
        /// 
        ///=====================================================================================
        public void SetCurrentInker()
        {
            int iUnit = cboInkerList.SelectedIndex;
            if (iUnit < 0)
            {
                return;
            }
            MCPressUnit mcUnit = GetCurrentPress().GetUnitAt(iUnit);
            if (mcUnit == null)
                return;
            mcCurrentInker = ((MCInker)(mcUnit.GetInkerAt(0)));/*supports only unitized inker for now*/
        }

        private void cboSPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            servoBank.SPUName = cboSPU.Text;
        }
        ServoBanks GetServoBankforCurrentInker(int iBank)
        {
            return mcCurrentInker.GetServoBankAt(iBank);
        }

        private void txtPortOnInker_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtPortOnInker.Text))
            {
                txtPortOnInker.Text = "1";
            }

            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            checkNullEntriesForFountainConfigurations(); //Nov-06-2008
            if (txtPortOnInker.Text == "")
            {
                return;
                //txtPortOnInker.Text = servoBank.PortOnSPU.ToString();
            }
            servoBank.PortOnSPU = int.Parse(txtPortOnInker.Text);
        }

        private void txtTotalKeysToCtrl_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtTotalKeysToCtrl.Text))
            {
                txtTotalKeysToCtrl.Text = txtKeysPerfountain.Text; ;
            }

            //ServoBanks servoBank = GetServoBankforCurrentInker(0);
            //if (servoBank == null)
            //    return;
            //checkNullEntriesForFountainConfigurations(); //Nov-06-2008
            //if (txtTotalKeysToCtrl.Text == "")
            //{
            //    return;
            //    //txtTotalKeysToCtrl.Text = servoBank.TotalKeys.ToString();
            //}
            //servoBank.TotalKeys = int.Parse(txtTotalKeysToCtrl.Text);
        }

        private void txtFirstKey_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtFirstKey.Text))
            {
                txtFirstKey.Text = "0";
            }

            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            checkNullEntriesForFountainConfigurations(); //Nov-06-2008
            if (txtFirstKey.Text == "")
            {
                return;
                //txtFirstKey.Text = servoBank.StartKey.ToString();
            }
            servoBank.StartKey = int.Parse(txtFirstKey.Text);
        }

        //Added for MT#11808 by Suresh on Nov-06-2008
        private void checkNullEntriesForFountainConfigurations()
        {
            if (txtServoTurns.Text == "" || txtFirstKey.Text == "" || txtTotalKeysToCtrl.Text == "" || txtPortOnInker.Text == "")
                this.btnCancel.Enabled = false;
            else
                this.btnCancel.Enabled = true;
        }

        private void chkUpperInker_CheckedChanged(object sender, EventArgs e)
        {
            mcCurrentInker.UpperOrLower = !mcCurrentInker.UpperOrLower;
        }

        //======================================================================================
        /// <Function>chkInverted_CheckedChanged</Function>
        /// <Author>        </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// chkInverted_CheckedChanged event
        /// </summary>
        /// <History>Hema Kumar Dt:11/18/2008 MT# 11872
        /// 
        /// </History> 
        ///=====================================================================================
        private void chkInverted_CheckedChanged(object sender, EventArgs e)
        {
            //mcCurrentInker.Inverted = !mcCurrentInker.Inverted;
            if (chkInverted.Checked)
                mcCurrentInker.Inverted = true;
            else
                mcCurrentInker.Inverted = false;
        }

        //======================================================================================
        /// <Function>txtServoTurns_TextChanged</Function>
        /// <Author>        </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txtServoTurns_TextChanged event
        /// </summary>
        /// <History>Hema Kumar Dt:11/20/2008 MT# 12062 
        /// 
        /// </History> 
        ///=====================================================================================
        private void txtServoTurns_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");  
            if (!regex.IsMatch(txtServoTurns.Text))
            {
                txtServoTurns.Text = "0.7";//mcCurrentInker.MinConsole;
            }
            checkNullEntriesForFountainConfigurations(); //Nov-06-2008
            if (txtServoTurns.Text == "")
            {
                return;
            }
            //float fSTurns = float.Parse(txtServoTurns.Text);
            //if (fSTurns < 0.25f || fSTurns > 1.25)
            //{
            //    MessageBox.Show("Not Supported");
            //    txtServoTurns.Text = "";
            //    return;
            //}
            //mcCurrentInker.ServoTurns = txtServoTurns.Text;
        }

        private void txtMinConsole_TextChanged(object sender, EventArgs e)
        {
            if (txtMinConsole.Text == "")
                return;
            int iMin = int.Parse(txtMinConsole.Text);
            if (iMin < 0 || iMin > 99)
            {
                MessageBox.Show("Not Supported");
                txtMinConsole.Text = "";
                return;
            }
            mcCurrentInker.MinConsole = txtMinConsole.Text;
        }

        private void txtMaxConsole_TextChanged(object sender, EventArgs e)
        {
            if (txtMaxConsole.Text == "")
                return;
            int iMin = int.Parse(txtMaxConsole.Text);
            //if (iMin < 0 || iMin > 99)
            if (iMin < 0 || iMin > DefineAndConst.SystemCapacities.MAX_SERVOCONSOLE_VALUE)
            {
                MessageBox.Show("Not Supported");
                txtMaxConsole.Text = "";
                return;
            }
            mcCurrentInker.MaxConsole = txtMaxConsole.Text;
        }

        private void txtLintableSize_TextChanged(object sender, EventArgs e)
        {
            if (mcCurrentInker == null)
                return;
            if (txtLintableSize.Text == "")
                return;
            int iMin = int.Parse(txtLintableSize.Text);
            if (iMin < 0)
            {
                MessageBox.Show("Not Supported, should be either 150/200/250");
                txtLintableSize.Text = "";
                return;
            }

            mcCurrentInker.LinTableSize = txtLintableSize.Text;
        }
        //======================================================================================
        /// <Function>ReadMC3ClientPathFile</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// Read the MC3 Client Path file
        /// </summary>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Read help path XT_MCCLIENT_HELP_PATH from the Site XML file
        ///         28-Apr-15, Mark C, WI55780: Read help path XT_MCCLIENT_LOG_FILES_PATH from the Site XML file
        /// </history> 
        ///=====================================================================================
        private void ReadMC3ClientPathFile(string strFilePath)
        {
            
            try
            {
                string sStartupPath = Application.StartupPath;
                XmlTextReader objXmlTextReader = new XmlTextReader(strFilePath);
               
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            {

                                Hashtable attributes = new Hashtable();
                                string strName = objXmlTextReader.Name;
                                for (int iCount = 0; iCount < objXmlTextReader.AttributeCount; iCount++)
                                {
                                    objXmlTextReader.MoveToAttribute(iCount);
                                    attributes.Add(objXmlTextReader.Name, objXmlTextReader.Value);

                                }

                                IDictionaryEnumerator _enumerator = attributes.GetEnumerator();

                                while (_enumerator.MoveNext())
                                {
                                    switch (strName)
                                    {

                                        case XMLNodeDictionary.XT_MC_CLIENT_PATH_CONFIG:
                                            {
                                            }
                                            break;

                                        case XMLNodeDictionary.XT_MCCLIENT_ACT_OPTIONS_PATH:
                                            {
                                                m_mcClientConfigData.ClientConfigPath= _enumerator.Value.ToString();
                                            }
                                            break;
                                            // help path from Site XML
                                        case XMLNodeDictionary.XT_MCCLIENT_HELP_PATH:
                                            {
                                                m_mcClientConfigData.HelpPath = _enumerator.Value.ToString();
                                            }
                                            break;
                                        case XMLNodeDictionary.XT_MCCLIENT_KEYBOARD_LAYOUTS_PATH:
                                            {
                                                m_mcClientConfigData.KBDLayoutFolder = _enumerator.Value.ToString();
                                            }
                                            break;
                                            // Log Files path
                                        case XMLNodeDictionary.XT_MCCLIENT_LOG_FILES_PATH:
                                            {
                                                m_mcClientConfigData.LogFilesPath = _enumerator.Value.ToString( );
                                            }
                                            break;
                                    }
                                }
                            }
                            break;
                    }
                }
                objXmlTextReader.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //======================================================================================
        /// <Function>ReadMC3ServerPathFile</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// Read the MC3 Server Path file
        /// </summary>
        /// <history>
        ///     29-May-19, Mark C, WI177016: Add support for reading the Job Management paths from App Server path file
        /// </history> 
        ///=====================================================================================
        private void ReadMC3ServerPathFile(string strFilePath)
        {
            string strValue = "";
            try
            {
                string sStartupPath = Application.StartupPath;
                XmlTextReader objXmlTextReader = new XmlTextReader(strFilePath);
               
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:

                            Hashtable attributes = new Hashtable();
                            string strName = objXmlTextReader.Name;
                            for (int iCount = 0; iCount  < objXmlTextReader.AttributeCount; iCount ++)
                            {
                                objXmlTextReader.MoveToAttribute(iCount );
                                attributes.Add(objXmlTextReader.Name, objXmlTextReader.Value);
                                              
                            }
                            
                            IDictionaryEnumerator _enumerator = attributes.GetEnumerator();

                            while (_enumerator.MoveNext())
                            {
                                switch (strName)
                                {

                                    case XMLNodeDictionary.XT_MC_SERVER_PATH_CONFIG:
                                        break;

                                    case XMLNodeDictionary.XT_MCSYSTEM_PATH:

                                        strValue = _enumerator.Value + "\n";
                                        m_mcPathConfigData.SystemPath = _enumerator.Value.ToString(); 
                                        break;

                                    case XMLNodeDictionary.XT_MCAPPLICATIONDATA_PATH:

                                        strValue = _enumerator.Value + "\n";
                                        m_mcPathConfigData.ApplicationData = _enumerator.Value.ToString();
                                        break;

                                   case XMLNodeDictionary.XT_MCLOG_PATH:

                                       strValue = _enumerator.Value + "\n";
                                       m_mcPathConfigData.LogPath = _enumerator.Value.ToString();
                                       break;

                                   case XMLNodeDictionary.XT_MCSYSTEM_RUNTIME_PATH:

                                       strValue = _enumerator.Value + "\n";
                                       m_mcPathConfigData.SystemRuntimeConfigPath = _enumerator.Value.ToString();
                                       break;

                                   case XMLNodeDictionary.XT_MCJOBS_XML_PATH:
                                       strValue = _enumerator.Value + "\n";
                                       m_mcPathConfigData.JobsPath = _enumerator.Value.ToString();
                                       break;

                                    case XMLNodeDictionary.XT_MCJOBS_ARCHIVE_PATH:
                                       strValue = _enumerator.Value + "\n";
                                       m_mcPathConfigData.JobsArchivePath = _enumerator.Value.ToString();
                                       break;

                                    case XMLNodeDictionary.XT_FORM_TEMPLATE_PATH:
                                       strValue = _enumerator.Value + "\n";
                                       m_mcPathConfigData.FormTemplatePath = _enumerator.Value.ToString();
                                       break;                                                 
                                }
                            }
                        break;
                    }
                }
                objXmlTextReader.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <![CDATA[
        ///  
        /// Function: ReadSiteXMLFile
        /// 
        /// Author: Hema Kumar, Sep-21-2008
        /// 
        /// History: 
        ///       
        /// Hema Kumar Dt: 11-12-2008 
        ///     Modified to edit the spu data
        /// Hema Dt: 11/19/2008 MT: 11891
        /// Hema Dt: 12-10-2008 MT: 12177 
        /// Hema Dt: 05/27/2009 MT: 13405
        /// Hema Dt: 07/09/2009 MT: 12885
        /// LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// Hema Kumar Dt: 09/01/2009 MT: 13873
        /// Sreejit MT: 15294  Dt: 12/03/10, Add PLC Crabtree Ductor Control
        /// Suresh MT: 14611  Dt: Mar-25-10
        /// Suresh, MAY-07-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data
        /// Hema, SEP-02-2010, ENH 16257: to provide the password to the MC3 client config view
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// MarkC Jun 20, 2011 - MT 16792 - new PLC type Dtoa Sweep and Water settings
        /// 07-Feb-12, Mark C, MT 17529: Added support for AutoZeroServos option
        /// 05-Mar-12, Mark C, MT 17637: Added support for ShowHelp option
        /// 20-Mar-12, BEttinger, MT 17624: Added support for Show2SidesThumbs option
        /// 13-AUG-12, Mark C, WI28788: Added support for PressAutoZero settings
        /// 17-AUG-12, Mark C, WI29261: Corrected reading the siteXML logic        
        /// 10-Sep-12, Mark C, WI 29423: Added support for new parameter 'DelayForFountainClose' in
        ///         Auto Zero settings
        /// 03-Apr-13, Mark C, WI30603: Added support for new parameter 'MAX_FOUNTAIN_PORTS' in 
        ///     SPU configuration.
        /// 23-Apr-13, Mark C, WI30347: Added support for Multi Web Press 
        /// 01-MAY-13, Mark C, WI30684: Removed support for 'Show2Sides' feature. This option is no longer 
        ///     useful since Mercury Client has Summary View available for all press types.
        ///     05-May-13, BEttinger, WI30488: added code for multiple source Auto Zero
        /// 10-Jun-13, Mark C, WI30950: Added support for Product Options >> Jobs Management mode
        /// 23-Oct-13, Mark C, WI33030: Added support for Product Options >> Keep Only Last Version Profiles
        /// MarkC 11/6/12 WI29958 add AB PLC5 type 
        /// MarkC 4/14/13 MT18082 add HO_MOTOR and HO_DTOA PLC types
        /// Apr-25-2014 WI36833  MarkC fixed FRQ sensors and mapping for AZ section.
		/// 21-Apr-14, Mark C, WI36192: Added support for reading IP Address of SPU
        /// 27-May-14, Mark C, WI37511: Added support for Product Options >> Prompt for 'Zero All Inker' needed
        ///     on every restart of Server
        /// 03-Sept-14, Mark C, WI40392: Added support for reading the type of communication between SPU3 & Server
        /// 28-Oct-14, Mark C, WI41821: Added support for reading the IP Address and Port number of Mercury Server for
        ///     SPU3 Ethernet interface
        /// 16-Dec-14, spa, WI 51029 Add support for Tower mode.
        /// 06-Jan-2015, spa 51032 Add Imposition data field
        /// 27-May-15, Mark C, WI57901: Update the data member 'UpperOrLowerInker' of MCInker objects.
        /// 23-Feb-16, Mark C, WI68970: Add support for Mercury Newspaper Navigation View option
        /// 09-Aug-16, Mark C, WI81328: Add support for label Towers with numbers option
        /// 06-Dec-16, Mark C, WI67306: Read Mercury Server options from Site XML file
        /// 19-Jul-17, Mark C, WI102725: Read AVT PLC Configuration data from Site XML file
        /// 03-Aug-17, Mark C, WI102725: Fix issues of reading water PLC parameters. Also, add support for new 
        ///     ramping parameters of AVT PLC >> Ramping >> Press Speed parameters
        /// 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        /// 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        /// 21-Dec-17, Mark C, WI145675: Add support for new Ramp curve parameters 
        /// 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        /// 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 05-Nov-18, Mark C, WI182050: Add support for 'Sync Sweep / Water console values' option
        /// 16-Oct-18 dlg, (177483) Add AVT PLC support for Manual Register
        /// 17-Dec-18 dlg, (183514) Add auto run delay time
        /// 29-May-19, Mark C, WI188815: Add support for Ardagh Manual Plate Register interlock options
        /// ]]>
        /// <summary>
        /// Read the site file
        /// </summary>
        /// <param>strFilePath</param>
        /// 
        private void ReadSiteXMLFile(string strFilePath)
        {
            // Is siteXML file exists?
            if (!File.Exists(strFilePath))
            {
                MessageBox.Show("Site XML not found:" + strfilePath);
				return;
            }

            MCPressInfo mcTempPressInfo = GetCurrentPress();
            try
            {
                int pressUnitIndex = -1;
                int inkerIndex = -1;
                int servoBankIndex = -1;
                int byTurnBar = -1;
                int bySPU = -1;
                int airBarCounter = -1;

                bool inSweepControl = false, inWaterControl = false;
                bool inAutoTest = false;
                   //WI30488
                byte byChannId = 0xFF;
                string strUnitName = "";
                int sweepRangeIndex = -1;


                // Load the XML document
                XmlTextReader xmlReader = new XmlTextReader(strFilePath);
                while (xmlReader.Read())
                {
                    // is the current node an element node type?
                    if (xmlReader.NodeType != XmlNodeType.Element)
                    {
                        continue;
                    }
                    string nodeName = xmlReader.Name;
                    // I don't like the way this method was written earlier with .NET 2.0.
                    // Most of the OOP concepts were broken and it was working correctly just by accidentally
                    // and not really working as it was coded ;(

                    // The logic below would take care of resetting the index for specific parameters 
                    // and incrementing indices as XML reading progresses...
                    switch (nodeName)
                    {
                        case XMLNodeDictionary.XT_PRESS_UNITS:
                            {
                                pressUnitIndex = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_INKERS:
                            {
                                inkerIndex = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS:
                            {
                                servoBankIndex = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_PRESS_TURN_BARS:
                            {
                                byTurnBar = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_MCPRESS_SPUS:
                            {
                                bySPU = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_PRESS_UNIT:
                            {
                                pressUnitIndex++;
                            }
                            break;
                        case XMLNodeDictionary.XT_INKER:
                            {
                                inkerIndex++;
                            }
                            break;
                        case XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS:
                            {
                                servoBankIndex++;
                            }
                            break;
                        case XMLNodeDictionary.XT_PRESS_TURN_BAR:
                            {
                                byTurnBar++;
                            }
                            break;
                        case XMLNodeDictionary.XT_MCPRESS_SPU:
                            {
                                bySPU++;
                            }
                            break;
                            //WI30488
                        case XMLNodeDictionary.XT_PRESS_AZ_MAPPING_ELEMENT:
                            {
                            }
                            break;
                        case XMLNodeDictionary.XT_PRESS_AZ_DRY_CHANNELS_MAPPING:
                            {
                            }
                            break;
                        case XMLNodeDictionary.XT_PRESS_AZ_FREQUENCY_CHANNELS_MAPPING:
                            {
                            }
                            break;
                        case XMLNodeDictionary.XT_AIR_BARS:
                            {
                                airBarCounter = -1;
                            }
                            break;
                        case XMLNodeDictionary.XT_AIR_BAR:
                            {
                                airBarCounter++;
                            }
                            break;
                        case XMLNodeDictionary.XT_PRODUCT_OPTIONS:
                            {
                                // do nothing for now.
                            }
                            break;
                        // Mercury Server Configuration
                        case XMLNodeDictionary.XT_MERCURY_SERVER_CONFIG:
                            {
                                // do nothing for now.    
                            }
                            break;
                        // Mercury Server options
                        case XMLNodeDictionary.XT_MERCURY_SERVER_OPTIONS:
                            {
                                // do nothing for now.    
                            }
                            break;
                        // Mercury GUI Options
                        case XMLNodeDictionary.XT_MERCURY_GUI_OPTIONS:
                            {
                                // do nothing for now.
                            }
                            break;
                        // MERCURY_AVT_PLC_CONFIG
                        case XMLNodeDictionary.XT_MERCURY_AVT_PLC_CONFIG:
                            {
                                m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Clear();
                            }
                            break;
                        case XMLNodeDictionary.XT_SWEEP_DUCT_RANGE:
                            {
                                ++sweepRangeIndex;
                                m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Add(new MercuryAVTPLCSweep_DuctorHoldOffRange());
                            }
                            break;
                    }

                    
                    Dictionary<string, string> nodeAttributes = new Dictionary<string, string>();
                    for (int counter = 0; counter < xmlReader.AttributeCount; counter++)
                    {
                        xmlReader.MoveToAttribute(counter);
                        nodeAttributes.Add(xmlReader.Name, xmlReader.Value);                        
                    }

                    IDictionaryEnumerator _enumerator = nodeAttributes.GetEnumerator();
                    while (_enumerator.MoveNext())
                    {
                        string strValue = "";
                        string strKey = "";
                        switch (nodeName)
                        {
                            case XMLNodeDictionary.XT_SYSTEM_SITENAME:
                                {
                                    m_mcSiteConfigData.SiteName = _enumerator.Value.ToString();
                                }
                                break;

                            case XMLNodeDictionary.XT_SYSTEM_SITENUMBER:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.SiteNumber = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCSYSTEM_CONFIG:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.SystemConfig = (float)Convert.ToDouble(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCSYSTEM_PRESSES:
                                {

                                }
                                break;

                            case XMLNodeDictionary.XT_SYSTEM_PRESS:
                                {
                                    strKey = _enumerator.Key.ToString();
                                    strValue = _enumerator.Value.ToString();
                                    if (strKey == XMLNodeDictionary.NAME)
                                        mcTempPressInfo.PressName = strValue;

                                    if (strKey == XMLNodeDictionary.XT_PRESS_TYPE)
                                    {
                                        mcTempPressInfo.PressType = int.Parse(strValue);
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_CQ_CLC_CONFIGURATION:
                                {
                                    strKey = (string)_enumerator.Key;
                                    if (strKey == XMLNodeDictionary.XT_CQ_CLC_ISCONFIGURED)
                                    {
                                        mcTempPressInfo.IsCLCOEM = Convert.ToBoolean(_enumerator.Value.ToString());
                                    }
                                    else if (strKey == XMLNodeDictionary.IP_ADDRESS)
                                    {
                                        mcTempPressInfo.CLCIPAddress = _enumerator.Value.ToString();
                                    }
                                    else if (strKey == XMLNodeDictionary.PORT)
                                    {
                                        mcTempPressInfo.CLCCQPort = Convert.ToUInt16(_enumerator.Value.ToString());
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_WIDTH:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressWidth = (float)Convert.ToDouble(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_FOLDER:
                                {
                                    strValue = _enumerator.Value.ToString();
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_UNITS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    int iTotalUnits = Convert.ToInt16(strValue);
                                    mcTempPressInfo.TotalUnits = iTotalUnits;
                                    mcTempPressInfo.GenerateUnits();
                                }
                                break;
                            case XMLNodeDictionary.XT_INKERS:
                                {
                                    if ((!inSweepControl) && (!inWaterControl))
                                    {
                                        strValue = _enumerator.Value.ToString();
                                        MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                        // assign number of inkers
                                        pressUnit.TotalInkers = Convert.ToInt16(strValue);
                                        pressUnit.CreateInkers();
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_INKER:
                                {
                                    strKey = _enumerator.Key.ToString();
                                    strValue = _enumerator.Value.ToString();
                                    if (strKey == XMLNodeDictionary.XT_MCPRESS_PRESS_SERVO_CONTROL)
                                    {
                                        if (inSweepControl)
                                            mcTempPressInfo.SweepServo.Add(strValue);
                                        if (inWaterControl)
                                            mcTempPressInfo.WaterServo.Add(strValue);
                                    }
                                    else if (strKey == XMLNodeDictionary.NAME)
                                    {
                                        MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                        MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                        inker.InkerName = strValue;
                                        mcTempPressInfo.InkerList.Add(inker);
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_UNIT_INKER_KEY1OPERATORSIDE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.FirstKeyOperatorSide = (strValue == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_SIDE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.UpperLowerInker = strValue;
                                    //
                                    // There are too many members to represent the WebSide of an Inker. Let us use one data member consistently to represent 
                                    // the WebSide of an Inker.
                                    //                     
                                    if( strValue.Contains( XMLNodeDictionary.XT_UPPER ) )
                                    {
                                        inker.UpperOrLowerInker = ( int ) MCNWSiteGen.INKERTYPE.UPPER;
                                    }
                                    else
                                    {
                                        inker.UpperOrLowerInker = ( int ) MCNWSiteGen.INKERTYPE.LOWER;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_INKER_LEFT_SIDE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[ pressUnitIndex ] );
                                    MCInker inker = ( MCInker )( pressUnit.InkerList[ inkerIndex ] );
                                    inker.IsLeftSide = ( 0 == string.Compare( strValue, XMLNodeDictionary.XT_PRESS_TRUE, true ) ); 
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.ServoTurns = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_KEYS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.TotalKeys = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_KEY:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.KeyWidth = (float)Convert.ToDouble(strValue);
                                }
                                break;
                            case XMLNodeDictionary.XT_KEYS_DISPLAY_ON_CLIENT:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.DisplayKeys = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.TotalBanks = Convert.ToInt16(strValue);
                                    inker.CreateServoBanks();
                                }
                                break;

                            case XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS:
                                {

                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME)
                                    {
                                        strValue = _enumerator.Value.ToString();

                                        MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                        MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                        ServoBanks servoBank = (ServoBanks)(inker.ServoBanks[servoBankIndex]);
                                        servoBank.SPUName = (strValue);
                                    }
                                    else if (strKey == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT)
                                    {
                                        strValue = _enumerator.Value.ToString();
                                        MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                        MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                        ServoBanks servoBank = (ServoBanks)(inker.ServoBanks[servoBankIndex]);
                                        servoBank.PortOnSPU = Convert.ToInt16(strValue);
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    ServoBanks servoBank = (ServoBanks)(inker.ServoBanks[servoBankIndex]);
                                    servoBank.TotalKeys = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    ServoBanks servoBank = (ServoBanks)(inker.ServoBanks[servoBankIndex]);
                                    servoBank.StartKey = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCINKER_SERVO_BANK_INVERTED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    ServoBanks servoBank = (ServoBanks)(inker.ServoBanks[servoBankIndex]);
                                    servoBank.BankInverted = (strValue == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.Inverted = (strValue == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.LTIndex = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.LTSize = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_CIP3_IMAGE_ROTATE_DEGREES:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.CIP3ImageRotateDegrees = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_CIP3_DATA_ROTATION:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[pressUnitIndex]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[inkerIndex]);
                                    inker.CIP3DataRotation = Convert.ToBoolean(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_SPUS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.InitTotalSPUS(Convert.ToInt16(strValue));
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_SPU:
                                {
                                    strKey = _enumerator.Key.ToString();
                                    strValue = _enumerator.Value.ToString();
                                    if (strKey == XMLNodeDictionary.NAME)
                                    {
                                        PressSPU pressSPU = (PressSPU)(mcTempPressInfo.PressSPUList[bySPU]);
                                        pressSPU.SPUName = (strValue);
                                    }
                                    else if (strKey == XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT)
                                    {
                                        PressSPU pressSPU = (PressSPU)(mcTempPressInfo.PressSPUList[bySPU]);
                                        pressSPU.SPUCommPort = (strValue);
                                    }
                                    else if (strKey == XMLNodeDictionary.IP_ADDRESS)
                                    {
                                        PressSPU pressSPU = (PressSPU)(mcTempPressInfo.PressSPUList[bySPU]);
                                        pressSPU.IPAddress = strValue;
                                    }
                                    else if (strKey == XMLNodeDictionary.XT_COMM_TYPE)
                                    {
                                        PressSPU pressSPU = (PressSPU)(mcTempPressInfo.PressSPUList[bySPU]);
                                        pressSPU.COMMType = strValue;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT:
                                {

                                }
                                break;
                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CREMOTEDATASTORAGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressClientInterface.NetworkPath = strValue;
                                }
                                break;
                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CLOCALDATASTORAGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressClientInterface.StandardPath = strValue;
                                }
                                break;
                            case XMLNodeDictionary.XT_MC_CLIENT_BLADE_STIFFNESS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.BladeStiffNess = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_MAX_NEIGH_KEY_DELTA:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.MaxKeyDelta = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_CIP3_PRESETTING:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.CIP3Presetting = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.CIP3Presetting = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_NON_LINEAR:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.NonLinearBool = true;
                                    else if (strValue == XMLNodeDictionary.XT_PRESS_FALSE)
                                        mcTempPressInfo.MCClientInterface.NonLinearBool = false;
                                    else
                                        mcTempPressInfo.MCClientInterface.NonLinear = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_BLADE_COMPENSATION:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.BladeCompensation = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.BladeCompensation = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_METER_OFFSET:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.MeterOffset = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.MeterOffset = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_SWEEP_CONTROL:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.SweepControl = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.SweepControl = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_FEATURE_WATER_CONTROL:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.WaterControl = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.WaterControl = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_LINEAR_TABLE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.NFSTableLinearPath = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_NON_LINEAR_TABLE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.NFSTableNonLinearPath = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_DEFAULT_OFFSET:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.DefaultOffset = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_SERVO_PULSES_ZONE_AT_ZERO:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.ServoPulsesZoneAtZero = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENT_ZERO_BACKOFF:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.MCClientInterface.PressZeroBackoffInPulses = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENTINTERFACE_WIDEPRESS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.WidePress = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.WidePress = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENTINTERFACE_FUNNY_FOUNTAINS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.FunnyFountains = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.FunnyFountains = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_MC_CLIENTINTERFACE_VIRTUAL_INKERS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.MCClientInterface.VirtualInkers = true;
                                    else
                                        mcTempPressInfo.MCClientInterface.VirtualInkers = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_CONSOLE_ZONES:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_NUM_ZONES)
                                        mcTempPressInfo.OCUInterface.NumberOfZones = Convert.ToInt16(_enumerator.Value.ToString());

                                    else if (strKey == XMLNodeDictionary.XT_MCPRESS_OCU_ZONE_WIDTH)
                                    {
                                        mcTempPressInfo.OCUInterface.ZoneWidth = (float)Convert.ToDouble(strValue);
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_UNIT_INKER_MINVALUE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.OCUInterface.MinValue = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.OCUInterface.MaxValue = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_NFSTABLE_BREAKPOINT:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.NFSTable.BreakPoint = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_NFSTABLE_GAIN:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.NFSTable.MaxKeyTurnsAtConsole99 = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_SWEEP_CONTROL_INTERFACE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    this.sweepConfiguration = Convert.ToInt16(strValue);
                                    inSweepControl = true; // fo defer the sweep and water for servo turns
                                    inWaterControl = false;
                                    mcTempPressInfo.SweepMotorServoControl.ReadFromFile = true;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_STEP_ENABLED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_VALUE)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        {
                                            mcTempPressInfo.SweepMotorServoControl.StepEnabled = true;
                                        }
                                        else
                                            mcTempPressInfo.SweepMotorServoControl.StepEnabled = false;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_SERVOTURNS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    double servoTurns = Convert.ToDouble(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.ServoTurns = servoTurns; //Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.ServoTurns = servoTurns;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_TURNS2:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    double turns2 = Convert.ToDouble(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.Turns2 = turns2; // Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.Turns2 = turns2;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_PULSE_WIDTH:
                            case XMLNodeDictionary.XT_MCPRESS_PCU_WATER_PULSE_WIDTH:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    int ivalue = Convert.ToInt16(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.PCU_pulseWidth = ivalue; // Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.PCU_pulseWidth = ivalue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_DIST_NUDGE:
                            case XMLNodeDictionary.XT_MCPRESS_PCU_WATER_DIST_NUDGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    int ivalue = Convert.ToInt16(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.PCU_distNudge = ivalue; // Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.PCU_distNudge = ivalue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_MAX_STALLS:
                            case XMLNodeDictionary.XT_MCPRESS_PCU_WATER_MAX_STALLS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    int ivalue = Convert.ToInt16(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.PCU_maxStalls = ivalue; // Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.PCU_maxStalls = ivalue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PCU_SWEEP_TOLERANCE:
                            case XMLNodeDictionary.XT_MCPRESS_PCU_WATER_TOLERANCE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    int ivalue = Convert.ToInt16(strValue);
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepMotorServoControl.PCU_tolerance = ivalue; // Convert.ToDouble(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterMotorServoControl.PCU_tolerance = ivalue;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_REVERSED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_VALUE)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        {
                                            if (inSweepControl)
                                                mcTempPressInfo.SweepMotorServoControl.Reversed = true;
                                            if (inWaterControl)
                                                mcTempPressInfo.WaterMotorServoControl.Reversed = true;
                                        }
                                        else
                                        {
                                            if (inSweepControl)
                                                mcTempPressInfo.SweepMotorServoControl.Reversed = false;
                                            if (inWaterControl)
                                                mcTempPressInfo.WaterMotorServoControl.Reversed = false;
                                        }
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_LOW_BACKLASH_USED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_VALUE)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        {
                                            mcTempPressInfo.SweepMotorServoControl.LowBacklashUsed = true;
                                        }
                                        else
                                            mcTempPressInfo.SweepMotorServoControl.LowBacklashUsed = false;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_OFFSET_ENABLED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_VALUE)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        {
                                            mcTempPressInfo.SweepMotorServoControl.OffsetEnabled = true;
                                        }
                                        else
                                            mcTempPressInfo.SweepMotorServoControl.OffsetEnabled = false;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_USE_BANK_1:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();
                                    if (strKey == XMLNodeDictionary.XT_VALUE)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        {
                                            if (inSweepControl)
                                                mcTempPressInfo.SweepMotorServoControl.UseBank1 = true;
                                            if (inWaterControl)
                                                mcTempPressInfo.WaterMotorServoControl.UseBank1 = true;
                                        }
                                        else
                                        {
                                            if (inSweepControl)
                                                mcTempPressInfo.SweepMotorServoControl.UseBank1 = false;
                                            if (inWaterControl)
                                                mcTempPressInfo.WaterMotorServoControl.UseBank1 = false;

                                        }
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_SWEEP_SERVO:
                                {
                                    mcTempPressInfo.SweepServo.Clear();
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_WATER_CONTROL_INTERFACE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    this.waterConfiguration = Convert.ToInt16(strValue);
                                    inSweepControl = false; // for defer the sweep and water for servo turns
                                    inWaterControl = true;
                                    mcTempPressInfo.WaterMotorServoControl.ReadFromFile = true;
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_INITIAL_SURGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.WaterMotorServoControl.InitialSurge = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_INCREMENTAL_SURGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.WaterMotorServoControl.IncrementalSurge = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_SPECIAL_MAPPING:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                            mcTempPressInfo.SweepMotorServoControl.SpecialMapping = true;   
                                        else
                                            mcTempPressInfo.SweepMotorServoControl.SpecialMapping = false;
                                    }
                                    if (inWaterControl)
                                    {
                                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
											mcTempPressInfo.WaterMotorServoControl.SpecialMapping = true;
										else
											mcTempPressInfo.WaterMotorServoControl.SpecialMapping = false;
									}
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_WATER_SERVO:
                                {
                                    mcTempPressInfo.WaterServo.Clear();
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONFIG:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    strKey = _enumerator.Key.ToString();

                                    // Sweep PLC Configuration
                                    if( inSweepControl )
                                    {
                                        if( strKey == XMLNodeDictionary.XT_PRESS_IS_USED )
                                        {
                                            if( strValue == XMLNodeDictionary.XT_PRESS_TRUE )
                                                mcTempPressInfo.SweepInterface.IsPLCUsed = true;
                                            else
                                                mcTempPressInfo.SweepInterface.IsPLCUsed = false;
                                        }
                                        else if( strKey == XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE )
                                        {
                                            strValue = _enumerator.Value.ToString();
                                            mcTempPressInfo.SweepInterface.PLCType = Convert.ToInt16( strValue );
                                        }
                                        else if( strKey == XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT )
                                        {
                                            mcTempPressInfo.SweepInterface.PLCCOMMPort = strValue;
                                        }
                                    }
                                    // Water PLC Configuration
                                    else if( inWaterControl )
                                    {
                                        if( strKey == XMLNodeDictionary.XT_PRESS_IS_USED )
                                        {
                                            if( strValue == XMLNodeDictionary.XT_PRESS_TRUE )
                                                mcTempPressInfo.WaterInterface.IsPLCUsed = true;
                                            else
                                                mcTempPressInfo.WaterInterface.IsPLCUsed = false;
                                        }
                                        else if( strKey == XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE )
                                        {
                                            strValue = _enumerator.Value.ToString();
                                            mcTempPressInfo.WaterInterface.PLCType = Convert.ToInt16( strValue );
                                        }
                                        else if( strKey == XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT )
                                        {
                                            mcTempPressInfo.WaterInterface.PLCCOMMPort = strValue;
                                        }
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWashCycle = Convert.ToInt16( strValue );
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCWashCycle = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_MECH_DELAY_IN_MS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCMechDelayInMS = Convert.ToInt16( strValue );
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCMechDelayInMS = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCTachPulsePerExec = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCTachPulsePerExec = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_SAMPLE_TIME_MS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCSampleTime = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCSampleTime = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_WATER_DIVISOR:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWaterDivisor = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCWaterDivisor = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_WATER_OUTPUT_MIN:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWaterOutputMin = Convert.ToInt16( strValue );
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCWaterOutputMin = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_WATER_START_SPEED_MIN:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWaterStartSpeedMin = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCWaterStartSpeedMin = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_WATER_START_SPEED_MAX:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWaterStartSpeedMax = Convert.ToInt16(strValue);
                                    else if(inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCWaterStartSpeedMax = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_WATER_STARTUP_VOLTAGE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCWaterStartupVolt = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCWaterStartupVolt = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_SWEEP_NL_CURVE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCNLCurve = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_SWEEP_MOTOR_SPEED:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCMotorSpeed = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_SWEEP_MOTOR_TURNS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCMotorTurns = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_SWEEP_DIVISOR:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if( inSweepControl )
                                        mcTempPressInfo.SweepInterface.PLCSweepDivisor = Convert.ToInt16(strValue);
                                    else if( inWaterControl )
                                        mcTempPressInfo.WaterInterface.PLCSweepDivisor = Convert.ToInt16( strValue );
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TURN_BARS:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    byte byTurnBars = Convert.ToByte(strValue);
                                    mcTempPressInfo.InitTotalTurnBars(byTurnBars);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TURN_BAR:
                                {
                                    TurnBars turnBar = (TurnBars)mcTempPressInfo.GetTurnBarAt(byTurnBar);
                                    if (null != turnBar)
                                    {
                                        strValue = _enumerator.Value.ToString();
                                        strKey = _enumerator.Key.ToString();
                                        if (strKey == XMLNodeDictionary.NAME)
                                        {
                                            turnBar.Name = strValue;

                                        }
                                        else if (strKey == XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT)
                                        {
                                            turnBar.Predecessor = strValue;
                                        }
                                        else if (strKey == XMLNodeDictionary.XT_PRESS_ACTIVATED)
                                        {
                                            if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                                turnBar.Checked = true;
                                            else
                                                turnBar.Checked = false;
                                        }
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TOTAL_SPUS_TO_TEST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    inAutoTest = !inAutoTest;
                                    if (inAutoTest)
                                        mcTempPressInfo.AutoTest.TotalSpusToTest = Convert.ToInt16(strValue);
                                    else //if in SweepTest)
                                        mcTempPressInfo.SweepTest.TotalSpusToTest = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TOTAL_UNITS_TO_TEST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoTest.TotalUnitsToTest = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TOTAL_SERVOS_TO_TEST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoTest.TotalServosToTest = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_CLOSE_KEYS_UP_TO:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoTest.CloseKeysUpTo = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TIME_DELAY:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inAutoTest)
                                        mcTempPressInfo.AutoTest.TimeDelay = Convert.ToInt16(strValue);
                                    else // if in SweepTest)
                                        mcTempPressInfo.SweepTest.TimeDelay = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_NUMBER_OF_CYCLES:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inAutoTest)
                                        mcTempPressInfo.AutoTest.NumberOfCycles = Convert.ToInt16(strValue);
                                    else // if in SweepTest)
                                        mcTempPressInfo.SweepTest.NumberOfCycles = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_LOOP_TYPE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoTest.LoopType = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_OPEN_KEYS_UP_TO:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoTest.OpenKeysUpTo = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_WHICH_PORT_TO_TEST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.SweepTest.WhichPortToTest = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_TOTAL_SWEEP_TO_TEST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.SweepTest.TotalSweepsToTest = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_OPEN_SWEEP_UP_TO:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.SweepTest.OpenSweepUpTo = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_AUTO_SCAN_CAL:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.AutoScanEnabled = Convert.ToBoolean(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_SWEEP_ZONE_RATIO:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.SweepZoneRatio = Convert.ToDouble(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_ZONE_MARGIN:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.ZoneMargin = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_EWMAFACTOR:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.EWMAFactor = Convert.ToDouble(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_SCAN_SWEEP_ADJUST:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.ScanSweepAdjust = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_SWEEP_DEFAULT:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.SweepDefault = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_WEB_TYPE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.WebType = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_ENABLE_LIMIT_CHECK:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.AutoScanCalibration.EnableLimitCheck = true;
                                    else
                                        mcTempPressInfo.AutoScanCalibration.EnableLimitCheck = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_BLADE_TOLERANCE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.BladeTolerance = Convert.ToInt16(strValue);
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_CIP3_PATH:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.Cip3Path = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_CIP3_IMAGES_PATH:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.Cip3ImagesPath = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_ENABLE_IMPOSITION_DATA:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcTempPressInfo.AutoScanCalibration.ImpositionDataEnabled = true;
                                    else
                                        mcTempPressInfo.AutoScanCalibration.ImpositionDataEnabled = false;
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_IMPO_PATH:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    mcTempPressInfo.AutoScanCalibration.ImpositionPath = strValue;
                                }
                                break;

                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CURRENTLANGUAGE:
                                {
                                    mcTempPressInfo.PressClientInterface.CurrentLanguage = _enumerator.Value.ToString();
                                }
                                break;

                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL1:
                                {
                                    string password = _enumerator.Value.ToString();
                                    // decrypt the password
                                    password = Decrypt(password);
                                    if (!string.IsNullOrEmpty(password))
                                    {
                                        mcTempPressInfo.PressClientInterface.ConfigurationPassword = password;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL2:
                                {
                                    string password = _enumerator.Value.ToString();
                                    // decrypt the password
                                    password = Decrypt(password);
                                    if (!string.IsNullOrEmpty(password))
                                    {
                                        mcTempPressInfo.PressClientInterface.DiagnosticPassword = password;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL3:
                                {
                                    string password = _enumerator.Value.ToString();
                                    // decrypt the password
                                    password = Decrypt(password);
                                    if (!string.IsNullOrEmpty(password))
                                    {
                                        mcTempPressInfo.PressClientInterface.ExitPassword = password;
                                    }
                                }
                                break;

                            case XMLNodeDictionary.XT_CLIENTINTERFACE_CADVUSER:
                                {
                                    string password = _enumerator.Value.ToString();
                                    // decrypt the password
                                    password = Decrypt(password);
                                    if (!string.IsNullOrEmpty(password))
                                    {
                                        mcTempPressInfo.PressClientInterface.AdvUser = password;
                                    }
                                }
                                break;
                            // AutoZeroServos option
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_SERVOS:
                                {
                                    string autoZeroEnabled = _enumerator.Value.ToString();
                                    if (autoZeroEnabled == XMLNodeDictionary.XT_PRESS_TRUE)
                                    {
                                        mcTempPressInfo.AutoZeroServosEnabled = true;
                                    }
                                    else
                                    {
                                        mcTempPressInfo.AutoZeroServosEnabled = false;
                                    }
                                }
                                break;

                            // Show Help option
                            case XMLNodeDictionary.XT_CLIENTINTERFACE_SHOW_HELP:
                                {
                                    string showHelp = _enumerator.Value.ToString();
                                    if (showHelp == XMLNodeDictionary.XT_PRESS_TRUE)
                                    {
                                        mcTempPressInfo.PressClientInterface.ShowHelp = true;
                                    }
                                    else
                                    {
                                        mcTempPressInfo.PressClientInterface.ShowHelp = false;
                                    }
                                }
                                break;

                            // Show 2 Sides Thumbs option
                            case XMLNodeDictionary.XT_CLIENTINTERFACE_SHOW_2SIDES:
                                {                                    
                                    mcTempPressInfo.PressClientInterface.Show2SidesThumbs = false;
                                }
                                break;
                            // PressAutoZero Enabled
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_ENABLED:
                                {
                                    string pressAutoZeroEnabled = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.AutoZeroEnabled =
                                    (pressAutoZeroEnabled == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // PressAutoZero Mode
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_MODE:
                                {
                                    string pressAutoZeroMode = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.Mode = Convert.ToByte(pressAutoZeroMode);
                                }
                                break;
                            // PressAutoZero DeviceIPAddress
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DEV_IPADDR:
                                {
                                    string pressAutoZeroIPAddress = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.DeviceIPAddress = pressAutoZeroIPAddress;
                                }
                                break;
                            // PressAutoZero DeviceID
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DEV_ID:
                                {
                                    string pressAutoZeroDeviceID = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.DeviceID = Convert.ToByte(pressAutoZeroDeviceID);
                                }
                                break;
                            // PressAutoZero TimeDelay
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_TIME_DELAY:
                                {
                                    string pressAutoZeroTimeDelay = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.TimeDelay = Convert.ToInt32(pressAutoZeroTimeDelay);
                                }
                                break;
                            // PressAutoZero PollTimePeriod
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_POLL_TIME:
                                {
                                    string pressAutoZeroPollTimePeriod = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.PollTimePeriod = Convert.ToInt32(pressAutoZeroPollTimePeriod);
                                }
                                break;
                            // PressAutoZero FactorFrequency
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_FACTOR_FREQUENCY:
                                {
                                    string pressAutoFactorFre = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.FactorFrequency = Convert.ToInt32(pressAutoFactorFre);
                                }
                                break;
                            // PressAutoZero IdleThresholdFPM
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_IDLE_THRESHOLD_FPM:
                                {
                                    string pressAutoIdleThreshold = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.IdleThresholdFPM = Convert.ToInt32(pressAutoIdleThreshold);
                                }
                                break;
                            // PressAutoZero DryContactIdleState
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DRY_CON_IDLE_STATE:
                                {
                                    string pressAutoDryContactIdleState = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.DryContactIdleState =
                                    (pressAutoDryContactIdleState == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // PressAutoZero TimeDelayFountainClose
                            case XMLNodeDictionary.XT_PRESS_AUTO_ZERO_DELAY_FOUNTAIN_CLOSE:
                                {
                                    string pressAutoZeroDelayFountainClose = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.TimeDelayToCloseFountain = Convert.ToInt32(pressAutoZeroDelayFountainClose);                                  
                                }
                                break;
                            // PressAutoZero DryChannelsMapping (WI30488)
                            case XMLNodeDictionary.XT_PRESS_AZ_DRY_CHANNELS_MAPPING:
                                {
                                    mcTempPressInfo.PressAutoZero.DryChannelsMap.Clear();
                                    string pressAutoZeroDryChannelsMapping = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.NumberOfDrySensors = Convert.ToInt32(pressAutoZeroDryChannelsMapping);
                                }
                                break;
                            // PressAutoZero FrqChannelsMapping (WI30488)
                            case XMLNodeDictionary.XT_PRESS_AZ_FREQUENCY_CHANNELS_MAPPING:
                                {
                                    mcTempPressInfo.PressAutoZero.FrqChannelsMap.Clear();
                                    string pressAutoZeroFrqChannelsMapping = _enumerator.Value.ToString();
                                    mcTempPressInfo.PressAutoZero.NumberOfFrequencySensors = Convert.ToInt32(pressAutoZeroFrqChannelsMapping);  //WI36833 chg'd to number of FRQ sensors
                                }
                                break;

                            case XMLNodeDictionary.XT_PRESS_AZ_MAPPING_ELEMENT:
                                {
                                    strKey = _enumerator.Key.ToString();
                                    strValue = _enumerator.Value.ToString();
                                    //byte byChannId = 0xFF;
                                    //string strUnitName = "";
                                    if (strKey == XMLNodeDictionary.XT_PRESS_AZ_INPUT_CHANNEL_ID)
                                    {
                                        byChannId = (byte)(Convert.ToInt16(strValue));
                                    }
                                    else if (strKey == XMLNodeDictionary.XT_PRESS_AZ_UNIT_NAME)
                                    {
                                        strUnitName = strValue;
                                    }
                                    if ((byChannId != 0xFF) && (strUnitName != ""))
                                    {
                                        if ((mcTempPressInfo.PressAutoZero.NumberOfDrySensors > 0) &&     
                                            (mcTempPressInfo.PressAutoZero.NumberOfFrequencySensors == 0))
                                        {
                                            //filling up the Dry map
                                            mcTempPressInfo.PressAutoZero.DryChannelsMap[byChannId] = strUnitName;
                                        }
                                        else
                                        {
                                            //filling up the Dry map
                                            mcTempPressInfo.PressAutoZero.FrqChannelsMap[byChannId] = strUnitName;
                                        }
                                        //prepare for the next element
                                        byChannId = 0xFF;
                                        strUnitName = "";
                                    } 
                                }
                                break;

                            // MaxFountainPorts 
                            case XMLNodeDictionary.XT_MAX_FOUNTAIN_PORTS_SPU:
                                {
                                    byte maxFountainPorts = Convert.ToByte( _enumerator.Value.ToString() );
                                    //Assumption: at least 4 inker ports per SPU 
                                    if (maxFountainPorts < 4)
                                    {
                                        maxFountainPorts = 6; // default 6 inker ports / SPU
                                    }
                                    mcTempPressInfo.MaxFountainPortCountPerSPU = maxFountainPorts;
                                }
                                break;

                            // Total webs
                            case XMLNodeDictionary.XT_MAX_WEBS:
                                {
                                    int totalWebs = Convert.ToInt32( _enumerator.Value.ToString() );
                                    // at least two webs for 'Dual / Multi Web Press type' 
                                    if( totalWebs < 2 )
                                    {
                                        totalWebs = 2;
                                    }
                                    mcTempPressInfo.TotalNumberOfWebs = totalWebs;
                                }
                                break;

                            // Airbar count
                            case XMLNodeDictionary.XT_AIR_BARS:
                                {
                                    string value = _enumerator.Value.ToString();
                                    // get the Airbar count
                                    int airBarCount = Convert.ToInt32( value );
                                    mcTempPressInfo.InitializeAirbarList(airBarCount);
                                }
                                break;
                            // Airbar 
                            case XMLNodeDictionary.XT_AIR_BAR:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();                                    

                                    if (airBarCounter < mcTempPressInfo.AirbarList.Count)
                                    {
                                        AirbarConfigurationDetails airbarDetails = mcTempPressInfo.AirbarList[airBarCounter];
                                        if (airbarDetails != null)
                                        {
                                            // Name
                                            if (key == XMLNodeDictionary.NAME)
                                            {
                                                airbarDetails.Name = value;
                                            }

                                            // After which unit (re-using the XML tag of Turn bar)
                                            if (key == XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT)
                                            {
                                                airbarDetails.AfterWhichUnit = value;
                                            }
                                        }
                                    }
                                }
                                break;

                            // Product options >> Jobs Management option
                            case XMLNodeDictionary.XT_JOBS_MANAGEMENT_OPTION:
                                {                                    
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ProductOptions.JobModeEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;

                            // Product options >> Keep only last version of profiles
                            case XMLNodeDictionary.XT_KEEP_LAST_VERSION_PROFILES_OPTION:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ProductOptions.KeepOnlyLastVersionProfiles = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;

                            // Product options >> prompt for Zero All Inker needed on every restart of Server
                            case XMLNodeDictionary.XT_PROMPT_ZAI_NEEDED_ON_SERVER_RESTART:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ProductOptions.PromptZAINeededOnServerRestart = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // Product options >> Newspaper Navigation View option
                            case XMLNodeDictionary.XT_NEWSPAPER_NAVIGATION_VIEW_OPTION:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ProductOptions.NewspaperNavigationViewOption = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // Product options >> Label Towers with Numbers option
                            case XMLNodeDictionary.XT_LABEL_TOWERS_WITH_NUMBERS_OPTION:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ProductOptions.LabelTowersWithNumbersOption = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            //WI41821 - Mercury Server configuration >> IP Address , Port number
                            case XMLNodeDictionary.XT_MERCURY_SERVER:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    switch ( key )
                                    {
                                        case XMLNodeDictionary.IP_ADDRESS:
                                            m_mcSiteConfigData.ServerConfiguration.IPAddress = value;
                                            break;
                                        case XMLNodeDictionary.PORT:
                                            m_mcSiteConfigData.ServerConfiguration.PortNumber = Convert.ToInt32(value);
                                            break;
                                    }
                                }
                                break;

                            // Allen Bradley PLC - AB type          MarkC 11/6/12 WI29958 add AB PLC5 type 
                            case XMLNodeDictionary.XT_AB_TYPE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABType = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABType = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_BAUD
                            case XMLNodeDictionary.XT_AB_BAUD:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABDHBaud = strValue;
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABDHBaud = strValue;
                                }
                                break;

                            // Allen Bradley PLC - AB_PLC_NODE
                            case XMLNodeDictionary.XT_AB_PLC_NODE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABPLCNode = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABPLCNode = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_AS_NODE
                            case XMLNodeDictionary.XT_AB_AS_NODE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABASNode = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABASNode = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_FILENAME
                            case XMLNodeDictionary.XT_AB_FILENAME:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABFilename = strValue;
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABFilename = strValue;
                                }
                                break;

                            // Allen Bradley PLC - AB_MOD_TYP
                            case XMLNodeDictionary.XT_AB_MOD_TYPE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABModType = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABModType = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_PLC_MAP
                            case XMLNodeDictionary.XT_AB_PLC_MAP:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABPLCMap = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABPLCMap = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_POLL_TYPE                     MT18035  MArkC Add poll type and rate  2/8/13
                            case XMLNodeDictionary.XT_AB_POLL_TYPE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABPOLLTYPE = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABPOLLTYPE = Convert.ToInt16(strValue);
                                }
                                break;

                            // Allen Bradley PLC - AB_POLL_RATE
                            case XMLNodeDictionary.XT_AB_POLL_RATE:
                                {
                                    strValue = _enumerator.Value.ToString();
                                    if (inSweepControl)
                                        mcTempPressInfo.SweepInterface.PLCABPOLLRATE = Convert.ToInt16(strValue);
                                    if (inWaterControl)
                                        mcTempPressInfo.WaterInterface.PLCABPOLLRATE = Convert.ToInt16(strValue);
                                }
                                break;
                            // WI67306 - Mercury Server options >> Log data option
                            case XMLNodeDictionary.XT_SERVER_LOGDATA:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.LogDataOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> Log IO data option
                            case XMLNodeDictionary.XT_SERVER_LOGIODATA:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.LogIODataOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> Simulation option
                            case XMLNodeDictionary.XT_SERVER_SIMULATION:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.SimulationOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> CPU Affinity option
                            case XMLNodeDictionary.XT_SERVER_CPU_AFFINITY:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.CPUAffinityOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> No Stress on SPU option
                            case XMLNodeDictionary.XT_SERVER_SPU_NOSTRESS:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.NoStressOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> SPU3 Debug option
                            case XMLNodeDictionary.XT_SERVER_SPU3DEBUG:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.SPU3DebugOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> SPU Response option
                            case XMLNodeDictionary.XT_SERVER_IGNORE_SPU_RESPONSE:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.IgnoreSPUResponseOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI67306 - Mercury Server options >> Fix COM Ports option
                            case XMLNodeDictionary.XT_SERVER_FIXCOMPORTS:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.ServerOptions.FixCOMPortsOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177003 - Mercury GUI Options >> Removal of Run button
                            case XMLNodeDictionary.XT_GUI_REMOVAL_RUN_BUTTON:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.GUIOptions.RemovalOfRunButtonOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177003 - Mercury GUI Options >> Invert preset profile button
                            case XMLNodeDictionary.XT_GUI_INVERT_PRESET_PROFILE_BUTTON:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.GUIOptions.InvertPresetProfileOption = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177003 - Mercury GUI Options >> Save & Undo Sweep Console Settings
                            case XMLNodeDictionary.XT_GUI_SAVE_AND_UNDO_SWEEP_SETTINGS:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.GUIOptions.SaveAndUndoSweepConsoleSettings = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177003 - Mercury GUI Options >> Save & Undo Water Console Settings
                            case XMLNodeDictionary.XT_GUI_SAVE_AND_UNDO_WATER_SETTINGS:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.GUIOptions.SaveAndUndoWaterConsoleSettings = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177003 - Mercury GUI Options >> Default Thumbnail Size
                            case XMLNodeDictionary.XT_GUI_DEF_THUMBNAIL_SIZE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.GUIOptions.DefaultThumbnailSize = Convert.ToInt32( value );
                                }
                                break;
                            // WI183514 - Mercury GUI Options >> Auto Run Delay Time
                            case XMLNodeDictionary.XT_GUI_AUTO_RUN_DELAY_TIME:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.GUIOptions.AutoRunDelayTime = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC 
                            case XMLNodeDictionary.XT_AVT_PLC:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    switch (key)
                                    {
                                        case XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE:
                                            m_mcSiteConfigData.AVTPLCConfig.PLCType = (AVTPLCType)Convert.ToInt32(value);
                                            break;
                                        case XMLNodeDictionary.IP_ADDRESS:
                                            m_mcSiteConfigData.AVTPLCConfig.PLCIPAdrress = value;
                                            break;
                                        case XMLNodeDictionary.PORT:
                                            m_mcSiteConfigData.AVTPLCConfig.PLCPortNum = Convert.ToInt32(value);
                                            break;
                                        // WI182050 - AVT PLC - Sync Sweep / Water console values with OnPress values
                                        case XMLNodeDictionary.XT_SYNC_SWEEP_WATER_CONSOLE_VALUES:
                                            {
                                                value = _enumerator.Value.ToString().ToUpper();
                                                m_mcSiteConfigData.AVTPLCConfig.SyncSweepWaterConsoleValues = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                            }
                                            break;
                                    }
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option
                            case XMLNodeDictionary.XT_SWEEP_CONFIG:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge
                            case XMLNodeDictionary.XT_SWEEP_SURGE:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.SurgeEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge >> Default ON Time
                            case XMLNodeDictionary.XT_SWEEP_DEF_ONTIME:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.DefaultONTime = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge >> Max ON Time
                            case XMLNodeDictionary.XT_SWEEP_MAX_ONTIME:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.MaxONTime = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge >> Surge Trim
                            case XMLNodeDictionary.XT_SWEEP_SURGE_TRIM:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeTrim = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge >> Surge Method
                            case XMLNodeDictionary.XT_SWEEP_METHOD_OF_SURGE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeMethod = (MethodOfSurge)Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Surge >> Surge Device
                            case XMLNodeDictionary.XT_SWEEP_SURGE_DEVICE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeDevice = (SurgeDevice)Convert.ToInt32(value);
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Sweep Option >> Inker Wash up 
                            case XMLNodeDictionary.XT_SWEEP_INKER_WASH_UP:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerWashupEnabled = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Ramping
                            case XMLNodeDictionary.XT_SWEEP_RAMPING:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RampingEnabled = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Ramping
                            case XMLNodeDictionary.XT_SWEEP_TRIM_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.TrimInfluence = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Sweep Function Control
                            case XMLNodeDictionary.XT_SWEEP_FUNC_CONTROL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.FunctionControl.SweepFuncControlEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Trim Manual
                            case XMLNodeDictionary.XT_SWEEP_TRIM_MANUAL:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.FunctionControl.TrimSettingManual = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Master Control
                            case XMLNodeDictionary.XT_SWEEP_MASTER_CONTROL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MasterSweepControlEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Master Influence
                            case XMLNodeDictionary.XT_SWEEP_MASTER_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MasterInfluence = Convert.ToInt32(value);
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Sweep Option >> Ink Master Setting
                            case XMLNodeDictionary.XT_SWEEP_INK_MASTER_SETTING:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.InkMasterSetting = Convert.ToInt32( value );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Ductor Holdoff
                            case XMLNodeDictionary.XT_SWEEP_DUCT_HOLDOFF:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOffEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Ductor Holdoff >> Num Of Ranges
                            case XMLNodeDictionary.XT_SWEEP_DUCT_RANGES:
                                {
                                    string value = _enumerator.Value.ToString();
                                    int numOfRanges = Convert.ToInt32(value);
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.NumOfRanges = numOfRanges;
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Sweep Option >> Ductor Holdoff >> Range Min, Max, Value
                            case XMLNodeDictionary.XT_SWEEP_DUCT_RANGE:
                                {
                                    if (sweepRangeIndex >= m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Count)
                                    {
                                        break;
                                    }

                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    MercuryAVTPLCSweep_DuctorHoldOffRange rangeItem = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList[sweepRangeIndex];
                                    if( null == rangeItem )
                                    {
                                        break;
                                    }
                                    rangeItem.RangeIndex = (sweepRangeIndex + 1); // Display value, so starts from 1.
                                    switch( key )
                                    {
                                        case XMLNodeDictionary.XT_VALUE:
                                            rangeItem.Value = Convert.ToInt32(value);
                                            break;
                                    }
                                }
                                break;

                            // WI102725 - Mercury AVT PLC >> Water Option
                            case XMLNodeDictionary.XT_WATER_CONFIG:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood
                            case XMLNodeDictionary.XT_WATER_FLOOD:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FloodEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood >> Default ON Time
                            case XMLNodeDictionary.XT_WATER_DEF_ONTIME:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.DefaultONTime = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood >> Max ON Time
                            case XMLNodeDictionary.XT_WATER_MAX_ONTIME:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.MaxONTime = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood >> Flood Trim
                            case XMLNodeDictionary.XT_WATER_FLOOD_TRIM:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodTrim = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood >> Flood Method
                            case XMLNodeDictionary.XT_WATER_METHOD_OF_FLOOD:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodMethod = (MethodOfFlood)Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Flood >> Flood Device
                            case XMLNodeDictionary.XT_WATER_FLOOD_DEVICE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodDevice = (FloodDevice)Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Ramping
                            case XMLNodeDictionary.XT_WATER_RAMPING:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RampingEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Ramping
                            case XMLNodeDictionary.XT_WATER_TRIM_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.TrimInfluence = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Water Function Control
                            case XMLNodeDictionary.XT_WATER_FUNC_CONTROL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FunctionControl.WaterFuncControlEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Trim Manual
                            case XMLNodeDictionary.XT_WATER_TRIM_MANUAL:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FunctionControl.TrimSettingManual = Convert.ToInt32(value);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Master Control
                            case XMLNodeDictionary.XT_WATER_MASTER_CONTROL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MasterWaterControlEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Water Option >> Master Influence
                            case XMLNodeDictionary.XT_WATER_MASTER_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MasterInfluence = Convert.ToInt32(value);
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Water Option >> Water Master Setting
                            case XMLNodeDictionary.XT_WATER_MASTER_SETTING:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.WaterMasterSetting = Convert.ToInt32( value );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Min Press Speed
                            case XMLNodeDictionary.XT_MIN_PRESS_SPEED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.MinPressSpeed = Convert.ToInt32( value );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Max Press Speed
                            case XMLNodeDictionary.XT_MAX_PRESS_SPEED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.MaxPressSpeed = Convert.ToInt32( value );
                                }
                                break;
                            // WI102725 - Mercury AVT PLC >> Display Press Speed units
                            case XMLNodeDictionary.XT_DISPLAY_PRESS_SPEED_OPTION:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.DisplayPressSpeedOption = (DisplayPressSpeedOption) Convert.ToInt32( value );
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Impression Length of plate
                            case XMLNodeDictionary.XT_IMPRESSION_LENGTH_OF_PLATE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.PlateInfoConfig.ImpressionLengthOfPlate = Convert.ToInt32( value );
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Num Of Plates in Fountain
                            case XMLNodeDictionary.XT_NUM_OF_PLATES_IN_FOUNTAIN:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.PlateInfoConfig.NumOfPlatesInFountain = Convert.ToInt32( value );
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Press Speed Input Voltage ( Min & Max )
                            case XMLNodeDictionary.XT_PRESS_SPEED_INPUT_VOLTAGE:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    switch( key )
                                    {
                                        case XMLNodeDictionary.XT_MIN:
                                            {
                                                m_mcSiteConfigData.AVTPLCConfig.PressSpeedVoltagesConfig.MinValue = Convert.ToSingle( value );
                                            }                                            
                                            break;
                                        case XMLNodeDictionary.XT_MAX:
                                            {
                                                m_mcSiteConfigData.AVTPLCConfig.PressSpeedVoltagesConfig.MaxValue = Convert.ToSingle( value );
                                            }                                            
                                            break;
                                    }
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Sweep Input Voltage ( Min & Max )
                            case XMLNodeDictionary.XT_SWEEP_INPUT_VOLTAGE:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    switch( key )
                                    {
                                        case XMLNodeDictionary.XT_MIN:
                                            {
                                                MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[pressUnitIndex] );
                                                MCInker inker = ( MCInker )( pressUnit.InkerList[inkerIndex] );
                                                inker.AVTPLCVoltages.SweepInputVoltages.MinValue = Convert.ToSingle( value );
                                            }                                            
                                            break;
                                        case XMLNodeDictionary.XT_MAX:
                                            {
                                                MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[pressUnitIndex] );
                                                MCInker inker = ( MCInker )( pressUnit.InkerList[inkerIndex] );
                                                inker.AVTPLCVoltages.SweepInputVoltages.MaxValue = Convert.ToSingle( value );
                                            } 
                                            break;
                                    }
                                }
                                break;
                            // WI128160 - Mercury AVT PLC >> Water Output Voltage ( Min & Max )
                            case XMLNodeDictionary.XT_WATER_OUTPUT_VOLTAGE:
                                {
                                    string key = _enumerator.Key.ToString();
                                    string value = _enumerator.Value.ToString();
                                    switch( key )
                                    {
                                        case XMLNodeDictionary.XT_MIN:
                                            {
                                                MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[pressUnitIndex] );
                                                MCInker inker = ( MCInker )( pressUnit.InkerList[inkerIndex] );
                                                inker.AVTPLCVoltages.WaterOutputVoltages.MinValue = Convert.ToSingle( value );
                                            }
                                            break;
                                        case XMLNodeDictionary.XT_MAX:
                                            {
                                                MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[pressUnitIndex] );
                                                MCInker inker = ( MCInker )( pressUnit.InkerList[inkerIndex] );
                                                inker.AVTPLCVoltages.WaterOutputVoltages.MaxValue = Convert.ToSingle( value );
                                            }
                                            break;
                                    }
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Options >> Hardware Interface Type
                            case XMLNodeDictionary.XT_SWEEP_HARDWARE_INTERFACE_TYPE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerOptions.HardwareInterfaceType = ( InkerHardwareInterfaceType )Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Options >> Enable Digital Control Cancel
                            case XMLNodeDictionary.XT_SWEEP_ENABLE_DIGITAL_CTRL_CANCEL:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerOptions.EnableDigitalControlCancel = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Options >> Hardware Interface Type
                            case XMLNodeDictionary.XT_WATER_HARDWARE_INTERFACE_TYPE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.WaterOptions.HardwareInterfaceType = ( WaterHardwareInterfaceType )Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Options >> Enable Digital Control Cancel
                            case XMLNodeDictionary.XT_WATER_ENABLE_DIGITAL_CTRL_CANCEL:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.WaterOptions.EnableDigitalControlCancel = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Ramping >> Speed Influence
                            case XMLNodeDictionary.XT_SWEEP_SPEED_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.SpeedInfluence = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Ramping >> Base Curve Max
                            case XMLNodeDictionary.XT_SWEEP_BASE_CURVE_MAX:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.BaseCurveMax = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Ramping >> Motor Clamp Min
                            case XMLNodeDictionary.XT_SWEEP_MOTOR_CLAMP_MIN:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MotorClampMin = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Sweep Ramping >> Motor Clamp Max
                            case XMLNodeDictionary.XT_SWEEP_MOTOR_CLAMP_MAX:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MotorClampMax = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Ramping >> Speed Influence
                            case XMLNodeDictionary.XT_WATER_SPEED_INFLUENCE:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.SpeedInfluence = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Ramping >> Water Curve Max
                            case XMLNodeDictionary.XT_WATER_BASE_CURVE_MAX:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.BaseCurveMax = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Ramping >> Motor Clamp Min
                            case XMLNodeDictionary.XT_WATER_MOTOR_CLAMP_MIN:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MotorClampMin = Convert.ToInt32( value );
                                }
                                break;
                            // WI145675 - Mercury AVT PLC >> Water Ramping >> Motor Clamp Max
                            case XMLNodeDictionary.XT_WATER_MOTOR_CLAMP_MAX:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MotorClampMax = Convert.ToInt32( value );
                                }
                                break;
                            // WI149990 - Mercury AVT PLC >> Recall Form Options >> Sweep Parameters
                            case XMLNodeDictionary.XT_SWEEP_TRIM_SELECTED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.TrimParamSelected = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI149990 - Mercury AVT PLC >> Recall Form Options >> Sweep Parameters
                            case XMLNodeDictionary.XT_SWEEP_FUNC_SETTING_SELECTED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.FunctionParamSelected = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI149990 - Mercury AVT PLC >> Recall Form Options >> Sweep Parameters
                            case XMLNodeDictionary.XT_SWEEP_DUCT_SETTING_SELECTED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.DuctorHoldoffParamSelected = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI149990 - Mercury AVT PLC >> Recall Form Options >> Water Parameters
                            case XMLNodeDictionary.XT_WATER_TRIM_SELECTED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RecallFormOptions.TrimParamSelected = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI149990 - Mercury AVT PLC >> Recall Form Options >> Water Parameters
                            case XMLNodeDictionary.XT_WATER_FUNC_SETTING_SELECTED:
                                {
                                    string value = _enumerator.Value.ToString();
                                    m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RecallFormOptions.FunctionParamSelected = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI177481 - Mercury AVT PLC >> Register 
                            case XMLNodeDictionary.XT_REGISTER_CONFIG:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.RegisterEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Mercury AVT PLC >> Register >> Operator On Left
                            case XMLNodeDictionary.XT_REGISTER_OPER_ON_LEFT:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.RegisterConfig.OperatorOnLeft = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Mercury AVT PLC >> Register >> Advance On Top
                            case XMLNodeDictionary.XT_REGISTER_ADVANCE_ON_TOP:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    m_mcSiteConfigData.AVTPLCConfig.RegisterConfig.AdvanceOnTop = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Max Travel
                            case XMLNodeDictionary.XT_REGISTER_LAT_MAX_TRAVEL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.MaxTravel = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Limit Switches
                            case XMLNodeDictionary.XT_REGISTER_LAT_LIMIT_SWITCHES:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Slope
                            case XMLNodeDictionary.XT_REGISTER_LAT_SLOPE:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.Slope = Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Pot Feedback
                            case XMLNodeDictionary.XT_REGISTER_LAT_POT_FEEDBACK:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.PotFeedBack = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Pot Feedback >> Minimum
                            case XMLNodeDictionary.XT_REGISTER_LAT_POT_FB_MIN:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.PotFeedbackMin = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Lateral Motor >> Pot Feedback >> Maximum
                            case XMLNodeDictionary.XT_REGISTER_LAT_POT_FB_MAX:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.LateralMotor.PotFeedbackMax = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Max Travel
                            case XMLNodeDictionary.XT_REGISTER_CIRC_MAX_TRAVEL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.MaxTravel = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Limit Switches
                            case XMLNodeDictionary.XT_REGISTER_CIRC_LIMIT_SWITCHES:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Slope
                            case XMLNodeDictionary.XT_REGISTER_CIRC_SLOPE:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.Slope = Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Pot Feedback
                            case XMLNodeDictionary.XT_REGISTER_CIRC_POT_FEEDBACK:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.PotFeedBack = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Pot Feedback >> Minimum
                            case XMLNodeDictionary.XT_REGISTER_CIRC_POT_FB_MIN:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.PotFeedbackMin = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Circ Motor >> Pot Feedback >> Maximum
                            case XMLNodeDictionary.XT_REGISTER_CIRC_POT_FB_MAX:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.CircMotor.PotFeedbackMax = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Pot Feedback
                            case XMLNodeDictionary.XT_INKER_REGISTER_SKEW_MOTOR:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewEnabled = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Max Travel
                            case XMLNodeDictionary.XT_REGISTER_SKEW_MAX_TRAVEL:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.MaxTravel = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Limit Switches
                            case XMLNodeDictionary.XT_REGISTER_SKEW_LIMIT_SWITCHES:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.LimitSwitches = (eMOTOR_LIMIT_SWITCHES)Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Slope
                            case XMLNodeDictionary.XT_REGISTER_SKEW_SLOPE:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.Slope = Convert.ToInt32( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Pot Feedback
                            case XMLNodeDictionary.XT_REGISTER_SKEW_POT_FEEDBACK:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.PotFeedBack = (value == XMLNodeDictionary.XT_PRESS_TRUE);
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Pot Feedback >> Minimum
                            case XMLNodeDictionary.XT_REGISTER_SKEW_POT_FB_MIN:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.PotFeedbackMin = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI177481 - Press >> Press Units >> Inker >> Register >> Skew Motor >> Pot Feedback >> Maximum
                            case XMLNodeDictionary.XT_REGISTER_SKEW_POT_FB_MAX:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = (MCPressUnit)(mcTempPressInfo.UnitList[ pressUnitIndex ]);
                                    MCInker inker = (MCInker)(pressUnit.InkerList[ inkerIndex ]);
                                    inker.AVTPLCRegister.SkewMotor.PotFeedbackMax = (float)Convert.ToDouble( value );
                                }
                                break;
                            // WI188815 - Mercury AVT PLC >> Register >> Interlock options >> Block Sidelay Motor when press stopped
                            case XMLNodeDictionary.XT_REGISTER_LAT_BLOCK_MOTOR_WHEN_PRESS_STOPPED:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[ pressUnitIndex ] );
                                    MCInker inker = ( MCInker )( pressUnit.InkerList[ inkerIndex ] );
                                    inker.AVTPLCRegister.LateralMotor.BlockMotorWhenPressStopped = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI188815 - Mercury AVT PLC >> Register >> Interlock options >> Block Circ Motor when press stopped
                            case XMLNodeDictionary.XT_REGISTER_CIRC_BLOCK_MOTOR_WHEN_PRESS_STOPPED:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[ pressUnitIndex ] );
                                    MCInker inker = ( MCInker )( pressUnit.InkerList[ inkerIndex ] );
                                    inker.AVTPLCRegister.CircMotor.BlockMotorWhenPressStopped = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;
                            // WI188815 - Mercury AVT PLC >> Register >> Interlock options >> Block Skew Motor when press stopped
                            case XMLNodeDictionary.XT_REGISTER_SKEW_BLOCK_MOTOR_WHEN_PRESS_STOPPED:
                                {
                                    string value = _enumerator.Value.ToString().ToUpper();
                                    MCPressUnit pressUnit = ( MCPressUnit )( mcTempPressInfo.UnitList[ pressUnitIndex ] );
                                    MCInker inker = ( MCInker )( pressUnit.InkerList[ inkerIndex ] );
                                    inker.AVTPLCRegister.SkewMotor.BlockMotorWhenPressStopped = ( value == XMLNodeDictionary.XT_PRESS_TRUE );
                                }
                                break;

                            default:
                                break;
                        }
                    }

                }
                xmlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if ( (mcTempPressInfo.PressType == (int)enPressTypes.SINGLE_WEB_PRESS) ||
                 (mcTempPressInfo.PressType == (int)enPressTypes.MULTI_WEB_PRESS) ||
                 (mcTempPressInfo.PressType == (int)enPressTypes.TOWER_PRESS))
            {
                m_iInkersPerUnit = 2;
            }
            else
            {
                m_iInkersPerUnit = 1;
            }
        }

        //======================================================================================
        /// <Function>PopulateTheUIFromCurrentPress</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Populate The UIF rom Current Press
        /// </summary>
        /// <history>
        /// LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// Hema Dt: 10/12/2009 MT: 14520
        /// Suresh, Mar-02-2010, MT: 15345
        /// Suresh MT: 14611  Dt: Mar-25-10
        /// 03-Apr-13, Mark C, WI30603: Changed to update Sweep / Water menu options
        /// </history>
        /// 
        ///=====================================================================================
        private bool PopulateTheUIFromCurrentPress()
        {
            MCPressInfo mcTempPressInfo = GetCurrentPress();
            if (mcTempPressInfo == null)
                return false;
            txtFountainCount.Text = mcTempPressInfo.InkerList.Count.ToString();
            tbDisplayZones.Text = mcTempPressInfo.DisplayKeys.ToString();
            MCPressUnit pressUnit = mcTempPressInfo.GetUnitAt(0);
            if (pressUnit == null)
            {
                MessageBox.Show("Invalid Press Unit information Found Abort open");
                return false;
            }
            MCInker mcInker = ((MCInker)pressUnit.GetInkerAt(0));
            if (mcInker == null)
            {
                MessageBox.Show("Invalid Press Inker information Found Abort open");
                return false;
            }
            LoadPressDetails();
            cqIPAddressTextBox.Text = "";
            cqPortTextBox.Text = "";
            isCLCOEMCheckBox.Checked = false;
            isCLCOEMCheckBox.Checked = mcTempPressInfo.IsCLCOEM;
            if (isCLCOEMCheckBox.Checked)
            {
                cqIPAddressTextBox.Enabled = true;
                cqIPAddressTextBox.Text = mcTempPressInfo.CLCIPAddress;

                cqPortTextBox.Enabled = true;
                cqPortTextBox.Text = mcTempPressInfo.CLCCQPort.ToString();
            }

            return true;
        }


        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Click event of the sweepInterfacesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sweepInterfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SweepInterfaces sweepInter = new SweepInterfaces(m_mcSiteConfigData.AVTPLCConfig);
            sweepInter.StartPosition = FormStartPosition.CenterScreen;
            sweepInter.CurrentPress = GetCurrentPress();
            if (this.sweepConfiguration >= 0)
                sweepInter.previousControl = (byte)sweepConfiguration;
            sweepInter.ShowDialog();
            int configuredControl = sweepInter.configuredSweepContorl;
            if (configuredControl >= 0)
                this.sweepConfiguration = configuredControl;
            sweepInter.Dispose();
        }

        private void pressInterfaceFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PressInterfaceFeatures pressInterface = new PressInterfaceFeatures();
            pressInterface.StartPosition = FormStartPosition.CenterScreen;
            pressInterface.CurrentPress = GetCurrentPress();
            pressInterface.ShowDialog();
            pressInterface.Dispose();
        }

        /// <![CDATA[
        /// 
        /// Function: chkInches_CheckedChanged
        ///
        /// Author: Chetan
        /// 
        /// History: Modified by Suresh for MT#11807
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// chkInches_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMM.Checked == true)
            {
                chkCms.Checked = false;
                chkInches.Checked = false;
                lblKeyWidthUnits.Text = "mm";

                if (txtKeyWidth.Text == "")
                {
                    MessageBox.Show(Properties.Resources.String1);
                    return;
                }

                float fKeyWidth = m_fKeyWidth;
                txtKeyWidth.Text = fKeyWidth.ToString();

                m_CurrentUnit = UnitTypes.UNIT_TYPE_MM;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: chkInches_CheckedChanged
        ///
        /// Author: Chetan
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// chkInches_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkInches_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInches.Checked == true)
            {
                chkCms.Checked = false;
                chkMM.Checked = false;
                lblKeyWidthUnits.Text = "inches";

                if (txtKeyWidth.Text == "")
                {
                    MessageBox.Show(Properties.Resources.String1);
                    return;
                }

                //convert from mm to inches
                float fKeyWidth = (float)(m_fKeyWidth * (1 / 25.4));
                //make it 2 decimal
                int iVal = (int)(fKeyWidth * 100.0f);
                fKeyWidth = (float)(iVal / 100.0f);

                txtKeyWidth.Text = fKeyWidth.ToString();
                
                m_CurrentUnit = UnitTypes.UNIT_TYPE_INCHS;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: chkCms_CheckedChanged
        ///
        /// Author: Someone
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// chkCms_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCms.Checked == true)
            {
                chkInches.Checked = false;
                chkMM.Checked = false;
                lblKeyWidthUnits.Text = "cms";

                if (txtKeyWidth.Text == "")
                {
                    MessageBox.Show(Properties.Resources.String1);
                    return;
                }

                //convert from mm to cm
                float fKeyWidth = m_fKeyWidth / 10;
                txtKeyWidth.Text = fKeyWidth.ToString();
                
                m_CurrentUnit = UnitTypes.UNIT_TYPE_CMS;
            }
        }

        //======================================================================================
        /// <Function>UnitConversions</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// UnitConversions
        /// </summary>
        /// 
        ///=====================================================================================
        public float UnitConversions(float fValue, UnitTypes uTypesFrom, UnitTypes uTypesTo)
        {
            float fConversionValue = 1.0f;
            switch (uTypesFrom)
            {
                case UnitTypes.UNIT_TYPE_MM:
                    {
                        switch (uTypesTo)
                        {
                            case UnitTypes.UNIT_TYPE_CMS:
                                fConversionValue = (float)UnitConverters.fMMToCms;
                                break;

                            case UnitTypes.UNIT_TYPE_INCHS:
                                fConversionValue = (float)UnitConverters.fMMToInch;
                                break;
                        }
                    }
                    break;

                case UnitTypes.UNIT_TYPE_INCHS:
                    {
                        switch (uTypesTo)
                        {
                            case UnitTypes.UNIT_TYPE_CMS:
                                fConversionValue = (float)UnitConverters.fInchToCms;
                                break;

                            case UnitTypes.UNIT_TYPE_MM:
                                fConversionValue = (float)UnitConverters.fInchToMM;
                                break;

                        }
                    }
                    break;

                case UnitTypes.UNIT_TYPE_CMS:
                    {
                        switch (uTypesTo)
                        {
                            case UnitTypes.UNIT_TYPE_MM:
                                fConversionValue = (float)UnitConverters.fCmsToMM;
                                break;

                            case UnitTypes.UNIT_TYPE_INCHS:
                                fConversionValue = (float)UnitConverters.fCmsToInch;
                                break;
                        }
                    }
                    break;
            }
            fConversionValue = RoundTo4Decimal(fConversionValue);
            float fNewVal = (fValue * fConversionValue);
            return (float)RoundTo2Decimal(ref fNewVal);
        }

        //======================================================================================
        /// <Function>RoundTo2Decimal</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// RoundTo2Decimal
        /// </summary>
        /// <History>
        /// Hema Kumr MT# 12122, 12123
        /// </History>
        ///=====================================================================================
        public float RoundTo2Decimal(ref float fVal)
        {
            fVal += 0.005f;
            int iVal = (int)(fVal * 100.0f);
            fVal = (float)(iVal / 100.0f);
            return fVal;
        }

        //======================================================================================
        /// <Function>RoundTo4Decimal</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// RoundTo4Decimal
        /// </summary>
        /// 
        ///=====================================================================================
        public float RoundTo4Decimal(float fNewVal)
        {
            int iValue = (int)(fNewVal * 1000000.0f);
            return (float)(iValue / 1000000.0f);
        }


        private void cboInkerList_TextChanged(object sender, EventArgs e)
        {
        }

        ///======================================================================================
        /// <Function>btnInkerNameChange_Click</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// btn InkerName Change Click
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 11-12-2008 MT: 11778
        /// Hema 01/07/2009 MT: 12322 
        /// Hema 01/13/2009 MT: 12324 
        /// Huimin 01/13/2009 check to see if user canceled the change made using ChangingInkerName dlg box
        /// </History>
        ///=====================================================================================
        private void btnInkerNameChange_Click(object sender, EventArgs e)
        {
            frmSingleInput frm = new frmSingleInput();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Value = cboInkerList.Text;
            int iCurrentIdx = cboInkerList.SelectedIndex;
            if ((iCurrentIdx >= 0) || (m_iSelectedInker >= 0))
            {
                //frm.ShowDialog();
                if (frm.ShowDialog ()== DialogResult.OK) //hqi 01/13/09
                {
                    string strNewValue = frm.Value;
                    frm.Dispose();
                    if (strNewValue == "")
                        return;

                    for (int iCount = 0; iCount < cboInkerList.Items.Count; iCount++)
                    {
                        if (iCount == iCurrentIdx)
                            continue;
                        if (strNewValue == cboInkerList.Items[iCount].ToString())
                        {
                            MessageBox.Show("Name already Exists");
                            return;
                        }
                    }
                    if (iCurrentIdx < 0)
                        if (m_iSelectedInker >= 0)
                            iCurrentIdx = m_iSelectedInker;
                    cboInkerList.Items[iCurrentIdx] = strNewValue;
                    mcCurrentInker.InkerName = strNewValue;
                }
            }
        }

        /// <![CDATA[
        /// 
        /// Function: txtKeysPerfountain_TextChanged
        ///
        /// Author: Someone
        /// 
        /// History: Jan-19-2009 HQ - de-couple Keys Per Fountain with inker [0]
        ///         Hema Kumar Dt: 09/01/2009 MT: 13873
        ///         Hema Kumar Dt: 04/03/2010 MT: 15342
        ///         Suresh, Mar-12-2010, MT 15258
        ///         Suresh, Oct-7-2010, MT 13878 (funny fountains suport)
        /// 
        /// ]]>
        /// <summary>
        /// txtKeysPerfountain TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeysPerfountain_TextChanged(object sender, EventArgs e)
        {
            if (txtKeysPerfountain.Text == "")
                return;
            int iMaxKeys = DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS;
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtKeysPerfountain.Text))
            {
                MessageBox.Show("Please enter a number between 1 - " + iMaxKeys.ToString());
                txtKeysPerfountain.Text = GetCurrentPress().GetMostCommonKeysPerFountain().ToString();
                return;
            }
            checkNullEntries();
            if (txtKeysPerfountain.Text == "")
                txtKeysPerfountain.Text = "16";
            int iTotalKeys = Convert.ToInt32(txtKeysPerfountain.Text);
            if (iTotalKeys <= 0 || iTotalKeys > iMaxKeys)
            {
                MessageBox.Show("The Total Keys range is: 1 - 80");
                txtKeysPerfountain.Text = GetCurrentPress().GetMostCommonKeysPerFountain().ToString();
            }

            if (!cbFunnyfountains.Checked)
            {
                txtKeysPerfountain.Text = txtKeysPerfountain.Text;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: tbDisplayZones_TextChanged
        ///
        /// Author: Suresh
        /// 
        /// History: Created for ENH 14611, Mar-17-2010
        ///         Suresh, Oct-7-2010, MT 13878 (funny fountains suport)
        ///         07-July-20, Mark C, 200927: Correct display zones when total keys changes
        /// 
        /// ]]>
        /// <summary>
        /// tbDisplayZones_TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void tbDisplayZones_TextChanged(object sender, EventArgs e)
        {
            if (tbDisplayZones.Text == "")
                return;

            int iMaxDisplayKeys = GetCurrentPress().OCUInterface.NumberOfZones;

            //user should not enter more than total number of keys
            if (Convert.ToInt32(txtKeysPerfountain.Text) < iMaxDisplayKeys)
            {
                iMaxDisplayKeys = Convert.ToInt32(txtKeysPerfountain.Text);
            }

            Regex rgx = new Regex("^[0-9]*$");
            if (!rgx.IsMatch(tbDisplayZones.Text))
            {
                MessageBox.Show("Please enter a number between 1 - " + iMaxDisplayKeys.ToString());
                tbDisplayZones.Text = "";
            }
            checkNullEntries();
        }

        /// <![CDATA[
        /// 
        /// Function: tbDisplayZones_Leave
        ///
        /// Author: Suresh
        /// 
        /// History: Created for ENH 14611, Mar-17-2010
        ///         Suresh, Oct-7-2010, MT 13878 (funny fountains suport)
        ///         07-July-20, Mark C, 200927: Correct display zones when total keys changes
        /// 
        /// ]]>
        /// <summary>
        /// tbDisplayZones_Leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDisplayZones_Leave(object sender, EventArgs e)
        {
            int iMaxDisplayKeys = GetCurrentPress().OCUInterface.NumberOfZones;

            //user should not enter more than total number of keys
            if( Convert.ToInt32( tbDisplayZones.Text ) > iMaxDisplayKeys )
            {
                tbDisplayZones.Text = iMaxDisplayKeys.ToString();
            }

            if ( string.IsNullOrEmpty( tbDisplayZones.Text ) )
            {
                MessageBox.Show("Please enter a number between 1 - " + iMaxDisplayKeys.ToString());
                tbDisplayZones.Text = iMaxDisplayKeys.ToString();
                tbDisplayZones.Focus();
                checkNullEntries();
                return;
            }

            int iEnteredKeys = Convert.ToInt32(tbDisplayZones.Text);
            if (iEnteredKeys <= 0 || iEnteredKeys > iMaxDisplayKeys)
            {
                MessageBox.Show("Please enter a number between 1 - " + iMaxDisplayKeys.ToString());
                tbDisplayZones.Text = iMaxDisplayKeys.ToString();
                tbDisplayZones.Focus();
                checkNullEntries();
                return;
            }

            GetCurrentPress().DisplayKeys = iEnteredKeys;     
        }

        private void txtKeyWidth_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyWidth.Text == "")
                return;
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
            if (!regex.IsMatch(txtKeyWidth.Text))
            {
                if (mcCurrentInker != null)
                    txtKeyWidth.Text = mcCurrentInker.KeyWidth.ToString();
                else
                    txtKeyWidth.Text = "27.725";
            }
            string strKeyWidth = txtKeyWidth.Text;
            bool bValidateDigits = IsValidRangeNumber(strKeyWidth);
            if (!bValidateDigits)
            {
                txtKeyWidth.Text = strKeyWidth.Remove(strKeyWidth.Length - 1); ;
            }
            checkNullEntries();
        }

        /// <![CDATA[
        /// 
        /// Function: txtKeyWidth_Leave
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        ///          15-Apr-11, Mark C, MT16925:Don't update OUC3 Zone width when Inker width is updated
        /// ]]>
        /// <summary>
        /// txt KeyWidth Leave event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeyWidth_Leave(object sender, EventArgs e)
        {
            if (txtKeyWidth.Text != "")
            {
                if (txtKeyWidth.Text == ".")
                    txtKeyWidth.Text = "0";
                if (txtKeyWidth.Text == "0")
                {
                    MessageBox.Show("Key Width should not be 0");
                    KeyWidthValidation();
                }
                if (bValuesChanged())
                    this.btnSave.Enabled = false;
                else
                    this.btnSave.Enabled = true;


                //keep the value always in mm internally to make calculations easy
                if (m_CurrentUnit == UnitTypes.UNIT_TYPE_MM)
                {
                    m_fKeyWidth = float.Parse(txtKeyWidth.Text);
                }
                else if (m_CurrentUnit == UnitTypes.UNIT_TYPE_INCHS)
                {
                    float fVal = float.Parse(txtKeyWidth.Text);
                    m_fKeyWidth = (float)(fVal * 25.4);
                }
                else if (m_CurrentUnit == UnitTypes.UNIT_TYPE_CMS)
                {
                    float fVal = float.Parse(txtKeyWidth.Text);
                    m_fKeyWidth = (float)(fVal * 10);
                }
            }
            else
            {
                KeyWidthValidation();
            }
        }

        private void KeyWidthValidation()
        {
            if (txtKeyWidth.Text == "")
                txtKeyWidth.Text = "27.725";
            if (mcCurrentInker != null)
            {
                if (mcCurrentInker.KeyWidth > 100)
                {
                    mcCurrentInker.KeyWidth = 27.725F;
                    txtKeyWidth.Text = mcCurrentInker.KeyWidth.ToString();
                }
            }
            else
                txtKeyWidth.Text = "27.725";
            m_CurrentUnit = UnitTypes.UNIT_TYPE_MM;
            chkMM.Checked = true;
        }

        /// <![CDATA[
        /// 
        /// Function: checkNullEntries
        ///
        /// Author: UnKnown
        /// 
        /// History: Suresh, MAR-17-10, ENH 14611
        ///         Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// to checkNullEntries
        /// </summary>
        /// <param name=""></param>
        private void checkNullEntries()
        {
            if ((txtFountainCount.Text == "") || (txtKeysPerfountain.Text == "") || (txtKeyWidth.Text == "") ||
                tbDisplayZones.Text == "" || txtKeyWidth.Text == "")
            {
                this.btnNext.Enabled = false;
            }
            else
            {
                this.btnNext.Enabled = true;
            }
        }        

        private void checkBoxVirtualInker_CheckedChanged(object sender, EventArgs e)
        {
            if(mcCurrentInker == null)
                return;
            ServoBanks srvoBank = mcCurrentInker.GetServoBankAt(0);
            if (checkBoxVirtualInker.Checked == true)
            {
                int iTotalKeys = 0;
                txtTotalKeysToCtrl.Text = iTotalKeys.ToString();
                //mcCurrentInker.TotalKeys = iTotalKeys;
                srvoBank.TotalKeys = iTotalKeys;
            }
            else
            {
                txtTotalKeysToCtrl.Text = srvoBank.TotalKeys.ToString();
            }
        }

        //======================================================================================
        /// <Function>txtTotalKeysToCtrl_Leave</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txtTotalKeysToCtrl_Leave event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 11-20-2008 MT: 
        ///     
        /// </History>
        ///=====================================================================================
        private void txtTotalKeysToCtrl_Leave(object sender, EventArgs e)
        {
            if (txtTotalKeysToCtrl.Text == "0")
            {
                checkBoxVirtualInker.Checked = true;
            }
            else
            {
                checkBoxVirtualInker.Checked = false;
            }
            if (txtTotalKeysToCtrl.Text == "")
            {
                txtTotalKeysToCtrl.Text = mcCurrentInker.TotalKeys.ToString();
            }
            //mcCurrentInker.TotalKeys = Convert.ToInt32(txtTotalKeysToCtrl.Text.ToString());
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            checkNullEntriesForFountainConfigurations(); //Nov-06-2008
            //if (txtTotalKeysToCtrl.Text == "")
            //{
            //    return;
            //    //txtTotalKeysToCtrl.Text = servoBank.TotalKeys.ToString();
            //}
            if (Convert.ToInt32(txtTotalKeysToCtrl.Text) > Convert.ToInt32(txtKeysPerfountain.Text))
            {
                MessageBox.Show("Total keys to control should not be more than total Keys");
                txtTotalKeysToCtrl.Text = txtKeysPerfountain.Text;
            }
            servoBank.TotalKeys = int.Parse(txtTotalKeysToCtrl.Text);
        }

        private void pressSiteSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPressSiteSettings pressInterface = new frmPressSiteSettings();
            pressInterface.StartPosition = FormStartPosition.CenterScreen;
            pressInterface.CurrentPress = GetCurrentPress();
            pressInterface.ShowDialog();
            pressInterface.Dispose();
        }

        //======================================================================================
        /// <Function>checkBoxMM_CheckedChanged</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// check Box MM CheckedChanged
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 11-12-2008 MT: 11803
        /// LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// </History>
        ///=====================================================================================
        private void checkBoxMM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMM.Checked == true)
            {
                //MT#11800
                checkBoxCMS.Checked = false;
                checkBoxInches.Checked = false;

                if (txtPressWidth.Text == "")
                {
                    MessageBox.Show(Properties.Resources.String2);
                    return;
                }

                float fVal = float.Parse(txtPressWidth.Text);
                float fNewVal = 0.0f;
                fNewVal = UnitConversions(fVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_MM);
                if (fNewVal < 0)
                {
                    fNewVal = 137.7f;
                }
                m_PressCurrentUnit = UnitTypes.UNIT_TYPE_MM;
                txtPressWidth.Text = fNewVal.ToString();
                m_PressWidthInCM = UnitConversions(fNewVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                CheckAnyChangesDone();
            }
        }

        private void checkBoxCMS_CheckedChanged(object sender, EventArgs e)
        {
            //if (CheckBoxSelection())
            //{
                //MT#11800
                if (checkBoxCMS.Checked == true)
                {
                    checkBoxInches.Checked = false;
                    checkBoxMM.Checked = false;

                    if (txtPressWidth.Text == "")
                    {
                        MessageBox.Show(Properties.Resources.String2);
                        return;
                    }

                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;
                    fNewVal = UnitConversions(fVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                    if (fNewVal < 0)
                    {
                        fNewVal = 137.7f;
                    }
                    m_PressCurrentUnit = UnitTypes.UNIT_TYPE_CMS;
                    txtPressWidth.Text = fNewVal.ToString();
                }
            //}
        }

        private void checkBoxInches_CheckedChanged(object sender, EventArgs e)
        {
                //MT#11800
                if (checkBoxInches.Checked == true)
                {
                    checkBoxCMS.Checked = false;
                    checkBoxMM.Checked = false;
                    if (txtPressWidth.Text == "")
                    {
                        MessageBox.Show(Properties.Resources.String2);
                        return;
                    }

                    float fVal = float.Parse(txtPressWidth.Text);
                    float fNewVal = 0.0f;
                    fNewVal = UnitConversions(fVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_INCHS);
                    if (fNewVal < 0)
                    {
                        fNewVal = 137.7f;
                    }
                    m_PressCurrentUnit = UnitTypes.UNIT_TYPE_INCHS;
                    txtPressWidth.Text = fNewVal.ToString();
                    //m_PressWidthInCM = UnitConversions(fNewVal, m_CurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                    m_PressWidthInCM = UnitConversions(fNewVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_CMS); // Hema
                    CheckAnyChangesDone();
                }
        }

        private void gpCreateNew_Enter(object sender, EventArgs e)
        {

        }

        ///======================================================================================
        /// <Function>txtPressWidth_TextChanged</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txt Press Width TextChanged event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 03/04/2010 MT: 15342
        /// </History>
        ///=====================================================================================
        private void txtPressWidth_TextChanged(object sender, EventArgs e)
        {
            if (txtPressWidth.Text == "")
            {
                enableButtons(true);
                return;
            }
             MCPressInfo mcPressInfo = GetCurrentPress();
             if (mcPressInfo == null)
                 return;
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
            if (!regex.IsMatch(txtPressWidth.Text))
            {
                MessageBox.Show("Enter Valid Number");
                txtPressWidth.Text = mcPressInfo.PressWidth.ToString();
            }
            string strPressWidth = txtPressWidth.Text;
            bool bValidateDigits = IsValidRangeNumber(strPressWidth);
            if (!bValidateDigits)            
            {
                txtPressWidth.Text = strPressWidth.Remove(strPressWidth.Length - 1); ;
            }
            enableButtons(false);
        }


        ///======================================================================================
        /// <Function>IsValidRangeNumber</Function>
        /// <Author>Hema Kumar    </Author>
        /// <Date>Mar-04-2010</Date>
        /// <summary>
        ///  validate the numbers digits
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 03/04/2010 MT: 15342
        /// </History>
        ///=====================================================================================
        internal bool IsValidRangeNumber(string strNumber)
        {
            int iDigits = DefineAndConst.SystemCapacities.MAX_NUMBER_DIGIT;
            bool bResult = true;
            int position = strNumber.IndexOf(".");

            if (position == -1)
            {
                if (strNumber.Length > 7)
                {
                    bResult = false;
                }
                else
                {
                    bResult = true;
                }
            }            
            else if (strNumber.Length > iDigits)
            {
                bResult = false;
            }
            return bResult;
        }         

        //======================================================================================
        /// <Function>buttonOK_Click</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// buttonOK Click event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 12-10-2008 MT: 12163
        /// Hema Kumar Dt: 03/04/2010 MT: 15342    
        ///     23-Apr-13, Mark C, WI30347: Added support for multi web press
        ///     16-Dec-14, spa, WI 51029 Add support for Tower mode.
        ///     24-Dec-16, Mark C, WI95717: Added checks to validate the site number
        /// 	11-Jan-17, Mark C, WI97682: Disable selecting press type once the press data was saved
        /// </History>
        ///=====================================================================================
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ( !IsValidSiteNumber( ) )
            {
                MessageBox.Show( "Invalid Site Number. Valid Range = 1000 to 9999." );
                return;
            }

            if (CheckBoxSelection())
            {
                MCPressInfo mcPressInfo = GetCurrentPress();
                if (mcPressInfo != null)
                {
                    mcPressInfo.PressName = txtPressName.Text;
                    float fTemPressWidth = 0.0f;
                    if (m_PressCurrentUnit != UnitTypes.UNIT_TYPE_CMS)
                    {
                        fTemPressWidth = m_PressWidthInCM;
                    }
                    else
                    {
                        fTemPressWidth = float.Parse(txtPressWidth.Text);
                    }
                    txtPressWidth.Text = fTemPressWidth.ToString();
                    m_iPressIdx = 0;
                    mcPressInfo.PressWidth = float.Parse(txtPressWidth.Text);
                    gpPressConfigurations.Enabled = true;
                    mcPressInfo.PressType = PressType_SelectedIndexChanged();
                    PressInformation_pressTypeChanged();
                    m_mcSiteConfigData.SiteNumber = Convert.ToInt32(txtSiteNumber.Text);
                    m_mcSiteConfigData.SiteName = txtSiteName.Text;
                    m_bUpdatedPressData = true;
                    enableButtons(true);
                    if ((mcPressInfo.PressType == (int)enPressTypes.SINGLE_WEB_PRESS) ||
                        (mcPressInfo.PressType == (int)enPressTypes.MULTI_WEB_PRESS) ||
                        (mcPressInfo.PressType == (int)enPressTypes.TOWER_PRESS))
                    {
                        m_iInkersPerUnit = 2;
                    }
                    else
                    {
                        m_iInkersPerUnit = 1;
                    }
                    GenerateFountainCount();
                    m_bFileOpenMode = false;
                    EnablePressTypeSelection( false );
                    return;
                }
            }
            enableButtons(false);
        }

        /// <![CDATA[
        /// Author: Mark C
        /// 
        /// History: 24-Dec-16, Mark C, WI95717: Added checks to validate the site number   
        /// 
        /// ]]>
        /// <summary>
        /// Determines whether [is valid site number].
        /// </summary>
        /// <returns></returns>
        private bool IsValidSiteNumber()
        {
            int siteNumber = int.Parse( txtSiteNumber.Text );
            return ( ( siteNumber >= 1000  ) && ( siteNumber <= 9999 ) );            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadPressDetails();
            buttonCancel.Enabled = false;   //MT#11800
            enableButtons(true);
        }

        //======================================================================================
        /// <Function>enableButtons</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// enable or disable the buttons
        /// </summary>
        /// <history>
        /// 	    11-Jan-17, Mark C, WI97682: Enable OK and Cancel button in Press Settings until press data was not saved once.
        /// </history>
        ///=====================================================================================
        private void enableButtons(bool bStatus)
        {
            if ( !m_bUpdatedPressData && !m_bFileOpenMode )
            {
                buttonOK.Enabled = true;
                buttonCancel.Enabled = true;
                gpPressConfigurations.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                if ( checkSiteEntries( ) )
                {
                    buttonOK.Enabled = !bStatus;
                    buttonCancel.Enabled = !bStatus;
                    gpPressConfigurations.Enabled = bStatus;
                    btnSave.Enabled = bStatus;
                }
            }
        }

        //======================================================================================
        /// <Function>checkSiteEntries</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Nov-04-2008</Date>
        /// <summary>
        /// enable or disable the buttons
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 12-10-2008 MT: 12163
        /// </History>
        ///=====================================================================================
        private bool checkSiteEntries()
        {
            bool bStatus = false;
            if ((txtPressWidth.Text == "") || (txtPressName.Text == "") || (txtSiteNumber.Text == "") || (txtSiteName.Text == ""))
            {
                buttonOK.Enabled = false;
                buttonCancel.Enabled = true;
                btnSave.Enabled = false;
                gpPressConfigurations.Enabled = false;
            }
            else
                bStatus = true;
            return bStatus;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBoxPressType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         07-May-14, Mark C, WI37033 - Select Job Management option for multi web press
        ///         23-Nov-15, Mark C, WI63631 - Disable Job Management option for Tower press type.
        ///         23-Feb-16, Mark C, WI68970 - Add support for Mercury Newspaper Navigation View option
        /// 		09-Aug-16, Mark C, WI81328: Add support for label Towers with numbers option
        /// 		15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// </history>
        private void comboBoxPressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
            int pressType = PressType_SelectedIndexChanged();
            // update Jobs Management options 
            if ((!m_bFileOpenMode) && (pressType == (int)enPressTypes.MULTI_WEB_PRESS))
            {
                this.jobManagementOption.Checked = true;
            }
            else
            {
                this.jobManagementOption.Checked = m_mcSiteConfigData.ProductOptions.JobModeEnabled;
            }

            // disable Job Management option for Tower Press configurations
            if( ( ( int )enPressTypes.TOWER_PRESS == pressType ) ||
                ( ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS == pressType ) ) 
            {
                this.jobManagementOption.Checked = false;
                this.jobManagementOption.Enabled = false;                
            }
            else
            {
                this.jobManagementOption.Enabled = true;
            }

            // update Newspaper Navigation View Option
            UpdateNewspaperNavigationViewOption( pressType );    
            // update label Towers with numbers option
            UpdateTowersWithNumbersOption( pressType );
            // Update GUI Options with defaults, in case of CIC Press Type
            UpdateMercuryGUIOptions( pressType );
        }


        private bool CheckBoxSelection()
        {
            bool bStatus = false;
            if ((checkBoxCMS.Checked) || (checkBoxMM.Checked) || (checkBoxInches.Checked))
            {
                enableButtons(true);
                bStatus = true;
            }
            else
            {
                enableButtons(false);
                MessageBox.Show("Please select any measurement unit");
                bStatus = false;
            }
            return bStatus;
        }

        //======================================================================================
        /// <Function>txtServoTurns_Leave</Function>
        /// <Author>        </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txtServoTurns_Leave event
        /// </summary>
        /// <History>Hema Kumar Dt:11/20/2008 MT# 12062 
        /// 
        /// </History> 
        ///=====================================================================================
        private void txtServoTurns_Leave(object sender, EventArgs e)
        {
            if (mcCurrentInker != null)
            {
                if (txtServoTurns.Text == "")
                {
                    MessageBox.Show("The range of servo turns are: 0.25 - 1.25 ");
                    txtServoTurns.Text = mcCurrentInker.ServoTurns;
                    return;
                }
                float fSTurns = float.Parse(txtServoTurns.Text);
                if (fSTurns < 0.25f || fSTurns > 1.25)
                {
                    MessageBox.Show("The range of servo turns are: 0.25 - 1.25 ");
                    txtServoTurns.Text = mcCurrentInker.ServoTurns;
                    return;
                }
                mcCurrentInker.ServoTurns = txtServoTurns.Text;
            }
        }

        //======================================================================================
        /// <Function>txtSiteNumber_TextChanged</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// txtSiteNumber TextChanged event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 12-10-2008 MT: 12163
        ///     
        /// </History>
        ///=====================================================================================
        private void txtSiteNumber_TextChanged(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( txtSiteNumber.Text ) )
            {
                enableButtons( false );
                return;
            }
            
            Regex regex = new Regex( "^[0-9]*$" );
            if ( !regex.IsMatch( txtSiteNumber.Text ) )
            {
                txtSiteNumber.Text = m_mcSiteConfigData.SiteNumber.ToString( );
            }

            CheckAnyChangesDone( );
        }
        
        /// <![CDATA[
        /// 
        /// Function: txtKeysPerfountain_Leave
        ///
        /// Author: Someone
        /// 
        /// History: Jan-19/2009 HQ - decouple the keys per fountain with inker [0]
        ///         Hema Dt: 09/01/2009 MT: 13873
        ///         Suresh, Mar-12-2010, MT 15258
        ///         Hema Dt: Jun-30-2010, MT: 15955
        ///         Suresh, 17-Nov-2010, MT: 16025 (update total servos to test)
        /// 
        /// ]]>
        /// <summary>
        /// txtKeysPerfountain Leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeysPerfountain_Leave(object sender, EventArgs e)
        {
            int iMaxWidePressKeys = DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS;
            int iMinWidePressKeys = DefineAndConst.SystemCapacities.WIDEPRESS_MIN_KEYS;
            int iCurrentTotalKeys = GetCurrentPress().GetMostCommonKeysPerFountain();
            int iTotalKeys = iCurrentTotalKeys;
            if (string.IsNullOrEmpty(txtKeysPerfountain.Text))
            {
                MessageBox.Show("Please enter a number between 1-" + iMaxWidePressKeys.ToString());
                txtKeysPerfountain.Text = iCurrentTotalKeys.ToString();
            }
            else
            {
                iTotalKeys = Convert.ToInt32(txtKeysPerfountain.Text);
                if (iCurrentTotalKeys != iTotalKeys)
                {
                    if (MessageBox.Show("Warning: If you change this parameter (Total keys), the number of keys for all the fountains will be reset. Do you want to continue?", "Warning",
                            MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        txtKeysPerfountain.Text = iCurrentTotalKeys.ToString();
                        iTotalKeys = iCurrentTotalKeys;

                        MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
                        mcConsoleZones.NumberOfZones = iTotalKeys;
                    }
                    if (iTotalKeys >= iMinWidePressKeys)
                    {
                        this.isWidePressCheckBox.Checked = true;
                    }
                    else
                    {
                        this.isWidePressCheckBox.Checked = false;
                    }
                }

                //Update Total servos to test with no.of keys
                MCPressInfo curPress = GetCurrentPress();
                if (curPress != null)
                {
                    MCAutoTest AutoTest = curPress.AutoTest;
                    if (AutoTest != null)
                    {
                        AutoTest.TotalServosToTest = iTotalKeys;
                    }
                }
            }

            int iKeysToDisplay = Convert.ToInt32(tbDisplayZones.Text);
            // If the keys to display is more than actual keys to control, then make the keys to display as actual keys
            if (iKeysToDisplay > iTotalKeys)
            {
                tbDisplayZones.Text = iTotalKeys.ToString();
            }
        }
        /// <![CDATA[
        /// 
        /// Function: txtFountainCount_Leave
        ///
        /// Author: Someone
        /// 
        /// History: 
        ///             14-JUN-12, BEttinger, MT17683: deleted code, which prevented odd number of inkers   
        /// ]]>
        /// <summary>
        /// txtFountainCount Leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFountainCount_Leave(object sender, EventArgs e)
        {
            int totalSPUs = GetCurrentPress().GetTotalSPUS();
            int configurableFountains = 6 * totalSPUs;
            int iCurrentTotalFountains = configurableFountains;
            if (txtFountainCount.Text == "")
            {
                MessageBox.Show("Atleast 1 Fountain should be available");
                txtFountainCount.Text = iCurrentTotalFountains.ToString();
            }
            int iTotalFountains = Convert.ToInt16(txtFountainCount.Text);
            if (iTotalFountains == 0)
            {
                MessageBox.Show("Atleast 1 Fountain should be available");                
                txtFountainCount.Text = configurableFountains.ToString();
            }
            if (bValuesChanged())
                this.btnSave.Enabled = false;
            else
                this.btnSave.Enabled = true;
        }

        //======================================================================================
        /// <Function>bValuesChanged</Function>
        /// <Author> Hema Kumar </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// checks the any changes are made
        /// </summary>
        /// <History>
        ///     17-Aug-12, Mark C WI29261: Update the fountain details when number of zones are changed 
        ///         in the press settings
        ///     07-July-20, Mark C, 200927: Correct display zones when total keys changes
        /// </History>
        ///=====================================================================================
        private bool bValuesChanged()
        {
            if(txtKeyWidth.Text == "")
                txtKeyWidth.Text = "27.725";
            bool bstatus = false;
            float fKeyWidth;
            fKeyWidth = (float)Convert.ToDouble(txtKeyWidth.Text);
            if (m_CurrentUnit != UnitTypes.UNIT_TYPE_MM)
            {
                float fTemp = UnitConversions(fKeyWidth, m_CurrentUnit, UnitTypes.UNIT_TYPE_MM);
                fKeyWidth = fTemp;
            }
            int iTotalFountains = GetCurrentPress().InkerList.Count; // Hema 05/06/2009
            int numberOfZones = GetCurrentPress().OCUInterface.NumberOfZones;

            if (mcCurrentInker != null)
            {
                if( ( txtFountainCount.Text != iTotalFountains.ToString() ) || 
                    ( m_iOldKeysValue != numberOfZones ) )                     
                {
                    bstatus = true;
                }
                else if (cbFunnyfountains.Checked)
                {
                    MCPressConsoleZones mcConsoleZones = GetCurrentPress().OCUInterface;
                    if (m_iOldKeysValue != mcConsoleZones.NumberOfZones)
                    {
                        bstatus = true;
                    }
                }
            }
            else
            {
                bstatus = true;
            }
            return bstatus;
        }

        //======================================================================================
        /// <Function>cboInkerList_KeyPress</Function>
        /// <Author> Hema Kumar </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// cboBox InkerList KeyPress event 
        /// </summary>
        /// <History>
        /// 
        /// </History>
        ///=====================================================================================
        private void cboInkerList_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = true; // disables the key board entries in the combo box
        }

        private void autoTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmUtilityTestSettings utilityTestSettings = new frmUtilityTestSettings())
            {
                utilityTestSettings.StartPosition = FormStartPosition.CenterScreen;
                utilityTestSettings.CurrentPress = GetCurrentPress();
                utilityTestSettings.Tag = "Auto Test";
                utilityTestSettings.ShowDialog();
            }
        }

        private void sweepTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmUtilityTestSettings utilityTestSettings = new frmUtilityTestSettings())
            {
                utilityTestSettings.StartPosition = FormStartPosition.CenterScreen;
                utilityTestSettings.CurrentPress = GetCurrentPress();
                utilityTestSettings.Tag = "Sweep Test";
                utilityTestSettings.ShowDialog();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                MessageBox.Show("Please Configure SPUs and Fountains before starting the Utility Test Settings");
                return;
            }
            if (GetCurrentPress().InkerList.Count <= 0)
            {
                MessageBox.Show("Please Configure Fountains before starting the Utility Test Settings");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Click event of the pressWaterToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pressWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormWaterInterface waterInterface = new FormWaterInterface(m_mcSiteConfigData.AVTPLCConfig))
            {
                waterInterface.StartPosition = FormStartPosition.CenterScreen;
                waterInterface.CurrentPress = GetCurrentPress();
                if (this.waterConfiguration >= 0)
                    waterInterface.previousControl = (byte)waterConfiguration;
                waterInterface.ShowDialog();
                int configuredControl = waterInterface.configuredWaterContorl;
                if (configuredControl >= 0)
                    this.waterConfiguration = configuredControl;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Click event of the toolStripWaterInterface control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripWaterInterface_Click(object sender, EventArgs e)
        {
            using (FormWaterInterface waterInterface = new FormWaterInterface(m_mcSiteConfigData.AVTPLCConfig))
            {
                waterInterface.StartPosition = FormStartPosition.CenterScreen;
                waterInterface.CurrentPress = GetCurrentPress();
                if (this.waterConfiguration >= 0)
                    waterInterface.previousControl = (byte)waterConfiguration;
                waterInterface.ShowDialog();
                int configuredControl = waterInterface.configuredWaterContorl;
                if (configuredControl >= 0)
                    this.waterConfiguration = configuredControl;
            }
        }

        private void WaterInterface_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                MessageBox.Show("Please Configure SPUs and Fountains before starting the Water Interface Settings");
                return;
            }
            else if (GetCurrentPress().InkerList.Count <= 0)
            {
                MessageBox.Show("Please Configure Fountains before starting the Water Interface Settings");
                return;
            }
        }

        private void toolbtnSweeps_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                MessageBox.Show("Please Configure SPUs and Fountains before starting the Sweep Interface Settings");
                return;
            }
            else if (GetCurrentPress().InkerList.Count <= 0)
            {
                MessageBox.Show("Please Configure Fountains before starting the Sweep Interface Settings");
                return;
            }
        }

        private void comboBoxPressType_Leave(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        /// <![CDATA[
        /// 
        /// Function: CheckAnyChangesDone
        ///
        /// Author: Someone
        /// 
        /// History: Suresh, Nov-02-2010, MT 15935 (Enable 'Done' and 'Cancel' buttons properly)
        /// 
        /// ]]>
        /// <summary>
        /// to check any changes done from site information
        /// </summary>
        private void CheckAnyChangesDone()
        {
            if (checkSiteEntries())
            {
                MCPressInfo mcPressInfo = GetCurrentPress();
                if (mcPressInfo != null)
                {
                    float fVal = float.Parse(txtPressWidth.Text);
                    if (m_PressCurrentUnit != UnitTypes.UNIT_TYPE_CMS)
                        fVal = UnitConversions(fVal, m_PressCurrentUnit, UnitTypes.UNIT_TYPE_CMS);
                    if (fVal < 0)
                    {
                        fVal = 137.7f;
                    }
                    int iPressType = PressType_SelectedIndexChanged();

                    if (mcPressInfo.PressName != txtPressName.Text || m_mcSiteConfigData.SiteName != txtSiteName.Text ||
                        m_mcSiteConfigData.SiteNumber != Convert.ToInt16(txtSiteNumber.Text) ||
                        mcPressInfo.PressWidth != fVal || mcPressInfo.PressType != iPressType)
                    {
                        enableButtons(false);
                        return;
                    }                    
                }
                enableButtons(true);
            }
        }
        
        private void txtSiteName_Leave(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        private void txtSiteNumber_Leave(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        private void txtPressWidth_Leave(object sender, EventArgs e)
        {
            float pressWidth = 137.7F;
            MCPressInfo mcPressInfo = GetCurrentPress();
            if (mcPressInfo != null)
            {
                if(mcPressInfo.PressWidth > 0)
                    pressWidth = mcPressInfo.PressWidth;
            }
            if ((txtPressWidth.Text == ".") || txtPressWidth.Text == "")
                txtPressWidth.Text = pressWidth.ToString();
            CheckAnyChangesDone();
        }

        private void txtPressName_Leave(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        private void toolStripAutoScanCal_Click(object sender, EventArgs e)
        {
            using (FormAutoScanCal autoScanCalibration = new FormAutoScanCal())
            {
                autoScanCalibration.StartPosition = FormStartPosition.CenterScreen;
                autoScanCalibration.CurrentPress = GetCurrentPress();
                autoScanCalibration.ShowDialog();
            }
        }

        private void txtPressName_TextChanged(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        private void txtSiteName_TextChanged(object sender, EventArgs e)
        {
            CheckAnyChangesDone();
        }

        /// <![CDATA[
        /// 
        /// Function: isCLCOEMCheckBox_CheckedChanged
        ///
        /// Author: Lonnie Mask
        /// 
        /// History: LMask, 08-AUG-09: MT13404, Add CLC communication with CQ2
        /// 
        /// ]]>
        /// <summary>
        /// Respond to the is clc oem check box by enabling or disabling the
        /// port and ip address fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void isCLCOEMCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            cqIPAddressTextBox.Enabled = isCLCOEMCheckBox.Checked;
            cqPortTextBox.Enabled = isCLCOEMCheckBox.Checked;
        }

        //======================================================================================
        /// <Function>IsWidePressCheckBox_CheckedChanged</Function>
        /// <Author>Hema Kumar    </Author>
        /// <Date>Sep-01-2009</Date>
        /// <summary>
        /// WidePressCheckBox Checked Changed event
        /// </summary>
        /// <History>
        /// Hema Kumar Dt: 09-01-2009 MT: 13873
        /// Suresh     Dt: 01-29-2010 MT: 15094
        /// Hema Kumar Dt: 06-30-2010 MT: 15955
        /// </History>
        ///=====================================================================================
        private void IsWidePressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ValidateWidePressData();
        }

        /// <![CDATA[
        /// 
        /// Function: WidePressCheckChanged
        ///
        /// Author: Hema Kumar
        /// 
        /// History: Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///          07-July-20, Mark C, 200927: Update the Inker count when the total key count is > 44 ( Wide Press )
        ///        
        /// ]]>
        /// <summary>
        /// Validate and Updates the wide press details
        /// </summary>
        private void ValidateWidePressData()
        {
            int iMinKeys = DefineAndConst.SystemCapacities.WIDEPRESS_MIN_KEYS;
            int iMaxKyes = DefineAndConst.SystemCapacities.WIDEPRESS_MAX_KEYS;
            int iAssignedTotalKeys = Convert.ToInt16(txtKeysPerfountain.Text);
            if (isWidePressCheckBox.Checked)
            {
                if ((iAssignedTotalKeys < iMinKeys)
                    || (iAssignedTotalKeys > iMaxKyes))
                {
                    MessageBox.Show("The Range of keys for wide press is:" + iMinKeys.ToString() + " - " + iMaxKyes.ToString());
                    txtKeysPerfountain.Text = iMinKeys.ToString();
                }
            }
            else
            {
                if (iAssignedTotalKeys >= iMinKeys)
                {
                    txtKeysPerfountain.Text = (iMinKeys - 1).ToString();
                }
            }
            m_bFirstListView = true;
            m_bSecondListView = false;
            iFirstView = 1;
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            CurrentPress.ClientInterface.WidePress = IsWidePress;
            // Check if file is opened one
            if ((m_bFileOpenMode == false) && (m_bFountainConfigured == false))
            {
                int iNumOfFountains = ConfigurableFountain();
                if (null != this.txtFountainCount.Text)
                {
                    //assign the configurable fountains
                    txtFountainCount.Text = iNumOfFountains.ToString();
                }
            }
            else
            {
                // Wide Press - Special Case
                if( GetCurrentPress().MCClientInterface.WidePress )
                {
                    int currentInkerCount = 0;
                    Int32.TryParse( txtFountainCount.Text, out currentInkerCount );
                    int configurableInkerCount = ConfigurableFountain();
                    if( currentInkerCount > configurableInkerCount )
                    {
                        GenerateFountainCount();
                    }
                }
            }

            //If it is FFountains and change the wide web status then GenerateFountainConfigurations
            if (cbFunnyfountains.Checked)
            {
                m_bFileOpenMode = false;
            }
        }
        //======================================================================================
        /// <Function>openSiteFileToolStripMenuItem_Click</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// To open an existing SIte File
        /// </summary>
        /// <history>
        ///         11-Jan-17, Mark C, WI97682: Do NOT allow changing Press Type in Edit (open) mode
        /// </history>
        ///=====================================================================================

       private void openSiteFileToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.toolStripPathDropDownButton.Visible = false;
           this.toolStripPathSeparator.Visible = false;
           m_bCreate = true;
           string strFileTag = "There is a new XML";
           if (strFileName != "")
               strFileTag = strFileName;
           if (m_bNewFileOpen)
           {
               MessageBox.Show(strFileTag + " configuration file still Running, save/ close the same before continuing");
               return;
           }

           OpenFileDialog ofn = new OpenFileDialog();
           ofn.FileName = "";
           ofn.Filter = "(*.xml)|*.xml";
           if (ofn.ShowDialog() == DialogResult.OK)
           {
               gpCreateNew.Visible = false;
               //Update that file is opened
               m_bFileOpenMode = true;
               ReadSiteXMLFile(ofn.FileName);
               if (PopulateTheUIFromCurrentPress())
                   createSiteFileToolStripMenuItem_Click(sender, e);
               else
               {
                   m_bFileOpenMode = false;
                   return;
               }
               strFileName = System.IO.Path.GetFileName(ofn.FileName);
               m_bSPUConfigured = false;
               activateSaveCancel(true);
               m_bUpdatedPressData = true;
               // disable Press Type selection in Open (Edit) mode
               EnablePressTypeSelection( false );
               this.gpCreateNew.Text = " Configuration File - " + strFileName;
               return;
           }
           else
           {
               this.toolStripPathDropDownButton.Visible = true;
               this.toolStripPathSeparator.Visible = true;
           }
       }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 11-Jan-17, Mark C, WI97682: Created
        /// 
        /// ]]>
       /// <summary>
       /// Enables the press type selection.
       /// </summary>
       /// <param name="status">if set to <c>true</c> [status].</param>
       private void EnablePressTypeSelection( bool status )
       {
           this.comboBoxPressType.Enabled = status;
       }

        //======================================================================================
        /// <Function>createSiteFileToolStripMenuItem_Click</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// To create a new SIte File
        /// </summary>
        /// <history>
        ///         11-Jan-17, Mark C, WI97682: Enable Press type selection in New mode.
        /// </history>
        ///=====================================================================================

        private void createSiteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_bUpdatedPressData = false;
            EnablePressTypeSelection( true );

            this.toolStripPathDropDownButton.Visible = false;
            this.toolStripPathSeparator.Visible = false;
           
            string strFileTag = "There is a new XML";
            if (strFileName != "")
            {
                strFileTag = strFileName;
            }

            if (gpCreateNew.Visible == true)
            {
                MessageBox.Show(strFileTag + " configuration file still Running, save/ close the same before continuing");
                return;
            }
            gpCreateNew.Visible = true;
            m_bNewFileOpen = true;
            this.NewFileOpen = true;

            m_bSPUConfigured = true;
            LoadPressDetails();
            activateSaveCancel(true);
            enableButtons(true);
            strFileName = "";
            this.gpCreateNew.Text = "Create A New Configuration File";
            txtKeyWidth.Text = "27.725"; // Hema 01/19/2009 to change to default value
        }
        //======================================================================================
        /// <Function>newServerPathToolStripMenuItem_Click</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// To create a new Server path File
        /// </summary>
        /// <history> 
        ///     29-May-19, Mark C, WI177016: Add support for Job Management View paths
        /// </history> 
        ///=====================================================================================
        private void newServerPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripSystemDropDownButton.Visible = false;
            this.toolStripSystemSeparator.Visible = false;
            m_bCreate = true;
            using (ServerDataPath dataPathConfig = new ServerDataPath(m_bCreate,null))
            {
                dataPathConfig.StartPosition = FormStartPosition.CenterParent;
                dataPathConfig.CurrentSystemPath = GetCurrentSystemPath();
                dataPathConfig.CurrentApplnDataPath = GetCurrentApplicationDataPath();
                dataPathConfig.CurrentLogPath = GetCurrentLogPath();
                dataPathConfig.CurrentRuntimePath = GetCurrentRuntimeConfigPath();
                dataPathConfig.CurrentJobsPath = GetCurrentJobsPath();
                dataPathConfig.CurrentJobsArchivePath = GetCurrentJobsArchivePath();
                dataPathConfig.CurrentFormTemplatePath = GetCurrentFormTemplatePath();
                dataPathConfig.ShowDialog();

            }
            this.toolStripSystemDropDownButton.Visible = true;
            this.toolStripSystemSeparator.Visible = true;
        }

        //======================================================================================
        /// <Function>openServerPathToolStripMenuItem_Click</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// To open an existing Server path File
        /// </summary>
        /// <history> 
        ///     29-May-19, Mark C, WI177016: Add support for Job Management View paths
        /// </history> 
        ///=====================================================================================

        private void openServerPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripSystemDropDownButton.Visible = false;
            this.toolStripSystemSeparator.Visible = false;
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.FileName = "MCAppServer";
            ofn.Filter = "(*.mcpath)|*.mcpath";
            ofn.InitialDirectory = @"c:\";
            if (ofn.ShowDialog() == DialogResult.OK)
            {
                string strFileName = strFileName = System.IO.Path.GetFileName(ofn.FileName);
                if (strFileName != "MCAppServer.mcpath")
                {
                    MessageBox.Show("Invalid File selected. Please select MCAppServer.mcpath file!");
                    this.toolStripSystemDropDownButton.Visible = true;
                    this.toolStripSystemSeparator.Visible = true;
                    return;
                }
                gpCreateNew.Visible = false;
                ReadMC3ServerPathFile(ofn.FileName);

                m_bCreate = false;
                using (ServerDataPath dataPathConfig = new ServerDataPath(m_bCreate, ofn.FileName))
                {
                    dataPathConfig.StartPosition = FormStartPosition.CenterParent;
                    dataPathConfig.CurrentSystemPath = GetCurrentSystemPath();
                    dataPathConfig.CurrentApplnDataPath = GetCurrentApplicationDataPath();
                    dataPathConfig.CurrentLogPath = GetCurrentLogPath();
                    dataPathConfig.CurrentRuntimePath = GetCurrentRuntimeConfigPath();
                    dataPathConfig.CurrentJobsPath = GetCurrentJobsPath();
                    dataPathConfig.CurrentJobsArchivePath = GetCurrentJobsArchivePath();
                    dataPathConfig.CurrentFormTemplatePath = GetCurrentFormTemplatePath();
                    dataPathConfig.ShowDialog();
                }
                strFileName = System.IO.Path.GetFileName(ofn.FileName);

                this.gpCreateNew.Text = " Data Path File - " + strFileName;
                this.toolStripSystemDropDownButton.Visible = true;
                this.toolStripSystemSeparator.Visible = true;
                return;
            }
            else
            {
                this.toolStripSystemDropDownButton.Visible = true;
                this.toolStripSystemSeparator.Visible = true;
            }
        }
        //======================================================================================
        /// <Function>helpToolStripMenuItem_Click</Function>
        /// <Author>Sreejit Kumar </Author>
        /// <Date>July-30-2010</Date>
        /// <summary>
        /// About Box
        /// </summary>
        /// 
        /// </History> 
        ///=====================================================================================
       
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (About aboutbox = new About())
            {
                aboutbox.StartPosition = FormStartPosition.CenterParent;
                aboutbox.ShowDialog();
            }
        }

        private void toolStripDataPathButton_Click(object sender, EventArgs e)
        {
            MCPressInfo mcTempPressInfo = GetCurrentPress();
            if (mcTempPressInfo == null)
                return;
            using (FormDataStorage dataStorageConfig = new FormDataStorage(mcTempPressInfo, m_bCreate))
            {
               
                dataStorageConfig.StartPosition = FormStartPosition.CenterScreen;
                dataStorageConfig.StandardPath = mcTempPressInfo.PressClientInterface.StandardPath;
                dataStorageConfig.NetworkPath = mcTempPressInfo.PressClientInterface.NetworkPath;
                dataStorageConfig.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the newClientPathToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637: Add support for configuring Help path
        ///         18-Mar-14, Chetan, Support for Keyboard layouts.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>
        private void newClientPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripSystemDropDownButton.Visible = false;
            this.toolStripSystemSeparator.Visible = false;
            m_bCreate = true;
            using (ClientDataPath clientPathConfig = new ClientDataPath(m_bCreate,null))
            {
                clientPathConfig.StartPosition = FormStartPosition.CenterParent;
                clientPathConfig.ClientConfigPath = GetClientConfigPath();
                clientPathConfig.HelpPath = GetHelpPath();
                clientPathConfig.KBDLayouts = GetKBDLayoutsPath();
                clientPathConfig.LogFilesPath = GetLogFilesPath( );
                clientPathConfig.ShowDialog();
            }
            this.toolStripSystemDropDownButton.Visible = true;
            this.toolStripSystemSeparator.Visible = true;
        }

        /// <summary>
        /// Handles the Click event of the openClientPathToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637: Add support for configuring Help path
        ///         18-Mar-14, Chetan, Support for Keyboard layouts.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>
        private void openClientPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripSystemDropDownButton.Visible = false;
            this.toolStripSystemSeparator.Visible = false;
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.FileName = "MCClient";
            ofn.Filter = "(*.mcpath)|*.mcpath";
            //Set the Initial directory to desktop
            ofn.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofn.ShowDialog() == DialogResult.OK)
            {
                string strFileName = strFileName = System.IO.Path.GetFileName(ofn.FileName);
                if (strFileName != "MCClient.mcpath")
                {
                    MessageBox.Show("Invalid File selected. Please select MCClient.mcpath file!");
                    this.toolStripSystemDropDownButton.Visible = true;
                    this.toolStripSystemSeparator.Visible = true;
                    return;
                }
                gpCreateNew.Visible = false;
                ReadMC3ClientPathFile(ofn.FileName);

                m_bCreate = false;
                using (ClientDataPath clientPathConfig = new ClientDataPath(m_bCreate, ofn.FileName))
                {
                    clientPathConfig.StartPosition = FormStartPosition.CenterParent;
                    clientPathConfig.ClientConfigPath = GetClientConfigPath();
                    clientPathConfig.HelpPath = GetHelpPath();
                    clientPathConfig.KBDLayouts = GetKBDLayoutsPath();
                    clientPathConfig.LogFilesPath = GetLogFilesPath( );
                    clientPathConfig.ShowDialog();
                }
                strFileName = System.IO.Path.GetFileName(ofn.FileName);

                this.gpCreateNew.Text = " Data Path File - " + strFileName;
                this.toolStripSystemDropDownButton.Visible = true;
                this.toolStripSystemSeparator.Visible = true;
                return;
            }
            else
            {
                this.toolStripSystemDropDownButton.Visible = true;
                this.toolStripSystemSeparator.Visible = true;
            }
        }

        /// <![CDATA[
        /// 
        /// Function: RemoveNationNameFromCultureInfo
        /// 
        /// Author: Hema Kumar
        /// 
        /// History: Hema Dt: Oct/8/2010 MT:16162  Turkey support
        /// 
        /// ]]>
        /// <summary>
        /// Removes the nation name from culture info to display language name
        /// </summary>
        /// <param name="strFileName"></param>
        private string RemoveNationNameFromCultureInfo(string strLanguage)
        {
            string strTemp = strLanguage;
            int iNationName = strTemp.IndexOf("(");
            // check for the nation name in the language name
            if (iNationName > 0)
            {
                // remove the nation name in the language name
                strTemp = strTemp.Substring(0, iNationName);
            }
            return strTemp.Trim();
        }
        /// <![CDATA[
        ///  
        /// Function: Encrypt
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Encrypts the data
        /// </summary>
        /// <param name="stringToEncrypt"></param>
        private string Encrypt(string stringToEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(stringToEncrypt);

            // Security key
            string key = DefineAndConst.StringConstant.PASSWORD_SEC_KEY;
            //If hashing use get hashcode regards to your key
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //Always release the resources and flush data
            //of the Cryptographic service provide. Best Practice
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock
                    (toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <![CDATA[
        ///  
        /// Function: Decrypt
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Decrypts the data
        /// </summary>
        /// <param name="StringToDecrypt"></param>
        private string Decrypt(string StringToDecrypt)
        {
            // remove blank spaces
            StringToDecrypt = StringToDecrypt.Trim();
            if (!string.IsNullOrEmpty(StringToDecrypt))
            {
                if (!StringToDecrypt.Equals(MCNWSiteGen.DefineAndConst.StringConstant.NA, StringComparison.InvariantCultureIgnoreCase))
                {
                    byte[] keyArray;
                    //get the byte code of the string
                    byte[] toEncryptArray = Convert.FromBase64String(StringToDecrypt);
                    // Security key
                    string key = DefineAndConst.StringConstant.PASSWORD_SEC_KEY;

                    //if hashing was used get the hash code with regards to your key
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    //release any resource held by the MD5CryptoServiceProvider

                    hashmd5.Clear();

                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                    //set the secret key for the tripleDES algorithm
                    tdes.Key = keyArray;
                    //mode of operation. there are other 4 modes.
                    //We choose ECB(Electronic code Book)
                    tdes.Mode = CipherMode.ECB;
                    //padding mode(if any extra byte added)
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform cTransform = tdes.CreateDecryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock
                            (toEncryptArray, 0, toEncryptArray.Length);
                    //Release resources held by TripleDes Encryptor
                    tdes.Clear();
                    //return the Clear decrypted TEXT
                    return UTF8Encoding.UTF8.GetString(resultArray);
                }
            }
            return string.Empty;
        }

        /// <![CDATA[
        ///  
        /// Function: tbPassword_TextChanged
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// text box Password Text Changed evnent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextbox = (TextBox)sender;
            ValidateThePassword(currentTextbox);
        }


        /// <![CDATA[
        ///  
        /// Function: ValidateThePassword
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Validates The Password
        /// </summary>
        private void ValidateThePassword(TextBox CurrentTextBox)
        {
            string password = CurrentTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                return;
            }
            Regex regex = new Regex("^[0-9]*$");
            // check for the given input is of numeric
            if (!regex.IsMatch(password))
            {
                MessageBox.Show("Password should be numeric values with 6 characters.");
                // assign the current password to the text box
                CurrentTextBox.Text = GetCurrentPassword(CurrentTextBox);
            }
        }

        /// <![CDATA[
        ///  
        /// Function: tbPassword_Leave
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// text box Password Text leave evnent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            ValidateThePassword(currentTextBox);
            int iLength = currentTextBox.Text.Length;
            int iRequiredLength = DefineAndConst.SystemCapacities.PASSWORD_LENGTH;
            if ((iLength < iRequiredLength)
                || (iLength > iRequiredLength))
            {
                MessageBox.Show("Password should be numeric values with 6 characters.");
                // assign the current password to the text box
                currentTextBox.Text = GetCurrentPassword(currentTextBox);
            }
        }

        /// <![CDATA[
        ///  
        /// Function: GetCurrentPassword
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Gets the Current configured Password
        /// </summary>
        /// <param name="currentTextBox"></param>
        private string GetCurrentPassword(TextBox currentTextBox)
        {
            PasswordType passwordType = (PasswordType) currentTextBox.Tag;
            string defaultPassword = GetDefaultPassword(passwordType);
            MCPressInfo mcPressInfo = GetCurrentPress();
            if (null == mcPressInfo)
            {
                return defaultPassword;
            }
            // get the current configured password
            switch (passwordType)
            {
                case PasswordType.Exit:
                    {
                        defaultPassword = mcPressInfo.PressClientInterface.ExitPassword;
                    }
                    break;
                case PasswordType.Configuration:
                    {
                        defaultPassword = mcPressInfo.PressClientInterface.ConfigurationPassword;
                    }
                    break;
                case PasswordType.Diagnostic:
                    {
                        defaultPassword = mcPressInfo.PressClientInterface.DiagnosticPassword;
                    }
                    break;
                case PasswordType.RuntimeOption:
                    {
                        defaultPassword = mcPressInfo.PressClientInterface.AdvUser;
                    }
                    break;
            }
            return defaultPassword;
        }

        /// <![CDATA[
        ///  
        /// Function: GetDefaultPassword
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Gets the default Password
        /// </summary>
        /// <param name="passwordType"></param>
        private string GetDefaultPassword(PasswordType passwordType)
        {
            string defaultPassword = DefineAndConst.StringConstant.DEFAULT_RUNTIME_PASSWORD; ;
            switch (passwordType)
            {
                case PasswordType.Exit:
                    {
                        defaultPassword = DefineAndConst.StringConstant.DEFAULT_EXIT_PASSWORD;
                    }
                    break;
                case PasswordType.Configuration:
                    {
                        defaultPassword = DefineAndConst.StringConstant.DEFAULT_CONFIGURATON_PASSWORD;
                    }
                    break;
                case PasswordType.Diagnostic:
                    {
                        defaultPassword = DefineAndConst.StringConstant.DEFAULT_DIAGNOSTIC_PASSWORD;
                    }
                    break;
            }
            return defaultPassword;
        }

        /// <![CDATA[
        ///  
        /// Function: SetTagInfoForPassword
        /// 
        /// Author: Hema, SEP-02-2010, ENH 16257
        /// 
        /// History: 
        /// ]]>
        /// <summary>
        /// Sets the tag information to the password text boxes
        /// </summary>
        private void SetTagInfoForPassword()
        {
            this.tbConfigurationPassword.Tag = PasswordType.Configuration;
            this.tbDiagnosticPassword.Tag = PasswordType.Diagnostic;
            this.tbExitPassword.Tag = PasswordType.Exit;
            this.tbRuntimePassword.Tag = PasswordType.RuntimeOption;
        }
        /// <![CDATA[
        /// 
        /// Function: cbFunnyfountains_CheckedChanged
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        /// 
        /// ]]>
        /// <summary>
        /// cbFunnyfountains_CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFunnyfountains_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFunnyfountainsData();
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateFunnyfountainsData
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Suresh, Oct-06-2010, MT 13878 (funny fountains support)
        ///          11-Jan-17, Mark C, WI97682: Made the "Servos on Fountain" a read-only field
        /// ]]>
        /// <summary>
        /// to UpdateFunnyfountainsData
        /// </summary>
        private void UpdateFunnyfountainsData()
        {
            if (cbFunnyfountains.Checked)
            {                
                txtKeyWidth.Enabled = false;
            }
            else
            {             
                txtKeyWidth.Enabled = true;
            }

            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            CurrentPress.ClientInterface.FunnyFountains = cbFunnyfountains.Checked;
        }
        //cbVirtualInkers

        /// <![CDATA[
        /// 
        /// Function: cbVirtualInkers_CheckedChanged
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Mark C 3-15-24 (Virtual Inkers support)
        /// 
        /// ]]>
        /// <summary>
        /// cbVirtualInkers_CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbVirtualInkers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateVirtualInkersData();
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateVirtualInkersData
        ///
        /// Author: Suresh
        /// 
        /// History: Created - Mark C 3-15-24 (Virtual Inkers support)
        /// ]]>
        /// <summary>
        /// to UpdateVirtualInkersData
        /// </summary>
        private void UpdateVirtualInkersData()
        {
            if (cbVirtualInkers.Checked)
            {
                // set Virtual Inker option TRUE

            }
            else
            {
                // clear Virtual Inker option 
            }

            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            CurrentPress.ClientInterface.VirtualInkers = cbVirtualInkers.Checked;
        }

        private void OCUSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOCUSettings frmOCUSettings = new frmOCUSettings();
            frmOCUSettings.CurrentPress = GetCurrentPress();
            frmOCUSettings.StartPosition = FormStartPosition.CenterParent;
            frmOCUSettings.ShowDialog();
            frmOCUSettings.Dispose();
        }


        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 13-Aug-12, Mark C, WI28788: Created
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Click event of the autoZeroSettingsToolStripMenuItem control.
        /// </summary>        
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void autoZeroSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAutoZeroConfiguration autoZeroDialog = new FormAutoZeroConfiguration( GetCurrentPress() ))
            {             
                autoZeroDialog.ShowDialog();
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Apr-13, Mark C, WI30347: Created
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Click event of the webConfigWizardMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void webConfigWizardMenuItem_Click(object sender, EventArgs e)
        {
            if (GetCurrentPress().GetTotalSPUS() <= 0)
            {
                MessageBox.Show("Please Configure SPUs and Fountains before configuring Web details");
                return;
            }
            if (GetCurrentPress().InkerList.Count <= 0)
            {
                MessageBox.Show("Please Configure Fountains before configuring Web details");
                return;
            }

            using (FormWebConfigWizard webConfigDialog = new FormWebConfigWizard(GetCurrentPress()))
            {
                webConfigDialog.ShowDialog();
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Apr-13, Mark C, WI30347: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the press settings menu.
        /// </summary>
        private void UpdatePressSettingsMenu()
        {
            MCPressInfo press = GetCurrentPress();
            if (press != null)
            {
                this.webConfigWizardMenuItem.Enabled = (press.PressType == Convert.ToInt32(enPressTypes.MULTI_WEB_PRESS));
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 10-Jun-13, Mark C, WI30950: Created
        ///          23-Oct-13, Mark C, WI33030: Added support for 'Keep Only Last Version of Profiles' option.
        /// 
        /// ]]>
        /// <summary>
        /// Jobs the management option clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void jobManagementOptionClicked(object sender, EventArgs e)
        {
            if (m_mcSiteConfigData != null)
            {
                bool jobManagementSelected = this.jobManagementOption.Checked;
                m_mcSiteConfigData.ProductOptions.JobModeEnabled = jobManagementSelected;
                if (jobManagementSelected)
                {
                    if (this.checkBoxKeepLastVersion.Checked)
                    {
                        this.checkBoxKeepLastVersion.Checked = false;
                        m_mcSiteConfigData.ProductOptions.KeepOnlyLastVersionProfiles = false;
                        string message = string.Format("Un-checked '{0}' option, since it is applicable only in Form mode.", this.checkBoxKeepLastVersion.Text);
                        MessageBox.Show(message);
                    }                
                }
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Oct-13, Mark C, WI33030: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [keeep only last version option].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnKeeepOnlyLastVersionOption(object sender, EventArgs e)
        {
            if (m_mcSiteConfigData != null)
            {
                bool keepLastVersionSelected = this.checkBoxKeepLastVersion.Checked;
                m_mcSiteConfigData.ProductOptions.KeepOnlyLastVersionProfiles = keepLastVersionSelected;
                if (keepLastVersionSelected)
                {
                    if (this.jobManagementOption.Checked)
                    { 
                        this.jobManagementOption.Checked = false;
                        m_mcSiteConfigData.ProductOptions.JobModeEnabled = false;
                        string message = string.Format("The option '{0}' is applicable only in Form mode. So un-checked '{1}' option.", this.checkBoxKeepLastVersion.Text, this.jobManagementOption.Text );
                        MessageBox.Show(message);
                    }  
                }
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 28-May-14, Mark C, WI37511: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [prompt ZAI checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPromptZAICheckedChanged(object sender, EventArgs e)
        {
            if (m_mcSiteConfigData != null)
            {
                m_mcSiteConfigData.ProductOptions.PromptZAINeededOnServerRestart = m_promptZAI.Checked;
            }
        }


        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Oct-14, Mark C, WI41821: Created
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the MercuryServerIPAddressText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryServerIPAddressText_Leave(object sender, EventArgs e)
        {
            TextBox ipAddressTextBox = sender as TextBox;
            if (ipAddressTextBox != null)
            {
                System.Net.IPAddress IPAddress;
                if (!string.IsNullOrEmpty(ipAddressTextBox.Text) &&
                     System.Net.IPAddress.TryParse(ipAddressTextBox.Text.Trim(), out IPAddress))
                {
                    if (IPAddress != null)
                    {
                        string newIPAddress = IPAddress.ToString();
                        m_mcSiteConfigData.ServerConfiguration.IPAddress = newIPAddress;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid IP Address. Please input valid IP Address.");
                    ipAddressTextBox.Undo();
                }
            }
        }

        /// <![CDATA[               
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Oct-14, Mark C, WI41821: Created
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the MercuryServerPortText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MercuryServerPortText_Leave(object sender, EventArgs e)
        {
            TextBox portNumberTextBox = sender as TextBox;
            if (portNumberTextBox != null)
            {
                // Validate input data - numeric value only
                if (System.Text.RegularExpressions.Regex.IsMatch(portNumberTextBox.Text.Trim(), "^[0-9]+$"))
                {
                    m_mcSiteConfigData.ServerConfiguration.PortNumber = Convert.ToInt32( portNumberTextBox.Text.Trim() );
                }
                else
                {
                    MessageBox.Show("Invalid Port Number. Please input valid Port number.");
                    portNumberTextBox.Undo();
                }
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
        /// Updates the tower press settings.
        /// </summary>
        private void UpdateTowerPressSettings()
        {
            MCPressInfo press = GetCurrentPress( );
            if ( null == press )
            {
                return;
            }

            // Disable Importing PRS file option in Open mode.
            if ( !m_bFileOpenMode )
            {
                if ( press.PressType == Convert.ToInt32( enPressTypes.TOWER_PRESS ) )
                {
                    this.m_importPRSGroupBox.Visible = true;
                    this.m_commonSettingsGroupBox.Enabled = false;
                    this.btnNext.Enabled = false;
                    this.txtFountainCount.Enabled = false;
                }
                else
                {
                    this.m_importPRSGroupBox.Visible = false;
                    this.m_commonSettingsGroupBox.Enabled = true;
                    this.btnNext.Enabled = true;                    
                    this.txtFountainCount.Enabled = true;
                }
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
        /// Called when [import PRS file button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnImportPRSFileButtonClick( object sender, EventArgs e )
        {
            using ( OpenFileDialog prsFileDialog = new OpenFileDialog( ) )
            {
                prsFileDialog.Filter = "(*.prs)|*.prs";
                prsFileDialog.Title = "Select a Press Constructor (.PRS) File :";
                prsFileDialog.InitialDirectory = System.Environment.GetFolderPath( Environment.SpecialFolder.MyComputer );

                try
                {
                    if ( prsFileDialog.ShowDialog( ) == DialogResult.OK )
                    {
                        string strFileName = prsFileDialog.FileName;
                        if ( !string.IsNullOrEmpty( strFileName ) )
                        {
                            m_PRSFileLocationText.Text = strFileName;
                            if ( ImportPRSFile( strFileName ) )
                            {
                                MessageBox.Show( string.Format( "PRS File: '{0}' imported successfully!", strFileName ) );
                                UpdateTowerPressInkerDetails( );
                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
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
        /// Imports the PRS file.
        /// </summary>
        /// <param name="prsFileName">Name of the PRS file.</param>
        /// <returns></returns>
        private bool ImportPRSFile( string prsFileName )
        {
            if ( string.IsNullOrEmpty( prsFileName ) )
            {
                return false;
            }

            // check whether the PRS file exists or not?
            if ( !File.Exists( prsFileName ) )
            {
                //PRS file does not exists 
                string message = string.Format( " PRS File: {0} does not exists ", prsFileName );
                MessageBox.Show( message );
                return false;
            }

            bool result = false;

            try
            {
                // Create Imposition Import API object
                ImpositionImport.ImpositionImport_API importAPI = new ImpositionImport.ImpositionImport_API( );
                // Read PRS data
                ImpositionImport.ImpositionImport_API.IMPOSITION_IMPORT_PRS prsData = new ImpositionImport.ImpositionImport_API.IMPOSITION_IMPORT_PRS( );
                ImpositionImport.ImpositionImport_API.eIMPORT_ERRORS retCode = importAPI.ReadPRSData( prsFileName, prsData );

                // Is PRS data import successful?
                if ( ImpositionImport.ImpositionImport_API.eIMPORT_ERRORS.eIMPORT_ERR_NONE != retCode )
                {
                    string strMessage = string.Format( "ImportPRSFile - Error occurred while reading press constructor file: {0}, Error code: {1}", prsFileName, retCode );
                    MessageBox.Show( strMessage );                    
                }
                else
                {
                    MCPressInfo press = GetCurrentPress( );
                    if ( null != press )
                    {
                        result = press.PRSData.UpdateData( prsData );
                    }
                }
            }
            catch ( Exception ex )
            {
                string exceptionMessage = "ImportPRSFile - " + ex.Message;
                MessageBox.Show( exceptionMessage );               
            }

            return result;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-15, Mark C, WI57901: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the tower press inker details.
        /// </summary>
        private void UpdateTowerPressInkerDetails()
        {
            this.m_commonSettingsGroupBox.Enabled = true;            
            MCPressInfo press = GetCurrentPress( );
            if ( null != press )
            {
                this.txtFountainCount.Text = press.PRSData.WebData.GetNumOfInkers( ).ToString();
                this.btnNext.Enabled = true;
            }           
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Feb-16, Mark C, WI68970: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [newspaper navigation view option changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnNewspaperNavigationViewOptionChanged( object sender, EventArgs e )
        {
            if ( m_mcSiteConfigData != null )
            {
                m_mcSiteConfigData.ProductOptions.NewspaperNavigationViewOption = m_newspaperNavigationViewOption.Checked;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 23-Feb-16, Mark C, WI68970: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the newspaper navigation view option.
        /// </summary>
        /// <param name="pressType">Type of the press.</param>
        private void UpdateNewspaperNavigationViewOption( int pressType )
        {
            if ( ( int ) enPressTypes.TOWER_PRESS == pressType )
            {
                this.m_newspaperNavigationViewOption.Enabled = true;
                this.m_newspaperNavigationViewOption.Checked = m_mcSiteConfigData.ProductOptions.NewspaperNavigationViewOption;
            }
            else
            {
                // disable Newspaper Navigation View option for non-Tower press types
                this.m_newspaperNavigationViewOption.Checked = false;
                this.m_newspaperNavigationViewOption.Enabled = false;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 09-Aug-16, Mark C, WI81328: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [tower with numbers option changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTowerWithNumbersOptionChanged( object sender, EventArgs e )
        {
            if ( m_mcSiteConfigData != null )
            {
                m_mcSiteConfigData.ProductOptions.LabelTowersWithNumbersOption = m_labelTowersWithNumbersOption.Checked;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 09-Aug-16, Mark C, WI81328: Created
        /// 
        /// ]]>
        /// <summary>
        /// Updates the towers with numbers option.
        /// </summary>
        /// <param name="pressType">Type of the press.</param>
        private void UpdateTowersWithNumbersOption( int pressType )
        {
            if ( ( int ) enPressTypes.TOWER_PRESS == pressType )
            {
                this.m_labelTowersWithNumbersOption.Enabled = true;
                this.m_labelTowersWithNumbersOption.Checked = m_mcSiteConfigData.ProductOptions.LabelTowersWithNumbersOption;
            }
            else
            {
                // disable Towers with numbers option for non-Tower press types
                this.m_labelTowersWithNumbersOption.Checked = false;
                this.m_labelTowersWithNumbersOption.Enabled = false;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Updates the mercury GUI options.
        /// </summary>
        /// <param name="pressType">Type of the press.</param>
        private void UpdateMercuryGUIOptions( int pressType )
        {
            if( ( int )enPressTypes.SINGLE_SIDED_CIC_PRESS != pressType )
            {
                return;
            }

            if( !m_bFileOpenMode )
            {
                // Set the Mercury GUI Options for CIC Press Type
                m_mcSiteConfigData.GUIOptions.RemovalOfRunButtonOption = true;
                m_mcSiteConfigData.GUIOptions.InvertPresetProfileOption = true;
                m_mcSiteConfigData.GUIOptions.SaveAndUndoSweepConsoleSettings = false;
                m_mcSiteConfigData.GUIOptions.SaveAndUndoWaterConsoleSettings = false;
                m_mcSiteConfigData.GUIOptions.DefaultThumbnailSize = 100;
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 06-Dec-16, Mark C, WI67306: Created
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Click event of the toolStripServerOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripServerOptions_Click( object sender, EventArgs e )
        {
            using( MercuryServerOptionsForm serverOptions = new MercuryServerOptionsForm( m_mcSiteConfigData.ServerOptions ) )
            {
                serverOptions.StartPosition = FormStartPosition.CenterScreen;
                serverOptions.ShowDialog();
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// 
        /// ]]>
        /// <summary>
        /// Handles the Click event of the toolStripGUIOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripGUIOptions_Click( object sender, EventArgs e )
        {
            using( MercuryGUIOptionsForm guiOptions = new MercuryGUIOptionsForm( m_mcSiteConfigData.GUIOptions ) )
            {
                guiOptions.StartPosition = FormStartPosition.CenterScreen;
                guiOptions.ShowDialog();
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 06-Dec-16, Mark C, WI67306: Created
        /// 
        /// ]]>
        /// <summary>
        /// Appends the Mercury Server options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="systemConfigNode">The system configuration node.</param>
        private void AppendMercuryServerOptions( XmlDocument doc, XmlNode systemConfigNode )
        {
            XmlNode serverOptions = doc.CreateElement( XMLNodeDictionary.XT_MERCURY_SERVER_OPTIONS );
            // Log data option 
            XmlNode logdataOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_LOGDATA );
            XmlAttribute logdataOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            logdataOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.LogDataOption.ToString( ).ToUpper( );
            logdataOption.Attributes.Append( logdataOptionAttribute );

            // add Log Data option to Server options
            serverOptions.AppendChild( logdataOption );

            // Log IO data option
            XmlNode logIODataOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_LOGIODATA );
            XmlAttribute logIOdataOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            logIOdataOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.LogIODataOption.ToString( ).ToUpper( );
            logIODataOption.Attributes.Append( logIOdataOptionAttribute );

            // add Log IO Data option to Server options
            serverOptions.AppendChild( logIODataOption );

            // Full Simulation option
            XmlNode simulationOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_SIMULATION );
            XmlAttribute simulationOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            simulationOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.SimulationOption.ToString( ).ToUpper( );
            simulationOption.Attributes.Append( simulationOptionAttribute );

            // add Full Simulation option to Server options
            serverOptions.AppendChild( simulationOption );

            // CPU Affinity option
            XmlNode cpuAffinityOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_CPU_AFFINITY );
            XmlAttribute cpuAffinityOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            cpuAffinityOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.CPUAffinityOption.ToString( ).ToUpper( );
            cpuAffinityOption.Attributes.Append( cpuAffinityOptionAttribute );

            // add CPU Affinity option to Server options
            serverOptions.AppendChild( cpuAffinityOption );

            // NO Stress on SPU option
            XmlNode noStressOnSPUOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_SPU_NOSTRESS );
            XmlAttribute noStressOnSPUOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            noStressOnSPUOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.NoStressOption.ToString( ).ToUpper( );
            noStressOnSPUOption.Attributes.Append( noStressOnSPUOptionAttribute );

            // NO Stress on SPU option to Server options
            serverOptions.AppendChild( noStressOnSPUOption );

            // SPU3 Debug option
            XmlNode spu3DebugOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_SPU3DEBUG );
            XmlAttribute spu3DebugOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            spu3DebugOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.SPU3DebugOption.ToString( ).ToUpper( );
            spu3DebugOption.Attributes.Append( spu3DebugOptionAttribute );

            // SPU3 Debug option to Server options
            serverOptions.AppendChild( spu3DebugOption );

            // Ignore SPU Response option
            XmlNode isrOption = doc.CreateElement( XMLNodeDictionary.XT_SERVER_IGNORE_SPU_RESPONSE );
            XmlAttribute isrOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            isrOptionAttribute.Value = m_mcSiteConfigData.ServerOptions.IgnoreSPUResponseOption.ToString( ).ToUpper( );
            isrOption.Attributes.Append( isrOptionAttribute );

            // Ignore SPU Response option to Server options
            serverOptions.AppendChild( isrOption );

            // Fix COM Ports option
            XmlNode fixCOMPorts = doc.CreateElement( XMLNodeDictionary.XT_SERVER_FIXCOMPORTS );
            XmlAttribute fixCOMPortsAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            fixCOMPortsAttribute.Value = m_mcSiteConfigData.ServerOptions.FixCOMPortsOption.ToString( ).ToUpper( );
            fixCOMPorts.Attributes.Append( fixCOMPortsAttribute );

            // Fix COM Ports option to Server options
            serverOptions.AppendChild( fixCOMPorts );

            // Finally, add Mercury Server Options to System Configuration
            systemConfigNode.AppendChild( serverOptions );
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        ///          17-Dec-18 dlg, (183514) Add auto run delay time
        /// 
        /// ]]>
        /// <summary>
        /// Appends the mercury GUI options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="systemConfigNode">The system configuration node.</param>
        private void AppendMercuryGUIOptions( XmlDocument doc, XmlNode systemConfigNode )
        {
            XmlNode guiOptions = doc.CreateElement( XMLNodeDictionary.XT_MERCURY_GUI_OPTIONS );
            // Removal of Run button option 
            XmlNode removalOfRunButtonOption = doc.CreateElement( XMLNodeDictionary.XT_GUI_REMOVAL_RUN_BUTTON );
            XmlAttribute removalOfRunButtonOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            removalOfRunButtonOptionAttribute.Value = m_mcSiteConfigData.GUIOptions.RemovalOfRunButtonOption.ToString().ToUpper();
            removalOfRunButtonOption.Attributes.Append( removalOfRunButtonOptionAttribute );

            // add Removal of Run button option to GUI Options
            guiOptions.AppendChild( removalOfRunButtonOption );

            // Invert Preset Profile option
            XmlNode invertPresetProfileOption = doc.CreateElement( XMLNodeDictionary.XT_GUI_INVERT_PRESET_PROFILE_BUTTON );
            XmlAttribute invertPresetProfileOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            invertPresetProfileOptionAttribute.Value = m_mcSiteConfigData.GUIOptions.InvertPresetProfileOption.ToString().ToUpper();
            invertPresetProfileOption.Attributes.Append( invertPresetProfileOptionAttribute );

            // add Invert Preset Profile option to GUI Options
            guiOptions.AppendChild( invertPresetProfileOption );

            // Save and Undo Sweep Console settings
            XmlNode saveAndUndoSweepSettings = doc.CreateElement( XMLNodeDictionary.XT_GUI_SAVE_AND_UNDO_SWEEP_SETTINGS );
            XmlAttribute saveAndUndoSweepSettingsAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            saveAndUndoSweepSettingsAttribute.Value = m_mcSiteConfigData.GUIOptions.SaveAndUndoSweepConsoleSettings.ToString().ToUpper();
            saveAndUndoSweepSettings.Attributes.Append( saveAndUndoSweepSettingsAttribute );

            // add Save and Undo Sweep Console settings to GUI Options
            guiOptions.AppendChild( saveAndUndoSweepSettings );

            // Save and Undo Water Console settings
            XmlNode saveAndUndoWaterSettings = doc.CreateElement( XMLNodeDictionary.XT_GUI_SAVE_AND_UNDO_WATER_SETTINGS );
            XmlAttribute saveAndUndoWaterSettingsAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            saveAndUndoWaterSettingsAttribute.Value = m_mcSiteConfigData.GUIOptions.SaveAndUndoWaterConsoleSettings.ToString().ToUpper();
            saveAndUndoWaterSettings.Attributes.Append( saveAndUndoWaterSettingsAttribute );

            // add Save and Undo Water Console settings to GUI Options
            guiOptions.AppendChild( saveAndUndoWaterSettings );

            // Default Thumbnail Size 
            XmlNode defThumbnailSizeElement = doc.CreateElement( XMLNodeDictionary.XT_GUI_DEF_THUMBNAIL_SIZE );
            XmlAttribute defThumbnailSizeElementAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            defThumbnailSizeElementAttribute.Value = m_mcSiteConfigData.GUIOptions.DefaultThumbnailSize.ToString();
            defThumbnailSizeElement.Attributes.Append( defThumbnailSizeElementAttribute );

            // add Default Thumbnail Size to GUI Options
            guiOptions.AppendChild( defThumbnailSizeElement );

            // Auto Run Delay Time option 
            XmlNode autoRunDelayTimeOption = doc.CreateElement( XMLNodeDictionary.XT_GUI_AUTO_RUN_DELAY_TIME );
            XmlAttribute autoRunDelayTimeOptionAttribute = doc.CreateAttribute( XMLNodeDictionary.VALUE );
            autoRunDelayTimeOptionAttribute.Value = m_mcSiteConfigData.GUIOptions.AutoRunDelayTime.ToString( "0.0");
            autoRunDelayTimeOption.Attributes.Append( autoRunDelayTimeOptionAttribute );

            // add Auto Run Delay Time option to GUI Options
            guiOptions.AppendChild( autoRunDelayTimeOption );

            // Finally, add Mercury GUI Options to System Configuration
            systemConfigNode.AppendChild( guiOptions );
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-Sep-17, Mark C, WI128160: Created
        /// 
        /// ]]>
        /// <summary>
        /// Determines whether [is avtplc sweep configured].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is avtplc sweep configured]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsAVTPLCSweepConfigured()
        {            
            bool AVTPLCSweepConfigured = GetCurrentPress().MCClientInterface.SweepControl && 
                    ( sweepConfiguration == ( int )DefineAndConst.ControlTypes.PLC ) &&
                    ( ePLCType.ePLC_AVT == ( ePLCType )GetCurrentPress().SweepInterface.PLCType ) &&
                    m_mcSiteConfigData.AVTPLCConfig.SweepEnabled;

            return AVTPLCSweepConfigured;
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-Sep-17, Mark C, WI128160: Created
        /// 
        /// ]]>
        /// <summary>
        /// Determines whether [is avtplc water configured].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is avtplc water configured]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsAVTPLCWaterConfigured()
        {
            bool AVTPLCWaterConfigured = GetCurrentPress().MCClientInterface.WaterControl &&
                    ( waterConfiguration == ( int )DefineAndConst.ControlTypes.PLC ) &&
                    ( ePLCType.ePLC_AVT == ( ePLCType )GetCurrentPress().WaterInterface.PLCType ) &&
                    m_mcSiteConfigData.AVTPLCConfig.WaterEnabled;

            return AVTPLCWaterConfigured;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///          03-Aug-17, Mark C, WI102725: Add support for Press Speed config parameters
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        /// 		 16-Oct-18 dlg, (177481) Add AVT PLC support for Manual Register
        /// ]]>
        /// <summary>
        /// Appends the mercury AVT PLC configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="systemConfigNode">The system configuration node.</param>
        private void AppendMercuryAVTPLCConfigDetails( XmlDocument doc, XmlNode systemConfigNode )
        {
            MCPressInfo mcPress = GetCurrentPress();
            if( null == mcPress )
            {
                return;
            }
           
            // Append AVT PLC Config parameters, only if either Sweep, Water or Register controls are enabled 
            if( !IsAVTPLCSweepConfigured() &&
                !IsAVTPLCWaterConfigured() &&
                !IsAVTPLCRegisterConfigured() )
            {
                return;
            }

            XmlNode mercuryAVTPLCConfig = doc.CreateElement( XMLNodeDictionary.XT_MERCURY_AVT_PLC_CONFIG );

            AppendAVTPLCConfigDetails( doc, mercuryAVTPLCConfig );
            AppendAVTPLCSweepConfigDetails( doc, mercuryAVTPLCConfig );
            AppendAVTPLCWaterConfigDetails( doc, mercuryAVTPLCConfig );
            AppendAVTPLCPressSpeedConfigDetails( doc, mercuryAVTPLCConfig );
            AppendAVTPLCPlateInfoConfigDetails( doc, mercuryAVTPLCConfig ); 
            AppendAVTPLCPressSpeedVoltageConfigDetails( doc, mercuryAVTPLCConfig ); 
            AppendAVTPLCRegisterConfigDetails( doc, mercuryAVTPLCConfig ); 

            // Finally, add Mercury AVT PLC Configuration details to System Configuration
            systemConfigNode.AppendChild( mercuryAVTPLCConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///          05-Nov-18, Mark C, WI182050: Add 'Sync Sweep / Water console values' option
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury avtplc configuration.</param>
        private void AppendAVTPLCConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            XmlNode avtPLCConfig = doc.CreateElement( XMLNodeDictionary.XT_AVT_PLC );
            // Add PLC Type, IP Address and Port#
            XmlAttribute plcType = doc.CreateAttribute( XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_TYPE );
            plcType.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.PLCType ).ToString();
            avtPLCConfig.Attributes.Append( plcType );

            XmlAttribute plcIPAddress = doc.CreateAttribute( XMLNodeDictionary.IP_ADDRESS );
            plcIPAddress.Value = m_mcSiteConfigData.AVTPLCConfig.PLCIPAdrress;
            avtPLCConfig.Attributes.Append( plcIPAddress );

            XmlAttribute plcPortNum = doc.CreateAttribute( XMLNodeDictionary.PORT );
            plcPortNum.Value = m_mcSiteConfigData.AVTPLCConfig.PLCPortNum.ToString();
            avtPLCConfig.Attributes.Append( plcPortNum );

            XmlAttribute syncSwpWtrConsoleValues = doc.CreateAttribute( XMLNodeDictionary.XT_SYNC_SWEEP_WATER_CONSOLE_VALUES );
            syncSwpWtrConsoleValues.Value = m_mcSiteConfigData.AVTPLCConfig.SyncSweepWaterConsoleValues.ToString().ToUpper();
            avtPLCConfig.Attributes.Append( syncSwpWtrConsoleValues );

            mercuryAVTPLCConfig.AppendChild( avtPLCConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        /// 		 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        /// 		 21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        /// 		 15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury avtplc configuration.</param>
        private void AppendAVTPLCSweepConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            // Append Sweep Parameters only when Sweep Control is enabled
            // and AVT PLC >> Sweep option is enabled
            if( !IsAVTPLCSweepConfigured() )
            {
                return;
            }

            // Sweep Config Value = "true/false"
            XmlNode sweepConfig = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_CONFIG );
            XmlAttribute sweepConfigAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            sweepConfigAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepEnabled.ToString().ToUpper();
            sweepConfig.Attributes.Append( sweepConfigAttribute );

            if( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {
                // Sweep Surge Value = "true/false"
                XmlNode sweepSurge = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_SURGE );
                XmlAttribute sweepSurgeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                sweepSurgeAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.SurgeEnabled.ToString().ToUpper();
                sweepSurge.Attributes.Append( sweepSurgeAttribute );
                sweepConfig.AppendChild( sweepSurge );

                // Append Surge Config details
                AppendAVTPLCSweepConfig_SurgeDetails( doc, sweepSurge );

                // Sweep Inker Wash up Value = "true/false"
                XmlNode inkerWashup = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_INKER_WASH_UP );
                XmlAttribute inkerWashupAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                inkerWashupAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerWashupEnabled.ToString().ToUpper();
                inkerWashup.Attributes.Append( inkerWashupAttribute );
                sweepConfig.AppendChild( inkerWashup );

                // Sweep Ramping Value = "true/false"
                XmlNode sweepRamping = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_RAMPING );
                XmlAttribute sweepRampAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                sweepRampAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RampingEnabled.ToString().ToUpper();
                sweepRamping.Attributes.Append( sweepRampAttribute );
                sweepConfig.AppendChild( sweepRamping );

                // Append Ramping Config details
                AppendAVTPLCSweepConfig_RampingDetails( doc, sweepRamping );

                // Sweep Function Control Value = "true/false"
                XmlNode sweepFunControl = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_FUNC_CONTROL );
                XmlAttribute sweepFuncAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                sweepFuncAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.FunctionControl.SweepFuncControlEnabled.ToString().ToUpper();
                sweepFunControl.Attributes.Append( sweepFuncAttribute );
                sweepConfig.AppendChild( sweepFunControl );

                // Append Sweep Function Control details
                AppendAVTPLCSweepConfig_FunctionControlDetails( doc, sweepFunControl );

                // Sweep Ductor Holdoff Value = "true/false"
                XmlNode ductorHoldOff = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DUCT_HOLDOFF );
                XmlAttribute ductorHoldOffAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                ductorHoldOffAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOffEnabled.ToString().ToUpper();
                ductorHoldOff.Attributes.Append( ductorHoldOffAttribute );
                sweepConfig.AppendChild( ductorHoldOff );

                // Append Ductor Holdoff config details
                AppendAVTPLCSweepConfig_DuctorHoldOffDetails( doc, ductorHoldOff );

                // Sweep options
                XmlNode sweepOptions = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_OPTIONS );
                sweepConfig.AppendChild( sweepOptions );

                // Append Sweep options
                AppendAVTPLCSweepConfig_SweepOptions( doc, sweepOptions );
            }

            // Sweep - Recall Form Options 
            XmlNode sweepRecallFormOptions = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_RECALL_FORM_OPTIONS );
            sweepConfig.AppendChild( sweepRecallFormOptions );

            // Append Recall Form Options
            AppendAVTPLCSweepConfig_RecallFormOptions( doc, sweepRecallFormOptions );

            mercuryAVTPLCConfig.AppendChild( sweepConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        /// 		 27-Sep-17, Mark C, WI128160: Remove obsolete parameters MIN & MAX of Ductor holdoff 
        ///         
        /// ]]>
        /// <summary>
        /// Appends the avtplc sweep configuration ductor hold off details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="ductorHoldOff">The ductor hold off.</param>
        private void AppendAVTPLCSweepConfig_DuctorHoldOffDetails( XmlDocument doc, XmlNode ductorHoldOff )
        {
            // Number of ranges
            XmlNode numOfRanges = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DUCT_RANGES );
            XmlAttribute rangeCountAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_COUNT );
            rangeCountAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList.Count.ToString();
            numOfRanges.Attributes.Append( rangeCountAttribute );

            ductorHoldOff.AppendChild( numOfRanges );

            // Append range - Min, Max, Value
            foreach ( MercuryAVTPLCSweep_DuctorHoldOffRange ductRangeItem in m_mcSiteConfigData.AVTPLCConfig.SweepConfig.DuctorHoldOff.RangeList )
            {
                XmlNode rangeNode = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DUCT_RANGE );

                XmlAttribute rangeValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                rangeValue.Value = ductRangeItem.Value.ToString();
                rangeNode.Attributes.Append( rangeValue );

                ductorHoldOff.AppendChild( rangeNode );
            }
        }
        
        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 	18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration sweep options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="sweepOptions">The sweep options.</param>
        private void AppendAVTPLCSweepConfig_SweepOptions( XmlDocument doc, XmlNode sweepOptions )
        {
            // Sweep Hardware Interface type
            XmlNode hardWareInterfaceType = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_HARDWARE_INTERFACE_TYPE );
            XmlAttribute hardWareInterfaceTypeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            hardWareInterfaceTypeAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerOptions.HardwareInterfaceType ).ToString();
            hardWareInterfaceType.Attributes.Append( hardWareInterfaceTypeAttribute );

            // Append Sweep Hardware Interface type
            sweepOptions.AppendChild( hardWareInterfaceType );

            // Enable Digital Control Cancel on Client
            XmlNode digitalControlCancel = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_ENABLE_DIGITAL_CTRL_CANCEL );
            XmlAttribute digitalControlCancelAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            digitalControlCancelAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkerOptions.EnableDigitalControlCancel.ToString().ToUpper();
            digitalControlCancel.Attributes.Append( digitalControlCancelAttribute );

            // Append Enable Digital Control Cancel on Client
            sweepOptions.AppendChild( digitalControlCancel );
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration recall form options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="sweepRecallFormOptions">The sweep recall form options.</param>
        private void AppendAVTPLCSweepConfig_RecallFormOptions( XmlDocument doc, XmlNode sweepRecallFormOptions )
        {
            // Sweep Trim Value parameter
            XmlNode sweepTrimSelected = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_TRIM_SELECTED );
            XmlAttribute sweepTrimSelectedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            sweepTrimSelectedValue.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.TrimParamSelected.ToString().ToUpper();
            sweepTrimSelected.Attributes.Append( sweepTrimSelectedValue );

            // Append Sweep Trim selected parameter
            sweepRecallFormOptions.AppendChild( sweepTrimSelected );

            // Sweep Function Setting parameter
            XmlNode sweepFuncSelected = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_FUNC_SETTING_SELECTED );
            XmlAttribute sweepFuncSelectedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            sweepFuncSelectedValue.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.FunctionParamSelected.ToString().ToUpper();
            sweepFuncSelected.Attributes.Append( sweepFuncSelectedValue );

            // Append Sweep Function Setting selected parameter
            sweepRecallFormOptions.AppendChild( sweepFuncSelected );
            
            // Sweep Ductor Hold off setting parameter
            XmlNode sweepDuctHoldoffSelected = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DUCT_SETTING_SELECTED );
            XmlAttribute sweepDuctHoldoffSelectedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            sweepDuctHoldoffSelectedValue.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.RecallFormOptions.DuctorHoldoffParamSelected.ToString().ToUpper();
            sweepDuctHoldoffSelected.Attributes.Append( sweepDuctHoldoffSelectedValue );

            // Append Sweep Hold off Setting selected parameter
            sweepRecallFormOptions.AppendChild( sweepDuctHoldoffSelected );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///          21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration ramping details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="sweepRamping">The sweep ramping.</param>
        private void AppendAVTPLCSweepConfig_RampingDetails( XmlDocument doc, XmlNode sweepRamping )
        {
            // Trim influence
            XmlNode trimInfluence = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_TRIM_INFLUENCE );
            XmlAttribute trimInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            trimInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.TrimInfluence.ToString();
            trimInfluence.Attributes.Append( trimInfluenceAttribute );

            sweepRamping.AppendChild( trimInfluence );

            // Master Sweep Control
            XmlNode sweepMasterCtrl = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MASTER_CONTROL );
            XmlAttribute sweepMasterCtrlAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            sweepMasterCtrlAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MasterSweepControlEnabled.ToString().ToUpper();
            sweepMasterCtrl.Attributes.Append( sweepMasterCtrlAttribute );

            sweepRamping.AppendChild( sweepMasterCtrl );

            // Master Influence
            XmlNode masterInfluence = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MASTER_INFLUENCE );
            XmlAttribute masterInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            masterInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MasterInfluence.ToString();
            masterInfluence.Attributes.Append( masterInfluenceAttribute );

            sweepRamping.AppendChild( masterInfluence );

            // Ink Master Setting
            XmlNode inkMasterSetting = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_INK_MASTER_SETTING );
            XmlAttribute inkMasterSettingAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            inkMasterSettingAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.InkMasterSetting.ToString().ToUpper();
            inkMasterSetting.Attributes.Append( inkMasterSettingAttribute );

            sweepRamping.AppendChild( inkMasterSetting );

            // Speed Influence
            XmlNode speedInfluence = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_SPEED_INFLUENCE );
            XmlAttribute speedInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            speedInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.SpeedInfluence.ToString();
            speedInfluence.Attributes.Append( speedInfluenceAttribute );

            sweepRamping.AppendChild( speedInfluence );

            // Base Curve Max
            XmlNode baseCurve = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_BASE_CURVE_MAX );
            XmlAttribute baseCurveMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            baseCurveMaxAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.BaseCurveMax.ToString();
            baseCurve.Attributes.Append( baseCurveMaxAttribute );

            sweepRamping.AppendChild( baseCurve );

            // Motor Clamp Min
            XmlNode motorClampMin = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MOTOR_CLAMP_MIN );
            XmlAttribute motorClampMinAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorClampMinAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MotorClampMin.ToString();
            motorClampMin.Attributes.Append( motorClampMinAttribute );

            sweepRamping.AppendChild( motorClampMin );

            // Motor Clamp Max
            XmlNode motorClampMax = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MOTOR_CLAMP_MAX );
            XmlAttribute motorClampMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorClampMaxAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.Ramping.MotorClampMax.ToString();
            motorClampMax.Attributes.Append( motorClampMaxAttribute );

            sweepRamping.AppendChild( motorClampMax );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration function control details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="sweepFunControl">The sweep function control.</param>
        private void AppendAVTPLCSweepConfig_FunctionControlDetails( XmlDocument doc, XmlNode sweepFunControl )
        {
            // Trim setting manual
            XmlNode trimManual = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_TRIM_MANUAL );
            XmlAttribute trimManualAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            trimManualAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.FunctionControl.TrimSettingManual.ToString();
            trimManual.Attributes.Append( trimManualAttribute );

            sweepFunControl.AppendChild( trimManual );
        }
        
        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep configuration surge details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="sweepSurge">The sweep surge.</param>
        private void AppendAVTPLCSweepConfig_SurgeDetails( XmlDocument doc, XmlNode sweepSurge )
        {
            // Default ON time
            XmlNode defaultOnTime = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_DEF_ONTIME );
            XmlAttribute defOnTimeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            defOnTimeAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.DefaultONTime.ToString();
            defaultOnTime.Attributes.Append( defOnTimeAttribute );

            sweepSurge.AppendChild( defaultOnTime );

            // Max ON time
            XmlNode maxOnTime = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_MAX_ONTIME );
            XmlAttribute maxOnTimeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            maxOnTimeAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.MaxONTime.ToString();
            maxOnTime.Attributes.Append( maxOnTimeAttribute );

            sweepSurge.AppendChild( maxOnTime );

            // Surge Trim
            XmlNode surgeTrim = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_SURGE_TRIM );
            XmlAttribute surgeTrimAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            surgeTrimAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeTrim.ToString();
            surgeTrim.Attributes.Append( surgeTrimAttribute );

            sweepSurge.AppendChild( surgeTrim );

            // Method of surge
            XmlNode methodOfSurge = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_METHOD_OF_SURGE );
            XmlAttribute methodSurgeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            methodSurgeAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeMethod ).ToString();
            methodOfSurge.Attributes.Append( methodSurgeAttribute );

            sweepSurge.AppendChild( methodOfSurge );

            // Surge Device
            XmlNode surgeDevice = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_SURGE_DEVICE );
            XmlAttribute surgeDeviceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            surgeDeviceAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.SweepConfig.InkSurge.SurgeDevice ).ToString();
            surgeDevice.Attributes.Append( surgeDeviceAttribute );

            sweepSurge.AppendChild( surgeDevice );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type         
        /// 
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury avtplc configuration.</param>
        private void AppendAVTPLCWaterConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {            
            // Append Water Parameters only when Water Control is enabled
            // and AVT PLC >> Water option is enabled
            if( !IsAVTPLCWaterConfigured() )
            {
                return;
            }

            // Water Config value = "true/false"
            XmlNode waterConfig = doc.CreateElement( XMLNodeDictionary.XT_WATER_CONFIG );
            XmlAttribute waterConfigAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            waterConfigAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterEnabled.ToString().ToUpper();
            waterConfig.Attributes.Append( waterConfigAttribute );

             if( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_mcSiteConfigData.AVTPLCConfig.PLCType )
             {
                 // Water Flood value = "true/false"
                 XmlNode waterFlood = doc.CreateElement( XMLNodeDictionary.XT_WATER_FLOOD );
                 XmlAttribute waterFloodAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                 waterFloodAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FloodEnabled.ToString().ToUpper();
                 waterFlood.Attributes.Append( waterFloodAttribute );
                 waterConfig.AppendChild( waterFlood );

                 // Append Flood Config details
                 AppendAVTPLCWaterConfig_FloodDetails( doc, waterFlood );

                 // Water Ramping value = "true/false"
                 XmlNode waterRamping = doc.CreateElement( XMLNodeDictionary.XT_WATER_RAMPING );
                 XmlAttribute waterRampAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                 waterRampAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RampingEnabled.ToString().ToUpper();
                 waterRamping.Attributes.Append( waterRampAttribute );
                 waterConfig.AppendChild( waterRamping );

                 // Append Ramping Config details
                 AppendAVTPLCWaterConfig_RampingDetails( doc, waterRamping );

                 // Water Function control value = "true/false"
                 XmlNode waterFuncControl = doc.CreateElement( XMLNodeDictionary.XT_WATER_FUNC_CONTROL );
                 XmlAttribute waterFuncControlAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                 waterFuncControlAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FunctionControl.WaterFuncControlEnabled.ToString().ToUpper();
                 waterFuncControl.Attributes.Append( waterFuncControlAttribute );
                 // Append Water Function Control
                 waterConfig.AppendChild( waterFuncControl );

                 // Append Water Function control details
                 AppendAVTPLCWaterConfig_FunctionControlDetails( doc, waterFuncControl );

                 // Water options
                 XmlNode waterOptions = doc.CreateElement( XMLNodeDictionary.XT_WATER_OPTIONS );
                 waterConfig.AppendChild( waterOptions );

                 // Append Water options
                 AppendAVTPLCWaterConfig_WaterOptions( doc, waterOptions );
             }

            // Water - Recall Form Options
            XmlNode waterRecallFormOptions = doc.CreateElement( XMLNodeDictionary.XT_WATER_RECALL_FORM_OPTIONS );
            waterConfig.AppendChild( waterRecallFormOptions );

            // Append Reacll Form Options of Water
            AppendAVTPLCWaterConfig_RecallFormOptions( doc, waterRecallFormOptions );

            mercuryAVTPLCConfig.AppendChild( waterConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///          20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///          21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration ramping details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="waterRamping">The water ramping.</param>
        private void AppendAVTPLCWaterConfig_RampingDetails( XmlDocument doc, XmlNode waterRamping )
        {
            // Trim Influence
            XmlNode trimInfluence = doc.CreateElement( XMLNodeDictionary.XT_WATER_TRIM_INFLUENCE );
            XmlAttribute trimInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            trimInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.TrimInfluence.ToString();
            trimInfluence.Attributes.Append( trimInfluenceAttribute );

            // Append Trim Influence
            waterRamping.AppendChild( trimInfluence );

            // Master Water Control 
            XmlNode masterWaterCtrl = doc.CreateElement( XMLNodeDictionary.XT_WATER_MASTER_CONTROL );
            XmlAttribute masterWaterCtrlAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            masterWaterCtrlAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MasterWaterControlEnabled.ToString().ToUpper();
            masterWaterCtrl.Attributes.Append( masterWaterCtrlAttribute );

            // Append Water control
            waterRamping.AppendChild( masterWaterCtrl );

            // Master Influence
            XmlNode masterInfluence = doc.CreateElement( XMLNodeDictionary.XT_WATER_MASTER_INFLUENCE );
            XmlAttribute masterInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            masterInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MasterInfluence.ToString();
            masterInfluence.Attributes.Append( masterInfluenceAttribute );

            // Append Master Influence
            waterRamping.AppendChild( masterInfluence );

            // Water Master Setting
            XmlNode waterMasterSetting = doc.CreateElement( XMLNodeDictionary.XT_WATER_MASTER_SETTING );
            XmlAttribute waterMasterSettingAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            waterMasterSettingAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.WaterMasterSetting.ToString();
            waterMasterSetting.Attributes.Append( waterMasterSettingAttribute );

            // Append Water Master setting
            waterRamping.AppendChild( waterMasterSetting );

            // Speed Influence
            XmlNode speedInfluence = doc.CreateElement( XMLNodeDictionary.XT_WATER_SPEED_INFLUENCE );
            XmlAttribute speedInfluenceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            speedInfluenceAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.SpeedInfluence.ToString();
            speedInfluence.Attributes.Append( speedInfluenceAttribute );

            waterRamping.AppendChild( speedInfluence );

            // Base Curve Max
            XmlNode baseCurve = doc.CreateElement( XMLNodeDictionary.XT_WATER_BASE_CURVE_MAX );
            XmlAttribute baseCurveMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            baseCurveMaxAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.BaseCurveMax.ToString();
            baseCurve.Attributes.Append( baseCurveMaxAttribute );

            waterRamping.AppendChild( baseCurve );

            // Motor Clamp Min
            XmlNode motorClampMin = doc.CreateElement( XMLNodeDictionary.XT_WATER_MOTOR_CLAMP_MIN );
            XmlAttribute motorClampMinAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorClampMinAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MotorClampMin.ToString();
            motorClampMin.Attributes.Append( motorClampMinAttribute );

            waterRamping.AppendChild( motorClampMin );

            // Motor Clamp Max
            XmlNode motorClampMax = doc.CreateElement( XMLNodeDictionary.XT_WATER_MOTOR_CLAMP_MAX );
            XmlAttribute motorClampMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorClampMaxAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Ramping.MotorClampMax.ToString();
            motorClampMax.Attributes.Append( motorClampMaxAttribute );

            waterRamping.AppendChild( motorClampMax );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 20-Nov-17, Mark C, WI143284: Make Sweep/Water Function controls independent from Ramping
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration function control details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="waterFuncControl">The water function control.</param>
        private void AppendAVTPLCWaterConfig_FunctionControlDetails( XmlDocument doc, XmlNode waterFuncControl )
        {
            // Trim Setting Manual
            XmlNode trimSettingManual = doc.CreateElement( XMLNodeDictionary.XT_WATER_TRIM_MANUAL );
            XmlAttribute trimManualAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            trimManualAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.FunctionControl.TrimSettingManual.ToString();
            trimSettingManual.Attributes.Append( trimManualAttribute );

            // Append Trim Setting
            waterFuncControl.AppendChild( trimSettingManual );
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI145676: Add support for new Ramp curve parameters
        /// 		 	18-Feb-18, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration water options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="waterOptions">The water options.</param>
        private void AppendAVTPLCWaterConfig_WaterOptions( XmlDocument doc, XmlNode waterOptions )
        {
            // Water Hardware Interface type
            XmlNode hardWareInterfaceType = doc.CreateElement( XMLNodeDictionary.XT_WATER_HARDWARE_INTERFACE_TYPE );
            XmlAttribute hardWareInterfaceTypeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            hardWareInterfaceTypeAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.WaterConfig.WaterOptions.HardwareInterfaceType ).ToString();
            hardWareInterfaceType.Attributes.Append( hardWareInterfaceTypeAttribute );

            // Append Water Hardware Interface type
            waterOptions.AppendChild( hardWareInterfaceType );

            // Enable Digital Control Cancel on Client
            XmlNode digitalControlCancel = doc.CreateElement( XMLNodeDictionary.XT_WATER_ENABLE_DIGITAL_CTRL_CANCEL );
            XmlAttribute digitalControlCancelAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            digitalControlCancelAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.WaterOptions.EnableDigitalControlCancel.ToString().ToUpper();
            digitalControlCancel.Attributes.Append( digitalControlCancelAttribute );

            // Append Enable Digital Control Cancel on Client
            waterOptions.AppendChild( digitalControlCancel );            
        }

        /// <![CDATA[        
        /// Author:     Mark C
        /// 
        /// History:    21-Dec-17, Mark C, WI149990: Add support for Recall Form Options
        ///
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration recall form options.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="waterRecallFormOptions">The water recall form options.</param>
        private void AppendAVTPLCWaterConfig_RecallFormOptions( XmlDocument doc, XmlNode waterRecallFormOptions )
        {
            // Water Trim Value parameter
            XmlNode waterTrimSelected = doc.CreateElement( XMLNodeDictionary.XT_WATER_TRIM_SELECTED );
            XmlAttribute waterTrimSelectedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            waterTrimSelectedValue.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RecallFormOptions.TrimParamSelected.ToString().ToUpper();
            waterTrimSelected.Attributes.Append( waterTrimSelectedValue );

            // Append Water Trim selected parameter
            waterRecallFormOptions.AppendChild( waterTrimSelected );

            // Water Function Setting parameter
            XmlNode waterFuncSelected = doc.CreateElement( XMLNodeDictionary.XT_WATER_FUNC_SETTING_SELECTED );
            XmlAttribute waterFuncSelectedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            waterFuncSelectedValue.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.RecallFormOptions.FunctionParamSelected.ToString().ToUpper();
            waterFuncSelected.Attributes.Append( waterFuncSelectedValue );

            // Append Water Function Setting selected parameter
            waterRecallFormOptions.AppendChild( waterFuncSelected );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support 
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water configuration flood details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="waterFlood">The water flood.</param>
        private void AppendAVTPLCWaterConfig_FloodDetails( XmlDocument doc, XmlNode waterFlood )
        {
            // Default ON time
            XmlNode defOnTime = doc.CreateElement( XMLNodeDictionary.XT_WATER_DEF_ONTIME );
            XmlAttribute defOnTimeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            defOnTimeAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.DefaultONTime.ToString();
            defOnTime.Attributes.Append( defOnTimeAttribute );

            waterFlood.AppendChild( defOnTime );

            // Max ON time
            XmlNode maxONTime = doc.CreateElement( XMLNodeDictionary.XT_WATER_MAX_ONTIME );
            XmlAttribute maxONTimeAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            maxONTimeAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.MaxONTime.ToString();
            maxONTime.Attributes.Append( maxONTimeAttribute );

            waterFlood.AppendChild( maxONTime );

            // Flood trim
            XmlNode floodTrim = doc.CreateElement( XMLNodeDictionary.XT_WATER_FLOOD_TRIM );
            XmlAttribute floodTrimAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            floodTrimAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodTrim.ToString();
            floodTrim.Attributes.Append( floodTrimAttribute );

            waterFlood.AppendChild( floodTrim );

            // Method of flood
            XmlNode methodOfFlood = doc.CreateElement( XMLNodeDictionary.XT_WATER_METHOD_OF_FLOOD );
            XmlAttribute methodOfFloodAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            methodOfFloodAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodMethod ).ToString();
            methodOfFlood.Attributes.Append( methodOfFloodAttribute );

            waterFlood.AppendChild( methodOfFlood );

            // Flood Device
            XmlNode floodDevice = doc.CreateElement( XMLNodeDictionary.XT_WATER_FLOOD_DEVICE );
            XmlAttribute floodDeviceAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            floodDeviceAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.WaterConfig.Flood.FloodDevice ).ToString();
            floodDevice.Attributes.Append( floodDeviceAttribute );

            waterFlood.AppendChild( floodDevice );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add AVT PLC >> Ramping >> Press Speed parameters
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC press speed configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury avtplc configuration.</param>
        private void AppendAVTPLCPressSpeedConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            // Press Speed config details are applicable to the Beckhoff CX50xx model type only
            if( AVTPLCType.eAVTPLCBeckhoffCX50xx != m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {
                return;
            }

            // Press Speed Config
            XmlNode pressSpeedConfig = doc.CreateElement( XMLNodeDictionary.XT_PRESS_SPEED_CONFIG );
            
            // Min Press Speed
            XmlNode minPressSpeed = doc.CreateElement( XMLNodeDictionary.XT_MIN_PRESS_SPEED );
            XmlAttribute minPressSpeedAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            minPressSpeedAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.MinPressSpeed.ToString();
            minPressSpeed.Attributes.Append( minPressSpeedAttribute );

            pressSpeedConfig.AppendChild( minPressSpeed );

            // Max Press Speed
            XmlNode maxPressSpeed = doc.CreateElement( XMLNodeDictionary.XT_MAX_PRESS_SPEED );
            XmlAttribute maxPressSpeedAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            maxPressSpeedAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.MaxPressSpeed.ToString();
            maxPressSpeed.Attributes.Append( maxPressSpeedAttribute );

            pressSpeedConfig.AppendChild( maxPressSpeed );

            // Display Press Speed option
            XmlNode dispPressSpeed = doc.CreateElement( XMLNodeDictionary.XT_DISPLAY_PRESS_SPEED_OPTION );
            XmlAttribute dispPressSpeedAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            dispPressSpeedAttribute.Value = Convert.ToInt32( m_mcSiteConfigData.AVTPLCConfig.PressSpeedConfig.DisplayPressSpeedOption ).ToString();
            dispPressSpeed.Attributes.Append( dispPressSpeedAttribute );

            pressSpeedConfig.AppendChild( dispPressSpeed );

            // Append PressSpeedConfig to AVT PLC Config
            mercuryAVTPLCConfig.AppendChild( pressSpeedConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Plate Info config parameters
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type        
        /// 
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC plate information configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury AVT PLC configuration.</param>
        private void AppendAVTPLCPlateInfoConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            // Plate config details are applicable to the Beckhoff CX50xx model type only
            if( AVTPLCType.eAVTPLCBeckhoffCX50xx != m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {
                return;
            }

            // Plate Info Config
            XmlNode plateInfoConfig = doc.CreateElement( XMLNodeDictionary.XT_PLATE_INFO_CONFIG );

            // Impression length of plate
            XmlNode impressionLengthOfPlate = doc.CreateElement( XMLNodeDictionary.XT_IMPRESSION_LENGTH_OF_PLATE );
            XmlAttribute impressionLengthOfPlateAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            impressionLengthOfPlateAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PlateInfoConfig.ImpressionLengthOfPlate.ToString();
            impressionLengthOfPlate.Attributes.Append( impressionLengthOfPlateAttribute );

            // Append impression length of plate to Plate Info Config
            plateInfoConfig.AppendChild( impressionLengthOfPlate );
            
            // Num of plates in Fountain
            XmlNode numOfPlatesInFountain = doc.CreateElement( XMLNodeDictionary.XT_NUM_OF_PLATES_IN_FOUNTAIN );
            XmlAttribute numOfPlatesInFountainAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            numOfPlatesInFountainAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PlateInfoConfig.NumOfPlatesInFountain.ToString();
            numOfPlatesInFountain.Attributes.Append( numOfPlatesInFountainAttribute );

            // Append #of plates in Fountain
            plateInfoConfig.AppendChild( numOfPlatesInFountain );

            // Append PlateInfoConfig to AVT PLC Config
            mercuryAVTPLCConfig.AppendChild( plateInfoConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Press Speed Voltage parameters
        ///          15-Oct-18, Mark C, WI177003: Add support for CIC Press Type
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC press speed voltage configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury AVT PLC configuration.</param>
        private void AppendAVTPLCPressSpeedVoltageConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            // Press Speed voltage config details are applicable to the Beckhoff CX50xx model type only
            if( AVTPLCType.eAVTPLCBeckhoffCX50xx != m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {
                return;
            }

            // Press Speed Input Voltages - Min and Max
            XmlNode pressSpeedVoltage = doc.CreateElement( XMLNodeDictionary.XT_PRESS_SPEED_INPUT_VOLTAGE );

            // Press Speed Input Min voltage            
            XmlAttribute voltageMinAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MIN );
            voltageMinAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PressSpeedVoltagesConfig.MinValue.ToString();
            pressSpeedVoltage.Attributes.Append( voltageMinAttribute );

            // Press Speed Input Max voltage
            XmlAttribute voltageMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MAX );
            voltageMaxAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.PressSpeedVoltagesConfig.MaxValue.ToString();
            pressSpeedVoltage.Attributes.Append( voltageMaxAttribute );

            // Append PressSpeedVoltageConfig to AVT PLC Config
            mercuryAVTPLCConfig.AppendChild( pressSpeedVoltage );
        }


        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Sweep Input Voltage parameters
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC sweep input voltages.
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="inkerNode">The inker node.</param>
        private void AppendAVTPLCSweepInputVoltages( MCInker inker, XmlDocument doc, XmlNode inkerNode )
        {
            if( !IsAVTPLCSweepConfigured() )
            {
                return;
            }

            // Sweep Input Voltages - Min and Max
            XmlNode sweepInputVoltage = doc.CreateElement( XMLNodeDictionary.XT_SWEEP_INPUT_VOLTAGE );

            // Sweep Input Min voltage
            XmlAttribute voltageMinAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MIN );
            voltageMinAttribute.Value = inker.AVTPLCVoltages.SweepInputVoltages.MinValue.ToString();
            sweepInputVoltage.Attributes.Append( voltageMinAttribute );
             
            // Sweep Input Max voltage
            XmlAttribute voltageMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MAX );
            voltageMaxAttribute.Value = inker.AVTPLCVoltages.SweepInputVoltages.MaxValue.ToString();
            sweepInputVoltage.Attributes.Append( voltageMaxAttribute );

            // Append Sweep Input Voltage - Min and Max
            inkerNode.AppendChild( sweepInputVoltage );

        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 27-Sep-17, Mark C, WI128160: Add AVT PLC >> Water Output Voltage parameters
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC water output voltages.
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="inkerNode">The inker node.</param>
        private void AppendAVTPLCWaterOutputVoltages( MCInker inker, XmlDocument doc, XmlNode inkerNode )
        {
            if( !IsAVTPLCWaterConfigured() )
            {
                return;
            }

            // Water Output Voltages - Min and Max
            XmlNode waterOutputVoltage = doc.CreateElement( XMLNodeDictionary.XT_WATER_OUTPUT_VOLTAGE );

            // Water Output Min Voltage
            XmlAttribute voltageMinAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MIN );
            voltageMinAttribute.Value = inker.AVTPLCVoltages.WaterOutputVoltages.MinValue.ToString();
            waterOutputVoltage.Attributes.Append( voltageMinAttribute );

            // Water Output Max Voltage
            XmlAttribute voltageMaxAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_MAX );
            voltageMaxAttribute.Value = inker.AVTPLCVoltages.WaterOutputVoltages.MaxValue.ToString();
            waterOutputVoltage.Attributes.Append( voltageMaxAttribute );
            
            // Append Water Output Voltage - Min and Max
            inkerNode.AppendChild( waterOutputVoltage );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 10-Oct-2018, dlg (177481) Add AVT PLC Support for Register interface
        ///          10-Jun-19, Mark C, AVT PLC can support up to 6 Register controls only. 
        ///                 So, display a message, if #of Inkers configured are > 6 and AVT PLC is selected to control the Registers.     
		///			Oct 7 -2019 markc (195391 - allow register to support up to 10 units in AVT PLC.
        /// ]]>
        /// <summary>
        /// Handles the Click event of the registerInterfacesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void registerInterfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCPressInfo currentPress = GetCurrentPress();
            if( null == currentPress )
            {
                return;
            }

            if( currentPress.GetTotalSPUS() <= 0 )
            {
                MessageBox.Show( "Please Configure SPUs and Fountains before starting the Register Interface settings." );
                return;
            }

            if( currentPress.InkerList.Count <= 0 )
            {
                MessageBox.Show( "Please Configure Fountains before starting the Register Interface settings." );
                return;
            }

            // Currently, AVT PLC can support up to 10 Inkers only for Register control. Let's check the #of Inkers accordingly
            if (currentPress.InkerList.Count > 10 && !currentPress.ClientInterface.VirtualInkers)
            {
                MessageBox.Show( "The AVT PLC can support up to 10 Register controls only. Please configure the number of Inkers accordingly." );                
                return;
            }

            using( MercuryAVTPLCRegisterConfigForm avtPLCRegisterConfigForm = new MercuryAVTPLCRegisterConfigForm( currentPress, m_mcSiteConfigData.AVTPLCConfig ) )
            {
                avtPLCRegisterConfigForm.StartPosition = FormStartPosition.CenterParent;
                avtPLCRegisterConfigForm.ShowDialog();
            }
        }
        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 16-Oct-18 dlg, (177481) Add AVT PLC support for Manual Register
        /// 
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC register configuration details.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="mercuryAVTPLCConfig">The mercury avtplc configuration.</param>
        private void AppendAVTPLCRegisterConfigDetails( XmlDocument doc, XmlNode mercuryAVTPLCConfig )
        {
            // Skip if Register control is not enabled
            if( !IsAVTPLCRegisterConfigured() )
            {
                return;
            }

            // Register Config Value = "true/false"
            XmlNode registerConfig = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CONFIG );
            XmlAttribute registerConfigAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            registerConfigAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.RegisterEnabled.ToString().ToUpper();
            registerConfig.Attributes.Append( registerConfigAttribute );

            if( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {
                // Operator On Left Value = "true/false"
                XmlNode registerOperOnLeft = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_OPER_ON_LEFT );
                XmlAttribute registerOperOnLeftAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                registerOperOnLeftAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.RegisterConfig.OperatorOnLeft.ToString().ToUpper();
                registerOperOnLeft.Attributes.Append( registerOperOnLeftAttribute );
                registerConfig.AppendChild( registerOperOnLeft );

                // Advance On Top = "true/false"
                XmlNode registerAdvanceOnTop = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_ADVANCE_ON_TOP );
                XmlAttribute registerAdvanceOnTopAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                registerAdvanceOnTopAttribute.Value = m_mcSiteConfigData.AVTPLCConfig.RegisterConfig.AdvanceOnTop.ToString().ToUpper();
                registerAdvanceOnTop.Attributes.Append( registerAdvanceOnTopAttribute );
                registerConfig.AppendChild( registerAdvanceOnTop );
            }

            mercuryAVTPLCConfig.AppendChild( registerConfig );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 16-Oct-2018 dlg, (177481) Add XML data elements for Register control
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC register inker configuration.
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="inkerNode">The inker node.</param>
        private void AppendAVTPLCRegisterInkerConfig( MCInker inker, XmlDocument doc, XmlNode inkerNode )
        {
            // Skip if Register control is not enabled
            if( !IsAVTPLCRegisterConfigured() )
            {
                return;
            }

            if( AVTPLCType.eAVTPLCBeckhoffCX50xx == m_mcSiteConfigData.AVTPLCConfig.PLCType )
            {

                // Register Config Value
                XmlNode registerConfig = doc.CreateElement( XMLNodeDictionary.XT_INKER_REGISTER_CONFIG );

                // Lateral Motor
                XmlNode registerLatMotor = doc.CreateElement( XMLNodeDictionary.XT_INKER_REGISTER_LAT_MOTOR );
                registerConfig.AppendChild( registerLatMotor );
                AppendAVTPLCRegisterInker_LatMotorDetails( inker, doc, registerLatMotor );

                // Circ Motor
                XmlNode registerCircMotor = doc.CreateElement( XMLNodeDictionary.XT_INKER_REGISTER_CIRC_MOTOR );
                registerConfig.AppendChild( registerCircMotor );
                AppendAVTPLCRegisterInker_CircMotorDetails( inker, doc, registerCircMotor );

                // Skew Motor Value = "true/false"
                XmlNode registerSkewMotor = doc.CreateElement( XMLNodeDictionary.XT_INKER_REGISTER_SKEW_MOTOR );
                XmlAttribute registerSkewMotorAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                registerSkewMotorAttribute.Value = inker.AVTPLCRegister.SkewEnabled.ToString().ToUpper();
                registerSkewMotor.Attributes.Append( registerSkewMotorAttribute );
                registerConfig.AppendChild( registerSkewMotor );
                AppendAVTPLCRegisterInker_SkewMotorDetails( inker, doc, registerSkewMotor );

                inkerNode.AppendChild( registerConfig );
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 16-Oct-2018 dlg, (177481) Add XML data elements for Register control
        ///          29-May-19, Mark C, WI188815 - Add support for Ardagh Manual Plate Register interlock options
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC register lateral motor configuration
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="registerLatMotor">The Lateral Motor node.</param>
        private void AppendAVTPLCRegisterInker_LatMotorDetails( MCInker inker, XmlDocument doc, XmlNode registerLatMotor )
        {
            // Max Travel
            XmlNode motorMaxTravel = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_MAX_TRAVEL );
            XmlAttribute motorMaxTravelValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorMaxTravelValue.Value = inker.AVTPLCRegister.LateralMotor.MaxTravel.ToString();
            motorMaxTravel.Attributes.Append( motorMaxTravelValue );
            registerLatMotor.AppendChild( motorMaxTravel );

            // Limit Switches
            XmlNode motorLimitSwitches = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_LIMIT_SWITCHES );
            XmlAttribute motorLimitSwitchesValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            int switchNumber = (int)inker.AVTPLCRegister.LateralMotor.LimitSwitches;
            motorLimitSwitchesValue.Value = switchNumber.ToString();
            motorLimitSwitches.Attributes.Append( motorLimitSwitchesValue );
            registerLatMotor.AppendChild( motorLimitSwitches );

            // Slope
            XmlNode motorSlope = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_SLOPE );
            XmlAttribute motorSlopeValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorSlopeValue.Value = inker.AVTPLCRegister.LateralMotor.Slope.ToString();
            motorSlope.Attributes.Append( motorSlopeValue );
            registerLatMotor.AppendChild( motorSlope );

            // Pot Feedback
            XmlNode motorPotFeedback = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_POT_FEEDBACK );
            XmlAttribute motorPotFeedbackValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackValue.Value = inker.AVTPLCRegister.LateralMotor.PotFeedBack.ToString();
            motorPotFeedback.Attributes.Append( motorPotFeedbackValue );

            // Pot Feedback - Min
            XmlNode motorPotFeedbackMin = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_POT_FB_MIN );
            XmlAttribute motorPotFeedbackMinValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMinValue.Value = inker.AVTPLCRegister.LateralMotor.PotFeedbackMin.ToString();
            motorPotFeedbackMin.Attributes.Append( motorPotFeedbackMinValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMin );

            // Pot Feedback - Max
            XmlNode motorPotFeedbackMax = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_POT_FB_MAX );
            XmlAttribute motorPotFeedbackMaxValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMaxValue.Value = inker.AVTPLCRegister.LateralMotor.PotFeedbackMax.ToString();
            motorPotFeedbackMax.Attributes.Append( motorPotFeedbackMaxValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMax );
            
            registerLatMotor.AppendChild( motorPotFeedback );

            // Block Lat Motor when Press stopped
            XmlNode blockMotorWhenPressStopped = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_LAT_BLOCK_MOTOR_WHEN_PRESS_STOPPED );
            XmlAttribute blockMotorWhenPressStoppedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            blockMotorWhenPressStoppedValue.Value = inker.AVTPLCRegister.LateralMotor.BlockMotorWhenPressStopped.ToString().ToUpper();
            blockMotorWhenPressStopped.Attributes.Append( blockMotorWhenPressStoppedValue );
            registerLatMotor.AppendChild( blockMotorWhenPressStopped );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 16-Oct-2018 dlg, (177481) Add XML data elements for Register control
		///          29-May-19, Mark C, WI188815 - Add support for Ardagh Manual Plate Register interlock options
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC register circumferential motor configuration
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="registerCircMotor">The Circ Motor node.</param>
        private void AppendAVTPLCRegisterInker_CircMotorDetails( MCInker inker, XmlDocument doc, XmlNode registerCircMotor )
        {
            // Max Travel
            XmlNode motorMaxTravel = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_MAX_TRAVEL );
            XmlAttribute motorMaxTravelValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorMaxTravelValue.Value = inker.AVTPLCRegister.CircMotor.MaxTravel.ToString();
            motorMaxTravel.Attributes.Append( motorMaxTravelValue );
            registerCircMotor.AppendChild( motorMaxTravel );

            // Limit Switches
            XmlNode motorLimitSwitches = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_LIMIT_SWITCHES );
            XmlAttribute motorLimitSwitchesValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            int switchNumber = (int)inker.AVTPLCRegister.CircMotor.LimitSwitches;
            motorLimitSwitchesValue.Value = switchNumber.ToString();
            motorLimitSwitches.Attributes.Append( motorLimitSwitchesValue );
            registerCircMotor.AppendChild( motorLimitSwitches );

            // Slope
            XmlNode motorSlope = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_SLOPE );
            XmlAttribute motorSlopeValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorSlopeValue.Value = inker.AVTPLCRegister.CircMotor.Slope.ToString();
            motorSlope.Attributes.Append( motorSlopeValue );
            registerCircMotor.AppendChild( motorSlope );

            // Pot Feedback
            XmlNode motorPotFeedback = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_POT_FEEDBACK );
            XmlAttribute motorPotFeedbackValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackValue.Value = inker.AVTPLCRegister.CircMotor.PotFeedBack.ToString();
            motorPotFeedback.Attributes.Append( motorPotFeedbackValue );

            // Pot Feedback - Min
            XmlNode motorPotFeedbackMin = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_POT_FB_MIN );
            XmlAttribute motorPotFeedbackMinValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMinValue.Value = inker.AVTPLCRegister.CircMotor.PotFeedbackMin.ToString();
            motorPotFeedbackMin.Attributes.Append( motorPotFeedbackMinValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMin );

            // Pot Feedback - Max
            XmlNode motorPotFeedbackMax = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_POT_FB_MAX );
            XmlAttribute motorPotFeedbackMaxValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMaxValue.Value = inker.AVTPLCRegister.CircMotor.PotFeedbackMax.ToString();
            motorPotFeedbackMax.Attributes.Append( motorPotFeedbackMaxValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMax );

            registerCircMotor.AppendChild( motorPotFeedback );

            // Block Circ Motor when Press stopped
            XmlNode blockMotorWhenPressStopped = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_CIRC_BLOCK_MOTOR_WHEN_PRESS_STOPPED );
            XmlAttribute blockMotorWhenPressStoppedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            blockMotorWhenPressStoppedValue.Value = inker.AVTPLCRegister.CircMotor.BlockMotorWhenPressStopped.ToString().ToUpper();
            blockMotorWhenPressStopped.Attributes.Append( blockMotorWhenPressStoppedValue );
            registerCircMotor.AppendChild( blockMotorWhenPressStopped );
        }

        /// <![CDATA[              
        /// 
        /// Author: Don Gerber
        /// History: 16-Oct-2018 dlg, (177481) Add XML data elements for Register control
		///          29-May-19, Mark C, WI188815 - Add support for Ardagh Manual Plate Register interlock options
        ///         
        /// ]]>
        /// <summary>
        /// Appends the AVT PLC register skew motor configuration
        /// </summary>
        /// <param name="inker">The inker.</param>
        /// <param name="doc">The document.</param>
        /// <param name="registerSkewMotor">The Skew Motor node.</param>
        private void AppendAVTPLCRegisterInker_SkewMotorDetails( MCInker inker, XmlDocument doc, XmlNode registerSkewMotor )
        {
            // Max Travel
            XmlNode motorMaxTravel = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_MAX_TRAVEL );
            XmlAttribute motorMaxTravelValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorMaxTravelValue.Value = inker.AVTPLCRegister.SkewMotor.MaxTravel.ToString();
            motorMaxTravel.Attributes.Append( motorMaxTravelValue );
            registerSkewMotor.AppendChild( motorMaxTravel );

            // Limit Switches
            XmlNode motorLimitSwitches = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_LIMIT_SWITCHES );
            XmlAttribute motorLimitSwitchesValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            int switchNumber = (int)inker.AVTPLCRegister.SkewMotor.LimitSwitches;
            motorLimitSwitchesValue.Value = switchNumber.ToString();
            motorLimitSwitches.Attributes.Append( motorLimitSwitchesValue );
            registerSkewMotor.AppendChild( motorLimitSwitches );

            // Slope
            XmlNode motorSlope = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_SLOPE );
            XmlAttribute motorSlopeValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorSlopeValue.Value = inker.AVTPLCRegister.SkewMotor.Slope.ToString();
            motorSlope.Attributes.Append( motorSlopeValue );
            registerSkewMotor.AppendChild( motorSlope );

            // Pot Feedback
            XmlNode motorPotFeedback = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_POT_FEEDBACK );
            XmlAttribute motorPotFeedbackValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackValue.Value = inker.AVTPLCRegister.SkewMotor.PotFeedBack.ToString();
            motorPotFeedback.Attributes.Append( motorPotFeedbackValue );

            // Pot Feedback - Min
            XmlNode motorPotFeedbackMin = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_POT_FB_MIN );
            XmlAttribute motorPotFeedbackMinValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMinValue.Value = inker.AVTPLCRegister.SkewMotor.PotFeedbackMin.ToString();
            motorPotFeedbackMin.Attributes.Append( motorPotFeedbackMinValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMin );

            // Pot Feedback - Max
            XmlNode motorPotFeedbackMax = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_POT_FB_MAX );
            XmlAttribute motorPotFeedbackMaxValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            motorPotFeedbackMaxValue.Value = inker.AVTPLCRegister.SkewMotor.PotFeedbackMax.ToString();
            motorPotFeedbackMax.Attributes.Append( motorPotFeedbackMaxValue );
            motorPotFeedback.AppendChild( motorPotFeedbackMax );

            registerSkewMotor.AppendChild( motorPotFeedback );

            // Block Skew Motor when Press stopped
            XmlNode blockMotorWhenPressStopped = doc.CreateElement( XMLNodeDictionary.XT_REGISTER_SKEW_BLOCK_MOTOR_WHEN_PRESS_STOPPED );
            XmlAttribute blockMotorWhenPressStoppedValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
            blockMotorWhenPressStoppedValue.Value = inker.AVTPLCRegister.SkewMotor.BlockMotorWhenPressStopped.ToString().ToUpper();
            blockMotorWhenPressStopped.Attributes.Append( blockMotorWhenPressStoppedValue );
            registerSkewMotor.AppendChild( blockMotorWhenPressStopped );
        }

        /// <![CDATA[
        ///
        /// Author: Don Gerber
        /// History: 16-Oct-2018 dlg, (177481) Add XML data elements for Register control
        /// 
        /// ]]>
        /// <summary>
        /// Determines whether [is avtplc register configured].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is avtplc register configured]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsAVTPLCRegisterConfigured()
        {
            bool bRegisterConfigured = m_mcSiteConfigData.AVTPLCConfig.RegisterEnabled;

            return bRegisterConfigured;
        }
    }

    /// <![CDATA[
    ///
    /// Author: Mark C
    /// 
    /// History: 08-Dec-16, Mark C, WI83371: Created    
    ///         
    /// ]]>
    /// <summary>
    /// This class is responsible for storing the map data of SPU to Port index.
    /// </summary>
    public class SPUToPortMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPUToPortMap"/> class.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="portIndex">Index of the port.</param>
        public SPUToPortMap( string spuName, int portIndex )
        {
            m_spuName = spuName;
            m_portIndex = portIndex;
        }

        /// <summary>
        /// Gets or sets the name of the spu.
        /// </summary>
        /// <value>
        /// The name of the spu.
        /// </value>
        public string SPUName
        {
            set { m_spuName = value; }
            get { return m_spuName; }
        }

        /// <summary>
        /// Gets or sets the index of the port.
        /// </summary>
        /// <value>
        /// The index of the port.
        /// </value>
        public int PortIndex
        {
            set { m_portIndex = value; }
            get { return m_portIndex; }
        }

        #region members

        private string m_spuName = string.Empty;
        private int m_portIndex = 0;

        #endregion
    }

    public class UnitConverters
    {
        public const double fInchToMM = 25.4f;
        public const double fMMToInch = 1.0 / 25.4f;
        public const double fCmsToMM = 10.0f;
        public const double fMMToCms = 1.0 / 10.0f;
        public const double fCmsToInch = 1.0f / 2.54f;
        public const double fInchToCms = 2.54f;
    }
    public class FountainLimits
    {
        //MT 17103 - Min and max key width, FF max difference key count and ftn width to console
        public const float MIN_KEY_WIDTH = 1.0f;        //inches
        public const float MAX_KEY_WIDTH = 2.0f;        //inches
        public const int FF_MAX_DIFF_KEYS = 8;        //ftn +/- servos from zones
        public const float FF_MAX_DIFF_FTN_WIDTH = 10.0f; //inches, ftn +/- wide from console width 
    }
}