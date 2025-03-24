/////////////////////////////////////////////////////////////////////////////
//  
// FormAutoScanCal.cs: Auto Scan Calibration Settings
//
//  Author:	Hema Kumar           May-25-2009
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormAutoScanCal.cs-arc   1.7   Jun 21 2012 09:44:54   BEttinger  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormAutoScanCal.cs-arc  $
///  
///     Rev 1.7   Jun 21 2012 09:44:54   BEttinger
///  MT17847
///  
///     Rev 1.6   May 14 2010 01:18:22   SRajarapu
///  15456: MC3Client - Add option to rotate CIP3 image and data
///  
///     Rev 1.5   May 05 2010 00:39:40   SSomashekaran
///  'New CIP3 Form...' option available from MC3Client, even though 'Use CIP3 Presetting' is disabled from site file.
///  
///     Rev 1.4   Sep 02 2009 08:25:50   HNarala
///  MC3SiteGen: 'Done' button not enabled after modifying "CIP3 Path" and "CIP3 Images Path" from 'CIP3 Presetting' dialog.
///  
///     Rev 1.3   Aug 07 2009 05:50:34   HNarala
///  13972: MC3SiteGen: Modify the CIP3 and CIP3 Image path to set manually
///  
///     Rev 1.2   Jun 16 2009 05:36:04   HNarala
///  site file generator defect fixes
///  
///     Rev 1.1   Jun 04 2009 04:56:54   HNarala
///  MT: 13469
///  
///     Rev 1.0   May 27 2009 05:54:14   HNarala
///  Initial revision.
/// 
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
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace MCNWSiteGen
{
    public struct INKER_ROTATE_RECORD
    {
        public string strName;
        public int iImageRotation;
        public bool bDataRotation;
    }

    public partial class FormAutoScanCal : Form
    {
        MCPressInfo currentPress;
        bool m_bIsListViewDataChanged = false;
        List<INKER_ROTATE_RECORD> InkerRecords;

        MC3Components.Controls.MC3Column NameColumn;
        MC3Components.Controls.MC3Column ImageRotationColumn;
        MC3Components.Controls.MC3Column DataRotationColumn;

        /// <![CDATA[
        /// 
        /// < Function: FormAutoScanCal >
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Suresh, MAY-06-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// Constructor
        /// </summary>
        public FormAutoScanCal()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                InkerRecords = new List<INKER_ROTATE_RECORD>();
                NameColumn = new MC3Components.Controls.MC3Column();
                ImageRotationColumn = new MC3Components.Controls.MC3Column();
                DataRotationColumn = new MC3Components.Controls.MC3Column();
            }
        }

        public MCPressInfo CurrentPress
        {
            set { currentPress = value; }
            get { return currentPress; }
        }

        //======================================================================================
        /// <Function>btnCip3PathBrows_Click</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Cip3 Brows Click event
        /// </summary>
        /// <History>
        /// Hema Dt: 08/31/2009 MT: 14130 
		///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </History>
        ///=====================================================================================
        private void btnCip3PathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                try
                {
                    fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string cip3Path = fbdlg.SelectedPath;
                        if ( cip3Path != "" )
                        {
                            this.textBoxCip3Path.Text = String.Concat( cip3Path, "\\" );
                            CheckDataChanges( );
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
        /// < Function: FormAutoScanCal_Load >
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Suresh, MAY-06-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// load event function
        /// </summary>
        private void FormAutoScanCal_Load(object sender, System.EventArgs e)
        {
            this.Location = new Point(Location.X + 150, Location.Y + 80);
            UpdateDataToGUI();
            UpdateListViewSettings();
        }

        //======================================================================================
        /// <Function>btnImpoPathBrows_Click</Function>
        /// <Author> Steve Austin  </Author>
        /// <Date>12-22-2014</Date>
        /// <summary>
        /// Imposition Data Brows Click event
        /// </summary>
        /// <History>
        /// 12-22-2014 spa 51029 Initial 
		///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog
        /// </History>
        ///=====================================================================================
        private void btnImpoPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                try
                {
                    fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string impoPath = fbdlg.SelectedPath;
                        if ( impoPath != "" )
                        {
                            this.textBoxImpo.Text = String.Concat( impoPath, "\\" );
                            CheckDataChanges( );
                        }
                    }

                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }

        //======================================================================================
        /// <Function>UpdateDataToGUI</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Update GUI data
        /// </summary>
        /// <History>
        /// 04-May-10, Sreejit, MT 15667: 'New CIP3 Form...' option available from MC3Client, 
        /// even though 'Use CIP3 Presetting' is disabled from site file
        /// March 9, 2013, MarkC, MT18059   create new ASC enable
        /// 06-Jan-15 spa 51032 Add Imposition Data path
        /// 27-May-15, Mark C, WI57901: Display Imposition data controls only in Tower Press 
        /// </History>
        ///=====================================================================================

        private void UpdateDataToGUI()
        {
            AutoScanCal autoScanCalibration = currentPress.AutoScanCalibration;
            this.checkEnabled.Checked = currentPress.MCClientInterface.CIP3Presetting;
            this.checkASC.Checked = autoScanCalibration.AutoScanEnabled;
            textBoxSweepZoneRatio.Text = autoScanCalibration.SweepZoneRatio.ToString();
            textBoxZoneMargin.Text = autoScanCalibration.ZoneMargin.ToString();
            textBoxEWMAFilterParam.Text = autoScanCalibration.EWMAFactor.ToString();
            int scanSweepAdjust = (int)autoScanCalibration.ScanSweepAdjust;
            string scanSweep = ScanSweepAdjust(scanSweepAdjust);
            comboBoxScanSweepAdjust.Text = scanSweep;
            textBoxSweepDefault.Text = autoScanCalibration.SweepDefault.ToString();
            string webType = GetWebType(autoScanCalibration.WebType);
            comboBoxWebType.Text = webType;
            if (autoScanCalibration.EnableLimitCheck)
                comboEnableLimitCheck.Text = "TRUE";
            else
                comboEnableLimitCheck.Text = "FALSE";
            textBoxBladeTolerance.Text = autoScanCalibration.BladeTolerance.ToString();
            textBoxCip3Path.Text = autoScanCalibration.Cip3Path;
            textBoxCip3ImagesPath.Text = autoScanCalibration.Cip3ImagesPath;

            // Show Imposition controls only in Tower Press 
            EnableImpositionDataControls( ( int ) enPressTypes.TOWER_PRESS == currentPress.PressType );

            EnableContol();
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-15, Mark C, WI57901: Created
        /// 
        /// ]]>
        /// <summary>
        /// Enables the imposition data controls.
        /// </summary>
        /// <param name="enable">if set to <c>true</c> [enable].</param>
        private void EnableImpositionDataControls(bool enable)
        {
            this.checkBoxImpositionData.Visible = enable;
            this.textBoxImpo.Visible = enable;
            this.btnImpoPathBrows.Visible = enable;
            this.labelImpo.Visible = enable;

            if ( enable )
            {
                AutoScanCal autoScanCalibration = currentPress.AutoScanCalibration;
                this.checkBoxImpositionData.Checked = autoScanCalibration.ImpositionDataEnabled;
                if ( checkBoxImpositionData.Checked )
                {
                    textBoxImpo.Text = autoScanCalibration.ImpositionPath;
                }
            }
        }

        /// <![CDATA[
        /// 
        /// < Function: UpdateListViewSettings >
        /// 
        /// < Author: Suresh, MAY-06-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to UpdateListViewSettings
        /// </summary>
        private void UpdateListViewSettings()
        {
            NameColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            NameColumn.Name = "InkerName";
            NameColumn.Text = "Inker Name";
            NameColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            NameColumn.Width = 100;

            ImageRotationColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            ImageRotationColumn.Name = "ImageRotation";
            ImageRotationColumn.Text = "Image Rotation";
            ImageRotationColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ImageRotationColumn.Width = 85;

            DataRotationColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            DataRotationColumn.Name = "DataRotation";
            DataRotationColumn.Text = "Data Rotation";
            DataRotationColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            DataRotationColumn.Width = 85;
            
            this.ListViewInkers.Columns.AddRange(new MC3Components.Controls.MC3Column[] {
                    NameColumn,
                    ImageRotationColumn,
                    DataRotationColumn});
            
            //Generate the inker records
            GenerateInkerRecords();
            //Update the GUI
            ShowInkerListView();
        }

        /// <![CDATA[
        /// 
        /// < Function: GenerateInkerRecords >
        /// 
        /// < Author: Suresh, MAY-06-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to GenerateInkerRecords
        /// </summary>
        private void GenerateInkerRecords()
        {
            if (null != currentPress)
            {
                int iTotalUnits = currentPress.TotalUnits;
                //generate an inker list
                for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
                {
                    MCPressUnit mcUnit = currentPress.GetUnitAt(iUnit);
                    if (mcUnit == null)
                        continue;
                    for (int iInker = 0; iInker < mcUnit.TotalInkers; iInker++)
                    {
                        MCInker mcInker = (MCInker)mcUnit.GetInkerAt(iInker);
                        if (mcInker == null)
                            continue;
                        INKER_ROTATE_RECORD recInker = new INKER_ROTATE_RECORD();
                        recInker.strName = mcInker.InkerName;
                        recInker.iImageRotation = mcInker.CIP3ImageRotateDegrees;
                        recInker.bDataRotation = mcInker.CIP3DataRotation;

                        InkerRecords.Add(recInker);
                    }
                }
                                
                this.ListViewInkers.Refresh();
            }
        }

        /// <![CDATA[
        /// 
        /// < Function: ShowInkerListView >
        /// 
        /// < Author: Suresh, MAY-06-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to ShowInkerListView
        /// </summary>
        private void ShowInkerListView()
        {
            this.ListViewInkers.Items.Clear();

            for (int iInker = 0; iInker < InkerRecords.Count; iInker++)
            {
                INKER_ROTATE_RECORD aRec = (INKER_ROTATE_RECORD)InkerRecords[iInker];
                this.ListViewInkers.Items.Add(aRec.strName);

                UpdateInkerNamesColumn(aRec, iInker);
                UpdateImageRotateDegreesColumn(aRec, iInker);
                UpdateDataRotationColumn(aRec, iInker);
            }
        }

        /// <![CDATA[
        /// 
        /// < Function: UpdateInkerNamesColumn >
        /// 
        /// < Author: Suresh, MAY-13-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to UpdateInkerNamesColumn
        /// </summary>
        private void UpdateInkerNamesColumn(INKER_ROTATE_RECORD aRec, int iInker)
        {
            TextBox tBox = new TextBox();
            tBox.Text = aRec.strName;
            tBox.ReadOnly = true;

            this.ListViewInkers.Items[iInker].SubItems[0].Control = tBox;
        }

        /// <![CDATA[
        /// 
        /// < Function: UpdateImageRotateDegreesColumn >
        /// 
        /// < Author: Suresh, MAY-13-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to UpdateImageRotateDegreesColumn
        /// </summary>
        private void UpdateImageRotateDegreesColumn(INKER_ROTATE_RECORD aRec, int iInker)
        {
            ComboBox cImageBox = new ComboBox();
            cImageBox.Items.Add("0");
            cImageBox.Items.Add("90");
            cImageBox.Items.Add("180");
            cImageBox.Items.Add("270");

            for (int iCnt = 0; iCnt < cImageBox.Items.Count; iCnt++)
            {
                if (aRec.iImageRotation.ToString() == cImageBox.Items[iCnt].ToString())
                {
                    cImageBox.SelectedIndex = iCnt;
                    break;
                }
            }

            cImageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ListViewInkers.Items[iInker].SubItems[1].Control = cImageBox;

            cImageBox.SelectedValueChanged += new EventHandler(cImageBox_SelectedValueChanged);
        }

        /// <![CDATA[
        /// 
        /// < Function: UpdateDataRotationColumn >
        /// 
        /// < Author: Suresh, MAY-13-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to UpdateDataRotationColumn
        /// </summary>
        private void UpdateDataRotationColumn(INKER_ROTATE_RECORD aRec, int iInker)
        {
            ComboBox cDataBox = new ComboBox();
            cDataBox.Items.Add("FALSE");
            cDataBox.Items.Add("TRUE");

            if (aRec.bDataRotation)
            {
                cDataBox.SelectedIndex = 1;
            }
            else
            {
                cDataBox.SelectedIndex = 0;
            }

            cDataBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ListViewInkers.Items[iInker].SubItems[2].Control = cDataBox;

            cDataBox.SelectedValueChanged += new EventHandler(cDataBox_SelectedValueChanged);
        }

        /// <![CDATA[
        /// 
        /// < Function: cImageBox_SelectedValueChanged >
        /// 
        /// < Author: Suresh, MAY-07-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// cImageBox_SelectedValueChanged event
        /// </summary>
        void cImageBox_SelectedValueChanged(object sender, EventArgs e)
        {
            m_bIsListViewDataChanged = true;
            CheckDataChanges();
        }

        /// <![CDATA[
        /// 
        /// < Function: cDataBox_SelectedValueChanged >
        /// 
        /// < Author: Suresh, MAY-07-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// cDataBox_SelectedValueChanged event
        /// </summary>
        void cDataBox_SelectedValueChanged(object sender, EventArgs e)
        {
            m_bIsListViewDataChanged = true;
            CheckDataChanges();
        }

        /// <![CDATA[
        /// 
        /// < Function: GetDataFromInkerListView >
        /// 
        /// < Author: Suresh, MAY-07-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// to GetDataFromInkerListView
        /// </summary>
        private void GetDataFromInkerListView()
        {
            ArrayList ayInkerRecords = new ArrayList();
            for (int iInker = 0; iInker < ListViewInkers.Items.Count; iInker++)
            {
                INKER_ROTATE_RECORD aRec = new INKER_ROTATE_RECORD();

                //inker name
                aRec.strName = this.ListViewInkers.Items[iInker].SubItems[0].Control.Text;
                //image rotation degrees
                aRec.iImageRotation = int.Parse(this.ListViewInkers.Items[iInker].SubItems[1].Control.Text);
                //data rotation
                aRec.bDataRotation = bool.Parse(this.ListViewInkers.Items[iInker].SubItems[2].Control.Text);
                
                ayInkerRecords.Add(aRec);
            }

            SaveInkerRecords(ayInkerRecords);
        }

        /// <![CDATA[
        /// 
        /// < Function: SaveInkerRecords >
        /// 
        /// < Author: Suresh, MAY-07-2010>
        /// 
        /// History: Created for ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        ///          21-JUN-12 BEttinger, MT17847 - fixed indexing for odd number of inkers
        /// ]]>
        /// <summary>
        /// to SaveInkerRecords
        /// </summary>
        private void SaveInkerRecords(ArrayList ayInkerRecords)
        {
            if (null != currentPress)
            {
                int iTotalUnits = currentPress.TotalUnits;
                int iIndex = 0;

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

                        //get press inker index from the loop
                        //index should not be more than total inkers
                        if (iIndex < ayInkerRecords.Count)
                        {
                            INKER_ROTATE_RECORD recInker = (INKER_ROTATE_RECORD)ayInkerRecords[iIndex];
                            mcInker.InkerName = recInker.strName;
                            mcInker.CIP3ImageRotateDegrees = recInker.iImageRotation;
                            mcInker.CIP3DataRotation = recInker.bDataRotation;
                            iIndex++;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect inker number");
                        }
                    }
                }
            }
        }

        //======================================================================================
        /// <Function>UpdateDataFromGUI</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Update GUI data
        /// </summary>
        /// <History>
        /// 04-May-10, Sreejit, MT 15667: 'New CIP3 Form...' option available from MC3Client, 
        /// even though 'Use CIP3 Presetting' is disabled from site file
        /// 06-Jan-15 spa 51032 Add Imposition Data path
        /// </History>
        ///=====================================================================================

        private void UpdateDataFromGUI()
        {
            AutoScanCal autoScanCalibration = currentPress.AutoScanCalibration;
            autoScanCalibration.AutoScanEnabled = this.checkASC.Checked;
            currentPress.MCClientInterface.CIP3Presetting = this.checkEnabled.Checked;

            autoScanCalibration.SweepZoneRatio = Convert.ToDouble(textBoxSweepZoneRatio.Text);
            autoScanCalibration.ZoneMargin =Convert.ToInt16(textBoxZoneMargin.Text);
            autoScanCalibration.EWMAFactor = Convert.ToDouble(textBoxEWMAFilterParam.Text);
            int scanSweepAdjust = ScanSweepAdjust(comboBoxScanSweepAdjust.Text);
            autoScanCalibration.ScanSweepAdjust = scanSweepAdjust;
            autoScanCalibration.SweepDefault = Convert.ToInt16(textBoxSweepDefault.Text);
            autoScanCalibration.WebType = GetWebType(comboBoxWebType.Text);
            autoScanCalibration.EnableLimitCheck = Convert.ToBoolean(comboEnableLimitCheck.Text);
            autoScanCalibration.BladeTolerance = Convert.ToInt16(textBoxBladeTolerance.Text);
            string path = textBoxCip3Path.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            autoScanCalibration.Cip3Path = path;
            path = textBoxCip3ImagesPath.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            autoScanCalibration.Cip3ImagesPath = path;

            autoScanCalibration.ImpositionDataEnabled = checkBoxImpositionData.Checked;
            if (checkBoxImpositionData.Checked)
            {
                path = textBoxImpo.Text;
                path.Trim();
                if (!isFormated(path))
                {
                    path = string.Concat(path, "\\");
                }
                autoScanCalibration.ImpositionPath = path;
            }

        }

        private bool isFormated(string path)
        {
            bool status = false;                
            if (path != "")
            {
                int length = path.Length;
                char lastChar = path[length - 1];
                int value = string.Compare(lastChar.ToString(), ("\\"));
                if (value == 0)
                    status = true;
            }
            return status;
        }

        private int GetWebType(string webType)
        {
            int type = (int)WebType.SINGLE_WEB_PRESS;
            switch (webType)
            {
                case DefineAndConst.WebType.SHEETFED:
                    type = (int)WebType.SHEETFED;
                    break;
                case DefineAndConst.WebType.SINGLE_WEB_PRESS:
                    type = (int)WebType.SINGLE_WEB_PRESS;
                    break;
                case DefineAndConst.WebType.TWO_WEB_SPLIT_PRESS:
                    type = (int)WebType.TWO_WEB_SPLIT_PRESS;
                    break;
                default:
                    type = (int)WebType.SINGLE_WEB_PRESS;
                    break;
            }
            return type;
        }
        private string GetWebType(int webType)
        {
            string type = DefineAndConst.WebType.SINGLE_WEB_PRESS;
            switch (webType)
            {
                case (int)WebType.SHEETFED:
                    type = DefineAndConst.WebType.SHEETFED;
                    break;
                case (int)WebType.SINGLE_WEB_PRESS:
                    type = DefineAndConst.WebType.SINGLE_WEB_PRESS;
                    break;
                case (int)WebType.TWO_WEB_SPLIT_PRESS:
                    type = DefineAndConst.WebType.TWO_WEB_SPLIT_PRESS;
                    break;
                default:
                    type = DefineAndConst.WebType.SINGLE_WEB_PRESS;
                    break;
            }
            return type;
        }

        private int ScanSweepAdjust(string scanSweepAdjust)
        {
            int swcanSweep = (int)ScanSweep.SCAN_SWEEP_DEFAULT;
            switch (scanSweepAdjust)
            {
                case DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_DEFAULT:
                    swcanSweep = (int)ScanSweep.SCAN_SWEEP_DEFAULT;
                    break;
                case DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_ADJUST:
                    swcanSweep = (int)ScanSweep.SCAN_SWEEP_ADJUST;
                    break;
                case DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_RETAIN:
                    swcanSweep = (int)ScanSweep.SCAN_SWEEP_RETAIN;
                    break;
                default:
                    swcanSweep = (int)ScanSweep.SCAN_SWEEP_DEFAULT;
                    break;
            }
            return swcanSweep;
        }
        private string ScanSweepAdjust(int scanSweepAdjust)
        {
            string swcanSweep = DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_DEFAULT;
            switch (scanSweepAdjust)
            {
                case (int)ScanSweep.SCAN_SWEEP_DEFAULT:
                    swcanSweep = DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_DEFAULT;
                    break;
                case (int)ScanSweep.SCAN_SWEEP_ADJUST:
                    swcanSweep = DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_ADJUST;
                    break;
                case (int)ScanSweep.SCAN_SWEEP_RETAIN:
                    swcanSweep = DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_RETAIN;
                    break;
                default:
                    swcanSweep = DefineAndConst.ScanSweepAdjust.SCAN_SWEEP_DEFAULT;
                    break;
            }
            return swcanSweep;
        }

        //======================================================================================
        /// <Function>btnCip3ImagesPathBrows_Click</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// Cip3 Images Path Brows Click event
        /// </summary>
        /// <History>
        /// Hema Dt: 08/31/2009 MT: 14130 
		///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog
        /// </History>
        ///=====================================================================================
        private void btnCip3ImagesPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                try
                {
                    fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                    DialogResult result = fbdlg.ShowDialog( );
                    if ( result == DialogResult.OK )
                    {
                        string cip3ImagesPath = fbdlg.SelectedPath;
                        if ( cip3ImagesPath != "" )
                        {
                            this.textBoxCip3ImagesPath.Text = String.Concat( cip3ImagesPath, "\\" );
                            CheckDataChanges( );
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <![CDATA[
        /// 
        /// < Function: btnOK_Click >
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Suresh, MAY-07-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data 
        /// ]]>
        /// <summary>
        /// btnOK_Click event
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateDataFromGUI();
            GetDataFromInkerListView();

            this.Close();
        }

        //======================================================================================
        /// <Function>textBoxSweepZoneRatio_TextChanged</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textBox SweepZoneRatio Text Changed event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textBoxSweepZoneRatio_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSweepZoneRatio.Text == "")
                return;
            if (CurrentPress != null)
            {
                double minSweepZoneRatio = DefineAndConst.SystemCapacities.MIN_SWEEP_ZONE_RATIO;
                double maxSweepZoneRatio = DefineAndConst.SystemCapacities.MAX_SWEEP_ZONE_RATIO;
                double sweepZoneRatio = CurrentPress.AutoScanCalibration.SweepZoneRatio;
                Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                if (!regex.IsMatch(textBoxSweepZoneRatio.Text))
                {
                    MessageBox.Show("The Range Of Sweep Zone Ratio is : " + minSweepZoneRatio + " - " + maxSweepZoneRatio);
                    textBoxSweepZoneRatio.Text = sweepZoneRatio.ToString();
                    return;
                }
            }
        }

        private void textBoxZoneMargin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxZoneMargin.Text == "")
                return;
            if (CurrentPress != null)
            {
                int minZoneMargin = DefineAndConst.SystemCapacities.MIN_ZONE_MARGIN;
                int maxZoneMargin = DefineAndConst.SystemCapacities.MAX_ZONE_MARGIN;
                int zoneMargin = CurrentPress.AutoScanCalibration.ZoneMargin;
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textBoxZoneMargin.Text))
                {
                    MessageBox.Show("The Range Of Zone Margin is : " + minZoneMargin + " - " + maxZoneMargin);
                    textBoxZoneMargin.Text = zoneMargin.ToString();
                    return;
                }
                int ZnMargin = Convert.ToInt16(textBoxZoneMargin.Text);
                if (ZnMargin < minZoneMargin || ZnMargin > maxZoneMargin)
                {
                    MessageBox.Show("The Range Of Zone Margin is : " + minZoneMargin + " - " + maxZoneMargin);
                    textBoxZoneMargin.Text = zoneMargin.ToString();
                }
                CheckDataChanges();
            }
        }

        //======================================================================================
        /// <Function>textBoxEWMAFilterParam_TextChanged</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textBox EWMAFilter Parameter Text Changed event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textBoxEWMAFilterParam_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEWMAFilterParam.Text == "")
                return;
            if (CurrentPress != null)
            {
                double minEWMAFactor = DefineAndConst.SystemCapacities.MIN_EWMAFACTOR;
                double maxEWMAFactor = DefineAndConst.SystemCapacities.MAX_EWMAFACTOR;
                double EWMAFactor = CurrentPress.AutoScanCalibration.EWMAFactor;

                Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$");
                if (!regex.IsMatch(textBoxEWMAFilterParam.Text))
                {
                    MessageBox.Show("The Range Of EWMAFilter Param is : " + minEWMAFactor + " - " + maxEWMAFactor);
                    textBoxEWMAFilterParam.Text = EWMAFactor.ToString();
                }
            }
        }

        private void textBoxSweepDefault_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSweepDefault.Text == "")
                return;
            if (CurrentPress != null)
            {
                int minSweepDefault = DefineAndConst.SystemCapacities.MIN_SWEEP_DEFAULT;
                int maxSweepDefault = DefineAndConst.SystemCapacities.MAX_SWEEP_DEFAULT;
                int sweepDefault = CurrentPress.AutoScanCalibration.SweepDefault;

                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textBoxSweepDefault.Text))
                {
                    MessageBox.Show("The Range Of Sweep Default is : " + minSweepDefault + " - " + maxSweepDefault);
                    textBoxSweepDefault.Text = sweepDefault.ToString();
                    return;
                }
                int swDefault = Convert.ToInt16(textBoxSweepDefault.Text);
                if (swDefault < minSweepDefault || swDefault > maxSweepDefault)
                {
                    MessageBox.Show("The Range Of Sweep Default is : " + minSweepDefault + " - " + maxSweepDefault);
                    textBoxSweepDefault.Text = sweepDefault.ToString();
                }
                CheckDataChanges();
            }
        }

        private void textBoxBladeTolerance_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBladeTolerance.Text == "")
                return;            
            if (CurrentPress != null)
            {
                int minBladeTolerance = DefineAndConst.SystemCapacities.MIN_BLADE_TOLERANCE;
                int maxBladeTolerance = DefineAndConst.SystemCapacities.MAX_BLADE_TOLERANCE;
                int bladeTolerance = CurrentPress.AutoScanCalibration.BladeTolerance;
                Regex regex = new Regex("^[0-9]*$");
                if (!regex.IsMatch(textBoxBladeTolerance.Text))
                {
                    MessageBox.Show("The Range Of Blade Tolerance is : " + minBladeTolerance + " - " + maxBladeTolerance);
                    textBoxBladeTolerance.Text = bladeTolerance.ToString();
                    return;
                }
                int bTolerance = Convert.ToInt16(textBoxBladeTolerance.Text);
                if (bTolerance < minBladeTolerance || bTolerance > maxBladeTolerance)
                {
                    MessageBox.Show("The Range Of Blade Tolerance is : " + minBladeTolerance + " - " + maxBladeTolerance);
                    textBoxBladeTolerance.Text = bladeTolerance.ToString();
                }
                CheckDataChanges();
            }
        }

        //======================================================================================
        /// <Function>textBoxSweepZoneRatio_Leave</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textBox SweepZoneRatio Leave event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textBoxSweepZoneRatio_Leave(object sender, EventArgs e)
        {
            double minSweepZoneRatio = DefineAndConst.SystemCapacities.MIN_SWEEP_ZONE_RATIO;
            double maxSweepZoneRatio = DefineAndConst.SystemCapacities.MAX_SWEEP_ZONE_RATIO;
            double sweepZoneRatio = CurrentPress.AutoScanCalibration.SweepZoneRatio;
            if (textBoxSweepZoneRatio.Text == "")
            {
                MessageBox.Show("The Range Of Sweep Zone Ratio is : " + minSweepZoneRatio + " - " + maxSweepZoneRatio);
                if (CurrentPress != null)
                {
                    textBoxSweepZoneRatio.Text = currentPress.AutoScanCalibration.SweepZoneRatio.ToString();
                    return;
                }
            }
            if (textBoxSweepZoneRatio.Text == ".")
                textBoxSweepZoneRatio.Text = "0";
            double SZRatio = Convert.ToDouble(textBoxSweepZoneRatio.Text);
            if (CurrentPress != null)
            {
                if (SZRatio < minSweepZoneRatio || SZRatio > maxSweepZoneRatio)
                {
                    MessageBox.Show("The Range Of Sweep Zone Ratio is : " + minSweepZoneRatio + " - " + maxSweepZoneRatio);
                    textBoxSweepZoneRatio.Text = sweepZoneRatio.ToString();
                }
                CheckDataChanges();                
            }
        }

        /// <![CDATA[
        /// 
        /// < Function: CheckDataChanges >
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Suresh, MAY-07-2010, ENH 15456: MC3Client - Add option to rotate CIP3 image and data
        ///         March 9, 2013, Markc, MT18059  add new ASC enable
        /// 06-Jan-15 spa 51032 Add Imposition Data path
        /// 27-May-15, Mark C, WI57901: Validate Imposition data elements only in Tower Press
        /// ]]>
        /// <summary>
        /// CheckDataChanges in WinForms data, turns ON the OK button control during editing Presetting/ASC view.
        /// </summary>
        private void CheckDataChanges()
        {
            bool changeInData = false;
            if (currentPress != null)
            {
                if ((textBoxSweepZoneRatio.Text != "") && (textBoxZoneMargin.Text != "") && (textBoxEWMAFilterParam.Text != "")
                    && (comboBoxScanSweepAdjust.Text != "") && (textBoxSweepDefault.Text != "") && (comboBoxWebType.Text != "")
                    && (comboEnableLimitCheck.Text != "") && (textBoxBladeTolerance.Text != "") && (textBoxCip3Path.Text != "")
                    && (textBoxCip3ImagesPath.Text != "") ) 
                {
                    AutoScanCal autoScanCal = currentPress.AutoScanCalibration;
                    if (autoScanCal.AutoScanEnabled != this.checkASC.Checked)
                        changeInData = true;
                    else if (currentPress.MCClientInterface.CIP3Presetting != this.checkEnabled.Checked)
                        changeInData = true;
                    else if (autoScanCal.SweepZoneRatio != Convert.ToDouble(textBoxSweepZoneRatio.Text))
                        changeInData = true;
                    else if (autoScanCal.ZoneMargin != Convert.ToInt16(textBoxZoneMargin.Text))
                        changeInData = true;
                    else if (autoScanCal.EWMAFactor != Convert.ToDouble(textBoxEWMAFilterParam.Text))
                        changeInData = true;
                    else if (autoScanCal.SweepDefault != Convert.ToInt16(textBoxSweepDefault.Text))
                        changeInData = true;
                    else if (autoScanCal.BladeTolerance != Convert.ToInt16(textBoxBladeTolerance.Text))
                        changeInData = true;
                    else if (autoScanCal.Cip3Path != textBoxCip3Path.Text)
                        changeInData = true;
                    else if (autoScanCal.Cip3ImagesPath != textBoxCip3ImagesPath.Text)
                        changeInData = true;
                    else
                    {
                        int scanSeepAdj = ScanSweepAdjust(comboBoxScanSweepAdjust.Text);
                        if (scanSeepAdj != autoScanCal.ScanSweepAdjust)
                            changeInData = true;
                        else
                        {
                            int webtype = GetWebType(comboBoxWebType.Text);
                            if (autoScanCal.WebType != webtype)
                                changeInData = true;
                            else
                            {
                                bool enableLimitCheck = Convert.ToBoolean(comboEnableLimitCheck.Text);
                                if (autoScanCal.EnableLimitCheck != enableLimitCheck)
                                    changeInData = true;
                            }
                        }
                    }
                }
                if (m_bIsListViewDataChanged) //if any of the rotate options changed
                {
                    changeInData = true;
                }

                // Validate Imposition data elements only in Tower Press
                if ( ( int ) enPressTypes.TOWER_PRESS == currentPress.PressType )
                {
                    if ( !string.IsNullOrEmpty( textBoxImpo.Text ) )
                    {
                        AutoScanCal autoScanCal = currentPress.AutoScanCalibration;
                        if ( ( autoScanCal.ImpositionPath != textBoxImpo.Text ) ||
                             ( autoScanCal.ImpositionDataEnabled != checkBoxImpositionData.Checked ) )
                        {
                            changeInData = true;
                        }
                    }
                }

            }
            btnOK.Enabled = changeInData;
        }

        private void textBoxZoneMargin_Leave(object sender, EventArgs e)
        {
            if (textBoxZoneMargin.Text == "")
            {
                MessageBox.Show("The Range Of Zone Margin is : " + DefineAndConst.SystemCapacities.MIN_ZONE_MARGIN + " - " + DefineAndConst.SystemCapacities.MAX_ZONE_MARGIN);
                if (CurrentPress != null)
                {
                    textBoxZoneMargin.Text = currentPress.AutoScanCalibration.ZoneMargin.ToString();
                }
            }
            CheckDataChanges();
        }

        //======================================================================================
        /// <Function>textBoxEWMAFilterParam_Leave</Function>
        /// <Author>  </Author>
        /// <Date>Jan-20-2009</Date>
        /// <summary>
        /// textBox EWMAFilter Param Leave event 
        /// </summary>
        /// <History>
        /// Hema MT: 13561 Dt: 06/15/2009 to enter the decimal values
        /// </History>
        ///=====================================================================================
        private void textBoxEWMAFilterParam_Leave(object sender, EventArgs e)
        {
            double minEWMAFactor = DefineAndConst.SystemCapacities.MIN_EWMAFACTOR;
            double maxEWMAFactor = DefineAndConst.SystemCapacities.MAX_EWMAFACTOR;
            double EWMAFactor = CurrentPress.AutoScanCalibration.EWMAFactor;
            if (textBoxEWMAFilterParam.Text == "")
            {
                MessageBox.Show("The Range Of EWMAFilter Param is : " + minEWMAFactor + " - " + maxEWMAFactor);
                if (currentPress != null)
                {
                    textBoxEWMAFilterParam.Text = EWMAFactor.ToString();
                }
                return;
            }
            if (textBoxEWMAFilterParam.Text == ".")
                textBoxEWMAFilterParam.Text = "0";
            double SZRatio = Convert.ToDouble(textBoxEWMAFilterParam.Text);
            if (SZRatio < minEWMAFactor || SZRatio > maxEWMAFactor)
            {
                MessageBox.Show("The Range Of EWMAFilter Param is : " + minEWMAFactor + " - " + maxEWMAFactor);
                textBoxEWMAFilterParam.Text = EWMAFactor.ToString();
            }
            CheckDataChanges();
        }

        private void comboBoxScanSweepAdjust_Leave(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void textBoxSweepDefault_Leave(object sender, EventArgs e)
        {
            if (textBoxSweepDefault.Text == "")
            {
                MessageBox.Show("The Range Of Sweep Default is : " + DefineAndConst.SystemCapacities.MIN_SWEEP_DEFAULT + " - " + DefineAndConst.SystemCapacities.MAX_SWEEP_DEFAULT);
                if (currentPress != null)
                {
                    textBoxSweepDefault.Text = currentPress.AutoScanCalibration.SweepDefault.ToString();
                }
            }
            CheckDataChanges();
        }

        private void comboBoxWebType_Leave(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void comboEnableLimitCheck_Leave(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void textBoxBladeTolerance_Leave(object sender, EventArgs e)
        {
            if (textBoxBladeTolerance.Text == "")
            {
                MessageBox.Show("The Range Of Blade Tolerance is : " + DefineAndConst.SystemCapacities.MIN_BLADE_TOLERANCE + " - " + DefineAndConst.SystemCapacities.MAX_BLADE_TOLERANCE);
                if (currentPress != null)
                {
                    textBoxBladeTolerance.Text = currentPress.AutoScanCalibration.BladeTolerance.ToString();
                }
            }
            CheckDataChanges();
        }

        //======================================================================================
        /// <Function>textBoxCip3Path_Leave</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>08/07/2009 </Date>
        /// <summary>
        /// text Box Cip3 Path Leave event 
        /// </summary>
        /// <History>
        /// 
        /// </History>
        ///=====================================================================================
        private void textBoxCip3Path_Leave(object sender, EventArgs e)
        {
            if (textBoxCip3Path.Text != "")
            {
                string path = textBoxCip3Path.Text.Trim();
                if (isValidPath(path))
                {
                    textBoxCip3Path.Text = path;
                    CheckDataChanges();
                    return;                    
                }
            }
            MessageBox.Show("Enter a valid CIP3 Path: ");
            textBoxCip3Path.Text = currentPress.AutoScanCalibration.Cip3Path;
            CheckDataChanges();
        }

        //======================================================================================
        /// <Function>textBoxCip3ImagesPath_Leave</Function>
        /// <Author>Hema Kumar   </Author>
        /// <Date>08/07/2009 </Date>
        /// <summary>
        /// text Box Cip3 Images Path Leave event 
        /// </summary>
        /// <History>
        /// 
        /// </History>
        ///=====================================================================================
        private void textBoxCip3ImagesPath_Leave(object sender, EventArgs e)
        {
            if (textBoxCip3ImagesPath.Text != "")
            {
                string path = textBoxCip3ImagesPath.Text.Trim();
                if (isValidPath(path))
                {
                    textBoxCip3ImagesPath.Text = path;
                    CheckDataChanges();
                    return;                     
                }
            }
            MessageBox.Show("Enter a valid CIP3 Images Path: ");
            textBoxCip3ImagesPath.Text = currentPress.AutoScanCalibration.Cip3ImagesPath;
            CheckDataChanges();
        }

        //======================================================================================
        /// <Function>ImpotextBox_Leave</Function>
        /// <Author>Steve Austin   </Author>
        /// <Date>01/06/2015 </Date>
        /// <summary>
        /// text Box Imposition Path Leave event 
        /// </summary>
        /// <History>
        /// 
        /// </History>
        ///=====================================================================================
        private void ImpotextBox_Leave(object sender, EventArgs e)
        {
            if( checkBoxImpositionData.Checked )
            {
                if (textBoxImpo.Text != "")
                {
                    string path = textBoxImpo.Text.Trim();
                    if (isValidPath(path))
                    {
                        textBoxImpo.Text = path;
                        CheckDataChanges();
                        return;
                    }
                }
                MessageBox.Show("Enter a valid Imposition Data Path: ");
                textBoxImpo.Text = currentPress.AutoScanCalibration.ImpositionPath;
                CheckDataChanges();
            }
        }

        private bool isValidPath(string strFolderPath)
        {
            Regex r = new Regex(@"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$");
            return r.IsMatch(strFolderPath);
        }

        private void comboBoxScanSweepAdjust_TextChanged(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void comboBoxWebType_TextChanged(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void comboEnableLimitCheck_TextChanged(object sender, EventArgs e)
        {
            CheckDataChanges();
        }

        private void checkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckDataChanges();
            EnableContol();
        }

        private void EnableContol()
        {
            if (checkEnabled.Checked)
            {
                gpMotorOrServoSettings.Enabled = true;
            }
            else
                gpMotorOrServoSettings.Enabled = false;
        }

        /// <![CDATA[
        ///
        /// Author: someone
        /// 
        /// History: 27-May-15, Mark C, WI57901: Enable Imposition data controls only when Imposition is configured.
        /// 
        /// ]]>
        /// <summary>
        /// Handles the CheckedChanged event of the checkBoxImpositionData control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkBoxImpositionData_CheckedChanged(object sender, EventArgs e)
        {            
            EnableImpositionDataControl();
            CheckDataChanges( );
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 27-May-15, Mark C, WI57901: Created
        /// 
        /// ]]>
        /// <summary>
        /// Enables the imposition data control.
        /// </summary>
        private void EnableImpositionDataControl()
        {
            bool selectedImposition = checkBoxImpositionData.Checked;
            labelImpo.Enabled = selectedImposition;
            textBoxImpo.Enabled = selectedImposition;
            btnImpoPathBrows.Enabled = selectedImposition;

            if ( selectedImposition )
            {
                AutoScanCal autoScanCalibration = currentPress.AutoScanCalibration;
                this.textBoxImpo.Text = autoScanCalibration.ImpositionPath;
            }
        }


        /// <![CDATA[        
        /// Author: Mark C
        /// 
        /// History: 12-Feb-20, Mark C, WI176828: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [ASC checked changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnASC_CheckedChanged( object sender, System.EventArgs e )
        {
            CheckDataChanges();
        }  

    }
}