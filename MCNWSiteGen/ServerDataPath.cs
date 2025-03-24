/////////////////////////////////////////////////////////////////////////////
//  
// ServerDataPath.cs: To configure the Server data Path 
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
    public partial class ServerDataPath : Form
    {

        string strCurrentSystemPath = "";
        string strCurrentApplnDataPath = "";
        string strCurrentLogPath = "";
        string strCurrentRuntimePath = "";
        string strfilePath = "";
        bool m_bNewPathFile = false;
        string m_strPath = "";
        string m_jobsPath = string.Empty;
        string m_jobsArchivePath = string.Empty;
        string m_formTemplatePath = string.Empty;

        public string CurrentSystemPath
        {
            get { return strCurrentSystemPath; }
            set { strCurrentSystemPath = value; }
        }
        public string CurrentApplnDataPath
        {
            get { return strCurrentApplnDataPath; }
            set { strCurrentApplnDataPath = value; }
        }
        public string CurrentLogPath
        {
            get { return strCurrentLogPath; }
            set { strCurrentLogPath = value; }
        }
        public string CurrentRuntimePath
        {
            get { return strCurrentRuntimePath; }
            set { strCurrentRuntimePath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the current jobs path.
        /// </summary>
        /// <value>
        /// The current jobs path.
        /// </value>
        public string CurrentJobsPath
        {
            get { return m_jobsPath; }
            set { m_jobsPath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the current jobs archive path.
        /// </summary>
        /// <value>
        /// The current jobs archive path.
        /// </value>
        public string CurrentJobsArchivePath
        {
            get { return m_jobsArchivePath; }
            set { m_jobsArchivePath = value; }
        }

        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Gets or sets the current form template path.
        /// </summary>
        /// <value>
        /// The current form template path.
        /// </value>
        public string CurrentFormTemplatePath
        {
            get { return m_formTemplatePath; }
            set { m_formTemplatePath = value; }
        }

        /// <summary>
        /// New instance of ServerDataPath class
        /// </summary>
        /// <param name="m_bCreate">New File or not.</param>
        /// <param name="m_strDataPathLoc">Path Location.</param>
        /// <history>
        ///     29-May-19, Mark C, WI177016: Enable 'Save' button in New and Edit mode
        /// </history>
        public ServerDataPath(bool m_bCreate, string m_strDataPathLoc)
        {
            InitializeComponent();
            m_bNewPathFile = m_bCreate;
            if (!string.IsNullOrEmpty(m_strDataPathLoc))
            {
                m_strPath = m_strDataPathLoc;
            }

            ActivateSaveButton( m_bNewPathFile );//Enable "Save" button 
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

        public class XMLNodeDictionary
        {
            #region XML NODE NAME

            public const string XT_MC_SERVER_PATH_CONFIG = "MC_SERVER_PATH_CONFIG";
            public const string XT_MCSYSTEM_PATH = "SYSTEM_PATH";
            public const string XT_MCAPPLICATIONDATA_PATH = "DATA_PATH";
            public const string XT_MCLOG_PATH = "LOG_PATH";
            public const string XT_MCSYSTEM_RUNTIME_PATH = "SYSTEM_RUNTIME_PATH";
            public const string XT_VALUE = "Value";
            public const string XT_MCJOBS_XML_PATH = "JOBS_XML_PATH";
            public const string XT_MCJOBS_ARCHIVE_PATH = "JOBS_ARCHIVE_PATH";
            public const string XT_FORM_TEMPLATE_PATH = "FORM_TEMPLATE_PATH";            

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
        /// On clicking System Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnSystemPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a System Path Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string SystemPath = fbdlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( SystemPath ) )
                        {
                            this.textBoxSystemPath.Text = String.Concat( SystemPath, "\\" );
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
        /// <summary>
        /// Check whether a path configured is valid or not
        /// </summary>
        /// <param name="strDirectoryPath">Directory.</param>

        private string CheckIsDirectoryValid(string strDirectoryPath)
        {

            string[] str = Directory.GetLogicalDrives();
            int iLength = str.Length;
            bool bSet = false;
            for (int iCount = 0; iCount < iLength; iCount++)
            {
                if (strDirectoryPath.Trim() == str[iCount].ToString())
                {
                    bSet = false;
                    break;
                }
                else
                {
                    bSet = true;
                }
            }
            if (bSet)
            {
                return strDirectoryPath;

            }
            else
            {
                MessageBox.Show("Please enter a valid directory");
                return "";
            }
        }

        /// <summary>
        /// On clicking Appln Data Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnApplnDataBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a Data Path Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );
                    if ( result == DialogResult.OK )
                    {
                        string strDirectory = CheckIsDirectoryValid( fbdlg.SelectedPath );
                        if ( !string.IsNullOrEmpty( strDirectory ) )
                        {
                            this.textBoxApplnData.Text = String.Concat( strDirectory, "\\" );
                        }
                        CheckPathDataChanges( );
                    }

                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
        /// <summary>
        /// On clicking Log Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnLogPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a Log Path Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );
                    if ( result == DialogResult.OK )
                    {
                        string LogPath = fbdlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( LogPath ) )
                        {
                            this.textBoxLogPath.Text = String.Concat( LogPath, "\\" );
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
        /// <summary>
        /// On clicking Runtime Config Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void buttonRuntimeConfig_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a Runtime Configuration Path Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );
                    if ( result == DialogResult.OK )
                    {
                        string RuntimePath = fbdlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( RuntimePath ) )
                        {
                            this.textRuntimeConfig.Text = String.Concat( RuntimePath, "\\" );
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

        /// <summary>
        /// Handles the Load event of the ServerDataPath dialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>

        private void DataPath_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X, Location.Y);
            if (m_bNewPathFile)
                UpdateDefaultDataPathConfigToGUI();
            else
                UpdateDataPathConfigToGUI();
        }
        /// <summary>
        /// Updates the default values to GUI.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// History: Sreejit, Aug-13-2010, ENH 16186: MCNWSiteGen: The default System file path should be "C:\GMI\MC3\SYSTEM"  
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        ///          
        private void UpdateDefaultDataPathConfigToGUI()
        {
            textBoxSystemPath.Text = @"C:\GMI\MC3\SYSTEM\";
            textBoxApplnData.Text = @"D:\GMI\MC3\JOB_DATA\";
            textBoxLogPath.Text = @"D:\GMI\MC3\LOGS\";
            textRuntimeConfig.Text = @"D:\GMI\MC3\MC3AS\RUNTIME\";
            textBoxJobsPath.Text = @"D:\GMI\MC3\JOBS\";
            textBoxJobsArchivePath.Text = @"D:\GMI\MC3\JOBS_ARCHIVE\";
            textBoxFormTemplatePath.Text = @"D:\GMI\MC3\FORM_TEMPLATE\";            
        }
        /// <summary>
        /// Updates the configured values to GUI.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void UpdateDataPathConfigToGUI()
        {
            textBoxSystemPath.Text = CurrentSystemPath;
            textBoxApplnData.Text = CurrentApplnDataPath;
            textBoxLogPath.Text = CurrentLogPath;
            textRuntimeConfig.Text = CurrentRuntimePath;
            textBoxJobsPath.Text = CurrentJobsPath;
            textBoxJobsArchivePath.Text = CurrentJobsArchivePath;
            textBoxFormTemplatePath.Text = CurrentFormTemplatePath;
        }
        /// <summary>
        /// Handles the textBoxSystemPath_Leave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void textBoxSystemPath_Leave(object sender, EventArgs e)
        {
            string path = textBoxSystemPath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid System Path." );
                textBoxSystemPath.Text = CurrentSystemPath;
            }

            CheckPathDataChanges();
        }
        /// <summary>
        /// Handles the textBoxApplnData_Leave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void textBoxApplnData_Leave(object sender, EventArgs e)
        {
            string path = textBoxApplnData.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Data Path." );
                textBoxApplnData.Text = CurrentApplnDataPath;
            }

            CheckPathDataChanges();
        }

        /// <summary>
        /// Handles the textRuntimeConfig_Leave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void textRuntimeConfig_Leave(object sender, EventArgs e)
        {
            string path = textRuntimeConfig.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Runtime Path." );
                textRuntimeConfig.Text = CurrentRuntimePath;
            }

            CheckPathDataChanges();
        }

        /// <summary>
        /// Handles the Click event of the buttonOK control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void btnOK_Click(object sender, EventArgs e)
        {

            string path = textBoxSystemPath.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            CurrentSystemPath = path;

            path = textBoxApplnData.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            CurrentApplnDataPath = path;

            path = textBoxLogPath.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            CurrentLogPath = path;

            path = textRuntimeConfig.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            CurrentRuntimePath = path;

            // Jobs Path
            path = textBoxJobsPath.Text.Trim();            
            if( !isFormated( path ) )
            {
                path = string.Concat( path, "\\" );
            }
            CurrentJobsPath = path;

            // Jobs Archive Path
            path = textBoxJobsArchivePath.Text.Trim();            
            if( !isFormated( path ) )
            {
                path = string.Concat( path, "\\" );
            }
            CurrentJobsArchivePath = path;

            // Form Template Path
            path = textBoxFormTemplatePath.Text.Trim();            
            if( !isFormated( path ) )
            {
                path = string.Concat( path, "\\" );
            }
            CurrentFormTemplatePath = path;
            
            bool bRet = createMCServerPathFile();
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
        /// Creates the MCServer Path File if it doesnt exist
        /// </summary>
        /// <param name="path">.</param>

        private bool createMCServerPathFile()
        {

            bool bReturn = false;
            if (m_bNewPathFile)
            {
                if (!SetServerPathFileLocation())
                    return bReturn;

            }
            else
            {
                strfilePath = m_strPath;
            }
            SaveMCServerPathFile();
            return true;

        }
        /// <summary>
        /// Sets the MCServer Path File location
        /// </summary>
        /// <param name="path">.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private bool SetServerPathFileLocation()
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select an AppServer Path File Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string LogPath = fbdlg.SelectedPath;
                        if ( !string.IsNullOrEmpty( LogPath ) )
                        {
                            strfilePath = LogPath + "\\" + "MCAppServer.mcpath";
                        }
                        else
                        {
                            MessageBox.Show( "Invalid Path Selected.Failed to save MC Server Path file" );
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
            return true;
        }

        /// <summary>
        /// Saves the MCServer Path File to a specific location
        /// </summary>
        /// <param name="path">.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void SaveMCServerPathFile()
        {
            try
            {
                // creates the xml file
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(docNode);


                XmlNode MCSystemPathConfigNode = doc.CreateElement(XMLNodeDictionary.XT_MC_SERVER_PATH_CONFIG);
                doc.AppendChild(MCSystemPathConfigNode);

                XmlNode SystemPath = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_PATH);
                XmlAttribute productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(CurrentSystemPath);
                SystemPath.Attributes.Append(productAttribute);
                MCSystemPathConfigNode.AppendChild(SystemPath);

                XmlNode ApplnDataPath = doc.CreateElement(XMLNodeDictionary.XT_MCAPPLICATIONDATA_PATH);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(CurrentApplnDataPath);
                ApplnDataPath.Attributes.Append(productAttribute);
                MCSystemPathConfigNode.AppendChild(ApplnDataPath);

                XmlNode LogPath = doc.CreateElement(XMLNodeDictionary.XT_MCLOG_PATH);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(CurrentLogPath);
                LogPath.Attributes.Append(productAttribute);
                MCSystemPathConfigNode.AppendChild(LogPath);

                XmlNode RuntimeConfigPath = doc.CreateElement(XMLNodeDictionary.XT_MCSYSTEM_RUNTIME_PATH);
                productAttribute = doc.CreateAttribute(XMLNodeDictionary.XT_VALUE);
                productAttribute.Value = Convert.ToString(CurrentRuntimePath);
                RuntimeConfigPath.Attributes.Append(productAttribute);
                MCSystemPathConfigNode.AppendChild(RuntimeConfigPath);

                // Jobs Path
                XmlNode jobsPath = doc.CreateElement( XMLNodeDictionary.XT_MCJOBS_XML_PATH );
                XmlAttribute jobsPathAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                jobsPathAttribute.Value = CurrentJobsPath;
                jobsPath.Attributes.Append( jobsPathAttribute );
                MCSystemPathConfigNode.AppendChild( jobsPath );

                // Jobs Archive Path
                XmlNode jobsArchivePath = doc.CreateElement( XMLNodeDictionary.XT_MCJOBS_ARCHIVE_PATH );
                XmlAttribute jobsArchivePathAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                jobsArchivePathAttribute.Value = CurrentJobsArchivePath;
                jobsArchivePath.Attributes.Append( jobsArchivePathAttribute );
                MCSystemPathConfigNode.AppendChild( jobsArchivePath );

                // Form Template Path
                XmlNode formTemplatePath = doc.CreateElement( XMLNodeDictionary.XT_FORM_TEMPLATE_PATH );
                XmlAttribute formTemplatePathAttribute = doc.CreateAttribute( XMLNodeDictionary.XT_VALUE );
                formTemplatePathAttribute.Value = CurrentFormTemplatePath;
                formTemplatePath.Attributes.Append( formTemplatePathAttribute );
                MCSystemPathConfigNode.AppendChild( formTemplatePath );
                
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
        /// Checks whether any changes made to the configuration
        /// </summary>
        /// <param name="path">.</param>
        /// <history>
        ///          29-May-19, Mark C, WI177016: Add support for Jobs Path, Jobs Archive Path and Form Template path
        /// </history>
        private void CheckPathDataChanges()
        {
            if( m_bNewPathFile )
            {
                return;
            }

            bool changeInData = false;
            if( ( !string.IsNullOrEmpty( textBoxSystemPath.Text ) ) && ( !string.IsNullOrEmpty( textBoxApplnData.Text ) )
                && ( !string.IsNullOrEmpty( textBoxLogPath.Text ) ) && ( !string.IsNullOrEmpty( textRuntimeConfig.Text ) )
                && ( !string.IsNullOrEmpty( textBoxJobsPath.Text ) ) && ( !string.IsNullOrEmpty( textBoxJobsArchivePath.Text ) )
                && ( !string.IsNullOrEmpty( textBoxFormTemplatePath.Text ) ) )
            {

                if( CurrentSystemPath != textBoxSystemPath.Text )
                    changeInData = true;
                else if( CurrentApplnDataPath != textBoxApplnData.Text )
                    changeInData = true;
                else if( CurrentLogPath != textBoxLogPath.Text )
                    changeInData = true;
                else if( CurrentRuntimePath != textRuntimeConfig.Text )
                    changeInData = true;
                else if( CurrentJobsPath != textBoxJobsPath.Text )
                    changeInData = true;
                else if( CurrentJobsArchivePath != textBoxJobsArchivePath.Text )
                    changeInData = true;
                else if( CurrentFormTemplatePath != textBoxFormTemplatePath.Text )
                    changeInData = true;
            }

            btnOK.Enabled = changeInData;
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Determines whether [is valid path] [the specified full path].
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <returns>
        ///   <c>true</c> if [is valid path] [the specified full path]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidPath( string fullPath )
        {
            bool validPath = false;

            Regex r = new Regex( @"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$" );
            validPath = r.IsMatch( fullPath );

            return validPath;
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the textBoxLogPath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxLogPath_Leave( object sender, EventArgs e )
        {
            string path = textBoxLogPath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Log Path." );
                textBoxLogPath.Text = CurrentLogPath;
            }

            CheckPathDataChanges();
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the textBoxJobsPath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxJobsPath_Leave( object sender, EventArgs e )
        {
            string path = textBoxJobsPath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Jobs Path." );
                textBoxJobsPath.Text = CurrentJobsPath;
            }

            CheckPathDataChanges();
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the textBoxJobsArchivePath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxJobsArchivePath_Leave( object sender, EventArgs e )
        {
            string path = textBoxJobsArchivePath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Jobs Archive Path." );
                textBoxJobsArchivePath.Text = CurrentJobsArchivePath;
            }

            CheckPathDataChanges();
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Leave event of the textBoxFormTemplatePath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxFormTemplatePath_Leave( object sender, EventArgs e )
        {
            string path = textBoxFormTemplatePath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Form Template Path." );
                textBoxFormTemplatePath.Text = CurrentFormTemplatePath;
            }

            CheckPathDataChanges();
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Click event of the browseButtonJobsPath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void browseButtonJobsPath_Click( object sender, EventArgs e )
        {
            using( FolderBrowserDialog fbdlg = new FolderBrowserDialog() )
            {
                fbdlg.Description = "Select the Jobs Path";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog();
                    if( result == DialogResult.OK )
                    {
                        string jobsPath = fbdlg.SelectedPath;
                        if( !string.IsNullOrEmpty( jobsPath ) )
                        {
                            this.textBoxJobsPath.Text = String.Concat( jobsPath, "\\" );
                            CheckPathDataChanges();
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Click event of the browseButtonArchivePath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void browseButtonArchivePath_Click( object sender, EventArgs e )
        {
            using( FolderBrowserDialog fbdlg = new FolderBrowserDialog() )
            {
                fbdlg.Description = "Select the Jobs Archive Path";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog();
                    if( result == DialogResult.OK )
                    {
                        string jobsArchivePath = fbdlg.SelectedPath;
                        if( !string.IsNullOrEmpty( jobsArchivePath ) )
                        {
                            this.textBoxJobsArchivePath.Text = String.Concat( jobsArchivePath, "\\" );
                            CheckPathDataChanges();
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
        /// <![CDATA[
        /// Author: Mark C        
        /// History: 29-May-19, Mark C, WI177016: Created        
        /// ]]>
        /// <summary>
        /// Handles the Click event of the browseButtonFormTemplatePath control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void browseButtonFormTemplatePath_Click( object sender, EventArgs e )
        {
            using( FolderBrowserDialog fbdlg = new FolderBrowserDialog() )
            {
                fbdlg.Description = "Select the Form Template Path";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog();
                    if( result == DialogResult.OK )
                    {
                        string formTemplatePath = fbdlg.SelectedPath;
                        if( !string.IsNullOrEmpty( formTemplatePath ) )
                        {
                            this.textBoxFormTemplatePath.Text = String.Concat( formTemplatePath, "\\" );
                            CheckPathDataChanges();
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
    }
}