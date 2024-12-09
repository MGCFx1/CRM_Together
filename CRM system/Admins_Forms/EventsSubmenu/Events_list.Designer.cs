namespace CRM_system.Admins_Forms.EventsSubmenu
{
    partial class Events_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events_list));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditEvents = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdSearchEvents = new System.Windows.Forms.TextBox();
            this.btnRemoveEvents = new System.Windows.Forms.Button();
            this.btnRefEvents = new System.Windows.Forms.Button();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 540);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(239, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 27);
            this.panel2.TabIndex = 111;
            // 
            // btnEditEvents
            // 
            this.btnEditEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditEvents.ForeColor = System.Drawing.Color.White;
            this.btnEditEvents.Location = new System.Drawing.Point(571, 481);
            this.btnEditEvents.Name = "btnEditEvents";
            this.btnEditEvents.Size = new System.Drawing.Size(97, 29);
            this.btnEditEvents.TabIndex = 107;
            this.btnEditEvents.Text = "Edit Event";
            this.btnEditEvents.UseVisualStyleBackColor = false;
            this.btnEditEvents.Click += new System.EventHandler(this.btnEditEvents_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.AdSearchEvents);
            this.panel5.Location = new System.Drawing.Point(665, 481);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 28);
            this.panel5.TabIndex = 108;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AdSearchEvents
            // 
            this.AdSearchEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AdSearchEvents.Location = new System.Drawing.Point(27, 3);
            this.AdSearchEvents.Name = "AdSearchEvents";
            this.AdSearchEvents.Size = new System.Drawing.Size(140, 23);
            this.AdSearchEvents.TabIndex = 0;
            this.AdSearchEvents.TextChanged += new System.EventHandler(this.AdSearchEvents_TextChanged_1);
            // 
            // btnRemoveEvents
            // 
            this.btnRemoveEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnRemoveEvents.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEvents.Location = new System.Drawing.Point(475, 482);
            this.btnRemoveEvents.Name = "btnRemoveEvents";
            this.btnRemoveEvents.Size = new System.Drawing.Size(97, 29);
            this.btnRemoveEvents.TabIndex = 106;
            this.btnRemoveEvents.Text = "Remove Event";
            this.btnRemoveEvents.UseVisualStyleBackColor = false;
            this.btnRemoveEvents.Click += new System.EventHandler(this.btnRemoveEvents_Click_1);
            // 
            // btnRefEvents
            // 
            this.btnRefEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnRefEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefEvents.Location = new System.Drawing.Point(379, 482);
            this.btnRefEvents.Name = "btnRefEvents";
            this.btnRefEvents.Size = new System.Drawing.Size(97, 29);
            this.btnRefEvents.TabIndex = 105;
            this.btnRefEvents.Text = "Refresh Events";
            this.btnRefEvents.UseVisualStyleBackColor = false;
            this.btnRefEvents.Click += new System.EventHandler(this.btnRefEvents_Click_1);
            // 
            // dgEvents
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.dgEvents.Location = new System.Drawing.Point(239, 73);
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.Size = new System.Drawing.Size(751, 391);
            this.dgEvents.TabIndex = 104;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(218, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 115;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(22, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 19);
            this.label16.TabIndex = 112;
            this.label16.Text = "Events List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 30);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // Events_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEditEvents);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnRemoveEvents);
            this.Controls.Add(this.btnRefEvents);
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events_list";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditEvents;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox AdSearchEvents;
        private System.Windows.Forms.Button btnRemoveEvents;
        private System.Windows.Forms.Button btnRefEvents;
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}