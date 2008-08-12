namespace simple_regexer
{
    partial class MatchCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup( "ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left );
            this.tabControl = new System.Windows.Forms.TabControl();
            this.matchPage = new System.Windows.Forms.TabPage();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.MatchList = new System.Windows.Forms.ListView();
            this.cText = new System.Windows.Forms.ColumnHeader();
            this.cIndex = new System.Windows.Forms.ColumnHeader();
            this.cLen = new System.Windows.Forms.ColumnHeader();
            this.GroupList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabControl.SuspendLayout();
            this.matchPage.SuspendLayout();
            this.groupPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add( this.matchPage );
            this.tabControl.Controls.Add( this.groupPage );
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point( 0, 0 );
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size( 326, 232 );
            this.tabControl.TabIndex = 0;
            // 
            // matchPage
            // 
            this.matchPage.Controls.Add( this.MatchList );
            this.matchPage.Location = new System.Drawing.Point( 4, 4 );
            this.matchPage.Name = "matchPage";
            this.matchPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.matchPage.Size = new System.Drawing.Size( 318, 206 );
            this.matchPage.TabIndex = 0;
            this.matchPage.Text = "Matches";
            this.matchPage.UseVisualStyleBackColor = true;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add( this.GroupList );
            this.groupPage.Location = new System.Drawing.Point( 4, 4 );
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.groupPage.Size = new System.Drawing.Size( 318, 206 );
            this.groupPage.TabIndex = 1;
            this.groupPage.Text = "Groups";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // MatchList
            // 
            this.MatchList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.cText,
            this.cIndex,
            this.cLen} );
            this.MatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchList.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            this.MatchList.Groups.AddRange( new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3} );
            this.MatchList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MatchList.LabelWrap = false;
            this.MatchList.Location = new System.Drawing.Point( 3, 3 );
            this.MatchList.MultiSelect = false;
            this.MatchList.Name = "MatchList";
            this.MatchList.ShowGroups = false;
            this.MatchList.Size = new System.Drawing.Size( 312, 200 );
            this.MatchList.TabIndex = 4;
            this.MatchList.UseCompatibleStateImageBehavior = false;
            this.MatchList.View = System.Windows.Forms.View.Details;
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
            // GroupList
            // 
            this.GroupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3} );
            this.GroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupList.GridLines = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup3";
            this.GroupList.Groups.AddRange( new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6} );
            this.GroupList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.GroupList.LabelWrap = false;
            this.GroupList.Location = new System.Drawing.Point( 3, 3 );
            this.GroupList.MultiSelect = false;
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size( 312, 200 );
            this.GroupList.TabIndex = 4;
            this.GroupList.UseCompatibleStateImageBehavior = false;
            this.GroupList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Text";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Index";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lenght";
            this.columnHeader3.Width = 75;
            // 
            // MatchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.tabControl );
            this.Name = "MatchCtrl";
            this.Size = new System.Drawing.Size( 326, 232 );
            this.tabControl.ResumeLayout( false );
            this.matchPage.ResumeLayout( false );
            this.groupPage.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage matchPage;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.ColumnHeader cText;
        private System.Windows.Forms.ColumnHeader cIndex;
        private System.Windows.Forms.ColumnHeader cLen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView MatchList;
        public System.Windows.Forms.ListView GroupList;
    }
}
