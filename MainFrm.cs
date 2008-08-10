using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using BKP.Online;

namespace ReallySimpleRegEx
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainFrm : Form
    {
        #region Contruction & Settings
        private volatile string exp = string.Empty;
        private volatile string input = string.Empty;
        private MatchCollection mc = null;
        private FileInfo file_info = null;
        private bool file_dirty = false;
        /// <summary>
        /// 
        /// </summary>
        public MainFrm()
        {
            InitializeComponent();
            timer.Enabled = false;
            ss_status.Text = Properties.Resources.READY_WAITING_ALT1;
            // empty match
            mc = Regex.Matches( "x", "y" );

            Properties.Settings.Current = Properties.Settings.Default;
            LoadSettings();
            rtb_input.SelectionProtected = false;
        }

        private Color input_hl_forecolor;
        private Color input_hl_backcolor;
        private Color input_backcolor;
        private Color input_forecolor;
        private volatile bool auto_match;
        private int interval;
        // do here default is 0 
        private RegexOptions regx_options = RegexOptions.Multiline;
        /// <summary>
        /// load or reloads settings 
        /// </summary>
        private void LoadSettings()
        {
            rtb_regx.Font = Properties.Settings.Current.exp_font;
            rtb_input.Font = Properties.Settings.Current.input_font; 
            input_backcolor = Properties.Settings.Current.input_backcolor;
            input_forecolor = Properties.Settings.Current.input_forecolor;
            input_hl_backcolor = Properties.Settings.Current.input_hl_backcolor;
            input_hl_forecolor = Properties.Settings.Current.input_hl_forecolor;
            auto_match = Properties.Settings.Current.auto_match;
            interval = Properties.Settings.Current.interval;
            UpdateFileStatus();
        }
        /// <summary>
        ///  commit current to file
        /// </summary>
        private void SaveSettings()
        {
            // copy defaults
            Properties.Settings.SyncSettings();
            Properties.Settings.Default.Save();
            // go aheead a save both
            Properties.Settings.Current.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnToolEdit_Click( object sender, EventArgs e )
        {
            OptionsDlg dlg = new OptionsDlg();
            if(dlg.ShowDialog( this ) == DialogResult.OK)
            {
                LoadSettings();

                if(StdMsgBox.YesNo( "Do want to commit this configuartion now?" ) == DialogResult.Yes)
                {
                    SaveSettings();
                }
            }
        }
        /// <summary>
        /// save config settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnToolSave_Click( object sender, EventArgs e )
        {
            SaveSettings();
        }
        /// <summary>
        /// reload config for file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnToolReload_Click( object sender, EventArgs e )
        {
            LoadSettings();
        }
        /// <summary>
        /// reset this restores defaults to pesistent storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnToolReset_Click( object sender, EventArgs e )
        {
            // resets but does not save 
            Properties.Settings.Current.Reset();
            Properties.Settings.Current = Properties.Settings.Default;
        }
        #endregion

        #region Open & Save
        private void mnFileOpen_Click( object sender, EventArgs e )
        {
            FileOpenDialog();
        }
        private void mnFileSave_Click( object sender, EventArgs e )
        {
            Save();
        }
        private void mnFileSaveAs_Click( object sender, EventArgs e )
        {
            FileSaveAsDialog();
        }
        /// <summary>
        /// open a file
        /// </summary>
        public void FileOpenDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = Properties.Resources.FILE_FILTER;
            dlg.DefaultExt = Properties.Resources.DEFAULT_EXT;
            dlg.DereferenceLinks = false;
            dlg.RestoreDirectory = true;
            dlg.ValidateNames = true;
            dlg.RestoreDirectory = true;
            dlg.Multiselect = false;
            dlg.SupportMultiDottedExtensions = true;
            dlg.InitialDirectory = Environment.GetFolderPath
                ( Environment.SpecialFolder.MyDocuments );

            DialogResult res = MessageBox.Show( Properties.Resources.SAVE_PROMPT,
                    Properties.Resources.SAVE_PROMPT_CAPTION, MessageBoxButtons.YesNo );
            // save the working file
            if(res == DialogResult.OK)
            {
                Save();
            }

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                if(File.Exists( file ))
                    rtb_regx.Text = File.ReadAllText( file );
                // file status
                file_info = new FileInfo( file );
                file_dirty = false;
            }
            UpdateFileStatus();
        }
        /// <summary>
        /// save file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save()
        {
            // just save if exsit
            if(file_info != null && file_info.Exists)
                File.WriteAllText( file_info.FullName, rtb_regx.Text );
            else
                FileSaveDialog( true,
                                Properties.Resources.DEFAULT_EXT,
                                Properties.Resources.FILE_FILTER,
                                "Create" );
        }
        /// <summary>
        ///  save a file with common options
        /// </summary>
        public void FileSaveAsDialog()
        {
            FileSaveDialog( true,
                            Properties.Resources.DEFAULT_EXT,
                            Properties.Resources.FILE_FILTER,
                            "Saving As" );
        }
        /// <summary>
        /// save or creates a file
        /// </summary>
        /// <param name="creating"></param>
        /// <param name="ext"></param>
        /// <param name="filter"></param>
        public void FileSaveDialog( bool creating, string ext, string filter, string title )
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = title;
            dlg.Filter = filter;
            dlg.DefaultExt = ext;
            dlg.CreatePrompt = creating;
            dlg.DereferenceLinks = false;
            dlg.OverwritePrompt = true;
            dlg.RestoreDirectory = true;
            dlg.ValidateNames = true;
            dlg.RestoreDirectory = true;
            dlg.SupportMultiDottedExtensions = true;
            dlg.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments );
            //dlg.FileName = file_info.FullName;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                file_info = new FileInfo( file );
                File.WriteAllText( file, rtb_regx.Text );
                // file status
                file_dirty = false;
            }
            UpdateFileStatus();
        }
        /// <summary>
        /// update file status
        /// </summary>
        public void UpdateFileStatus()
        {
            if(file_info != null)
                lblFileSaveStatus.Text = file_info.Name + " : " + ( ( file_dirty ) ? "updated" : "saved" );
            else
                lblFileSaveStatus.Text = "unsaved";
        }
        #endregion
              
        #region RichTextBox Events
        /// <summary>
        ///  regx box entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_regx_Enter( object sender, EventArgs e )
        {
            //RichTextBox rtb = (RichTextBox)sender;
            //rtb_regx_focus = rtb;
            TryMatch();
            // used for clipboard
            //rtb_captured = rtb;
        }
        /// <summary>
        ///  regx box leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_regx_Leave( object sender, EventArgs e )
        {
            // used for clipboard
            //rtb_captured = null;
        }
        /// <summary>
        /// begin edit input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_input_Enter( object sender, EventArgs e )
        {
            FormatMatchText( input_backcolor );
            timer.Enabled = false;
            this.ss_status.Text = Properties.Resources.EDITING_INPUT;
            auto_match = false; // turn off 
        }
        /// <summary>
        /// end edit input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_input_Leave( object sender, EventArgs e )
        {
            this.ss_status.Text = Properties.Resources.READY_WAITING;
            auto_match = mnToolsAutoMatch.Checked;
        }
        /// </summary>
        /// regx text changed - toggles the edit events 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_TextChanged( object sender, EventArgs e )
        {
            //SyntaxHighlight();
            if(auto_match)
            {
                ss_status.Text = Properties.Resources.EDITING_EXP;
                timer.Enabled = true;
            }
            file_dirty = true;
        }
        #endregion

        /// <summary>
        /// timer tick,  edit timer timeout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick( object sender, EventArgs e )
        {
            if(auto_match && timer.Enabled)
            {
                this.Invoke( new VoidDelegate( TryMatch ) );
            }
        }
        public void TryMatchSelected()
        {
            this.exp = rtb_regx.SelectedText.Replace( "\n", "" );
            TryMatch( exp );
        }
        /// <summary>
        ///   make regex matches
        /// </summary>
        public void TryMatch()
        {
            if(rtb_regx != null && string.IsNullOrEmpty( rtb_regx.Text ))
                return;
            //ResetTextColor( rtb_regx );
            this.exp = rtb_regx.Text.Replace( "\n", "" );
            TryMatch( exp );
        }
        /// <summary>
        /// make regex matches
        /// </summary>
        private void TryMatch( string exp )
        {
            this.timer.Enabled = false;
            this.input = this.rtb_input.Text;
            FormatMatchText( input_backcolor );
            if(exp != string.Empty && input != string.Empty)
            {
                try
                {
                    mc = Regex.Matches( input, exp, regx_options );
                    ss_status.Text = Properties.Resources.MATCHED;
                    FormatMatchText( input_hl_backcolor );
                    UpdateFileStatus();
                } catch(ArgumentException)
                {
                    ss_status.Text = Properties.Resources.INVALID_EXPRESSION;
                }
            }
            else
            {
                ss_status.Text = Properties.Resources.READY_WAITING;
            }
        }
        /// <summary>
        /// highlight matches                                                                                   
        /// </summary>
        /// <param name="c"></param>
        private void FormatMatchText( Color c )
        {
            listView.Items.Clear();
            foreach(Match m in mc)
            {
                rtb_input.SelectionStart = m.Index;
                rtb_input.SelectionLength = m.Length;
                rtb_input.SelectionBackColor = c;

                ListViewItem item = listView.Items.Add( m.Value );
                item.SubItems.Add( m.Index.ToString() );
                item.SubItems.Add( m.Length.ToString() );

                //if(m.Groups.Count > 0)
                //{
                //    foreach(Group g in m.Groups)
                //    {
                //        item.SubItems.Add( g.Index + g.Index + " : \"" + g.Value );

                //    }
                //};
            }
            rtb_input.SelectionStart = 0;
            rtb_input.SelectionLength = 0;
            rtb_input.SelectionBackColor = input_backcolor;
            ss_count.Text = mc.Count.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnToolsAutoMatch_Click( object sender, EventArgs e )
        {
            auto_match = mnToolsAutoMatch.Checked;
        }
        /// <summary>
        /// show \ hide match list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnMatchList_Click( object sender, EventArgs e )
        {
            top_Spliter.Panel2Collapsed = !mnMatchList.Checked;
  
        }

        private void mnFileExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void mnMatchSelected_Click( object sender, EventArgs e )
        {
            timer.Enabled = false; // disable timer
            TryMatchSelected();
        }

        private void listView_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        //private void SyntaxHighlight()
        //{
        //    string input = rtb_regx.Text;

        //    MatchCollection mc = Regex.Matches( input, syntax, RegexOptions.Multiline );

        //    int idx = rtb_regx.SelectionStart;
        //    foreach( Match m in mc )
        //    {
        //        Group g = m.Groups["g1"];
        //        rtb_regx.SelectionStart = g.Index;
        //        rtb_regx.SelectionLength = g.Length;
        //        rtb_regx.SelectionBackColor = Color.Yellow;

        //        g = m.Groups["g2"];
        //        rtb_regx.SelectionStart = g.Index;
        //        rtb_regx.SelectionLength = g.Length;
        //        rtb_regx.SelectionBackColor = Color.Green;

        //        g = m.Groups["g3"];
        //        rtb_regx.SelectionStart = g.Index;
        //        rtb_regx.SelectionLength = g.Length;
        //        rtb_regx.SelectionBackColor = Color.Blue;

        //    }

        //    rtb_regx.SelectionStart = idx;
        //    rtb_regx.SelectionLength = 0;
        //    rtb_regx.SelectionColor = Properties.Settings.Current.exp_backcolor;
        //}
    }
}