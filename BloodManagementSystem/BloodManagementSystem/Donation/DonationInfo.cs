﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BloodManagementSystem
{
    public partial class DonationInfo : Form
    {
        Panel p;
        int id;
        public DonationInfo(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }
        private void DonationInfo_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                flowLayoutPanel1.Controls.Clear();
                SQLDonationClass s = new SQLDonationClass();
                s.successformLoad(flowLayoutPanel1);
            }
            else
            {
                //pass an id so it's filter out the results
                flowLayoutPanel1.Controls.Clear();
                SQLDonationClass s = new SQLDonationClass();
                s.successformLoad(flowLayoutPanel1);
            }
            
        }

        private void lbl_per_Click(object sender, EventArgs e)
        {

        }
    }
}
