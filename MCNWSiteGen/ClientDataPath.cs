/////////////////////////////////////////////////////////////////////////////
//  
// ClientDataPath.cs: To configure the Client data Path 
//
//  Author:	Sreejit Kumar S           Aug-10-2010 
//
//	$Header:   
//
//	$Log:   
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
namespace MCNWSiteGen
{
    public partial class ClientDataPath : Form
    {
        string strClientConfigPath = "";
        string m_strPath = "";
        string strfilePath = "";
        bool m_bNewPathFile = false;
        string m_helpFilePath = "";     // location of the Help file path
        string m_strKBDLayouts = "";
        private string m_logFilesPath = string.Empty;   // location of the log file(s) path

        public string ClientConfigPath
        {
            get { return strClientConfigPath; }
            set { strClientConfigPath = value; }
        }

        /// <summary>
        /// Gets or sets the help path.
        /// </summary>
        /// <value>The help path.</value>
        public string HelpPath
        {
            get { return m_helpFilePath;  }
            set { m_helpFilePath = value; }
        }

        /// <summary>
        /// Keyboard layouts path.
        /// </summary>
        public string KBDLayouts
        {
            get { return m_strKBDLayouts; }
            set { m_strKBDLayouts = value; }
        }


        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
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

        /// <summary>
        /// New instance of ClientDataPath class
        /// </summary>
        /// <param name="m_bCreate">New File or not.</param>
        /// <param name="m_strDataPathLoc">Path Location.</param>
        /// 
        public ClientDataPath(bool m_bCreate, string m_strDataPathLoc)
        {
            InitializeComponent();
            m_bNewPathFile = m_bCreate;
            if (!string.IsNullOrEmpty(m_strDataPathLoc))
            {
                m_strPath = m_strDataPathLoc;
            }
            if (m_bNewPathFile)
                ActivateSaveButton(m_bNewPathFile);//Enable "Save" button when New file is created
        }

        /// <summary>
        /// XML Node Dictionary.
        /// <history>
        /// 18-Mar-2014, Chetan, Modified for supporting Keyboard Layouts folder.
        /// 28-Apr-15, Mark C, WI55780: Add support for Log folder
        /// </history>
        /// </summary>
        public class XMLNodeDictionary
        {
            #region XML NODE NAME

            public const string XT_MC_CLIENT_PATH_CONFIG     = "MC_CLIENT_PATH_CONFIG";
            public const string XT_MCCLIENT_ACT_OPTIONS_PATH = "MCCLIENT_ACT_OPTIONS_PATH";
            public const string XT_MCCLIENT_HELP_PATH        = "MCCLIENT_HELP_PATH";
            public const string XT_MCCLIENT_KEYBOARD_LAYOUTS_PATH = "MCCLIENT_KBD_FILES_PATH";
            public const string XT_VALUE                     = "Value";
            public const string XT_MCCLIENT_LOG_FILES_PATH = "MCCLIENT_LOG_FILES_PATH";

            // PRESS

            #endregion
        }
        /// <summary>
        /// Save Button Status Enable or Disable
        /// </summary>
        /// <param name="bStatus">Enable/Disable Status.</param>
        public void ActivateSaveButton(bool bStatus)
        {
            btnOK.Enabled = bStatus;
        }
        /// <summary>
        /// On clicking Cancel Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handles the Load event of the ClientDataPath dialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ClientDataPath_Load(object sender, EventArgs e)
        {

            this.Location = new Point(Location.X, Location.Y);
            if (m_bNewPathFile)
                UpdateDefaultDataPathConfigToGUI();
            else
                UpdateDataPathConfigToGUI();
        }
        /// <summary>
        /// Handles the textClientConfig_Leave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Added support for configuring Help file path
        /// 18-Mar-2014, Chetan, Modified for supporting Keyboard Layouts folder.
        /// </history>
        private void textClientConfig_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textClientConfig.Text))
            {
                string path = textClientConfig.Text.Trim();
                textClientConfig.Text = path;
            }
            else
            {
                MessageBox.Show("Enter a valid System Path ");
                textClientConfig.Text = ClientConfigPath;
            }

            if (!string.IsNullOrEmpty(textHelpPath.Text))
            {
                string helpPath = textHelpPath.Text.Trim();
                textHelpPath.Text = helpPath;
            }
            else
            {
                MessageBox.Show("Enter a valid Help file path");
                textHelpPath.Text = HelpPath;
            }

            if (!string.IsNullOrEmpty(txtKeyboardLayouts.Text))
            {
                string kbdPath = txtKeyboardLayouts.Text.Trim();
                txtKeyboardLayouts.Text = kbdPath;
            }

            CheckPathDataChanges();
        }

        /// <summary>
        /// Checks whether any changes made to the configuration
        /// </summary>
        /// <param name="path">.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Validate Help file path
        ///         18-Mar-2014, Chetan, added Keyboard layous path.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>
        private void CheckPathDataChanges()
        {
            bool changeInData = false;
            if (  ( (!string.IsNullOrEmpty(textClientConfig.Text) ) && 
                  ( ClientConfigPath != textClientConfig.Text ) ) ||
                  ( (!string.IsNullOrEmpty(textHelpPath.Text) ) &&
                  ( HelpPath != textHelpPath.Text ) ) ||
                  ( ( KBDLayouts != txtKeyboardLayouts.Text)    && 
                  (!string.IsNullOrEmpty(txtKeyboardLayouts.Text))) ||
                  IsLogfilesPathChanged( ) )                
            {
                    changeInData = true;
            }
            this.btnOK.Enabled = changeInData;
        }


        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 
        /// ]]>
        /// <summary>
        /// Determines whether [is logfiles path changed].
        /// </summary>
        /// <returns></returns>
        private bool IsLogfilesPathChanged()
        {
            return ( !string.IsNullOrEmpty( m_logFilePathTextBox.Text ) && ( LogFilesPath != m_logFilePathTextBox.Text ) );
        }
        
        /// <summary>
        /// Updates the default values to GUI.
        /// </summary>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Assign default help file path
        /// 18-Mar-2014, Chetan, Modified for supporting Keyboard Layouts folder.
        /// 28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>
        private void UpdateDefaultDataPathConfigToGUI()
        {
            this.textClientConfig.Text = @"D:\GMI\MC3\MC3CLIENT\CONFIG\";
            this.textHelpPath.Text = @"D:\GMI\MC3\MC3CLIENT\HELP\";
            //defaults should be c: drive
            this.txtKeyboardLayouts.Text = @"C:\GMI\MC3\MC3CLIENT\KBDLayouts";
            this.m_logFilePathTextBox.Text = @"D:\GMI\MC3\Logs\";
        }
        /// <summary>
        /// Updates the configured values to GUI.
        /// </summary>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Update help file path
        ///         18-Mar-2014, Chetan, added Keyboard layous path.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>
        private void UpdateDataPathConfigToGUI()
        {
            this.textClientConfig.Text = ClientConfigPath;
            this.textHelpPath.Text = HelpPath;
            this.txtKeyboardLayouts.Text = KBDLayouts;
            this.m_logFilePathTextBox.Text = LogFilesPath;
        }
        /// <summary>
        /// Handles the Click event of the buttonOK control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Added support for Help file path
        ///         18-Mar-2014, Chetan, added Keyboard layous path.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>    
        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = this.textClientConfig.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            ClientConfigPath = path;

            string helpPath = this.textHelpPath.Text;
            helpPath.Trim();
            if (!isFormated(helpPath))
            {
                helpPath = string.Concat(helpPath, "\\");
            }
            HelpPath = helpPath;

            string kbdLayoutsPath = this.txtKeyboardLayouts.Text;
            kbdLayoutsPath.Trim();
            if (!isFormated(kbdLayoutsPath))
            {
                kbdLayoutsPath = string.Concat(kbdLayoutsPath, "\\");
            }

            KBDLayouts = kbdLayoutsPath;

            string logFilesPath = m_logFilePathTextBox.Text.Trim( );
            if ( !isFormated( logFilesPath  ) )
            {
                m_logFilesPath = string.Concat( logFilesPath, "\\" );
            }
            m_logFilesPath = logFilesPath;

            bool bRet = createMCClientPathFile();
            if (bRet)
            {
                this.Close();
            }
            
        }
        /// <summary>
        /// Formats the string
        /// </summary>
        /// <param name="path">The string to be formatted.</param>
        private bool isFormated(string path)
        {
            bool status = false;
            if (!string.IsNullOrEmpty(path))
            {
                int length = path.Length;
                char lastChar = path[length - 1];
                int value = string.Compare(lastChar.ToString(), ("\\"));
                if (value == 0)
                    status = true;
            }
            return status;
        }
        /// <summary>
        /// Creates the MCClient Path File if it doesnt exist
        /// </summary>
        /// <param name="path">.</param>
        private bool createMCClientPathFile()
        {

            bool bReturn = false;
            if (m_bNewPathFile)
            {
               if (!SetClientPathFileLocation())
                   return bReturn;
            }
            else
            {
                strfilePath = m_strPath;
            }
            SaveMCClientPathFile();
            return true;

        }
        /// <summary>
        /// Sets the MCClient Path File location
        /// </summary>
        /// <param name="path">.</param>
        private bool SetClientPathFileLocation()
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog() )
            {
                fbdlg.Description = "Select a MCClient Path File Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string LogPath = fbdlg.SelectedPath;
                        if (!string.IsNullOrEmpty(LogPath))
                        {
                            strfilePath = LogPath + "\\" + "MCClient.mcpath";
                        }
                        else
                        {
                            MessageBox.Show("Invalid Path Selected.Failed to save MC Client Path file");
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return true;
        }
        /// <summary>
        /// Saves the MCClient Path File to a specific location
        /// </summary>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Added support for saving the Help file location
        ///         18-Mar-14, Chetan, Added support to save Keyboard layouts path.
        ///         28-Apr-15, Mark C, WI55780: Add support for Log folder.
        /// </history>          
        private void SaveMCClientPathFile()
        {
             try
            {
                // creates the xml file
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(docNode);

                XmlNode MCSystemPathConfigNode = doc.CreateElement(XMLNodeDictionary.XT_MC_CLIENT_PATH_CONFIG);
                doc.AppendChild(MCSystemPathConfigNode);

                XmlNode MCClientConfigPath = doc.CreateElement(XMLNodeDictionary.XT_MCCLIENT_ACT_OPTIONS_PATH);
                XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(ClientConfigPath);
                MCClientConfigPath.Attributes.Append(productAttribute);
                MCSystemPathConfigNode.AppendChild(MCClientConfigPath);

                // Help file path
                XmlNode helpFilePath = doc.CreateElement(XMLNodeDictionary.XT_MCCLIENT_HELP_PATH);
                XmlAttribute helpFileAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                helpFileAttribute.Value = HelpPath;
                helpFilePath.Attributes.Append(helpFileAttribute);
                MCSystemPathConfigNode.AppendChild(helpFilePath);

                 //Path for Keyboard layouts.
                XmlNode kbdLayoutPath = doc.CreateElement(XMLNodeDictionary.XT_MCCLIENT_KEYBOARD_LAYOUTS_PATH);
                XmlAttribute kbdLayoutAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                kbdLayoutAttribute.Value = KBDLayouts;
                kbdLayoutPath.Attributes.Append(kbdLayoutAttribute);
                MCSystemPathConfigNode.AppendChild(kbdLayoutPath);

                 // Path for Log files ( OCU3 Log and Preset Imposition log )
                XmlNode logFilesPath = doc.CreateElement( XMLNodeDictionary.XT_MCCLIENT_LOG_FILES_PATH );
                XmlAttribute logFilesPathValue = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                logFilesPathValue.Value = LogFilesPath;
                logFilesPath.Attributes.Append( logFilesPathValue );
                MCSystemPathConfigNode.AppendChild( logFilesPath );
                 

                //save the file               
                doc.Save(strfilePath);
                string strSavedFileName = System.IO.Path.GetFileName(strfilePath);
                MessageBox.Show(strfilePath + " file saved successfully.");
                strfilePath = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// On clicking Client Config Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnClientConfigPathBrows_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbdlg = new FolderBrowserDialog())
            {
                fbdlg.Description = "Select a Client Configuration Path Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string ClientPath = fbdlg.SelectedPath;
                        if (!string.IsNullOrEmpty(ClientPath))
                        {
                            this.textClientConfig.Text = String.Concat(ClientPath, "\\");
                            CheckPathDataChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonHelpBrowse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///         08-Mar-12, Mark C, MT 17637 - Added support for selecting a folder for Help file
		///  		15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog
        /// </history> 
        private void buttonHelpBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browseDlg = new FolderBrowserDialog())
            {
                browseDlg.Description = "Select the Help file path location:";
                browseDlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = browseDlg.ShowDialog();
                    if ( result == DialogResult.OK )
                    {
                        string helpPath = browseDlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( helpPath ) )
                        {
                            this.textHelpPath.Text = String.Concat(helpPath, "\\");
                            CheckPathDataChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Event Handler for Browse Button[Keyboard layouts]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void buttonKeyboardLayouts_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browseDlg = new FolderBrowserDialog())
            {
                browseDlg.Description = "Select the keyboard layout file path location:";
                browseDlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = browseDlg.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string kbdFilesPath = browseDlg.SelectedPath;
                        if (!string.IsNullOrEmpty(kbdFilesPath))
                        {
                            this.txtKeyboardLayouts.Text = String.Concat(kbdFilesPath, "\\");
                            CheckPathDataChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <![CDATA[
        ///
        /// Author: Mark C
        /// 
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 		15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// ]]>
        /// <summary>
        /// Called when [log files path browse click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLogFilesPathBrowseClick( object sender, EventArgs e )
        {
            using ( FolderBrowserDialog browseDlg = new FolderBrowserDialog( ) )
            {
                browseDlg.Description = "Select the Log files path location:";
                browseDlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = browseDlg.ShowDialog( );
                    if ( result == DialogResult.OK )
                    {
                        string logFilesPath = browseDlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( logFilesPath ) )
                        {
                            m_logFilePathTextBox.Text = String.Concat( logFilesPath, "\\" );
                            CheckPathDataChanges( );
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
        /// History: 28-Apr-15, Mark C, WI55780: Created
        /// 
        /// ]]>
        /// <summary>
        /// Called when [log file path text box_ leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLogFilePathTextBox_Leave( object sender, EventArgs e )
        {
            // check Log files path
            if ( !string.IsNullOrEmpty( m_logFilePathTextBox.Text ) )
            {
                m_logFilesPath = m_logFilePathTextBox.Text.Trim( );
            }
            else
            {
                MessageBox.Show( "Enter a valid Log file path" );
                m_logFilePathTextBox.Text = LogFilesPath;
            }
        }

    }
}