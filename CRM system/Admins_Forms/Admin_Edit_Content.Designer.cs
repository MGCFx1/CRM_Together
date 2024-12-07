namespace CRM_system.Admins_Forms
{
    partial class Admin_Edit_Content
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PopContentAttend = new System.Windows.Forms.TextBox();
            this.PopEventDiscard = new System.Windows.Forms.Button();
            this.PopEventSave = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PopContentSchedule = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.PopContentPubSett = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.PopContentDesc = new System.Windows.Forms.RichTextBox();
            this.PopContentName = new System.Windows.Forms.TextBox();
            this.PopContentType = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.PopContentAttend);
            this.panel5.Controls.Add(this.PopEventDiscard);
            this.panel5.Controls.Add(this.PopEventSave);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.PopContentSchedule);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.PopContentPubSett);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.PopContentDesc);
            this.panel5.Controls.Add(this.PopContentName);
            this.panel5.Controls.Add(this.PopContentType);
            this.panel5.Location = new System.Drawing.Point(-1, -2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 617);
            this.panel5.TabIndex = 103;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Please be aware that some content properties are uneditable.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 256);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 99;
            this.label15.Text = "Attendee Limit";
            // 
            // PopContentAttend
            // 
            this.PopContentAttend.BackColor = System.Drawing.Color.White;
            this.PopContentAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopContentAttend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopContentAttend.Location = new System.Drawing.Point(27, 274);
            this.PopContentAttend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentAttend.Name = "PopContentAttend";
            this.PopContentAttend.Size = new System.Drawing.Size(396, 30);
            this.PopContentAttend.TabIndex = 98;
            // 
            // PopEventDiscard
            // 
            this.PopEventDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.PopEventDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopEventDiscard.FlatAppearance.BorderSize = 0;
            this.PopEventDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopEventDiscard.ForeColor = System.Drawing.Color.White;
            this.PopEventDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PopEventDiscard.Location = new System.Drawing.Point(224, 528);
            this.PopEventDiscard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopEventDiscard.Name = "PopEventDiscard";
            this.PopEventDiscard.Size = new System.Drawing.Size(165, 36);
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
            this.PopEventSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PopEventSave.Location = new System.Drawing.Point(51, 528);
            this.PopEventSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopEventSave.Name = "PopEventSave";
            this.PopEventSave.Size = new System.Drawing.Size(165, 36);
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
            this.label21.Location = new System.Drawing.Point(23, 383);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 20);
            this.label21.TabIndex = 83;
            this.label21.Text = "Content Schedule";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(24, 448);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 20);
            this.label22.TabIndex = 84;
            this.label22.Text = "Publish Settings";
            // 
            // PopContentSchedule
            // 
            this.PopContentSchedule.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PopContentSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopContentSchedule.Location = new System.Drawing.Point(23, 402);
            this.PopContentSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentSchedule.Name = "PopContentSchedule";
            this.PopContentSchedule.Size = new System.Drawing.Size(396, 24);
            this.PopContentSchedule.TabIndex = 82;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(27, 139);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(158, 20);
            this.label23.TabIndex = 76;
            this.label23.Text = "Content Description";
            // 
            // PopContentPubSett
            // 
            this.PopContentPubSett.BackColor = System.Drawing.Color.White;
            this.PopContentPubSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopContentPubSett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopContentPubSett.FormattingEnabled = true;
            this.PopContentPubSett.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Draft"});
            this.PopContentPubSett.Location = new System.Drawing.Point(23, 466);
            this.PopContentPubSett.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentPubSett.Name = "PopContentPubSett";
            this.PopContentPubSett.Size = new System.Drawing.Size(396, 28);
            this.PopContentPubSett.TabIndex = 85;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(27, 82);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 20);
            this.label24.TabIndex = 73;
            this.label24.Text = "Content Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(24, 319);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 20);
            this.label25.TabIndex = 76;
            this.label25.Text = "Content Type";
            // 
            // PopContentDesc
            // 
            this.PopContentDesc.Location = new System.Drawing.Point(27, 158);
            this.PopContentDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentDesc.Name = "PopContentDesc";
            this.PopContentDesc.Size = new System.Drawing.Size(396, 80);
            this.PopContentDesc.TabIndex = 81;
            this.PopContentDesc.Text = "";
            // 
            // PopContentName
            // 
            this.PopContentName.BackColor = System.Drawing.Color.White;
            this.PopContentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopContentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopContentName.Location = new System.Drawing.Point(27, 97);
            this.PopContentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentName.Name = "PopContentName";
            this.PopContentName.Size = new System.Drawing.Size(396, 30);
            this.PopContentName.TabIndex = 72;
            this.PopContentName.TextChanged += new System.EventHandler(this.PopEventName_TextChanged);
            // 
            // PopContentType
            // 
            this.PopContentType.BackColor = System.Drawing.Color.White;
            this.PopContentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopContentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PopContentType.FormattingEnabled = true;
            this.PopContentType.Items.AddRange(new object[] {
            "Leadership",
            "Sustainability ",
            "Entrepreneurship ",
            "Networking ",
            "Learning ",
            "Community Engagement",
            "Experiencing ",
            "Sharing ",
            "Creating"});
            this.PopContentType.Location = new System.Drawing.Point(23, 337);
            this.PopContentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopContentType.Name = "PopContentType";
            this.PopContentType.Size = new System.Drawing.Size(400, 28);
            this.PopContentType.TabIndex = 77;
            // 
            // Admin_Edit_Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 612);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_Edit_Content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Edit_Event";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PopContentAttend;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button PopEventDiscard;
        private System.Windows.Forms.Button PopEventSave;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker PopContentSchedule;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox PopContentPubSett;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RichTextBox PopContentDesc;
        private System.Windows.Forms.TextBox PopContentName;
        private System.Windows.Forms.ComboBox PopContentType;
        private System.Windows.Forms.Label label1;
    }
}