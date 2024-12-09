namespace CRM_system
{
    partial class NotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsForm));
            this.FlowPanelNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.NotifPanel1 = new System.Windows.Forms.Panel();
            this.NotifErase1 = new System.Windows.Forms.Button();
            this.NotifMessege1 = new System.Windows.Forms.Label();
            this.NotifDate1 = new System.Windows.Forms.Label();
            this.NotifTitle1 = new System.Windows.Forms.Label();
            this.NotifIcon1 = new System.Windows.Forms.PictureBox();
            this.NotifCloseForm = new System.Windows.Forms.Button();
            this.FlowPanelNotifications.SuspendLayout();
            this.NotifPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotifIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanelNotifications
            // 
            this.FlowPanelNotifications.AutoScroll = true;
            this.FlowPanelNotifications.Controls.Add(this.NotifPanel1);
            this.FlowPanelNotifications.Location = new System.Drawing.Point(6, 9);
            this.FlowPanelNotifications.Name = "FlowPanelNotifications";
            this.FlowPanelNotifications.Size = new System.Drawing.Size(396, 495);
            this.FlowPanelNotifications.TabIndex = 2;
            // 
            // NotifPanel1
            // 
            this.NotifPanel1.Controls.Add(this.NotifErase1);
            this.NotifPanel1.Controls.Add(this.NotifMessege1);
            this.NotifPanel1.Controls.Add(this.NotifDate1);
            this.NotifPanel1.Controls.Add(this.NotifTitle1);
            this.NotifPanel1.Controls.Add(this.NotifIcon1);
            this.NotifPanel1.Location = new System.Drawing.Point(3, 3);
            this.NotifPanel1.Name = "NotifPanel1";
            this.NotifPanel1.Size = new System.Drawing.Size(393, 86);
            this.NotifPanel1.TabIndex = 0;
            this.NotifPanel1.Visible = false;
            // 
            // NotifErase1
            // 
            this.NotifErase1.Image = ((System.Drawing.Image)(resources.GetObject("NotifErase1.Image")));
            this.NotifErase1.Location = new System.Drawing.Point(341, 32);
            this.NotifErase1.Name = "NotifErase1";
            this.NotifErase1.Size = new System.Drawing.Size(33, 27);
            this.NotifErase1.TabIndex = 4;
            this.NotifErase1.UseVisualStyleBackColor = true;
            // 
            // NotifMessege1
            // 
            this.NotifMessege1.Location = new System.Drawing.Point(63, 25);
            this.NotifMessege1.Name = "NotifMessege1";
            this.NotifMessege1.Size = new System.Drawing.Size(258, 37);
            this.NotifMessege1.TabIndex = 3;
            this.NotifMessege1.Text = "Messege";
            // 
            // NotifDate1
            // 
            this.NotifDate1.AutoSize = true;
            this.NotifDate1.Location = new System.Drawing.Point(65, 60);
            this.NotifDate1.Name = "NotifDate1";
            this.NotifDate1.Size = new System.Drawing.Size(30, 13);
            this.NotifDate1.TabIndex = 2;
            this.NotifDate1.Text = "Date";
            // 
            // NotifTitle1
            // 
            this.NotifTitle1.AutoSize = true;
            this.NotifTitle1.Location = new System.Drawing.Point(63, 11);
            this.NotifTitle1.Name = "NotifTitle1";
            this.NotifTitle1.Size = new System.Drawing.Size(87, 13);
            this.NotifTitle1.TabIndex = 1;
            this.NotifTitle1.Text = "Account Created";
            // 
            // NotifIcon1
            // 
            this.NotifIcon1.Image = ((System.Drawing.Image)(resources.GetObject("NotifIcon1.Image")));
            this.NotifIcon1.Location = new System.Drawing.Point(7, 15);
            this.NotifIcon1.Name = "NotifIcon1";
            this.NotifIcon1.Size = new System.Drawing.Size(49, 53);
            this.NotifIcon1.TabIndex = 0;
            this.NotifIcon1.TabStop = false;
            // 
            // NotifCloseForm
            // 
            this.NotifCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.NotifCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifCloseForm.FlatAppearance.BorderSize = 0;
            this.NotifCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotifCloseForm.ForeColor = System.Drawing.Color.White;
            this.NotifCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("NotifCloseForm.Image")));
            this.NotifCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotifCloseForm.Location = new System.Drawing.Point(131, 506);
            this.NotifCloseForm.Name = "NotifCloseForm";
            this.NotifCloseForm.Size = new System.Drawing.Size(136, 37);
            this.NotifCloseForm.TabIndex = 3;
            this.NotifCloseForm.Text = "        Close Notifications";
            this.NotifCloseForm.UseVisualStyleBackColor = false;
            this.NotifCloseForm.Click += new System.EventHandler(this.NotifCloseForm_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 552);
            this.Controls.Add(this.FlowPanelNotifications);
            this.Controls.Add(this.NotifCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationsForm";
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.FlowPanelNotifications.ResumeLayout(false);
            this.NotifPanel1.ResumeLayout(false);
            this.NotifPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotifIcon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanelNotifications;
        private System.Windows.Forms.Panel NotifPanel1;
        private System.Windows.Forms.Button NotifErase1;
        private System.Windows.Forms.Label NotifMessege1;
        private System.Windows.Forms.Label NotifDate1;
        private System.Windows.Forms.Label NotifTitle1;
        private System.Windows.Forms.PictureBox NotifIcon1;
        private System.Windows.Forms.Button NotifCloseForm;
    }
}