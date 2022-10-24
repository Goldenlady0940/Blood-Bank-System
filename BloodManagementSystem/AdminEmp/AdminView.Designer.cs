﻿namespace BloodManagementSystem
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.lbl_Donation = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Employee = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Branch = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_transfer = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Home = new Guna.UI.WinForms.GunaLabel();
            this.PicDonProfile = new System.Windows.Forms.PictureBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.ManageAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.PanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Donation
            // 
            this.lbl_Donation.AutoSize = true;
            this.lbl_Donation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Donation.ForeColor = System.Drawing.Color.Red;
            this.lbl_Donation.Location = new System.Drawing.Point(579, 26);
            this.lbl_Donation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Donation.Name = "lbl_Donation";
            this.lbl_Donation.Size = new System.Drawing.Size(98, 25);
            this.lbl_Donation.TabIndex = 13;
            this.lbl_Donation.Text = "Donation";
            this.lbl_Donation.Click += new System.EventHandler(this.lbl_Donation_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee.Location = new System.Drawing.Point(715, 26);
            this.lbl_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(104, 25);
            this.lbl_Employee.TabIndex = 14;
            this.lbl_Employee.Text = "Employee";
            this.lbl_Employee.Click += new System.EventHandler(this.lbl_Employee_Click);
            // 
            // gunaPanel
            // 
            this.gunaPanel.Controls.Add(this.kryptonLabel1);
            this.gunaPanel.Controls.Add(this.lbl_Branch);
            this.gunaPanel.Controls.Add(this.gunaLabel2);
            this.gunaPanel.Controls.Add(this.lbl_transfer);
            this.gunaPanel.Controls.Add(this.pictureBox2);
            this.gunaPanel.Controls.Add(this.lbl_Donation);
            this.gunaPanel.Controls.Add(this.lbl_Home);
            this.gunaPanel.Controls.Add(this.PicDonProfile);
            this.gunaPanel.Controls.Add(this.lbl_Employee);
            this.gunaPanel.Controls.Add(this.lbl_hi);
            this.gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gunaPanel.Name = "gunaPanel";
            this.gunaPanel.Size = new System.Drawing.Size(1312, 78);
            this.gunaPanel.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(320, 19);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(80, 32);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 19;
            this.kryptonLabel1.Values.Text = "Admin";
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.AutoSize = true;
            this.lbl_Branch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Branch.ForeColor = System.Drawing.Color.Red;
            this.lbl_Branch.Location = new System.Drawing.Point(963, 26);
            this.lbl_Branch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(81, 25);
            this.lbl_Branch.TabIndex = 18;
            this.lbl_Branch.Text = "Branch";
            this.lbl_Branch.Click += new System.EventHandler(this.lbl_Branch_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel2.Location = new System.Drawing.Point(104, 0);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(177, 72);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "National \r\nBlood Bank";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_transfer
            // 
            this.lbl_transfer.AutoSize = true;
            this.lbl_transfer.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transfer.ForeColor = System.Drawing.Color.Red;
            this.lbl_transfer.Location = new System.Drawing.Point(837, 26);
            this.lbl_transfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transfer.Name = "lbl_transfer";
            this.lbl_transfer.Size = new System.Drawing.Size(92, 25);
            this.lbl_transfer.TabIndex = 17;
            this.lbl_transfer.Text = "Transfer";
            this.lbl_transfer.Click += new System.EventHandler(this.lbl_Hospital_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Red;
            this.lbl_Home.Location = new System.Drawing.Point(471, 26);
            this.lbl_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(68, 25);
            this.lbl_Home.TabIndex = 12;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // PicDonProfile
            // 
            this.PicDonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicDonProfile.BackgroundImage")));
            this.PicDonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicDonProfile.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.PicDonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDonProfile.Location = new System.Drawing.Point(1639, 17);
            this.PicDonProfile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PicDonProfile.Name = "PicDonProfile";
            this.PicDonProfile.Size = new System.Drawing.Size(52, 46);
            this.PicDonProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicDonProfile.TabIndex = 7;
            this.PicDonProfile.TabStop = false;
            this.PicDonProfile.ContextMenuStripChanged += new System.EventHandler(this.PicDonProfile_MouseHover);
            this.PicDonProfile.Click += new System.EventHandler(this.PicDonProfile_Click);
            this.PicDonProfile.MouseHover += new System.EventHandler(this.PicDonProfile_MouseHover);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageAccToolStripMenuItem,
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
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(191, 52);
            // 
            // ManageAccToolStripMenuItem
            // 
            this.ManageAccToolStripMenuItem.Name = "ManageAccToolStripMenuItem";
            this.ManageAccToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.ManageAccToolStripMenuItem.Text = "Manage Account";
            this.ManageAccToolStripMenuItem.Click += new System.EventHandler(this.ManageAccToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // lbl_hi
            // 
            this.lbl_hi.Location = new System.Drawing.Point(1447, 32);
            this.lbl_hi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(136, 32);
            this.lbl_hi.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hi.TabIndex = 6;
            this.lbl_hi.Values.Text = "AdminName";
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.panel2);
            this.PanelAdmin.Controls.Add(this.panel1);
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 78);
            this.PanelAdmin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(1312, 641);
            this.PanelAdmin.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 641);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 641);
            this.panel1.TabIndex = 29;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 719);
            this.Controls.Add(this.PanelAdmin);
            this.Controls.Add(this.gunaPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminViews";
            this.Load += new System.EventHandler(this.AdminViews_Load);
            this.gunaPanel.ResumeLayout(false);
            this.gunaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.PanelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel;
        private System.Windows.Forms.PictureBox PicDonProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_hi;
        private Guna.UI.WinForms.GunaLabel lbl_Donation;
        private Guna.UI.WinForms.GunaLabel lbl_Employee;
        private Guna.UI.WinForms.GunaLabel lbl_Home;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelAdmin;
        private Guna.UI.WinForms.GunaLabel lbl_Branch;
        private Guna.UI.WinForms.GunaLabel lbl_transfer;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}