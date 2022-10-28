﻿namespace BloodManagementSystem
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            this.Panel_Emp = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PicDonProfile = new System.Windows.Forms.PictureBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_NewDon = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Home = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_EmpDisplay = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_EmpDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Emp
            // 
            this.Panel_Emp.Controls.Add(this.kryptonLabel1);
            this.Panel_Emp.Controls.Add(this.PicDonProfile);
            this.Panel_Emp.Controls.Add(this.lbl_hi);
            this.Panel_Emp.Controls.Add(this.lbl_NewDon);
            this.Panel_Emp.Controls.Add(this.lbl_Home);
            this.Panel_Emp.Controls.Add(this.gunaLabel2);
            this.Panel_Emp.Controls.Add(this.pictureBox2);
            this.Panel_Emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Emp.Location = new System.Drawing.Point(0, 0);
            this.Panel_Emp.Name = "Panel_Emp";
            this.Panel_Emp.Size = new System.Drawing.Size(1152, 63);
            this.Panel_Emp.TabIndex = 1;
            this.Panel_Emp.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Emp_Paint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(257, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(87, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 27;
            this.kryptonLabel1.Values.Text = "Employee";
            // 
            // PicDonProfile
            // 
            this.PicDonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicDonProfile.BackgroundImage")));
            this.PicDonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicDonProfile.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.PicDonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDonProfile.Location = new System.Drawing.Point(1072, 4);
            this.PicDonProfile.Name = "PicDonProfile";
            this.PicDonProfile.Size = new System.Drawing.Size(68, 56);
            this.PicDonProfile.TabIndex = 26;
            this.PicDonProfile.TabStop = false;
            this.PicDonProfile.Click += new System.EventHandler(this.PicDonProfile_Click);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            this.manageAccountToolStripMenuItem.Click += new System.EventHandler(this.manageAccountToolStripMenuItem_Click_1);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // lbl_hi
            // 
            this.lbl_hi.Location = new System.Drawing.Point(957, 21);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(91, 26);
            this.lbl_hi.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hi.TabIndex = 25;
            this.lbl_hi.Values.Text = "EmpName";
            this.lbl_hi.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_hi_Paint);
            // 
            // lbl_NewDon
            // 
            this.lbl_NewDon.AutoSize = true;
            this.lbl_NewDon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewDon.ForeColor = System.Drawing.Color.Red;
            this.lbl_NewDon.Location = new System.Drawing.Point(784, 24);
            this.lbl_NewDon.Name = "lbl_NewDon";
            this.lbl_NewDon.Size = new System.Drawing.Size(114, 19);
            this.lbl_NewDon.TabIndex = 22;
            this.lbl_NewDon.Text = "New Donation";
            this.lbl_NewDon.Click += new System.EventHandler(this.lbl_NewDon_Click);
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Red;
            this.lbl_Home.Location = new System.Drawing.Point(654, 24);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(53, 19);
            this.lbl_Home.TabIndex = 21;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel2.Location = new System.Drawing.Point(82, 3);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 58);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "National \r\nBlood Bank";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Panel_EmpDisplay
            // 
            this.Panel_EmpDisplay.Controls.Add(this.panel2);
            this.Panel_EmpDisplay.Controls.Add(this.panel1);
            this.Panel_EmpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_EmpDisplay.Location = new System.Drawing.Point(0, 63);
            this.Panel_EmpDisplay.Name = "Panel_EmpDisplay";
            this.Panel_EmpDisplay.Size = new System.Drawing.Size(1152, 531);
            this.Panel_EmpDisplay.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 531);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 531);
            this.panel1.TabIndex = 28;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 594);
            this.Controls.Add(this.Panel_EmpDisplay);
            this.Controls.Add(this.Panel_Emp);
            this.Name = "EmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeView";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            this.Panel_Emp.ResumeLayout(false);
            this.Panel_Emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_EmpDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Emp;
        private System.Windows.Forms.Panel Panel_EmpDisplay;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel lbl_NewDon;
        private Guna.UI.WinForms.GunaLabel lbl_Home;
        private System.Windows.Forms.PictureBox PicDonProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_hi;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}