/////////////////////////////////////////////////////////////////////////////
//
//  FormAutoZeroConfiguration.cs - PressAutoZero settings dialog  
//
//  Author:	Mark C, 13-Aug-12, WI28788
//
//	$Header:   $
//
//	$Log:   $
//
/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{
    public struct CHANNEL_MAPPING_ELEMENT//WI30488
    {
        public int iChannNdx;
        public string strChannType;
        public string stUnitName;
    }


    public partial class FormAutoZeroConfiguration : Form
    {
              //WI30488
        bool m_bIsListViewDataChanged = true;
        List<CHANNEL_MAPPING_ELEMENT> MappingElementRecords;
        MC3Components.Controls.MC3Column ChannelColumn;
        MC3Components.Controls.MC3Column TypeColumn;
        MC3Components.Controls.MC3Column UnitColumn;


        /// <summary>
        /// Class to hold parameter limits
        /// </summary>
        private class PressAutoZeroParameterValidRange
        {
            public const int AZ_DEVICE_ID_MAX = 10;
            public const int AZ_TIME_DELAY = 10000;
            public const int AZ_POLL_PERIOD = 10000;
            public const int AZ_FACTOR_FREQUENCY = 10000;
            public const int AZ_IDLE_THRESHOLD_FPM = 1000;
            public const int AZ_TIME_DELAY_CLOSE_FOUNTAIN = 600000;
        }


        /// <summary>
        /// Costructor. Initializes a new instance of the <see cref="FormAutoZeroConfiguration"/> class.
        /// </summary>
        /// <param name="press">The press.</param>
        public FormAutoZeroConfiguration(MCPressInfo  press)
        {
            this.m_press = press;
            InitializeComponent();
               //WI30488
            if (!DesignMode)
            {
                MappingElementRecords = new List<CHANNEL_MAPPING_ELEMENT>();
                ChannelColumn = new MC3Components.Controls.MC3Column();
                TypeColumn = new MC3Components.Controls.MC3Column();
                UnitColumn = new MC3Components.Controls.MC3Column();
            }
         
        }

        /// <summary>
        /// Handles the Load event of the FormAutoZeroConfiguration control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormAutoZeroConfiguration_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 35);
            UpdateDataToGUI();
            UpdateListViewSettings();//WI30488
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateListViewSettings 
        /// 
        /// History: 07-May-2013 BEttinger WI30488: created for ADAM channels mapping 
        /// ]]>
        /// <summary>
        /// updates ListView settings for the mapping
        /// </summary>
        private void UpdateListViewSettings()
        {
            ChannelColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            ChannelColumn.Name = "ChannelNdx";
            ChannelColumn.Text = "Channel Index";
            ChannelColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ChannelColumn.Width = 100;


            TypeColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            TypeColumn.Name = "Type";
            TypeColumn.Text = "Type";
            TypeColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            TypeColumn.Width = 85;

            UnitColumn.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            UnitColumn.Name = "UnitName";
            UnitColumn.Text = "Unit Name";
            UnitColumn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            UnitColumn.Width = 85;

            this.ListViewMapping.Columns.AddRange(new MC3Components.Controls.MC3Column[] {
                    ChannelColumn,
                    TypeColumn,
                    UnitColumn});

            //GenerateInkerRecords();
            GenerateMappingRecords();
            //Update the GUI
            //ShowInkerListView();
            ShowMappingListView();
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Update new parameter timeDelayToCloseFountain with XML data
        ///         07-May-13, BEttinger, WI30488: add channel map for multiple source Auto Zero
        /// ]]>
        /// <summary>
        /// Updates the data to GUI.
        /// </summary>
        private void UpdateDataToGUI()
        {            
            this.checkAutoZero.Checked = m_press.PressAutoZero.AutoZeroEnabled;
            // if PressAutoZero is disabled then disable all the controls
            this.groupAutoZeroSettings.Enabled = this.checkAutoZero.Checked;
                        //WI30488 
            this.groupBoxChannMap.Enabled = this.checkAutoZero.Checked; 

            this.comboAutoZeroMode.SelectedIndex = m_press.PressAutoZero.Mode;
            this.textDeviceIPAddress.Text = m_press.PressAutoZero.DeviceIPAddress;
            this.textDeviceID.Text = m_press.PressAutoZero.DeviceID.ToString();
            this.textTimeDelay.Text = m_press.PressAutoZero.TimeDelay.ToString();
            this.textPollPeriod.Text = m_press.PressAutoZero.PollTimePeriod.ToString();
            this.textFactorFrequency.Text = m_press.PressAutoZero.FactorFrequency.ToString();
            this.textIdleThresholdFPM.Text = m_press.PressAutoZero.IdleThresholdFPM.ToString();
            this.comboDryContactIdleFpm.SelectedIndex = Convert.ToByte( m_press.PressAutoZero.DryContactIdleState );
            this.textTimeDelayToCloseFountain.Text = m_press.PressAutoZero.TimeDelayToCloseFountain.ToString();
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         07-May-13, BEttinger, WI30488: created to add channel map for multiple source Auto Zero
        /// ]]>
        /// <summary>
        /// Generates mapping data.
        /// </summary>
        private void GenerateMappingRecords()
        {
            if (null != m_press)
            {
                        //generate mapping list:
                int iTotalChannels = DefineAndConst.SystemCapacities.MAX_AUTO_ZERO_CHANNELS;
                Dictionary<byte, string> dryChannelsMap = m_press.PressAutoZero.DryChannelsMap;
                Dictionary<byte, string> frqChannelsMap = m_press.PressAutoZero.FrqChannelsMap;

                for (int iChanId = 0; iChanId < iTotalChannels; ++iChanId)
                {
                    CHANNEL_MAPPING_ELEMENT mapElem = new CHANNEL_MAPPING_ELEMENT();

                    mapElem.iChannNdx = iChanId;

                    string strUnitName;
                    if( (dryChannelsMap != null) && dryChannelsMap.TryGetValue((byte)iChanId, out strUnitName) )
                    {
                        mapElem.strChannType = "DRY";
                        mapElem.stUnitName = strUnitName;
                    }
                    else if ((frqChannelsMap != null) && frqChannelsMap.TryGetValue((byte)iChanId, out strUnitName))
                    {
                        mapElem.strChannType = "FRQ";
                        mapElem.stUnitName = strUnitName;
                    }
                    else
                    {
                        mapElem.strChannType = "NA";
                        mapElem.stUnitName   = "NA";
                    }
                    MappingElementRecords.Add(mapElem);
                }//for()
                this.ListViewMapping.Refresh();
            }

        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         07-May-13, BEttinger, WI30488: created to add channel map for multiple source Auto Zero
        /// ]]>
        /// <summary>
        /// Updates the data to GUI.
        /// </summary>
        private void ShowMappingListView()
        {
            this.ListViewMapping.Items.Clear();

            for (int iChanId = 0; iChanId < MappingElementRecords.Count; ++iChanId)
            {
                CHANNEL_MAPPING_ELEMENT aRec = (CHANNEL_MAPPING_ELEMENT)MappingElementRecords[iChanId];
                this.ListViewMapping.Items.Add(aRec.iChannNdx.ToString());           

                UpdateChannelColumn(aRec, iChanId);
                UpdateTypeColumn(aRec, iChanId);
                UpdateUnitColumn(aRec, iChanId);
            }
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateChannelColumn >
        /// 
        /// History: 07-May-13, BEttinger, WI30488: to present the channel map 
        /// ]]>
        /// <summary>
        /// Updating Channel Column
        /// </summary>
        private void UpdateChannelColumn(CHANNEL_MAPPING_ELEMENT aRec, int iChanId)
        {
            TextBox tBox = new TextBox();
            tBox.Text = aRec.iChannNdx.ToString();
            tBox.ReadOnly = true;

            this.ListViewMapping.Items[iChanId].SubItems[0].Control = tBox;
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateTypeColumn >
        /// 
        /// History: 07-May-13, BEttinger, WI30488: to present the channel map 
        /// ]]>
        /// <summary>
        /// Updating  Type Column
        /// </summary>
        private void UpdateTypeColumn(CHANNEL_MAPPING_ELEMENT aRec, int iChanId)
        {
            ComboBox cTypeBox = new ComboBox();
            cTypeBox.Items.Add("NA");
            cTypeBox.Items.Add("DRY");
            cTypeBox.Items.Add("FRQ");

            for (int iCnt = 0; iCnt < cTypeBox.Items.Count; iCnt++)
            {
                if (aRec.strChannType == (string)cTypeBox.Items[iCnt])            
                {
                    cTypeBox.SelectedIndex = iCnt;
                    break;
                }
            }


            cTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ListViewMapping.Items[iChanId].SubItems[1].Control = cTypeBox;

            //this.ListViewMapping.Items[iChanId].SubItems[1].Control.TextChanged += new EventHandler(cTypeBox_SelectedValueChanged);

            cTypeBox.SelectedValueChanged += new EventHandler(cTypeBox_SelectedValueChanged);
        }

        /// <![CDATA[
        /// 
        /// Function: UpdateTypeColumn >
        /// 
        /// History: 07-May-13, BEttinger, WI30488: to present the channel map 
        /// ]]>
        /// <summary>
        /// Updating  Type Column
        /// </summary>
        private void UpdateUnitColumn(CHANNEL_MAPPING_ELEMENT aRec, int iChanId)
        {
            ComboBox cUnitBox = new ComboBox();

            cUnitBox.Items.Add("NA");

            if (null != m_press)
            {
                int iTotalUnits = m_press.TotalUnits;
                for (int iUnit = 0; iUnit < iTotalUnits; iUnit++)
                {
                    MCPressUnit mcUnit = m_press.GetUnitAt(iUnit);
                    if (mcUnit == null)
                        continue;
                    cUnitBox.Items.Add(mcUnit.UnitName);
                }
            }

            for (int iCnt = 0; iCnt < cUnitBox.Items.Count; iCnt++)
            {
                if (aRec.stUnitName == (string)cUnitBox.Items[iCnt])
                {
                    cUnitBox.SelectedIndex = iCnt;
                    break;
                }
            }

            cUnitBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ListViewMapping.Items[iChanId].SubItems[2].Control = cUnitBox;

            //this.ListViewMapping.Items[iChanId].SubItems[2].Control.TextChanged += new EventHandler(cUnitBox_SelectedValueChanged);

            cUnitBox.SelectedValueChanged += new EventHandler(cUnitBox_SelectedValueChanged);
        }

        /// <![CDATA[
        /// 
        /// Function: cTypeBox_SelectedValueChanged
        /// 
        /// History: 07-May-13, BEttinger, WI30488: to present and use the channel map 
        /// ]]>
        /// <summary>
        /// cTypeBox_SelectedValueChanged event processor
        /// </summary>
        void cTypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            m_bIsListViewDataChanged = true;

            ComboBox cbType = (ComboBox)sender;
            if((cbType.Text == "DRY") && (Convert.ToByte(this.comboAutoZeroMode.SelectedIndex) == 1))
            {//error
                string strTmp = "Selected channel type DRY is invalid for the Auto Zero mode." ;
                MessageBox.Show(strTmp);
                m_bIsListViewDataChanged = false;
            }
            else if((cbType.Text == "FRQ") && (Convert.ToByte(this.comboAutoZeroMode.SelectedIndex) == 0))
            {//error
                string strTmp = "Selected channel type FRQ is invalid for the Auto Zero mode.";
                MessageBox.Show(strTmp);
                m_bIsListViewDataChanged = false;
            }
                        
            CheckInputData(); 
        }

        /// <![CDATA[
        /// 
        /// Function: cUnitBox_SelectedValueChanged
        /// 
        /// History: 07-May-13, BEttinger, WI30488: to present and use the channel map 
        /// ]]>
        /// <summary>
        /// cUnitBox_SelectedValueChanged event processor
        /// </summary>
        void cUnitBox_SelectedValueChanged(object sender, EventArgs e)
        {
            m_bIsListViewDataChanged = true;
            CheckInputData();
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Update new parameter TimeDelayToCloseFountain with UI data
        /// 
        /// ]]>
        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            this.m_press.PressAutoZero.AutoZeroEnabled = this.checkAutoZero.Checked;
            this.m_press.PressAutoZero.Mode = Convert.ToByte( this.comboAutoZeroMode.SelectedIndex );
            this.m_press.PressAutoZero.DeviceIPAddress = this.textDeviceIPAddress.Text;
            this.m_press.PressAutoZero.DeviceID = Convert.ToByte( this.textDeviceID.Text );
            this.m_press.PressAutoZero.TimeDelay = Convert.ToInt32( this.textTimeDelay.Text );
            this.m_press.PressAutoZero.PollTimePeriod = Convert.ToInt32( this.textPollPeriod.Text );
            this.m_press.PressAutoZero.FactorFrequency = Convert.ToInt32( this.textFactorFrequency.Text );
            this.m_press.PressAutoZero.IdleThresholdFPM = Convert.ToInt32( this.textIdleThresholdFPM.Text );
            this.m_press.PressAutoZero.DryContactIdleState = Convert.ToBoolean( this.comboDryContactIdleFpm.SelectedIndex );             
            this.m_press.PressAutoZero.TimeDelayToCloseFountain = Convert.ToInt32( this.textTimeDelayToCloseFountain.Text );
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         07-May-13, BEttinger, WI30488: Update ADAM channel mapping with data configured with the ListView (multiple source Auto Zero)
        /// 
        /// ]]>
        /// <summary>
        /// Updates the data from channel mapping ListView on OK button pressed.
        /// </summary>

        private void UpdateDataFromListView()
        {
            GetDataFromMappingListView(); //get data from Mapping ListView fields to MappingElementRecords


                //clear the m_dicAZchannelMap_Dry and m_dicAZchannelMap_Frq maps
            this.m_press.PressAutoZero.DryChannelsMap.Clear();   
            this.m_press.PressAutoZero.FrqChannelsMap.Clear();   
                //again loop over MappingElementRecords and update the maps with ListView settings (report possible deficiences left) 
            for (int iChanId = 0; iChanId < MappingElementRecords.Count; ++iChanId)
            {
                CHANNEL_MAPPING_ELEMENT aRec = (CHANNEL_MAPPING_ELEMENT)MappingElementRecords[iChanId];
                if(aRec.strChannType.Equals("DRY"))
                {
                    if (aRec.stUnitName.Equals("NA"))
                    {
                                //error
                        string strTmp = "Unit is Not Asigned for the Dry Contact channnel. " + "Channel Id = " + iChanId.ToString();
                        MessageBox.Show(strTmp);
                    }
                    else
                    {
                        this.m_press.PressAutoZero.DryChannelsMap.Add((byte)iChanId, aRec.stUnitName); 
                    }
                }
                else if (aRec.strChannType.Equals("FRQ"))
                {
                    if (aRec.stUnitName.Equals("NA"))
                    {
                                //error
                        string strTmp = "Unit is Not Asigned for the Frequency channnel. " + "Channel Id = " + iChanId.ToString();
                        MessageBox.Show(strTmp);
                    }
                    else
                    {
                        this.m_press.PressAutoZero.FrqChannelsMap.Add((byte)iChanId, aRec.stUnitName);
                    }
                }
                else if ( aRec.strChannType.Equals("NA") && (this.m_press.PressAutoZero.Mode == 2) && !aRec.stUnitName.Equals("NA") )
                {
                        //error
                    string strTmp = "Auto Zero combo mode: channel Type is Not Asigned for the Unit. " + "Channel Id = " + iChanId.ToString();
                    MessageBox.Show(strTmp);
                }
                else if (aRec.strChannType.Equals("NA") && (this.m_press.PressAutoZero.Mode == 0) && !aRec.stUnitName.Equals("NA"))
                {
                    aRec.strChannType = "DRY";//assign DRY channel type
                    this.ListViewMapping.Items[iChanId].SubItems[1].Control.Text = "DRY";
                    this.m_press.PressAutoZero.DryChannelsMap.Add((byte)iChanId, aRec.stUnitName);
                }
                else if (aRec.strChannType.Equals("NA") && (this.m_press.PressAutoZero.Mode == 1) && !aRec.stUnitName.Equals("NA"))
                {
                    aRec.strChannType = "FRQ";//assign FRQ channel type
                    this.ListViewMapping.Items[iChanId].SubItems[1].Control.Text = "FRQ";
                    this.m_press.PressAutoZero.FrqChannelsMap.Add((byte)iChanId, aRec.stUnitName);
                }
            }//for()

            this.m_press.PressAutoZero.NumberOfDrySensors = this.m_press.PressAutoZero.DryChannelsMap.Count;
            this.m_press.PressAutoZero.NumberOfFrequencySensors = this.m_press.PressAutoZero.FrqChannelsMap.Count;
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         09-May-13, BEttinger, WI30488: Get ADAM channel mapping data from the ListView (multiple source Auto Zero)
        /// 
        /// ]]>
        /// <summary>
        /// Gets the data from channel mapping ListView to MappingElementRecords on OK button pressed.
        /// </summary>

        private void GetDataFromMappingListView()
        {
            MappingElementRecords.Clear();
            for (int iNdx = 0; iNdx < ListViewMapping.Items.Count; ++iNdx)
            {
                CHANNEL_MAPPING_ELEMENT aRec = new CHANNEL_MAPPING_ELEMENT();

                //channel index
                aRec.iChannNdx = Convert.ToInt32(this.ListViewMapping.Items[iNdx].SubItems[0].Control.Text);
                //channel type
                aRec.strChannType = this.ListViewMapping.Items[iNdx].SubItems[1].Control.Text;
                //unit name
                aRec.stUnitName = this.ListViewMapping.Items[iNdx].SubItems[2].Control.Text;
                MappingElementRecords.Add(aRec);
            }
        }


        /// <summary>
        /// Handles the CheckedChanged event of the checkAutoZero control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void checkAutoZero_CheckedChanged(object sender, EventArgs e)
        {
            this.groupAutoZeroSettings.Enabled = this.checkAutoZero.Checked;
            this.groupBoxChannMap.Enabled = this.checkAutoZero.Checked;//WI30488 
        }

        /// <summary>
        /// Handles the TextChanged event of the textDeviceIPAddress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textDeviceIPAddress_TextChanged(object sender, EventArgs e)
        {
            CheckInputData();            
        }

        /// <summary>
        /// Handles the TextChanged event of the textDeviceID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textDeviceID_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");            
            if (!regex.IsMatch(this.textDeviceID.Text))
            {
                this.textDeviceID.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(textDeviceID.Text))
                {
                    byte value = Convert.ToByte(textDeviceID.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_DEVICE_ID_MAX) ||
                         (value < 0))
                    {
                        this.textDeviceID.Text = "0";
                        MessageBox.Show("Device ID: valid range: 0 to 10");
                    }
                }
            }
            CheckInputData();
        }

        /// <summary>
        /// Handles the TextChanged event of the textTimeDelay control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textTimeDelay_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textTimeDelay.Text))
            {
                this.textTimeDelay.Text = "0";
            }            
            else
            {
                if (!string.IsNullOrEmpty(textTimeDelay.Text))
                {
                    int value = Convert.ToInt32(textTimeDelay.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_TIME_DELAY) ||
                         (value < 0))
                    {
                        this.textTimeDelay.Text = "0";
                        MessageBox.Show("Time Delay: valid range: 0 to 10000 msec");
                    }
                }
            }
            CheckInputData();
        }

        /// <summary>
        /// Handles the TextChanged event of the textPollPeriod control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textPollPeriod_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textPollPeriod.Text))
            {
                this.textPollPeriod.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(textPollPeriod.Text))
                {
                    int value = Convert.ToInt32(textPollPeriod.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_POLL_PERIOD) ||
                         (value < 0))
                    {
                        this.textPollPeriod.Text = "0";
                        MessageBox.Show("Poll period: valid range: 0 to 10000 msec");
                    }
                }
            }
            CheckInputData();
        }

        /// <summary>
        /// Handles the TextChanged event of the textFactorFrequency control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textFactorFrequency_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textFactorFrequency.Text))
            {
                this.textFactorFrequency.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(textFactorFrequency.Text))
                {
                    int value = Convert.ToInt32(textFactorFrequency.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_FACTOR_FREQUENCY) ||
                         (value < 0))
                    {
                        this.textFactorFrequency.Text = "0";
                        MessageBox.Show("Factor Frequency: valid range: 0 to 10000");
                    }
                }
            }
            CheckInputData();
        }

        /// <summary>
        /// Handles the TextChanged event of the textIdleThresholdFPM control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textIdleThresholdFPM_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textIdleThresholdFPM.Text))
            {
                this.textIdleThresholdFPM.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(textIdleThresholdFPM.Text))
                {
                    int value = Convert.ToInt32(textIdleThresholdFPM.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_IDLE_THRESHOLD_FPM) ||
                         (value < 0))
                    {
                        this.textIdleThresholdFPM.Text = "0";
                        MessageBox.Show("Idle Threshold FPM: valid range: 0 to 1000");
                    }
                }
            }
            CheckInputData();
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Validate parameter textTimeDelayToCloseFountain
        /// 
        /// ]]>
        /// <summary>
        /// Handles the TextChanged event of the textTimeDelayToCloseFountain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textTimeDelayToCloseFountain_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textTimeDelayToCloseFountain.Text))
            {
                this.textTimeDelayToCloseFountain.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(textTimeDelayToCloseFountain.Text))
                {
                    int value = Convert.ToInt32(textTimeDelayToCloseFountain.Text);
                    if ( (value > PressAutoZeroParameterValidRange.AZ_TIME_DELAY_CLOSE_FOUNTAIN) ||
                         (value < 0))
                    {
                        this.textTimeDelayToCloseFountain.Text = "0";
                        MessageBox.Show("Time Delay for Fountain Close: valid range: 0 to 600000");
                    }
                }
            }
            CheckInputData();
        }

        /// <![CDATA[
        /// 
        /// History: 
        ///         10-Sep-12, Mark C, WI 29423: Validate parameter textTimeDelayToCloseFountain
        /// 
        /// ]]>        
        /// <summary>
        /// Checks the input data.
        /// </summary>
        private void CheckInputData()
        {
            bool validData = false;            

            if( !string.IsNullOrEmpty(textDeviceIPAddress.Text) &&
                !string.IsNullOrEmpty(textDeviceID.Text) &&
                !string.IsNullOrEmpty(textTimeDelay.Text) &&
                !string.IsNullOrEmpty(textPollPeriod.Text) &&
                !string.IsNullOrEmpty(textFactorFrequency.Text) && 
                !string.IsNullOrEmpty(textIdleThresholdFPM.Text) &&
                !string.IsNullOrEmpty(textTimeDelayToCloseFountain.Text) )                
            {
                validData = true;
            }

            if (m_bIsListViewDataChanged == false)//WI30488
            {
                validData = false;
            }

            
            this.btnOK.Enabled = validData;
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // update Press data with PressAutoZero settings
            UpdateDataFromGUI();
            UpdateDataFromListView();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region members
        private MCPressInfo m_press;
        #endregion


    }
}
