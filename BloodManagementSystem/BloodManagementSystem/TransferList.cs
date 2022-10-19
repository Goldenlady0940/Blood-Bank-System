﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class TransferList : Form
    {
        Panel p;
        public TransferList(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void tbAp_Click(object sender, EventArgs e)
        {
            tbAp.Text = "";
        }

        private void tbAp_MouseClick(object sender, MouseEventArgs e)
        {
            tbAp.Text = "";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void TransferList_Load(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            TransferClass t = new TransferClass();
            t.TransferFormLoad(flp);
        }
    }
}