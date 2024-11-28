namespace CRM_system
{
    partial class dashboard_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usMemberTierLabel = new System.Windows.Forms.Label();
            this.usMemberSinceLabel = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RefreshJoinedEvents = new System.Windows.Forms.Button();
            this.dgJoinedEvents = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgLeaveEvent = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usMemberStatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJoinedEvents)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.usMemberStatusLabel);
            this.panel1.Controls.Add(this.usMemberTierLabel);
            this.panel1.Controls.Add(this.usMemberSinceLabel);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(33, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 171);
            this.panel1.TabIndex = 0;
            // 
            // usMemberTierLabel
            // 
            this.usMemberTierLabel.AutoSize = true;
            this.usMemberTierLabel.Location = new System.Drawing.Point(162, 89);
            this.usMemberTierLabel.Name = "usMemberTierLabel";
            this.usMemberTierLabel.Size = new System.Drawing.Size(66, 13);
            this.usMemberTierLabel.TabIndex = 3;
            this.usMemberTierLabel.Text = "Member Tier";
            // 
            // usMemberSinceLabel
            // 
            this.usMemberSinceLabel.AutoSize = true;
            this.usMemberSinceLabel.Location = new System.Drawing.Point(162, 114);
            this.usMemberSinceLabel.Name = "usMemberSinceLabel";
            this.usMemberSinceLabel.Size = new System.Drawing.Size(78, 13);
            this.usMemberSinceLabel.TabIndex = 2;
            this.usMemberSinceLabel.Text = "Member Since:";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(165, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(174, 42);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Welcome, NAME";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Joined Events";
            // 
            // RefreshJoinedEvents
            // 
            this.RefreshJoinedEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.RefreshJoinedEvents.FlatAppearance.BorderSize = 0;
            this.RefreshJoinedEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshJoinedEvents.ForeColor = System.Drawing.Color.White;
            this.RefreshJoinedEvents.Image = ((System.Drawing.Image)(resources.GetObject("RefreshJoinedEvents.Image")));
            this.RefreshJoinedEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshJoinedEvents.Location = new System.Drawing.Point(459, 234);
            this.RefreshJoinedEvents.Name = "RefreshJoinedEvents";
            this.RefreshJoinedEvents.Size = new System.Drawing.Size(117, 30);
            this.RefreshJoinedEvents.TabIndex = 4;
            this.RefreshJoinedEvents.Text = "        Refresh Events";
            this.RefreshJoinedEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshJoinedEvents.UseVisualStyleBackColor = false;
            this.RefreshJoinedEvents.Click += new System.EventHandler(this.RefreshJoinedEvents_Click);
            // 
            // dgJoinedEvents
            // 
            this.dgJoinedEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgJoinedEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJoinedEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgJoinedEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgJoinedEvents.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgJoinedEvents.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgJoinedEvents.Location = new System.Drawing.Point(0, 0);
            this.dgJoinedEvents.Name = "dgJoinedEvents";
            this.dgJoinedEvents.Size = new System.Drawing.Size(408, 168);
            this.dgJoinedEvents.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.dgJoinedEvents);
            this.panel2.Location = new System.Drawing.Point(378, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 171);
            this.panel2.TabIndex = 5;
            // 
            // dgLeaveEvent
            // 
            this.dgLeaveEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgLeaveEvent.FlatAppearance.BorderSize = 0;
            this.dgLeaveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgLeaveEvent.ForeColor = System.Drawing.Color.White;
            this.dgLeaveEvent.Image = ((System.Drawing.Image)(resources.GetObject("dgLeaveEvent.Image")));
            this.dgLeaveEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dgLeaveEvent.Location = new System.Drawing.Point(582, 234);
            this.dgLeaveEvent.Name = "dgLeaveEvent";
            this.dgLeaveEvent.Size = new System.Drawing.Size(124, 30);
            this.dgLeaveEvent.TabIndex = 6;
            this.dgLeaveEvent.Text = "         Leave an Event";
            this.dgLeaveEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dgLeaveEvent.UseVisualStyleBackColor = false;
            this.dgLeaveEvent.Click += new System.EventHandler(this.dgLeaveEvent_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 30);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Users Dashboard";
            // 
            // usMemberStatusLabel
            // 
            this.usMemberStatusLabel.AutoSize = true;
            this.usMemberStatusLabel.Location = new System.Drawing.Point(163, 135);
            this.usMemberStatusLabel.Name = "usMemberStatusLabel";
            this.usMemberStatusLabel.Size = new System.Drawing.Size(81, 13);
            this.usMemberStatusLabel.TabIndex = 4;
            this.usMemberStatusLabel.Text = "Member Status:";
            this.usMemberStatusLabel.Click += new System.EventHandler(this.usMemberStatusLabel_Click);
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RefreshJoinedEvents);
            this.Controls.Add(this.dgLeaveEvent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard_form";
            this.Load += new System.EventHandler(this.dashboard_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJoinedEvents)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usMemberTierLabel;
        private System.Windows.Forms.Label usMemberSinceLabel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RefreshJoinedEvents;
        private System.Windows.Forms.DataGridView dgJoinedEvents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dgLeaveEvent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usMemberStatusLabel;
    }
}