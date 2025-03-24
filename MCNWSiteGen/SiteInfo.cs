/////////////////////////////////////////////////////////////////////////////
//  
// SiteInfo.cs: Site Information
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/SiteInfo.cs-arc   1.1   Jan 06 2009 23:13:54   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/SiteInfo.cs-arc  $
///  
///     Rev 1.1   Jan 06 2009 23:13:54   HNarala
///  to remove warning
///  
///     Rev 1.0   03 Oct 2008 14:42:14   knadler
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
using MCNWSiteGen;
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{
    public partial class SiteInfo : Form
    {
        //MCSiteConfigData m_SiteConfig;
        public string SetSiteName
        {
            get { return txtSiteName.Text; }
            set { txtSiteName.Text = value; }
        }

        //======================================================================================
        /// <Function>EnableDisableCtrls</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// EnableDisableCtrls
        /// </summary>
        /// 
        ///=====================================================================================
        public void EnableDisableCtrls(bool bState)
        {
           // txtSiteName.Enabled = bState;
            txtConfigVersion.Enabled = bState;
          //  txtSiteNumber.Enabled = bState;
            txtTotalPresses.Enabled = bState;
        }

        //======================================================================================
        /// <Function>SiteNumber</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// SiteNumber
        /// </summary>
        /// 
        ///=====================================================================================
        public int SiteNumber
        {
            get {
                if (txtSiteNumber.Text == "")
                    return 0;
                else 
                    return int.Parse(txtSiteNumber.Text);
            }
            set { txtSiteNumber.Text = value.ToString(); }
        }

        //======================================================================================
        /// <Function>ConfigVersion</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Config Version
        /// </summary>
        /// 
        ///=====================================================================================
        public float ConfigVersion
        {
            get{
                if( txtConfigVersion.Text == "")
                    return 0.0f;
                return float.Parse(txtConfigVersion.Text);
            } 
            set{ txtConfigVersion.Text = value.ToString ();}
        }

        //======================================================================================
        /// <Function>PressCount</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Press Count
        /// </summary>
        /// 
        ///=====================================================================================
        public int PressCount
        {
            get {
                if (txtTotalPresses.Text == "")
                    return 1;
                else
                    return int.Parse(txtTotalPresses.Text);
                }
                set { txtTotalPresses.Text = value.ToString(); }
        }

        //======================================================================================
        /// <Function>SiteInfo Constructor</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Site Information
        /// </summary>
        /// 
        ///=====================================================================================
        public SiteInfo()
        {
            InitializeComponent();
        }       
        private void btnOK_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSiteName_TextChanged(object sender, EventArgs e)
        {
            checkForNullEntries();
        }

        //======================================================================================
        /// <Function>checkForNullEntries</Function>
        /// <Author>Hema Kumar</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// checkForNullEntries
        /// </summary>
        /// 
        ///=====================================================================================
        private void checkForNullEntries()
        {
            if ((txtSiteName.Text == "") || (txtSiteNumber.Text == "") || (txtTotalPresses.Text == "") || (txtConfigVersion.Text == ""))
                btnOK.Enabled = false;
            else
                btnOK.Enabled = true;
        }

        private void txtTotalPresses_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtTotalPresses.Text))
            {
                txtTotalPresses.Text = "";
            }
            checkForNullEntries();
        }

        private void txtSiteNumber_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(txtSiteNumber.Text))
            {
                txtSiteNumber.Text = "";
            }
            checkForNullEntries();
        }

        private void txtConfigVersion_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*\.?[0-9]*$"); 
            if (!regex.IsMatch(txtConfigVersion.Text))
            {
                txtConfigVersion.Text = "";
            }
            checkForNullEntries();
        }
    }
}