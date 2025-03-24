/////////////////////////////////////////////////////////////////////////////
//  
// FormWaterInterface.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen//////////////////////////////////////////////////////////////////////////////
//  
// FormSweepMotorOrServoCtrl.cs: Sweep Motor Or Servo Contorls
//
//  Author:	Hema Kumar           May-14-2009 
//
//	$Header:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterInterface.cs-arc   1.4   Jul 21 2011 14:47:00   MColvin  $
//
//	$Log:   //engr/pvcs/GMIProjects/archives/Microcolor3/Source/MCNWSiteGen/MCNWSiteGen/FormWaterInterface.cs-arc  $
///  
///     Rev 1.4   Jul 21 2011 14:47:00   MColvin
///  MT 16792 - MCNWSiteGen - Add PLC type DtoA for sweep and water control
///  
///     Rev 1.3   May 27 2010 22:59:32   SSomashekaran
///  MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility.
///  
///     Rev 1.2   May 20 2010 05:01:14   SSomashekaran
///  MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled even after the sweep or water interface is changed.
///  
///     Rev 1.1   Jun 04 2009 04:57:04   HNarala
///  MT: 13469
///  
///     Rev 1.0   May 14 2009 03:36:06   HNarala
///  Initial revision.
///  
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
    public partial class FormWaterInterface : Form
    {
        MCPressInfo m_CurrentPress;
        private int waterInterface;
        public int configuredWaterContorl, previousControl;
        private readonly MercuryAVTPLCConfig m_avtPLCConfig = new MercuryAVTPLCConfig();

        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///         
        /// ]]>
        /// <summary>
        /// Initializes a new instance of the <see cref="FormWaterInterface"/> class.
        /// </summary>
        /// <param name="avtPLCConfig">The avt PLC configuration.</param>
        public FormWaterInterface(MercuryAVTPLCConfig avtPLCConfig)
        {
            InitializeComponent();
            m_CurrentPress = null;
            waterInterface = -1;
            configuredWaterContorl = -1;
            previousControl = -1;
            this.m_avtPLCConfig = avtPLCConfig;
        }
        public MCPressInfo CurrentPress
        {
            set { m_CurrentPress = value; }
            get { return m_CurrentPress; }
        }
        /// <![CDATA[
        /// 
        /// < Function: btnOK_Click>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            waterInterface = Set_WaterSelection();
            if (waterInterface >= 0)
            {
                configuredWaterContorl = waterInterface;
                if (ConfigureWaterControl.Checked)
                {
                    CurrentPress.ClientInterface.WaterControl = true;
                }
                else
                    CurrentPress.ClientInterface.WaterControl = false;
            }

            // update PLC Type selected
            if( DefineAndConst.ControlTypes.PLC == waterInterface )
                CurrentPress.WaterInterface.PLCType = PLCNameAndType.GetPLCType( m_plcTypeComboBox.SelectedItem.ToString() );

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// Handles the Click event of the btnConfigure control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConfigure_Click(object sender, EventArgs e)
        {
		// MT16792 markc Jun 20, 2011  add PLC water interface
            if (radioPLC.Checked)
            {
                DisplayPLCConfigDialog();
            }
            else if (radioServoWater.Checked)
            {
                using (FormWaterMotorOrServo waterServo = new FormWaterMotorOrServo())
                {
                    waterServo.CurrentPress = CurrentPress;
                    waterServo.StartPosition = FormStartPosition.CenterParent;
                    waterServo.Tag = "Servo Water";
                    waterServo.ShowDialog();
                    if (waterServo.motorOrServoConfigured)
                    {
                        waterInterface = DefineAndConst.ControlTypes.SERVO; //2;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioMotorWater.Checked)
            {
                using (FormWaterMotorOrServo sweepMotor = new FormWaterMotorOrServo())
                {
                    sweepMotor.CurrentPress = CurrentPress;
                    sweepMotor.StartPosition = FormStartPosition.CenterParent;
                    sweepMotor.Tag = "Motor Water";
                    sweepMotor.ShowDialog();
                    if (sweepMotor.motorOrServoConfigured)
                    {
                        waterInterface = DefineAndConst.ControlTypes.MOTOR; //1;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioBothServoMotor.Checked)
            {
                using (FormWaterMotorServo sweepMotorServo = new FormWaterMotorServo())
                {
                    sweepMotorServo.CurrentPress = CurrentPress;
                    sweepMotorServo.StartPosition = FormStartPosition.CenterParent;
                    sweepMotorServo.ShowDialog();
                    if (sweepMotorServo.bothMotorServoConfigured)
                    {
                        waterInterface = DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO; // 3;
                        DisableUnUsedControls();
                    }
                }
            }
            else if (radioPCU.Checked) 		//WI31010  markc 8/8/13
            {
                using (FormWaterPCU sweepPCU = new FormWaterPCU())
                {
                    sweepPCU.CurrentPress = CurrentPress;
                    sweepPCU.StartPosition = FormStartPosition.CenterParent;
                    sweepPCU.ShowDialog();
                    if (sweepPCU.PCUConfigured)
                    {
                        waterInterface = DefineAndConst.ControlTypes.PCU; // 5
                        DisableUnUsedControls();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select any Control to Configure");
            }
            if (waterInterface > 0)
                ConfigureWaterControl.Checked = true;
            else
                ConfigureWaterControl.Checked = false;
        }


        /// <![CDATA[              
        /// 
        /// Author: unknown
        /// History: 19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// Disables the un used controls.
        /// </summary>
        private void DisableUnUsedControls()
        {
            if (!radioPLC.Checked)
                radioPLC.Enabled = false;
            if (!radioServoWater.Checked)
                radioServoWater.Enabled = false;
            if (!radioMotorWater.Checked)
                radioMotorWater.Enabled = false;
            if (!radioBothServoMotor.Checked)
                radioBothServoMotor.Enabled = false;
            if (!radioPCU.Checked)			//WI31010  markc 8/8/13
                radioPCU.Enabled = false;
            buttonClear.Enabled = true;
            //CheckChangeInSelection();
            this.btnOK.Enabled = true;
        }
        /// <![CDATA[
        /// 
        /// < Function: CheckChangeInSelection>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-27-2010, DEF 15816: MC3SiteGen: Servos does not respond for Sweep and Water if a new site file is created using MC3 Site Gen Utility  
        /// ]]>
        /// <summary>
        /// </summary>

        private void CheckChangeInSelection()
        {
            if (waterInterface >= 0)
            {
                if (previousControl != waterInterface)
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
        /// History:    MT16792 markc Jun 20, 2011  add PLC water interface
        ///             19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///          	03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
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
            radioServoWater.Enabled = true;
            radioMotorWater.Enabled = true;
            radioBothServoMotor.Enabled = true;
            radioPCU.Enabled = true;		//WI31010  markc 8/8/13
            btnOK.Enabled = false;
            buttonClear.Enabled = false;
            waterInterface = 0;
        }
        /// <![CDATA[
        /// 
        /// < Function: FormWaterInterface_Load>
        /// 
        /// < Author: UnKnown>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        ///          05-Apr-13, Mark C, WI30603: Enable / Disable Water options as per number of Fountain ports / SPU
        ///          19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// </summary>
        private void FormWaterInterface_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Location.X + 180, Location.Y + 60);
            {
                switch (previousControl)
                {
                    case DefineAndConst.ControlTypes.NONE:
                        radioServoWater.Checked = true;//By default Servo Water
                        break;
                    case DefineAndConst.ControlTypes.MOTOR:
                        radioMotorWater.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.SERVO:
                        radioServoWater.Checked = true;
                        break;
                    case DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO:
                        radioBothServoMotor.Checked = true;
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
                        radioServoWater.Checked = true; //default will be Servo Water
                        break;                        
                }
            }
            waterInterface = previousControl;
            if (CurrentPress.ClientInterface.WaterControl)
                ConfigureWaterControl.Checked = true;
            else
                ConfigureWaterControl.Checked = false;

            EnableWaterOptions();

            CheckChangeInSelection();
            UpdatePLCType();
        }
        /// <![CDATA[
        /// 
        /// < Function: Set_WaterSelection>
        /// 
        /// < Author: Sreejit Kumar S>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled 
        ///          19-Jul-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// </summary>
        private int Set_WaterSelection()
        {
            int Interface = 0;
            if (radioMotorWater.Checked)
                Interface = DefineAndConst.ControlTypes.MOTOR; //1;
            else if (radioServoWater.Checked)
                Interface = DefineAndConst.ControlTypes.SERVO; //2;
            else if (radioBothServoMotor.Checked)
                Interface = DefineAndConst.ControlTypes.BOTH_MOTOR_AND_SERVO; // 3;
            else if (radioPLC.Checked)
                Interface = DefineAndConst.ControlTypes.PLC; //4;
            else if (radioPCU.Checked)
                Interface = DefineAndConst.ControlTypes.PCU;//5
            else if (radioGOSS.Checked)
                Interface = DefineAndConst.ControlTypes.GOSS_MPU;//6
            return Interface;
        }
        /// <![CDATA[
        /// 
        /// < Function: Water_ConfigChanged>
        /// 
        /// < Author: Sreejit Kumar S>
        /// 
        /// History: Sreejit, MAY-18-2010, DEF 15755: MCSite Gen: In Sweep Interface and Water Interface dialogs the "OK" button doesnt get enabled  
        ///          03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface
        /// ]]>
        /// <summary>
        /// </summary>


        private void Water_ConfigChanged(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
            this.m_plcTypeComboBox.Enabled = radioPLC.Checked; 
        }


        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 
        ///         05-Apr-13, Mark C, WI30603: Enable / Disable Water options as per number of Fountain ports / SPU  
        ///         
        /// ]]>
        /// <summary>
        /// Enables the water options.
        /// </summary>
        private void EnableWaterOptions()
        {
            // Enable Water options Servo, Motor and Both only when number of Fountain ports per SPU are <= 6
            bool waterStatus = (CurrentPress.MaxFountainPortCountPerSPU <= 6);

            radioMotorWater.Enabled = waterStatus;
            radioServoWater.Enabled = waterStatus;
            radioBothServoMotor.Enabled = waterStatus;
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface         
        ///         
        /// ]]>
        /// <summary>
        /// Updates the type of the PLC.
        /// </summary>
        private void UpdatePLCType()
        {
            m_plcTypeComboBox.SelectedItem = PLCNameAndType.GetPLCName( ( ePLCType )CurrentPress.WaterInterface.PLCType );
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface         
        ///          27-Sep-17, Mark C, WI128160: Add support for missing AVT PLC parameters
        ///          10-Jun-19, Mark C, AVT PLC can support up to 10 Water controls only. 
        ///                 So, display a message, if #of Inkers configured are > 10 and AVT PLC is selected to control the Waters.   
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
                    MessageBox.Show( "The AVT PLC can support up to 10 Water controls only. Please configure the number of Inkers accordingly." );
                    return;
                }

                using( MercuryAVTPLCConfigForm avtPLCConfigForm = new MercuryAVTPLCConfigForm( CurrentPress, m_avtPLCConfig, false ) )
                {
                    avtPLCConfigForm.StartPosition = FormStartPosition.CenterParent;
                    if( DialogResult.OK == avtPLCConfigForm.ShowDialog() )
                    {
                        CurrentPress.WaterInterface.PLCType = PLCNameAndType.GetPLCType( m_plcTypeComboBox.SelectedItem.ToString() );
                        waterInterface = DefineAndConst.ControlTypes.PLC;
                    }
                }
            }
            else // Other PLC Type selected              
            {
                using( PLCwater plcWater = new PLCwater( m_plcTypeComboBox.SelectedItem.ToString() ) )
                {
                    plcWater.CurrentPress = CurrentPress;
                    plcWater.StartPosition = FormStartPosition.CenterScreen;
                    plcWater.ShowDialog();
                    if( plcWater.plcCongigured )
                    {
                        waterInterface = DefineAndConst.ControlTypes.PLC; //4;
                        DisableUnUsedControls();
                    }
                }
            }
        }

        /// <![CDATA[              
        /// 
        /// Author: Mark C
        /// History: 03-Aug-17, Mark C, WI102725: Add AVT PLC Support for Water interface         
        ///         
        /// ]]>
        /// <summary>
        /// Called when [PLC type ComboBox selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnPLCTypeComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            this.btnOK.Enabled = true;
        }
    }
}