/////////////////////////////////////////////////////////////////////////////
//  
// FormWebConfigWizard.cs: Used to configure Multi Web details, like number of webs,
//      number of Airbars and location of Airbars.
//
// Author:	Mark C Babu DV
//
// $Header:   
//
// $Log:   
//
/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MCNWSiteGen
{
    public partial class FormWebConfigWizard : Form
    {

        #region implementation
        MCPressInfo m_press;
        Dictionary<string, string> m_airbarDetails;
        int m_airbarCount = 1;
        int m_webCount = 2;
        #endregion

        /// <summary>
        /// Class to hold parameter limits
        /// </summary>
        private class WebConfigParameterValidRange
        {
            public const int WC_MAX_WEBS = 20;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormWebConfigWizard"/> class.
        /// </summary>
        /// <param name="press">The press.</param>
        public FormWebConfigWizard(MCPressInfo press)
        {
            this.m_press = press;
            this.m_airbarDetails = new Dictionary<string, string>();            
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the FormWebConfigWizard control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormWebConfigWizard_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 200, Location.Y + 35);
            UpdateDataToGUI();
        }

        /// <summary>
        /// Updates the data to GUI.
        /// </summary>
        private void UpdateDataToGUI()
        {   
            UpdateAirbarListBox();
            UpdateUnitComboBox();            
            this.textBoxNumOfWebs.Text = m_press.TotalNumberOfWebs.ToString();
            if (m_press.AirbarList.Count > 0)
            {
                this.textBoxNumOfAirbars.Text = m_press.AirbarList.Count.ToString();
            }            
            SelectDefaultAirbar();
            this.buttonOK.Enabled = true;
        }

        /// <summary>
        /// Updates the airbar list box.
        /// </summary>
        private void UpdateAirbarListBox()
        {
            m_airbarDetails.Clear();
            // if there are NO airbars (in case of creating a new SiteXML)
            if (m_press.AirbarList.Count <= 0)
            {
                GenerateAirbarList(m_airbarCount);
            }
            else
            {
                m_airbarCount = m_press.AirbarList.Count;
                for (int counter = 0; counter < m_press.AirbarList.Count; ++counter)
                {
                    this.listBoxAirbarList.Items.Add(m_press.AirbarList[counter].Name);
                    m_airbarDetails.Add(m_press.AirbarList[counter].Name, m_press.AirbarList[counter].AfterWhichUnit);
                }
            }     
        }

        /// <summary>
        /// Updates the unit combo box.
        /// </summary>
        private void UpdateUnitComboBox()
        {
            int unitCount = m_press.TotalUnits;
            for (int unitIndex = 0; unitIndex < unitCount; ++unitIndex)
            {
                MCPressUnit unit = m_press.GetUnitAt(unitIndex);
                if (unit != null)
                {
                    this.comboBoxWhichUnit.Items.Add(unit.UnitName);                    
                }
            }
        }

        /// <summary>
        /// Selects the default airbar.
        /// </summary>
        private void SelectDefaultAirbar()
        {
            if (this.listBoxAirbarList.Items.Count > 0)
            {
                string airbarName = this.listBoxAirbarList.Items[0].ToString();
                SelectUnitForAirbar(airbarName);
            }
        }

        /// <summary>
        /// Selects the unit for airbar.
        /// </summary>
        /// <param name="airbarName">Name of the airbar.</param>
        private void SelectUnitForAirbar(string airbarName)
        {
            if (m_airbarDetails.ContainsKey(airbarName))
            {
                if (this.comboBoxWhichUnit.Items.Contains(m_airbarDetails[airbarName]))
                {
                    string selectedUnit = m_airbarDetails[airbarName];
                    this.comboBoxWhichUnit.SelectedItem = m_airbarDetails[airbarName];
                }
                else
                {
                    this.comboBoxWhichUnit.SelectedIndex = -1;
                }

                this.listBoxAirbarList.SelectedItem = airbarName;
             }            
        }

        /// <summary>
        /// Updates the data from GUI.
        /// </summary>
        private void UpdateDataFromGUI()
        {
            this.m_press.TotalNumberOfWebs = Convert.ToInt32( this.textBoxNumOfWebs.Text );
            if (m_airbarDetails.Count > 0)
            {
                this.m_press.AirbarList.Clear();
                // Update Airbar details 
                foreach (KeyValuePair<string, string> item in m_airbarDetails)
                {
                    AirbarConfigurationDetails airbarDetails = new AirbarConfigurationDetails();
                    airbarDetails.Name = item.Key;
                    airbarDetails.AfterWhichUnit = item.Value;
                    this.m_press.AirbarList.Add(airbarDetails);
                }
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the textBoxMaxWebs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBoxMaxWebs_TextChanged(object sender, EventArgs e)
        {
            if ( IsValidWebCountData() )
            {
                m_webCount = Convert.ToInt32(this.textBoxNumOfWebs.Text);             
            }            
        }


        /// <summary>
        /// Determines whether [is valid web count data].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is valid web count data]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidWebCountData()
        {
            bool validInput = false;

            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textBoxNumOfWebs.Text) ||
                string.IsNullOrEmpty(textBoxNumOfWebs.Text) )
            {
                this.textBoxNumOfWebs.Text = m_webCount.ToString();
            }
            else
            {
                int webCount = Convert.ToInt32(textBoxNumOfWebs.Text);
                if ((webCount > WebConfigParameterValidRange.WC_MAX_WEBS) ||
                     (webCount < 2))
                {
                    this.textBoxNumOfWebs.Text = m_webCount.ToString();
                    MessageBox.Show(string.Format("Number of Webs: valid range: 2 to {0}", WebConfigParameterValidRange.WC_MAX_WEBS));
                }
                else
                {
                    validInput = true;
                }
            }

            this.buttonOK.Enabled = validInput && IsValidAirbarCountData();

            return validInput;
        }

        /// <summary>
        /// Numbers the of airbars changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void NumberOfAirbarsChanged(object sender, EventArgs e)
        {
            if ( IsValidAirbarCountData() )
            {
                m_airbarCount = Convert.ToInt32(this.textBoxNumOfAirbars.Text);
                OnUpdateAirbarList(m_airbarCount);
            }            
        }

        /// <summary>
        /// Determines whether [is valid airbar count data].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is valid airbar count data]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidAirbarCountData()
        {
            bool validInput = false;
            
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.textBoxNumOfAirbars.Text) ||
                 string.IsNullOrEmpty(this.textBoxNumOfAirbars.Text))
            {
                this.textBoxNumOfAirbars.Text = m_airbarCount.ToString();
            }
            else
            {
                int webCount = Convert.ToInt32(this.textBoxNumOfWebs.Text);
                int airbarCount = Convert.ToInt32(this.textBoxNumOfAirbars.Text);
                // Is the airbar count valid?
                if ((airbarCount <= 0) || (airbarCount >= m_press.TotalUnits))
                {
                    MessageBox.Show(string.Format("Number of Airbars:Enter a valid value: 1 to {0}",  (m_press.TotalUnits - 1) ));
                    this.textBoxNumOfAirbars.Text = m_airbarCount.ToString();
                }
                else
                {
                    validInput = true;
                }
            }

            this.buttonOK.Enabled = validInput;

            return validInput;
        }

        /// <summary>
        /// Generates the airbar list.
        /// </summary>
        /// <param name="airbarCount">The airbar count.</param>
        private void GenerateAirbarList(int airbarCount)
        {
            this.listBoxAirbarList.Items.Clear();            
            for (int counter = 0; counter < airbarCount; ++counter)
            {
                string airBarName = string.Format("Airbar{0}", (counter + 1));
                this.listBoxAirbarList.Items.Add(airBarName);
                if (!m_airbarDetails.ContainsKey(airBarName) &&
                    (counter < m_press.UnitList.Count) )
                {
                    // fill dummy data 
                    m_airbarDetails.Add(airBarName, ((MCPressUnit)m_press.UnitList[counter]).UnitName);
                }
            }
        }

        /// <summary>
        /// Called when [update airbar list].
        /// </summary>
        /// <param name="airbarCount">The airbar count.</param>
        private void OnUpdateAirbarList(int airbarCount)
        {
            bool airbarChanged = false;
            int currentSize = m_airbarDetails.Count;
            if (currentSize < airbarCount)
            {
                // add new airbars to the list
                for(int index = currentSize; index < airbarCount; ++index)
                {
                    string airBarName = string.Format("Airbar{0}", (index + 1));
                    if ( !m_airbarDetails.ContainsKey(airBarName) &&
                         (index < m_press.UnitList.Count) )
                    {
                        m_airbarDetails.Add( airBarName, ((MCPressUnit)m_press.UnitList[index]).UnitName);
                    }
                }

                airbarChanged = true;
            }
            else if (currentSize > airbarCount)
            {
                // remove extra airbars
                for (int index = airbarCount; index < currentSize; ++index)
                {
                    string airBarName = string.Format("Airbar{0}", (index + 1));
                    if (m_airbarDetails.ContainsKey(airBarName))
                    {
                        m_airbarDetails.Remove(airBarName);
                    }
                }

                airbarChanged = true;
            }

            if ( airbarChanged )
            {
                this.listBoxAirbarList.Items.Clear();
                foreach (KeyValuePair<string, string> item in m_airbarDetails)
                {
                    this.listBoxAirbarList.Items.Add(item.Key);
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the AirbarList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AirbarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectUnitForAirbar(this.listBoxAirbarList.SelectedItem.ToString());
        }
               
        private void buttonOK_Click(object sender, EventArgs e)
        {
            UpdateDataFromGUI();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the buttonCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the Click event of the buttonUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string selectedAirbar = this.listBoxAirbarList.SelectedItem.ToString();
            string selectedUnit = this.comboBoxWhichUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedAirbar) &&
                !string.IsNullOrEmpty(selectedUnit))
            {              
                if (m_airbarDetails.ContainsKey(selectedAirbar))
                {
                    m_airbarDetails[selectedAirbar] = selectedUnit;
                }
                else
                {
                    m_airbarDetails.Add(selectedAirbar, selectedUnit);
                }

                this.buttonOK.Enabled = true;
            }            
        }
    }
}
