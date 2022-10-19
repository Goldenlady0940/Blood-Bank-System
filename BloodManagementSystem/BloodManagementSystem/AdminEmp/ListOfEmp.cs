﻿using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem.AdminEmp
{
    public partial class ListOfEmp : Form
    {
        Panel p;
        public ListOfEmp(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void ListOfEmp_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            bool flager = false;
            foreach(var item in EmployeeClass.PopulateAll())
            {
                UCEmp emp = new UCEmp();
                emp.ID = item.ID;
                string fullName = item.FirstName.ToString() + " " + item.LastName.ToString();
                emp.Name = fullName;
                emp.Phone = item.Phone;
                emp.Click += (object P, EventArgs e2) =>
                {
                    p.Controls.Clear();
                    ListOfEmpDetailPage ld = new ListOfEmpDetailPage(item.ID,item.FirstName, item.LastName, item.Gender,item.DOB, item.Phone, item.Email,  item.Country, item.City, item.Region, item.Salary, item.AdminStatus) 
                    { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    p.Controls.Add(ld);
                    ld.Show();
                };
                if (flager == false)
                {
                    flager = true;
                    emp.BackColor = Color.LightGray;
                }
                else if (flager == true)
                {
                    flager = false;
                    emp.BackColor = Color.DarkGray;
                }
                
                flowLayoutPanel1.Controls.Add(emp);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            var res = emp.Search(tbAp.Text);
            
            if (res >= 1)
            {
                int filtered = res;
               // flowLayoutPanel1.Controls.Add(filtered);
            }
            //populate the table with only that value
            //activate the edit and delete button
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            EmployeeRegi emp = new EmployeeRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(emp);
            emp.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}