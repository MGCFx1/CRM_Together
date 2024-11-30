namespace CRM_system
{
    partial class Users_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Dashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavTitle = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnDashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnMemberships1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnEvents = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PneLearning = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnContacts = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnAccount = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.Signup_close = new System.Windows.Forms.Label();
            this.adUserProf = new System.Windows.Forms.Button();
            this.adNotification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.MaximumSize = new System.Drawing.Size(283, 665);
            this.sidebar.MinimumSize = new System.Drawing.Size(107, 665);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(283, 665);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.NavTitle);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NavTitle
            // 
            this.NavTitle.AutoSize = true;
            this.NavTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NavTitle.ForeColor = System.Drawing.Color.White;
            this.NavTitle.Location = new System.Drawing.Point(105, 46);
            this.NavTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NavTitle.Name = "NavTitle";
            this.NavTitle.Size = new System.Drawing.Size(110, 25);
            this.NavTitle.TabIndex = 1;
            this.NavTitle.Text = "Nav Menu";
            this.NavTitle.Click += new System.EventHandler(this.NavTitle_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(47, 38);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(51, 42);
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnDashboard);
            this.panel5.Location = new System.Drawing.Point(4, 114);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 64);
            this.panel5.TabIndex = 2;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnDashboard.FlatAppearance.BorderSize = 0;
            this.pnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pnDashboard.ForeColor = System.Drawing.Color.White;
            this.pnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pnDashboard.Image")));
            this.pnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnDashboard.Location = new System.Drawing.Point(-4, 0);
            this.pnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(283, 60);
            this.pnDashboard.TabIndex = 2;
            this.pnDashboard.Text = "              Dashboard";
            this.pnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnDashboard.UseVisualStyleBackColor = true;
            this.pnDashboard.Click += new System.EventHandler(this.pnDashboard_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnMemberships1);
            this.panel6.Location = new System.Drawing.Point(4, 186);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 64);
            this.panel6.TabIndex = 2;
            // 
            // pnMemberships1
            // 
            this.pnMemberships1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMemberships1.FlatAppearance.BorderSize = 0;
            this.pnMemberships1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnMemberships1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pnMemberships1.ForeColor = System.Drawing.Color.White;
            this.pnMemberships1.Image = ((System.Drawing.Image)(resources.GetObject("pnMemberships1.Image")));
            this.pnMemberships1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMemberships1.Location = new System.Drawing.Point(-4, 0);
            this.pnMemberships1.Margin = new System.Windows.Forms.Padding(4);
            this.pnMemberships1.Name = "pnMemberships1";
            this.pnMemberships1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pnMemberships1.Size = new System.Drawing.Size(281, 57);
            this.pnMemberships1.TabIndex = 1;
            this.pnMemberships1.Text = "         Memberships";
            this.pnMemberships1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMemberships1.UseVisualStyleBackColor = true;
            this.pnMemberships1.Click += new System.EventHandler(this.pnMemberships_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PnEvents);
            this.panel4.Location = new System.Drawing.Point(4, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 64);
            this.panel4.TabIndex = 2;
            // 
            // PnEvents
            // 
            this.PnEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnEvents.FlatAppearance.BorderSize = 0;
            this.PnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.PnEvents.ForeColor = System.Drawing.Color.White;
            this.PnEvents.Image = ((System.Drawing.Image)(resources.GetObject("PnEvents.Image")));
            this.PnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PnEvents.Location = new System.Drawing.Point(-4, 9);
            this.PnEvents.Margin = new System.Windows.Forms.Padding(4);
            this.PnEvents.Name = "PnEvents";
            this.PnEvents.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.PnEvents.Size = new System.Drawing.Size(285, 52);
            this.PnEvents.TabIndex = 1;
            this.PnEvents.Text = "              Events";
            this.PnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PnEvents.UseVisualStyleBackColor = true;
            this.PnEvents.Click += new System.EventHandler(this.PnEvents_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PneLearning);
            this.panel3.Location = new System.Drawing.Point(4, 330);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 64);
            this.panel3.TabIndex = 2;
            // 
            // PneLearning
            // 
            this.PneLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PneLearning.FlatAppearance.BorderSize = 0;
            this.PneLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PneLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.PneLearning.ForeColor = System.Drawing.Color.White;
            this.PneLearning.Image = ((System.Drawing.Image)(resources.GetObject("PneLearning.Image")));
            this.PneLearning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PneLearning.Location = new System.Drawing.Point(0, 4);
            this.PneLearning.Margin = new System.Windows.Forms.Padding(4);
            this.PneLearning.Name = "PneLearning";
            this.PneLearning.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.PneLearning.Size = new System.Drawing.Size(285, 52);
            this.PneLearning.TabIndex = 1;
            this.PneLearning.Text = "              E-Learning";
            this.PneLearning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PneLearning.UseVisualStyleBackColor = true;
            this.PneLearning.Click += new System.EventHandler(this.PneLearning_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnContacts);
            this.panel2.Location = new System.Drawing.Point(4, 402);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 122);
            this.panel2.TabIndex = 1;
            // 
            // pnContacts
            // 
            this.pnContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContacts.FlatAppearance.BorderSize = 0;
            this.pnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pnContacts.ForeColor = System.Drawing.Color.White;
            this.pnContacts.Image = ((System.Drawing.Image)(resources.GetObject("pnContacts.Image")));
            this.pnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnContacts.Location = new System.Drawing.Point(0, 4);
            this.pnContacts.Margin = new System.Windows.Forms.Padding(4);
            this.pnContacts.Name = "pnContacts";
            this.pnContacts.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pnContacts.Size = new System.Drawing.Size(285, 52);
            this.pnContacts.TabIndex = 1;
            this.pnContacts.Text = "              Contacts";
            this.pnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnContacts.UseVisualStyleBackColor = true;
            this.pnContacts.Click += new System.EventHandler(this.pnContacts_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel8.Controls.Add(this.btnLogout);
            this.panel8.Location = new System.Drawing.Point(4, 532);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(281, 64);
            this.panel8.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-4, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(285, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "              Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnAccount);
            this.panel7.Location = new System.Drawing.Point(4, 604);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 64);
            this.panel7.TabIndex = 2;
            // 
            // pnAccount
            // 
            this.pnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAccount.FlatAppearance.BorderSize = 0;
            this.pnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pnAccount.ForeColor = System.Drawing.Color.White;
            this.pnAccount.Image = ((System.Drawing.Image)(resources.GetObject("pnAccount.Image")));
            this.pnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnAccount.Location = new System.Drawing.Point(-3, 4);
            this.pnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pnAccount.Size = new System.Drawing.Size(280, 57);
            this.pnAccount.TabIndex = 1;
            this.pnAccount.Text = "              Account";
            this.pnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnAccount.UseVisualStyleBackColor = true;
            this.pnAccount.Click += new System.EventHandler(this.pnAccount_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Signup_close
            // 
            this.Signup_close.AutoSize = true;
            this.Signup_close.BackColor = System.Drawing.Color.White;
            this.Signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_close.Location = new System.Drawing.Point(1296, 22);
            this.Signup_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Signup_close.Name = "Signup_close";
            this.Signup_close.Size = new System.Drawing.Size(26, 25);
            this.Signup_close.TabIndex = 10;
            this.Signup_close.Text = "X";
            this.Signup_close.Click += new System.EventHandler(this.Signup_close_Click);
            // 
            // adUserProf
            // 
            this.adUserProf.BackColor = System.Drawing.Color.Transparent;
            this.adUserProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adUserProf.FlatAppearance.BorderSize = 0;
            this.adUserProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adUserProf.Image = ((System.Drawing.Image)(resources.GetObject("adUserProf.Image")));
            this.adUserProf.Location = new System.Drawing.Point(1244, 17);
            this.adUserProf.Margin = new System.Windows.Forms.Padding(4);
            this.adUserProf.Name = "adUserProf";
            this.adUserProf.Size = new System.Drawing.Size(44, 42);
            this.adUserProf.TabIndex = 96;
            this.adUserProf.UseVisualStyleBackColor = false;
            this.adUserProf.Click += new System.EventHandler(this.adUserProf_Click);
            // 
            // adNotification
            // 
            this.adNotification.BackColor = System.Drawing.Color.Transparent;
            this.adNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adNotification.FlatAppearance.BorderSize = 0;
            this.adNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adNotification.Image = ((System.Drawing.Image)(resources.GetObject("adNotification.Image")));
            this.adNotification.Location = new System.Drawing.Point(1191, 17);
            this.adNotification.Margin = new System.Windows.Forms.Padding(4);
            this.adNotification.Name = "adNotification";
            this.adNotification.Size = new System.Drawing.Size(45, 42);
            this.adNotification.TabIndex = 95;
            this.adNotification.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1219, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "1";
            // 
            // Users_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adUserProf);
            this.Controls.Add(this.adNotification);
            this.Controls.Add(this.Signup_close);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Users_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_Dashboard";
            this.Load += new System.EventHandler(this.Users_Dashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pnContacts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PnEvents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PneLearning;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pnMemberships1;
        private System.Windows.Forms.Button pnAccount;
        private System.Windows.Forms.Label NavTitle;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label Signup_close;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button adUserProf;
        private System.Windows.Forms.Button adNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pnDashboard;
    }
}