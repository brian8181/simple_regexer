using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace simple_regexer
{
    public partial class MatchCtrl : UserControl
    {
        public MatchCtrl()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            // clear all
            GroupList.Items.Clear();
            MatchList.Items.Clear();
            GroupList.Groups.Clear();
        }
    }
}
