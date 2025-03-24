/////////////////////////////////////////////////////////////////////////////
//  
// About.cs: Product Info
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

namespace MCNWSiteGen
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            labelBuildDate.Text = MCSiteConfigData.ApplicationBuiltTime;

        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  23-Dec-16, Mark C, WI95713: Created
        ///			  
        /// ]]>
        /// <summary>
        /// Handles the Load event of the About control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void About_Load( object sender, EventArgs e )
        {
            LoadLogoImage( );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <![CDATA[
        /// Author:  Mark C
        /// 
        /// History:  23-Dec-16, Mark C, WI95713: Created
        ///			  
        /// ]]>
        /// <summary>
        /// Loads the logo image.
        /// </summary>
        private void LoadLogoImage()
        {
            m_logoBitmap = Properties.Resources.Mercury_AVT_Logo;
            if ( null != m_logoBitmap )
            {
                // make blue back color transparent
                m_logoBitmap.MakeTransparent( Color.Blue );
                this.m_logoPictureBox.Image = m_logoBitmap;
            }
        }

        #region members

        private Bitmap m_logoBitmap = null;

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}