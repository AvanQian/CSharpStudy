using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;    //StreamReader
using System.Windows.Forms;

namespace MultiThreadsExample
{
    public partial class MultiThreadsForm : Form
    {
        private List<Thread> multiThreads = new List<Thread>();
        const int iRtbNumber = 4;
        const int iTestNumber = 20;
        string msgThread = string.Empty;
        string txtPath = string.Empty;
        private delegate void WriteMessageDelegate1(string msg);
        private delegate void WriteMessageDelegate2(string msg);
        private delegate void WriteMessageDelegate3(string msg);
        private delegate void WriteMessageDelegate4(string msg);

        private static Object lockObj = new Object();
        private static Object rndLock = new Object();

        public MultiThreadsForm()
        {
            GetThreadNumberFormFile();
            InitializeComponent();
            DisplayControls();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;//maximize form window  

            formWidth = this.Size.Width;  //acquire width for current form 
            formWidth = this.Size.Height; //acquire height for current form
/*
            Thread thread = Thread.CurrentThread;
            lock (lockObj)
            {
                msgThread = String.Format("Application thread information\n") +
                      String.Format("   Background: {0}\n", thread.IsBackground) +
                      String.Format("   Thread Pool: {0}\n", thread.IsThreadPoolThread) +
                      String.Format("   Thread ID: {0}\n", thread.ManagedThreadId);
            }
            WriteMessage1(msgThread);
            WriteMessage2(msgThread);
            WriteMessage3(msgThread);
            WriteMessage4(msgThread);
            
            multiThreads.Add(new Thread(new ThreadStart(ThreadAction0)));
            multiThreads.Add(new Thread(new ThreadStart(ThreadAction1)));
            multiThreads.Add(new Thread(new ThreadStart(ThreadAction2)));
            multiThreads.Add(new Thread(new ThreadStart(ThreadAction3)));
            multiThreads[0].Start();
            multiThreads[1].Start();
            multiThreads[2].Start();
            multiThreads[3].Start();
 * */
        }

        private void ThreadAction0()
        {
            //Thread printMsg = new Thread(new ParameterizedThreadStart(PrintMsg0));
            //printMsg.Start(PrintMsg0);
            string msg = string.Empty;
            for (int i = 0; i < iTestNumber; i++)
            {
                msg = string.Format("key = {0}, value = Thread1_{1}\n", i, i);
                Thread.Sleep(100);//sleep to wait for printing message
                WriteMessage1(msg);
            }
            WriteMessage1("End of printing message for Thread0!");
        }
        /*
        private void PrintMsg0(object msg)
        {
        }
        */

        private void ThreadAction1()
        {
            Random rnd = new Random();
            //List<Task<Double>> lstTasks = new List<Task<Double>>(); 
            var tasks = new List<Task<Double>>();
            string msg = string.Empty;
            Thread thread = Thread.CurrentThread;
            lock (lockObj)
            {
                msg = String.Format("Current main thread information\n") +
                      String.Format("   Background: {0}\n", thread.IsBackground) +
                      String.Format("   Thread Pool: {0}\n", thread.IsThreadPoolThread) +
                      String.Format("   Thread ID: {0}\n", thread.ManagedThreadId);
            }
            WriteMessage2(msg);

            Task<Double> t = Task.Run(() =>
            {
                Thread mainTask = Thread.CurrentThread;
                lock (lockObj)
                {
                    msg = String.Format("Main Task(Task #" + Task.CurrentId.ToString() + ")" + " thread information\n") +
                          String.Format("   Background: {0}\n", mainTask.IsBackground) +
                          String.Format("   Thread Pool: {0}\n", mainTask.IsThreadPoolThread) +
                          String.Format("   Thread ID: {0}\n", mainTask.ManagedThreadId);
                }
                WriteMessage2(msg);
                
                for (int ctr = 1; ctr <= 20; ctr++)
                    tasks.Add(Task.Factory.StartNew(
                       () =>
                       {
                           Thread currentTask = Thread.CurrentThread;
                           lock (lockObj)
                           {
                               msg = String.Format("Task #" + Task.CurrentId.ToString() + " thread information\n") +
                                     String.Format("   Background: {0}\n", currentTask.IsBackground) +
                                     String.Format("   Thread Pool: {0}\n", currentTask.IsThreadPoolThread) +
                                     String.Format("   Thread ID: {0}\n", currentTask.ManagedThreadId);
                           }
                           WriteMessage2(msg);
                           
                           long s = 0;
                           for (int n = 0; n <= 999999; n++)
                           {
                               lock (rndLock)
                               {
                                   s += rnd.Next(1, 1000001);
                               }
                           }
                           return s / 1000000.0;
                       }));

                Task.WaitAll(tasks.ToArray());
                Double grandTotal = 0;
                WriteMessage2("Means of each task: ");
                foreach (var child in tasks)
                {
                    msg = string.Format("task ID = {0}, task result = {1}\n", child.Id, child.Result);
                    WriteMessage2(msg);
                    grandTotal += child.Result;
                }
                return grandTotal / 20;
            });
            msg = string.Format("Mean of Means: {0}", t.Result);
            WriteMessage2(msg);
        }

        private void ThreadAction2()
        {
        }

        private void ThreadAction3()
        {
        }

        private void WriteMessage1(string msg)
        {
            if (this.txtThread1.InvokeRequired)
            {
                WriteMessageDelegate1 d = new WriteMessageDelegate1(WriteMessage1);
                this.txtThread1.Invoke(d, new object[] { msg });
            }
            else
            {
                this.txtThread1.AppendText(msg + Environment.NewLine);
            }
        }

        private void WriteMessage2(string msg)
        {
            /*
            String msg = null;
            Thread thread = Thread.CurrentThread;
            lock (lockObj)
            {
                msg = String.Format("{0} thread information\n", taskName) +
                      String.Format("   Background: {0}\n", thread.IsBackground) +
                      String.Format("   Thread Pool: {0}\n", thread.IsThreadPoolThread) +
                      String.Format("   Thread ID: {0}\n", thread.ManagedThreadId);
            }
            */
            if (this.txtThread2.InvokeRequired)
            {
                WriteMessageDelegate2 d = new WriteMessageDelegate2(WriteMessage2);
                this.txtThread2.Invoke(d, new object[] { msg });
            }
            else
            {
                this.txtThread2.AppendText(msg + Environment.NewLine);
            }
        }

        private void WriteMessage3(string msg)
        {
            if (this.txtThread3.InvokeRequired)
            {
                WriteMessageDelegate3 d = new WriteMessageDelegate3(WriteMessage3);
                this.txtThread3.Invoke(d, new object[] { msg });
            }
            else
            {
                this.txtThread3.AppendText(msg + Environment.NewLine);
            }
        }

        private void WriteMessage4(string msg)
        {
            if (this.txtThread4.InvokeRequired)
            {
                WriteMessageDelegate4 d = new WriteMessageDelegate4(WriteMessage4);
                this.txtThread4.Invoke(d, new object[] { msg });
            }
            else
            {
                this.txtThread4.AppendText(msg + Environment.NewLine);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void GetThreadNumberFormFile()
        {
            string exePath = System.Windows.Forms.Application.ExecutablePath;
            txtPath = exePath.Remove(exePath.LastIndexOf("\\"));
            txtPath = txtPath.Remove(txtPath.LastIndexOf("\\"));
            txtPath = txtPath + "\\Configuration\\ThreadNumberConfiguration.txt";
            StreamReader sr = new StreamReader(txtPath, Encoding.ASCII);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                line = line.Remove(line.LastIndexOf(";"));
                if (line.Contains(Configuration.threadNumberDiscription))
                {
                    string temp = line.Substring(Configuration.threadNumberDiscription.Length);
                    if (temp.Contains(" "))
                        temp = temp.Replace(" ", "");
                    if (temp.Contains("\t"))
                        temp = temp.Replace("\t", "");
                    Configuration.threadNumber = int.Parse(temp);
                }
            }              
        }

        private void DisplayControls()
        {
            this.btnThread1.Size = this.btnThread2.Size = this.btnThread3.Size = this.btnThread4.Size = new System.Drawing.Size(btnWidth,btnHeight);
            //this.lblThread1.Size = this.lblThread2.Size = this.lblThread3.Size = this.lblThread4.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblThread1.TextAlign = this.lblThread2.TextAlign = this.lblThread3.TextAlign = this.lblThread4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtThread1.Location = new System.Drawing.Point(toLeftRight, toTop);
            this.txtThread1.Size = new System.Drawing.Size((formWidth - toLeftRight * (Configuration.threadNumber + 1)) / Configuration.threadNumber, formHeight - toTop - toBottom);
            this.lblThread1.Location = new System.Drawing.Point(toLeftRight, (toTop + btnHeight - lblHeight) / 2);
            this.btnThread1.Location = new System.Drawing.Point(this.txtThread1.Location.X + this.txtThread1.Size.Width - btnWidth, toTop / 2);

            this.txtThread2.Location = new System.Drawing.Point(this.txtThread1.Location.X + this.txtThread1.Size.Width + toLeftRight, toTop);
            this.txtThread2.Size = this.txtThread1.Size;
            this.lblThread2.Location = new System.Drawing.Point(this.txtThread2.Location.X, (toTop + btnHeight - lblHeight) / 2);
            this.btnThread2.Location = new System.Drawing.Point(this.txtThread2.Location.X + this.txtThread2.Size.Width - btnWidth, toTop / 2);

            this.txtThread3.Location = new System.Drawing.Point(this.txtThread2.Location.X + this.txtThread2.Size.Width + toLeftRight, toTop);
            this.txtThread3.Size = this.txtThread1.Size;
            this.lblThread3.Location = new System.Drawing.Point(this.txtThread3.Location.X, (toTop + btnHeight - lblHeight) / 2);
            this.btnThread3.Location = new System.Drawing.Point(this.txtThread3.Location.X + this.txtThread3.Size.Width - btnWidth, toTop / 2);

            this.txtThread4.Location = new System.Drawing.Point(this.txtThread3.Location.X + this.txtThread3.Size.Width + toLeftRight, toTop);
            this.txtThread4.Size = this.txtThread1.Size;
            this.lblThread4.Location = new System.Drawing.Point(this.txtThread4.Location.X, (toTop + btnHeight - lblHeight) / 2);
            this.btnThread4.Location = new System.Drawing.Point(this.txtThread4.Location.X + this.txtThread4.Size.Width - btnWidth, toTop / 2);

            switch(Configuration.threadNumber)
            {            
                case 1:
                    this.txtThread1.Visible = true;
                    this.btnThread1.Visible = true;
                    this.lblThread1.Visible = true;

                    this.txtThread2.Visible = false;
                    this.btnThread2.Visible = false;
                    this.lblThread2.Visible = false;

                    this.txtThread3.Visible = false;
                    this.btnThread3.Visible = false;
                    this.lblThread3.Visible = false;

                    this.txtThread4.Visible = false;
                    this.btnThread4.Visible = false;
                    this.lblThread4.Visible = false;

                    break;

                case 2:
                    this.txtThread1.Visible = true;
                    this.btnThread1.Visible = true;
                    this.lblThread1.Visible = true;

                    this.txtThread2.Visible = true;
                    this.btnThread2.Visible = true;
                    this.lblThread2.Visible = true;

                    this.txtThread3.Visible = false;
                    this.btnThread3.Visible = false;
                    this.lblThread3.Visible = false;

                    this.txtThread4.Visible = false;
                    this.btnThread4.Visible = false;
                    this.lblThread4.Visible = false;
                    
                    break;
                case 3:
                    this.txtThread1.Visible = true;
                    this.btnThread1.Visible = true;
                    this.lblThread1.Visible = true;

                    this.txtThread2.Visible = true;
                    this.btnThread2.Visible = true;
                    this.lblThread2.Visible = true;

                    this.txtThread3.Visible = true;
                    this.btnThread3.Visible = true;
                    this.lblThread3.Visible = true;

                    this.txtThread4.Visible = false;
                    this.btnThread4.Visible = false;
                    this.lblThread4.Visible = false;

                    break;
                case 4:
                    this.txtThread1.Visible = true;
                    this.btnThread1.Visible = true;
                    this.lblThread1.Visible = true;

                    this.txtThread2.Visible = true;
                    this.btnThread2.Visible = true;
                    this.lblThread2.Visible = true;

                    this.txtThread3.Visible = true;
                    this.btnThread3.Visible = true;
                    this.lblThread3.Visible = true;

                    this.txtThread4.Visible = true;
                    this.btnThread4.Visible = true;
                    this.lblThread4.Visible = true;

                    break;
                default:
                    break;
                
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        private void MultiThreadsForm_Load(object sender, EventArgs e)
        {

        }
          

    }
}
