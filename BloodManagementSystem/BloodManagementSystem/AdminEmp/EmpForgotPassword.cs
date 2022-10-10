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
    public partial class EmpForgotPassword : Form
    {
        Panel p;
        public EmpForgotPassword(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var result = EmployeeClass.findIDbyPhoneEmail(txt_phEmp.Text, txt_emEmp.Text);
            if (result == null)
            {
                MessageBox.Show("Invalid phone or email");
                p.Controls.Clear();
                AdminEmpLogin ad = new AdminEmpLogin(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(ad);
                ad.Show();
            }
            else
            {
                var log = EmployeeClass.findPass(result.ID);
                MessageBox.Show("Dear " + log.UserName + ", your password is " + log.Password + ".");
                p.Controls.Clear();
                AdminEmpLogin ad = new AdminEmpLogin(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(ad);
                ad.Show();
            }
        }
    }
}
