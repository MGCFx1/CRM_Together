namespace CRM_system.Admins_Forms.ContactsSubmenu
{
    partial class Contacts_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts_List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adMembersRef = new System.Windows.Forms.Button();
            this.adMembersRemove = new System.Windows.Forms.Button();
            this.adMemberList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adMemberSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adMemberList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 540);
            this.panel1.TabIndex = 8;
            // 
            // adMembersRef
            // 
            this.adMembersRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adMembersRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adMembersRef.FlatAppearance.BorderSize = 0;
            this.adMembersRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adMembersRef.ForeColor = System.Drawing.Color.White;
            this.adMembersRef.Image = ((System.Drawing.Image)(resources.GetObject("adMembersRef.Image")));
            this.adMembersRef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adMembersRef.Location = new System.Drawing.Point(535, 486);
            this.adMembersRef.Name = "adMembersRef";
            this.adMembersRef.Size = new System.Drawing.Size(124, 29);
            this.adMembersRef.TabIndex = 64;
            this.adMembersRef.Text = "    Refresh List";
            this.adMembersRef.UseVisualStyleBackColor = false;
            this.adMembersRef.Click += new System.EventHandler(this.adMembersRef_Click);
            // 
            // adMembersRemove
            // 
            this.adMembersRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adMembersRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adMembersRemove.FlatAppearance.BorderSize = 0;
            this.adMembersRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adMembersRemove.ForeColor = System.Drawing.Color.White;
            this.adMembersRemove.Image = ((System.Drawing.Image)(resources.GetObject("adMembersRemove.Image")));
            this.adMembersRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adMembersRemove.Location = new System.Drawing.Point(395, 486);
            this.adMembersRemove.Name = "adMembersRemove";
            this.adMembersRemove.Size = new System.Drawing.Size(134, 29);
            this.adMembersRemove.TabIndex = 63;
            this.adMembersRemove.Text = "       Remove a member";
            this.adMembersRemove.UseVisualStyleBackColor = false;
            this.adMembersRemove.Click += new System.EventHandler(this.adMembersRemove_Click);
            // 
            // adMemberList
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.adMemberList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.adMemberList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adMemberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.adMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adMemberList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.adMemberList.Location = new System.Drawing.Point(244, 69);
            this.adMemberList.Name = "adMemberList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adMemberList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.adMemberList.RowHeadersWidth = 51;
            this.adMemberList.Size = new System.Drawing.Size(740, 402);
            this.adMemberList.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.adMemberSearch);
            this.panel2.Location = new System.Drawing.Point(665, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 28);
            this.panel2.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // adMemberSearch
            // 
            this.adMemberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.adMemberSearch.Location = new System.Drawing.Point(34, 3);
            this.adMemberSearch.Name = "adMemberSearch";
            this.adMemberSearch.Size = new System.Drawing.Size(149, 23);
            this.adMemberSearch.TabIndex = 0;
            this.adMemberSearch.TextChanged += new System.EventHandler(this.adMemberSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(218, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(22, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 19);
            this.label16.TabIndex = 112;
            this.label16.Text = "Contacts List";
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
            // Contacts_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.adMembersRef);
            this.Controls.Add(this.adMembersRemove);
            this.Controls.Add(this.adMemberList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts_List";
            this.Load += new System.EventHandler(this.Contacts_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adMemberList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adMembersRef;
        private System.Windows.Forms.Button adMembersRemove;
        private System.Windows.Forms.DataGridView adMemberList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox adMemberSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}