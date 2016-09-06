using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KillProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            int killedProcesses = 0;
            bool sucess = true;
            List<string> processList = new List<string>();
            processList.Add("WinMergeU");
            processList.Add("YodaoDict");
            processList.Add("HaoZip");
            foreach (string process in processList)
            {
                // Check if fileExtension exist (.exe), if so remove
                string processName = System.IO.Path.GetFileNameWithoutExtension(process);

                //Look for process/es in current process list 
                Process[] processes = Process.GetProcessesByName(processName);

                //Loop through the list and check process Memory/PageList usage
                foreach (Process theProcess in processes)
                {
                    try
                    {
                        theProcess.Kill();
                        killedProcesses++;
                        Console.WriteLine("Killed process {0}", theProcess);
                    }
                    catch
                    {
                        Console.WriteLine("Failed to kill process {0}", theProcess);
                        sucess = false;
                    }
                    if(false == sucess)
                        Console.WriteLine("Process {0} is not active.", theProcess);
                }
            }
            Console.ReadKey();
        }
    }
}
