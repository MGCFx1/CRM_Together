namespace CRM_system
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_register = new System.Windows.Forms.Label();
            this.login_show = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPasswordErr = new System.Windows.Forms.Label();
            this.lblEmailErr = new System.Windows.Forms.Label();
            this.btnBackAd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 543);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_register
            // 
            this.login_register.AutoSize = true;
            this.login_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.login_register.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_register.ForeColor = System.Drawing.Color.White;
            this.login_register.Location = new System.Drawing.Point(579, 422);
            this.login_register.Name = "login_register";
            this.login_register.Size = new System.Drawing.Size(76, 13);
            this.login_register.TabIndex = 8;
            this.login_register.Text = "Admins Only";
            this.login_register.Click += new System.EventHandler(this.label5_Click);
            // 
            // login_show
            // 
            this.login_show.AutoSize = true;
            this.login_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.login_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_show.ForeColor = System.Drawing.Color.White;
            this.login_show.Location = new System.Drawing.Point(582, 329);
            this.login_show.Name = "login_show";
            this.login_show.Size = new System.Drawing.Size(122, 20);
            this.login_show.TabIndex = 6;
            this.login_show.Text = "Show Password";
            this.login_show.UseVisualStyleBackColor = false;
            this.login_show.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Black;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Image = ((System.Drawing.Image)(resources.GetObject("login_btn.Image")));
            this.login_btn.Location = new System.Drawing.Point(539, 371);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(161, 38);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "  Login";
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.White;
            this.login_password.Location = new System.Drawing.Point(505, 292);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(208, 26);
            this.login_password.TabIndex = 4;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // login_email
            // 
            this.login_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.login_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.ForeColor = System.Drawing.Color.White;
            this.login_email.Location = new System.Drawing.Point(505, 211);
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(208, 26);
            this.login_email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.ForeColor = System.Drawing.Color.White;
            this.login_close.Location = new System.Drawing.Point(746, 22);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(20, 20);
            this.login_close.TabIndex = 2;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(475, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 403);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(500, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "It\'s great to have you back!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(499, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Welcome Admin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPasswordErr
            // 
            this.lblPasswordErr.AutoSize = true;
            this.lblPasswordErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblPasswordErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblPasswordErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.lblPasswordErr.Location = new System.Drawing.Point(585, 277);
            this.lblPasswordErr.Name = "lblPasswordErr";
            this.lblPasswordErr.Size = new System.Drawing.Size(84, 13);
            this.lblPasswordErr.TabIndex = 46;
            this.lblPasswordErr.Text = "wrong password";
            this.lblPasswordErr.Visible = false;
            // 
            // lblEmailErr
            // 
            this.lblEmailErr.AutoSize = true;
            this.lblEmailErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblEmailErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblEmailErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.lblEmailErr.Location = new System.Drawing.Point(502, 177);
            this.lblEmailErr.Name = "lblEmailErr";
            this.lblEmailErr.Size = new System.Drawing.Size(84, 13);
            this.lblEmailErr.TabIndex = 47;
            this.lblEmailErr.Text = "wrong password";
            this.lblEmailErr.Visible = false;
            // 
            // btnBackAd
            // 
            this.btnBackAd.BackColor = System.Drawing.Color.White;
            this.btnBackAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAd.FlatAppearance.BorderSize = 0;
            this.btnBackAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAd.Image = ((System.Drawing.Image)(resources.GetObject("btnBackAd.Image")));
            this.btnBackAd.Location = new System.Drawing.Point(713, 20);
            this.btnBackAd.Name = "btnBackAd";
            this.btnBackAd.Size = new System.Drawing.Size(27, 22);
            this.btnBackAd.TabIndex = 89;
            this.btnBackAd.UseVisualStyleBackColor = false;
            this.btnBackAd.Click += new System.EventHandler(this.btnBackAd_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.btnBackAd);
            this.Controls.Add(this.lblEmailErr);
            this.Controls.Add(this.lblPasswordErr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_register);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_show);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_email;
        private System.Windows.Forms.CheckBox login_show;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label login_register;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasswordErr;
        private System.Windows.Forms.Label lblEmailErr;
        private System.Windows.Forms.Button btnBackAd;
    }
}

