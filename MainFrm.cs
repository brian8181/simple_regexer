using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Utility;

namespace simple_regexer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainFrm : Form
    {
        #region Contruction & Settings
        private volatile string exp = string.Empty;
        private volatile string input = string.Empty;
        private Regex regx = null;
        private MatchCollection mc = null;
        private FileInfo file_info = null;
        private Document doc = null;

        /// <summary>
        /// 
        /// </summary>
        public MainFrm()
        {
            InitializeComponent();

            Properties.Settings.Current = Properties.Settings.Default;
            LoadSettings();
            InitDocument();
        }

        public void InitDocument()
        {
            timer.Enabled = false;
            ss_status.Text = Properties.Resources.READY_WAITING_ALT1;
            // empty match
            mc = Regex.Matches("x", "y");
            rtb_input.SelectionProtected = false;
            doc = new Document( rtb_regx, rtb_input );
            doc.StatusChanged += new EventHandler( doc_StatusChanged );
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

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OptionsDlg dlg = new OptionsDlg();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                LoadSettings();

                if (StdMsgBox.YesNo("Do want to commit this configuartion now?") == DialogResult.Yes)
                {
                    SaveSettings();
                }
            }
        }
        #endregion

        #region New, Open & Save

        // todo Work in Progress
        /// <summary>
        /// clear current doc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnFileNew_Click(object sender, EventArgs e)
        {
            file_info = null;
            rtb_regx.Text = string.Empty;
            rtb_input.Text = string.Empty;
            lblFileSaveStatus.Text = "unsaved";
            ss_count.Text = "0";

            InitDocument();
            matchCtrl.ClearAll();
        }


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
            if(doc.isDirty)
            {
                DialogResult res = MessageBox.Show( Properties.Resources.SAVE_PROMPT,
                        Properties.Resources.SAVE_PROMPT_CAPTION, MessageBoxButtons.YesNo );
                // save the working file
                if(res == DialogResult.OK)
                {
                    Save();
                }
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = Properties.Resources.FILE_FILTER;
            dlg.FilterIndex = 2;
            dlg.DefaultExt = Properties.Resources.DEFAULT_EXT;
            dlg.DereferenceLinks = false;
            dlg.RestoreDirectory = true;
            dlg.ValidateNames = true;
            dlg.RestoreDirectory = true;
            dlg.Multiselect = false;
            dlg.SupportMultiDottedExtensions = true;
            dlg.InitialDirectory = Environment.GetFolderPath
                ( Environment.SpecialFolder.MyDocuments );
                  
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                file_info = new FileInfo( file );
                doc.Open( file_info );
                doc.Read();
            }
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
                doc.Write();
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
            dlg.FilterIndex = 2;
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
                doc.Open( file_info );
                doc.Write();
            }
        }

        void doc_StatusChanged( object sender, EventArgs e )
        {
            lblFileSaveStatus.Text = doc.Name + " : " + (doc.isDirty ? "updated" : "saved");
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
                    regx = new Regex( exp, regx_options );
                    mc = regx.Matches( input );
                    ss_status.Text = Properties.Resources.MATCHED;
                    FormatMatchText( input_hl_backcolor );
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
            // clear all
            matchCtrl.ClearAll();

            // get regex group names
            string[] groups = null;
            if(regx != null)
            {
                groups = regx.GetGroupNames();
                foreach(string g in groups)
                {
                    matchCtrl.GroupList.Groups.Add( g, g );
                }
            }
            
            foreach(Match m in mc)
            {
                rtb_input.SelectionStart = m.Index;
                rtb_input.SelectionLength = m.Length;
                rtb_input.SelectionBackColor = c;

                ListViewItem item = matchCtrl.MatchList.Items.Add( m.Value );
                item.SubItems.Add( m.Index.ToString() );
                item.SubItems.Add( m.Length.ToString() );


                foreach(string g in groups)
                {
                     Group exp_grp = m.Groups[g];
                     item = matchCtrl.GroupList.Items.Add( exp_grp.Value );
                     matchCtrl.GroupList.Groups[g].Items.Add( item );
                     item.SubItems.Add( exp_grp.Index.ToString() );
                     item.SubItems.Add( exp_grp.Length.ToString() );
                }
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
            //top_Spliter.Panel2Collapsed = !cmnMatchList.Checked;
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

        private void MainFrm_FormClosing( object sender, FormClosingEventArgs e )
        {
            if(doc.isDirty)
            {
                DialogResult res = MessageBox.Show( Properties.Resources.SAVE_PROMPT,
                             Properties.Resources.SAVE_PROMPT_CAPTION, MessageBoxButtons.YesNo );
                // save the working file
                if(res == DialogResult.OK)
                {
                    Save();
                }
            }
        }
              
        private void cmnAutoMatch_Click(object sender, EventArgs e)
        {
            if (auto_match)
            {
                FormatMatchText(input_backcolor);
                auto_match = false;
            }
            else
            {
                TryMatch();
                auto_match = true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.ShowDialog();
        }
    }
}