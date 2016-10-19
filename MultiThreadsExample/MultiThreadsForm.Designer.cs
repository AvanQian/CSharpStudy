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

        protected override void OnResize(System.EventArgs e)
        {
            //所有调整窗体大小的动作，不管是最大化/最小化操作都会调用此方法，所以改变大小后都要获取client的大小以调整其中控件的大小
            base.OnResize(e);
            if(this.WindowState.Equals(System.Windows.Forms.FormWindowState.Maximized))
            {
                clientWidth = this.ClientSize.Width;
                clientHeight = this.ClientSize.Height;
            }
            clientWidth = this.ClientSize.Width;
            clientHeight = this.ClientSize.Height;
            DisplayControls();
        }
/*
        //调整大小前会调用此方法
        protected override void OnResizeBegin(System.EventArgs e)
        {
            base.OnResizeBegin(e);
            beforeResizeSize = this.Size;
        }

        //调整大小后会调用此方法，因此在结束后也可以获取client的大小
        protected override void OnResizeEnd(System.EventArgs e)
        {
            base.OnResizeEnd(e);
            clientWidth = this.ClientSize.Width;
            clientHeight = this.ClientSize.Height;
        }
*/


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// Create 4 RichTextBox/Label/Button, but display them according to thread number configuration
        /// </summary>
        private void InitializeComponent()
        {
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
            this.btnThread1 = new System.Windows.Forms.Button();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.btnThread3 = new System.Windows.Forms.Button();
            this.btnThread4 = new System.Windows.Forms.Button();
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
            this.txtThread1.Visible = false;
            // 
            // txtThread2
            // 
            this.txtThread2.Location = new System.Drawing.Point(283, 58);
            this.txtThread2.Name = "txtThread2";
            this.txtThread2.Size = new System.Drawing.Size(242, 483);
            this.txtThread2.TabIndex = 1;
            this.txtThread2.Text = "";
            this.txtThread2.Visible = false;
            // 
            // txtThread3
            // 
            this.txtThread3.Location = new System.Drawing.Point(539, 58);
            this.txtThread3.Name = "txtThread3";
            this.txtThread3.Size = new System.Drawing.Size(242, 483);
            this.txtThread3.TabIndex = 2;
            this.txtThread3.Text = "";
            this.txtThread3.Visible = false;
            // 
            // txtThread4
            // 
            this.txtThread4.Location = new System.Drawing.Point(795, 58);
            this.txtThread4.Name = "txtThread4";
            this.txtThread4.Size = new System.Drawing.Size(242, 483);
            this.txtThread4.TabIndex = 3;
            this.txtThread4.Text = "";
            this.txtThread4.Visible = false;
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Location = new System.Drawing.Point(48, 37);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(47, 13);
            this.lblThread1.TabIndex = 4;
            this.lblThread1.Text = "Thread1";
            this.lblThread1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThread1.Visible = false;
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Location = new System.Drawing.Point(303, 37);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(47, 13);
            this.lblThread2.TabIndex = 5;
            this.lblThread2.Text = "Thread2";
            this.lblThread2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThread2.Visible = false;
            // 
            // lblThread3
            // 
            this.lblThread3.AutoSize = true;
            this.lblThread3.Location = new System.Drawing.Point(558, 37);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(47, 13);
            this.lblThread3.TabIndex = 6;
            this.lblThread3.Text = "Thread3";
            this.lblThread3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThread3.Visible = false;
            // 
            // lblThread4
            // 
            this.lblThread4.AutoSize = true;
            this.lblThread4.Location = new System.Drawing.Point(813, 37);
            this.lblThread4.Name = "lblThread4";
            this.lblThread4.Size = new System.Drawing.Size(47, 13);
            this.lblThread4.TabIndex = 7;
            this.lblThread4.Text = "Thread4";
            this.lblThread4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThread4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadNumberSelectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
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
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(179, 30);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(75, 26);
            this.btnThread1.TabIndex = 9;
            this.btnThread1.Text = "Start1";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Visible = false;
            // 
            // btnThread2
            // 
            this.btnThread2.Location = new System.Drawing.Point(440, 30);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Size = new System.Drawing.Size(75, 26);
            this.btnThread2.TabIndex = 10;
            this.btnThread2.Text = "Start2";
            this.btnThread2.UseVisualStyleBackColor = true;
            this.btnThread2.Visible = false;
            // 
            // btnThread3
            // 
            this.btnThread3.Location = new System.Drawing.Point(701, 30);
            this.btnThread3.Name = "btnThread3";
            this.btnThread3.Size = new System.Drawing.Size(75, 26);
            this.btnThread3.TabIndex = 11;
            this.btnThread3.Text = "Start3";
            this.btnThread3.UseVisualStyleBackColor = true;
            this.btnThread3.Visible = false;
            // 
            // btnThread4
            // 
            this.btnThread4.Location = new System.Drawing.Point(962, 30);
            this.btnThread4.Name = "btnThread4";
            this.btnThread4.Size = new System.Drawing.Size(75, 26);
            this.btnThread4.TabIndex = 12;
            this.btnThread4.Text = "Start4";
            this.btnThread4.UseVisualStyleBackColor = true;
            this.btnThread4.Visible = false;
            // 
            // MultiThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnThread4);
            this.Controls.Add(this.btnThread3);
            this.Controls.Add(this.btnThread2);
            this.Controls.Add(this.btnThread1);
            this.Controls.Add(this.lblThread4);
            this.Controls.Add(this.lblThread3);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.Controls.Add(this.txtThread4);
            this.Controls.Add(this.txtThread3);
            this.Controls.Add(this.txtThread2);
            this.Controls.Add(this.txtThread1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.Button btnThread3;
        private System.Windows.Forms.Button btnThread4;
        private int formWidth;  //整个form的宽和高
        private int formHeight;
        private int clientWidth;    //编辑区域的宽和高
        private int clientHeight;
        private int toLeftRight = 30;
        private int toTop = 60;
        private int toBottom = 30;
        private int btnWidth = 75;
        private int btnHeight = 25;
        private int lblWidth = 47;  //width of label can't be changed
        private int lblHeight = 13; //height of label can't be changed
        private System.Drawing.Size beforeResizeSize = System.Drawing.Size.Empty;
    }
}

