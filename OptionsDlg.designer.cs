namespace ReallySimpleRegEx
{
    partial class OptionsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.iInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.iAutoMatch = new System.Windows.Forms.CheckBox();
            this.lblFont1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_backcolor = new System.Windows.Forms.Label();
            this.lbl_forecolor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_exp_font = new System.Windows.Forms.Label();
            this.lbl_backcolor_name = new System.Windows.Forms.Label();
            this.lbl_forecolor_name = new System.Windows.Forms.Label();
            this.grpgt = new System.Windows.Forms.GroupBox();
            this.lbl_input_font = new System.Windows.Forms.Label();
            this.lblFont2 = new System.Windows.Forms.Label();
            this.lbl_hl_backcolor_name = new System.Windows.Forms.Label();
            this.lbl_hl_forecolor_name = new System.Windows.Forms.Label();
            this.lbl_hl_forecolor = new System.Windows.Forms.Label();
            this.lbl_hl_backcolor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbghnt = new System.Windows.Forms.GroupBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            ( (System.ComponentModel.ISupportInitialize)( this.iInterval ) ).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpgt.SuspendLayout();
            this.gbghnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point( 352, 335 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 271, 335 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // iInterval
            // 
            this.iInterval.Increment = new decimal( new int[] {
            100,
            0,
            0,
            0} );
            this.iInterval.Location = new System.Drawing.Point( 112, 19 );
            this.iInterval.Maximum = new decimal( new int[] {
            5000,
            0,
            0,
            0} );
            this.iInterval.Minimum = new decimal( new int[] {
            100,
            0,
            0,
            0} );
            this.iInterval.Name = "iInterval";
            this.iInterval.Size = new System.Drawing.Size( 80, 20 );
            this.iInterval.TabIndex = 2;
            this.iInterval.Value = new decimal( new int[] {
            2000,
            0,
            0,
            0} );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 198, 24 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 20, 13 );
            this.label1.TabIndex = 3;
            this.label1.Text = "ms";
            // 
            // iAutoMatch
            // 
            this.iAutoMatch.AllowDrop = true;
            this.iAutoMatch.AutoSize = true;
            this.iAutoMatch.Checked = true;
            this.iAutoMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iAutoMatch.Location = new System.Drawing.Point( 27, 20 );
            this.iAutoMatch.Name = "iAutoMatch";
            this.iAutoMatch.Size = new System.Drawing.Size( 84, 17 );
            this.iAutoMatch.TabIndex = 4;
            this.iAutoMatch.Text = "Auto Match:";
            this.iAutoMatch.UseVisualStyleBackColor = true;
            this.iAutoMatch.CheckedChanged += new System.EventHandler( this.cbAutoValidate_CheckedChanged );
            // 
            // lblFont1
            // 
            this.lblFont1.Location = new System.Drawing.Point( 11, 19 );
            this.lblFont1.Name = "lblFont1";
            this.lblFont1.Size = new System.Drawing.Size( 64, 13 );
            this.lblFont1.TabIndex = 5;
            this.lblFont1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.label1 );
            this.groupBox2.Controls.Add( this.iAutoMatch );
            this.groupBox2.Controls.Add( this.iInterval );
            this.groupBox2.Location = new System.Drawing.Point( 6, 2 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 249, 57 );
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 11, 92 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 59, 13 );
            this.label5.TabIndex = 10;
            this.label5.Text = "BackColor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 11, 58 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 55, 13 );
            this.label6.TabIndex = 11;
            this.label6.Text = "ForeColor:";
            // 
            // lbl_backcolor
            // 
            this.lbl_backcolor.BackColor = System.Drawing.Color.White;
            this.lbl_backcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_backcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_backcolor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_backcolor.ForeColor = System.Drawing.Color.White;
            this.lbl_backcolor.Location = new System.Drawing.Point( 86, 80 );
            this.lbl_backcolor.Name = "lbl_backcolor";
            this.lbl_backcolor.Size = new System.Drawing.Size( 25, 26 );
            this.lbl_backcolor.TabIndex = 9;
            this.lbl_backcolor.Click += new System.EventHandler( this.lbl_backcolor_Click );
            // 
            // lbl_forecolor
            // 
            this.lbl_forecolor.BackColor = System.Drawing.Color.Black;
            this.lbl_forecolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_forecolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forecolor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_forecolor.Location = new System.Drawing.Point( 87, 45 );
            this.lbl_forecolor.Name = "lbl_forecolor";
            this.lbl_forecolor.Size = new System.Drawing.Size( 24, 26 );
            this.lbl_forecolor.TabIndex = 8;
            this.lbl_forecolor.Click += new System.EventHandler( this.lbl_forecolor_Click );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.lbl_exp_font );
            this.groupBox1.Controls.Add( this.lblFont1 );
            this.groupBox1.Controls.Add( this.lbl_backcolor_name );
            this.groupBox1.Controls.Add( this.lbl_forecolor_name );
            this.groupBox1.Controls.Add( this.lbl_forecolor );
            this.groupBox1.Controls.Add( this.lbl_backcolor );
            this.groupBox1.Controls.Add( this.label6 );
            this.groupBox1.Controls.Add( this.label5 );
            this.groupBox1.Location = new System.Drawing.Point( 6, 69 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 249, 127 );
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // lbl_exp_font
            // 
            this.lbl_exp_font.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_exp_font.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_font.Location = new System.Drawing.Point( 87, 16 );
            this.lbl_exp_font.Name = "lbl_exp_font";
            this.lbl_exp_font.Size = new System.Drawing.Size( 134, 21 );
            this.lbl_exp_font.TabIndex = 16;
            this.lbl_exp_font.Text = "Font";
            this.lbl_exp_font.Click += new System.EventHandler( this.lbl_exp_font_Click );
            // 
            // lbl_backcolor_name
            // 
            this.lbl_backcolor_name.AutoSize = true;
            this.lbl_backcolor_name.Location = new System.Drawing.Point( 126, 93 );
            this.lbl_backcolor_name.Name = "lbl_backcolor_name";
            this.lbl_backcolor_name.Size = new System.Drawing.Size( 35, 13 );
            this.lbl_backcolor_name.TabIndex = 15;
            this.lbl_backcolor_name.Text = "Name";
            // 
            // lbl_forecolor_name
            // 
            this.lbl_forecolor_name.AutoSize = true;
            this.lbl_forecolor_name.Location = new System.Drawing.Point( 126, 58 );
            this.lbl_forecolor_name.Name = "lbl_forecolor_name";
            this.lbl_forecolor_name.Size = new System.Drawing.Size( 35, 13 );
            this.lbl_forecolor_name.TabIndex = 14;
            this.lbl_forecolor_name.Text = "Name";
            // 
            // grpgt
            // 
            this.grpgt.Controls.Add( this.lbl_input_font );
            this.grpgt.Controls.Add( this.lblFont2 );
            this.grpgt.Controls.Add( this.lbl_hl_backcolor_name );
            this.grpgt.Controls.Add( this.lbl_hl_forecolor_name );
            this.grpgt.Controls.Add( this.lbl_hl_forecolor );
            this.grpgt.Controls.Add( this.lbl_hl_backcolor );
            this.grpgt.Controls.Add( this.label17 );
            this.grpgt.Controls.Add( this.label18 );
            this.grpgt.Location = new System.Drawing.Point( 6, 202 );
            this.grpgt.Name = "grpgt";
            this.grpgt.Size = new System.Drawing.Size( 249, 127 );
            this.grpgt.TabIndex = 16;
            this.grpgt.TabStop = false;
            this.grpgt.Text = "Match Colors";
            // 
            // lbl_input_font
            // 
            this.lbl_input_font.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_input_font.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_input_font.Location = new System.Drawing.Point( 87, 16 );
            this.lbl_input_font.Name = "lbl_input_font";
            this.lbl_input_font.Size = new System.Drawing.Size( 134, 21 );
            this.lbl_input_font.TabIndex = 17;
            this.lbl_input_font.Text = "Font";
            this.lbl_input_font.Click += new System.EventHandler( this.lbl_input_font_Click );
            // 
            // lblFont2
            // 
            this.lblFont2.Location = new System.Drawing.Point( 11, 23 );
            this.lblFont2.Name = "lblFont2";
            this.lblFont2.Size = new System.Drawing.Size( 64, 13 );
            this.lblFont2.TabIndex = 16;
            this.lblFont2.Text = "Font";
            // 
            // lbl_hl_backcolor_name
            // 
            this.lbl_hl_backcolor_name.AutoSize = true;
            this.lbl_hl_backcolor_name.Location = new System.Drawing.Point( 127, 93 );
            this.lbl_hl_backcolor_name.Name = "lbl_hl_backcolor_name";
            this.lbl_hl_backcolor_name.Size = new System.Drawing.Size( 35, 13 );
            this.lbl_hl_backcolor_name.TabIndex = 15;
            this.lbl_hl_backcolor_name.Text = "Name";
            // 
            // lbl_hl_forecolor_name
            // 
            this.lbl_hl_forecolor_name.AutoSize = true;
            this.lbl_hl_forecolor_name.Location = new System.Drawing.Point( 127, 58 );
            this.lbl_hl_forecolor_name.Name = "lbl_hl_forecolor_name";
            this.lbl_hl_forecolor_name.Size = new System.Drawing.Size( 35, 13 );
            this.lbl_hl_forecolor_name.TabIndex = 14;
            this.lbl_hl_forecolor_name.Text = "Name";
            // 
            // lbl_hl_forecolor
            // 
            this.lbl_hl_forecolor.BackColor = System.Drawing.Color.Black;
            this.lbl_hl_forecolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hl_forecolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_hl_forecolor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_hl_forecolor.Location = new System.Drawing.Point( 87, 45 );
            this.lbl_hl_forecolor.Name = "lbl_hl_forecolor";
            this.lbl_hl_forecolor.Size = new System.Drawing.Size( 24, 26 );
            this.lbl_hl_forecolor.TabIndex = 8;
            this.lbl_hl_forecolor.Click += new System.EventHandler( this.lbl_hl_forecolor_Click );
            // 
            // lbl_hl_backcolor
            // 
            this.lbl_hl_backcolor.BackColor = System.Drawing.Color.Yellow;
            this.lbl_hl_backcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hl_backcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_hl_backcolor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_hl_backcolor.Location = new System.Drawing.Point( 86, 80 );
            this.lbl_hl_backcolor.Name = "lbl_hl_backcolor";
            this.lbl_hl_backcolor.Size = new System.Drawing.Size( 25, 26 );
            this.lbl_hl_backcolor.TabIndex = 9;
            this.lbl_hl_backcolor.Click += new System.EventHandler( this.lbl_hl_backcolor_Click );
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point( 11, 58 );
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size( 55, 13 );
            this.label17.TabIndex = 11;
            this.label17.Text = "ForeColor:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point( 12, 93 );
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size( 59, 13 );
            this.label18.TabIndex = 10;
            this.label18.Text = "BackColor:";
            // 
            // gbghnt
            // 
            this.gbghnt.Controls.Add( this.cb9 );
            this.gbghnt.Controls.Add( this.cb1 );
            this.gbghnt.Controls.Add( this.cb8 );
            this.gbghnt.Controls.Add( this.cb2 );
            this.gbghnt.Controls.Add( this.cb10 );
            this.gbghnt.Controls.Add( this.cb5 );
            this.gbghnt.Controls.Add( this.cb6 );
            this.gbghnt.Controls.Add( this.cb4 );
            this.gbghnt.Controls.Add( this.cb7 );
            this.gbghnt.Controls.Add( this.cb3 );
            this.gbghnt.Location = new System.Drawing.Point( 261, 2 );
            this.gbghnt.Name = "gbghnt";
            this.gbghnt.Size = new System.Drawing.Size( 166, 327 );
            this.gbghnt.TabIndex = 17;
            this.gbghnt.TabStop = false;
            this.gbghnt.Text = "regx_opt";
            // 
            // cb9
            // 
            this.cb9.AllowDrop = true;
            this.cb9.AutoSize = true;
            this.cb9.Checked = true;
            this.cb9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb9.Location = new System.Drawing.Point( 20, 268 );
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size( 67, 17 );
            this.cb9.TabIndex = 14;
            this.cb9.Text = "regx_opt";
            this.cb9.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AllowDrop = true;
            this.cb1.AutoSize = true;
            this.cb1.Checked = true;
            this.cb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1.Location = new System.Drawing.Point( 20, 23 );
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size( 67, 17 );
            this.cb1.TabIndex = 13;
            this.cb1.Text = "regx_opt";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.AllowDrop = true;
            this.cb8.AutoSize = true;
            this.cb8.Checked = true;
            this.cb8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb8.Location = new System.Drawing.Point( 20, 237 );
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size( 67, 17 );
            this.cb8.TabIndex = 12;
            this.cb8.Text = "regx_opt";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AllowDrop = true;
            this.cb2.AutoSize = true;
            this.cb2.Checked = true;
            this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2.Location = new System.Drawing.Point( 20, 56 );
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size( 67, 17 );
            this.cb2.TabIndex = 11;
            this.cb2.Text = "regx_opt";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb10
            // 
            this.cb10.AllowDrop = true;
            this.cb10.AutoSize = true;
            this.cb10.Checked = true;
            this.cb10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb10.Location = new System.Drawing.Point( 20, 299 );
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size( 67, 17 );
            this.cb10.TabIndex = 10;
            this.cb10.Text = "regx_opt";
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AllowDrop = true;
            this.cb5.AutoSize = true;
            this.cb5.Checked = true;
            this.cb5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb5.Location = new System.Drawing.Point( 20, 149 );
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size( 67, 17 );
            this.cb5.TabIndex = 9;
            this.cb5.Text = "regx_opt";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AllowDrop = true;
            this.cb6.AutoSize = true;
            this.cb6.Checked = true;
            this.cb6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb6.Location = new System.Drawing.Point( 20, 177 );
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size( 67, 17 );
            this.cb6.TabIndex = 8;
            this.cb6.Text = "regx_opt";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AllowDrop = true;
            this.cb4.AutoSize = true;
            this.cb4.Checked = true;
            this.cb4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb4.Location = new System.Drawing.Point( 20, 118 );
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size( 67, 17 );
            this.cb4.TabIndex = 7;
            this.cb4.Text = "regx_opt";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AllowDrop = true;
            this.cb7.AutoSize = true;
            this.cb7.Checked = true;
            this.cb7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb7.Location = new System.Drawing.Point( 20, 206 );
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size( 67, 17 );
            this.cb7.TabIndex = 6;
            this.cb7.Text = "regx_opt";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AllowDrop = true;
            this.cb3.AutoSize = true;
            this.cb3.Checked = true;
            this.cb3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3.Location = new System.Drawing.Point( 20, 87 );
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size( 67, 17 );
            this.cb3.TabIndex = 5;
            this.cb3.Text = "regx_opt";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // OptionsDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 432, 371 );
            this.Controls.Add( this.gbghnt );
            this.Controls.Add( this.grpgt );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDlg";
            this.Text = "Settings";
            ( (System.ComponentModel.ISupportInitialize)( this.iInterval ) ).EndInit();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.grpgt.ResumeLayout( false );
            this.grpgt.PerformLayout();
            this.gbghnt.ResumeLayout( false );
            this.gbghnt.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown iInterval;
        public System.Windows.Forms.CheckBox iAutoMatch;
        private System.Windows.Forms.Label lblFont1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_backcolor;
        private System.Windows.Forms.Label lbl_forecolor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_backcolor_name;
        private System.Windows.Forms.Label lbl_forecolor_name;
        private System.Windows.Forms.GroupBox grpgt;
        private System.Windows.Forms.Label lbl_hl_backcolor_name;
        private System.Windows.Forms.Label lbl_hl_forecolor_name;
        private System.Windows.Forms.Label lbl_hl_forecolor;
        private System.Windows.Forms.Label lbl_hl_backcolor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFont2;
        private System.Windows.Forms.GroupBox gbghnt;
        public System.Windows.Forms.CheckBox cb6;
        public System.Windows.Forms.CheckBox cb4;
        public System.Windows.Forms.CheckBox cb7;
        public System.Windows.Forms.CheckBox cb3;
        public System.Windows.Forms.CheckBox cb9;
        public System.Windows.Forms.CheckBox cb1;
        public System.Windows.Forms.CheckBox cb8;
        public System.Windows.Forms.CheckBox cb2;
        public System.Windows.Forms.CheckBox cb10;
        public System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.Label lbl_exp_font;
        private System.Windows.Forms.Label lbl_input_font;

    }
}