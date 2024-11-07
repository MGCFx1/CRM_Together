namespace CRM_system
{
    partial class Landing_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            this.Signup_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.landing_login = new System.Windows.Forms.Button();
            this.landing_signup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signup_close
            // 
            this.Signup_close.AutoSize = true;
            this.Signup_close.BackColor = System.Drawing.Color.White;
            this.Signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_close.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_close.Location = new System.Drawing.Point(747, 22);
            this.Signup_close.Name = "Signup_close";
            this.Signup_close.Size = new System.Drawing.Size(22, 28);
            this.Signup_close.TabIndex = 9;
            this.Signup_close.Text = "X";
            this.Signup_close.Click += new System.EventHandler(this.Signup_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 543);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(45, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 381);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEGIN YOUR JOURNEY WITH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOGETHER CULTURE!";
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(60, 91);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(200, 10);
            this.line.TabIndex = 2;
            this.line.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Why together culture?";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 201);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // landing_login
            // 
            this.landing_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.landing_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.landing_login.ForeColor = System.Drawing.Color.White;
            this.landing_login.Image = global::CRM_system.Properties.Resources.icons8_login_20;
            this.landing_login.Location = new System.Drawing.Point(417, 282);
            this.landing_login.Name = "landing_login";
            this.landing_login.Size = new System.Drawing.Size(163, 44);
            this.landing_login.TabIndex = 11;
            this.landing_login.Text = "        Login";
            this.landing_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.landing_login.UseVisualStyleBackColor = false;
            this.landing_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // landing_signup
            // 
            this.landing_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.landing_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.landing_signup.ForeColor = System.Drawing.Color.White;
            this.landing_signup.Image = ((System.Drawing.Image)(resources.GetObject("landing_signup.Image")));
            this.landing_signup.Location = new System.Drawing.Point(606, 282);
            this.landing_signup.Name = "landing_signup";
            this.landing_signup.Size = new System.Drawing.Size(163, 44);
            this.landing_signup.TabIndex = 12;
            this.landing_signup.Text = "        Sign Up";
            this.landing_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.landing_signup.UseVisualStyleBackColor = false;
            this.landing_signup.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(488, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Join Us Today!";
            // 
            // Landing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.landing_signup);
            this.Controls.Add(this.landing_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Signup_close);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Landing_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Signup_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button landing_login;
        private System.Windows.Forms.Button landing_signup;
        private System.Windows.Forms.Label label5;
    }
}