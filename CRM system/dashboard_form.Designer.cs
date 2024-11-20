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
            this.dashboardFormLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashboardFormLbl
            // 
            this.dashboardFormLbl.AutoSize = true;
            this.dashboardFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardFormLbl.Location = new System.Drawing.Point(437, 315);
            this.dashboardFormLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboardFormLbl.Name = "dashboardFormLbl";
            this.dashboardFormLbl.Size = new System.Drawing.Size(117, 25);
            this.dashboardFormLbl.TabIndex = 1;
            this.dashboardFormLbl.Text = "Dashboard";
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 665);
            this.Controls.Add(this.dashboardFormLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardFormLbl;
    }
}