﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactMate_Pro
{
    public partial class CGmailControl : UserControl
    {
        public CGmailControl()
        {
            InitializeComponent();
        }

        #region PROPERTY OF CONTACT GMAIL CONTROL

        public String GmailAddress
        {
            get { return gmailAddress.Text; }
            set { gmailAddress.Text = value; }
        }

        #endregion

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
