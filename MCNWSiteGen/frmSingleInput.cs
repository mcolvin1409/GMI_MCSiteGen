/////////////////////////////////////////////////////////////////////////////
//  
// frmSingleInput.cs.cs: Enters the single input values
//
//  Author:	Chetan           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmSingleInput.cs-arc   1.1   Nov 12 2008 21:38:06   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/frmSingleInput.cs-arc  $
///  
///     Rev 1.1   Nov 12 2008 21:38:06   HNarala
///  for the screen resolution of 1440 X 900
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

namespace MCNWSiteGen
{
    public partial class frmSingleInput : Form
    {
        string m_strValue;
        public frmSingleInput()
        {
            InitializeComponent();
        }
        public string Value
        {
            get { return m_strValue; }
            set { m_strValue = value; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            m_strValue = txtInput.Text;
            this.Close();
        }

        private void frmSingleInput_Load(object sender, EventArgs e)
        {
            txtInput.Text = m_strValue;
        }

        //======================================================================================
        /// <Function>txtInput_TextChanged</Function>
        /// <Author>   </Author>
        /// <Date>Set-15-2008</Date>
        /// <summary>
        /// txt Input Text Changed event
        /// </summary>
        /// <History>
        /// Hema Dt: 11-12-2008 MT: 11778 
        /// </History>
        ///=====================================================================================
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }
    }
}