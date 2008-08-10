namespace ReallySimpleRegEx
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainFrm ) );
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.top_Spliter = new System.Windows.Forms.SplitContainer();
            this.rtb_regx = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.mnMatchList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMatchSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.cText = new System.Windows.Forms.ColumnHeader();
            this.cIndex = new System.Windows.Forms.ColumnHeader();
            this.cLen = new System.Windows.Forms.ColumnHeader();
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToolsAutoMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToolEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToolReload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToolReset = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer( this.components );
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFileSaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.top_Spliter.Panel1.SuspendLayout();
            this.top_Spliter.Panel2.SuspendLayout();
            this.top_Spliter.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point( 0, 0 );
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add( this.top_Spliter );
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add( this.rtb_input );
            this.splitContainer1.Size = new System.Drawing.Size( 831, 570 );
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // top_Spliter
            // 
            this.top_Spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_Spliter.Location = new System.Drawing.Point( 0, 0 );
            this.top_Spliter.Name = "top_Spliter";
            // 
            // top_Spliter.Panel1
            // 
            this.top_Spliter.Panel1.Controls.Add( this.rtb_regx );
            // 
            // top_Spliter.Panel2
            // 
            this.top_Spliter.Panel2.Controls.Add( this.listView );
            this.top_Spliter.Size = new System.Drawing.Size( 831, 205 );
            this.top_Spliter.SplitterDistance = 462;
            this.top_Spliter.TabIndex = 0;
            // 
            // rtb_regx
            // 
            this.rtb_regx.ContextMenuStrip = this.contextMenuStrip;
            this.rtb_regx.DetectUrls = false;
            this.rtb_regx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_regx.Location = new System.Drawing.Point( 0, 0 );
            this.rtb_regx.Name = "rtb_regx";
            this.rtb_regx.Size = new System.Drawing.Size( 462, 205 );
            this.rtb_regx.TabIndex = 0;
            this.rtb_regx.Text = "";
            this.rtb_regx.Enter += new System.EventHandler( this.rtb_regx_Enter );
            this.rtb_regx.Leave += new System.EventHandler( this.rtb_regx_Leave );
            this.rtb_regx.TextChanged += new System.EventHandler( this.rtb_TextChanged );
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnMatchList,
            this.toolStripMenuItem1,
            this.mnMatchSelected} );
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size( 205, 70 );
            // 
            // mnMatchList
            // 
            this.mnMatchList.Checked = true;
            this.mnMatchList.CheckOnClick = true;
            this.mnMatchList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnMatchList.Name = "mnMatchList";
            this.mnMatchList.Size = new System.Drawing.Size( 204, 22 );
            this.mnMatchList.Text = "Match List";
            this.mnMatchList.Click += new System.EventHandler( this.mnMatchList_Click );
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size( 204, 22 );
            this.toolStripMenuItem1.Text = "Auto Match";
            // 
            // mnMatchSelected
            // 
            this.mnMatchSelected.Name = "mnMatchSelected";
            this.mnMatchSelected.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5 ) ) );
            this.mnMatchSelected.Size = new System.Drawing.Size( 204, 22 );
            this.mnMatchSelected.Text = "Match Selection";
            this.mnMatchSelected.Click += new System.EventHandler( this.mnMatchSelected_Click );
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.cText,
            this.cIndex,
            this.cLen} );
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            this.listView.Groups.AddRange( new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3} );
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point( 0, 0 );
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size( 365, 205 );
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler( this.listView_SelectedIndexChanged );
            // 
            // cText
            // 
            this.cText.Text = "Text";
            this.cText.Width = 46;
            // 
            // cIndex
            // 
            this.cIndex.Text = "Index";
            this.cIndex.Width = 75;
            // 
            // cLen
            // 
            this.cLen.Text = "Lenght";
            this.cLen.Width = 75;
            // 
            // rtb_input
            // 
            this.rtb_input.ContextMenuStrip = this.contextMenuStrip;
            this.rtb_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_input.Location = new System.Drawing.Point( 0, 0 );
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size( 831, 361 );
            this.rtb_input.TabIndex = 0;
            this.rtb_input.Text = "";
            this.rtb_input.Enter += new System.EventHandler( this.rtb_input_Enter );
            this.rtb_input.Leave += new System.EventHandler( this.rtb_input_Leave );
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem} );
            this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size( 831, 24 );
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "mnStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnFileOpen,
            this.toolStripSeparator,
            this.mnFileSave,
            this.mnFileSaveAs,
            this.toolStripSeparator1,
            this.mnFileExit} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 35, 20 );
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnFileOpen
            // 
            this.mnFileOpen.Image = ( (System.Drawing.Image)( resources.GetObject( "mnFileOpen.Image" ) ) );
            this.mnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnFileOpen.Name = "mnFileOpen";
            this.mnFileOpen.Size = new System.Drawing.Size( 124, 22 );
            this.mnFileOpen.Text = "&Open";
            this.mnFileOpen.Click += new System.EventHandler( this.mnFileOpen_Click );
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size( 121, 6 );
            // 
            // mnFileSave
            // 
            this.mnFileSave.Image = ( (System.Drawing.Image)( resources.GetObject( "mnFileSave.Image" ) ) );
            this.mnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnFileSave.Name = "mnFileSave";
            this.mnFileSave.Size = new System.Drawing.Size( 124, 22 );
            this.mnFileSave.Text = "&Save";
            this.mnFileSave.Click += new System.EventHandler( this.mnFileSave_Click );
            // 
            // mnFileSaveAs
            // 
            this.mnFileSaveAs.Name = "mnFileSaveAs";
            this.mnFileSaveAs.Size = new System.Drawing.Size( 124, 22 );
            this.mnFileSaveAs.Text = "Save &As";
            this.mnFileSaveAs.Click += new System.EventHandler( this.mnFileSaveAs_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 121, 6 );
            // 
            // mnFileExit
            // 
            this.mnFileExit.Name = "mnFileExit";
            this.mnFileExit.Size = new System.Drawing.Size( 124, 22 );
            this.mnFileExit.Text = "E&xit";
            this.mnFileExit.Click += new System.EventHandler( this.mnFileExit_Click );
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem} );
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 125, 6 );
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "cutToolStripMenuItem.Image" ) ) );
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "copyToolStripMenuItem.Image" ) ) );
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "pasteToolStripMenuItem.Image" ) ) );
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size( 125, 6 );
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2} );
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnToolsAutoMatch,
            this.toolStripMenuItem3} );
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size( 124, 22 );
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // mnToolsAutoMatch
            // 
            this.mnToolsAutoMatch.Checked = true;
            this.mnToolsAutoMatch.CheckOnClick = true;
            this.mnToolsAutoMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnToolsAutoMatch.Name = "mnToolsAutoMatch";
            this.mnToolsAutoMatch.Size = new System.Drawing.Size( 140, 22 );
            this.mnToolsAutoMatch.Text = "Auto Match";
            this.mnToolsAutoMatch.Click += new System.EventHandler( this.mnToolsAutoMatch_Click );
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size( 140, 22 );
            this.toolStripMenuItem3.Text = "Match List";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnToolEdit,
            this.mnToolSave,
            this.mnToolReload,
            this.mnToolReset} );
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size( 124, 22 );
            this.toolStripMenuItem2.Text = "Settings";
            // 
            // mnToolEdit
            // 
            this.mnToolEdit.Name = "mnToolEdit";
            this.mnToolEdit.Size = new System.Drawing.Size( 156, 22 );
            this.mnToolEdit.Text = "Edit";
            this.mnToolEdit.Click += new System.EventHandler( this.mnToolEdit_Click );
            // 
            // mnToolSave
            // 
            this.mnToolSave.Name = "mnToolSave";
            this.mnToolSave.Size = new System.Drawing.Size( 156, 22 );
            this.mnToolSave.Text = "Save";
            this.mnToolSave.Click += new System.EventHandler( this.mnToolSave_Click );
            // 
            // mnToolReload
            // 
            this.mnToolReload.Name = "mnToolReload";
            this.mnToolReload.Size = new System.Drawing.Size( 156, 22 );
            this.mnToolReload.Text = "Reload";
            this.mnToolReload.Click += new System.EventHandler( this.mnToolReload_Click );
            // 
            // mnToolReset
            // 
            this.mnToolReset.Name = "mnToolReset";
            this.mnToolReset.Size = new System.Drawing.Size( 156, 22 );
            this.mnToolReset.Text = "Reset Defaults";
            this.mnToolReset.Click += new System.EventHandler( this.mnToolReset_Click );
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem} );
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size( 40, 20 );
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size( 129, 22 );
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size( 126, 6 );
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 129, 22 );
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler( this.timer_Tick );
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.lbl,
            this.ss_count,
            this.ss_status,
            this.lblFileSaveStatus} );
            this.statusStrip.Location = new System.Drawing.Point( 0, 0 );
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size( 831, 22 );
            this.statusStrip.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides)( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.lbl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size( 55, 17 );
            this.lbl.Text = "Matches:";
            // 
            // ss_count
            // 
            this.ss_count.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides)( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.ss_count.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.ss_count.Name = "ss_count";
            this.ss_count.Size = new System.Drawing.Size( 17, 17 );
            this.ss_count.Text = "0";
            // 
            // ss_status
            // 
            this.ss_status.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides)( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.ss_status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.ss_status.Name = "ss_status";
            this.ss_status.Padding = new System.Windows.Forms.Padding( 50, 0, 0, 0 );
            this.ss_status.Size = new System.Drawing.Size( 692, 17 );
            this.ss_status.Spring = true;
            this.ss_status.Text = "Ready";
            // 
            // lblFileSaveStatus
            // 
            this.lblFileSaveStatus.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides)( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.lblFileSaveStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lblFileSaveStatus.DoubleClickEnabled = true;
            this.lblFileSaveStatus.Name = "lblFileSaveStatus";
            this.lblFileSaveStatus.Size = new System.Drawing.Size( 52, 17 );
            this.lblFileSaveStatus.Text = "unsaved";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add( this.statusStrip );
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add( this.splitContainer1 );
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size( 831, 570 );
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size( 831, 616 );
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add( this.menuStrip );
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 831, 616 );
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add( this.toolStripContainer1 );
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainFrm";
            this.Text = "Simple RegX";
            this.splitContainer1.Panel1.ResumeLayout( false );
            this.splitContainer1.Panel2.ResumeLayout( false );
            this.splitContainer1.ResumeLayout( false );
            this.top_Spliter.Panel1.ResumeLayout( false );
            this.top_Spliter.Panel2.ResumeLayout( false );
            this.top_Spliter.ResumeLayout( false );
            this.contextMenuStrip.ResumeLayout( false );
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout( false );
            this.statusStrip.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout( false );
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout( false );
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout( false );
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout( false );
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtb_regx;
        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbl;
        private System.Windows.Forms.ToolStripStatusLabel ss_count;
        private System.Windows.Forms.ToolStripStatusLabel ss_status;
        private System.Windows.Forms.ToolStripStatusLabel lblFileSaveStatus;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnFileExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnToolsAutoMatch;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnToolEdit;
        private System.Windows.Forms.ToolStripMenuItem mnToolSave;
        private System.Windows.Forms.ToolStripMenuItem mnToolReload;
        private System.Windows.Forms.ToolStripMenuItem mnToolReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnMatchList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader cText;
        private System.Windows.Forms.ColumnHeader cIndex;
        private System.Windows.Forms.ColumnHeader cLen;
        public System.Windows.Forms.SplitContainer top_Spliter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnMatchSelected;
    }
}

