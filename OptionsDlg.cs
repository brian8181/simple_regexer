using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using simple_regexer;

namespace simple_regexer
{
    public partial class OptionsDlg : Form
    {
        public Font exp_font = null;
        public Font input_font = null;
        public CheckBox[] options = null;
        /// <summary>
        /// default ctor 
        /// </summary>
        public OptionsDlg()
        {
            InitializeComponent();
            // load config file settings
            LoadSettings();
            // regx options 
            Type TYPE = typeof( System.Text.RegularExpressions.RegexOptions );
            string[] names = Enum.GetNames( TYPE );
            int[] values = (int[])Enum.GetValues( TYPE );
            int len = names.Length;
            options = new CheckBox[10] {  cb1, cb2, cb3, 
                                          cb4, cb5, cb6, 
                                          cb7,cb8, cb9, cb10  };
            for(int i = 0; i < len; ++i)
            {
                options[i].Text = names[i];
                options[i].Tag = values[i];  // save values in Tag
                options[i].Checked = ( ( (int)values[i] & (int)Properties.Settings.Current.regx_options ) != 0 );
            }
        }

        /// <summary>
        /// load settings from current configuration
        /// </summary>
        private void LoadSettings()
        {
            // load controls
            exp_font = Properties.Settings.Current.exp_font;
            input_font = Properties.Settings.Current.input_font;

            string font = String.Format( "{0},{1}",
                exp_font.Name,
                exp_font.SizeInPoints.ToString( "0.0" ) );
            lbl_exp_font.Text = font;

           
            font = String.Format( "{0},{1}",
                  input_font.Name,
                  input_font.SizeInPoints.ToString( "0.0" ) );
            lbl_input_font.Text = font;

            // exp
            lbl_forecolor_name.Text = Properties.Settings.Current.exp_forecolor.Name;
            lbl_backcolor_name.Text = Properties.Settings.Current.exp_backcolor.Name;
            lbl_hl_forecolor_name.Text = Properties.Settings.Current.exp_hl_forecolor.Name;
            lbl_hl_backcolor_name.Text = Properties.Settings.Current.exp_hl_backcolor.Name;
            // input
            lbl_forecolor.BackColor = Properties.Settings.Current.input_forecolor;
            lbl_backcolor.BackColor = Properties.Settings.Current.input_backcolor;
            lbl_hl_forecolor.BackColor = Properties.Settings.Current.input_hl_forecolor;
            lbl_hl_backcolor.BackColor = Properties.Settings.Current.input_hl_backcolor;
            // set tags for look up
            lbl_backcolor.Tag = lbl_backcolor_name;
            lbl_forecolor.Tag = lbl_forecolor_name;
            lbl_hl_forecolor.Tag = lbl_hl_forecolor_name;
            lbl_hl_backcolor.Tag = lbl_hl_backcolor_name;

            iInterval.Value = Properties.Settings.Current.interval;
            iInterval.Enabled = Properties.Settings.Current.auto_match;
        }

        /// <summary>
        ///  set auto matching values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAutoValidate_CheckedChanged( object sender, EventArgs e )
        {
            iInterval.Enabled = iAutoMatch.Checked;
        }
        /// <summary>
        /// ok clicked (unload control into settings)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            Properties.Settings.Current.exp_font = exp_font;
            Properties.Settings.Current.input_font = input_font;

            Properties.Settings.Current.exp_forecolor = lbl_forecolor.BackColor;
            Properties.Settings.Current.exp_backcolor = lbl_backcolor.BackColor;
            Properties.Settings.Current.exp_hl_forecolor = lbl_hl_forecolor.BackColor;
            Properties.Settings.Current.exp_hl_backcolor = lbl_hl_backcolor.BackColor;
            Properties.Settings.Current.input_forecolor = lbl_forecolor.BackColor;
            Properties.Settings.Current.input_backcolor = lbl_backcolor.BackColor;
            Properties.Settings.Current.input_hl_forecolor = lbl_hl_forecolor.BackColor;
            Properties.Settings.Current.input_hl_backcolor = lbl_hl_backcolor.BackColor;

            Properties.Settings.Current.auto_match = iAutoMatch.Checked;
            if( iAutoMatch.Checked )
                Properties.Settings.Current.interval = (int)iInterval.Value;
            
            int len = options.Length;
            for(int i = 0; i < len; ++i)
            {
                if(options[i].Checked)
                    Properties.Settings.Current.regx_options |= (int)options[i].Tag;
            }
        }

        /// <summary>
        /// set expression font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_exp_font_Click( object sender, EventArgs e )
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                exp_font = dlg.Font;

                string font = String.Format( "{0},{1}",
                  exp_font.Name,
                  exp_font.SizeInPoints.ToString( "0.0" ) );

                lbl_exp_font.Text = font;
            }
        }

        /// <summary>
        /// set  input font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_input_font_Click( object sender, EventArgs e )
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                input_font = dlg.Font;

                string font = String.Format("{0},{1}", 
                    input_font.Name, 
                    input_font.SizeInPoints.ToString("0.0"));

                lbl_input_font.Text = font;
            }
        }

        private void lbl_forecolor_Click( object sender, EventArgs e )
        {
            SetColor( (Label)sender );
        }

        private void lbl_backcolor_Click( object sender, EventArgs e )
        {
            SetColor( (Label)sender );
        }

        private void lbl_hl_forecolor_Click( object sender, EventArgs e )
        {
            SetColor( (Label)sender );
        }

        private void lbl_hl_backcolor_Click( object sender, EventArgs e )
        {
            SetColor( (Label)sender );
        }

        /// <summary>
        /// set labels
        /// </summary>
        /// <param name="l"></param>
        private void SetColor( Label l )
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                l.BackColor = dlg.Color;
                ( (Label)l.Tag ).Text = dlg.Color.Name;
            }
        }
    }
}