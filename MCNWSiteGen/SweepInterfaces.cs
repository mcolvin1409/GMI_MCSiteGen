/////////////////////////////////////////////////////////////////////////////
//  
// SweepInterfaces.cs: Sweep Interfaces
//
//  Author:	Hema Kumar           Sep-04-2008 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/SweepInterfaces.cs-arc   1.6   Jul 21 2011 14:47:18   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/SweepInterfaces.cs-arc  $
///  
///     Rev 1.6   Jul 21 2011 14:47:18   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.5   May 27 2010 22:59:42   SSomashekaran
///  MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility.
///  
///     Rev 1.4   May 20 2010 05:01:18   SSomashekaran
///  MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled even after the sweep or water interface is changed.
///  
///     Rev 1.3   Jun 04 2009 05:01:40   HNarala
///  For Mt: 13469
///  
///     Rev 1.2   May 14 2009 04:07:48   HNarala
///  MT 13162
///  
///     Rev 1.1   Nov 12 2008 23:21:06   HNarala
///  MT#11779
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

namespace MCNWSiteGen
{
    public partial class SweepInterfaces : Form
    {
        MCPressInfo m_CurrentPress;
        private int sweepInterface;
        public int configuredSweepContorl, previousControl;
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepInterfaces"/> class.
        /// </summary>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        public SweepInterfaces(MercuryAVTPLCConfig avtPLCConfig)
        {
            InitializeComponent();
            m_CurrentPress = null;
            sweepInterface = -1;
            configuredSweepContorl = -1;
            previousControl = -1;
            this.m_avtPLCConfig = avtPLCConfig;
        }
        public MCPressInfo CurrentPress
        {
            get { return m_CurrentPress; }
            set { m_CurrentPress = value; }
        }

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// Handles the Click event of the btnConfigure control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConfigure_Click(object sender, EventArgs e)
        {
            if (radioPLC.Checked)
            {
                DisplayPLCConfigDialog();                
            }
            else if (radioServoSweeps.Checked)
            {
                using (FormSweepMotorOrServoCtrl sweepServo= new FormSweepMotorOrServoCtrl())
                {
                    sweepServo.CurrentPress = CurrentPress;
                    sweepServo.StartPosition = FormStartPosition.CenterParent;
                    sweepServo.Tag = "Servo Sweep";
                    sweepServo.ShowDialog();
                    if (sweepServo.motorOrServoConfigured)
                    {
                        sweepInterface = DefineAndConst.ControlTypes.SERVO; //2;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioSWEEPMTR.Checked)
            {
                using (FormSweepMotorOrServoCtrl sweepMotor = new FormSweepMotorOrServoCtrl())
                {
                    sweepMotor.CurrentPress = CurrentPress;
                    sweepMotor.StartPosition = FormStartPosition.CenterParent;
                    sweepMotor.Tag = "Motor Sweep";
                    sweepMotor.ShowDialog();
                    if (sweepMotor.motorOrServoConfigured)
                    {
                        sweepInterface = DefineAndConst.ControlTypes.MOTOR; //1;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioBoth.Checked)
            {
                using (FormSweepMotorServo sweepMotorServo = new FormSweepMotorServo())
                {
                    sweepMotorServo.CurrentPress = CurrentPress;
                    sweepMotorServo.StartPosition = FormStartPosition.CenterParent;
                    sweepMotorServo.ShowDialog();
                    if (sweepMotorServo.bothMotorServoConfigured)
                    {
                        sweepInterface = DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO; // 3;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioPCU.Checked)
            {
                using (FormSweepPCU sweepPCU = new FormSweepPCU())
                {
                    sweepPCU.CurrentPress = CurrentPress;
                    sweepPCU.StartPosition = FormStartPosition.CenterParent;
                    sweepPCU.ShowDialog();
                    if (sweepPCU.PCUConfigured)
                    {
                        sweepInterface = DefineAndConst.ControlTypes.PCU; // 5;
                        DisableUnUsedControls();
                    }
                }
            }
            if (sweepInterface >= 0)
                ConfigureSweepControl.Checked = true;
        }

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// Disables the un used controls.
        /// </summary>
        private void DisableUnUsedControls()
        {
            if (!radioPLC.Checked)
                radioPLC.Enabled = false;
            if (!radioServoSweeps.Checked)
                radioServoSweeps.Enabled = false;
            if (!radioSWEEPMTR.Checked)
                radioSWEEPMTR.Enabled = false;
            if (!radioBoth.Checked)
                radioBoth.Enabled = false;
            if (!radioPCU.Checked)
                radioPCU.Enabled = false;
            buttonClear.Enabled = true;
            this.btnOK.Enabled = true;
        }
        /// <![CDATA[
        /// 
        /// < Function: btnOK_Click>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// </summary>

        private void btnOK_Click(object sender, EventArgs e)
        {
            sweepInterface = Set_SweepSelection();
            if (sweepInterface >= 0)
            {
                
                configuredSweepContorl = sweepInterface;
                if (ConfigureSweepControl.Checked)
                    CurrentPress.ClientInterface.SweepControl = true;
                else
                    CurrentPress.ClientInterface.SweepControl = false;
            }

            // update PLC Type selected
            if (DefineAndConst.ControlTypes.PLC == sweepInterface)
                CurrentPress.SweepInterface.PLCType = PLCNameAndType.GetPLCType( m_plcTypeComboBox.SelectedItem.ToString() );

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <![CDATA[
        /// 
        /// < Function: SweepInterface_Load>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        /// MarkC MT 16792 6/20/11 default sweep interface is MOTOR
        ///         05-Apr-13, Mark C, WI30603: Enable / Disable Sweep options as per number of Fountain ports / SPU  
        ///         19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// </summary>
        private void SweepInterface_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 180, Location.Y + 60);
            {
                switch (previousControl)
                {
                    case DefineAndConst.ControlTypes.NONE:
                        radioServoSweeps.Checked = true;//By default Servo Sweep
                        break;
                    case DefineAndConst.ControlTypes.MOTOR:
                        radioSWEEPMTR.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.SERVO:
                        radioServoSweeps.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO:
                        radioBoth.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.PLC:
                        radioPLC.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.PCU:
                        radioPCU.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.GOSS_MPU:
                        radioGOSS.Checked = true;
                        break;
                    default:                        
                        radioSWEEPMTR.Checked = true;//default will be Motor Sweep
                        break;                        
                }
            }
            sweepInterface = previousControl;
            if (CurrentPress.ClientInterface.SweepControl)
                ConfigureSweepControl.Checked = true;
            else
                ConfigureSweepControl.Checked = false;
                        
            EnableSweepOptions();

            CheckChangeInSelection();
            UpdatePLCType();
        }
        /// <![CDATA[
        /// 
        /// < Function: CheckChangeInSelection>
        /// 
        /// < Author: Sreejit Kumar S>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        /// ]]>
        /// <summary>
        /// </summary>


        private void CheckChangeInSelection()
        {
            if (sweepInterface >= 0)
            {
                if (previousControl != sweepInterface)
                    this.btnOK.Enabled = true;
                else
                    this.btnOK.Enabled = false;
            }
            else
                this.btnOK.Enabled = false;
        }

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        ///         
        /// ]]>
        /// <summary>
        /// Handles the Click event of the buttonClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {            
            radioPLC.Enabled = true;
            radioServoSweeps.Enabled = true;
            radioSWEEPMTR.Enabled = true;
            radioBoth.Enabled = true;
            radioPCU.Enabled = true;
            btnOK.Enabled = false;
            buttonClear.Enabled = false;
        }
        /// <![CDATA[
        /// 
        /// < Function: Set_SweepSelection>
        /// 
        /// < Author: Sreejit Kumar S>
        /// 
        /// History:    Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        ///             19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Sweep interface
        ///          	03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// </summary>
        private int Set_SweepSelection()
        {
            int Interface = 0;
            if (radioSWEEPMTR.Checked)
                Interface = DefineAndConst.ControlTypes.MOTOR;//1
            else if (radioServoSweeps.Checked)
                Interface = DefineAndConst.ControlTypes.SERVO; //2
            else if (radioBoth.Checked)
                Interface = DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO;//3
            else if (radioPLC.Checked)
                Interface = DefineAndConst.ControlTypes.PLC; //4
            else if (radioPCU.Checked)
                Interface = DefineAndConst.ControlTypes.PCU;//5
            else if (radioGOSS.Checked)
                Interface = DefineAndConst.ControlTypes.GOSS_MPU;//6
            return Interface;
       }
        /// <![CDATA[
        /// 
        /// < Function: Sweep_ConfigChanged>
        /// 
        /// < Author: Sreejit Kumar S>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support
        /// ]]>
        /// <summary>
        /// </summary>


        private void Sweep_ConfigChanged(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
            this.m_plcTypeComboBox.Enabled = radioPLC.Checked;
        }


        /// <![CDATA[
        /// 
        /// Author: Mark C
        /// History:
        ///         05-Apr-13, Mark C, WI30603: Enable / Disable Sweep options as per number of Fountain ports / SPU  
        /// ]]>
        /// <summary>
        /// Enables the sweep options.
        /// </summary>
        private void EnableSweepOptions()
        {
            // Enable Sweep options Servo, Motor and Both only when number of Fountain ports per SPU are <= 6
            bool sweepStatus = (CurrentPress.MaxFountainPortCountPerSPU <= 6);

            radioSWEEPMTR.Enabled = sweepStatus;
            radioServoSweeps.Enabled = sweepStatus;
            radioBoth.Enabled = sweepStatus;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC
        ///         
        /// ]]>
        /// <summary>
        /// Updates the type of the PLC.
        /// </summary>
        private void UpdatePLCType()
        {
            m_plcTypeComboBox.SelectedItem = PLCNameAndType.GetPLCName( ( ePLCType )CurrentPress.SweepInterface.PLCType );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC
		/// 		 27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          10-Jun-19, Mark C, AVT PLC can support up to 10 Sweep controls only. 
        ///                 So, display a message, if #of Inkers configured are > 10 and AVT PLC is selected to control the Sweeps.          
        /// 
        /// ]]>
        /// <summary>
        /// Displays the PLC configuration dialog.
        /// </summary>
        private void DisplayPLCConfigDialog()
        {
            // AVT PLC Type Selected
            if( ePLCType.ePLC_AVT == ( ePLCType )PLCNameAndType.GetPLCType( m_plcTypeComboBox.SelectedItem.ToString() ) )
            {
                // Currently, AVT PLC can support up to 10 Inkers only. Let's check the #of Inkers accordingly
                if (CurrentPress.InkerList.Count > 10 && !CurrentPress.ClientInterface.VirtualInkers)
                {
                    MessageBox.Show( "The AVT PLC can support up to 10 Sweep controls only. Please configure the number of Inkers accordingly." );
                    return;
                }

                using( MercuryAVTPLCConfigForm avtPLCConfigForm = new MercuryAVTPLCConfigForm( CurrentPress, m_avtPLCConfig, true ) )
                {
                    avtPLCConfigForm.StartPosition = FormStartPosition.CenterParent;
                    if( DialogResult.OK == avtPLCConfigForm.ShowDialog() )
                    {
                        CurrentPress.SweepInterface.PLCType = PLCNameAndType.GetPLCType( m_plcTypeComboBox.SelectedItem.ToString() );
                        sweepInterface = DefineAndConst.ControlTypes.PLC;
                    }
                }
            }
            else // Other PLC Type selected              
            {
                using( PLCSweep plcSweep = new PLCSweep( m_plcTypeComboBox.SelectedItem.ToString() ) )
                {
                    plcSweep.CurrentPress = CurrentPress;
                    plcSweep.StartPosition = FormStartPosition.CenterScreen;
                    plcSweep.ShowDialog();
                    if( plcSweep.plcConfigured )
                    {
                        sweepInterface = DefineAndConst.ControlTypes.PLC; //4;
                        DisableUnUsedControls();
                    }
                }
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add support for AVT PLC
        ///         
        /// ]]>
        /// <summary>
        /// Called when [PLC type ComboBox selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPLCTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
        }
    }
}
