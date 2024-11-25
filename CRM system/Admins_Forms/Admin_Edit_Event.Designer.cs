namespace CRM_system.Admins_Forms
{
    partial class Admin_Edit_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Edit_Event));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PopEventAttend = new System.Windows.Forms.TextBox();
            this.PopEventDiscard = new System.Windows.Forms.Button();
            this.PopEventSave = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PopEventSchedule = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.PopEventPubSett = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.PopEventDesc = new System.Windows.Forms.RichTextBox();
            this.PopEventName = new System.Windows.Forms.TextBox();
            this.PopEventType = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.PopEventAttend);
            this.panel5.Controls.Add(this.PopEventDiscard);
            this.panel5.Controls.Add(this.PopEventSave);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.PopEventSchedule);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.PopEventPubSett);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.PopEventDesc);
            this.panel5.Controls.Add(this.PopEventName);
            this.panel5.Controls.Add(this.PopEventType);
            this.panel5.Location = new System.Drawing.Point(-1, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 501);
            this.panel5.TabIndex = 103;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Please be aware that some event properties are uneditable.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 99;
            this.label15.Text = "Attendee Limit";
            // 
            // PopEventAttend
            // 
            this.PopEventAttend.BackColor = System.Drawing.Color.White;
            this.PopEventAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopEventAttend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopEventAttend.Location = new System.Drawing.Point(20, 223);
            this.PopEventAttend.Name = "PopEventAttend";
            this.PopEventAttend.Size = new System.Drawing.Size(298, 26);
            this.PopEventAttend.TabIndex = 98;
            // 
            // PopEventDiscard
            // 
            this.PopEventDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.PopEventDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopEventDiscard.FlatAppearance.BorderSize = 0;
            this.PopEventDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopEventDiscard.ForeColor = System.Drawing.Color.White;
            this.PopEventDiscard.Image = ((System.Drawing.Image)(resources.GetObject("PopEventDiscard.Image")));
            this.PopEventDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PopEventDiscard.Location = new System.Drawing.Point(168, 429);
            this.PopEventDiscard.Name = "PopEventDiscard";
            this.PopEventDiscard.Size = new System.Drawing.Size(124, 29);
            this.PopEventDiscard.TabIndex = 89;
            this.PopEventDiscard.Text = "    Discard Changes";
            this.PopEventDiscard.UseVisualStyleBackColor = false;
            this.PopEventDiscard.Click += new System.EventHandler(this.PopEventDiscard_Click);
            // 
            // PopEventSave
            // 
            this.PopEventSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.PopEventSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopEventSave.FlatAppearance.BorderSize = 0;
            this.PopEventSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopEventSave.ForeColor = System.Drawing.Color.White;
            this.PopEventSave.Image = ((System.Drawing.Image)(resources.GetObject("PopEventSave.Image")));
            this.PopEventSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PopEventSave.Location = new System.Drawing.Point(38, 429);
            this.PopEventSave.Name = "PopEventSave";
            this.PopEventSave.Size = new System.Drawing.Size(124, 29);
            this.PopEventSave.TabIndex = 78;
            this.PopEventSave.Text = "    Save Changes";
            this.PopEventSave.UseVisualStyleBackColor = false;
            this.PopEventSave.Click += new System.EventHandler(this.PopEventSave_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(17, 311);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 16);
            this.label21.TabIndex = 83;
            this.label21.Text = "Content Schedule";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(18, 364);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 16);
            this.label22.TabIndex = 84;
            this.label22.Text = "Publish Settings";
            // 
            // PopEventSchedule
            // 
            this.PopEventSchedule.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PopEventSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopEventSchedule.Location = new System.Drawing.Point(17, 327);
            this.PopEventSchedule.Name = "PopEventSchedule";
            this.PopEventSchedule.Size = new System.Drawing.Size(298, 21);
            this.PopEventSchedule.TabIndex = 82;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(20, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 16);
            this.label23.TabIndex = 76;
            this.label23.Text = "Event Description";
            // 
            // PopEventPubSett
            // 
            this.PopEventPubSett.BackColor = System.Drawing.Color.White;
            this.PopEventPubSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopEventPubSett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopEventPubSett.FormattingEnabled = true;
            this.PopEventPubSett.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Draft"});
            this.PopEventPubSett.Location = new System.Drawing.Point(17, 379);
            this.PopEventPubSett.Name = "PopEventPubSett";
            this.PopEventPubSett.Size = new System.Drawing.Size(298, 24);
            this.PopEventPubSett.TabIndex = 85;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(20, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 16);
            this.label24.TabIndex = 73;
            this.label24.Text = "Event Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(18, 259);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 16);
            this.label25.TabIndex = 76;
            this.label25.Text = "Event Type";
            // 
            // PopEventDesc
            // 
            this.PopEventDesc.Location = new System.Drawing.Point(20, 128);
            this.PopEventDesc.Name = "PopEventDesc";
            this.PopEventDesc.Size = new System.Drawing.Size(298, 66);
            this.PopEventDesc.TabIndex = 81;
            this.PopEventDesc.Text = "";
            // 
            // PopEventName
            // 
            this.PopEventName.BackColor = System.Drawing.Color.White;
            this.PopEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopEventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopEventName.Location = new System.Drawing.Point(20, 79);
            this.PopEventName.Name = "PopEventName";
            this.PopEventName.Size = new System.Drawing.Size(298, 26);
            this.PopEventName.TabIndex = 72;
            this.PopEventName.TextChanged += new System.EventHandler(this.PopEventName_TextChanged);
            // 
            // PopEventType
            // 
            this.PopEventType.BackColor = System.Drawing.Color.White;
            this.PopEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopEventType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopEventType.FormattingEnabled = true;
            this.PopEventType.Items.AddRange(new object[] {
            "Leadership",
            "Sustainability ",
            "Entrepreneurship ",
            "Networking ",
            "Learning ",
            "Community Engagement",
            "Experiencing ",
            "Sharing ",
            "Creating"});
            this.PopEventType.Location = new System.Drawing.Point(17, 274);
            this.PopEventType.Name = "PopEventType";
            this.PopEventType.Size = new System.Drawing.Size(301, 24);
            this.PopEventType.TabIndex = 77;
            // 
            // Admin_Edit_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 497);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Edit_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Edit_Event";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PopEventAttend;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button PopEventDiscard;
        private System.Windows.Forms.Button PopEventSave;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker PopEventSchedule;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox PopEventPubSett;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RichTextBox PopEventDesc;
        private System.Windows.Forms.TextBox PopEventName;
        private System.Windows.Forms.ComboBox PopEventType;
        private System.Windows.Forms.Label label1;
    }
}