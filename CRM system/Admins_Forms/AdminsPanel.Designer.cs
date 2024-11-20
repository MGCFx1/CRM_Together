namespace CRM_system.Admins_Forms
{
    partial class AdminsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsPanel));
            this.Signup_close = new System.Windows.Forms.Label();
            this.adSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adbtDashboard = new System.Windows.Forms.Button();
            this.adbtEvents = new System.Windows.Forms.Button();
            this.adbtContacts = new System.Windows.Forms.Button();
            this.adbtLearning = new System.Windows.Forms.Button();
            this.adSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signup_close
            // 
            this.Signup_close.AutoSize = true;
            this.Signup_close.BackColor = System.Drawing.Color.White;
            this.Signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_close.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_close.Location = new System.Drawing.Point(972, 18);
            this.Signup_close.Name = "Signup_close";
            this.Signup_close.Size = new System.Drawing.Size(22, 28);
            this.Signup_close.TabIndex = 11;
            this.Signup_close.Text = "X";
            this.Signup_close.Click += new System.EventHandler(this.Signup_close_Click);
            // 
            // adSidebar
            // 
            this.adSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adSidebar.Controls.Add(this.panel8);
            this.adSidebar.Controls.Add(this.panel1);
            this.adSidebar.Controls.Add(this.panel2);
            this.adSidebar.Controls.Add(this.panel3);
            this.adSidebar.Controls.Add(this.panel4);
            this.adSidebar.Controls.Add(this.panel5);
            this.adSidebar.Location = new System.Drawing.Point(0, 0);
            this.adSidebar.Name = "adSidebar";
            this.adSidebar.Size = new System.Drawing.Size(212, 540);
            this.adSidebar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adbtDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 52);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adbtEvents);
            this.panel2.Location = new System.Drawing.Point(3, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 52);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adbtContacts);
            this.panel3.Location = new System.Drawing.Point(3, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 52);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.adbtLearning);
            this.panel4.Location = new System.Drawing.Point(3, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 179);
            this.panel4.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(209, 119);
            this.panel8.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nav Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Logged in as admin";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 52);
            this.panel5.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adbtDashboard
            // 
            this.adbtDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adbtDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adbtDashboard.FlatAppearance.BorderSize = 0;
            this.adbtDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adbtDashboard.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.adbtDashboard.ForeColor = System.Drawing.Color.White;
            this.adbtDashboard.Image = ((System.Drawing.Image)(resources.GetObject("adbtDashboard.Image")));
            this.adbtDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtDashboard.Location = new System.Drawing.Point(6, 3);
            this.adbtDashboard.Name = "adbtDashboard";
            this.adbtDashboard.Size = new System.Drawing.Size(202, 48);
            this.adbtDashboard.TabIndex = 14;
            this.adbtDashboard.Text = "              Dashboard";
            this.adbtDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtDashboard.UseVisualStyleBackColor = false;
            this.adbtDashboard.Click += new System.EventHandler(this.adbtDashboard_Click);
            // 
            // adbtEvents
            // 
            this.adbtEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adbtEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adbtEvents.FlatAppearance.BorderSize = 0;
            this.adbtEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adbtEvents.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.adbtEvents.ForeColor = System.Drawing.Color.White;
            this.adbtEvents.Image = ((System.Drawing.Image)(resources.GetObject("adbtEvents.Image")));
            this.adbtEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtEvents.Location = new System.Drawing.Point(6, 3);
            this.adbtEvents.Name = "adbtEvents";
            this.adbtEvents.Size = new System.Drawing.Size(202, 48);
            this.adbtEvents.TabIndex = 14;
            this.adbtEvents.Text = "              Events";
            this.adbtEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtEvents.UseVisualStyleBackColor = false;
            this.adbtEvents.Click += new System.EventHandler(this.adbtEvents_Click);
            // 
            // adbtContacts
            // 
            this.adbtContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adbtContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adbtContacts.FlatAppearance.BorderSize = 0;
            this.adbtContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adbtContacts.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.adbtContacts.ForeColor = System.Drawing.Color.White;
            this.adbtContacts.Image = ((System.Drawing.Image)(resources.GetObject("adbtContacts.Image")));
            this.adbtContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtContacts.Location = new System.Drawing.Point(6, 3);
            this.adbtContacts.Name = "adbtContacts";
            this.adbtContacts.Size = new System.Drawing.Size(202, 48);
            this.adbtContacts.TabIndex = 14;
            this.adbtContacts.Text = "              Contacts";
            this.adbtContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtContacts.UseVisualStyleBackColor = false;
            this.adbtContacts.Click += new System.EventHandler(this.adbtContacts_Click);
            // 
            // adbtLearning
            // 
            this.adbtLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adbtLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adbtLearning.FlatAppearance.BorderSize = 0;
            this.adbtLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adbtLearning.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.adbtLearning.ForeColor = System.Drawing.Color.White;
            this.adbtLearning.Image = ((System.Drawing.Image)(resources.GetObject("adbtLearning.Image")));
            this.adbtLearning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtLearning.Location = new System.Drawing.Point(3, -1);
            this.adbtLearning.Name = "adbtLearning";
            this.adbtLearning.Size = new System.Drawing.Size(202, 65);
            this.adbtLearning.TabIndex = 14;
            this.adbtLearning.Text = "              eLearning";
            this.adbtLearning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adbtLearning.UseVisualStyleBackColor = false;
            this.adbtLearning.Click += new System.EventHandler(this.adbtLearning_Click);
            // 
            // AdminsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.adSidebar);
            this.Controls.Add(this.Signup_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AdminsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminsPanel";
            this.Load += new System.EventHandler(this.AdminsPanel_Load);
            this.adSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Signup_close;
        private System.Windows.Forms.FlowLayoutPanel adSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adbtDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button adbtEvents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adbtContacts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button adbtLearning;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
    }
}