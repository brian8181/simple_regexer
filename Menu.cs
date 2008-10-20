using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace simple_regexer
{
    class CustomMenu : ContextMenuStrip
    {
        ToolStripMenuItem showMatchList = new System.Windows.Forms.ToolStripMenuItem();
        public ToolStripMenuItem ShowMatchList
        {
            get { return showMatchList; }
            set { showMatchList = value; }
        }
        ToolStripMenuItem autoMatch = new System.Windows.Forms.ToolStripMenuItem();
        public ToolStripMenuItem AutoMatch
        {
            get { return autoMatch; }
            set { autoMatch = value; }
        }
        ToolStripMenuItem match = new System.Windows.Forms.ToolStripMenuItem();
        public ToolStripMenuItem Match
        {
            get { return match; }
            set { match = value; }
        }
        ToolStripMenuItem matchSelected = new System.Windows.Forms.ToolStripMenuItem();
        public ToolStripMenuItem MatchSelected
        {
            get { return matchSelected; }
            set { matchSelected = value; }
        }

        public CustomMenu()
        {
            autoMatch.Checked = true;
            autoMatch.CheckOnClick = true;
            autoMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            autoMatch.Name = "AutoMatch";
            autoMatch.Size = new System.Drawing.Size( 204, 22 );
            autoMatch.Text = "Auto Match";

            showMatchList.Checked = true;
            showMatchList.CheckOnClick = true;
            showMatchList.CheckState = System.Windows.Forms.CheckState.Checked;
            showMatchList.Name = "ShowMatchList";
            showMatchList.Size = new System.Drawing.Size( 204, 22 );
            showMatchList.Text = "Show Match List";

            match.Checked = false;
            match.CheckOnClick = false;
            match.CheckState = System.Windows.Forms.CheckState.Unchecked;
            match.Name = "Match";
            match.Size = new System.Drawing.Size( 204, 22 );
            match.Text = "Match";
            
            matchSelected.Checked = false;
            matchSelected.CheckOnClick = false;
            matchSelected.CheckState = System.Windows.Forms.CheckState.Unchecked;
            matchSelected.Name = "MatchSelected";
            matchSelected.Size = new System.Drawing.Size( 204, 22 );
            matchSelected.Text = "Match Selected";
            
            this.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            autoMatch,
            showMatchList,
            match,
            matchSelected} );
            this.Name = "contextMenuStrip";
            this.Size = new System.Drawing.Size( 205, 92 );
        }
     
    }
}
