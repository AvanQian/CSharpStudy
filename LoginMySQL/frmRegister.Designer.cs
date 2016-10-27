namespace LoginApp.forms
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPasswrod = new System.Windows.Forms.Label();
            this.tbUserid = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.toolTip4Userid = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(37, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Userid";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPasswrod
            // 
            this.lblConfirmPasswrod.AutoSize = true;
            this.lblConfirmPasswrod.Location = new System.Drawing.Point(13, 107);
            this.lblConfirmPasswrod.Name = "lblConfirmPasswrod";
            this.lblConfirmPasswrod.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPasswrod.TabIndex = 2;
            this.lblConfirmPasswrod.Text = "Confirm Passwrod";
            // 
            // tbUserid
            // 
            this.tbUserid.AccessibleDescription = "";
            this.tbUserid.Location = new System.Drawing.Point(16, 26);
            this.tbUserid.MaxLength = 8;
            this.tbUserid.Name = "tbUserid";
            this.tbUserid.Size = new System.Drawing.Size(281, 20);
            this.tbUserid.TabIndex = 3;
            this.tbUserid.Tag = "";
            this.toolTip4Userid.SetToolTip(this.tbUserid, "Input 8 number begin with 1.");
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(16, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(281, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(16, 122);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(281, 20);
            this.tbConfirmPassword.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(222, 152);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // toolTip4Userid
            // 
            this.toolTip4Userid.AutoPopDelay = 5000;
            this.toolTip4Userid.InitialDelay = 500;
            this.toolTip4Userid.ReshowDelay = 500;
            this.toolTip4Userid.ShowAlways = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 182);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserid);
            this.Controls.Add(this.lblConfirmPasswrod);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPasswrod;
        private System.Windows.Forms.TextBox tbUserid;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ToolTip toolTip4Userid;
    }
}