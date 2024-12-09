namespace CRM_system.Admins_Forms.EventsSubmenu
{
    partial class Events_Attendees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events_Attendees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgEventsAttendees = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRefattendees = new System.Windows.Forms.Button();
            this.btnRemoveAttendees = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SearchEventAttendees = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventsAttendees)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 540);
            this.panel1.TabIndex = 7;
            // 
            // dgEventsAttendees
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgEventsAttendees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEventsAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEventsAttendees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.dgEventsAttendees.Location = new System.Drawing.Point(244, 77);
            this.dgEventsAttendees.Name = "dgEventsAttendees";
            this.dgEventsAttendees.Size = new System.Drawing.Size(753, 391);
            this.dgEventsAttendees.TabIndex = 117;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(218, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 118;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(22, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 19);
            this.label17.TabIndex = 112;
            this.label17.Text = "Events Attendees list";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 30);
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // btnRefattendees
            // 
            this.btnRefattendees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnRefattendees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefattendees.Location = new System.Drawing.Point(429, 490);
            this.btnRefattendees.Name = "btnRefattendees";
            this.btnRefattendees.Size = new System.Drawing.Size(122, 29);
            this.btnRefattendees.TabIndex = 119;
            this.btnRefattendees.Text = "Refresh Attendees";
            this.btnRefattendees.UseVisualStyleBackColor = false;
            this.btnRefattendees.Click += new System.EventHandler(this.btnRefattendees_Click);
            // 
            // btnRemoveAttendees
            // 
            this.btnRemoveAttendees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnRemoveAttendees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveAttendees.Location = new System.Drawing.Point(557, 489);
            this.btnRemoveAttendees.Name = "btnRemoveAttendees";
            this.btnRemoveAttendees.Size = new System.Drawing.Size(122, 29);
            this.btnRemoveAttendees.TabIndex = 120;
            this.btnRemoveAttendees.Text = "Remove an Attendee";
            this.btnRemoveAttendees.UseVisualStyleBackColor = false;
            this.btnRemoveAttendees.Click += new System.EventHandler(this.btnRemoveAttendees_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.SearchEventAttendees);
            this.panel4.Location = new System.Drawing.Point(685, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 28);
            this.panel4.TabIndex = 121;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // SearchEventAttendees
            // 
            this.SearchEventAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SearchEventAttendees.Location = new System.Drawing.Point(27, 3);
            this.SearchEventAttendees.Name = "SearchEventAttendees";
            this.SearchEventAttendees.Size = new System.Drawing.Size(140, 23);
            this.SearchEventAttendees.TabIndex = 0;
            this.SearchEventAttendees.TextChanged += new System.EventHandler(this.SearchEventAttendees_TextChanged);
            // 
            // Events_Attendees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRemoveAttendees);
            this.Controls.Add(this.btnRefattendees);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgEventsAttendees);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events_Attendees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events_Attendees";
            this.Load += new System.EventHandler(this.Events_Attendees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEventsAttendees)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgEventsAttendees;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRefattendees;
        private System.Windows.Forms.Button btnRemoveAttendees;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox SearchEventAttendees;
    }
}