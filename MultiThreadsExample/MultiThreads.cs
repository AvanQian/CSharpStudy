using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading; //Semaphore
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.IO;//StreamWriter

namespace MultiThreadsExample
{
    static class MultiThreads
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            string exePath = System.Windows.Forms.Application.ExecutablePath;
            string processPath = exePath.Remove(exePath.LastIndexOf("\\"));
            processPath = processPath + "\\Login.exe";
            process.StartInfo.FileName = processPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;

            // Get program output by callbacks.
            //string processOutput = String.Empty;
            //string processError = String.Empty;
            //Semaphore semaphore = new Semaphore(1, 1);
            //process.OutputDataReceived += (sender, data) => { if (data.Data != null) { semaphore.WaitOne(); processOutput += data.Data + "\n"; semaphore.Release(); } };
            //process.ErrorDataReceived += (sender, data) => { if (data.Data != null) { semaphore.WaitOne(); processError += data.Data + "\n"; semaphore.Release(); } };

            // Open output log stream.
            //StreamWriter streamWriter = new StreamWriter(File.Open(Path.Combine(exePath.Remove(exePath.LastIndexOf("\\")) + "\\ApplicationOutput.txt"), FileMode.CreateNew));
            
            process.Start();
            process.WaitForExit();//关键，等待外部程序退出后才能往下执行
            process.Close();

            //process.BeginErrorReadLine();
            //process.BeginOutputReadLine();
            /*
            // Wait for process to finish.
            DateTime startTime = DateTime.Now;
            int keepRunning = 2;
            do
            {
                if ((DateTime.Now - startTime).TotalMilliseconds > 1000 || process.WaitForExit(1000))
                    keepRunning--;

                // Print collected output.
                semaphore.WaitOne();
                if (!String.IsNullOrEmpty(processOutput))
                    foreach (string s in processOutput.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                    {
                        streamWriter.WriteLine(s);
                    }

                if (!String.IsNullOrEmpty(processError))
                    foreach (string s in processError.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                    {
                        streamWriter.WriteLine(s);
                    }

                processOutput = String.Empty;
                processError = String.Empty;
                semaphore.Release();
            } while (keepRunning > 0);
            streamWriter.Flush();
            streamWriter.Close();

            // Do not want to have an exception after Save has been called.
            try
            {
                process.WaitForExit();   // This will ensure that asynchronous event handling has been completed
                process.Close();
                semaphore.Close();
            }
            catch
            {
                //
            }
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultiThreadsForm());
        }
    }
}
