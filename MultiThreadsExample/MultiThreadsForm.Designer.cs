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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.threadNumberSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThread1
            // 
            this.txtThread1.Location = new System.Drawing.Point(27, 58);
            this.txtThread1.Name = "txtThread1";
            this.txtThread1.Size = new System.Drawing.Size(242, 483);
            this.txtThread1.TabIndex = 0;
            this.txtThread1.Text = "";
            // 
            // txtThread2
            // 
            this.txtThread2.Location = new System.Drawing.Point(283, 58);
            this.txtThread2.Name = "txtThread2";
            this.txtThread2.Size = new System.Drawing.Size(242, 483);
            this.txtThread2.TabIndex = 1;
            this.txtThread2.Text = "";
            // 
            // txtThread3
            // 
            this.txtThread3.Location = new System.Drawing.Point(539, 58);
            this.txtThread3.Name = "txtThread3";
            this.txtThread3.Size = new System.Drawing.Size(242, 483);
            this.txtThread3.TabIndex = 2;
            this.txtThread3.Text = "";
            // 
            // txtThread4
            // 
            this.txtThread4.Location = new System.Drawing.Point(795, 58);
            this.txtThread4.Name = "txtThread4";
            this.txtThread4.Size = new System.Drawing.Size(242, 483);
            this.txtThread4.TabIndex = 3;
            this.txtThread4.Text = "";
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Location = new System.Drawing.Point(48, 40);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(47, 13);
            this.lblThread1.TabIndex = 4;
            this.lblThread1.Text = "Thread1";
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Location = new System.Drawing.Point(303, 40);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(47, 13);
            this.lblThread2.TabIndex = 5;
            this.lblThread2.Text = "Thread2";
            // 
            // lblThread3
            // 
            this.lblThread3.AutoSize = true;
            this.lblThread3.Location = new System.Drawing.Point(558, 40);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(47, 13);
            this.lblThread3.TabIndex = 6;
            this.lblThread3.Text = "Thread3";
            // 
            // lblThread4
            // 
            this.lblThread4.AutoSize = true;
            this.lblThread4.Location = new System.Drawing.Point(813, 40);
            this.lblThread4.Name = "lblThread4";
            this.lblThread4.Size = new System.Drawing.Size(47, 13);
            this.lblThread4.TabIndex = 7;
            this.lblThread4.Text = "Thread4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadNumberSelectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // threadNumberSelectionToolStripMenuItem
            // 
            this.threadNumberSelectionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.threadNumberSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.threadNumberSelectionToolStripMenuItem.Name = "threadNumberSelectionToolStripMenuItem";
            this.threadNumberSelectionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.threadNumberSelectionToolStripMenuItem.Text = "THREAD";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "4";
            // 
            // MultiThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;//maximize form window  
            this.Controls.Add(this.lblThread4);
            this.Controls.Add(this.lblThread3);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.Controls.Add(this.txtThread4);
            this.Controls.Add(this.txtThread3);
            this.Controls.Add(this.txtThread2);
            this.Controls.Add(this.txtThread1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MultiThreadsForm";
            this.Text = "MultiThreadsDemo(by QW)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem threadNumberSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private int formWidth = 1366;
        private int formHeight = 768;
    }
}

