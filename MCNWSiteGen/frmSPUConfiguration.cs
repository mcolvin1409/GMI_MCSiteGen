/////////////////////////////////////////////////////////////////////////////
//  
// frmSPUConfiguration.cs - SPU Configuration details - Form 
//
//  Author:	Mark C Babu.D.V.
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MC3Components.Controls;
using System.Reflection;


namespace MCNWSiteGen
{

    public partial class frmSPUConfiguration : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSPUConfiguration"/> class.
        /// </summary>
        /// <param name="newFile">if set to <c>true</c> [new file].</param>
        /// <param name="press">The press.</param>
        public frmSPUConfiguration(bool newFile, MCPressInfo press)
        {
            InitializeComponent();
            m_press = press;
            m_newFile = newFile;
        }

        /// <summary>
        /// Handles the Load event of the SPUConfigForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SPUConfigForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 45);
            AddSPUConfigHeader();
            LoadSPUConfigDetails();            
        }

        /// <summary>
        /// Adds the spu configuration header.
        /// </summary>
        /// <history>
        ///     03-Sept-14, Mark C, WI40392: Added a new column COMM Type to select
        ///         the communication interface type between SPU3 and Server
        /// </history>
        private void AddSPUConfigHeader()
        {

            // SPU Name
            MC3Column spuName = new MC3Column();
            spuName.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            spuName.Name = "SPUName";
            spuName.Text = "SPU Name";
            spuName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            spuName.Width = 150;

            // Communication Interface Type
            MC3Column interfaceType = new MC3Column();
            interfaceType.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            interfaceType.Name = "SPUCOMMType";
            interfaceType.Text = "COMM Type";
            interfaceType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            interfaceType.Width = 120;

            // SPU COMM port
            MC3Column spuCOMM = new MC3Column();
            spuCOMM.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            spuCOMM.Name = "SPUCOMM";
            spuCOMM.Text = "COM Port";
            spuCOMM.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            spuCOMM.Width = 120;

            // SPU3 IP Address
            MC3Column spuIPAddress = new MC3Column();
            spuIPAddress.ActivatedEmbeddedType = MC3Components.Controls.GLActivatedEmbeddedTypes.None;
            spuIPAddress.Name = "SPUIPAddress";
            spuIPAddress.Text = "PRESSNET IP Address";
            spuIPAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            spuIPAddress.Width = 160;

            this.m_spuConfigListViewCtrl.Columns.AddRange(new MC3Components.Controls.MC3Column[] { spuName, interfaceType, spuCOMM, spuIPAddress });            

        }

        /// <summary>
        /// Loads the spu configuration details.
        /// </summary>
        /// <history>
        ///     03-Sept-14, Mark C, WI40392: Added support to select the COMM Type
        /// </history>
        private void LoadSPUConfigDetails()
        {
            int spuCount = m_press.GetTotalSPUS();
            for (int spuIndex = 0; spuIndex < spuCount; ++spuIndex)
            {
                string spuName = m_press.SPU(spuIndex).SPUName;
                string comPort = m_press.SPU(spuIndex).SPUCommPort;
                string ipAddress = m_press.SPU(spuIndex).IPAddress;
                string commType = m_press.SPU(spuIndex).COMMType;
                AddRecord(spuIndex, new PressSPU(spuName, commType, comPort, ipAddress) );
            }

            if (spuCount > 0)
            {
                this.m_spuConfigListViewCtrl.Items[0].Selected = true;
            }

            maxFountainPortComboBox.Text = m_press.MaxFountainPortCountPerSPU.ToString();
        }

        /// <summary>
        /// Gets the index of the next record.
        /// </summary>
        /// <returns></returns>
        private int GetNextRecordIndex()
        {
            return this.m_spuConfigListViewCtrl.Items.Count;
        }

        /// <summary>
        /// Handles the Click event of the butAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        private void butAdd_Click(object sender, EventArgs e)
        {
            int spuCount = this.m_spuConfigListViewCtrl.Items.Count;
            if (spuCount >= DefineAndConst.SystemCapacities.MAX_SPUS_PER_AS)
            {
                MessageBox.Show(string.Format("The Number of SPU range is: 1 - {0}", DefineAndConst.SystemCapacities.MAX_SPUS_PER_AS));
                return;
            }

            string spuName = string.Format("SPU{0}", GetNextRecordIndex()+1);

            int currentIndex = GetNextRecordIndex();
            string commType = GetDefaultCOMMType();
            string comPortName = string.Empty;

            if ( string.Compare(commType, CommType.Serial, true) == 0 )
            {
                comPortName = GetNextCOMMPort();
            }

            AddRecord(currentIndex, new PressSPU(spuName, commType, comPortName, GetDefaultIPAddress())); 
            
            this.m_spuConfigListViewCtrl.Items[currentIndex].Selected = true;
            this.m_spuConfigListViewCtrl.Refresh();
        }

        /// <summary>
        /// Gets the next comm port.
        /// </summary>
        /// <returns></returns>
        private string GetNextCOMMPort()
        {            
            int comPortIndex = 0;
                        
            foreach (PressSPU spuConfig in m_spuConfigDetails)
            {
                if ( string.Compare( spuConfig.COMMType, CommType.Serial, true) == 0 )
                {
                    if (!string.IsNullOrEmpty(spuConfig.SPUCommPort))
                    {
                        int index = Convert.ToInt32(spuConfig.SPUCommPort.Substring(3));
                        comPortIndex = Math.Max(index, comPortIndex);
                    }
                }
            }

            string commPort = string.Format("COM{0}", StartingCOMMPort);
            if (comPortIndex != 0)
            {
                commPort = string.Format("COM{0}", comPortIndex + 1);
            }
            
            return commPort;
        }


        /// <summary>
        /// Gets the default ip address.
        /// </summary>
        /// <returns></returns>
        private string GetDefaultIPAddress()
        {
            return "0.0.0.0";
        }

        /// <summary>
        /// Gets the default type of the communication.
        /// </summary>
        /// <returns></returns>
        private string GetDefaultCOMMType()
        {
            return CommType.Serial;
        }


        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="spuConfig">The spu configuration.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>  
        private void AddRecord( int index, PressSPU spuConfig )
        {
            AddSPUName(index, spuConfig.SPUName);
            AddCOMMType(index, spuConfig.COMMType);
            AddCOMMName(index, spuConfig.SPUCommPort, (spuConfig.COMMType == CommType.Serial) );
            AddIPAddress(index, spuConfig.IPAddress);
            m_spuConfigDetails.Add(spuConfig);
        }

        /// <summary>
        /// Adds the name of the spu.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="spuName">Name of the spu.</param>
        private void AddSPUName(int index, string spuName)
        {
            this.m_spuConfigListViewCtrl.Items.Add(spuName);  
        }

        /// <summary>
        /// Adds the type of the comm.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="commType">Type of the comm.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>      
        private void AddCOMMType(int index, string commType)
        {
            ComboBox commTypeComboBox = new ComboBox();
            commTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // add the type of communications available
            commTypeComboBox.Items.Add(CommType.Ethernet);
            commTypeComboBox.Items.Add(CommType.Serial);

            commTypeComboBox.SelectedIndexChanged += new System.EventHandler(SPUCommType_SelectedIndexChanged);
            this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COMM_TYPE].Control = commTypeComboBox;

            if (commTypeComboBox.Items.Contains(commType))
            {
                commTypeComboBox.SelectedItem = commType;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the SPUCommType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        private void SPUCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox commComboBox = sender as ComboBox;
            if (commComboBox != null)
            {
                FieldInfo fld = typeof(ComboBox).GetField("currentText", BindingFlags.Instance | BindingFlags.NonPublic);
                string previousSelectedTex = fld.GetValue(commComboBox).ToString();
                string selectedCOMMType = commComboBox.SelectedItem as string;
                
                if (!string.IsNullOrEmpty(previousSelectedTex) &&
                    !string.IsNullOrEmpty(selectedCOMMType))
                {
                    // Is selection changed?
                    if (previousSelectedTex != selectedCOMMType)
                    {
                        string spuName = GetSPUNameByCOMMType(commComboBox);
                        UpdateCOMControl(spuName, selectedCOMMType);
                        UpdateCOMMType(spuName, selectedCOMMType);
                    }
                }
            }

        }



        /// <summary>
        /// Adds the name of the comm.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="comPortName">Name of the COM port.</param>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        private void AddCOMMName(int index, string comPortName, bool enabled)
        {
            ComboBox commComboBox = new ComboBox();
            commComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int commIndex = 2; commIndex < 255; ++commIndex)
            {
                string commName = string.Format("COM{0}", commIndex);
                commComboBox.Items.Add(commName);
            }

            if (!string.IsNullOrEmpty(comPortName))
            {
                commComboBox.SelectedItem = comPortName;                
            }

            commComboBox.Enabled = enabled;

            commComboBox.SelectedIndexChanged += new System.EventHandler(SPUCommPort_SelectedIndexChanged);
            this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COM_PORT].Control = commComboBox;
            
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the SPUCommPort control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        private void SPUCommPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox commComboBox = sender as ComboBox;
            if (commComboBox != null)
            {
                FieldInfo fld = typeof(ComboBox).GetField("currentText", BindingFlags.Instance | BindingFlags.NonPublic);
                string previousSelectedTex = fld.GetValue(commComboBox).ToString();
                string selectedCOMMPort = commComboBox.SelectedItem as string;
                // Is selection changed?
                if (previousSelectedTex != selectedCOMMPort)
                {
                    if (!IsCOMMAssigned(selectedCOMMPort))
                    {
                        string spuName = GetSPUNameByCOMPort(commComboBox);
                        UpdateCOMMPort(spuName, selectedCOMMPort);
                    }
                    else
                    {                        
                        MessageBox.Show("The selected COMM Port is already assigned. Please select other COMM Port.");
                        commComboBox.SelectedItem = previousSelectedTex;
                    }
                }
            }

        }


        /// <summary>
        /// Updates the comm port.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="newCOMMSelection">The new comm selection.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>     
        private void UpdateCOMMPort(string spuName, string newCOMMSelection)
        {
            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
                if (string.Compare(spuDetails.SPUName, spuName, true) == 0)
                {
                    spuDetails.SPUCommPort = newCOMMSelection;
                    break;
                }
            }
        }

        /// <summary>
        /// Updates the type of the comm.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="commType">Type of the comm.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>             
        private void UpdateCOMMType(string spuName, string commType)
        {
            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
 //               if (string.Compare(spuDetails.COMMType, "Ethernet", true) == 0)     //chg MAX fountains per SPU to 8, if Ethernet
 //                   m_press.MaxFountainPortCountPerSPU = 8;
                maxFountainPortComboBox.Text = m_press.MaxFountainPortCountPerSPU.ToString();

                if (string.Compare(spuDetails.SPUName, spuName, true) == 0)
                {
                    spuDetails.COMMType = commType;
                    break;
                }
            }
        }


        /// <summary>
        /// Determines whether [is comm assigned] [the specified comm port].
        /// </summary>
        /// <param name="commPort">The comm port.</param>
        /// <returns></returns>
        private bool IsCOMMAssigned(string commPort)
        {
            bool result = false;

            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
                if (string.Compare(spuDetails.SPUCommPort, commPort, true) == 0)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Adds the ip address.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="spuIPAddress">The spu ip address.</param>
        private void AddIPAddress(int index, string spuIPAddress)
        {
            TextBox ipAddress = new TextBox();
            ipAddress.Text = spuIPAddress;

            ipAddress.Leave += new System.EventHandler(SPUIPAddress_Leave);
            this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_IPADDRESS].Control = ipAddress;
        }

        /// <summary>
        /// Handles the Leave event of the SPUIPAddress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>   
        private void SPUIPAddress_Leave(object sender, EventArgs e)
        {
            TextBox ipAddressTextBox = sender as TextBox;
            if (ipAddressTextBox != null)
            {
                System.Net.IPAddress IPAddress;
                if ( !string.IsNullOrEmpty(ipAddressTextBox.Text) &&
                     System.Net.IPAddress.TryParse(ipAddressTextBox.Text.Trim(), out IPAddress) )
                {
                    if( IPAddress != null )
                    {
                        string newIPAddress = IPAddress.ToString();
                        string spuName = GetSPUNameByIPAddress(ipAddressTextBox);

                        if (string.Compare(newIPAddress, GetDefaultIPAddress(), true) != 0)
                        {                            
                            if (!IsDuplicateIPAddress(spuName, newIPAddress))
                            {
                                UpdateIPAddress(spuName, newIPAddress);
                                ipAddressTextBox.Text = newIPAddress;
                            }
                            else
                            {
                                MessageBox.Show("Duplicate IP Address. Please input valid IP Address.");
                                ipAddressTextBox.Undo();
                            }
                        }
                        else
                        {
                            UpdateIPAddress(spuName, newIPAddress);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid IP Address. Please input valid IP Address.");
                    ipAddressTextBox.Undo();
                }
            }
        }

        /// <summary>
        /// Determines whether [is duplicate ip address] [the specified spu name].
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns></returns>
        private bool IsDuplicateIPAddress(string spuName, string ipAddress)
        {
            bool result = false;

            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
                if (string.Compare(spuDetails.SPUName, spuName, true) != 0)
                {
                    if (string.Compare(spuDetails.IPAddress, ipAddress, true) == 0)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the spu name for.
        /// </summary>
        /// <param name="ipAddressTextBox">The ip address text box.</param>
        /// <returns></returns>
        private string GetSPUNameByIPAddress(TextBox ipAddressTextBox)
        {
            int count = this.m_spuConfigListViewCtrl.Items.Count;
            
            string spuName = string.Empty;
            for(int index = 0; index < count; ++index)
            {
                if (this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_IPADDRESS].Control is TextBox)
                {
                    TextBox control = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_IPADDRESS].Control as TextBox;
                    if ( (control != null) && ( ipAddressTextBox == control ) )
                    {
                        spuName = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_NAME].Text;
                        break;
                    }
                }
            }

            return spuName;
        }

        /// <summary>
        /// Gets the spu name by COM port.
        /// </summary>
        /// <param name="comPortComboBox">The COM port ComboBox.</param>
        /// <returns>The Name of the SPU</returns>
        /// <history>
        ///     03-Sept-14, WI40392: Created
        /// </history>
        private string GetSPUNameByCOMPort(ComboBox comPortComboBox)
        {
            int count = this.m_spuConfigListViewCtrl.Items.Count;

            string spuName = string.Empty;
            for (int index = 0; index < count; ++index)
            {
                if (this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COM_PORT].Control is ComboBox)
                {
                    ComboBox control = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COM_PORT].Control as ComboBox;
                    if ((control != null) && (comPortComboBox == control))
                    {
                        spuName = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_NAME].Text;
                        break;
                    }
                }
            }

            return spuName;
        }


        /// <summary>
        /// Gets the type of the spu name by comm.
        /// </summary>
        /// <param name="commTypeComboBox">The comm type ComboBox.</param>
        /// <returns>The Name of the SPU</returns>
        /// <history>
        ///     03-Sept-14, WI40392: Created
        /// </history>
        private string GetSPUNameByCOMMType(ComboBox commTypeComboBox)
        {
            int count = this.m_spuConfigListViewCtrl.Items.Count;

            string spuName = string.Empty;
            for (int index = 0; index < count; ++index)
            {
                if (this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COMM_TYPE].Control is ComboBox)
                {
                    ComboBox control = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COMM_TYPE].Control as ComboBox;
                    if ((control != null) && (commTypeComboBox == control))
                    {
                        spuName = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_NAME].Text;
                        break;
                    }
                }
            }

            return spuName;
        }


        /// <summary>
        /// Updates the COM control.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="commType">Type of the comm.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>
        private void UpdateCOMControl(string spuName, string commType)
        {
            int count = this.m_spuConfigListViewCtrl.Items.Count;
                        
            for (int index = 0; index < count; ++index)
            {
                if (this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_NAME].Text == spuName)
                {
                    ComboBox comPortControl = this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_COM_PORT].Control as ComboBox;
                    if (comPortControl != null)
                    {
                        comPortControl.Enabled = (commType == CommType.Serial);
                        string nextCOMPort = string.Empty;

                        if ( string.Compare( commType, CommType.Serial, true) == 0 )
                        {
                            nextCOMPort = GetNextCOMMPort();
                            if (!string.IsNullOrEmpty(nextCOMPort))
                            {
                                comPortControl.SelectedItem = nextCOMPort;
                            }
                        }
                        else
                        {
                            comPortControl.SelectedIndex = -1;
                        }

                        UpdateCOMMPort(spuName, nextCOMPort);
                    }

                    break;
                }
            }
        }

        
        /// <summary>
        /// Updates the ip address.
        /// </summary>
        /// <param name="spuName">Name of the spu.</param>
        /// <param name="newIPAddress">The new ip address.</param>
        private void UpdateIPAddress(string spuName, string newIPAddress)
        {
            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
                if (string.Compare(spuDetails.SPUName, spuName, true) == 0)
                {
                    spuDetails.IPAddress = newIPAddress;
                    break;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the butRemove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void butRemove_Click(object sender, EventArgs e)
        {
            if (this.m_spuConfigListViewCtrl.SelectedItems.Count > 0)
            {
                int selectedIndex = Convert.ToInt32(this.m_spuConfigListViewCtrl.SelectedIndicies[0]);
                this.m_spuConfigListViewCtrl.Items.RemoveAt(selectedIndex);
                m_spuConfigDetails.RemoveAt(selectedIndex);
                if (selectedIndex > 0)
                {
                    this.m_spuConfigListViewCtrl.Items[selectedIndex - 1].Selected = true;
                }
                else if ((selectedIndex == 0) &&
                          (this.m_spuConfigListViewCtrl.Items.Count > 0))
                {
                    this.m_spuConfigListViewCtrl.Items[selectedIndex].Selected = true;
                }

                // generate SPU names after deleting a record
                RefreshSPUConfiguration(selectedIndex);

                this.m_spuConfigListViewCtrl.Refresh();
            }
        }

        /// <summary>
        /// Refreshes the spu configuration.
        /// </summary>
        /// <param name="selectedIndex">Index of the selected.</param>
        private void RefreshSPUConfiguration(int selectedIndex)
        {
            if (m_spuConfigDetails.Count > 0)
            {
                for (int index = selectedIndex; index < m_spuConfigDetails.Count; ++index)
                {
                    string spuName = string.Format("SPU{0}", (index + 1));
                    m_spuConfigDetails[index].SPUName = spuName;
                    this.m_spuConfigListViewCtrl.Items[index].SubItems[SPU_NAME].Text = spuName;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Validate the IP Address before saving the data.
        /// </history>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ( !IsIPAddressValid() )
            {
                MessageBox.Show("Input Valid IP Address");
                return;
            }

            SaveSPUData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Determines whether [is ip address valid].
        /// </summary>
        /// <returns>
        ///     true - if IP Addresses are valid, otheriwse 'false'
        /// </returns>
        /// <history>
        ///     03-Sept-14, WI40392: Created
        /// </history>
        private bool IsIPAddressValid()
        {
            bool validData = true;

            foreach (PressSPU spuDetails in m_spuConfigDetails)
            {
                if (null != spuDetails)
                {
                    if (string.Compare(spuDetails.COMMType, CommType.Ethernet, true) == 0)
                    {
                        string defaultIP = GetDefaultIPAddress();
                        if (string.Compare(spuDetails.IPAddress, defaultIP, true) == 0)
                        {
                            validData = false;
                            break;
                        }
                    }
                }
            }
                        
            return validData;
        }

        /// <![CDATA[
        ///
        /// Author: someone
        /// 
        /// History: 23-Nov-15, Mark C, WI63659: Consider change in port count per SPU as a change in SPU data.
        /// 
        /// ]]>
        /// <summary>
        /// Saves the spu data.
        /// </summary>
        private void SaveSPUData()
        {
            int oldSPUCount = m_press.GetTotalSPUS();
            int newSPUCount = this.m_spuConfigListViewCtrl.Items.Count;

            byte oldMaxFountainPortCount = m_press.MaxFountainPortCountPerSPU;
            byte newMaxFountainPortCount = Convert.ToByte(maxFountainPortComboBox.Text);

            if (oldSPUCount != newSPUCount) 
            {
                m_dataChanged = true;
                m_press.InitTotalSPUS(newSPUCount);                                
            }

            if (oldMaxFountainPortCount != newMaxFountainPortCount)
            {
                m_press.MaxFountainPortCountPerSPU = newMaxFountainPortCount;
                m_dataChanged = true;
            }

            UpdateSPUData(newSPUCount);
            MessageBox.Show("SPU data updated successfully");
        }

        /// <summary>
        /// Updates the spu data.
        /// </summary>
        /// <param name="newSPUCount">The new spu count.</param>
        /// <history>
        ///     03-Sept-14, WI40392: Added support for selecting COMM Type
        /// </history>   
        private void UpdateSPUData(int newSPUCount)
        {
            for ( int spuIndex = 0; spuIndex < newSPUCount; ++spuIndex )
            {
                PressSPU pressSPU = m_press.SPU(spuIndex);
                if (pressSPU != null)
                {
                    pressSPU.SPUName = m_spuConfigDetails[spuIndex].SPUName;
                    pressSPU.SPUCommPort = m_spuConfigDetails[spuIndex].SPUCommPort;
                    pressSPU.IPAddress = m_spuConfigDetails[spuIndex].IPAddress;
                    pressSPU.COMMType = m_spuConfigDetails[spuIndex].COMMType;

 //                   if (string.Compare(pressSPU.COMMType, "Ethernet", true)==0)     //chg MAX fountains per SPU to 8, if Ethernet
//                        m_press.MaxFountainPortCountPerSPU = 8;
                    maxFountainPortComboBox.Text = m_press.MaxFountainPortCountPerSPU.ToString();
                }
            }

            m_press.AutoTest.TotalSpusToTest = newSPUCount;
            m_press.SweepTest.TotalSpusToTest = newSPUCount;            
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gets a value indicating whether [data changed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [data changed]; otherwise, <c>false</c>.
        /// </value>
        public bool DataChanged
        {
            get { return m_dataChanged; }
        }

        #region Implementation

        private List<PressSPU> m_spuConfigDetails = new List<PressSPU>();
        private MCPressInfo m_press = new MCPressInfo();
        private bool m_newFile = false;        
        private const int SPU_NAME = 0, SPU_COMM_TYPE = 1, SPU_COM_PORT = 2, SPU_IPADDRESS = 3;
        private const int StartingCOMMPort = 5;
        private bool m_dataChanged = false;

        #endregion

    }
    
}
