namespace MultiThreadsExample
{
    partial class MultiThreadsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiThreadsForm));
            this.txtThread1 = new System.Windows.Forms.RichTextBox();
            this.txtThread2 = new System.Windows.Forms.RichTextBox();
            this.txtThread3 = new System.Windows.Forms.RichTextBox();
            this.txtThread4 = new System.Windows.Forms.RichTextBox();
            this.lblThread1 = new System.Windows.Forms.Label();
            this.lblThread2 = new System.Windows.Forms.Label();
            this.lblThread3 = new System.Windows.Forms.Label();
            this.lblThread4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtThread1
            // 
            this.txtThread1.Location = new System.Drawing.Point(27, 40);
            this.txtThread1.Name = "txtThread1";
            this.txtThread1.Size = new System.Drawing.Size(242, 501);
            this.txtThread1.TabIndex = 0;
            this.txtThread1.Text = "";
            // 
            // txtThread2
            // 
            this.txtThread2.Location = new System.Drawing.Point(283, 40);
            this.txtThread2.Name = "txtThread2";
            this.txtThread2.Size = new System.Drawing.Size(242, 501);
            this.txtThread2.TabIndex = 1;
            this.txtThread2.Text = "";
            // 
            // txtThread3
            // 
            this.txtThread3.Location = new System.Drawing.Point(539, 40);
            this.txtThread3.Name = "txtThread3";
            this.txtThread3.Size = new System.Drawing.Size(242, 501);
            this.txtThread3.TabIndex = 2;
            this.txtThread3.Text = "";
            // 
            // txtThread4
            // 
            this.txtThread4.Location = new System.Drawing.Point(795, 40);
            this.txtThread4.Name = "txtThread4";
            this.txtThread4.Size = new System.Drawing.Size(242, 501);
            this.txtThread4.TabIndex = 3;
            this.txtThread4.Text = "";
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Location = new System.Drawing.Point(48, 19);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(47, 13);
            this.lblThread1.TabIndex = 4;
            this.lblThread1.Text = "Thread1";
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Location = new System.Drawing.Point(303, 19);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(47, 13);
            this.lblThread2.TabIndex = 5;
            this.lblThread2.Text = "Thread2";
            // 
            // lblThread3
            // 
            this.lblThread3.AutoSize = true;
            this.lblThread3.Location = new System.Drawing.Point(558, 19);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(47, 13);
            this.lblThread3.TabIndex = 6;
            this.lblThread3.Text = "Thread3";
            // 
            // lblThread4
            // 
            this.lblThread4.AutoSize = true;
            this.lblThread4.Location = new System.Drawing.Point(813, 19);
            this.lblThread4.Name = "lblThread4";
            this.lblThread4.Size = new System.Drawing.Size(47, 13);
            this.lblThread4.TabIndex = 7;
            this.lblThread4.Text = "Thread4";
            // 
            // MultiThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 562);
            this.Controls.Add(this.lblThread4);
            this.Controls.Add(this.lblThread3);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.Controls.Add(this.txtThread4);
            this.Controls.Add(this.txtThread3);
            this.Controls.Add(this.txtThread2);
            this.Controls.Add(this.txtThread1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiThreadsForm";
            this.Text = "MultiThreadsDemo(by QW)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtThread1;
        private System.Windows.Forms.RichTextBox txtThread2;
        private System.Windows.Forms.RichTextBox txtThread3;
        private System.Windows.Forms.RichTextBox txtThread4;
        private System.Windows.Forms.Label lblThread1;
        private System.Windows.Forms.Label lblThread2;
        private System.Windows.Forms.Label lblThread3;
        private System.Windows.Forms.Label lblThread4;
    }
}

