/////////////////////////////////////////////////////////////////////////////
//  
// Turnbars.cs: Turnbars 
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/Turnbars.cs-arc   1.1   Nov 12 2008 23:21:08   HNarala  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/Turnbars.cs-arc  $
///  
///     Rev 1.1   Nov 12 2008 23:21:08   HNarala
///  MT#11779
///  
///     Rev 1.0   03 Oct 2008 14:42:16   knadler
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
    public partial class Turnbars : Form
    {
        MCPressInfo mcPress;
        bool m_bInitialGeneration;
        public Turnbars()
        {
            InitializeComponent();
            m_bInitialGeneration = true;
        }

        public MCPressInfo CurrentPress
        {
            get { return mcPress; }
            set { mcPress = value; }
        }
        private void Turnbars_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 150, Location.Y + 50);
            GenerateData();
        }

        //======================================================================================
        /// <Function>GenerateData</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Generate Data
        /// </summary>
        /// 
        ///=====================================================================================
        void GenerateData()
        {
            int iTotalTurnBars = mcPress.TotalTurnBars;
            txtTurnBarCount.Text = iTotalTurnBars.ToString();
            m_bInitialGeneration = false;            

        }
        void StoreData()
        {
            
        }

        //======================================================================================
        /// <Function>GenerateTurnBarInfo</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// Generate TurnBar Info
        /// </summary>
        /// 
        ///=====================================================================================
        void GenerateTurnBarInfo()
        {
            if (mcPress.TotalTurnBars == 0)
            {

                cboTurnBars.Items.Clear();
                cboPredecessor.Items.Clear();
                int iTotalUnit = mcPress.TotalUnits;
                for (int iUnit = 0; iUnit < iTotalUnit; iUnit++)
                {
                    MCPressUnit pressUnit = mcPress.GetUnitAt(iUnit);
                    if (pressUnit == null)
                        continue;
                    cboPredecessor.Items.Add(pressUnit.UnitName);
                }
                if (txtTurnBarCount.Text == "")
                    return;
                int iTotalTurnBars = int.Parse(txtTurnBarCount.Text);
                if (iTotalTurnBars == 0)
                    return;

                mcPress.ClearAllTurnBars();
                for (int iTurnBar = 0; iTurnBar < iTotalTurnBars; iTurnBar++)
                {
                    TurnBars turnBar = new TurnBars();//mcPress.TurnBar(iTurnBar);
                    string strTurnBarName = "TurnBar" + (iTurnBar + 1).ToString();
                    turnBar.Name = strTurnBarName;
                    turnBar.Predecessor = "Unit" + (iTurnBar + 1).ToString();
                    cboTurnBars.Items.Add(turnBar.Name);
                    mcPress.AddTurnBar(turnBar);
                }
            }
            // populate existing turnbar data.
            else
            {
                cboTurnBars.Items.Clear();
                cboPredecessor.Items.Clear();
                int iTotalUnit = mcPress.TotalUnits;
                for (int iUnit = 0; iUnit < iTotalUnit; iUnit++)
                {
                    MCPressUnit pressUnit = mcPress.GetUnitAt(iUnit);
                    if (pressUnit == null)
                        continue;
                    cboPredecessor.Items.Add(pressUnit.UnitName);
                }
                int iTotalTurnBars = mcPress.TotalTurnBars;
                for (int iTurnBar = 0; iTurnBar < iTotalTurnBars; iTurnBar++)
                {
                    TurnBars turnBar = mcPress.TurnBar(iTurnBar);
                    if (turnBar == null)
                        continue;
                    cboTurnBars.Items.Add(turnBar.Name);
                }
            }
        }

        //======================================================================================
        /// <Function>ChangeData</Function>
        /// <Author>Chetan</Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// ChangeData
        /// </summary>
        /// 
        ///=====================================================================================
        void ChangeData()
        {
            int iIndex = cboTurnBars.SelectedIndex;
            if (iIndex < 0)
                return;
            TurnBars turnBar = ((TurnBars)(mcPress.TurnBar(iIndex)));
            if (turnBar == null)
                return;
            cboTurnBars.Text = turnBar.Name;
            cboPredecessor.Text = turnBar.Predecessor;
            chkActive.Checked = turnBar.Checked;
        }

        private void txtTurnBarCount_TextChanged(object sender, EventArgs e)
        {
            if( m_bInitialGeneration == false)
                mcPress.ClearAllTurnBars();
            GenerateTurnBarInfo();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            int iIndex = cboTurnBars.SelectedIndex;
            if (iIndex < 0)
                return;
            TurnBars turnBar = ((TurnBars)mcPress.TurnBar(iIndex));
            if (turnBar == null)
                return;
            if (cboTurnBars.Text == "")
            {
                MessageBox.Show("Select proper TurnBar");
                return;
            }
            if (cboPredecessor.Text == "")
            {
                MessageBox.Show("Select proper Unit");
                return;
            }
            turnBar.Name = cboTurnBars.Text;
            turnBar.Predecessor = cboPredecessor.Text ;
            turnBar.Checked = chkActive.Checked;
        }

        private void cboTurnBars_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        //======================================================================================
        /// <Function>btnInkerNameChange_Click</Function>
        /// <Author>    </Author>
        /// <Date>Sep-21-2008</Date>
        /// <summary>
        /// btn Inker Name Change Click
        /// </summary>
        /// <History>
        /// Hema Dt: 11-03-2008 MT: 11778
        /// </History>
        ///=====================================================================================
        private void btnInkerNameChange_Click(object sender, EventArgs e)
        {
            frmSingleInput frm = new frmSingleInput();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Value = cboTurnBars.Text;
            int iCurrentIdx = cboTurnBars.SelectedIndex;
            if (iCurrentIdx >= 0) 
            {
                frm.ShowDialog();
                string strNewValue = frm.Value;
                if (strNewValue != "")  
                {
                    frm.Dispose();
                    for (int iCount = 0; iCount < cboTurnBars.Items.Count; iCount++)
                    {
                        if (iCount == iCurrentIdx)
                            continue;
                        if (strNewValue == cboTurnBars.Items[iCount].ToString())
                        {
                            MessageBox.Show("Name already Exists");
                            return;
                        }
                    }
                    cboTurnBars.Items[iCurrentIdx] = strNewValue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}