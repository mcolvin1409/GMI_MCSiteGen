using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

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
    public partial class frmMain : Form
    {
        string m_strUSERLoggedIn;
        string m_strFilename;
        MCSiteConfigData m_mcSiteConfigData, m_TempMCSiteConfig;
        MCPressInfo mcTempPressInfo;
        MCPressUnit pressUnit;
        int m_iInputType;
        bool m_bAdminLoggedIN;
        int m_iPressIdx;
        int m_iFountainWzrdState;
        int m_iInkersPerUnit;
        MCInker mcCurrentInker;
        bool m_bFountainConfigured;
        bool m_bNewFileOpen;
        bool m_bFileOpenMode;
        public frmMain()
        {
            InitializeComponent();
            m_strFilename = "Untitiled.xml";
            m_bAdminLoggedIN = false;
            m_mcSiteConfigData = new MCSiteConfigData();
            //m_TempMCSiteConfig = new MCSiteConfigData();
            m_iPressIdx = 0;
            m_iInputType = 0;
            m_iFountainWzrdState = (int)FountainWizardStates.Initial;
            m_iInkersPerUnit = 1;
            mcCurrentInker = null;
            m_bNewFileOpen = false;
            m_bFileOpenMode = false;
        }
        public MCPressInfo GetCurrentPress()
        {
            return m_mcSiteConfigData.GetPressAt(m_iPressIdx);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        private void LoggedIn()
        {
            gpLogin.Enabled = false;
            gpLogin.Visible = false;
            pnlSettings.Visible = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
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
                }
            }
            else
            {
                MessageBox.Show("Select a USER");
            }
        }

        private void btnNew_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnOpen_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseNew_Click(object sender, EventArgs e)
        {
            gpCreateNew.Visible = false;
            m_bNewFileOpen = false;
            m_bFileOpenMode = false;
        }

        private void btnNewConfig_Click(object sender, EventArgs e)
        {
            gpCreateNew.Visible = true;
            m_bNewFileOpen = true;
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
            
            m_mcSiteConfigData.SiteNumber=siteInfo.SiteNumber ;
            m_mcSiteConfigData.SiteName = siteInfo.SetSiteName;
            m_mcSiteConfigData.SystemConfig = siteInfo.ConfigVersion;
            
            if( m_mcSiteConfigData.PressCount() < siteInfo.PressCount )
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

        private void cboPresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPresses.SelectedIndex >= 0)
            {
                m_iPressIdx = cboPresses.SelectedIndex;
                gpPressConfigurations.Enabled = true;
                //btnPressSetup.Enabled = true;
                GenerateInkerList();
            }

        }
        private void GenerateInkerList()
        {
            /*
            MCPressInfo mcPress = GetCurrentPress();
            int iUnits = mcPress.TotalUnits;
            cboFountain.Items.Clear();
            for (int iUnit = 0; iUnit < iUnits; iUnit++)
            {
                MCPressUnit pressUnit = mcPress.GetUnitAt(iUnit);
                if (pressUnit == null)
                    continue;
                int iTotalInkers = pressUnit.GetTotalInkers;
                for (int iInker = 0; iInker < iTotalInkers; iInker++)
                {
                    MCInker mcInker = pressUnit.InkerAt(iInker);
                    if (mcInker == null)
                        continue;
                    cboFountain.Items.Add(mcInker.InkerName);
                }


            }*/
        }
      

        private void btnFountainInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnInkerInfo_Click(object sender, EventArgs e)
        {
            pnlFountainWizard.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_iFountainWzrdState = (int)FountainWizardStates.Initial;
            SwitchFountainWzrdStates();
            pnlFountainWizard.Visible = false;
            m_bFountainConfigured = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            m_iFountainWzrdState++;
            SwitchFountainWzrdStates();
        }
        void SwitchFountainWzrdStates()
        {
            btnCancel.Enabled = false;

            switch (m_iFountainWzrdState )
            {
                case (int)FountainWizardStates.Initial:
                    lstPressType.Visible = true;
                    groupBox3.Visible = true;
                    IndicateProgress.Value = 0;
                    IndicateProgress.Visible = false;
                    btnNext.Enabled = true;
                    gpInkerConfigurations.Visible = false;
                    break;
                case(int) FountainWizardStates.Third :
                    btnNext.Enabled = false;
                    btnCancel.Enabled = true;
                    GenerateInkerDetails();
                    gpInkerConfigurations.Visible = true;
                    cboInkerList.SelectedIndex = 0;
                    break;
                case (int)FountainWizardStates.Second :
                    // genrate Unitized web for now.
                    lstPressType.Visible = false;
                    groupBox3.Visible = false;
                    IndicateProgress.Visible = true;
                    IndicateProgress.BringToFront();
                    //terminate this wizard here.
                    if( m_bFileOpenMode == false)
                        GenerateUnitizedWebFountainConfigurations();
                    m_iFountainWzrdState++;
                    SwitchFountainWzrdStates();
                    break;
            }
        }
        public void GenerateInkerDetails()
        {
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = CurrentPress.TotalUnits;
            cboInkerList.Items.Clear();
            cboSPU.Items.Clear();
            int iTotalSPUs = GetCurrentPress ().GetTotalSPUS ();
            for(int iSPU = 0;iSPU < iTotalSPUs;iSPU++)
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
        }
        void GenerateUnitizedWebFountainConfigurations()
        {
            IndicateProgress.Visible = true;
            MCPressInfo CurrentPress = GetCurrentPress();
            if (CurrentPress == null)
                return;
            int iTotalUnits = int.Parse(txtFountainCount.Text);
            int iTotalKeysPerFountain = int.Parse(txtKeysPerfountain.Text);
            float fKeyWidth = float.Parse(txtKeyWidth.Text);
            CurrentPress.TotalUnits = iTotalUnits;
            CurrentPress.GenerateUnits();
            int iPercentComplete = 0;
            int iPortOnSPU = 0;
            for(int iUnit = 0;iUnit < iTotalUnits;iUnit ++)
            {
                MCPressUnit mcUnit = CurrentPress.GetUnitAt(iUnit);
                if (mcUnit == null)
                    continue;
                mcUnit.UnitName = "Unit" + (iUnit + 1).ToString();
                mcUnit.TotalInkers = m_iInkersPerUnit;
                MCInker mcInker = new MCInker();
                mcInker.TotalKeys = iTotalKeysPerFountain;
                //mcInker.InkerName = "Inker " + (iUnit+1).ToString();
                mcInker.InkerName = "Upper " + (iUnit + 1).ToString();
                mcInker.KeyWidth = fKeyWidth ;
                mcInker.InitInkerKey();
                mcInker.ClearServoBanks();
                int iTotalBanks = (iTotalKeysPerFountain > 44) ? 2 : 1;/*a bank can have max of 44 keys*/
                for (int iBank = 0; iBank < iTotalBanks; iBank++)
                {
                    int iTotalSPU = GetCurrentPress().GetTotalSPUS ();
                    int iSPU = iUnit / 6;/*one SPU can have 6 inkers*/
                    if (iUnit % 6 == 0 && iUnit> 0)
                        iPortOnSPU = 1;
                    else
                        iPortOnSPU++;
                    PressSPU spu = GetCurrentPress().SPU(iSPU);
                    if (spu == null)
                        continue;
                    ServoBanks servoBank = new ServoBanks();
                    servoBank.SPUName = spu.SPUName;
                    servoBank.PortOnSPU = iPortOnSPU;
                    servoBank.StartKey = (iBank == 0) ? 1 : iTotalKeysPerFountain;
                    servoBank.TotalKeys = iTotalKeysPerFountain;   
                    mcInker.AddServoBank(servoBank);
                }
                mcUnit.InitializeInker(mcInker);
                iPercentComplete += (int)(((float)iUnit / iTotalUnits) * 100.0);
                if (iPercentComplete > 100)
                    iPercentComplete = 100;
                IndicateProgress.Value = iPercentComplete;
                System.Threading.Thread.Sleep(100);
            }

            return;
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

        //=============================================================================
        ///<Function Name>XMLNodeDictionary </Function>
        /// <Auther> Hema Kumar              09/10/2008</Auther>
        /// <summary>
        /// Declaring the xml node constants
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// ======================================================================================
        public class XMLNodeDictionary
        {
            #region XML NODE NAME
            public const string COMMENT_MULTIPLE = "Can have more than one child";
            public const string COMMENT_CONTROLS = "motr=1, srv=2, both = 3, PLC = 4, PCU=5, GOSS MPU=6, PARLMOTOR=7";
            public const string COMMENT_WATER_CONTROL_INTERFACE = "Motr=1, Srv=2, Miyakoshi Water =3, PLC=4, PCU =5, GOSS MPU GATEWAY = 6,";
            public const string COMMENT_KEY_MEMBER_STARTS_FROM = "Key number starts from 1";

            public const string COMMENT_OTHERMEMBERS = "TO DO : Other Members";
            public const string COMMENT_KEY_WIDTH_IN_MM = "Key widths are in mm";
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

            public const string XT_MCPRESS_PRESS_SWEEP_CONTROL_INTERFACE = "PRESS_SWEEP_CONTROL_INTERFACE";
            public const string XT_MCPRESS_PRESS_CONTROL_TYPE = "CONTROL_TYPE";
            public const string XT_MCPRESS_PRESS_WATER_CONTROL_INTERFACE = "PRESS_WATER_CONTROL_INTERFACE";

            public const string XT_MCPRESS_PRESS_PLC_CONTROL = "PLC_CONTROL";
            public const string XT_MCPRESS_PRESS_NILP_3300 = "NILP_3300";
            public const string XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC = "WASH_CYCLE_TIME_IN_10TH_SEC";
            public const string XT_MCPRESS_PRESS_MECH_DELAY_IN_MS = "MECH_DELAY_IN_MS";
            public const string XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE = "TACH_PULSE_PER_EXECUTION_CYCLE";

            public const string XT_PRESS_TYPE = "PRESS_TYPE";
            public const string XT_PRESS_CONSOLE_ZONES = "PRESS_CONSOLE_ZONES";
            public const string XT_PRESS_IS_USED = "IS_USED";
            // MC PRESS TURN BAR
            public const string XT_PRESS_TURN_BARS = "PRESS_TURN_BARS";
            public const string XT_PRESS_TURN_BAR = "TURN_BAR";
            public const string XT_PRESS_TURN_BAR1 = "TurnBar1";
            public const string XT_PRESS_TURN_BAR2 = "TurnBar2";

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

            // UNIT INKER - INKER KEY
            public const string XT_UNIT_INKER_ATTRIB_WIDTH = "Width";

            // UNIT INKER - SERVO BANK
            public const string XT_MCINKER_SERVO_ADDRESS = "ServoAddress";
            public const string XT_MCINKER_SERVO_TOTALKEYS = "TotalKeysToCtrl";
            public const string XT_MCINKER_SERVO_START_KEY = "StartFromKey";

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
            public const string XT_CLIENTINTERFACE_CCLIENTBACKUPDRIVE = "CLIENT_BACKUP_DRIVE";


            public const string XT_CLIENTINTERFACE_DISPLAYOPTIONTOP = "DISPLAYOPTION_TOP";
            public const string XT_CLIENTINTERFACE_OPERATORONLEFT = "OperatorOnLeft";
            public const string XT_CLIENTINTERFACE_WEBDIRECTIONUP = "WebDirectionUp";
            public const string XT_CLIENTINTERFACE_DISPLAYKEYLEFTTORIGHT = "DisplayKeyLeftToRight";


            public const string XT_CLIENTINTERFACE_DISPLAYOPTIONBOT = "DISPLAYOPTION_BOTTOM";
            public const string XT_CLIENTINTERFACE_CURRENTLANGUAGE = "CurrentLanguage";
            public const string XT_CLIENTINTERFACE_FILTERNAMES = "FilterNames";
            public const string XT_CLIENTINTERFACE_FILTERNAME = "Filter";

            public const string XT_CLIENTINTERFACE_KEY = "KEY";
            public const string XT_CLIENTINTERFACE_CYN = "CYN";
            public const string XT_CLIENTINTERFACE_MAG = "MAG";
            public const string XT_CLIENTINTERFACE_YEL = "YEL";

            public const string XT_CLIENTINTERFACE_METRICDISPLAYS = "MetricDisplays";
            public const string XT_CLIENTINTERFACE_SPEEDDISPLAYFORMAT = "SpeedDisplayFormat";
            public const string XT_CLIENTINTERFACE_IMPCOUNTINGMETHOD = "ImpCountingMethod";

            //public const string XT_COLORASSIGNMENTS = "COLORASSIGNMENTS";
            //public const string XT_INK_TYPE = "INK_TYPE";
            #endregion
        }
        private void btnAddSPU_Click(object sender, EventArgs e)
        {
            
        }

        private void gpSPUConfig_Enter(object sender, EventArgs e)
        {

        }
        //=============================================================================
        ///<Function Name>createMcNSiteFile </Function>
        /// <Auther> Hema Kumar              09/10/2008</Auther>
        /// <summary>
        /// Creats the site file
        /// </summary>
        /// <param name=></param>
        /// <returns></returns>
        /// ======================================================================================
        private void createMcNSiteFile()
        {
            MCPressInfo mcPress = GetCurrentPress();
            if (mcPress == null)
                return;
            try
            {
                // creates the xml file
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(docNode);

                //create the MC System Config node element
                XmlNode MCSystemConfigNode = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_CONFIG);
                XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSYSTEMCONFIG_VERSION);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.SystemConfig); //"1.0";
                MCSystemConfigNode.Attributes.Append(productAttribute);
                doc.AppendChild(MCSystemConfigNode);

                //Creates the site name element
                XmlNode SiteNameNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_SITENAME);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = m_mcSiteConfigData.SiteName; //"Quebecor Newspaper";
                SiteNameNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(SiteNameNode);

                //Creates the site Number element
                XmlNode SiteNumNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_SITENUMBER);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.SiteNumber);//"1111";
                SiteNumNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(SiteNumNode);

               
                //Creates the MC Press element
                XmlNode McPressNode = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_PRESSES);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(m_mcSiteConfigData.PressCount());// "1";
                McPressNode.Attributes.Append(productAttribute);
                MCSystemConfigNode.AppendChild(McPressNode);


                // Comment

                XmlComment xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_MULTIPLE);
                McPressNode.AppendChild(xmlComment);


                //Creates the MC Press Name element
                XmlNode McPressNameNode = doc.CreateElement(XMLNodeDictionary.XT_SYSTEM_PRESS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                productAttribute.Value = mcPress.PressName;//XMLNodeDictionary.XT_SYSTEM_PRESSNAME;
                McPressNameNode.Attributes.Append(productAttribute);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TYPE);
                productAttribute.Value = Convert.ToString(mcPress.PressType);// "0";
                McPressNameNode.Attributes.Append(productAttribute);
                McPressNode.AppendChild(McPressNameNode);

                //Create Press width element
                XmlNode McPressWidthNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_WIDTH);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.PressWidth);//"137.7";
                McPressWidthNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(McPressWidthNode);

                //Create Press Folder element
                XmlNode McPressFolderNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_FOLDERS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(mcPress.FolderCount);//"1";
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
                    productAttribute.Value = Convert.ToString(mcPress.PressFolderName[byFolder]);//"FO1";
                    McPressFolderNameNode.Attributes.Append(productAttribute);
                    McPressFolderNode.AppendChild(McPressFolderNameNode);
                }

                //Create Press Units element
                XmlNode McPressUnitsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNITS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(mcPress.TotalUnits);//"12";
                McPressUnitsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(McPressUnitsNode);

                //Unit information
                for (int iUnit = 0; iUnit < mcPress.TotalUnits; iUnit++)
                {
                    MCPressUnit pressUnit =  mcPress.GetUnitAt(iUnit);
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
                    int iInkerount = pressUnit.TotalInkers;
                    productAttribute.Value = Convert.ToString(iInkerount);//"1";
                    InkerNode.Attributes.Append(productAttribute);
                    UnitNode.AppendChild(InkerNode);
                    //Comment

                    xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_MULTIPLE);
                    InkerNode.AppendChild(xmlComment);

                    // Inker Name
                    for (int iInker = 0; iInker < iInkerount; iInker++)
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
                            //productAttribute.Value = Convert.ToString(mcInker.FirstKeyOperatorSide);//"TRUE";
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;//"TRUE";
                        }
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                        Key1OperatorSideNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(Key1OperatorSideNode);

                        // Upper Lower Inker Node 
                        XmlNode UpperLowerInkerNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SIDE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = "Upper";
                        UpperLowerInkerNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(UpperLowerInkerNode);

                        // Servo Turns
                        XmlNode ServoTurnsNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.ServoTurns); // "0.7";
                        ServoTurnsNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(ServoTurnsNode);

                        // INKER KEYS
                        XmlNode InkerKeysNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_KEYS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                        int iTotalKeys = mcInker.TotalKeys;
                        productAttribute.Value = Convert.ToString(iTotalKeys);//"16";
                        InkerKeysNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(InkerKeysNode);

                        //Comment

                        xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_KEY_WIDTH_IN_MM);
                        InkerKeysNode.AppendChild(xmlComment);

                        for (int iInkerKey = 0; iInkerKey < iTotalKeys; iInkerKey++)   // 23
                        {
                            // INKER KEY width
                            XmlNode InkerKeyNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_KEY);

                            productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_UNIT_INKER_ATTRIB_WIDTH);
                            productAttribute.Value = Convert.ToString(mcInker.EachKeyWidth); //"27.725";
                            InkerKeyNode.Attributes.Append(productAttribute);
                            InkerKeysNode.AppendChild(InkerKeyNode);
                        }

                        // min value
                        XmlNode MinValueNode = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MINVALUE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.MinConsoleVal);//"0";
                        MinValueNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(MinValueNode);

                        // Max Value 
                        XmlNode MaxValueNode = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.MaxConsoleVal); // "99";
                        MaxValueNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(MaxValueNode);

                        // Servo Banks 
                        XmlNode ServoBanksNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                        productAttribute.Value = Convert.ToString(mcInker.TotalBanks); // "1";
                        ServoBanksNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(ServoBanksNode);

                        // Servo Bank 
                        XmlNode ServoBankNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANK);
                        ServoBanksNode.AppendChild(ServoBankNode);

                        // Servo address
                        XmlNode ServoAddressNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME);
                        ServoBanks ServoBank = (ServoBanks)mcInker.ServoBanks[iInker];
                        productAttribute.Value = ServoBank.SPUName; // "SPU1";
                        ServoAddressNode.Attributes.Append(productAttribute);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT);
                        productAttribute.Value = Convert.ToString(ServoBank.PortOnSPU); //"1";
                        ServoAddressNode.Attributes.Append(productAttribute);
                        ServoBankNode.AppendChild(ServoAddressNode);

                        // Total Keys to Control
                        XmlNode ServoTotalKeysNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(ServoBank.TotalKeys); // "16";
                        ServoTotalKeysNode.Attributes.Append(productAttribute);
                        ServoBankNode.AppendChild(ServoTotalKeysNode);

                        // Start from key
                        XmlNode StartFromKeyNode = doc.CreateElement(XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(ServoBank.StartKey); // "1";
                        StartFromKeyNode.Attributes.Append(productAttribute);
                        ServoBankNode.AppendChild(StartFromKeyNode);

                            // Comment

                            xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_KEY_MEMBER_STARTS_FROM);
                            StartFromKeyNode.AppendChild(xmlComment);

                        // Inverted
                        XmlNode InvertedNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        if (mcInker.Inverted)
                        {
                            //productAttribute.Value = Convert.ToString(mcInker.Inverted);//"FALSE";
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;//"FALSE";
                        }
                        else
                            productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;

                        InvertedNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(InvertedNode);

                        // Linear Table Index
                        XmlNode LinearTableIndexNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        //productAttribute.Value =  Convert.ToString(mcInker.LTIndex);//"1";
                        productAttribute.Value = "1";
                        LinearTableIndexNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(LinearTableIndexNode);

                        // Linear Table Size
                        XmlNode LinearTableSizeNode = doc.CreateElement(XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE);

                        productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                        productAttribute.Value = Convert.ToString(mcInker.LTSize); // "200";
                        LinearTableSizeNode.Attributes.Append(productAttribute);
                        InkerNameNode.AppendChild(LinearTableSizeNode);
                    }
                }

                //int iNumUnitGroups = mcPress.UnitGroups.Count;
                int iNumUnitGroups = 1;
                
                //Create Press Unit Groups
                XmlNode PressUnitGroupsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_UNITGROUPS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                //productAttribute.Value = Convert.ToString(iNumUnitGroups);//"1";
                productAttribute.Value = "1";
                PressUnitGroupsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PressUnitGroupsNode);
                for (int iUnitGroup = 0; iUnitGroup < iNumUnitGroups; iUnitGroup++)
                {
                    //UnitGroupMembers unitGroups = mcPress.GetPressUnitGroupAt(iUnitGroup);
                    //if (unitGroups == null)
                    //    continue;
                
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
                    productAttribute.Value = Convert.ToString(iNumUnitGroupMem);//"6";
                    //productAttribute.Value = "6";
                    UnitGroup_MemsNode.Attributes.Append(productAttribute);
                    UnitGroupNode.AppendChild(UnitGroup_MemsNode);

                    for (byte byUnitGroupMember = 1; byUnitGroupMember <= iNumUnitGroupMem; byUnitGroupMember++)
                    {
                        //string strUnitMemName = unitGroups.GetUnitMemNameAt(byUnitGroupMember);
                        //if (strUnitMemName == "")
                        //    continue;
                        //Create UnitGroupMem "Unit1"
                        XmlNode UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                        //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                        productAttribute = doc.CreateAttribute("Name");
                        //productAttribute.Value = strUnitMemName; // "Unit1";
                        productAttribute.Value = "Unit" + byUnitGroupMember;
                        UnitGroupMemNode.Attributes.Append(productAttribute);
                        UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);
                    }

                    //Create UnitGroupMem "Unit2"
                    //UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                    //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = "Unit2";
                    //UnitGroupMemNode.Attributes.Append(productAttribute);
                    //UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);

                    ////Create UnitGroupMem "Unit3"
                    //UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                    //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = "Unit3";
                    //UnitGroupMemNode.Attributes.Append(productAttribute);
                    //UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);

                    ////Create UnitGroupMem "Unit4"
                    //UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                    //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = "Unit4";
                    //UnitGroupMemNode.Attributes.Append(productAttribute);
                    //UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);

                    ////Create UnitGroupMem "Unit5"
                    //UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                    //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = "Unit5";
                    //UnitGroupMemNode.Attributes.Append(productAttribute);
                    //UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);

                    ////Create UnitGroupMem "Unit6"

                    //UnitGroupMemNode = doc.CreateElement(XMLNodeDictionary.XT_UNITGROUP_UNITGROUPMEM);

                    //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = "Unit6";
                    //UnitGroupMemNode.Attributes.Append(productAttribute);
                    //UnitGroup_MemsNode.AppendChild(UnitGroupMemNode);
                }

                //Create Press_Reelstands
                int iReelstandsCount = mcPress.GetNumReelStands();
                XmlNode Press_ReelstandsNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_REELSTANDS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                //productAttribute.Value = Convert.ToString(iReelstandsCount); // "1";
                productAttribute.Value = "1";
                Press_ReelstandsNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(Press_ReelstandsNode);

                for (int iReelstand = 0; iReelstand < 1 /*iReelstandsCount */; iReelstand++)
                {
                    ReelStands ReelStand = (ReelStands)mcPress.GetPressReelStandAt(iReelstand);
                    //if (ReelStand == null)
                    //    continue;
                    //string strReelstandName = ReelStand.Name;
                    //Create PressReelstand
                    XmlNode PressReelstandNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_REELSTAND);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    //productAttribute.Value = strReelstandName; // "RSO1";
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
                    PressSPU  Spu = (PressSPU)mcPress.GetSPUAt(bySpu);
                    if (Spu == null)
                        continue;
                    XmlNode SpuNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_SPU);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = Spu.SPUName; // "SPU1";
                    SpuNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT);
                    productAttribute.Value = Spu.SPUCommPort; // "COM5";
                    SpuNode.Attributes.Append(productAttribute);
                    Press_SpusNode.AppendChild(SpuNode);
                }

                //Create SPU 2
                //SpuNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_SPU);

                //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                //productAttribute.Value = "SPU2";
                //SpuNode.Attributes.Append(productAttribute);

                //productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT);
                //productAttribute.Value = "COM6";
                //SpuNode.Attributes.Append(productAttribute);
                //Press_SpusNode.AppendChild(SpuNode);
                
                //Create Press_ClientInterface
               // PressClientInterface PressClientInterfc = (PressClientInterface)mcPress.PressClientInterface();
                XmlNode Press_ClientInterfaceNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CLIENTINTERFACE);
                McPressNameNode.AppendChild(Press_ClientInterfaceNode);

                    //Create Client_Passwords
                    XmlNode Client_PasswordsNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLIENTPASSWORDS);
                    Press_ClientInterfaceNode.AppendChild(Client_PasswordsNode);

                    //Create Level1
                    XmlNode Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL1);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = "NA";
                    Level1Node.Attributes.Append(productAttribute);
                    Client_PasswordsNode.AppendChild(Level1Node);

                    //Create Level2
                    Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL2);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = "NA";
                    Level1Node.Attributes.Append(productAttribute);
                    Client_PasswordsNode.AppendChild(Level1Node);

                    //Create Level3
                    Level1Node = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLEVEL3);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = "        ";
                    Level1Node.Attributes.Append(productAttribute);
                    Client_PasswordsNode.AppendChild(Level1Node);

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

                    //Create AdvUser
                    XmlNode AdvUserNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CADVUSER);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = "";
                    AdvUserNode.Attributes.Append(productAttribute);
                    Client_PasswordsNode.AppendChild(AdvUserNode);

                    //Create Data_File_Pathes
                    XmlNode Data_File_PathesNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLIENTDATAFILEPATHES);
                    Press_ClientInterfaceNode.AppendChild(Data_File_PathesNode);

                //Create Remote_Data_Storage
                XmlNode Remote_Data_StorageNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CREMOTEDATASTORAGE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"C:\GMI";
                Remote_Data_StorageNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Remote_Data_StorageNode);

                //Create Local_Data_Storage
                XmlNode Local_Data_StorageNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CLOCALDATASTORAGE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"C:\GMI\MC3\JOB_DATA";
                Local_Data_StorageNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Local_Data_StorageNode);

                //Create Job_Storage_Share_Name
                XmlNode Job_Storage_Share_NameNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_CJOBSTORAGESHARENAME);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = @"MC3_JOB_DATA";
                Job_Storage_Share_NameNode.Attributes.Append(productAttribute);
                Data_File_PathesNode.AppendChild(Job_Storage_Share_NameNode);

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
                productAttribute.Value = mcPress.PressClientInterface.CurrentLanguage; // "ENG";
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
                productAttribute.Value = Convert.ToString(mcPress.PressClientInterface.SpeedDispFormat); // "0";
                SpeedDisplayFormatNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(SpeedDisplayFormatNode);

                //Create ImpCountingMethod
                XmlNode ImpCountingMethodNode = doc.CreateElement(XMLNodeDictionary.XT_CLIENTINTERFACE_IMPCOUNTINGMETHOD);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.PressClientInterface.ImpCountMethod); // "";
                ImpCountingMethodNode.Attributes.Append(productAttribute);
                Press_ClientInterfaceNode.AppendChild(ImpCountingMethodNode);

                //Create MCPress_ClientInterface
                XmlNode MCPress_ClientInterface = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_CLIENTINTERFACE);
                McPressNameNode.AppendChild(MCPress_ClientInterface);

                //Create BladeStiffness
                XmlNode BladeStiffnessNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_BLADE_STIFFNESS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.BladeStiffNess); //"0";
                BladeStiffnessNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(BladeStiffnessNode);

                //Create MaxNeighbourKeyDelta
                XmlNode MaxNeighbourKeyDeltaNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_MAX_NEIGH_KEY_DELTA);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.MaxKeyDelta);// "30";
                MaxNeighbourKeyDeltaNode.Attributes.Append(productAttribute);
                MCPress_ClientInterface.AppendChild(MaxNeighbourKeyDeltaNode);

                //Create McClient_Features
                XmlNode McClient_FeaturesNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENTINTERFACE_CLIENTFEATURES);
                MCPress_ClientInterface.AppendChild(McClient_FeaturesNode);

                //Create Cip3Presetting
                XmlNode Cip3PresettingNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_CIP3_PRESETTING);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.CIP3Enabled);//"TRUE";
                if (mcPress.MCClientInterface.CIP3Enabled)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                Cip3PresettingNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Cip3PresettingNode);

                //Create NonLinear
                XmlNode NonLinearNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_NON_LINEAR);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.NonLinear);//"1";
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
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.MeterOffset); // "TRUE";
                if (mcPress.MCClientInterface.MeterOffset)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                MeterOffsetNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(MeterOffsetNode);

                //Create Sweep_Control
                XmlNode Sweep_ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_SWEEP_CONTROL);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.SweepControl); // "TRUE";
                if (mcPress.MCClientInterface.SweepControl)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                Sweep_ControlNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Sweep_ControlNode);

                //Create Water_Control
                XmlNode Water_ControlNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_FEATURE_WATER_CONTROL);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.WaterControl); // "TRUE";
                if (mcPress.MCClientInterface.WaterControl)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                Water_ControlNode.Attributes.Append(productAttribute);
                McClient_FeaturesNode.AppendChild(Water_ControlNode);

                    //Create LinearTable
                    XmlNode LinearTableNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_LINEAR_TABLE);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.PATH);
                    productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.Linear); // "0";
                    LinearTableNode.Attributes.Append(productAttribute);
                    MCPress_ClientInterface.AppendChild(LinearTableNode);

                    //Create NonLinearTable
                    XmlNode NonLinearTableNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_NON_LINEAR_TABLE);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.PATH);
                    productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.NonLinear); // "0";
                    NonLinearTableNode.Attributes.Append(productAttribute);
                    MCPress_ClientInterface.AppendChild(NonLinearTableNode);

                    //Create DefaultOffset
                    XmlNode DefaultOffsetNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_DEFAULT_OFFSET);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.DefaultOffset); // "0";
                    DefaultOffsetNode.Attributes.Append(productAttribute);
                    MCPress_ClientInterface.AppendChild(DefaultOffsetNode);

                    //Create ServoPulsesZoneAtZero
                    XmlNode ServoPulsesZoneAtZeroNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_SERVO_PULSES_ZONE_AT_ZERO);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.ServoPulsesZoneAtZero); // "0";
                    ServoPulsesZoneAtZeroNode.Attributes.Append(productAttribute);
                    MCPress_ClientInterface.AppendChild(ServoPulsesZoneAtZeroNode);

                    //Create PressZeroBackOffInPulses
                    XmlNode PressZeroBackOffInPulsesNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_ZERO_BACKOFF);
                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                    productAttribute.Value = Convert.ToString(mcPress.MCClientInterface.PressZeroBackoffInPulses); // "0";
                    PressZeroBackOffInPulsesNode.Attributes.Append(productAttribute);
                    MCPress_ClientInterface.AppendChild(PressZeroBackOffInPulsesNode);

                //Create Press_Console_Zones_NumOfZones
                XmlNode Press_Console_Zones_NumOfZonesNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_CONSOLE_ZONES);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_NUM_ZONES);
                //productAttribute.Value = Convert.ToString(mcPress.PressConsoleZones.NumberOfZones); // "16";
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.NumberOfZones); // "16";
                Press_Console_Zones_NumOfZonesNode.Attributes.Append(productAttribute);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_OCU_ZONE_WIDTH);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.ZoneWidth); // "2.7725";
                Press_Console_Zones_NumOfZonesNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(Press_Console_Zones_NumOfZonesNode);

                //Create MinValue Node
                XmlNode MinValueNode1 = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MINVALUE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.MinValue); // "0";
                MinValueNode1.Attributes.Append(productAttribute);
                Press_Console_Zones_NumOfZonesNode.AppendChild(MinValueNode1);

                //Create MaxValue Node
                XmlNode MaxValueNode1 = doc.CreateElement(XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.OCUInterface.MaxValue); // "100";
                MaxValueNode1.Attributes.Append(productAttribute);
                Press_Console_Zones_NumOfZonesNode.AppendChild(MaxValueNode1);

                //Create Press_Nfstable Node
                XmlNode Press_NfstableNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE);
                McPressNameNode.AppendChild(Press_NfstableNode);

                //Create BreakPoint Node
                XmlNode BreakPointNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE_BREAKPOINT);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                //productAttribute.Value = Convert.ToString(mcPress.PressNFSTable.BreakPoint); // "50";
                productAttribute.Value = Convert.ToString(mcPress.NFSTable.BreakPoint);
                BreakPointNode.Attributes.Append(productAttribute);
                Press_NfstableNode.AppendChild(BreakPointNode);

                //Create MaxKeyTurnsAtConsoleZone99 Node
                XmlNode MaxKeyTurnsAtConsoleZone99Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_NFSTABLE_GAIN);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.NFSTable.MaxKeyTurnsAtConsole99); // "200";
                MaxKeyTurnsAtConsoleZone99Node.Attributes.Append(productAttribute);
                Press_NfstableNode.AppendChild(MaxKeyTurnsAtConsoleZone99Node);


                //Create PRESS_SWEEP_CONTROL_INTERFACE Node
                XmlNode PRESS_SWEEP_CONTROL_INTERFACENode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_SWEEP_CONTROL_INTERFACE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_CONTROL_TYPE);
                //productAttribute.Value = Convert.ToString(mcPress.SweepControlInterface.ControlType); // "4";
                productAttribute.Value = Convert.ToString(mcPress.SweepInterface.ControlType);
                PRESS_SWEEP_CONTROL_INTERFACENode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_SWEEP_CONTROL_INTERFACENode);

                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_CONTROLS);
                PRESS_SWEEP_CONTROL_INTERFACENode.AppendChild(xmlComment);


                //Create PLC_CONTROL Node
                XmlNode PLC_CONTROLNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_PLC_CONTROL);
                PRESS_SWEEP_CONTROL_INTERFACENode.AppendChild(PLC_CONTROLNode);

                //Create NILP_3300 Node
                XmlNode NILP_3300Node = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_NILP_3300);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_IS_USED);
               // productAttribute.Value = Convert.ToString(mcPress.SweepControlInterface.IsNILPUsed); // "TRUE";
                if (mcPress.SweepInterface.IsNILPUsed)
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE;
                else
                    productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                NILP_3300Node.Attributes.Append(productAttribute);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT);
                productAttribute.Value = mcPress.SweepInterface.NILPCOMMPort; // "COM8";
                NILP_3300Node.Attributes.Append(productAttribute);
                PLC_CONTROLNode.AppendChild(NILP_3300Node);

                XmlNode WASH_CYCLE_TIMENode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_WASH_CYCLE_TIME_IN_10TH_SEC);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepInterface.NILPWashCycle);// "10";
                WASH_CYCLE_TIMENode.Attributes.Append(productAttribute);
                NILP_3300Node.AppendChild(WASH_CYCLE_TIMENode);

                // Create Mech_Delay Node
                XmlNode Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_MECH_DELAY_IN_MS);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepInterface.NILPMechDelayInMS); // "70";
                Mech_DelayNode.Attributes.Append(productAttribute);
                NILP_3300Node.AppendChild(Mech_DelayNode);

                // Create Mech_Delay Node
                Mech_DelayNode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_TACH_PULSE_PER_EXECUTION_CYCLE);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.VALUE);
                productAttribute.Value = Convert.ToString(mcPress.SweepInterface.NilpTachPulsePerExec); // "3";
                Mech_DelayNode.Attributes.Append(productAttribute);
                NILP_3300Node.AppendChild(Mech_DelayNode);


                //Create PRESS_Water_CONTROL_INTERFACE
                XmlNode PRESS_WATER_CONTROL_INTERFACENode = doc.CreateElement(XMLNodeDictionary.XT_MCPRESS_PRESS_WATER_CONTROL_INTERFACE);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_MCPRESS_PRESS_CONTROL_TYPE);
                //productAttribute.Value = Convert.ToString(mcPress.WaterControlInterface.ControlType); // "4";
                productAttribute.Value = "4";
                PRESS_WATER_CONTROL_INTERFACENode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_WATER_CONTROL_INTERFACENode);
                //Comment

                xmlComment = doc.CreateComment(XMLNodeDictionary.COMMENT_WATER_CONTROL_INTERFACE);
                PRESS_WATER_CONTROL_INTERFACENode.AppendChild(xmlComment);

                //Create PRESS_TURN_BARS
                int iTurnBarCount = mcPress.TotalTurnBars;
                XmlNode PRESS_TURN_BARSNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TURN_BARS);

                productAttribute = doc.CreateAttribute(XMLNodeDictionary.ARRAY_SIZE);
                productAttribute.Value = Convert.ToString(iTurnBarCount); // "2";
                PRESS_TURN_BARSNode.Attributes.Append(productAttribute);
                McPressNameNode.AppendChild(PRESS_TURN_BARSNode);

                for (int iTurnBar = 0; iTurnBar < iTurnBarCount; iTurnBar++)
                {

                    TurnBars TurnBar = (TurnBars)mcPress.TurnBar(iTurnBar);
                    if (TurnBar == null)
                        continue;
                    XmlNode PRESS_TURN_BARNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TURN_BAR);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                    productAttribute.Value = TurnBar.Name; // "TurnBar1";
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT);
                    productAttribute.Value = TurnBar.Predecessor; // "Unit4";
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                    productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_ACTIVATED);
                    if (TurnBar.Checked)
                    {
                        //productAttribute.Value = Convert.ToString(TurnBar.Checked); // "FALSE";
                        productAttribute.Value = XMLNodeDictionary.XT_PRESS_TRUE; // "TRUE";
                    }
                    else
                        productAttribute.Value = productAttribute.Value = XMLNodeDictionary.XT_PRESS_FALSE;
                    PRESS_TURN_BARNode.Attributes.Append(productAttribute);
                    PRESS_TURN_BARSNode.AppendChild(PRESS_TURN_BARNode);
                }

                

                //PRESS_TURN_BARNode = doc.CreateElement(XMLNodeDictionary.XT_PRESS_TURN_BAR);

                //productAttribute = doc.CreateAttribute(XMLNodeDictionary.NAME);
                //productAttribute.Value = "TurnBar2";
                //PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                //productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_TURN_BAR_AFTER_WHICH_UNIT);
                //productAttribute.Value = "Unit8";
                //PRESS_TURN_BARNode.Attributes.Append(productAttribute);

                //productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_PRESS_ACTIVATED);
                //productAttribute.Value = "TRUE";
                //PRESS_TURN_BARNode.Attributes.Append(productAttribute);
                //PRESS_TURN_BARSNode.AppendChild(PRESS_TURN_BARNode);


                //save the file in C:\GMI\MC3\SYSTEM
                doc.Save(@"C:\GMI\MC3\SYSTEM\MC9999.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
            this.cboPresses.Items[this.cboPresses.SelectedIndex] = GetCurrentPress().PressName; ;
        }

        private void sPUInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // GenerateSPUDetails();
            frmSPUConfiguration frmSPUConfig = new frmSPUConfiguration();
            frmSPUConfig.CurrentPress = GetCurrentPress();
            frmSPUConfig.StartPosition = FormStartPosition.CenterParent;
            frmSPUConfig.ShowDialog();
            frmSPUConfig.Dispose();
        }

        private void fountainConfigurationWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bFountainConfigured)
            {
                if (MessageBox.Show("Fountain Configuration is already done, do you want to start over?","", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_bFountainConfigured = false;
                }
                else
                    return;

            }
            m_bFountainConfigured = false;
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                MessageBox.Show("Please Configure SPUs before starting the Fountain wizard");
                return;
            }
            if (m_bFileOpenMode == false)
            {
                GenerateFountainCount();
            }
            btnInkerInfo_Click(sender, e);
        }
        private void GenerateFountainCount()
        {
            int iTotalFountains = (6 * GetCurrentPress().GetTotalSPUS());
            txtFountainCount.Text = iTotalFountains.ToString();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strMessage = "";
            if (GetCurrentPress().GetTotalSPUS() == 0)
            {
                strMessage = "\n SPU configuration";
            }
            if (GetCurrentPress().TotalUnits == 0)
            {
                strMessage += "\n Fountain(s)/ Unit(s)";
            }
            if (strMessage != "")
            {
                string strMsg = "Cannot Save!, Missing Information for: \n";
                strMsg += strMessage ;
                MessageBox.Show(strMsg);
                return;
            }
            m_bNewFileOpen = false;            
            createMcNSiteFile();
        }

        private void rButtonTurnbars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTurnBar_CheckedChanged(object sender, EventArgs e)
        {
            GetCurrentPress().PressType = (1 - GetCurrentPress().PressType);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: You Will Loose any changes made, if you Go Back! Sure?","",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            btnNext.Enabled = true;
            // go two steps back.
            m_iFountainWzrdState--;
            m_iFountainWzrdState--;
            if (m_iFountainWzrdState == 0)
                btnBack.Enabled = false;
            SwitchFountainWzrdStates();
        }

        private void txtFountainCount_TextChanged(object sender, EventArgs e)
        {
            if (txtFountainCount.Text == "")
                return;
            int iTotalFountains = int.Parse(txtFountainCount.Text);
            if (((float)iTotalFountains / 6) > GetCurrentPress().GetTotalSPUS())
            {
                MessageBox.Show("Cannot add that many Fountains, Total Fountains should be <= 6 * SPUs");
                txtFountainCount.Text = "";
                return;
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

        private void cboInkerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pdateInkerData();
            SetCurrentInker();
            UpdateDataToUI();
        }
        public void UpdateDataToUI()
        {
            ServoBanks servoBank = mcCurrentInker.GetServoBankAt(0);
            if (servoBank != null)
            {
                cboSPU.Text = servoBank.SPUName; ;
                txtPortOnInker.Text = servoBank.PortOnSPU.ToString();
                txtTotalKeysToCtrl.Text = servoBank.TotalKeys.ToString();
                txtFirstKey.Text = servoBank.StartKey.ToString ();
            }
            // tood, add servo bank 2.
            chkInverted.Checked = mcCurrentInker.Inverted;
            chkKeyOpSide.Checked = mcCurrentInker.KeyOneOPSide;
            chkUpperInker.Checked = mcCurrentInker.UpperOrLower;
            txtServoTurns.Text = mcCurrentInker.ServoTurns;
            txtMinConsole.Text = mcCurrentInker.MinConsole;
            txtMaxConsole.Text = mcCurrentInker.MaxConsole;
            txtLintableSize.Text = mcCurrentInker.LinTableSize;
        }
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
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            servoBank.PortOnSPU =  int.Parse (txtPortOnInker.Text);
        }

        private void txtTotalKeysToCtrl_TextChanged(object sender, EventArgs e)
        {
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            servoBank.TotalKeys = int.Parse(txtTotalKeysToCtrl.Text);
        }

        private void txtFirstKey_TextChanged(object sender, EventArgs e)
        {
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
            if (servoBank == null)
                return;
            servoBank.StartKey = int.Parse(txtFirstKey.Text);
        }

        private void chkUpperInker_CheckedChanged(object sender, EventArgs e)
        {
            mcCurrentInker.UpperOrLower = !mcCurrentInker.UpperOrLower;
        }

        private void chkKeyOpSide_CheckedChanged(object sender, EventArgs e)
        {
            mcCurrentInker.KeyOneOPSide = !mcCurrentInker.KeyOneOPSide;
        }

        private void chkInverted_CheckedChanged(object sender, EventArgs e)
        {
            mcCurrentInker.Inverted = !mcCurrentInker.Inverted;
        }

        private void txtServoTurns_TextChanged(object sender, EventArgs e)
        {
            if (txtServoTurns.Text == "")
                return;
            float fSTurns = float.Parse (txtServoTurns.Text);
            if (fSTurns < 0.25f || fSTurns > 1.25)
            {
                MessageBox.Show("Not Supported");
                txtServoTurns.Text = "";
                return;
            }
            mcCurrentInker.ServoTurns = txtServoTurns.Text;
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
            if (iMin < 0 || iMin > 99)
            {
                MessageBox.Show("Not Supported");
                txtMaxConsole.Text = "";
                return;
            }
            mcCurrentInker.MaxConsole = txtMaxConsole.Text;
        }

        private void txtLintableSize_TextChanged(object sender, EventArgs e)
        {
            if (txtLintableSize.Text == "")
                return;
            int iMin = int.Parse(txtLintableSize.Text);
            if (iMin < 0  )
            {
                MessageBox.Show("Not Supported, should be either 150/200/250");
                txtLintableSize.Text = "";
                return;
            }

            mcCurrentInker.LinTableSize = txtLintableSize.Text;
        }

        private void ReadSiteXMLFile()
        {
            try
            {
                string sStartupPath = Application.StartupPath;
                //clsSValidator objclsSValidator =
                //      new clsSValidator(sStartupPath + @"..\..\..\XMLFile1.xml",
                //      sStartupPath + @"..\..\..\XMLFile1.xsd");
                //if (objclsSValidator.ValidateXMLFile()) return;
                XmlTextReader objXmlTextReader =
                    //  new XmlTextReader(sStartupPath + @"..\..\..\XMLFile1.xml"); //@"C:\GMI\MC3\SYSTEM\MC9999.xml"
                    new XmlTextReader(@"C:\GMI\MC3\SYSTEM\MC9999.xml");
                string sName = "";
                m_TempMCSiteConfig = new MCSiteConfigData();
                mcTempPressInfo = new MCPressInfo();
                m_TempMCSiteConfig.RemovePress();
                MCPressUnit pressUnit = new MCPressUnit();
                int iSPU = 0;
                string strValue = "";
                ServoBanks servoBank = GetServoBankforCurrentInker(0);


                //  MCPressInfo mcPress = GetCurrentPress();
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:

                            //
                            Hashtable attributes = new Hashtable();
                            // string strURI = objXmlTextReader.NamespaceURI;
                            string strName = objXmlTextReader.Name;
                            for (int i = 0; i < objXmlTextReader.AttributeCount; i++)
                            {
                                objXmlTextReader.MoveToAttribute(i);
                                attributes.Add(objXmlTextReader.Name, objXmlTextReader.Value);
                            }
                            IDictionaryEnumerator _enumerator = attributes.GetEnumerator();
                           // LoadElement(strName, attributes);
                            switch (strName)
                            {

                                case XMLNodeDictionary.XT_SYSTEM_SITENAME:

                                    m_TempMCSiteConfig.SiteName = _enumerator.Value.ToString();
                                    break;

                                case XMLNodeDictionary.XT_SYSTEM_SITENUMBER:

                                    strValue = _enumerator.Value + "\n";
                                    m_TempMCSiteConfig.SiteNumber = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCSYSTEM_CONFIG:

                                    strValue = _enumerator.Value + "\n";
                                    m_TempMCSiteConfig.SystemConfig = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCSYSTEM_PRESSES:

                                    //strValue = _enumerator.Value + "\n";
                                    //m_TempMCSiteConfig.PressCount =
                                    break;

                                case XMLNodeDictionary.XT_SYSTEM_PRESS:

                                    if ((string)_enumerator.Key == XMLNodeDictionary.NAME)
                                        mcTempPressInfo.PressName = _enumerator.Value.ToString();
                                    if ((string)_enumerator.Key == XMLNodeDictionary.XT_PRESS_TYPE)
                                    {
                                        strValue = _enumerator.Value + "\n";
                                        mcTempPressInfo.PressType = Convert.ToInt16(strValue);
                                    }

                                    break;

                                case XMLNodeDictionary.XT_PRESS_WIDTH:

                                    strValue = _enumerator.Value + "\n";
                                    mcTempPressInfo.PressWidth = (float)Convert.ToDouble(strValue);
                                    break;

                                case XMLNodeDictionary.XT_PRESS_FOLDER:

                                    strValue = _enumerator.Value.ToString();
                                    break;

                                case XMLNodeDictionary.XT_PRESS_UNITS:

                                    strValue = _enumerator.Value + "\n";
                                    mcTempPressInfo.TotalUnits = Convert.ToInt16(strValue);
                                    mcTempPressInfo.GenerateUnits();
                                    break;

                                case XMLNodeDictionary.XT_PRESS_UNIT:

                                    strValue = _enumerator.Value.ToString();
                                    pressUnit = mcTempPressInfo.GetUnitByName(strValue);

                                    break;

                                case XMLNodeDictionary.XT_INKERS:

                                    strValue = _enumerator.Value + "\n";
                                    pressUnit.TotalInkers = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_INKER:

                                    strValue = _enumerator.Value.ToString();
                                    mcCurrentInker = ((MCInker)(pressUnit.GetInkerAt(0)));//supports only unitized inker for now
                                    mcCurrentInker.InkerName = (strValue);
                                    break;

                                case XMLNodeDictionary.XT_UNIT_INKER_KEY1OPERATORSIDE:
                                    strValue = _enumerator.Value + "\n";
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcCurrentInker.FirstKeyOperatorSide = true;
                                    else
                                        mcCurrentInker.FirstKeyOperatorSide = false;
                                    //
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_SIDE:
                                    strValue = _enumerator.Value + "\n";
                                    //pressUnit. = Convert.ToInt16(strValue);
                                    // To do
                                    //
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS:
                                    strValue = _enumerator.Value.ToString();
                                    mcCurrentInker.ServoTurns = strValue;
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_KEYS:
                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.TotalKeys = Convert.ToInt16(strValue);
                                    //
                                    break;

                                case XMLNodeDictionary.XT_UNIT_INKER_ATTRIB_WIDTH:
                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.KeyWidth = Convert.ToInt16(strValue);
                                    //
                                    break;

                                case XMLNodeDictionary.XT_UNIT_INKER_MINVALUE:
                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.MinConsoleVal = Convert.ToInt16(strValue);
                                    //
                                    break;

                                case XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE:
                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.MaxConsoleVal = Convert.ToInt16(strValue);
                                    //
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS:
                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.TotalBanks = Convert.ToInt16(strValue);
                                    //
                                    break;

                                case XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS:

                                    //if (servoBank == null)
                                    //    continue;
                                    //ServoBanks servoBank = GetServoBankforCurrentInker(0);
                                    if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME)
                                    {
                                        strValue = _enumerator.Value.ToString();
                                        servoBank.SPUName = (strValue);
                                    }

                                    else if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT)
                                    {
                                        strValue = _enumerator.Value + "\n";
                                        servoBank.PortOnSPU = Convert.ToInt16(strValue);
                                    }

                                    break;

                                case XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS:

                                    strValue = _enumerator.Value + "\n";
                                    servoBank.TotalKeys = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY:

                                    strValue = _enumerator.Value + "\n";
                                    servoBank.StartKey = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED:
                                    strValue = _enumerator.Value + "\n";
                                    if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                                        mcCurrentInker.Inverted = true;
                                    else
                                        mcCurrentInker.Inverted = false;
                                    //
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX:

                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.LTIndex = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE:

                                    strValue = _enumerator.Value + "\n";
                                    mcCurrentInker.LTSize = Convert.ToInt16(strValue);
                                    break;

                                case XMLNodeDictionary.XT_MCPRESS_SPUS:

                                    strValue = _enumerator.Value + "\n";
                                    mcTempPressInfo.InitTotalSPUS(Convert.ToInt16(strValue));
                                    iSPU++;
                                    break;

                                case XMLNodeDictionary.XT_MCPRESS_SPU:

                                    PressSPU Spu = (PressSPU)mcPress.GetSPUAt(iSPU);
                                    strValue = _enumerator.Value; 
                                    Spu.SPUName = (strValue);
                                   // iSPU++;
                                    break;

                                case XMLNodeDictionary.XT_MCPRESS_SPU_COMPORT:

                                    PressSPU Spu = (PressSPU)mcPress.GetSPUAt(iSPU);
                                    strValue = _enumerator.Value; 
                                    Spu.SPUCommPort = (strValue);
                                    iSPU++;
                                    break;

                            }

                            // sName = objXmlTextReader.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (sName)
                            {
                                case "BookName":
                                    // cboBookName.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "ReleaseYear":
                                    // cboReleaseYear.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "Publication":
                                    //  cboPublication.Items.Add(objXmlTextReader.Value);
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void LoadElement(string strName, Hashtable attributes)
        {
            IDictionaryEnumerator _enumerator = attributes.GetEnumerator();
            string strValue = "";
            ServoBanks servoBank = GetServoBankforCurrentInker(0);

            while (_enumerator.MoveNext())
            {
                switch (strName)
                {
                    case XMLNodeDictionary.XT_SYSTEM_SITENAME:

                        m_TempMCSiteConfig.SiteName = _enumerator.Value.ToString();
                        break;

                    case XMLNodeDictionary.XT_SYSTEM_SITENUMBER:

                        strValue = _enumerator.Value + "\n";
                        m_TempMCSiteConfig.SiteNumber = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCSYSTEM_CONFIG:

                        strValue = _enumerator.Value + "\n";
                        m_TempMCSiteConfig.SystemConfig = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCSYSTEM_PRESSES:

                        //strValue = _enumerator.Value + "\n";
                        //m_TempMCSiteConfig.PressCount =
                        break;

                    case XMLNodeDictionary.XT_SYSTEM_PRESS:

                        if ((string)_enumerator.Key == XMLNodeDictionary.NAME)
                            mcTempPressInfo.PressName = _enumerator.Value.ToString();
                        if ((string)_enumerator.Key == XMLNodeDictionary.XT_PRESS_TYPE)
                        {
                            strValue = _enumerator.Value + "\n";
                            mcTempPressInfo.PressType = Convert.ToInt16(strValue);
                        }

                        break;

                    case XMLNodeDictionary.XT_PRESS_WIDTH:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.PressWidth = (float)Convert.ToDouble(strValue);
                        break;

                    case XMLNodeDictionary.XT_PRESS_FOLDER:

                        strValue = _enumerator.Value.ToString();
                        break;

                    case XMLNodeDictionary.XT_PRESS_UNITS:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.TotalUnits = Convert.ToInt16(strValue);
                        mcTempPressInfo.GenerateUnits();
                        break;

                    case XMLNodeDictionary.XT_PRESS_UNIT:

                        strValue = _enumerator.Value.ToString();
                        pressUnit = mcTempPressInfo.GetUnitByName(strValue);

                        break;

                    case XMLNodeDictionary.XT_INKERS:

                        strValue = _enumerator.Value + "\n";
                        pressUnit.TotalInkers = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_INKER:

                        strValue = _enumerator.Value.ToString();
                        mcCurrentInker = ((MCInker)(pressUnit.GetInkerAt(0)));//supports only unitized inker for now
                        mcCurrentInker.InkerName = (strValue);
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_KEY1OPERATORSIDE:
                        strValue = _enumerator.Value + "\n";
                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                            mcCurrentInker.FirstKeyOperatorSide = true;
                        else
                            mcCurrentInker.FirstKeyOperatorSide = false;
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SIDE:
                        strValue = _enumerator.Value + "\n";
                        //pressUnit. = Convert.ToInt16(strValue);
                        // To do
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS:
                        strValue = _enumerator.Value.ToString();
                        mcCurrentInker.ServoTurns = strValue;
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_KEYS:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.TotalKeys = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_ATTRIB_WIDTH:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.KeyWidth = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_MINVALUE:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.MinConsoleVal = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.MaxConsoleVal = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.TotalBanks = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS:

                        //if (servoBank == null)
                        //    continue;
                        //ServoBanks servoBank = GetServoBankforCurrentInker(0);
                        if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME)
                        {
                            strValue = _enumerator.Value.ToString();
                            servoBank.SPUName = (strValue);
                        }

                        else if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT)
                        {
                            strValue = _enumerator.Value + "\n";
                            servoBank.PortOnSPU = Convert.ToInt16(strValue);
                        }

                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS:

                        strValue = _enumerator.Value + "\n";
                        servoBank.TotalKeys = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY:

                        strValue = _enumerator.Value + "\n";
                        servoBank.StartKey = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED:
                        strValue = _enumerator.Value + "\n";
                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                            mcCurrentInker.Inverted = true;
                        else
                            mcCurrentInker.Inverted = false;
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX:

                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.LTIndex = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE:

                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.LTSize = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCPRESS_SPUS:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.InitTotalSPUS(Convert.ToInt16(strValue));
                        break;


                }
            }
        }
        
        /*
        private void ReadSiteXMLFile()
        {
            try
            {
                string sStartupPath = Application.StartupPath;
                //clsSValidator objclsSValidator =
                //      new clsSValidator(sStartupPath + @"..\..\..\XMLFile1.xml",
                //      sStartupPath + @"..\..\..\XMLFile1.xsd");
                //if (objclsSValidator.ValidateXMLFile()) return;
                XmlTextReader objXmlTextReader =
                    //  new XmlTextReader(sStartupPath + @"..\..\..\XMLFile1.xml"); //@"C:\GMI\MC3\SYSTEM\MC9999.xml"
                    new XmlTextReader(@"C:\GMI\MC3\SYSTEM\MC9999.xml");
                string sName = "";
                m_TempMCSiteConfig = new MCSiteConfigData();
                mcTempPressInfo = new MCPressInfo();
                m_TempMCSiteConfig.RemovePress();
                MCPressUnit pressUnit = new MCPressUnit();
                
              //  MCPressInfo mcPress = GetCurrentPress();
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:

                            //
                            Hashtable attributes = new Hashtable();
                          // string strURI = objXmlTextReader.NamespaceURI;
                            string strName = objXmlTextReader.Name;
                            for (int i = 0; i < objXmlTextReader.AttributeCount; i++)
                            {
                                objXmlTextReader.MoveToAttribute(i);
                                attributes.Add(objXmlTextReader.Name, objXmlTextReader.Value);
                            }
                            
                            LoadElement(strName, attributes);
                            
                            // sName = objXmlTextReader.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (sName)
                            {
                                case "BookName":
                                    // cboBookName.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "ReleaseYear":
                                    // cboReleaseYear.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "Publication":
                                    //  cboPublication.Items.Add(objXmlTextReader.Value);
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



 
        private void LoadElement(string strName, Hashtable attributes)
        {
            IDictionaryEnumerator _enumerator = attributes.GetEnumerator();
            string strValue = "";
            ServoBanks servoBank = GetServoBankforCurrentInker(0);
              
            while (_enumerator.MoveNext())
            {
                switch (strName)
                {
                    case XMLNodeDictionary.XT_SYSTEM_SITENAME:

                        m_TempMCSiteConfig.SiteName = _enumerator.Value.ToString();
                        break;

                    case XMLNodeDictionary.XT_SYSTEM_SITENUMBER:

                        strValue = _enumerator.Value + "\n";
                        m_TempMCSiteConfig.SiteNumber = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCSYSTEM_CONFIG:

                        strValue = _enumerator.Value + "\n";
                        m_TempMCSiteConfig.SystemConfig = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCSYSTEM_PRESSES:

                        //strValue = _enumerator.Value + "\n";
                        //m_TempMCSiteConfig.PressCount =
                        break;

                    case XMLNodeDictionary.XT_SYSTEM_PRESS:

                        if ((string)_enumerator.Key == XMLNodeDictionary.NAME)
                            mcTempPressInfo.PressName = _enumerator.Value.ToString();
                        if ((string)_enumerator.Key == XMLNodeDictionary.XT_PRESS_TYPE)
                        {
                            strValue = _enumerator.Value + "\n";
                            mcTempPressInfo.PressType = Convert.ToInt16(strValue);
                        }

                        break;

                    case XMLNodeDictionary.XT_PRESS_WIDTH:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.PressWidth = (float)Convert.ToDouble(strValue);
                        break;

                    case XMLNodeDictionary.XT_PRESS_FOLDER:

                        strValue = _enumerator.Value.ToString(); 
                        break;

                    case XMLNodeDictionary.XT_PRESS_UNITS:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.TotalUnits = Convert.ToInt16(strValue);
                        mcTempPressInfo.GenerateUnits();
                        break;

                    case XMLNodeDictionary.XT_PRESS_UNIT:

                        strValue = _enumerator.Value.ToString(); 
                        pressUnit = mcTempPressInfo.GetUnitByName(strValue);
                        
                        break;

                    case XMLNodeDictionary.XT_INKERS:
                        
                        strValue = _enumerator.Value + "\n";
                        pressUnit.TotalInkers = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_INKER:
                        
                        strValue = _enumerator.Value.ToString(); 
                        mcCurrentInker = ((MCInker)(pressUnit.GetInkerAt(0)));//supports only unitized inker for now
                        mcCurrentInker.InkerName = (strValue);
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_KEY1OPERATORSIDE:
                        strValue = _enumerator.Value + "\n";
                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                            mcCurrentInker.FirstKeyOperatorSide = true;
                        else
                            mcCurrentInker.FirstKeyOperatorSide = false;
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SIDE:
                        strValue = _enumerator.Value + "\n";
                        //pressUnit. = Convert.ToInt16(strValue);
                        // To do
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SERVOTURNS:
                        strValue = _enumerator.Value.ToString(); 
                        mcCurrentInker.ServoTurns = strValue;
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_KEYS:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.TotalKeys = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_ATTRIB_WIDTH:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.KeyWidth = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_MINVALUE:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.MinConsoleVal = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_UNIT_INKER_MAXVALUE:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.MaxConsoleVal = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_SERVO_BANKS:
                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.TotalBanks = Convert.ToInt16(strValue);
                        //
                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_ADDRESS:

                        //if (servoBank == null)
                        //    continue;
                        //ServoBanks servoBank = GetServoBankforCurrentInker(0);
                        if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_NAME)
                        {
                            strValue = _enumerator.Value.ToString(); 
                            servoBank.SPUName = (strValue);                            
                        }

                        else if ((string)_enumerator.Key == XMLNodeDictionary.XT_MCSERVO_BANK_SPU_PORT)
                        {
                            strValue = _enumerator.Value + "\n";
                            servoBank.PortOnSPU = Convert.ToInt16(strValue);
                        }

                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_TOTALKEYS:

                        strValue = _enumerator.Value + "\n";
                        servoBank.TotalKeys = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCINKER_SERVO_START_KEY:

                        strValue = _enumerator.Value + "\n";
                        servoBank.StartKey = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_INVERTED:
                        strValue = _enumerator.Value + "\n";
                        if (strValue == XMLNodeDictionary.XT_PRESS_TRUE)
                            mcCurrentInker.Inverted = true;
                        else
                            mcCurrentInker.Inverted = false;
                        //
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_INDEX:

                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.LTIndex = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCUNIT_INKER_LINEAR_TABLE_SIZE:

                        strValue = _enumerator.Value + "\n";
                        mcCurrentInker.LTSize = Convert.ToInt16(strValue);
                        break;

                    case XMLNodeDictionary.XT_MCPRESS_SPUS:

                        strValue = _enumerator.Value + "\n";
                        mcTempPressInfo.InitTotalSPUS(Convert.ToInt16(strValue));
                        break;
                     

                }
            }
        }
        */
  
     


        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            if (m_bNewFileOpen)
            {
                MessageBox.Show("There is a new XML configuration still Running, save/ close the same before continuing");
                return;
            }
                
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.FileName = "";
            ofn.Filter = "(*.xml)|*.xml";
            if (ofn.ShowDialog() == DialogResult.OK)
            {
                gpCreateNew.Visible = false;                
                // TODO: please add the new code to read the XML here...
                // TODO: read XML data and populate the CurrentPress.
                // ends.
                ReadSiteXMLFile();

                if (PopulateTheUIFromCurrentPress())
                    btnNewConfig_Click(sender, e);
                else
                {
                    m_bFileOpenMode = false;
                    return;
                }
                m_bFileOpenMode = true;
                return;
            }
        }
        private bool PopulateTheUIFromCurrentPress()
        {
            txtFountainCount.Text = GetCurrentPress().TotalUnits.ToString ();
            MCPressUnit pressUnit = GetCurrentPress().GetUnitAt(0);
            if (pressUnit == null)
            {
                MessageBox.Show("Invalid Press Unit information Found Abort open");
                return false;

            }
            MCInker mcInker = ((MCInker)pressUnit.GetInkerAt(0));
            if( mcInker == null)
            {
                MessageBox.Show("Invalid Press Inker information Found Abort open");
                return false;
            }
            txtKeysPerfountain.Text = mcInker.GetServoBankAt(0).TotalKeys.ToString ();
            txtKeyWidth.Text = mcInker.KeyWidth.ToString();
            chkTurnBar.Checked = (GetCurrentPress().PressType == 0) ? false : true;
            return true;

        }


        private void sweepInterfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SweepInterfaces sweepInter = new SweepInterfaces();
            sweepInter.StartPosition = FormStartPosition.CenterScreen;
            sweepInter.CurrentPress = GetCurrentPress();
            sweepInter.ShowDialog();
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
    }
}