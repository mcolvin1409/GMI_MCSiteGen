/////////////////////////////////////////////////////////////////////////////
//  
// NFSTables.cs: NFS Tables
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/NFSTables.cs-arc   1.0   03 Oct 2008 14:42:08   knadler  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/NFSTables.cs-arc  $
///  
///     Rev 1.0   03 Oct 2008 14:42:08   knadler
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
using System.Text.RegularExpressions;

namespace MCNWSiteGen
{
    public partial class NFSTables : Form
    {
        MCPressInfo mcPressInfo;
        public NFSTables()
        {
            InitializeComponent();
        }
        public MCPressInfo CurrentPress
        {
            set { mcPressInfo = value; }
            get { return mcPressInfo; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateData();
            this.Close();
        }

        private void NFSTables_Load(object sender, EventArgs e)
        {
            GenerateData();
        }
        void GenerateData()
        {
            MCPressNFSTable mcPressNFS = mcPressInfo.NFSTable;
            txtBreakPoint.Text = mcPressNFS.BreakPoint.ToString();
            txtMaxTurnsValue.Text = mcPressNFS.MaxKeyTurnsAtConsole99.ToString();
        }

        //======================================================================================
        /// <Function>UpdateData</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Update Data
        /// </summary>
        /// 
        ///=====================================================================================
        void UpdateData()
        {
            MCPressNFSTable mcPressNFS = mcPressInfo.NFSTable;
            mcPressNFS.BreakPoint = int.Parse(txtBreakPoint.Text );
            mcPressNFS.MaxKeyTurnsAtConsole99 = int.Parse(txtMaxTurnsValue.Text);
        }

        private void txtBreakPoint_TextChanged(object sender, EventArgs e)
        {
        }
    }
}