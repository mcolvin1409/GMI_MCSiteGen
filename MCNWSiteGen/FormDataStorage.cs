/////////////////////////////////////////////////////////////////////////////
//  
// FormDataStorage.cs: To configure the Standard and Remote Storage data Path 
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
    public partial class FormDataStorage : Form
    {

        MCPressInfo currentPress = null;
        string strStandardPath = "";
        string strNetworkPath = "";

        public string StandardPath
        {
            get { return strStandardPath; }
            set { strStandardPath = value; }
        }
        public string NetworkPath
        {
            get { return strNetworkPath; }
            set { strNetworkPath = value; }
        }
        /// <summary>
        /// New instance of FormDataStorage class
        /// </summary>
        /// <param name="bCreateFile">New File or not.</param>
        /// <param name="CurrentPress">MCPressInfo details.</param>
        /// 
        public FormDataStorage(MCPressInfo CurrentPress, bool bCreateFile)
        {
            InitializeComponent();
            currentPress = CurrentPress;
            this.btnOK.Enabled = !bCreateFile;
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
        /// On clicking Standard Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnStandardPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a Standard Path Storage Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {
                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string strDirectory = CheckIsDirectoryValid( fbdlg.SelectedPath );
                        if ( !string.IsNullOrEmpty( strDirectory ) )
                        {
                            this.textBoxStandardPath.Text = String.Concat( strDirectory, "\\" );
                        }
                        CheckStorageDataPathChanges( );
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
        /// <summary>
        /// On clicking Network Path Browse Button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <history>        
        ///  15-JUL-15, Mark C, WI59058: Display network shared folders in the Folder Browser dialog 
        /// </history>
        private void btnNetworkPathBrows_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog fbdlg = new FolderBrowserDialog( ) )
            {
                fbdlg.Description = "Select a Network Path Storage Location";
                fbdlg.RootFolder = Environment.SpecialFolder.Desktop;
                try
                {

                    DialogResult result = fbdlg.ShowDialog( );

                    if ( result == DialogResult.OK )
                    {
                        string strDirectory = CheckIsDirectoryValid( fbdlg.SelectedPath );
                        if ( !string.IsNullOrEmpty( strDirectory ) )
                        {
                            this.textBoxNetworkPath.Text = String.Concat( strDirectory, "\\" );
                        }
                        CheckStorageDataPathChanges( );
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
        /// Checks whether any changes made to the configuration
        /// </summary>
        /// <param name="path">.</param>
        private void CheckStorageDataPathChanges()
        {
            bool changeInData = false;
            if ((!string.IsNullOrEmpty(textBoxStandardPath.Text)) && (!string.IsNullOrEmpty(textBoxNetworkPath.Text)))
            {
                if (StandardPath != textBoxStandardPath.Text)
                    changeInData = true;
                else if (NetworkPath != textBoxNetworkPath.Text)
                    changeInData = true;
         
            }

            btnOK.Enabled = changeInData;
        }
        /// <summary>
        /// Handles the Load event of the ServerDataPath dialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormDataStorage_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 180, Location.Y + 80);
            UpdateDataStoragePathsToGUI();
        }
        /// <summary>
        /// Updates the configured values to GUI.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        private void UpdateDataStoragePathsToGUI()
        {
             this.textBoxStandardPath.Text = currentPress.PressClientInterface.StandardPath;
             this.textBoxNetworkPath.Text = currentPress.PressClientInterface.NetworkPath;
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
        /// Handles the Click event of the buttonOK control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>

        private void btnOK_Click(object sender, EventArgs e)
        {        
               
            string path = textBoxStandardPath.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            currentPress.PressClientInterface.StandardPath = path;

            path = textBoxNetworkPath.Text;
            path.Trim();
            if (!isFormated(path))
            {
                path = string.Concat(path, "\\");
            }
            currentPress.PressClientInterface.NetworkPath = path;

            MessageBox.Show("Data storage paths updated successfully.");
            this.Close();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 5-Nov-18, Mark C, WI128404: SiteGen | Won't able to save changes in Data Storage Paths. 
        ///          
        /// ]]>
        /// <summary>
        /// Called when [network path text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnNetworkPath_TextChanged( object sender, EventArgs e )
        {
            CheckStorageDataPathChanges();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 5-Nov-18, Mark C, WI128404: SiteGen | Won't able to save changes in Data Storage Paths. 
        ///          
        /// ]]>
        /// <summary>
        /// Called when [standard path text changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnStandardPath_TextChanged( object sender, EventArgs e )
        {
            CheckStorageDataPathChanges();
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 5-Nov-18, Mark C, WI128404: SiteGen | Won't able to save changes in Data Storage Paths. 
        ///          
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
        /// 
        /// Author: Mark C
        /// History: 5-Nov-18, Mark C, WI128404: SiteGen | Won't able to save changes in Data Storage Paths. 
        ///          
        /// ]]>
        /// <summary>
        /// Called when [text box standard path leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTextBoxStandardPath_Leave( object sender, EventArgs e )
        {
            string path = textBoxStandardPath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Standard Form Storage Path." );
                textBoxStandardPath.Text = currentPress.PressClientInterface.StandardPath;
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 5-Nov-18, Mark C, WI128404: SiteGen | Won't able to save changes in Data Storage Paths. 
        ///          
        /// ]]>
        /// <summary>
        /// Called when [text box network path leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTextBoxNetworkPath_Leave( object sender, EventArgs e )
        {
            string path = textBoxNetworkPath.Text.Trim();
            if( !IsValidPath( path ) )
            {
                MessageBox.Show( "Invalid Network Form Storage Path." );
                textBoxNetworkPath.Text = currentPress.PressClientInterface.NetworkPath;
            }
        }
    }
}