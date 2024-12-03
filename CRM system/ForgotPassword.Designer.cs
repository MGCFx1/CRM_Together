using System.Drawing;
using System.Windows.Forms;

namespace CRM_system
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.register_login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.Signup_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_close = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.signup_pswrd_hide = new System.Windows.Forms.Button();
            this.lblErrEmail = new System.Windows.Forms.Label();
            this.signup_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.lblErrDOB = new System.Windows.Forms.Label();
            this.lblErrPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.signup_post_code = new System.Windows.Forms.TextBox();
            this.lblPostCodeErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_login
            // 
            this.register_login.AutoSize = true;
            this.register_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.register_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_login.ForeColor = System.Drawing.Color.White;
            this.register_login.Location = new System.Drawing.Point(443, 469);
            this.register_login.Name = "register_login";
            this.register_login.Size = new System.Drawing.Size(86, 17);
            this.register_login.TabIndex = 8;
            this.register_login.Text = "Login here";
            this.register_login.Click += new System.EventHandler(this.register_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Succesfully Signed Up?";
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.White;
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.Signup_btn.Image = ((System.Drawing.Image)(resources.GetObject("Signup_btn.Image")));
            this.Signup_btn.Location = new System.Drawing.Point(324, 415);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(184, 41);
            this.Signup_btn.TabIndex = 5;
            this.Signup_btn.Text = "        Reset";
            this.Signup_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // Signup_close
            // 
            this.Signup_close.AutoSize = true;
            this.Signup_close.BackColor = System.Drawing.Color.White;
            this.Signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_close.Location = new System.Drawing.Point(746, 22);
            this.Signup_close.Name = "Signup_close";
            this.Signup_close.Size = new System.Drawing.Size(26, 25);
            this.Signup_close.TabIndex = 7;
            this.Signup_close.Text = "X";
            this.Signup_close.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 539);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.BackColor = System.Drawing.Color.White;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(746, 24);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(26, 25);
            this.login_close.TabIndex = 6;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Forgot Password?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "No problem, you can reset it!";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.ForeColor = System.Drawing.Color.White;
            this.Sign.Location = new System.Drawing.Point(231, 151);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(118, 20);
            this.Sign.TabIndex = 26;
            this.Sign.Text = "Email Address";
            this.Sign.Click += new System.EventHandler(this.label13_Click);
            // 
            // signup_email
            // 
            this.signup_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.signup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.ForeColor = System.Drawing.Color.White;
            this.signup_email.Location = new System.Drawing.Point(224, 165);
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(394, 30);
            this.signup_email.TabIndex = 25;
            this.signup_email.TextChanged += new System.EventHandler(this.signup_email_TextChanged);
            // 
            // signup_pswrd_hide
            // 
            this.signup_pswrd_hide.Location = new System.Drawing.Point(0, 0);
            this.signup_pswrd_hide.Name = "signup_pswrd_hide";
            this.signup_pswrd_hide.Size = new System.Drawing.Size(75, 23);
            this.signup_pswrd_hide.TabIndex = 86;
            // 
            // lblErrEmail
            // 
            this.lblErrEmail.AutoSize = true;
            this.lblErrEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblErrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblErrEmail.ForeColor = System.Drawing.Color.White;
            this.lblErrEmail.Location = new System.Drawing.Point(353, 145);
            this.lblErrEmail.Name = "lblErrEmail";
            this.lblErrEmail.Size = new System.Drawing.Size(110, 17);
            this.lblErrEmail.TabIndex = 44;
            this.lblErrEmail.Text = "wrong password";
            this.lblErrEmail.Visible = false;
            // 
            // signup_dateOfBirth
            // 
            this.signup_dateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.signup_dateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.signup_dateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signup_dateOfBirth.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLight;
            this.signup_dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.signup_dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.signup_dateOfBirth.Location = new System.Drawing.Point(224, 226);
            this.signup_dateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.signup_dateOfBirth.MinimumSize = new System.Drawing.Size(4, 28);
            this.signup_dateOfBirth.Name = "signup_dateOfBirth";
            this.signup_dateOfBirth.Size = new System.Drawing.Size(394, 28);
            this.signup_dateOfBirth.TabIndex = 83;
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.DOBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLbl.ForeColor = System.Drawing.Color.White;
            this.DOBLbl.Location = new System.Drawing.Point(231, 211);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(105, 20);
            this.DOBLbl.TabIndex = 84;
            this.DOBLbl.Text = "Date of Birth";
            // 
            // lblErrDOB
            // 
            this.lblErrDOB.AutoSize = true;
            this.lblErrDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblErrDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblErrDOB.ForeColor = System.Drawing.Color.White;
            this.lblErrDOB.Location = new System.Drawing.Point(353, 205);
            this.lblErrDOB.Name = "lblErrDOB";
            this.lblErrDOB.Size = new System.Drawing.Size(110, 17);
            this.lblErrDOB.TabIndex = 85;
            this.lblErrDOB.Text = "wrong password";
            this.lblErrDOB.Visible = false;
            this.lblErrDOB.Click += new System.EventHandler(this.lblErrDOB_Click);
            // 
            // lblErrPassword
            // 
            this.lblErrPassword.AutoSize = true;
            this.lblErrPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblErrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblErrPassword.ForeColor = System.Drawing.Color.White;
            this.lblErrPassword.Location = new System.Drawing.Point(340, 330);
            this.lblErrPassword.Name = "lblErrPassword";
            this.lblErrPassword.Size = new System.Drawing.Size(110, 17);
            this.lblErrPassword.TabIndex = 89;
            this.lblErrPassword.Text = "wrong password";
            this.lblErrPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Password";
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.ForeColor = System.Drawing.Color.White;
            this.signup_password.Location = new System.Drawing.Point(224, 350);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(394, 30);
            this.signup_password.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(231, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 91;
            this.label16.Text = "Post Code";
            // 
            // signup_post_code
            // 
            this.signup_post_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.signup_post_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_post_code.ForeColor = System.Drawing.Color.White;
            this.signup_post_code.Location = new System.Drawing.Point(224, 287);
            this.signup_post_code.Name = "signup_post_code";
            this.signup_post_code.Size = new System.Drawing.Size(394, 30);
            this.signup_post_code.TabIndex = 90;
            // 
            // lblPostCodeErr
            // 
            this.lblPostCodeErr.AutoSize = true;
            this.lblPostCodeErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblPostCodeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblPostCodeErr.ForeColor = System.Drawing.Color.White;
            this.lblPostCodeErr.Location = new System.Drawing.Point(340, 267);
            this.lblPostCodeErr.Name = "lblPostCodeErr";
            this.lblPostCodeErr.Size = new System.Drawing.Size(110, 17);
            this.lblPostCodeErr.TabIndex = 92;
            this.lblPostCodeErr.Text = "wrong password";
            this.lblPostCodeErr.Visible = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.lblPostCodeErr);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.signup_post_code);
            this.Controls.Add(this.lblErrPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.lblErrDOB);
            this.Controls.Add(this.DOBLbl);
            this.Controls.Add(this.signup_dateOfBirth);
            this.Controls.Add(this.lblErrEmail);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.register_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Signup_close);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_pswrd_hide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label register_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.Label Signup_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Sign;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Button signup_pswrd_hide;
        private System.Windows.Forms.Label lblErrEmail;
        private DateTimePicker signup_dateOfBirth;
        private Label DOBLbl;
        private Label lblErrDOB;
        private Label lblErrPassword;
        private Label label2;
        private TextBox signup_password;
        private Label label16;
        private TextBox signup_post_code;
        private Label lblPostCodeErr;
    }
}